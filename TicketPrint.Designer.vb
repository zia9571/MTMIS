<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketPrint))
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        ComboBoxTicketID = New ComboBox()
        ButtonPrint = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' ComboBoxTicketID
        ' 
        ComboBoxTicketID.FormattingEnabled = True
        ComboBoxTicketID.Location = New Point(164, 275)
        ComboBoxTicketID.Name = "ComboBoxTicketID"
        ComboBoxTicketID.Size = New Size(266, 28)
        ComboBoxTicketID.TabIndex = 0
        ' 
        ' ButtonPrint
        ' 
        ButtonPrint.BackColor = Color.LavenderBlush
        ButtonPrint.FlatStyle = FlatStyle.Popup
        ButtonPrint.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonPrint.ForeColor = SystemColors.InactiveCaptionText
        ButtonPrint.Location = New Point(164, 345)
        ButtonPrint.Name = "ButtonPrint"
        ButtonPrint.Size = New Size(266, 79)
        ButtonPrint.TabIndex = 1
        ButtonPrint.Text = "PRINT"
        ButtonPrint.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.HotPink
        Button1.Location = New Point(22, 474)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TicketPrint
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(586, 515)
        Controls.Add(Button1)
        Controls.Add(ButtonPrint)
        Controls.Add(ComboBoxTicketID)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "TicketPrint"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TicketPrint"
        ResumeLayout(False)
    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ComboBoxTicketID As ComboBox
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents Button1 As Button
End Class
