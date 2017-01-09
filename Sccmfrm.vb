Public Class Sccmfrm

    Dim Selectedgv As DataGridView
    Dim sTitle As String = ""
    Dim dtAutoStart As DataTable
    Dim dtServices As DataTable
    Dim dtAddRemoveProg As DataTable
    Dim dtMicroSoftUpdates As DataTable
    Dim dtFiles As DataTable
    Dim dtDisks As DataTable
    'Dim dt As DataTable
    Dim dtf As DataTable


    Private Sub Hardwarefrm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        LoadInitialdata()
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub LoadInitialdata()
        Try

            Me.LabelHeader.Text = "SCCM Info for " & sCompName
            Me.Text += " [" & sCompName & "]"
            Me.DtHardwareTableAdapter.FillRows(Me.SMS_EAIDataSet.dtHardware, sCompName)

            dtAutoStart = Me.DtAutoStartProgramsTableAdapter.GetAutoStartPrograms(sCompName)
            DtAutoStartProgramsDataGridView.DataSource = dtAutoStart

            dtMicroSoftUpdates = DtSoftwareUpdatesTableAdapter1.GetSoftwareUpdatesForComputer(sCompName)
            DtSoftwareUpdatesDataGridView.DataSource = dtMicroSoftUpdates

            dtServices = Me.DtServicesTableAdapter.GetServicesList(sCompName)
            DtServicesDataGridView.DataSource = dtServices

            DtDiskSpaceDataGridView.DataSource = DtDiskSpaceTableAdapter.GetDiskSpace(sCompName)

            DtNetworkInfoDataGridView.DataSource = DtNetworkInfoTableAdapter.GetNetworkInfo(sCompName)

            DtSoftwareInstalledByUserDataGridView.DataSource = DtSoftwareInstalledByUserTableAdapter.GetSoftwareInstalledByUser(sCompName)

            DtAdvertisementDetailDataGridView.DataSource = DtAdvertisementDetailTableAdapter.GetAdvertisementDetailForComputer(sCompName)

            SetRowsFound()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AllRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem.Click
        PrintDGV.Print_DataGridView(Selectedgv, sTitle, True)
    End Sub

    Private Sub DtServicesDataGridView_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DtServicesDataGridView.MouseDown
        Selectedgv = DtServicesDataGridView
        sTitle = "Resutls from Services Tab "
    End Sub

    Private Sub DtAutoStartProgramsDataGridView_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DtAutoStartProgramsDataGridView.MouseDown
        Selectedgv = DtAutoStartProgramsDataGridView
        sTitle = "Resutls from Auto Start Programs Tab"
    End Sub

    Private Sub SelectedRowsToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem.Click
        PrintDGV.Print_DataGridView(Selectedgv, sTitle, False)
    End Sub

    Private Sub GetFilesListToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.DtFilesListTableAdapter.GetFilesList(sCompName)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnGetAddRemoveData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetAddRemoveData.Click
        Me.Cursor = Cursors.WaitCursor
        If chkIncludeKBArticle.Checked Then
            dtAddRemoveProg = Me.DtAddRemoveProgramsTableAdapter1.GetAddRemoveProgramsAllFiles(sCompName)
        Else
            dtAddRemoveProg = Me.DtAddRemoveProgramsTableAdapter1.GetAddRemovePrograms(sCompName)
        End If
        DtAddRemoveProgramsDataGridView.DataSource = Me.dtAddRemoveProg
        Selectedgv = DtAddRemoveProgramsDataGridView
        SetRowsFound()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnGetFiles_Click(sender As System.Object, e As System.EventArgs) Handles btnGetFiles.Click
        Me.Cursor = Cursors.WaitCursor
        dtFiles = Me.DtFilesListTableAdapter.GetFilesList(sCompName)
        DtFilesListDataGridView.DataSource = Me.dtFiles
        Selectedgv = DtFilesListDataGridView
        SetRowsFound()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtAddRemNormalizedName_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAddRemNormalizedName.KeyUp
        FilterGrid(Me.DtAddRemoveProgramsDataGridView)
    End Sub


    Public Sub FilterGrid(dgv As DataGridView)
        Dim sTemp As String = ""
        Try
            Select Case dgv.Name

                Case "DtAutoStartProgramsDataGridView"
                    If Me.txtAutoStartPubName.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and Publisher like '*" & Me.txtAutoStartPubName.Text & "*'"
                        Else
                            sTemp += " Publisher like '*" & Me.txtAutoStartPubName.Text & "*'"
                        End If
                    End If

                    If Me.txtAutoStartDesc.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and Description like '*" & Me.txtAutoStartDesc.Text & "*'"
                        Else
                            sTemp += " Description like '*" & Me.txtAutoStartDesc.Text & "*'"
                        End If
                    End If

                    If Me.txtAutoStartFileName.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and FileName like '*" & Me.txtAutoStartFileName.Text & "*'"
                        Else
                            sTemp += " FileName like '*" & Me.txtAutoStartFileName.Text & "*'"
                        End If
                    End If

                    Dim DV As New DataView(dtAutoStart)
                    DV.RowFilter = sTemp
                    dtf = DV.ToTable
                    dgv.DataSource = dtf

                Case "DtAddRemoveProgramsDataGridView"
                    sTemp = ""
                    ' txtAddRemNormalizedName
                    If Me.txtAddRemNormalizedName.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and NormalizedName like '*" & Me.txtAddRemNormalizedName.Text & "*'"
                        Else
                            sTemp += " NormalizedName like '*" & Me.txtAddRemNormalizedName.Text & "*'"
                        End If
                    End If

                    If Me.txtAddRemovInstalledLocation.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and InstalledLocation0 like '*" & Me.txtAddRemovInstalledLocation.Text & "*'"
                        Else
                            sTemp += " InstalledLocation0 like '*" & Me.txtAddRemovInstalledLocation.Text & "*'"
                        End If
                    End If


                    Dim DV As New DataView(dtAddRemoveProg)
                    DV.RowFilter = sTemp
                    dtf = DV.ToTable
                    dgv.DataSource = dtf

                Case "DtFilesListDataGridView"
                    sTemp = ""

                    If Me.txtFilesFileName.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and FileName like '*" & Me.txtFilesFileName.Text & "*'"
                        Else
                            sTemp += " FileName like '*" & Me.txtFilesFileName.Text & "*'"
                        End If
                    End If

                    If Me.txtFilesFileDesc.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and FileDescription like '*" & Me.txtFilesFileDesc.Text & "*'"
                        Else
                            sTemp += " FileDescription like '*" & Me.txtFilesFileDesc.Text & "*'"
                        End If
                    End If


                    If Me.txtFilesFilePath.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and FilePath like '*" & Me.txtFilesFilePath.Text & "*'"
                        Else
                            sTemp += " FilePath like '*" & Me.txtFilesFilePath.Text & "*'"
                        End If
                    End If


                    Dim DV As New DataView(dtFiles)
                    DV.RowFilter = sTemp
                    dtf = DV.ToTable
                    dgv.DataSource = dtf

                Case "DtServicesDataGridView"
                    sTemp = ""

                    If Me.txtServicesDisplayName.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and Displayname0 like '*" & Me.txtServicesDisplayName.Text & "*'"
                        Else
                            sTemp += " Displayname0 like '*" & Me.txtServicesDisplayName.Text & "*'"
                        End If
                    End If

                    If Me.txtServicesMode.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and StartMode0 like '*" & Me.txtServicesMode.Text & "*'"
                        Else
                            sTemp += " startmode0 like '*" & Me.txtServicesMode.Text & "*'"
                        End If
                    End If

                    If Me.txtServicesType.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and servicetype0 like '*" & Me.txtServicesType.Text & "*'"
                        Else
                            sTemp += " servicetype0 like '*" & Me.txtServicesType.Text & "*'"
                        End If
                    End If

                    If Me.txtServicesPath.Text.Length > 0 Then
                        If sTemp.Length > 0 Then
                            sTemp += " and PathName0 like '*" & Me.txtServicesPath.Text & "*'"
                        Else
                            sTemp += " PathName0 like '*" & Me.txtServicesPath.Text & "*'"
                        End If
                    End If



                    Dim DV As New DataView(dtServices)
                    DV.RowFilter = sTemp
                    dtf = DV.ToTable
                    dgv.DataSource = dtf


            End Select

            SetRowsFound()
        Catch ex As Exception
            MsgBox("Error In Filter." & vbCrLf & ex.Message)
            LogError("Filter Error " & ex.Message)
        End Try
    End Sub

    Public Sub SetRowsFound()
        Me.lblAddRemoveStatus.Text = "Rows: " & DtAddRemoveProgramsDataGridView.RowCount
        Me.lblFilesStatus.Text = "Rows: " & DtFilesListDataGridView.RowCount
        Me.lblServicesStatus.Text = "Rows: " & DtServicesDataGridView.RowCount
        Me.lblMSUpdates.Text = "Rows: " & dtMicroSoftUpdates.Rows.Count
    End Sub

    Private Sub txtServicesCompName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtServicesDisplayName.KeyUp, txtServicesMode.KeyUp, txtServicesPath.KeyUp, txtServicesType.KeyUp
        FilterGrid(DtServicesDataGridView)
    End Sub

    Private Sub txtAddRemCompName_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAddRemNormalizedName.KeyUp, txtAddRemovInstalledLocation.KeyUp
        FilterGrid(DtAddRemoveProgramsDataGridView)
    End Sub

    Private Sub txtFilesCompName_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFilesFileDesc.KeyUp, txtFilesFileName.KeyUp, txtFilesFilePath.KeyUp
        FilterGrid(DtFilesListDataGridView)
    End Sub

    Private Sub AllRowsToolStripMenuItem_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles AllRowsToolStripMenuItem.MouseDown
        PrintDGV.Print_DataGridView(Selectedgv, , True)
    End Sub

    Private Sub tabServices_Click(sender As Object, e As System.EventArgs) Handles tabServices.Click
        Selectedgv = DtServicesDataGridView
    End Sub

    Private Sub tabAddRemov_Click(sender As Object, e As System.EventArgs) Handles tabAddRemov.Click
        Selectedgv = DtAddRemoveProgramsDataGridView
    End Sub

    Private Sub tabAutoStart_Click(sender As Object, e As System.EventArgs) Handles tabAutoStart.Click
        Selectedgv = DtAutoStartProgramsDataGridView
    End Sub

    Private Sub tabFiles_Click(sender As Object, e As System.EventArgs) Handles tabFiles.Click
        Selectedgv = DtFilesListDataGridView
    End Sub

    Private Sub tabSoftInstalledByUser_Click(sender As Object, e As System.EventArgs) Handles tabSoftInstalledByUser.Click
        Selectedgv = DtSoftwareInstalledByUserDataGridView
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
