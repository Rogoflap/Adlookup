Imports Microsoft.Office.Interop


Public Class Mail
    Private Sub Mail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub GetEmail()
        Dim tempApp As Outlook.Application
        Dim tempInbox As Outlook.MAPIFolder
        Dim InboxItems As Outlook.Items
        'Dim objattachments, objAttach
        tempApp = CreateObject("Outlook.Application")
        tempInbox = tempApp.GetNamespace("Mapi").GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox)
        InboxItems = tempInbox.Items
        Dim newMail As Outlook.MailItem
        For Each newMail In InboxItems
            If newMail.UnRead Then
                Dim des As String = newMail.Body
                'if u want to delete
                'newMail.Delete()
            End If
        Next
        InboxItems = Nothing
        tempInbox = Nothing
        tempApp = Nothing
    End Sub
End Class