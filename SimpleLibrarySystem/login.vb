Public Class login
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If (txtUser.Text = "admin" And txtPass.Text = "admin") Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class