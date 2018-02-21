Imports System.DirectoryServices
Imports System.Management
Imports System.DirectoryServices.AccountManagement
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Data.SqlClient

Public Class UserGroupInfo
    Dim iRowSelected As Integer
    Public dt As DataTable
    Public dtf As DataTable
    Public dtMemberof As DataTable

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

            Dim dclist As New List(Of String)
            dclist = GetDomainControllers()
            For Each itm As String In dclist
                cbdomainlist.Items.Add(itm)
            Next
            cbdomainlist.SelectedIndex = 1
            SetLdap(My.Settings.LDAP)

            lblDomain.Text = sLdap

            RefreshGrid()
            Me.Text = "USER GROUP INFO"
            Me.Height = My.Settings.UserGroupHeight
            Me.Width = My.Settings.UserGroupWidth
            Me.Location = New Point(My.Settings.UserGroupX, My.Settings.UserGroupY)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            LogError("Form UserGroupInfo Load Error " & ex.Message)
            sendMail("ADLookup UserGroupInfo Error on Form Load.", ex.Message)
            MsgBox("Error." & vbCrLf & ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub FilterGrid()
        Dim sTemp As String = ""
        Try


            sTemp = ""
            If Me.txtFullName.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and Name like '*" & Me.txtFullName.Text & "*'"
                Else
                    sTemp += " Name like '*" & Me.txtFullName.Text & "*'"
                End If
            End If


            If Me.txtMembers.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and Members like '*" & Me.txtMembers.Text & "*'"
                Else
                    sTemp += " Members like '*" & Me.txtMembers.Text & "*'"
                End If
            End If


            If Me.txtMail.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and Mail like '*" & Me.txtMail.Text & "*'"
                Else
                    sTemp += " Mail like '*" & Me.txtMail.Text & "*'"
                End If
            End If

            If Me.txtMemberOf.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and MemberOf like '*" & Me.txtMemberOf.Text & "*'"
                Else
                    sTemp += " MemberOf like '*" & Me.txtMemberOf.Text & "*'"
                End If
            End If

            If Me.txtDescription.Text.Length > 0 Then
                If sTemp.Length > 0 Then
                    sTemp += " and Description like '*" & Me.txtDescription.Text & "*'"
                Else
                    sTemp += " Description like '*" & Me.txtDescription.Text & "*'"
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

    Private Sub filterKeyUp(sender As Object, e As System.EventArgs) Handles txtFullName.KeyUp, txtDescription.KeyUp, txtMembers.KeyUp, txtMemberOf.KeyUp, txtMail.KeyUp
        FilterGrid()
    End Sub

    Private Sub txtPhone_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        FilterGrid()
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

            LabelHeader.Text = "AD User Group Info"
            Me.DataGridView1.ContextMenuStrip = Me.cmsUser
            dt = GetGroupInfo()
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

    Public Sub ShowMembersOfGroup(sGroupName As String)

        Dim frm As New ShowInfo
        frm.dgv1.DataSource = GetMembersOfGroup(sGroupName)
        frm.Text = "Members of Group " & sGroupName
        frm.lblListCaption.Text = "Members of Group " & sGroupName
        frm.ShowDialog()

    End Sub


    Public Sub ShowMemberOfSummary(iRow As Integer)
        If iRow > 0 Then
            Dim frm As New ShowInfo
            Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.Rows(iRow)
            frm.txtInfo.Text = dataGridViewRow1.Cells("MemberOf").Value.ToString
            frm.Text = "Group Info for: " & dataGridViewRow1.Cells("name").Value.ToString
            frm.lblListCaption.Text = "Group Info for: " & dataGridViewRow1.Cells("name").Value.ToString
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

    Private Sub DataGridView1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDown

        ShowUserInfoSummaryToolStripMenuItem.Visible = True
        ShowMemberOfInfoToolStripMenuItem.Visible = False

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

    Private Sub ShowMemberOfInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowUserInfoSummaryToolStripMenuItem.Click
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.CurrentRow
        If dataGridViewRow1.Cells("Name").Value.ToString.Trim.Length > 0 Then
            ShowMembersOfGroup(dataGridViewRow1.Cells("Name").Value.ToString)
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

    Private Sub ExportGridToExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportGridToExcelToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(dtf)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(dtf)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbRefresh_Click(sender As System.Object, e As System.EventArgs) Handles tsbRefresh.Click
        RefreshGrid()
    End Sub

    Private Sub filterKeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFullName.KeyUp, txtDescription.KeyUp, txtMemberOf.KeyUp, txtMembers.KeyUp, txtMail.KeyUp

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None Then
            Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Else
            Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        End If
    End Sub


    Public Sub SaveFormSettings()

        My.Settings.UserGroupOpen = "Y"
        My.Settings.UserGroupHeight = Me.Height
        My.Settings.UserGroupWidth = Me.Width
        My.Settings.UserGroupX = Me.Location.X
        My.Settings.UserGroupY = Me.Location.Y
        My.Settings.Save()
    End Sub

    Public Sub GetFormSettings()
        Dim iHeight As Integer
        Dim iWidth As Integer
        Dim iX As Integer
        Dim iY As Integer

        If My.Settings.UserFormOpen.ToUpper = "Y" Then
            iHeight = My.Settings.UserGroupHeight
            iWidth = My.Settings.UserGroupWidth
            iX = My.Settings.UserGroupX
            iY = My.Settings.UserGroupY
        End If

        Me.Location = New Point(iX, iY)
        Me.Width = iWidth
        Me.Height = iHeight
    End Sub

    Private Sub AllRowsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(DataGridView1)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SelectedRowsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(DataGridView1, True)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub SetColumnWidths()
        Dim i As Integer = 0
        Dim iWidth As Integer = 20
        For i = 0 To DataGridView1.ColumnCount - 1
            Select Case UCase(DataGridView1.Columns(i).HeaderText).Trim
                Case "NAME"
                    iWidth = 175
                Case "DESCRIPTION"
                    iWidth = 425
                Case "ADSPATH"
                    iWidth = 425
                Case "CREATED", "MODIFIED", "MAIL"
                    iWidth = 125
                Case "MEMBEROF"
                    iWidth = 300
                Case "MEMBERS"
                    iWidth = 300
                Case Else
                    iWidth = 425
            End Select
            DataGridView1.Columns(i).Width = iWidth
        Next
    End Sub

End Class
