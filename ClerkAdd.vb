Imports MySql.Data.MySqlClient

Public Class ClerkAdd
    Dim connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub ClerkAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with positions
        ComboBox1.Items.AddRange(New String() {
            "Admin (Manager)", "Counter Clerk", "Projectionist", "Usher",
            "Concessions Staff", "Box Office Staff", "Cleaners/Janitorial Staff",
            "Security Personnel", "Marketing/Promotions Staff", "Maintenance Technicians",
            "Guest Services/Customer Support", "Event Coordinator", "IT Support Staff",
            "Inventory Manager", "Advertising Specialist", "Special Effects/Event Technicians"
        })
        ComboBox1.SelectedIndex = 0 ' Set default selection
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Validate input fields
            If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
               String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
               String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
               ComboBox1.SelectedIndex = -1 Then
                MessageBox.Show("Please fill out all fields.")
                Exit Sub
            End If

            ' Check if the username already exists in the clerk table
            Dim checkQuery = "SELECT COUNT(*) FROM clerk WHERE cusername = @cusername"
            Dim checkCmd As New MySqlCommand(checkQuery, connection)
            checkCmd.Parameters.AddWithValue("@cusername", TextBox1.Text)

            connection.Open()
            Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If userCount > 0 Then
                MessageBox.Show("The username already exists. Please choose a different username.")
                Exit Sub
            End If

            ' Insert new employee into the clerk table
            Dim insertQuery = "INSERT INTO clerk (cusername, cpassword, position, phone_number) 
                               VALUES (@cusername, @cpassword, @position, @phone_number)"
            Dim insertCmd As New MySqlCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@cusername", TextBox1.Text)
            insertCmd.Parameters.AddWithValue("@cpassword", TextBox2.Text)
            insertCmd.Parameters.AddWithValue("@position", ComboBox1.SelectedItem.ToString())
            insertCmd.Parameters.AddWithValue("@phone_number", TextBox3.Text)

            insertCmd.ExecuteNonQuery()

            ' Check if the selected position is "Admin (Manager)"
            If ComboBox1.SelectedItem.ToString() = "Admin (Manager)" Then
                ' Insert the username and password into the admin table
                Dim insertAdminQuery = "INSERT INTO admin (username, password) VALUES (@username, @password)"
                Dim insertAdminCmd As New MySqlCommand(insertAdminQuery, connection)
                insertAdminCmd.Parameters.AddWithValue("@username", TextBox1.Text)
                insertAdminCmd.Parameters.AddWithValue("@password", TextBox2.Text)

                insertAdminCmd.ExecuteNonQuery()
                MessageBox.Show("Admin (Manager) credentials added successfully to the admin table.")
            End If

            MessageBox.Show("New employee added successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding employee: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CinemaLocation.Show()
        Me.Hide()
    End Sub

    Private Sub ClerkAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub
End Class
