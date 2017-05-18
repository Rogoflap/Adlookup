Imports System.Windows.Forms

Public Class MainParent

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub ShowSCCMReports()
        For Each Child As Form In Me.MdiChildren
            If Child.Text = "SCCM Reports" Then
                Me.ActivateMdiChild(Child)
                Child.BringToFront()
                Exit Sub
            End If
        Next Child

        Dim frm As New SCCMReports
        frm.MdiParent = Me
        frm.Text = "SCCM Reports"
        frm.Show()

    End Sub
    Private Sub ShowFormUserInfo()
        If Me.MdiChildren.Count < 1 Then
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New UserInfo
            frm.MdiParent = Me
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
            Me.Cursor = Cursors.Default
        Else
            For Each Child As Form In Me.MdiChildren
                If TypeOf Child Is UserInfo Then
                    Me.ActivateMdiChild(Child)
                    Child.BringToFront()
                    Exit Sub
                End If
            Next Child

            Me.Cursor = Cursors.WaitCursor
            Dim frm As New UserInfo
            frm.MdiParent = Me
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ShowFormPrinterInfo()
        If Me.MdiChildren.Count < 1 Then
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New PrinterInfo
            frm.MdiParent = Me
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
            Me.Cursor = Cursors.Default
        Else
            For Each Child As Form In Me.MdiChildren
                If TypeOf Child Is UserInfo Then
                    Me.ActivateMdiChild(Child)
                    Child.BringToFront()
                    Exit Sub
                End If
            Next Child

            Me.Cursor = Cursors.WaitCursor
            Dim frm As New PrinterInfo
            frm.MdiParent = Me
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ShowFormComputerUserInfo()
        If Me.MdiChildren.Count < 1 Then
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New ComputerInfo
            frm.MdiParent = Me
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
            Me.Cursor = Cursors.Default
        Else
            For Each Child As Form In Me.MdiChildren
                If TypeOf Child Is ComputerInfo Then
                    Me.ActivateMdiChild(Child)
                    Child.BringToFront()
                    Exit Sub
                End If
            Next Child

            Me.Cursor = Cursors.WaitCursor
            Dim frm As New ComputerInfo
            frm.MdiParent = Me
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ShowformUserGroupInfo()
        If Me.MdiChildren.Count < 1 Then
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New UserGroupInfo
            frm.MdiParent = Me
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
            Me.Cursor = Cursors.Default
        Else
            For Each Child As Form In Me.MdiChildren
                If TypeOf Child Is UserGroupInfo Then
                    Me.ActivateMdiChild(Child)
                    Child.BringToFront()
                    Exit Sub
                End If
            Next Child

            Me.Cursor = Cursors.WaitCursor
            Dim frm As New UserGroupInfo
            frm.MdiParent = Me
            frm.Show()
            frm.WindowState = FormWindowState.Maximized
            Me.LayoutMdi(MdiLayout.TileVertical)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub tsbUser_Click(sender As System.Object, e As System.EventArgs) Handles tsbUser.Click
        ShowFormUserInfo()
    End Sub

    Private Sub MainParent_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.MainHeight = Me.Height
        My.Settings.MainWidth = Me.Width
        My.Settings.MainX = Me.Location.X
        My.Settings.MainY = Me.Location.Y

        Dim frm As Object
        For Each frm In MdiChildren
            Dim type = frm.GetType()
            If type Is GetType(UserInfo) Then
                Dim frm2 As UserInfo
                frm2 = frm
                frm2.SaveFormSettings()
            ElseIf type Is GetType(ComputerInfo) Then
                Dim frm2 As ComputerInfo
                frm2 = frm
                frm2.SaveFormSettings()
            ElseIf type Is GetType(UserGroupInfo) Then
                Dim frm2 As UserGroupInfo
                frm2 = frm
                frm2.SaveFormSettings()
            ElseIf type Is GetType(SCCMReports) Then
                Dim frm3 As SCCMReports
                frm3 = frm
                SaveFormSettings(frm3)
            End If
        Next
        My.Settings.Save()
    End Sub

    Private Sub MainParent_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            '    Me.Height = My.Settings.MainHeight
            '    Me.Width = My.Settings.MainWidth
            '    Me.Location = New Point(My.Settings.MainX, My.Settings.MainY)
            Me.WindowState = FormWindowState.Maximized
        Catch

        End Try
        sLdap = My.Settings.LDAP
        FillUserIDFullName()

        Try
            Me.Text = GetCurrentUserName() & " - Outlook Contact Lookup Ver " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
            LogError("Starting Adlookup  Ver " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build)

            If isSCCMUser(GetCurrentUserName) Then
                SCCMReportsToolStripMenuItem.Visible = True
                tsbSCCMReports.Visible = True
            Else
                SCCMReportsToolStripMenuItem.Visible = False
                tsbSCCMReports.Visible = False
            End If

            If My.Settings.UserFormOpen.ToUpper = "Y" Then
                ShowFormUserInfo()
            End If
            If My.Settings.UserGroupOpen.ToUpper = "Y" Then
                ShowformUserGroupInfo()
            End If

            If My.Settings.ComputerFormOpen.ToUpper = "Y" Then
                ShowFormComputerUserInfo()
            End If

            If My.Settings.SCCMReportOpen.ToUpper = "Y" Then
                ShowSCCMReports()
            End If

            My.Settings.ComputerFormOpen = "N"
            My.Settings.UserFormOpen = "N"
            My.Settings.UserGroupOpen = "N"
            My.Settings.Save()

            'DameWareRemoteExists()

            Me.LayoutMdi(MdiLayout.TileHorizontal)

        Catch ex As Exception
            LogError("Error Loading Main form: " & ex.Message)
        End Try

    End Sub

    Private Sub tsbUserGroup_Click(sender As Object, e As System.EventArgs) Handles tsbUserGroup.Click
        ShowformUserGroupInfo()
    End Sub

    Private Sub tbComputerInfo_Click(sender As System.Object, e As System.EventArgs) Handles tbComputerInfo.Click
        ShowFormComputerUserInfo()
    End Sub

    Private Sub tsbSCCMReports_Click(sender As System.Object, e As System.EventArgs) Handles tsbSCCMReports.Click
        ShowSCCMReports()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm As New SplashScreen1
        frm.ShowDialog()
    End Sub

    Private Sub GridResultsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GridResultsToolStripMenuItem.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        Dim ctrl As Control
        For Each ctrl In activeChild.Controls
            If ctrl.GetType() Is GetType(DataGridView) Then
                PrintDGV.Print_DataGridView(ctrl)
            End If
        Next
    End Sub

    Private Sub SCCMReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SCCMReportsToolStripMenuItem.Click
        ShowSCCMReports()
    End Sub

    Private Sub UserInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UserInfoToolStripMenuItem.Click
        ShowFormUserInfo()
    End Sub

    Private Sub ComputerInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComputerInfoToolStripMenuItem.Click
        ShowFormComputerUserInfo()
    End Sub

    Private Sub UserGroupInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UserGroupInfoToolStripMenuItem.Click
        ShowformUserGroupInfo()
    End Sub

    Private Sub tsbSendSuggestion_Click(sender As System.Object, e As System.EventArgs) Handles tsbSendSuggestion.Click
        Dim frm As New SendSuggestion
        frm.ShowDialog()
    End Sub

    Private Sub BugFixesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BugFixesToolStripMenuItem.Click
        Dim frm As New BugFixes
        frm.ShowDialog()
    End Sub

    Private Sub tsbExact_Click(sender As Object, e As EventArgs) Handles tsbExact.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New GeneralData
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbPrinterInfo_Click(sender As Object, e As EventArgs) Handles tsbPrinterInfo.Click
        ShowFormPrinterInfo()
    End Sub

    Private Sub EmpowerEmailButton_Click(sender As Object, e As EventArgs) Handles EmpowerEmailButton.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New EmpowerEmail
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
        Me.Cursor = Cursors.Default
    End Sub
End Class
