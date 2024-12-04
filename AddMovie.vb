Imports MySql.Data.MySqlClient

Public Class AddMovie
    ' This is the initialization logic for your form controls
    Private Sub AddMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize or reset controls as needed
        TextBox1.Clear() ' Clear the movie title text box
        TextBox2.Clear() ' Clear the file path text box
        RichTextBox1.Clear() ' Clear the synopsis text box
        TextBoxTime.Clear() ' Clear the time text box
        TextBoxAuditorium.Clear() ' Clear the auditorium text box
        NumericUpDownSeats.Value = 15 ' Set seat number to 15 (fixed value)
        DateTimePicker1.Value = DateTime.Now ' Set DateTimePicker to the current date
    End Sub

    ' Button to open file dialog and select an image for the movie poster
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                TextBox2.Text = openFileDialog.FileName ' Store file path here
            End If
        End Using
    End Sub

    ' Button to insert movie and show details into the database
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
        Dim conn As New MySqlConnection(connectionString)

        Try
            ' Validate input fields
            If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Or String.IsNullOrWhiteSpace(RichTextBox1.Text) Then
                MessageBox.Show("Please fill out all fields.")
                Exit Sub
            End If

            ' Validate show details (Date, Time, Auditorium, Number of Seats)
            If String.IsNullOrWhiteSpace(DateTimePicker1.Text) Or String.IsNullOrWhiteSpace(TextBoxTime.Text) Or String.IsNullOrWhiteSpace(TextBoxAuditorium.Text) Or NumericUpDownSeats.Value = 0 Then
                MessageBox.Show("Please fill out the show details (Date, Time, Auditorium, and Number of Seats).")
                Exit Sub
            End If

            conn.Open()

            ' Check if a movie with the same title already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM moviedetails WHERE mtitle = @Title"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@Title", TextBox1.Text)
            Dim movieCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If movieCount > 0 Then
                MessageBox.Show("A movie with this title already exists. Please enter a different title.", "Duplicate Movie")
                Exit Sub
            End If

            ' Insert the new movie into the MovieDetails table
            Dim insertMovieQuery As String = "INSERT INTO moviedetails (mtitle, mposter, mdes) VALUES (@Title, @Poster, @Synopsis)"
            Dim insertMovieCmd As New MySqlCommand(insertMovieQuery, conn)
            insertMovieCmd.Parameters.AddWithValue("@Title", TextBox1.Text)
            insertMovieCmd.Parameters.AddWithValue("@Poster", TextBox2.Text) ' Store the image path
            insertMovieCmd.Parameters.AddWithValue("@Synopsis", RichTextBox1.Text)
            insertMovieCmd.ExecuteNonQuery()

            ' Get the movie ID of the newly added movie
            Dim movieID As Integer = Convert.ToInt32(New MySqlCommand("SELECT LAST_INSERT_ID()", conn).ExecuteScalar())

            ' Insert the new show into the Shows table
            Dim insertShowQuery As String = "INSERT INTO shows (mID, date, time, auditorium) VALUES (@MovieID, @Date, @Time, @Auditorium)"
            Dim insertShowCmd As New MySqlCommand(insertShowQuery, conn)
            insertShowCmd.Parameters.AddWithValue("@MovieID", movieID)
            insertShowCmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            insertShowCmd.Parameters.AddWithValue("@Time", TextBoxTime.Text)
            insertShowCmd.Parameters.AddWithValue("@Auditorium", TextBoxAuditorium.Text)
            insertShowCmd.ExecuteNonQuery()

            ' Get the show ID of the newly added show
            Dim showID As Integer = Convert.ToInt32(New MySqlCommand("SELECT LAST_INSERT_ID()", conn).ExecuteScalar())

            ' Insert seats for the show (formatted as A1-A5, B1-B5, C1-C5)
            Dim rows As Char() = {"A"c, "B"c, "C"c} ' The 3 rows: A, B, C
            Dim seatCounter As Integer = 1

            For Each row As Char In rows
                For i As Integer = 1 To 5 ' Each row has 5 seats
                    Dim seatNumber As String = row & seatCounter.ToString() ' Create seat number like A1, B2, etc.
                    Dim insertSeatQuery As String = "INSERT INTO seats (show_id, seat_number, status) VALUES (@ShowID, @SeatNumber, @Status)"
                    Dim insertSeatCmd As New MySqlCommand(insertSeatQuery, conn)
                    insertSeatCmd.Parameters.AddWithValue("@ShowID", showID)
                    insertSeatCmd.Parameters.AddWithValue("@SeatNumber", seatNumber) ' Use the formatted seat number
                    insertSeatCmd.Parameters.AddWithValue("@Status", "Available") ' Status is always "Available" for new seats
                    insertSeatCmd.ExecuteNonQuery()
                    seatCounter += 1
                Next
            Next

            MessageBox.Show("Movie and show details saved successfully!", "Success")
            Me.Hide()
            MovieShow.Show()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    ' Button to go back to MovieShow form without saving
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        MovieShow.Show()
    End Sub

    ' Handle the form closing event
    Private Sub AddMovie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub
End Class
