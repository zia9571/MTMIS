Imports MySql.Data.MySqlClient

Public Class MovieShow
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MovieShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        AddMovie.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim name As String
        name = InputBox("Please enter the name of the movie:", "Name Input")

        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("No name entered.", "Input Error")
        Else
            Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
            Dim conn As New MySqlConnection(connectionString)

            Try
                conn.Open()

                ' Get the movie ID for the specified movie
                Dim movieIDQuery As String = "SELECT mID FROM moviedetails WHERE mtitle=@Title"
                Dim movieIDCmd As New MySqlCommand(movieIDQuery, conn)
                movieIDCmd.Parameters.AddWithValue("@Title", name)
                Dim movieID As Object = movieIDCmd.ExecuteScalar()

                If movieID Is Nothing Then
                    MessageBox.Show("Movie not found.", "Error")
                    Exit Sub
                End If

                ' Get all show IDs associated with the movie
                Dim showIDsQuery As String = "SELECT show_id FROM shows WHERE mID=@MovieID"
                Dim showIDsCmd As New MySqlCommand(showIDsQuery, conn)
                showIDsCmd.Parameters.AddWithValue("@MovieID", movieID)
                Dim reader As MySqlDataReader = showIDsCmd.ExecuteReader()
                Dim showIDs As New List(Of Integer)()

                While reader.Read()
                    showIDs.Add(reader.GetInt32("show_id"))
                End While
                reader.Close()

                ' Delete related bookings for each show ID
                For Each showID As Integer In showIDs
                    Dim deleteBookingsQuery As String = "DELETE FROM bookings WHERE show_id=@ShowID"
                    Dim deleteBookingsCmd As New MySqlCommand(deleteBookingsQuery, conn)
                    deleteBookingsCmd.Parameters.AddWithValue("@ShowID", showID)
                    deleteBookingsCmd.ExecuteNonQuery()
                Next

                ' Delete related seats for each show ID
                For Each showID As Integer In showIDs
                    Dim deleteSeatsQuery As String = "DELETE FROM seats WHERE show_id=@ShowID"
                    Dim deleteSeatsCmd As New MySqlCommand(deleteSeatsQuery, conn)
                    deleteSeatsCmd.Parameters.AddWithValue("@ShowID", showID)
                    deleteSeatsCmd.ExecuteNonQuery()
                Next

                ' Delete related shows
                Dim deleteShowsQuery As String = "DELETE FROM shows WHERE mID=@MovieID"
                Dim deleteShowsCmd As New MySqlCommand(deleteShowsQuery, conn)
                deleteShowsCmd.Parameters.AddWithValue("@MovieID", movieID)
                deleteShowsCmd.ExecuteNonQuery()

                ' Delete the movie
                Dim deleteMovieQuery As String = "DELETE FROM moviedetails WHERE mID=@MovieID"
                Dim deleteMovieCmd As New MySqlCommand(deleteMovieQuery, conn)
                deleteMovieCmd.Parameters.AddWithValue("@MovieID", movieID)
                deleteMovieCmd.ExecuteNonQuery()

                MessageBox.Show("Movie and all related records removed successfully.", "Success")

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error")
            Finally
                conn.Close()
            End Try
        End If
    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub


    Private Sub MovieShow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminMovieShow.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        CinemaLocation.Show()
    End Sub
End Class