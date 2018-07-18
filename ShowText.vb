Public Class ShowText

    Private Sub ShowText_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtText.Text = sPasteStr
        txtText.SelectionLength = 0

    End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class