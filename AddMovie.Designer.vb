<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMovie))
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        TextBox2 = New TextBox()
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        DateTimePicker1 = New DateTimePicker()
        TextBoxTime = New TextBox()
        TextBoxAuditorium = New TextBox()
        NumericUpDownSeats = New NumericUpDown()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(NumericUpDownSeats, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.InactiveCaption
        TextBox1.Location = New Point(250, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(207, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(250, 130)
        Button1.Name = "Button1"
        Button1.Size = New Size(207, 29)
        Button1.TabIndex = 2
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(250, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter title of the movie"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 12)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 3
        TextBox2.Visible = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.InactiveCaption
        RichTextBox1.Location = New Point(250, 199)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(207, 135)
        RichTextBox1.TabIndex = 4
        RichTextBox1.Text = ""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(250, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 5
        Label2.Text = "Enter synopsis"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(307, 598)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonFace
        Button3.Location = New Point(668, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 7
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(225, 365)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 8
        ' 
        ' TextBoxTime
        ' 
        TextBoxTime.BackColor = Color.Silver
        TextBoxTime.Location = New Point(227, 438)
        TextBoxTime.Name = "TextBoxTime"
        TextBoxTime.Size = New Size(248, 27)
        TextBoxTime.TabIndex = 9
        ' 
        ' TextBoxAuditorium
        ' 
        TextBoxAuditorium.BackColor = Color.Silver
        TextBoxAuditorium.Location = New Point(227, 491)
        TextBoxAuditorium.Name = "TextBoxAuditorium"
        TextBoxAuditorium.Size = New Size(248, 27)
        TextBoxAuditorium.TabIndex = 10
        ' 
        ' NumericUpDownSeats
        ' 
        NumericUpDownSeats.Location = New Point(225, 556)
        NumericUpDownSeats.Name = "NumericUpDownSeats"
        NumericUpDownSeats.Size = New Size(250, 27)
        NumericUpDownSeats.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(227, 415)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 12
        Label3.Text = "Enter time"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(227, 468)
        Label4.Name = "Label4"
        Label4.Size = New Size(175, 20)
        Label4.TabIndex = 13
        Label4.Text = "Enter auditorium number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(225, 342)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 14
        Label5.Text = "Select date"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(221, 533)
        Label6.Name = "Label6"
        Label6.Size = New Size(159, 20)
        Label6.TabIndex = 15
        Label6.Text = "Select number of seats"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Location = New Point(250, 107)
        Label7.Name = "Label7"
        Label7.Size = New Size(171, 20)
        Label7.TabIndex = 16
        Label7.Text = "Add poster of the movie"
        ' 
        ' AddMovie
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(774, 860)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(NumericUpDownSeats)
        Controls.Add(TextBoxAuditorium)
        Controls.Add(TextBoxTime)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AddMovie"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddMovie"
        CType(NumericUpDownSeats, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents TextBoxAuditorium As TextBox
    Friend WithEvents NumericUpDownSeats As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
