Public Class AdminInfo
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        sAdminUserName = txtUserName.Text
        sAdminPassword = txtPassword.Text
        MsgBox("Admin Info Changed.")
        Me.Close()
    End Sub
End Class