Public Class MainMenu
    Private Sub ManageStockToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ManageStock.Show()
        Me.Hide()
    End Sub

    Private Sub DisplayStockListToolStripMenuItem_Click(sender As Object, e As EventArgs)
        StockList.Show()
    End Sub

    Private Sub user_btnAbout_Click(sender As Object, e As EventArgs) Handles user_btnAbout.Click
        MsgBox(" Welcome to Bingsu Management System! We are from group 3 decided to create An Ice Cream Shop Management System. ")
    End Sub

    Private Sub manageStockBtn_Click(sender As Object, e As EventArgs) Handles manageStockBtn.Click
        ManageStock.Show()
        Me.Hide()
    End Sub

    Private Sub displayStockListBtn_Click(sender As Object, e As EventArgs) Handles displayStockListBtn.Click
        StockList.Show()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Close()
    End Sub
End Class