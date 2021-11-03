Imports System.Data.SqlClient
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

End Class