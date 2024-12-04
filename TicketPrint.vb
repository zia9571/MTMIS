Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class TicketPrint
    Private connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
    Private connection As New MySqlConnection(connectionString)

    ' Declared variables to hold ticket details
    Public ticketID As String
    Public customerName As String
    Public customerPhone As String
    Public seatNumbers As String
    Public ticketPrice As String
    Public auditorium As String
    Public movieDay As String
    Public movieTime As String
    Public showID As String

    Private isComboBoxLoaded As Boolean = False ' Flag to prevent premature event triggering

    Private Sub TicketPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()

            ' Fetch distinct ticket IDs for ComboBox
            Dim query As String = "SELECT ticket_id, CONCAT('Ticket ID: ', ticket_id, ' | Customer: ', customer_name) AS ticket_details FROM ticket"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind the ComboBox to the data
            ComboBoxTicketID.DataSource = dt
            ComboBoxTicketID.DisplayMember = "ticket_details" ' What user sees
            ComboBoxTicketID.ValueMember = "ticket_id"       ' What gets stored
        Catch ex As Exception
            MessageBox.Show("Please wait a second" & ex.Message, "Loading")
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ComboBoxTicketID_DropDown(sender As Object, e As EventArgs) Handles ComboBoxTicketID.DropDown
        isComboBoxLoaded = True
    End Sub

    Private Sub ComboBoxTicketID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTicketID.SelectedIndexChanged
        If Not isComboBoxLoaded Then Return

        If ComboBoxTicketID.SelectedIndex <> -1 Then
            Dim selectedRow As DataRowView = CType(ComboBoxTicketID.SelectedItem, DataRowView)
            Dim selectedTicketID As Integer = CInt(selectedRow("ticket_id"))

            Try
                If connection.State = ConnectionState.Open Then connection.Close()
                connection.Open()

                Dim query As String = "SELECT * FROM ticket WHERE ticket_id = @ticket_id"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@ticket_id", selectedTicketID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ticketID = reader("ticket_id").ToString()
                    customerName = reader("customer_name").ToString()
                    customerPhone = reader("customer_phone_number").ToString()
                    seatNumbers = reader("seat_numbers").ToString()
                    ticketPrice = reader("ticket_price").ToString()
                    auditorium = reader("auditorium").ToString()
                    movieDay = Convert.ToDateTime(reader("day")).ToShortDateString()
                    movieTime = reader("time").ToString()
                    showID = reader("show_id").ToString()
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error fetching ticket details: " & ex.Message, "Database Error")
            Finally
                If connection.State = ConnectionState.Open Then connection.Close()
            End Try
        End If
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        If String.IsNullOrEmpty(ticketID) Then
            MessageBox.Show("Please select a valid ticket ID before printing.", "Error")
            Return
        End If

        ' Create and configure the Print Preview Dialog
        Dim printPreviewDialog As New PrintPreviewDialog
        printPreviewDialog.Document = PrintDocument1

        ' Safely cast the PrintPreviewControl from the dialog
        Try
            ' Access the PrintPreviewControl inside the PrintPreviewDialog
            Dim previewControl As PrintPreviewControl = Nothing

            For Each control As Control In printPreviewDialog.Controls
                If TypeOf control Is PrintPreviewControl Then
                    previewControl = CType(control, PrintPreviewControl)
                    Exit For
                End If
            Next

            ' Set the zoom level if the control is found
            If previewControl IsNot Nothing Then
                previewControl.Zoom = 0.75 ' Set zoom level to 75%
            End If

        Catch ex As Exception
            MessageBox.Show("Error setting zoom level: " & ex.Message, "Error")
        End Try

        ' Display the Print Preview Dialog
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer = 50
        Dim y As Integer = 50
        Dim largeFont As New Font("Arial", 18, FontStyle.Bold)
        Dim mediumFont As New Font("Arial", 14)
        Dim smallFont As New Font("Arial", 10)

        ' Print decorative border
        e.Graphics.DrawRectangle(Pens.Black, x - 10, y - 10, 700, 400)

        ' Title
        e.Graphics.DrawString("MOVIE TICKET", largeFont, Brushes.Black, x + 250, y)
        y += 40

        ' Ticket details
        e.Graphics.DrawString($"Ticket ID: {ticketID}", mediumFont, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString($"Customer Name: {customerName}", mediumFont, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString($"Phone: {customerPhone}", mediumFont, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString($"Seats: {seatNumbers}", mediumFont, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString($"Price: {ticketPrice}", mediumFont, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString($"Auditorium: {auditorium}", mediumFont, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString($"Day: {movieDay}", mediumFont, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString($"Time: {movieTime}", mediumFont, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString($"Show ID: {showID}", mediumFont, Brushes.Black, x, y)
        y += 40

        ' Footer
        e.Graphics.DrawString("Enjoy your movie!", smallFont, Brushes.Black, x + 250, y)
    End Sub

    Private Sub TicketPrint_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Booking.Show()
    End Sub
End Class
