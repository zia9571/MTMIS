<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovieShow))
        Button9 = New Button()
        Button10 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(277, 142)
        Button9.Name = "Button9"
        Button9.Size = New Size(164, 29)
        Button9.TabIndex = 17
        Button9.Text = "Add Movie"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(277, 189)
        Button10.Name = "Button10"
        Button10.Size = New Size(164, 29)
        Button10.TabIndex = 18
        Button10.Text = "Remove Movie"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(220, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(277, 33)
        Button1.TabIndex = 19
        Button1.Text = "View Movie Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Varsity Regular", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(106, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(558, 57)
        Label1.TabIndex = 20
        Label1.Text = "MANAGE MOVIE SHOWS"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(12, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 29)
        Button2.TabIndex = 21
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' MovieShow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(246))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(773, 650)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MovieShow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MovieShow"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
