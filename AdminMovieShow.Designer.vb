<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMovieShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMovieShow))
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button9 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Varsity Regular", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(179, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(475, 72)
        Label1.TabIndex = 35
        Label1.Text = "NOW SHOWING"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Location = New Point(28, 95)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(758, 374)
        FlowLayoutPanel1.TabIndex = 36
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(660, 58)
        Button9.Name = "Button9"
        Button9.Size = New Size(126, 29)
        Button9.TabIndex = 37
        Button9.Text = "Book Show"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(28, 58)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 29)
        Button1.TabIndex = 38
        Button1.Text = "Go Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AdminMovieShow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(826, 500)
        Controls.Add(Button1)
        Controls.Add(Button9)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AdminMovieShow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminMovieShow"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button1 As Button
End Class
