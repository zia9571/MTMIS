Imports MySql.Data.MySqlClient

Public Class AdminMovieShow
    Private Sub AdminMovieShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayMoviesWithPosters()
    End Sub

    Private Sub DisplayMoviesWithPosters()
        Try
            FlowLayoutPanel1.Controls.Clear() ' Clear existing items

            Dim connString As String = "server=localhost;user id=root;password='';database=mtmis;"

            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT mtitle, mposter, mdes FROM moviedetails", conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ' Retrieve data from each row
                    Dim title As String = reader("mtitle").ToString()
                    Dim posterPath As String = reader("mposter").ToString()
                    Dim synopsis As String = reader("mdes").ToString()

                    ' Create a Panel for each movie to hold the picture and labels
                    Dim moviePanel As New Panel()
                    moviePanel.Width = 150
                    moviePanel.Height = 280
                    moviePanel.Margin = New Padding(10)

                    ' Label for the movie title
                    Dim titleLabel As New Label()
                    titleLabel.Text = title
                    titleLabel.TextAlign = ContentAlignment.MiddleCenter
                    titleLabel.Dock = DockStyle.Top
                    titleLabel.AutoSize = False
                    titleLabel.Height = 25 ' Fixed height for the title
                    titleLabel.Font = New Font("Arial", 10, FontStyle.Bold)

                    ' PictureBox for the movie poster
                    Dim posterBox As New PictureBox()
                    posterBox.Width = 150
                    posterBox.Height = 180
                    posterBox.SizeMode = PictureBoxSizeMode.StretchImage ' Stretch to fit PictureBox dimensions

                    ' Load the image if the file path is valid
                    If IO.File.Exists(posterPath) Then
                        posterBox.Image = Image.FromFile(posterPath)
                    Else
                        MessageBox.Show("Poster file not found: " & posterPath)
                    End If

                    ' Button for viewing the synopsis
                    Dim synopsisButton As New Button()
                    synopsisButton.Text = "View Synopsis"
                    synopsisButton.Width = 150
                    synopsisButton.Height = 30
                    synopsisButton.Top = posterBox.Bottom ' Move the button slightly above bottom
                    synopsisButton.Anchor = AnchorStyles.Bottom

                    ' Add an event handler for the synopsis button to display the synopsis in a custom form
                    AddHandler synopsisButton.Click, Sub(sender As Object, e As EventArgs)
                                                         ShowSynopsisPopup(title, synopsis)
                                                     End Sub

                    ' Add the controls to the movie panel
                    moviePanel.Controls.Add(titleLabel) ' Add title at top
                    moviePanel.Controls.Add(posterBox)   ' Poster in center
                    moviePanel.Controls.Add(synopsisButton) ' Button at bottom

                    ' Add the movie panel to the FlowLayoutPanel
                    FlowLayoutPanel1.Controls.Add(moviePanel)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Method to show synopsis in a custom form
    Private Sub ShowSynopsisPopup(title As String, synopsis As String)
        Dim synopsisForm As New Form()
        synopsisForm.Text = title
        synopsisForm.Size = New Size(300, 250)
        synopsisForm.StartPosition = FormStartPosition.CenterParent
        synopsisForm.FormBorderStyle = FormBorderStyle.FixedDialog
        synopsisForm.MinimizeBox = False
        synopsisForm.MaximizeBox = False
        synopsisForm.ShowIcon = False
        synopsisForm.ShowInTaskbar = False

        ' Scrollable panel to hold the synopsis label
        Dim scrollablePanel As New Panel()
        scrollablePanel.Dock = DockStyle.Fill
        scrollablePanel.AutoScroll = True

        ' Label to display the synopsis, limited to panel's width for vertical scroll only
        Dim synopsisLabel As New Label()
        synopsisLabel.Text = synopsis
        synopsisLabel.AutoSize = True
        synopsisLabel.MaximumSize = New Size(280, 0) ' Set maximum width and allow height to grow
        synopsisLabel.TextAlign = ContentAlignment.TopLeft
        synopsisLabel.Padding = New Padding(10)
        synopsisLabel.Font = New Font("Arial", 10, FontStyle.Regular)

        ' Add the synopsis label to the scrollable panel
        scrollablePanel.Controls.Add(synopsisLabel)

        ' Add the scrollable panel to the form
        synopsisForm.Controls.Add(scrollablePanel)

        ' Show the form as a modal dialog
        synopsisForm.ShowDialog()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Hide()
        BookTicket.Show()
    End Sub

    Private Sub ClerkMovieShow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MovieShow.Show()
    End Sub
End Class