Imports MySql.Data.MySqlClient

Public Class ClerkLogin
    Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
    Dim conn As New MySqlConnection(connectionString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()

            ' Modified query to include position check
            Dim command As New MySqlCommand(
                "SELECT * FROM clerk WHERE cusername = @username AND cpassword = @password AND position = 'Counter Clerk'", conn)
            command.Parameters.AddWithValue("@username", TextBox1.Text)
            command.Parameters.AddWithValue("@password", TextBox2.Text)

            Dim reader = command.ExecuteReader()
            If reader.Read() Then
                MessageBox.Show("Logged in successfully", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClerkMovieShow.Show() ' Proceed to the ClerkMovieShow form
                Hide()
            Else
                MessageBox.Show("Invalid username, password, or position", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ClerkLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization logic (if needed)
    End Sub

    Private Sub ClerkLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show() ' Navigate back to the previous form (Form1)
    End Sub
End Class
