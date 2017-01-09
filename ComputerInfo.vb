Imports System.DirectoryServices
Imports System.Management
Imports System.DirectoryServices.AccountManagement
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Data.SqlClient

Public Class ComputerInfo

    Dim iRowSelected As Integer
    Public dt As DataTable
    Public dtf As DataTable
    Public dtMemberof As DataTable

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
                Case "MAILSTOP"
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

    Public Sub RemoteDesktopMachine(sComp As String)
        Dim sShell As String = ""
        Dim sPar As String = ""

        Try
            sShell = "mstsc.exe"
            sPar = "/f /v:" & sComp
            Process.Start(sShell, sPar)
        Catch ex As Exception
            LogError("Error Opening RemoteDesktop: " & sShell & " " & sPar & ex.Message & vbTab & ex.StackTrace)

        End Try
    End Sub

    Public Sub DameWareMachine(sComp As String)
        Dim sShell As String
        Dim spar As String
        sShell = sDameWareFile
        spar = " -c: -m:" & sComp
        Try
            Process.Start(sShell, spar)
        Catch ex As Exception
            LogError("Error Opening Dameware: " & sShell & " " & spar & ex.Message & vbTab & ex.StackTrace)
        End Try
    End Sub

    Public Sub ShowSCCMSummary(sComputerName As String)
        Dim frm As New Sccmfrm
        Dim s() As String
        s = Split(sComputerName, ";")
        sCompName = s(0)
        frm.ShowDialog()
    End Sub

    Public Sub ShowComputerPing(sComputerName As String)
        Dim scommand As String = "Ping " & sComputerName
        Me.Cursor = Cursors.WaitCursor
        Try
            MsgBox(Ping(sComputerName), MsgBoxStyle.Information, "Ping Info for " & sComputerName)

            'MsgBox(ParseString(RunDosCommand(scommand), "PING"), MsgBoxStyle.Information, "Ping Info for " & sComputerName)
            Exit Sub
        Catch ex As Exception
            LogError("Error Getting Ping Info Summary " & scommand & vbCrLf & ex.Message & vbTab & ex.StackTrace)
        End Try
        Me.Cursor = Cursors.Default
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

    Public Sub Startup()
        If DameWareRemoteExists() Then
            DamewareMachineToolStripMenuItem.Visible = True
        End If
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

            Startup()

            If isSCCMUser(GetCurrentUserName) Then
                SCCMInfoToolStripMenuItem1.Visible = True
            Else
                SCCMInfoToolStripMenuItem1.Visible = False
            End If

            'Fills Datatable with UserID and User Full Names for other forms.
            FillUserIDFullName()
            RefreshGrid()
            Me.Text = "COMPUTER INFO"
            Me.Height = My.Settings.ComputerHeight
            Me.Width = My.Settings.ComputerWidth
            Me.Location = New Point(My.Settings.ComputerX, My.Settings.ComputerY)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            LogError("Form Computer Info Load Error " & ex.Message)
            sendMail("ADLookup Error on Computer Info Form Load.", ex.Message)
            MsgBox("Error." & vbCrLf & ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub FilterGrid()
        Dim sTemp As String = ""
        Try
                    sTemp = ""

                    If Me.txtCompUser.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and USER like '*" & Me.txtCompUser.Text & "*'"
                        Else
                            sTemp += " USER like '*" & Me.txtCompUser.Text & "*'"
                        End If
                    End If

                    If Me.txtCompUserID.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and USERID like '*" & Me.txtCompUserID.Text & "*'"
                        Else
                            sTemp += " USERID like '*" & Me.txtCompUserID.Text & "*'"
                        End If
                    End If


                    If Me.txtCompCompName.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and Name like '*" & Me.txtCompCompName.Text & "*'"
                        Else
                            sTemp += " Name like '*" & Me.txtCompCompName.Text & "*'"
                        End If
                    End If

                    If Me.txtOS.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and OS like '*" & Me.txtOS.Text & "*'"
                        Else
                            sTemp += " OS like '*" & Me.txtOS.Text & "*'"
                        End If
                    End If

                    If Me.txtVersion.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and SP like '*" & Me.txtVersion.Text & "*'"
                        Else
                            sTemp += "  SP like '*" & Me.txtVersion.Text & "*'"
                        End If
                    End If

                    If Me.txtCompLoc.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and LOC like '*" & Me.txtCompLoc.Text & "*'"
                        Else
                            sTemp += " LOC like '*" & Me.txtCompLoc.Text & "*'"
                        End If
                    End If

                    If Me.TextCompOu.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and OU like '*" & Me.TextCompOu.Text & "*'"
                        Else
                            sTemp += " OU like '*" & Me.TextCompOu.Text & "*'"
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

    

    Private Sub filterKeyUp(sender As Object, e As System.EventArgs) Handles txtCompCompName.KeyUp, txtOS.KeyUp, txtVersion.KeyUp, txtCompLoc.KeyUp,
        TextCompOu.KeyUp, txtCompUser.KeyUp, txtCompUserID.KeyUp
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
            LabelHeader.Text = "AD Computer Info"
            Me.DataGridView1.ContextMenuStrip = Me.cmsComputer
            dt = getComputerADInfo()
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

    Private Sub DataGridView1_CellToolTipTextNeeded(sender As Object, e As System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs) Handles DataGridView1.CellToolTipTextNeeded
        Dim newLine As String = Environment.NewLine
        Try
            If e.RowIndex > -1 And e.ColumnIndex = 9 Then
                Dim dataGridViewRow1 As DataGridViewRow = _
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

    Private Sub AllRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, True)
    End Sub

    Private Sub SelectedRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, False)
    End Sub

    Private Sub ShowUserInfoSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.Rows(iRowSelected)
        If dataGridViewRow1.Cells("USERID").Value.ToString.Trim.Length > 0 Then
            ShowUserSummary(dataGridViewRow1.Cells("USERID").Value.ToString)
        End If
    End Sub

    Private Sub DamewareMachineToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DamewareMachineToolStripMenuItem.Click
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.Rows(iRowSelected)
        DameWareMachine(dataGridViewRow1.Cells("Name").Value.ToString)
    End Sub

    Private Sub RemoteDesktopMachineToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteDesktopMachineToolStripMenuItem.Click
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.Rows(iRowSelected)
        RemoteDesktopMachine(dataGridViewRow1.Cells("Name").Value.ToString)
    End Sub

    Private Sub PingMachineToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PingMachineToolStripMenuItem1.Click
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.Rows(iRowSelected)
        ShowComputerPing(dataGridViewRow1.Cells("Name").Value.ToString)
    End Sub

    Private Sub SCCMInfoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SCCMInfoToolStripMenuItem1.Click
        Dim sComputers As String = ""
        For Each dr As DataGridViewRow In DataGridView1.SelectedRows
            sComputers += dr.Cells("Name").Value.ToString & ";"
        Next
        Dim dataGridViewRow1 As DataGridViewRow = DataGridView1.Rows(iRowSelected)
        ShowSCCMSummary(sComputers)
    End Sub

    Private Sub AllRowsToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem2.Click
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, True)
    End Sub

    Private Sub SelectedRowsToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem2.Click
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, False)
    End Sub

    Private Sub cbdomainlist_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbdomainlist.SelectedIndexChanged
        SetLdap(cbdomainlist.SelectedItem)
    End Sub

    Private Sub ExportGridToExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(dtf)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbRefresh_Click(sender As System.Object, e As System.EventArgs) Handles tsbRefresh.Click
        RefreshGrid()
    End Sub

    Private Sub filterKeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtVersion.KeyUp, txtOS.KeyUp, txtCompUserID.KeyUp, txtCompUser.KeyUp, txtCompLoc.KeyUp, txtCompCompName.KeyUp, TextCompOu.KeyUp

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None Then
            Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Else
            Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        End If
    End Sub

    Public Sub SaveFormSettings()

        My.Settings.ComputerFormOpen = "Y"
        My.Settings.ComputerHeight = Me.Height
        My.Settings.ComputerWidth = Me.Width
        My.Settings.ComputerX = Me.Location.X
        My.Settings.ComputerY = Me.Location.Y
        My.Settings.Save()
    End Sub

    Public Sub GetFormSettings()
        Dim iHeight As Integer
        Dim iWidth As Integer
        Dim iX As Integer
        Dim iY As Integer

        If My.Settings.ComputerFormOpen.ToUpper = "Y" Then
            iHeight = My.Settings.ComputerHeight
            iWidth = My.Settings.ComputerWidth
            iX = My.Settings.ComputerX
            iY = My.Settings.ComputerY
        End If

        Me.Location = New Point(iX, iY)
        Me.Width = iWidth
        Me.Height = iHeight
    End Sub

    Private Sub AllRowsToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        'ExportToExcel(dtf)
        ExportToExcel(DataGridView1)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SelectedRowsToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        'ExportToExcel(dtf)
        ExportToExcel(DataGridView1, True)
        Me.Cursor = Cursors.Default
    End Sub
End Class
