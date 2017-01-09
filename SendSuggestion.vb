Public Class SendSuggestion


    Private Sub BtnSend_Click(sender As System.Object, e As System.EventArgs) Handles BtnSend.Click
        Try
            sendMail("ADLOOKUP " & cbType.SelectedItem & ": " & Me.txtSubject.Text, tbBody.Text, "Rogoflap@gmail.com")
            MsgBox("Message was sent successfully.", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            LogError("Error Sending Message: " & txtSubject.Text & vbCrLf & tbBody.Text & vbCrLf & ex.Message)
            MsgBox("Error Sending Message: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class