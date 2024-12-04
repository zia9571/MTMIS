Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class BookTicket
    Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedShowId As Integer = GetSelectedShowId()
        LoadSeats(selectedShowId)
    End Sub
    Public Class ComboBoxItem
        Public Property Text As String
        Public Property Value As Integer
        Public Overrides Function ToString() As String
            Return Text  ' Display text in the ComboBox
        End Function
    End Class
    Private Sub LoadMovies()
        Try
            Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
            Dim conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim query As String = "SELECT mID, mtitle FROM moviedetails"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ComboBox1.Items.Clear()
            While reader.Read()
                Dim item As New ComboBoxItem() With {
                .Text = reader("mtitle").ToString(),
                .Value = reader("mID")
            }
                ComboBox1.Items.Add(item)
            End While
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show($"Error loading movies: {ex.Message}")
        End Try
    End Sub
    Private Sub LoadDates()
        ComboBox2.Items.Clear() ' Clear existing items in ComboBox2

        ' Check if a valid item is selected in ComboBox1
        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a movie first.")
            Return ' Exit the method if no movie is selected
        End If

        Try
            ' Get the selected movie ID from ComboBox1 using ComboBoxItem
            Dim selectedMovieItem As ComboBoxItem = CType(ComboBox1.SelectedItem, ComboBoxItem)
            Dim selectedMovieId As Integer = selectedMovieItem.Value

            ' Set up the database connection
            Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
            Dim connection As New MySqlConnection(connectionString)

            connection.Open()

            ' Prepare the SQL query to get unique dates for the selected movie
            Dim query As String = "SELECT DISTINCT date FROM shows WHERE mID = @mID"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@mID", selectedMovieId)

            ' Execute the query and populate ComboBox2 with the dates
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ComboBox2.Items.Add(reader("date").ToString())
            End While

            reader.Close()
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error loading dates: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTimes()
        ComboBox3.Items.Clear() ' Clear existing items in ComboBox3

        ' Check if a valid item is selected in ComboBox1
        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a movie first.")
            Return
        End If

        Try
            ' Get the selected movie ID from ComboBox1
            Dim selectedMovieItem As ComboBoxItem = CType(ComboBox1.SelectedItem, ComboBoxItem)
            Dim selectedMovieId As Integer = selectedMovieItem.Value

            ' Prepare the SQL query to get unique time-date combinations for the selected movie
            Dim query As String = "SELECT DISTINCT CONCAT(date, ' ', time) AS showtime FROM shows WHERE mID = @mID"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@mID", selectedMovieId)

            connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ComboBox3.Items.Add(reader("showtime").ToString())
            End While
            reader.Close()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading times: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub
    Private Sub LoadAuditoriums()
        ComboBox4.Items.Clear() ' Clear existing items in ComboBox4

        ' Ensure ComboBox1 and ComboBox3 have valid selections
        If ComboBox1.SelectedItem Is Nothing Or ComboBox3.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a movie and showtime first.")
            Return
        End If

        Try
            ' Get the selected movie ID and showtime
            Dim selectedMovieId As ComboBoxItem = CType(ComboBox1.SelectedItem, ComboBoxItem)
            Dim selectedShowTime = ComboBox3.SelectedItem.ToString()

            ' Split the combined date and time (e.g., "2024-11-20 14:00:00")
            Dim datePart As String = selectedShowTime.Split(" "c)(0)
            Dim timePart As String = selectedShowTime.Split(" "c)(1)

            ' Debugging: Display intermediate values
            MessageBox.Show($"Movie ID: {selectedMovieId.Value}, Date: {datePart}, Time: {timePart}")

            ' Set up the database connection
            Using connection As New MySqlConnection("Server=localhost;Database=mtmis;userid=root;password=''")
                connection.Open() ' Open the connection

                ' Prepare the SQL query to get auditoriums
                Dim query As String = "SELECT DISTINCT auditorium FROM shows WHERE mID = @mID AND date = @date AND time = @time"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@mID", selectedMovieId.Value)
                cmd.Parameters.AddWithValue("@date", datePart)
                cmd.Parameters.AddWithValue("@time", timePart)

                ' Execute the query
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Populate ComboBox4 with the results
                Dim rowCount As Integer = 0
                While reader.Read()
                    ComboBox4.Items.Add(reader("auditorium").ToString())
                    rowCount += 1
                End While

                ' Debugging: Display the number of rows returned
                MessageBox.Show($"Number of auditoriums found: {rowCount}")

                reader.Close() ' Close the reader
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading auditoriums: " & ex.Message)
        End Try
    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadDates()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        LoadTimes()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        LoadAuditoriums()
    End Sub
    Private Function GetSelectedShowId() As Integer
        Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password='';"
        Using connection As New MySqlConnection(connectionString)
            Try
                ' Validate ComboBox selections
                If ComboBox1.SelectedItem Is Nothing Then
                    MessageBox.Show("Please select a movie.")
                    Return -1
                End If
                Dim selectedMovieId As ComboBoxItem = CType(ComboBox1.SelectedItem, ComboBoxItem)

                If ComboBox2.SelectedItem Is Nothing Then
                    MessageBox.Show("Please select a date.")
                    Return -1
                End If
                ' Parse and format the selected date
                Dim selectedDate = DateTime.Parse(ComboBox2.SelectedItem.ToString()).ToString("yyyy-MM-dd")

                If ComboBox3.SelectedItem Is Nothing Then
                    MessageBox.Show("Please select a time.")
                    Return -1
                End If
                ' Parse and format the selected time
                Dim selectedTime = DateTime.Parse(ComboBox3.SelectedItem.ToString()).ToString("HH:mm:ss")

                If ComboBox4.SelectedItem Is Nothing Then
                    MessageBox.Show("Please select an auditorium.")
                    Return -1
                End If
                Dim selectedAuditorium = ComboBox4.SelectedItem.ToString()

                ' Debugging: Display query parameter values
                MessageBox.Show($"Movie ID: {selectedMovieId.Value}, Date: {selectedDate}, Time: {selectedTime}, Auditorium: {selectedAuditorium}")

                ' Define the SQL query
                Dim query As String = "SELECT show_id FROM shows WHERE mID = @mID AND date = @date AND time = @time AND auditorium = @auditorium"
                Dim cmd As New MySqlCommand(query, connection)

                ' Add parameters
                cmd.Parameters.AddWithValue("@mID", selectedMovieId.Value)
                cmd.Parameters.AddWithValue("@date", selectedDate)
                cmd.Parameters.AddWithValue("@time", selectedTime)
                cmd.Parameters.AddWithValue("@auditorium", selectedAuditorium)

                ' Execute the query
                connection.Open()
                Dim result = cmd.ExecuteScalar()

                ' Check the query result
                If result Is Nothing Then
                    MessageBox.Show("No matching show found in the database.")
                    Return -1
                End If

                Return Convert.ToInt32(result)

            Catch ex As Exception
                ' Handle and display any exceptions
                MessageBox.Show($"Error: {ex.Message}")
                Return -1
            End Try
        End Using
    End Function

    Private Sub LoadSeats(showId As Integer)
        FlowLayoutPanel1.Controls.Clear() ' Clear existing seat buttons

        ' Connection string for the database
        Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password='';"
        Dim connection As New MySqlConnection(connectionString)

        Dim query As String = "SELECT seat_id, seat_number, status FROM seats WHERE show_id = @show_id"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@show_id", showId)

        Try
            connection.Open() ' Open the connection

            Dim reader As MySqlDataReader = cmd.ExecuteReader() ' Execute the query

            ' Read the results and create seat buttons
            While reader.Read()
                Dim seatButton As New Button()
                seatButton.Text = reader("seat_number").ToString() ' Display seat number
                seatButton.Tag = reader("seat_id") ' Store seat ID in the button's Tag property

                ' Set the button's appearance and behavior based on seat status
                If reader("status").ToString().ToLower() = "available" Then
                    seatButton.BackColor = Color.Green ' Green for available seats
                    AddHandler seatButton.Click, AddressOf SeatButton_Click
                Else
                    seatButton.BackColor = Color.Red ' Red for unavailable seats
                    seatButton.Enabled = False
                End If

                ' Add the button to the FlowLayoutPanel
                FlowLayoutPanel1.Controls.Add(seatButton)
            End While

            reader.Close() ' Close the reader after use
        Catch ex As Exception
            ' Display the error message
            MessageBox.Show("Error loading seats: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub SeatButton_Click(sender As Object, e As EventArgs)
        Dim seatButton As Button = CType(sender, Button)
        seatButton.BackColor = If(seatButton.BackColor = Color.Green, Color.Yellow, Color.Green)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedShowId = GetSelectedShowId()

        If selectedShowId = -1 Then
            ' No valid show selected, exit the process
            Return
        End If

        Dim selectedSeats As New List(Of String)

        ' Loop through each button in FlowLayoutPanel1 to check if it’s selected (yellow color)
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is Button Then
                Dim seatButton = CType(control, Button)
                ' Only book seats that are selected (yellow)
                If seatButton.BackColor = Color.Yellow Then
                    Dim seatId = Integer.Parse(seatButton.Tag.ToString)
                    selectedSeats.Add(seatButton.Text)

                    ' Update seat status to 'booked' in the seats table
                    Dim query = "UPDATE seats SET status = 'booked' WHERE seat_id = @seat_id"
                    Dim cmd As New MySqlCommand(query, connection)

                    Try
                        connection.Open()
                        cmd.Parameters.AddWithValue("@seat_id", seatId)
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("Error booking seat: " & ex.Message)
                    Finally
                        connection.Close()
                    End Try

                    ' Insert booking details into the bookings table
                    Dim bookingQuery = "INSERT INTO bookings (show_id, seat_number) VALUES (@show_id, @seat_number)"
                    Dim bookingCmd As New MySqlCommand(bookingQuery, connection)

                    Try
                        connection.Open()
                        bookingCmd.Parameters.AddWithValue("@show_id", selectedShowId)
                        bookingCmd.Parameters.AddWithValue("@seat_number", seatButton.Text)
                        bookingCmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("Error inserting booking: " & ex.Message)
                    Finally
                        connection.Close()
                    End Try
                End If
            End If
        Next

        ' Display the selected seats in a message box
        If selectedSeats.Count > 0 Then
            MessageBox.Show("You have selected the following seats: " & String.Join(", ", selectedSeats), "Selected Seats")
        Else
            MessageBox.Show("No seats selected. Please select seats to book.", "No Selection")
            Return
        End If

        ' Open the Booking form and hide the current form
        Dim bookingForm As New Booking
        bookingForm.Show()
        Hide()
    End Sub



    Private Sub BookTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMovies()
    End Sub


    Private Sub BookTicket_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        ClerkMovieShow.Show()
    End Sub
End Class