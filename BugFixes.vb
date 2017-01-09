Public Class BugFixes

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BugFixes_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\ReadMe.txt")
        Catch ex As Exception
            LogError("Error Showing ItemsFixed.txt. " & ex.Message)
        End Try

    End Sub
End Class