<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookTicket))
        FlowLayoutPanel1 = New FlowLayoutPanel()
        ComboBox1 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        ComboBox2 = New ComboBox()
        Label1 = New Label()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(386, 12)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(482, 197)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(328, 28)
        ComboBox1.TabIndex = 1
        ComboBox1.Text = "Select Movie"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(12, 123)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(328, 28)
        ComboBox3.TabIndex = 3
        ComboBox3.Text = "Select Time"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(12, 181)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(328, 28)
        ComboBox4.TabIndex = 4
        ComboBox4.Text = "Select Auditorium"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(87, 242)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 104)
        Button1.TabIndex = 5
        Button1.Text = "Show Seats"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(386, 282)
        Button2.Name = "Button2"
        Button2.Size = New Size(482, 64)
        Button2.TabIndex = 6
        Button2.Text = "Book Seats"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(12, 62)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(328, 28)
        ComboBox2.TabIndex = 2
        ComboBox2.Text = "Select Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(458, 194)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 41)
        Label1.TabIndex = 0
        Label1.Text = "               SCREEN             "
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.Desktop
        Button4.FlatStyle = FlatStyle.Popup
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(12, 369)
        Button4.Name = "Button4"
        Button4.Size = New Size(141, 29)
        Button4.TabIndex = 8
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' BookTicket
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(880, 410)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(FlowLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "BookTicket"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BookTicket"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
End Class
