<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoxOffice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BoxOffice))
        btnGenerateReport = New Button()
        dgvReport = New DataGridView()
        btnExportToCSV = New Button()
        Button1 = New Button()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGenerateReport
        ' 
        btnGenerateReport.BackColor = Color.Salmon
        btnGenerateReport.FlatStyle = FlatStyle.Popup
        btnGenerateReport.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGenerateReport.Location = New Point(238, 262)
        btnGenerateReport.Name = "btnGenerateReport"
        btnGenerateReport.Size = New Size(330, 97)
        btnGenerateReport.TabIndex = 0
        btnGenerateReport.Text = "Generate Box-Office Report"
        btnGenerateReport.UseVisualStyleBackColor = False
        ' 
        ' dgvReport
        ' 
        dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReport.Location = New Point(186, 12)
        dgvReport.Name = "dgvReport"
        dgvReport.RowHeadersWidth = 51
        dgvReport.Size = New Size(427, 234)
        dgvReport.TabIndex = 1
        ' 
        ' btnExportToCSV
        ' 
        btnExportToCSV.BackColor = Color.DarkTurquoise
        btnExportToCSV.FlatStyle = FlatStyle.Flat
        btnExportToCSV.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExportToCSV.Location = New Point(238, 365)
        btnExportToCSV.Name = "btnExportToCSV"
        btnExportToCSV.Size = New Size(330, 97)
        btnExportToCSV.TabIndex = 2
        btnExportToCSV.Text = "Convert to CSV "
        btnExportToCSV.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(519, 469)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 3
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BoxOffice
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(622, 510)
        Controls.Add(Button1)
        Controls.Add(btnExportToCSV)
        Controls.Add(dgvReport)
        Controls.Add(btnGenerateReport)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "BoxOffice"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BoxOffice"
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents btnExportToCSV As Button
    Friend WithEvents Button1 As Button
End Class
