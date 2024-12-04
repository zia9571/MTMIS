<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking))
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button3 = New Button()
        ComboBoxShows = New ComboBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(229, 263)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(192, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(195, 201)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 35)
        Label1.TabIndex = 1
        Label1.Text = "BOOKING"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(174, 266)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(115, 299)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 4
        Label3.Text = "Phone Number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(229, 296)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(192, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Goldenrod
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(115, 396)
        Button1.Name = "Button1"
        Button1.Size = New Size(306, 29)
        Button1.TabIndex = 5
        Button1.Text = "Book Tickets"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Goldenrod
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(115, 445)
        Button3.Name = "Button3"
        Button3.Size = New Size(306, 29)
        Button3.TabIndex = 6
        Button3.Text = "Print Ticket"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxShows
        ' 
        ComboBoxShows.FormattingEnabled = True
        ComboBoxShows.Location = New Point(115, 362)
        ComboBoxShows.Name = "ComboBoxShows"
        ComboBoxShows.Size = New Size(306, 28)
        ComboBoxShows.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(229, 329)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(192, 27)
        TextBox3.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(127, 336)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 20)
        Label4.TabIndex = 10
        Label4.Text = "Seat Number"
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ControlLightLight
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Goldenrod
        Button4.Location = New Point(12, 510)
        Button4.Name = "Button4"
        Button4.Size = New Size(106, 29)
        Button4.TabIndex = 11
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Booking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(530, 551)
        Controls.Add(Button4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(ComboBoxShows)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Booking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Booking"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBoxShows As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
End Class
