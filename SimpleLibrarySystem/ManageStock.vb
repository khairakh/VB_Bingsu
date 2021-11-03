Public Class ManageStock
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim counter As Integer
    Dim MaxRec As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Include this code in Private Sub Form1_Load.
        'This line of code calls the database you have created:
        con.ConnectionString = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\bingsu.mdb"
        con.Open()

        'This line of code enables you to access your database.
        sql = "SELECT * FROM bingsu"

        da = New OleDb.OleDbDataAdapter(sql, con)

        'This line adds or refreshes rows in the System.Data.DataSet to match those in the data source using the System.Data.DataSet and System.Data.DataTable names.
        MaxRec = da.Fill(ds, "bingsu")

        'This represents the lblNumRec.text
        counter = 0

        'This line counts the rows in the table
        MaxRec = ds.Tables("bingsu").Rows.Count

        'This signifies the Maximum number of Records in the table.
        user_lblMaxRec.Text = MaxRec

        'This line of code calls a private sub function called fillrecords
        fillrecords()
        ProgressBar1.Hide()
        user_lblRefresh.Hide()
    End Sub
    'This lines of code handles the filling of data from the form to the database.
    Private Sub fillrecords()

        user_txtID.Text = ds.Tables("bingsu").Rows(0).Item(0)
        user_txtName.Text = ds.Tables("bingsu").Rows(0).Item(1)
        user_txtQuantity.Text = ds.Tables("bingsu").Rows(0).Item(2)

    End Sub

    'This lines of code handles the navigation records.
    Private Sub navigaterecords()

        user_txtID.Text = ds.Tables("bingsu").Rows(counter).Item(0)
        user_txtName.Text = ds.Tables("bingsu").Rows(counter).Item(1)
        user_txtQuantity.Text = ds.Tables("bingsu").Rows(counter).Item(2)

    End Sub

    Private Sub user_btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnFirst.Click
        counter = 0
        navigaterecords()

        user_lblNumRec.Text = 1
    End Sub

    Private Sub user_btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnPrevious.Click
        If counter = 0 Then
            Exit Sub
        Else
            counter = counter - 1
            navigaterecords()
        End If
        user_lblNumRec.Text = counter + 1
    End Sub

    Private Sub user_btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnNext.Click
        If counter = MaxRec - 1 Then
            Exit Sub
        Else
            counter = counter + 1
            navigaterecords()
        End If
        user_lblNumRec.Text = counter + 1
    End Sub

    Private Sub user_btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnLast.Click
        counter = MaxRec - 1
        navigaterecords()
        user_lblNumRec.Text = MaxRec
    End Sub

    Private Sub user_btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnSave.Click
        If counter <> -1 Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("bingsu").NewRow()

            dsNewRow.Item("ID") = user_txtID.Text
            dsNewRow.Item("Name") = user_txtName.Text
            dsNewRow.Item("Quantity") = user_txtQuantity.Text
            dsNewRow.Item("Category") = user_cboCategory.Text


            ds.Tables("bingsu").Rows.Add(dsNewRow)

            da.Update(ds, "bingsu")
        End If
        MsgBox("Add Successful")

    End Sub

    Private Sub user_btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnEdit.Click
        user_txtName.Enabled = True
        user_txtQuantity.Enabled = True
        user_txtID.Enabled = False
    End Sub

    Private Sub user_btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnDelete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)


        ds.Tables("bingsu").Rows(counter).Delete()
        MaxRec = MaxRec - 1

        counter = 0

        da.Update(ds, "bingsu")
        navigaterecords()

        user_lblNumRec.Text = 1

        user_lblMaxRec.Text = MaxRec
    End Sub

    Private Sub user_btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnCancel.Click
        counter = 0
        navigaterecords()
        ProgressBar1.Hide()
        Timer1.Stop()
        user_txtID.Enabled = True
    End Sub

    Private Sub user_btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnSearch.Click
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


        MaxRec = ds.Tables("bingsu").Rows.Count
        counter = 0
        user_lblMaxRec.Text = MaxRec
        user_lblNumRec.Text = 1

        fillrecords()
    End Sub

    Private Sub user_btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnAddNew.Click
        user_txtID.Clear()
        user_txtName.Clear()
        user_txtQuantity.Clear()
    End Sub

    Private Sub user_btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("bingsu").Rows(counter).Item(0) = user_txtID.Text
        ds.Tables("bingsu").Rows(counter).Item(1) = user_txtName.Text
        ds.Tables("bingsu").Rows(counter).Item(2) = user_txtQuantity.Text
        ds.Tables("bingsu").Rows(counter).Item(3) = user_cboCategory.Text


        da.Update(ds, "bingsu")
        MsgBox("Update Successful")
    End Sub

    Private Sub user_btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnRefresh.Click


        MaxRec = ds.Tables("bingsu").Rows.Count
        counter = 0
        user_lblMaxRec.Text = MaxRec
        user_lblNumRec.Text = 1
        Timer1.Start()
        ProgressBar1.Show()
        user_lblRefresh.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(100)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()



            MaxRec = ds.Tables("bingsu").Rows.Count
            counter = 0
            user_lblMaxRec.Text = MaxRec
            user_lblNumRec.Text = 1
            fillrecords()
            MsgBox("Refreshed!")
            ProgressBar1.Hide()
            ProgressBar1.Value = 0
            user_lblRefresh.Hide()
        End If
    End Sub

    Private Sub user_btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btnClose.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

End Class
