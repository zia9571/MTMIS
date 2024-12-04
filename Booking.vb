Imports MySql.Data.MySqlClient

Public Class Booking
    Private connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
    Private connection As New MySqlConnection(connectionString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the customer's name and phone number
        Dim customerName As String = TextBox1.Text.Trim()
        Dim customerPhone As String = TextBox2.Text.Trim()
        Dim seatNumbers As String = TextBox3.Text.Trim() ' Seat numbers input (comma-separated)

        ' Validate inputs
        If String.IsNullOrWhiteSpace(customerName) Then
            MessageBox.Show("Please enter the customer's name.", "Input Error")
            Return
        End If

        If String.IsNullOrWhiteSpace(customerPhone) Then
            MessageBox.Show("Please enter the customer's phone number.", "Input Error")
            Return
        End If

        If String.IsNullOrWhiteSpace(seatNumbers) Then
            MessageBox.Show("Please enter at least one seat number.", "Input Error")
            Return
        End If

        ' Split seat numbers by comma and trim spaces
        Dim seatList As List(Of String) = seatNumbers.Split(","c).Select(Function(seat) seat.Trim()).ToList()

        ' If no valid seats are provided, show an error
        If seatList.Count = 0 Then
            MessageBox.Show("Please enter valid seat numbers.", "Input Error")
            Return
        End If

        Dim customerId As Integer
        Dim showId As Integer = CInt(ComboBoxShows.SelectedValue) ' Get the selected show_id from ComboBoxShows

        Try
            connection.Open()

            ' Check if customer already exists
            Dim checkCustomerQuery As String = "SELECT customer_id FROM customers WHERE phone_number = @phone_number"
            Dim checkCustomerCmd As New MySqlCommand(checkCustomerQuery, connection)
            checkCustomerCmd.Parameters.AddWithValue("@phone_number", customerPhone)

            Dim result = checkCustomerCmd.ExecuteScalar()

            If result IsNot Nothing Then
                ' Customer exists, get their ID
                customerId = Convert.ToInt32(result)
            Else
                ' Insert new customer
                Dim insertCustomerQuery As String = "INSERT INTO customers (name, phone_number) VALUES (@name, @phone_number)"
                Dim insertCustomerCmd As New MySqlCommand(insertCustomerQuery, connection)
                insertCustomerCmd.Parameters.AddWithValue("@name", customerName)
                insertCustomerCmd.Parameters.AddWithValue("@phone_number", customerPhone)
                insertCustomerCmd.ExecuteNonQuery()

                ' Get the ID of the newly inserted customer
                customerId = CInt(insertCustomerCmd.LastInsertedId)
            End If

            ' Fetch show details using selected show from ComboBoxShows
            Dim showDetailsQuery As String = "SELECT auditorium, date, time FROM shows WHERE show_id = @show_id"
            Dim showCmd As New MySqlCommand(showDetailsQuery, connection)
            showCmd.Parameters.AddWithValue("@show_id", showId)

            Dim reader = showCmd.ExecuteReader()

            Dim auditorium As String = ""
            Dim movieDay As Date
            Dim movieTime As TimeSpan

            If reader.Read() Then
                auditorium = reader("auditorium").ToString()
                movieDay = Convert.ToDateTime(reader("date"))
                movieTime = TimeSpan.Parse(reader("time").ToString())
            End If
            reader.Close()

            ' Insert booking details for each seat number
            For Each seatNumber In seatList
                Dim insertBookingQuery As String = "INSERT INTO bookings (customer_id, show_id, seat_number) VALUES (@customer_id, @show_id, @seat_number)"
                Dim insertBookingCmd As New MySqlCommand(insertBookingQuery, connection)
                insertBookingCmd.Parameters.AddWithValue("@customer_id", customerId)
                insertBookingCmd.Parameters.AddWithValue("@show_id", showId)
                insertBookingCmd.Parameters.AddWithValue("@seat_number", seatNumber)

                insertBookingCmd.ExecuteNonQuery()
            Next

            ' Calculate ticket price based on the number of booked seats for the customer and show
            Dim totalSeats As Integer = seatList.Count
            Dim ticketPrice As Integer = 200 * totalSeats

            ' Insert ticket details into the ticket table, including seat numbers
            Dim ticketQuery As String = "INSERT INTO ticket (ticket_price, customer_name, customer_phone_number, auditorium, day, time, seat_numbers, show_id) VALUES (@ticket_price, @customer_name, @customer_phone, @auditorium, @day, @time, @seat_numbers, @show_id)"
            Dim ticketCmd As New MySqlCommand(ticketQuery, connection)

            ticketCmd.Parameters.AddWithValue("@ticket_price", ticketPrice)
            ticketCmd.Parameters.AddWithValue("@customer_name", customerName)
            ticketCmd.Parameters.AddWithValue("@customer_phone", customerPhone)
            ticketCmd.Parameters.AddWithValue("@auditorium", auditorium)
            ticketCmd.Parameters.AddWithValue("@day", movieDay)
            ticketCmd.Parameters.AddWithValue("@time", movieTime)
            ticketCmd.Parameters.AddWithValue("@seat_numbers", String.Join(",", seatList)) ' Join seat numbers with commas
            ticketCmd.Parameters.AddWithValue("@show_id", showId)

            ticketCmd.ExecuteNonQuery()

            ' Success message
            MessageBox.Show($"Tickets for seats {String.Join(", ", seatList)} have been successfully booked!", "Success")

            ' Get the ID of the newly inserted ticket
            Dim ticketId As Integer = CInt(ticketCmd.LastInsertedId)

            ' Display the ticket ID to the user
            MessageBox.Show($"The ticket has been successfully booked! Your Ticket ID is: {ticketId}. Use this ID to print the ticket.", "Ticket ID Information")

            ' Reset form fields
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear() ' Clear seat number input
            ComboBoxShows.SelectedIndex = -1 ' Reset ComboBox selection

        Catch ex As Exception
            MessageBox.Show("Error while booking tickets: " & ex.Message, "Database Error")
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            ' Query to fetch show details
            Dim query As String = "SELECT show_id, CONCAT(date, ' | ', time, ' | ', auditorium) AS show_details FROM shows"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind the ComboBox to the data
            ComboBoxShows.DataSource = dt
            ComboBoxShows.DisplayMember = "show_details" ' What user sees
            ComboBoxShows.ValueMember = "show_id"       ' What gets stored
        Catch ex As Exception
            MessageBox.Show("Loading")
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        TicketPrint.Show()
    End Sub
    Private Sub Booking_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        BookTicket.Show()
    End Sub
End Class
