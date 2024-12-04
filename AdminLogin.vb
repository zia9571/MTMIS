Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class AdminLogin
    Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
    Dim conn As New MySqlConnection(connectionString)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim command As New MySqlCommand("SELECT * FROM admin WHERE username = @username AND password = @password", conn)
        command.Parameters.AddWithValue("@username", TextBox1.Text)
        command.Parameters.AddWithValue("@password", TextBox2.Text)
        Dim reader = command.ExecuteReader
        If reader.Read Then
            MessageBox.Show("Logged in successfully", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CinemaLocation.Show()
            Hide()
        Else
            MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
    End Sub
    Private Sub AdminLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class