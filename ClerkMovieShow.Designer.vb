<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClerkMovieShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClerkMovieShow))
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button9 = New Button()
        Button10 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Varsity Regular", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(164, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(475, 72)
        Label1.TabIndex = 34
        Label1.Text = "NOW SHOWING"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Location = New Point(26, 117)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(758, 374)
        FlowLayoutPanel1.TabIndex = 35
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(658, 82)
        Button9.Name = "Button9"
        Button9.Size = New Size(126, 29)
        Button9.TabIndex = 36
        Button9.Text = "Book Show"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(26, 82)
        Button10.Name = "Button10"
        Button10.Size = New Size(126, 29)
        Button10.TabIndex = 37
        Button10.Text = "Go Back"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' ClerkMovieShow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(826, 500)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ClerkMovieShow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ClerkMovieShow"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
