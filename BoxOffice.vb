Imports MySql.Data.MySqlClient
Imports System.IO

Public Class BoxOffice

    Private connectionString As String = "Server=localhost;Database=mtmis;userid=root;password=''"
    Private connection As New MySqlConnection(connectionString)

    ' Generate Box-Office Report
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            connection.Open()

            ' SQL Query to calculate monthly box-office collections
            Dim query = "SELECT MONTH(day) AS Month, YEAR(day) AS Year, SUM(ticket_price) AS MonthlyCollection " &
                                  "FROM ticket " &
                                  "GROUP BY YEAR(day), MONTH(day) " &
                                  "ORDER BY YEAR(day), MONTH(day);"

            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable

            adapter.Fill(dt)

            ' Bind the DataGridView to the DataTable
            dgvReport.DataSource = dt

            ' Set column headers for better understanding
            dgvReport.Columns("Month").HeaderText = "Month"
            dgvReport.Columns("Year").HeaderText = "Year"
            dgvReport.Columns("MonthlyCollection").HeaderText = "Box-Office Collection"

        Catch ex As Exception
            MessageBox.Show("Error fetching report: " & ex.Message, "Database Error")
        Finally
            connection.Close()
        End Try
    End Sub

    ' Export the report to a CSV file
    Private Sub btnExportToCSV_Click(sender As Object, e As EventArgs) Handles btnExportToCSV.Click
        Try
            ' Open a SaveFileDialog to specify the file name and location
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
            saveFileDialog.Title = "Save Box-Office Report"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName

                Using writer As New StreamWriter(filePath)
                    ' Write column headers
                    For Each column As DataGridViewColumn In dgvReport.Columns
                        writer.Write(column.HeaderText & ",")
                    Next
                    writer.WriteLine()

                    ' Write rows
                    For Each row As DataGridViewRow In dgvReport.Rows
                        If Not row.IsNewRow Then
                            For Each cell As DataGridViewCell In row.Cells
                                writer.Write(cell.Value?.ToString() & ",")
                            Next
                            writer.WriteLine()
                        End If
                    Next
                End Using

                MessageBox.Show("Report exported successfully!", "Success")
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting report: " & ex.Message, "Export Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CinemaLocation.Show()
    End Sub
    Private Sub BoxOffice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Close the entire application
        Application.Exit()
    End Sub
End Class
