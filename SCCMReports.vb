Imports System.Threading
Public Class SCCMReports
    Dim dtReports As DataTable
    Dim dtfReports As DataTable
    Dim sComputerName As String = ""

    Public Sub New(dt As DataTable)
        InitializeComponent()
        dtReports = dt
        'FillGrid(dtReports)
        Me.cmbReport.Visible = False
        Me.btnGetData.Visible = False
        Me.labelcmb.Visible = False
        Me.cmbSite.Visible = False
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
        If tbParameter.Visible Then
            If Me.tbParameter.Text.Length > 0 And cmbReport.SelectedIndex > -1 Then
                Me.Cursor = Cursors.WaitCursor
                FillGrid()
                Me.Cursor = Cursors.Default
            Else
                MsgBox("Please Picka A Report and fill in the parameter field if needed.", vbInformation, "Fill In Parameter")
            End If
        Else
            Me.Cursor = Cursors.WaitCursor
            FillGrid()
            Me.Cursor = Cursors.Default
        End If
        SetUpRightClickMenu()
    End Sub

    Public Sub FillGrid(Optional dt As DataTable = Nothing)
        Try
            If dt Is Nothing Then
                Me.dtReports = Nothing
                Me.dgvReports.DataSource = Nothing

                Dim sSite As String = "EAI"
                Me.Cursor = Cursors.WaitCursor
                sSite = Me.cmbSite.SelectedItem.ToString.ToUpper

                Dim sParam As String = "%"
                sParam += Me.tbParameter.Text.Trim & "%"
                ClearFilters()
                HideFilters()

                If sSite = "ANY" Then
                    sSite = "%"
                End If

                ' Add Remove Programs by Program Name
                ' Advertisement ALL Status
                ' Computers(All)
                ' Computers with File Name
                ' Diskspace Less Than # GB
                ' Package Distribution ALL Summary
                ' Software Updates by KBArticle

                Select Case cmbReport.SelectedItem.ToString

                    Case "Add Remove Programs by Program Name"
                        dtReports = DtAddRemoveProgramsReportsTableAdapter1.GetAddRemoveByProgName(sParam, sSite)
                    Case "Advertisement ALL Status"
                        dtReports = DtAdvertisementSummaryTableAdapter1.GetALLAdvertisementSummary
                    Case "Advertisement Detail ALL Computers"
                        dtReports = DtAdvertisementDetailTableAdapter1.GetAdvertisementDetailAllComputers
                    Case "Diskspace Less Than # GB"
                        dtReports = DtDiskSpaceTableAdapter1.GetDiskSpaceLessThan(Me.tbParameter.Text.Trim, sSite)
                    Case "Collection ALL Machines"
                        dtReports = DtCollectionTableAdapter1.GetCollectionALLMachine
                    Case "Computers All"
                        dtReports = DtComputerListAllTableAdapter1.GetComputersBySiteID(sSite)
                    Case "Computers With Bios"
                        dtReports = DtCompInfoReportTableAdapter1.GetCompInfoByBiosManSiteID(sParam, sSite)
                    Case "Computers with File Name"
                        dtReports = DtFilesListTableAdapter1.GetFileListByFileName(sParam, sSite)
                    Case "Package Distribution ALL Summary"
                        dtReports = DtPackageDistributionTableAdapter1.GetALLPackageDistributionInfo
                    Case "Software Updates by KBArticle"
                        dtReports = DtSoftwareUpdatesTableAdapter1.GetComputerListByKBarticleID(sParam, sSite)
                    Case "Software Installed by User by Product"
                        dtReports = DtSoftwareInstalledByUserTableAdapter1.GetListByProdName(sParam, sSite)
                    Case Else
                        dtReports = dtUserIDFullName
                End Select
            Else
                dtReports = dt
            End If
            dgvReports.DataSource = dtReports
            dtfReports = dtReports
            Me.ToolStripStatusLabel1.Text = "Rows Found: " & dtReports.Rows.Count
            SetUpFilter()
        Catch ex As Exception
            LogError("Error in SCCMReports. Report picked: " & cmbReport.SelectedItem.text & " parameter: " & Me.tbParameter.Text & vbCrLf & ex.Message)
            MsgBox("Error running query. " & vbCrLf & ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub HideFilters()

        Dim ctrl As Control
        For Each ctrl In GroupBox1.Controls
            '  If ctrl.Name.Substring(0, 3) = "lbl" Or ctrl.Name.Substring(0, 3) = "txt" Then
            ctrl.Visible = False
            'End If
        Next
    End Sub

    Public Sub ClearFilters()
        Dim ctrl As Control
        For Each ctrl In GroupBox1.Controls
            If ctrl.Name.Substring(0, 3) = "txt" Then
                ctrl.Text = ""
            End If
        Next
    End Sub
    Public Sub SetUpRightClickMenu()
        For Each col As DataGridViewColumn In dgvReports.Columns
            If InStr(col.HeaderText.ToUpper, "COMPUTER") > 0 Or InStr(col.HeaderText.ToUpper, "NETBIOS") > 0 Or
                        InStr(col.HeaderText.ToUpper, "SYSTEMNAME") > 0 Then

                DamewareMachineToolStripMenuItem.Visible = True
                RemoteDesktopMachineToolStripMenuItem.Visible = True
                SCCMInfoToolStripMenuItem1.Visible = True
                PingMachineToolStripMenuItem1.Visible = True
                Exit For
            Else
                DamewareMachineToolStripMenuItem.Visible = False
                RemoteDesktopMachineToolStripMenuItem.Visible = False
                SCCMInfoToolStripMenuItem1.Visible = False
                PingMachineToolStripMenuItem1.Visible = False
            End If
        Next col

    End Sub

    Public Sub SetUpFilter()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim col As DataGridViewColumn

        For Each col In dgvReports.Columns
            'Skipping Date Fields in Filter area
            If InStr(col.HeaderText.ToUpper, "DATE") < 1 And InStr(col.HeaderText.ToUpper, "TIME") < 1 Then
                i += 1

                Select Case i
                    Case 1
                        lbl1.Text = col.HeaderText
                        lbl1.Visible = True
                        txt1.Visible = True
                    Case 2
                        lbl2.Text = col.HeaderText
                        lbl2.Visible = True
                        txt2.Visible = True
                    Case 3
                        lbl3.Text = col.HeaderText
                        lbl3.Visible = True
                        txt3.Visible = True
                    Case 4
                        lbl4.Text = col.HeaderText
                        lbl4.Visible = True
                        txt4.Visible = True
                    Case 5
                        lbl5.Text = col.HeaderText
                        lbl5.Visible = True
                        txt5.Visible = True
                    Case 6
                        lbl6.Text = col.HeaderText
                        lbl6.Visible = True
                        txt6.Visible = True
                    Case 7
                        lbl7.Text = col.HeaderText
                        lbl7.Visible = True
                        txt7.Visible = True
                    Case 8
                        lbl8.Text = col.HeaderText
                        lbl8.Visible = True
                        txt8.Visible = True
                    Case 9
                        lbl9.Text = col.HeaderText
                        lbl9.Visible = True
                        txt9.Visible = True
                    Case 10
                        lbl10.Text = col.HeaderText
                        lbl10.Visible = True
                        txt10.Visible = True
                    Case 11
                        lbl11.Text = col.HeaderText
                        lbl11.Visible = True
                        txt11.Visible = True
                    Case 12
                        lbl12.Text = col.HeaderText
                        lbl12.Visible = True
                        txt12.Visible = True
                    Case 13
                        lbl13.Text = col.HeaderText
                        lbl13.Visible = True
                        txt13.Visible = True
                    Case 14
                        lbl14.Text = col.HeaderText
                        lbl14.Visible = True
                        txt14.Visible = True
                    Case 15
                        lbl15.Text = col.HeaderText
                        lbl15.Visible = True
                        txt15.Visible = True
                    Case 16
                        lbl16.Text = col.HeaderText
                        lbl16.Visible = True
                        txt16.Visible = True

                    Case Else

                End Select
            End If 'Skipping Date Fields in Filter area

        Next

    End Sub
    Private Sub AllRowsToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem2.Click
        PrintDGV.Print_DataGridView(dgvReports, Me.cmbReport.SelectedItem.ToString, True)
    End Sub

    Private Sub SelectedRowsToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem2.Click
        PrintDGV.Print_DataGridView(dgvReports, Me.cmbReport.SelectedItem.ToString, False)
    End Sub

    Public Sub FilterGrid()
        Dim sTemp As String
        Dim ctrltb() As Control
        Dim ctrllb() As Control
        Try
            sTemp = ""

            For i As Integer = 1 To 16
                ctrltb = GroupBox1.Controls.Find("txt" & i, False)
                If ctrltb(0).Text.Length > 0 Then
                    ctrllb = GroupBox1.Controls.Find("lbl" & i, False)
                    If sTemp.Length > 0 Then
                        sTemp += " and [" & ctrllb(0).Text & "] like '*" & ctrltb(0).Text & "*'"
                    Else
                        sTemp += " [" & ctrllb(0).Text & "] like '*" & ctrltb(0).Text & "*'"
                    End If
                End If
            Next

            Dim DV As New DataView(dtReports)
            DV.RowFilter = sTemp
            dtfReports = DV.ToTable
            dgvReports.DataSource = dtfReports
            Me.ToolStripStatusLabel1.Text = "Rows: " & dgvReports.Rows.Count

        Catch ex As Exception
            MsgBox("Error In Filter." & vbCrLf & ex.Message)
            LogError("Filter Error " & ex.Message)
        End Try
    End Sub

    Private Sub txt1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1.KeyUp, txt2.KeyUp, txt3.KeyUp, txt4.KeyUp, txt5.KeyUp, txt6.KeyUp, txt7.KeyUp, txt8.KeyUp, txt9.KeyUp, txt10.KeyUp, txt11.KeyUp, txt12.KeyUp, txt13.KeyUp, txt14.KeyUp, txt15.KeyUp, txt16.KeyUp
        FilterGrid()
    End Sub

    Private Sub SCCMReports_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        HideFilters()
        'If My.Settings.SCCMReportOpen = "Y" Then
        '    Me.Height = My.Settings.SCCMReportHeight
        '    Me.Width = My.Settings.SCCMReportWidth
        '    Me.Location = New Point(My.Settings.SCCMReportX, My.Settings.SCCMReportY)
        'End If
        If Not dtReports Is Nothing Then
            Me.tbParameter.Visible = False
            Me.labelParam.Visible = False
            FillGrid(dtReports)
        End If

    End Sub

    Public Sub setParmLabel()
        Dim stemp As String
        stemp = cmbReport.SelectedItem.ToString.Trim
        Dim ibeg As Integer = 0
        ibeg = InStr(stemp.ToUpper, "BY")
        If ibeg = 0 Then
            ibeg = InStr(stemp.ToUpper, "WITH") + 5
        Else
            ibeg += 3
        End If

        If InStr(stemp.ToUpper, "DISK") > 0 Then
            Me.labelParam.Text = "Less than GB"
            'Me.tbParameter
        Else
            Me.labelParam.Text = Mid(stemp, ibeg)
        End If

        If InStr(stemp.ToUpper, "ALL") > 0 Or InStr(stemp.ToUpper, "TEST") > 1 Then
            Me.labelParam.Visible = False
            Me.tbParameter.Visible = False
        Else
            Me.labelParam.Visible = True
            Me.tbParameter.Visible = True
        End If
    End Sub

    Private Sub cmbReport_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbReport.SelectedIndexChanged
        Me.tbParameter.Text = ""
        ClearFilters()
        HideFilters()
        setParmLabel()
    End Sub

    Private Sub tbParameter_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbParameter.KeyUp
        If e.KeyCode = Keys.Enter Then
            If Me.tbParameter.Text.Length > 0 And cmbReport.SelectedIndex > 0 Then
                Me.Cursor = Cursors.WaitCursor
                FillGrid()
                Me.Cursor = Cursors.Default
            Else
                MsgBox("Please fill in parameter field.", vbInformation, "Fill In Parameter")
            End If
        End If
    End Sub

    Private Sub AllRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(dgvReports)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SelectedRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(dgvReports, True)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SCCMInfoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SCCMInfoToolStripMenuItem1.Click
        ShowSCCMSummary(dgvReports.SelectedCells(0).Value)
    End Sub

    Public Sub ShowSCCMSummary(sComputerName As String)
        Dim frm As New Sccmfrm
        Dim s() As String
        s = Split(sComputerName, ";")
        sCompName = s(0)
        frm.ShowDialog()
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

    Private Sub dgvReports_Mouseup(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgvReports.MouseUp
        Dim i As Integer
        i = dgvReports.CurrentRow.Index
        Dim col As DataGridViewColumn
        For Each col In dgvReports.Columns
            If InStr(col.HeaderText.ToUpper, "COMPUTER") > 0 Or InStr(col.HeaderText.ToUpper, "NETBIOS") > 0 Then
                sComputerName = dgvReports.Item(0, i).Value
                sCompName = dgvReports.Item(0, i).Value
            End If
        Next
    End Sub

    Private Sub PingMachineToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PingMachineToolStripMenuItem1.Click
        ShowComputerPing(sComputerName)
    End Sub

    Private Sub DamewareMachineToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DamewareMachineToolStripMenuItem.Click
        DameWareMachine(sComputerName)
    End Sub

    Private Sub RemoteDesktopMachineToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteDesktopMachineToolStripMenuItem.Click
        RemoteDesktopMachine(sComputerName)
    End Sub

    Private Sub ShowComputerSharesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowComputerSharesToolStripMenuItem.Click
        MsgBox(ShowComputerShares(sComputerName), MsgBoxStyle.Information, "Shares for " & sComputerName)
    End Sub

    Private Sub AllComputersInGridToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllComputersInGridToolStripMenuItem.Click
        Dim dt As DataTable
        Me.Cursor = Cursors.WaitCursor
        dt = GetComputerSharesAllComputers(dgvReports)
        Dim frm As New SCCMReports(dt)
        Me.Cursor = Cursors.Default
        'frm.Parent = MainParent
        frm.WindowState = FormWindowState.Normal
        frm.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        FillGrid()
    End Sub


    Public Function GetComputerSharesAllComputers(dgv As DataGridView) As DataTable

        dtShares = New DataTable("SharesOnComputer")
        dtShares.Columns.Add(New DataColumn("Full Name", GetType(System.String)))
        dtShares.Columns.Add(New DataColumn("UserID", GetType(System.String)))
        dtShares.Columns.Add(New DataColumn("Computer Name", GetType(System.String)))
        dtShares.Columns.Add(New DataColumn("Drive", GetType(System.String)))
        dtShares.Columns.Add(New DataColumn("Share Folder", GetType(System.String)))
        dtShares.Columns.Add(New DataColumn("Status", GetType(System.String)))
        'Dim dr As DataRow
        Dim dgr As DataGridViewRow
        Dim iCmpCnt As Integer = 1
        Dim iThCnt As Integer = 0
        iThCnt = Process.GetCurrentProcess.Threads.Count
        For Each dgr In dgv.Rows
            sCompName = dgr.Cells(0).Value 'Computer Name
            'Dim evaluator = New Thread(AddressOf AddComputerShares)
            'evaluator.Start(sCompName)
            AddComputerShares(sCompName)
            'Do While Process.GetCurrentProcess.Threads.Count > iThCnt + 6
            '    Thread.Sleep(2000)
            Me.ToolStripStatusLabel1.Text = "Working on Comp # " & iCmpCnt & " of " & dgv.RowCount
            iCmpCnt += 1
            'Loop
        Next dgr
        Return dtShares

    End Function

    Public Sub AddComputerShares(sComputerName As String)
        Dim sOut As String = "Realtime Shares mapped for " & sComputerName & vbCrLf & vbCrLf
        Dim Path As ManagementPath = New ManagementPath
        Dim Shares As ManagementClass = Nothing
        Dim CO As ConnectionOptions = New ConnectionOptions
        Dim dr As DataRow
        dr = dtShares.NewRow
        dr(0) = GetNameFromUserid(Mid(sComputerName.ToUpper, 5, 6))
        dr(1) = Mid(sComputerName.ToUpper, 5, 6)
        dr(2) = sCompName
        'Dim s As String
        If Not PingSimple(sComputerName) Then
            dr(5) = "Machine Not Pingable"
            dtShares.Rows.Add(dr)
            Exit Sub
        End If

        Path.Server = sComputerName ' use . for local server, else server name
        Path.NamespacePath = "root\CIMV2"
        Path.RelativePath = "Win32_Share"
        Path.RelativePath = "Win32_LogicalDisk"
        Path.RelativePath = "win32_MappedLogicalDisk"

        Dim Scope As ManagementScope = New ManagementScope(Path, CO)
        Dim Options As ObjectGetOptions = New ObjectGetOptions(Nothing, New TimeSpan(0, 0, 0, 5), True)
        Try
            Shares = New ManagementClass(Scope, Path, Options)
            Dim MOC As ManagementObjectCollection = Shares.GetInstances()
            Dim MO As ManagementObject
            If MOC.Count = 0 Then
                dr(5) = "No Mapped Drives Found"
                dtShares.Rows.Add(dr)
            End If
            For Each MO In MOC
                dr(3) = MO("DeviceID")
                dr(4) = MO("ProviderName")
                dtShares.Rows.Add(dr)
                dr = dtShares.NewRow
                dr(0) = GetNameFromUserid(Mid(sComputerName.ToUpper, 5, 6))
                dr(1) = Mid(sComputerName.ToUpper, 5, 6)
                dr(2) = sCompName
            Next
        Catch e As Exception
            dr(5) = e.Message
            dtShares.Rows.Add(dr)
        Finally
            Shares.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FillGrid(dtShares)
    End Sub
End Class