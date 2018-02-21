Imports System.DirectoryServices
Imports System.Management
Imports System.DirectoryServices.AccountManagement
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Data.SqlClient

Public Class UserInfo

    Dim iRowSelected As Integer
    Public dt As DataTable
    Public dtf As DataTable
    Public dtMemberof As DataTable
    Public sDataTableType As String
    Public sFormtype As String
    Dim sUserSelected As String

    Private Sub SetColumnWidths()
        Dim i As Integer = 0
        Dim iWidth As Integer = 20
        For i = 0 To DataGridView1.ColumnCount - 1
            Select Case UCase(DataGridView1.Columns(i).HeaderText).Trim
                Case "NAME"
                    iWidth = 148
                Case "TELEPHONE"
                    iWidth = 82
                Case "EMAIL"
                    iWidth = 117
                Case "USERID"
                    iWidth = 52
                Case "TITLE"
                    iWidth = 55
                Case "STREETADDRESS"
                    iWidth = 100
                Case "ACCT"
                    iWidth = 102
                Case "HOMEDIRECTORY"
                    iWidth = 149
                Case "MEMBEROF"
                    iWidth = 175
                Case "OU"
                    iWidth = 292
                Case "OS"
                    iWidth = 166
                Case "SP"
                    iWidth = 100
                Case "SERVICEPRINCIPAL"
                    iWidth = 302
                Case "GROUPNAME"
                    iWidth = 192
                Case Else
                    iWidth = 120

            End Select

            DataGridView1.Columns(i).Width = iWidth
        Next
    End Sub

    Public Sub OpenNewEmail(sEmail As String)
        Dim SShell As String = ""
        Try
            SShell = "Mailto:" & sEmail
            Process.Start(SShell)
        Catch ex As Exception
            LogError("Error Opening New Email" & ex.Message & vbTab & ex.StackTrace)
        End Try

    End Sub

    Public Sub ShowUserSummary(sUserId As String)
        Dim scommand As String = "net users " & sUserId & " /domain"
        Try
            MsgBox(ParseString(RunDosCommand(scommand), "USERINFO"), MsgBoxStyle.Information, "AD User Info for " & sUserId)
            Exit Sub
        Catch ex As Exception
            LogError("Error Getting User Summary " & scommand & vbCrLf & ex.Message & vbTab & ex.StackTrace)
        End Try
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            'sSiteID = Me.cmbSite.SelectedItem.ToString

            Dim dclist As New List(Of String)
            dclist = GetDomainControllers()
            For Each itm As String In dclist
                cbdomainlist.Items.Add(itm)
            Next
            cbdomainlist.SelectedIndex = 1
            SetLdap(My.Settings.LDAP)

            lblDomain.Text = sLdap

            RefreshGrid()
            Me.Text = "USER INFO"
            Me.Height = My.Settings.UserFormHeight
            Me.Width = My.Settings.UserFormWidth
            Me.Location = New Point(My.Settings.UserFormX, My.Settings.UserFormY)

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            LogError("Form UserInfo Load Error " & ex.Message)
            sendMail("ADLookup Error on UserInfo form Load.", ex.Message)
            MsgBox("Error." & vbCrLf & ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub FilterGrid()
        Dim sTemp As String = ""

        Dim sOperator As String = " Like "

        Try

            sTemp = ""
            If Me.txtUserName.Text.Length > 0 Then
                sTemp = "userid like '*" & Me.txtUserName.Text & "*'"
            End If

            If Me.txtName.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and Name like '*" & Me.txtName.Text & "*'"
                Else
                    sTemp += " Name like '*" & Me.txtName.Text & "*'"
                End If
            End If

            If Me.txtemail.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and email like '*" & Me.txtemail.Text & "*'"
                Else
                    sTemp += "email like '*" & Me.txtemail.Text & "*'"
                End If
            End If

            If Me.txtPhone.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and telephone like '*" & Me.txtPhone.Text & "*'"
                Else
                    sTemp += "telephone like '*" & Me.txtPhone.Text & "*'"
                End If
            End If

            If Me.txtTitle.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and Title like '*" & Me.txtTitle.Text & "*'"
                Else
                    sTemp += "Title like '*" & Me.txtTitle.Text & "*'"
                End If
            End If

            If Me.txtAddress.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and StreetAddress like '*" & Me.txtAddress.Text & "*'"
                Else
                    sTemp += "StreetAddress like '*" & Me.txtAddress.Text & "*'"
                End If
            End If

            If Me.txtLoc.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and LOC like '*" & Me.txtLoc.Text & "*'"
                Else
                    sTemp += "LOC like '*" & Me.txtLoc.Text & "*'"
                End If
            End If

            If txtStatus.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and Status like '*" & Me.txtStatus.Text & "*'"
                Else
                    sTemp += "Status like '*" & Me.txtStatus.Text & "*'"
                End If
            End If

            If txtCompany.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and Company like '*" & Me.txtCompany.Text & "*'"
                Else
                    sTemp += " Company like '*" & Me.txtCompany.Text & "*'"
                End If
            End If

            If txtManager.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and Manager like '*" & Me.txtManager.Text & "*'"
                Else
                    sTemp += " Manager like '*" & Me.txtManager.Text & "*'"
                End If
            End If

            If Me.txtUserMemberOf.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and memberof like '*" & Me.txtUserMemberOf.Text & "*'"
                Else
                    sTemp += "memberof like '*" & Me.txtUserMemberOf.Text & "*'"
                End If
            End If

            If Me.txtUserOU.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and OU like '*" & Me.txtUserOU.Text & "*'"
                Else
                    sTemp += "OU like '*" & Me.txtUserOU.Text & "*'"
                End If
            End If

            Dim DV As New DataView(dt)
            DV.RowFilter = sTemp
            dtf = DV.ToTable
            DataGridView1.DataSource = dtf
            SetRowsFound()
        Catch ex As Exception
            MsgBox("Error In Filter." & vbCrLf & ex.Message)
            LogError("Filter Error " & ex.Message)
        End Try
    End Sub

    Public Sub SetRowsFound()
        Me.tsslStatus.Text = "Rows Found: " & DataGridView1.RowCount
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs)
        Me.txtUserName.Text = ""
        Me.txtemail.Text = ""
        Me.txtName.Text = ""
        Me.txtPhone.Text = ""
        Me.DataGridView1.DataSource = dt
        SetRowsFound()
    End Sub

    Private Sub filterKeyUp(sender As Object, e As System.EventArgs) Handles txtName.KeyUp, txtPhone.KeyUp, txtemail.KeyUp, txtUserName.KeyUp, txtTitle.KeyUp, txtAddress.KeyUp, txtCompany.KeyUp,
        txtLoc.KeyUp, txtUserMemberOf.KeyUp, txtUserOU.KeyUp, txtManager.KeyUp, txtStatus.KeyUp
        FilterGrid()
    End Sub

    Private Sub txtPhone_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        FilterGrid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        iRowSelected = e.RowIndex
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Select Case UCase(Me.DataGridView1.Columns(e.ColumnIndex).HeaderText)
                Case "USERID"
                    ShowUserSummary(DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value)
                Case "EMAIL"
                    OpenNewEmail(DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value)
            End Select
        Catch ex As Exception
            LogError("Error Sending Email from Grid Doubleclick" & ex.Message & vbTab & ex.StackTrace)
            sendMail("Error Sending Email from Grid Doubleclick", ex.Message & vbTab & ex.StackTrace)
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveDataXML()
    End Sub

    Private Sub ReadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReadToolStripMenuItem.Click
        LoadXMLData()
    End Sub

    Private Sub RefreshGridToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshGridToolStripMenuItem.Click
        RefreshGrid()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Public Sub RefreshGrid()
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.DataGridView1.DataSource = Nothing
            Me.DataGridView1.Refresh()

            LabelHeader.Text = "AD User Info"
            dt = GetUserADInfo(cbAddMemberofInfo.Checked)
            Me.DataGridView1.ContextMenuStrip = Me.cmsUser
            If cbLocalContacts.Checked Then
                GetContactsLocal(dt)
                SetRowsFound()
            End If

            If cbAddMemberofInfo.Checked Then
                lblMemberOf.Visible = True
                lbluserou.Visible = True
                txtUserMemberOf.Visible = True
                txtUserOU.Visible = True
            Else
                lblMemberOf.Visible = False
                lbluserou.Visible = False
                txtUserMemberOf.Visible = False
                txtUserOU.Visible = False
            End If

            DataGridView1.DataSource = dt
            dtf = dt
            SetColumnWidths()
            dtf = dt.Copy
            SetRowsFound()
        Catch ex As Exception
            LogError(ex.Message)
        Finally
            Me.labelLastUpdate.Text = "Last Refreshed: " & Now
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GetADGroupInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim sGroup As String = ""
        Dim sCommand As String = ""
        sGroup = InputBox("Enter AD Group Name", "Enter AD Group Name")
        sCommand = "NET GROUP " & Chr(34) & sGroup & Chr(34) & " /Domain"
        MsgBox(ParseString(RunDosCommand(sCommand)), MsgBoxStyle.Information, "Ad Group Info for Group " & sGroup)

    End Sub

    Public Sub ShowMemberOfSummary(iRow As Integer)
        If iRow > 0 Then
            Dim frm As New ShowInfo
            Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.Rows(iRow)
            'frm.txtInfo.Text = dataGridViewRow1.Cells("Name").Value.ToString
            frm.Text = "Members of group " & dataGridViewRow1.Cells("name").Value.ToString
            frm.lblListCaption.Text = "G Info for: " & dataGridViewRow1.Cells("name").Value.ToString
            frm.ShowDialog()
        End If
    End Sub

    Private Sub DataGridView1_CellToolTipTextNeeded(sender As Object, e As System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs) Handles DataGridView1.CellToolTipTextNeeded
        Dim newLine As String = Environment.NewLine
        Try
            If e.RowIndex > -1 And e.ColumnIndex = 9 Then
                Dim dataGridViewRow1 As DataGridViewRow =
                DataGridView1.Rows(e.RowIndex)

                ' Add the employee's ID to the ToolTipText.
                e.ToolTipText = "Group Names for  " & dataGridViewRow1.Cells("name").Value.ToString & newLine & dataGridViewRow1.Cells("MemberOf").Value.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub ShowColumnWidthsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
    '    Dim sOut As String
    '    Dim i As Integer = 0

    '    For i = 0 To DataGridView1.ColumnCount - 1
    '        With DataGridView1
    '            sOut += .Columns(i).HeaderText & " : " & .Columns(i).Width & vbCrLf
    '        End With
    '    Next

    '    Debug.Print("Column Widths" & vbCrLf & sOut)


    'End Sub


    Private Sub ResetColumWidthsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        SetColumnWidths()
    End Sub

    Private Sub ShowColumnWidthsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        Dim sOut As String = ""
        Dim i As Integer = 0

        For i = 0 To DataGridView1.ColumnCount - 1
            With DataGridView1
                sOut += .Columns(i).HeaderText & " : " & .Columns(i).Width & vbCrLf
            End With
        Next
        MsgBox("Column Widths" & vbCrLf & sOut)
    End Sub

    Private Sub ShowLogsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New ShowLog
        frm.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Shell("adlookup help.pdf")
    End Sub

    Private Sub AllRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem.Click
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, True)
    End Sub

    Private Sub SelectedRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem.Click
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, False)
    End Sub

    Private Sub DataGridView1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            DataGridView1.Rows(e.RowIndex).Selected = True
            sUserSelected = DataGridView1.Rows(e.RowIndex).Cells("UserID").Value
            'MsgBox("User: " & DataGridView1.Rows(e.RowIndex).Cells("UserID").Value & " was selected.")
        End If
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDown

        'ShowUserInfoSummaryToolStripMenuItem.Visible = False
        'ShowMemberOfInfoToolStripMenuItem.Visible = False

        'For i = 0 To DataGridView1.ColumnCount - 1
        '    If DataGridView1.Columns(i).HeaderText.ToUpper = "MEMBEROF" Then
        '        ShowMemberOfInfoToolStripMenuItem.Visible = True
        '    End If
        '    If DataGridView1.Columns(i).HeaderText.ToUpper = "USERID" Then
        '        ShowUserInfoSummaryToolStripMenuItem.Visible = True
        '    End If
        'Next

        ' Code for checking what cell was clicked....
        'If e.Button = Windows.Forms.MouseButtons.Right Then
        '    Dim hit As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)
        '    iRowSelected = hit.RowIndex
        '    If UCase(Me.DataGridView1.Columns(Me.DataGridView1.HitTest(e.X, e.Y).ColumnIndex).Name) = "USERID" Then
        '        ShowUserInfoSummaryToolStripMenuItem.Visible = True
        '    Else
        '        ShowUserInfoSummaryToolStripMenuItem.Visible = False
        '    End If
        '    If UCase(Me.DataGridView1.Columns(Me.DataGridView1.HitTest(e.X, e.Y).ColumnIndex).Name) = "MEMBEROF" Then
        '        ShowMemberOfInfoToolStripMenuItem.Visible = True

        '    Else
        '        ShowMemberOfInfoToolStripMenuItem.Visible = False
        '    End If

        'End If

    End Sub

    Private Sub ShowUserInfoSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowUserInfoSummaryToolStripMenuItem.Click
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.Rows(iRowSelected)
        If dataGridViewRow1.Cells("USERID").Value.ToString.Trim.Length > 0 Then
            ShowUserSummary(dataGridViewRow1.Cells("USERID").Value.ToString)
        End If
    End Sub

    Private Sub ShowMemberOfInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowMemberOfInfoToolStripMenuItem.Click
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.Rows(iRowSelected)
        If dataGridViewRow1.Cells("Name").Value.ToString.Trim.Length > 0 Then
            ShowMemberOfSummary(iRowSelected)
        End If
    End Sub

    Private Sub AllRowsToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs)
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, True)
    End Sub

    Private Sub SelectedRowsToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs)
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, False)
    End Sub

    Private Sub cbdomainlist_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbdomainlist.SelectedIndexChanged
        SetLdap(cbdomainlist.SelectedItem)
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(dtf)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbRefresh_Click(sender As System.Object, e As System.EventArgs) Handles tsbRefresh.Click
        RefreshGrid()
    End Sub

    Private Sub filterKeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtUserOU.KeyUp, txtUserName.KeyUp, txtUserMemberOf.KeyUp, txtPhone.KeyUp, txtName.KeyUp, txtTitle.KeyUp, txtManager.KeyUp, txtemail.KeyUp, txtAddress.KeyUp, txtLoc.KeyUp, txtCompany.KeyUp, txtStatus.KeyUp

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None Then
            Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Else
            Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        End If
    End Sub

    Public Sub SaveFormSettings()

        My.Settings.UserFormOpen = "Y"
        My.Settings.UserFormHeight = Me.Height
        My.Settings.UserFormWidth = Me.Width
        My.Settings.UserFormX = Me.Location.X
        My.Settings.UserFormY = Me.Location.Y
        My.Settings.Save()
    End Sub

    Public Sub GetFormSettings()
        Dim iHeight As Integer
        Dim iWidth As Integer
        Dim iX As Integer
        Dim iY As Integer

        If My.Settings.UserFormOpen.ToUpper = "Y" Then
            iHeight = My.Settings.UserGroupHeight
            iWidth = My.Settings.UserFormWidth
            iX = My.Settings.UserFormX
            iY = My.Settings.UserFormY
        End If

        Me.Location = New Point(iX, iY)
        Me.Width = iWidth
        Me.Height = iHeight
    End Sub

    Private Sub cbAddMemberofInfo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbAddMemberofInfo.CheckedChanged
        If cbAddMemberofInfo.Checked Then
            RefreshGrid()
        End If
    End Sub

    Private Sub AllRowsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        'ExportToExcel(dtf)
        ExportToExcel(DataGridView1)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SelectedRowsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        'ExportToExcel(dtf)
        ExportToExcel(DataGridView1, True)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cbLocalContacts_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbLocalContacts.CheckedChanged
        RefreshGrid()
    End Sub

    Private Sub CopyCtrlCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCtrlCToolStripMenuItem.Click
        My.Computer.Keyboard.SendKeys("^{C}")
    End Sub

    Private Sub ResetPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.CurrentRow
        Dim sPassword As String
        If dataGridViewRow1.Cells("USERID").Value.ToString.Trim.Length > 0 Then
            sPassword = InputBox("New Password for :" & sUserSelected, "Reset Password for :" & sUserSelected, My.Settings.DefaultPassword)
            If sPassword.Length > 0 Then
                MsgBox(ResetPassword(sPassword, sUserSelected), vbInformation)
            Else
                MsgBox("Password Reset Canceled.", vbInformation)
            End If
        End If
    End Sub

    Private Sub UnlockPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnlockPasswordToolStripMenuItem.Click
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.CurrentRow
        If dataGridViewRow1.Cells("USERID").Value.ToString.Trim.Length > 0 Then
            MsgBox(AdUnlockUser(sUserSelected))
        End If
    End Sub


End Class
