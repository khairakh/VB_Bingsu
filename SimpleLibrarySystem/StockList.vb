Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Public Class StockList
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String

    Private Sub StockList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\bingsu.mdb"
        con.Open()
        sql = "SELECT * FROM bingsu"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "bingsu")
        DataGridView1.DataSource = ds.Tables("bingsu")
    End Sub

    Private Sub user_btnSearch_Click(sender As Object, e As EventArgs) Handles user_btnSearch.Click
        ds.Clear()


        If user_cboCategory.Text = "All" Then

            sql = "SELECT * FROM bingsu"

        ElseIf user_cboCategory.Text = "Ingredient" Then

            sql = "SELECT * FROM bingsu WHERE Category = '" & user_cboCategory.Text & "'"

        ElseIf user_cboCategory.Text = "Toppings" Then

            sql = "SELECT * FROM bingsu WHERE Category = '" & user_cboCategory.Text & "'"

        ElseIf user_cboCategory.Text = "Flavour" Then

            sql = "SELECT * FROM bingsu WHERE Category = '" & user_cboCategory.Text & "'"

        ElseIf user_cboCategory.Text = "Ice Cream Base" Then

            sql = "SELECT * FROM bingsu WHERE Category = '" & user_cboCategory.Text & "'"

        ElseIf user_cboCategory.Text = "Handpacked" Then

            sql = "SELECT * FROM bingsu WHERE Category = '" & user_cboCategory.Text & "'"

        End If
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "bingsu")

    End Sub

    Private Sub printStockListBtn_Click(sender As Object, e As EventArgs) Handles printStockListBtn.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        e.Graphics.DrawString("==============BINGSU MANAGEMENT SYSTEM==============", New Font("Century Gothic", 11), Brushes.Black, 50, 80)
        e.Graphics.DrawString("======================Latest List of Stock======================", New Font("Century Gothic", 10), Brushes.Black, 50, 100)
        DataGridView1.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imagebmp, 10, 170)

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        MainMenu.Show()

    End Sub
End Class