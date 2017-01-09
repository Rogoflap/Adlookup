<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sccmfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Netbios_Name0Label As System.Windows.Forms.Label
        Dim Proc_NameLabel As System.Windows.Forms.Label
        Dim IsMulticore0Label As System.Windows.Forms.Label
        Dim Service_PackLabel As System.Windows.Forms.Label
        Dim OSD_VersionLabel As System.Windows.Forms.Label
        Dim OS_InstallDateLabel As System.Windows.Forms.Label
        Dim BiosDescLabel As System.Windows.Forms.Label
        Dim BiosManufacturerLabel As System.Windows.Forms.Label
        Dim BiosNameLabel As System.Windows.Forms.Label
        Dim SerialNumber0Label As System.Windows.Forms.Label
        Dim SMBIOSBIOSVersion0Label As System.Windows.Forms.Label
        Dim RamLabel As System.Windows.Forms.Label
        Dim Video_DescLabel As System.Windows.Forms.Label
        Dim VIdeo_Driver_DateLabel As System.Windows.Forms.Label
        Dim VideoDriverVersionLabel As System.Windows.Forms.Label
        Dim Video_NameLabel As System.Windows.Forms.Label
        Dim VideoRamLabel As System.Windows.Forms.Label
        Dim Computer_ManufacturerLabel As System.Windows.Forms.Label
        Dim Computer_ModelLabel As System.Windows.Forms.Label
        Dim NumberOfProcessors0Label As System.Windows.Forms.Label
        Dim OSTimeStampLabel As System.Windows.Forms.Label
        Dim OS_CaptionLabel As System.Windows.Forms.Label
        Dim LastBootUpTime0Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sccmfrm))
        Me.DtHardwareBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.DtHardwareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS_EAIDataSet = New ADLookup.SMS_EAIDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Netbios_Name0TextBox = New System.Windows.Forms.TextBox()
        Me.Proc_NameTextBox = New System.Windows.Forms.TextBox()
        Me.IsMulticore0TextBox = New System.Windows.Forms.TextBox()
        Me.Service_PackTextBox = New System.Windows.Forms.TextBox()
        Me.OSD_VersionTextBox = New System.Windows.Forms.TextBox()
        Me.BiosDescTextBox = New System.Windows.Forms.TextBox()
        Me.BiosManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.BiosNameTextBox = New System.Windows.Forms.TextBox()
        Me.SerialNumber0TextBox = New System.Windows.Forms.TextBox()
        Me.SMBIOSBIOSVersion0TextBox = New System.Windows.Forms.TextBox()
        Me.RamTextBox = New System.Windows.Forms.TextBox()
        Me.Video_DescTextBox = New System.Windows.Forms.TextBox()
        Me.VideoDriverVersionTextBox = New System.Windows.Forms.TextBox()
        Me.Video_NameTextBox = New System.Windows.Forms.TextBox()
        Me.VideoRamTextBox = New System.Windows.Forms.TextBox()
        Me.Computer_ManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.Computer_ModelTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfProcessors0TextBox = New System.Windows.Forms.TextBox()
        Me.gbComputer = New System.Windows.Forms.GroupBox()
        Me.LastBootUpTime0Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.VIdeo_Driver_DateLabel2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OS_InstallDateLabel2 = New System.Windows.Forms.Label()
        Me.OSTimeStampLabel2 = New System.Windows.Forms.Label()
        Me.OS_CaptionTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Hardware = New System.Windows.Forms.TabPage()
        Me.DtDiskSpaceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtDiskSpaceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabNetwork = New System.Windows.Forms.TabPage()
        Me.DtNetworkInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtNetworkInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabAutoStart = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtAutoStartFileName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAutoStartPubName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAutoStartDesc = New System.Windows.Forms.TextBox()
        Me.DtAutoStartProgramsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsRightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DtAutoStartProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabServices = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtServicesMode = New System.Windows.Forms.TextBox()
        Me.txtServicesDisplayName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServicesPath = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServicesType = New System.Windows.Forms.TextBox()
        Me.lblServicesStatus = New System.Windows.Forms.Label()
        Me.DtServicesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabAddRemov = New System.Windows.Forms.TabPage()
        Me.chkIncludeKBArticle = New System.Windows.Forms.CheckBox()
        Me.DtAddRemoveProgramsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DtAddRemoveProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtAddRemovInstalledLocation = New System.Windows.Forms.TextBox()
        Me.txtAddRemNormalizedName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAddRemoveStatus = New System.Windows.Forms.Label()
        Me.btnGetAddRemoveData = New System.Windows.Forms.Button()
        Me.tabFiles = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtFilesFilePath = New System.Windows.Forms.TextBox()
        Me.txtFilesFileName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFilesFileDesc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblFilesStatus = New System.Windows.Forms.Label()
        Me.btnGetFiles = New System.Windows.Forms.Button()
        Me.DtFilesListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtFilesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabSoftInstalledByUser = New System.Windows.Forms.TabPage()
        Me.DtSoftwareInstalledByUserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtSoftwareInstalledByUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabMicrosoftUpdates = New System.Windows.Forms.TabPage()
        Me.lblMSUpdates = New System.Windows.Forms.Label()
        Me.DtSoftwareUpdatesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DtSoftwareUpdatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtHardwareTableAdapter = New ADLookup.SMS_EAIDataSetTableAdapters.dtHardwareTableAdapter()
        Me.DtFilesListTableAdapter = New ADLookup.SMS_EAIDataSetTableAdapters.dtFilesListTableAdapter()
        Me.DtDiskSpaceTableAdapter = New ADLookup.SMS_EAIDataSetTableAdapters.dtDiskSpaceTableAdapter()
        Me.DtSoftwareInstalledByUserTableAdapter = New ADLookup.SMS_EAIDataSetTableAdapters.dtSoftwareInstalledByUserTableAdapter()
        Me.TableAdapterManager = New ADLookup.SMS_EAIDataSetTableAdapters.TableAdapterManager()
        Me.DtAutoStartProgramsTableAdapter = New ADLookup.SMS_EAIDataSetTableAdapters.dtAutoStartProgramsTableAdapter()
        Me.DtServicesTableAdapter = New ADLookup.SMS_EAIDataSetTableAdapters.dtServicesTableAdapter()
        Me.DtNetworkInfoTableAdapter = New ADLookup.SMS_EAIDataSetTableAdapters.dtNetworkInfoTableAdapter()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DtSoftwareUpdatesTableAdapter1 = New ADLookup.SMS_EAIDataSetTableAdapters.dtSoftwareUpdatesTableAdapter()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DtAddRemoveProgramsTableAdapter1 = New ADLookup.SMS_EAIDataSetTableAdapters.dtAddRemoveProgramsTableAdapter()
        Me.tabAdvertisement = New System.Windows.Forms.TabPage()
        Me.DtAdvertisementDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtAdvertisementDetailTableAdapter = New ADLookup.SMS_EAIDataSetTableAdapters.dtAdvertisementDetailTableAdapter()
        Me.DtAdvertisementDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Netbios_Name0Label = New System.Windows.Forms.Label()
        Proc_NameLabel = New System.Windows.Forms.Label()
        IsMulticore0Label = New System.Windows.Forms.Label()
        Service_PackLabel = New System.Windows.Forms.Label()
        OSD_VersionLabel = New System.Windows.Forms.Label()
        OS_InstallDateLabel = New System.Windows.Forms.Label()
        BiosDescLabel = New System.Windows.Forms.Label()
        BiosManufacturerLabel = New System.Windows.Forms.Label()
        BiosNameLabel = New System.Windows.Forms.Label()
        SerialNumber0Label = New System.Windows.Forms.Label()
        SMBIOSBIOSVersion0Label = New System.Windows.Forms.Label()
        RamLabel = New System.Windows.Forms.Label()
        Video_DescLabel = New System.Windows.Forms.Label()
        VIdeo_Driver_DateLabel = New System.Windows.Forms.Label()
        VideoDriverVersionLabel = New System.Windows.Forms.Label()
        Video_NameLabel = New System.Windows.Forms.Label()
        VideoRamLabel = New System.Windows.Forms.Label()
        Computer_ManufacturerLabel = New System.Windows.Forms.Label()
        Computer_ModelLabel = New System.Windows.Forms.Label()
        NumberOfProcessors0Label = New System.Windows.Forms.Label()
        OSTimeStampLabel = New System.Windows.Forms.Label()
        OS_CaptionLabel = New System.Windows.Forms.Label()
        LastBootUpTime0Label = New System.Windows.Forms.Label()
        CType(Me.DtHardwareBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DtHardwareBindingNavigator.SuspendLayout()
        CType(Me.DtHardwareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_EAIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbComputer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Hardware.SuspendLayout()
        CType(Me.DtDiskSpaceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDiskSpaceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNetwork.SuspendLayout()
        CType(Me.DtNetworkInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtNetworkInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAutoStart.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DtAutoStartProgramsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsRightClickMenu.SuspendLayout()
        CType(Me.DtAutoStartProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServices.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DtServicesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAddRemov.SuspendLayout()
        CType(Me.DtAddRemoveProgramsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtAddRemoveProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.tabFiles.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DtFilesListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtFilesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSoftInstalledByUser.SuspendLayout()
        CType(Me.DtSoftwareInstalledByUserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtSoftwareInstalledByUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMicrosoftUpdates.SuspendLayout()
        CType(Me.DtSoftwareUpdatesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtSoftwareUpdatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdvertisement.SuspendLayout()
        CType(Me.DtAdvertisementDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtAdvertisementDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Netbios_Name0Label
        '
        Netbios_Name0Label.AutoSize = True
        Netbios_Name0Label.Location = New System.Drawing.Point(8, 22)
        Netbios_Name0Label.Name = "Netbios_Name0Label"
        Netbios_Name0Label.Size = New System.Drawing.Size(35, 13)
        Netbios_Name0Label.TabIndex = 2
        Netbios_Name0Label.Text = "Name"
        '
        'Proc_NameLabel
        '
        Proc_NameLabel.AutoSize = True
        Proc_NameLabel.Location = New System.Drawing.Point(4, 19)
        Proc_NameLabel.Name = "Proc_NameLabel"
        Proc_NameLabel.Size = New System.Drawing.Size(63, 13)
        Proc_NameLabel.TabIndex = 4
        Proc_NameLabel.Text = "Proc Name:"
        '
        'IsMulticore0Label
        '
        IsMulticore0Label.AutoSize = True
        IsMulticore0Label.Location = New System.Drawing.Point(4, 45)
        IsMulticore0Label.Name = "IsMulticore0Label"
        IsMulticore0Label.Size = New System.Drawing.Size(64, 13)
        IsMulticore0Label.TabIndex = 6
        IsMulticore0Label.Text = "Is Multicore:"
        '
        'Service_PackLabel
        '
        Service_PackLabel.AutoSize = True
        Service_PackLabel.Location = New System.Drawing.Point(5, 81)
        Service_PackLabel.Name = "Service_PackLabel"
        Service_PackLabel.Size = New System.Drawing.Size(71, 13)
        Service_PackLabel.TabIndex = 14
        Service_PackLabel.Text = "Service Pack"
        '
        'OSD_VersionLabel
        '
        OSD_VersionLabel.AutoSize = True
        OSD_VersionLabel.Location = New System.Drawing.Point(5, 55)
        OSD_VersionLabel.Name = "OSD_VersionLabel"
        OSD_VersionLabel.Size = New System.Drawing.Size(42, 13)
        OSD_VersionLabel.TabIndex = 16
        OSD_VersionLabel.Text = "Version"
        '
        'OS_InstallDateLabel
        '
        OS_InstallDateLabel.AutoSize = True
        OS_InstallDateLabel.Location = New System.Drawing.Point(5, 108)
        OS_InstallDateLabel.Name = "OS_InstallDateLabel"
        OS_InstallDateLabel.Size = New System.Drawing.Size(60, 13)
        OS_InstallDateLabel.TabIndex = 20
        OS_InstallDateLabel.Text = "Install Date"
        '
        'BiosDescLabel
        '
        BiosDescLabel.AutoSize = True
        BiosDescLabel.Location = New System.Drawing.Point(6, 22)
        BiosDescLabel.Name = "BiosDescLabel"
        BiosDescLabel.Size = New System.Drawing.Size(35, 13)
        BiosDescLabel.TabIndex = 28
        BiosDescLabel.Text = "Desc:"
        '
        'BiosManufacturerLabel
        '
        BiosManufacturerLabel.AutoSize = True
        BiosManufacturerLabel.Location = New System.Drawing.Point(6, 48)
        BiosManufacturerLabel.Name = "BiosManufacturerLabel"
        BiosManufacturerLabel.Size = New System.Drawing.Size(73, 13)
        BiosManufacturerLabel.TabIndex = 30
        BiosManufacturerLabel.Text = "Manufacturer:"
        '
        'BiosNameLabel
        '
        BiosNameLabel.AutoSize = True
        BiosNameLabel.Location = New System.Drawing.Point(6, 74)
        BiosNameLabel.Name = "BiosNameLabel"
        BiosNameLabel.Size = New System.Drawing.Size(38, 13)
        BiosNameLabel.TabIndex = 32
        BiosNameLabel.Text = "Name:"
        '
        'SerialNumber0Label
        '
        SerialNumber0Label.AutoSize = True
        SerialNumber0Label.Location = New System.Drawing.Point(6, 100)
        SerialNumber0Label.Name = "SerialNumber0Label"
        SerialNumber0Label.Size = New System.Drawing.Size(76, 13)
        SerialNumber0Label.TabIndex = 34
        SerialNumber0Label.Text = "Serial Number:"
        '
        'SMBIOSBIOSVersion0Label
        '
        SMBIOSBIOSVersion0Label.AutoSize = True
        SMBIOSBIOSVersion0Label.Location = New System.Drawing.Point(6, 126)
        SMBIOSBIOSVersion0Label.Name = "SMBIOSBIOSVersion0Label"
        SMBIOSBIOSVersion0Label.Size = New System.Drawing.Size(73, 13)
        SMBIOSBIOSVersion0Label.TabIndex = 36
        SMBIOSBIOSVersion0Label.Text = "BIOS Version:"
        '
        'RamLabel
        '
        RamLabel.AutoSize = True
        RamLabel.Location = New System.Drawing.Point(6, 102)
        RamLabel.Name = "RamLabel"
        RamLabel.Size = New System.Drawing.Size(53, 13)
        RamLabel.TabIndex = 40
        RamLabel.Text = "Ram (GB)"
        '
        'Video_DescLabel
        '
        Video_DescLabel.AutoSize = True
        Video_DescLabel.Location = New System.Drawing.Point(6, 20)
        Video_DescLabel.Name = "Video_DescLabel"
        Video_DescLabel.Size = New System.Drawing.Size(35, 13)
        Video_DescLabel.TabIndex = 42
        Video_DescLabel.Text = "Desc:"
        '
        'VIdeo_Driver_DateLabel
        '
        VIdeo_Driver_DateLabel.AutoSize = True
        VIdeo_Driver_DateLabel.Location = New System.Drawing.Point(6, 47)
        VIdeo_Driver_DateLabel.Name = "VIdeo_Driver_DateLabel"
        VIdeo_Driver_DateLabel.Size = New System.Drawing.Size(64, 13)
        VIdeo_Driver_DateLabel.TabIndex = 44
        VIdeo_Driver_DateLabel.Text = "Driver Date:"
        '
        'VideoDriverVersionLabel
        '
        VideoDriverVersionLabel.AutoSize = True
        VideoDriverVersionLabel.Location = New System.Drawing.Point(6, 72)
        VideoDriverVersionLabel.Name = "VideoDriverVersionLabel"
        VideoDriverVersionLabel.Size = New System.Drawing.Size(76, 13)
        VideoDriverVersionLabel.TabIndex = 46
        VideoDriverVersionLabel.Text = "Driver Version:"
        '
        'Video_NameLabel
        '
        Video_NameLabel.AutoSize = True
        Video_NameLabel.Location = New System.Drawing.Point(6, 98)
        Video_NameLabel.Name = "Video_NameLabel"
        Video_NameLabel.Size = New System.Drawing.Size(38, 13)
        Video_NameLabel.TabIndex = 48
        Video_NameLabel.Text = "Name:"
        '
        'VideoRamLabel
        '
        VideoRamLabel.AutoSize = True
        VideoRamLabel.Location = New System.Drawing.Point(7, 124)
        VideoRamLabel.Name = "VideoRamLabel"
        VideoRamLabel.Size = New System.Drawing.Size(32, 13)
        VideoRamLabel.TabIndex = 50
        VideoRamLabel.Text = "Ram:"
        '
        'Computer_ManufacturerLabel
        '
        Computer_ManufacturerLabel.AutoSize = True
        Computer_ManufacturerLabel.Location = New System.Drawing.Point(6, 50)
        Computer_ManufacturerLabel.Name = "Computer_ManufacturerLabel"
        Computer_ManufacturerLabel.Size = New System.Drawing.Size(70, 13)
        Computer_ManufacturerLabel.TabIndex = 52
        Computer_ManufacturerLabel.Text = "Manufacturer"
        '
        'Computer_ModelLabel
        '
        Computer_ModelLabel.AutoSize = True
        Computer_ModelLabel.Location = New System.Drawing.Point(6, 76)
        Computer_ModelLabel.Name = "Computer_ModelLabel"
        Computer_ModelLabel.Size = New System.Drawing.Size(36, 13)
        Computer_ModelLabel.TabIndex = 54
        Computer_ModelLabel.Text = "Model"
        '
        'NumberOfProcessors0Label
        '
        NumberOfProcessors0Label.AutoSize = True
        NumberOfProcessors0Label.Enabled = False
        NumberOfProcessors0Label.Location = New System.Drawing.Point(4, 70)
        NumberOfProcessors0Label.Name = "NumberOfProcessors0Label"
        NumberOfProcessors0Label.Size = New System.Drawing.Size(122, 13)
        NumberOfProcessors0Label.TabIndex = 56
        NumberOfProcessors0Label.Text = "Number Of Processors0:"
        '
        'OSTimeStampLabel
        '
        OSTimeStampLabel.AutoSize = True
        OSTimeStampLabel.Location = New System.Drawing.Point(5, 134)
        OSTimeStampLabel.Name = "OSTimeStampLabel"
        OSTimeStampLabel.Size = New System.Drawing.Size(63, 13)
        OSTimeStampLabel.TabIndex = 62
        OSTimeStampLabel.Text = "Time Stamp"
        '
        'OS_CaptionLabel
        '
        OS_CaptionLabel.AutoSize = True
        OS_CaptionLabel.Location = New System.Drawing.Point(5, 29)
        OS_CaptionLabel.Name = "OS_CaptionLabel"
        OS_CaptionLabel.Size = New System.Drawing.Size(22, 13)
        OS_CaptionLabel.TabIndex = 10
        OS_CaptionLabel.Text = "OS"
        '
        'LastBootUpTime0Label
        '
        LastBootUpTime0Label.AutoSize = True
        LastBootUpTime0Label.Location = New System.Drawing.Point(7, 124)
        LastBootUpTime0Label.Name = "LastBootUpTime0Label"
        LastBootUpTime0Label.Size = New System.Drawing.Size(69, 13)
        LastBootUpTime0Label.TabIndex = 63
        LastBootUpTime0Label.Text = "Last Boot Up"
        '
        'DtHardwareBindingNavigator
        '
        Me.DtHardwareBindingNavigator.AddNewItem = Nothing
        Me.DtHardwareBindingNavigator.BindingSource = Me.DtHardwareBindingSource
        Me.DtHardwareBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DtHardwareBindingNavigator.DeleteItem = Nothing
        Me.DtHardwareBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.DtHardwareBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DtHardwareBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DtHardwareBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DtHardwareBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DtHardwareBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DtHardwareBindingNavigator.Name = "DtHardwareBindingNavigator"
        Me.DtHardwareBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DtHardwareBindingNavigator.Size = New System.Drawing.Size(1029, 25)
        Me.DtHardwareBindingNavigator.TabIndex = 0
        Me.DtHardwareBindingNavigator.Text = "BindingNavigator1"
        '
        'DtHardwareBindingSource
        '
        Me.DtHardwareBindingSource.DataMember = "dtHardware"
        Me.DtHardwareBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'SMS_EAIDataSet
        '
        Me.SMS_EAIDataSet.DataSetName = "SMS_EAIDataSet"
        Me.SMS_EAIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Netbios_Name0TextBox
        '
        Me.Netbios_Name0TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "Netbios_Name0", True))
        Me.Netbios_Name0TextBox.Enabled = False
        Me.Netbios_Name0TextBox.Location = New System.Drawing.Point(154, 19)
        Me.Netbios_Name0TextBox.Name = "Netbios_Name0TextBox"
        Me.Netbios_Name0TextBox.Size = New System.Drawing.Size(305, 20)
        Me.Netbios_Name0TextBox.TabIndex = 3
        '
        'Proc_NameTextBox
        '
        Me.Proc_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "Proc Name", True))
        Me.Proc_NameTextBox.Enabled = False
        Me.Proc_NameTextBox.Location = New System.Drawing.Point(152, 16)
        Me.Proc_NameTextBox.Name = "Proc_NameTextBox"
        Me.Proc_NameTextBox.Size = New System.Drawing.Size(307, 20)
        Me.Proc_NameTextBox.TabIndex = 5
        '
        'IsMulticore0TextBox
        '
        Me.IsMulticore0TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "IsMulticore0", True))
        Me.IsMulticore0TextBox.Enabled = False
        Me.IsMulticore0TextBox.Location = New System.Drawing.Point(152, 42)
        Me.IsMulticore0TextBox.Name = "IsMulticore0TextBox"
        Me.IsMulticore0TextBox.Size = New System.Drawing.Size(307, 20)
        Me.IsMulticore0TextBox.TabIndex = 7
        '
        'Service_PackTextBox
        '
        Me.Service_PackTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "Service Pack", True))
        Me.Service_PackTextBox.Enabled = False
        Me.Service_PackTextBox.Location = New System.Drawing.Point(153, 78)
        Me.Service_PackTextBox.Name = "Service_PackTextBox"
        Me.Service_PackTextBox.Size = New System.Drawing.Size(290, 20)
        Me.Service_PackTextBox.TabIndex = 15
        '
        'OSD_VersionTextBox
        '
        Me.OSD_VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "OSD Version", True))
        Me.OSD_VersionTextBox.Enabled = False
        Me.OSD_VersionTextBox.Location = New System.Drawing.Point(153, 52)
        Me.OSD_VersionTextBox.Name = "OSD_VersionTextBox"
        Me.OSD_VersionTextBox.Size = New System.Drawing.Size(290, 20)
        Me.OSD_VersionTextBox.TabIndex = 17
        '
        'BiosDescTextBox
        '
        Me.BiosDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "BiosDesc", True))
        Me.BiosDescTextBox.Enabled = False
        Me.BiosDescTextBox.Location = New System.Drawing.Point(154, 19)
        Me.BiosDescTextBox.Name = "BiosDescTextBox"
        Me.BiosDescTextBox.Size = New System.Drawing.Size(307, 20)
        Me.BiosDescTextBox.TabIndex = 29
        '
        'BiosManufacturerTextBox
        '
        Me.BiosManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "BiosManufacturer", True))
        Me.BiosManufacturerTextBox.Enabled = False
        Me.BiosManufacturerTextBox.Location = New System.Drawing.Point(154, 45)
        Me.BiosManufacturerTextBox.Name = "BiosManufacturerTextBox"
        Me.BiosManufacturerTextBox.Size = New System.Drawing.Size(307, 20)
        Me.BiosManufacturerTextBox.TabIndex = 31
        '
        'BiosNameTextBox
        '
        Me.BiosNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "BiosName", True))
        Me.BiosNameTextBox.Enabled = False
        Me.BiosNameTextBox.Location = New System.Drawing.Point(154, 71)
        Me.BiosNameTextBox.Name = "BiosNameTextBox"
        Me.BiosNameTextBox.Size = New System.Drawing.Size(307, 20)
        Me.BiosNameTextBox.TabIndex = 33
        '
        'SerialNumber0TextBox
        '
        Me.SerialNumber0TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "SerialNumber0", True))
        Me.SerialNumber0TextBox.Enabled = False
        Me.SerialNumber0TextBox.Location = New System.Drawing.Point(154, 97)
        Me.SerialNumber0TextBox.Name = "SerialNumber0TextBox"
        Me.SerialNumber0TextBox.Size = New System.Drawing.Size(307, 20)
        Me.SerialNumber0TextBox.TabIndex = 35
        '
        'SMBIOSBIOSVersion0TextBox
        '
        Me.SMBIOSBIOSVersion0TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "SMBIOSBIOSVersion0", True))
        Me.SMBIOSBIOSVersion0TextBox.Enabled = False
        Me.SMBIOSBIOSVersion0TextBox.Location = New System.Drawing.Point(154, 123)
        Me.SMBIOSBIOSVersion0TextBox.Name = "SMBIOSBIOSVersion0TextBox"
        Me.SMBIOSBIOSVersion0TextBox.Size = New System.Drawing.Size(307, 20)
        Me.SMBIOSBIOSVersion0TextBox.TabIndex = 37
        '
        'RamTextBox
        '
        Me.RamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "Ram", True))
        Me.RamTextBox.Enabled = False
        Me.RamTextBox.Location = New System.Drawing.Point(154, 99)
        Me.RamTextBox.Name = "RamTextBox"
        Me.RamTextBox.Size = New System.Drawing.Size(305, 20)
        Me.RamTextBox.TabIndex = 41
        '
        'Video_DescTextBox
        '
        Me.Video_DescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "Video_Desc", True))
        Me.Video_DescTextBox.Enabled = False
        Me.Video_DescTextBox.Location = New System.Drawing.Point(154, 17)
        Me.Video_DescTextBox.Name = "Video_DescTextBox"
        Me.Video_DescTextBox.Size = New System.Drawing.Size(289, 20)
        Me.Video_DescTextBox.TabIndex = 43
        '
        'VideoDriverVersionTextBox
        '
        Me.VideoDriverVersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "VideoDriverVersion", True))
        Me.VideoDriverVersionTextBox.Enabled = False
        Me.VideoDriverVersionTextBox.Location = New System.Drawing.Point(154, 69)
        Me.VideoDriverVersionTextBox.Name = "VideoDriverVersionTextBox"
        Me.VideoDriverVersionTextBox.Size = New System.Drawing.Size(289, 20)
        Me.VideoDriverVersionTextBox.TabIndex = 47
        '
        'Video_NameTextBox
        '
        Me.Video_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "Video_Name", True))
        Me.Video_NameTextBox.Enabled = False
        Me.Video_NameTextBox.Location = New System.Drawing.Point(154, 95)
        Me.Video_NameTextBox.Name = "Video_NameTextBox"
        Me.Video_NameTextBox.Size = New System.Drawing.Size(289, 20)
        Me.Video_NameTextBox.TabIndex = 49
        '
        'VideoRamTextBox
        '
        Me.VideoRamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "VideoRam", True))
        Me.VideoRamTextBox.Enabled = False
        Me.VideoRamTextBox.Location = New System.Drawing.Point(154, 121)
        Me.VideoRamTextBox.Name = "VideoRamTextBox"
        Me.VideoRamTextBox.Size = New System.Drawing.Size(289, 20)
        Me.VideoRamTextBox.TabIndex = 51
        '
        'Computer_ManufacturerTextBox
        '
        Me.Computer_ManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "Computer Manufacturer", True))
        Me.Computer_ManufacturerTextBox.Enabled = False
        Me.Computer_ManufacturerTextBox.Location = New System.Drawing.Point(154, 47)
        Me.Computer_ManufacturerTextBox.Name = "Computer_ManufacturerTextBox"
        Me.Computer_ManufacturerTextBox.Size = New System.Drawing.Size(305, 20)
        Me.Computer_ManufacturerTextBox.TabIndex = 53
        '
        'Computer_ModelTextBox
        '
        Me.Computer_ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "Computer Model", True))
        Me.Computer_ModelTextBox.Enabled = False
        Me.Computer_ModelTextBox.Location = New System.Drawing.Point(154, 73)
        Me.Computer_ModelTextBox.Name = "Computer_ModelTextBox"
        Me.Computer_ModelTextBox.Size = New System.Drawing.Size(305, 20)
        Me.Computer_ModelTextBox.TabIndex = 55
        '
        'NumberOfProcessors0TextBox
        '
        Me.NumberOfProcessors0TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "NumberOfProcessors0", True))
        Me.NumberOfProcessors0TextBox.Enabled = False
        Me.NumberOfProcessors0TextBox.Location = New System.Drawing.Point(152, 67)
        Me.NumberOfProcessors0TextBox.Name = "NumberOfProcessors0TextBox"
        Me.NumberOfProcessors0TextBox.Size = New System.Drawing.Size(307, 20)
        Me.NumberOfProcessors0TextBox.TabIndex = 57
        '
        'gbComputer
        '
        Me.gbComputer.BackColor = System.Drawing.Color.Gainsboro
        Me.gbComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbComputer.Controls.Add(LastBootUpTime0Label)
        Me.gbComputer.Controls.Add(Me.Netbios_Name0TextBox)
        Me.gbComputer.Controls.Add(Netbios_Name0Label)
        Me.gbComputer.Controls.Add(Me.LastBootUpTime0Label1)
        Me.gbComputer.Controls.Add(Me.Computer_ManufacturerTextBox)
        Me.gbComputer.Controls.Add(Computer_ManufacturerLabel)
        Me.gbComputer.Controls.Add(Me.Computer_ModelTextBox)
        Me.gbComputer.Controls.Add(Computer_ModelLabel)
        Me.gbComputer.Controls.Add(Me.RamTextBox)
        Me.gbComputer.Controls.Add(RamLabel)
        Me.gbComputer.Location = New System.Drawing.Point(26, 6)
        Me.gbComputer.Name = "gbComputer"
        Me.gbComputer.Size = New System.Drawing.Size(475, 162)
        Me.gbComputer.TabIndex = 68
        Me.gbComputer.TabStop = False
        Me.gbComputer.Text = "Computer"
        '
        'LastBootUpTime0Label1
        '
        Me.LastBootUpTime0Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "LastBootUpTime0", True))
        Me.LastBootUpTime0Label1.Location = New System.Drawing.Point(151, 124)
        Me.LastBootUpTime0Label1.Name = "LastBootUpTime0Label1"
        Me.LastBootUpTime0Label1.Size = New System.Drawing.Size(292, 23)
        Me.LastBootUpTime0Label1.TabIndex = 64
        Me.LastBootUpTime0Label1.Text = "LastBootUpTime0Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.IsMulticore0TextBox)
        Me.GroupBox1.Controls.Add(IsMulticore0Label)
        Me.GroupBox1.Controls.Add(Me.Proc_NameTextBox)
        Me.GroupBox1.Controls.Add(Proc_NameLabel)
        Me.GroupBox1.Controls.Add(Me.NumberOfProcessors0TextBox)
        Me.GroupBox1.Controls.Add(NumberOfProcessors0Label)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 118)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CPU"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.BiosDescTextBox)
        Me.GroupBox2.Controls.Add(Me.SMBIOSBIOSVersion0TextBox)
        Me.GroupBox2.Controls.Add(SMBIOSBIOSVersion0Label)
        Me.GroupBox2.Controls.Add(Me.SerialNumber0TextBox)
        Me.GroupBox2.Controls.Add(SerialNumber0Label)
        Me.GroupBox2.Controls.Add(Me.BiosNameTextBox)
        Me.GroupBox2.Controls.Add(BiosNameLabel)
        Me.GroupBox2.Controls.Add(Me.BiosManufacturerTextBox)
        Me.GroupBox2.Controls.Add(BiosManufacturerLabel)
        Me.GroupBox2.Controls.Add(BiosDescLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 159)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BIOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.Video_NameTextBox)
        Me.GroupBox3.Controls.Add(Me.VIdeo_Driver_DateLabel2)
        Me.GroupBox3.Controls.Add(Me.VideoRamTextBox)
        Me.GroupBox3.Controls.Add(Video_NameLabel)
        Me.GroupBox3.Controls.Add(Me.VideoDriverVersionTextBox)
        Me.GroupBox3.Controls.Add(VideoDriverVersionLabel)
        Me.GroupBox3.Controls.Add(VIdeo_Driver_DateLabel)
        Me.GroupBox3.Controls.Add(Me.Video_DescTextBox)
        Me.GroupBox3.Controls.Add(Video_DescLabel)
        Me.GroupBox3.Controls.Add(VideoRamLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(507, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 199)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Video Driver"
        '
        'VIdeo_Driver_DateLabel2
        '
        Me.VIdeo_Driver_DateLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "VIdeo_Driver_Date", True))
        Me.VIdeo_Driver_DateLabel2.Enabled = False
        Me.VIdeo_Driver_DateLabel2.Location = New System.Drawing.Point(152, 41)
        Me.VIdeo_Driver_DateLabel2.Name = "VIdeo_Driver_DateLabel2"
        Me.VIdeo_Driver_DateLabel2.Size = New System.Drawing.Size(201, 23)
        Me.VIdeo_Driver_DateLabel2.TabIndex = 73
        Me.VIdeo_Driver_DateLabel2.Text = "Label1"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox4.Controls.Add(Me.OS_InstallDateLabel2)
        Me.GroupBox4.Controls.Add(Me.OSTimeStampLabel2)
        Me.GroupBox4.Controls.Add(Me.OS_CaptionTextBox)
        Me.GroupBox4.Controls.Add(OS_CaptionLabel)
        Me.GroupBox4.Controls.Add(Me.OSD_VersionTextBox)
        Me.GroupBox4.Controls.Add(OSD_VersionLabel)
        Me.GroupBox4.Controls.Add(Me.Service_PackTextBox)
        Me.GroupBox4.Controls.Add(Service_PackLabel)
        Me.GroupBox4.Controls.Add(OS_InstallDateLabel)
        Me.GroupBox4.Controls.Add(OSTimeStampLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(507, 211)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(472, 199)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Operating System"
        '
        'OS_InstallDateLabel2
        '
        Me.OS_InstallDateLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "OS_InstallDate", True))
        Me.OS_InstallDateLabel2.Location = New System.Drawing.Point(150, 108)
        Me.OS_InstallDateLabel2.Name = "OS_InstallDateLabel2"
        Me.OS_InstallDateLabel2.Size = New System.Drawing.Size(294, 23)
        Me.OS_InstallDateLabel2.TabIndex = 73
        Me.OS_InstallDateLabel2.Text = "Label1"
        '
        'OSTimeStampLabel2
        '
        Me.OSTimeStampLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "OSTimeStamp", True))
        Me.OSTimeStampLabel2.Location = New System.Drawing.Point(152, 134)
        Me.OSTimeStampLabel2.Name = "OSTimeStampLabel2"
        Me.OSTimeStampLabel2.Size = New System.Drawing.Size(291, 23)
        Me.OSTimeStampLabel2.TabIndex = 73
        Me.OSTimeStampLabel2.Text = "Label1"
        '
        'OS_CaptionTextBox
        '
        Me.OS_CaptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtHardwareBindingSource, "OS_Caption", True))
        Me.OS_CaptionTextBox.Enabled = False
        Me.OS_CaptionTextBox.Location = New System.Drawing.Point(153, 26)
        Me.OS_CaptionTextBox.Name = "OS_CaptionTextBox"
        Me.OS_CaptionTextBox.Size = New System.Drawing.Size(290, 20)
        Me.OS_CaptionTextBox.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Hardware)
        Me.TabControl1.Controls.Add(Me.tabNetwork)
        Me.TabControl1.Controls.Add(Me.tabAutoStart)
        Me.TabControl1.Controls.Add(Me.tabServices)
        Me.TabControl1.Controls.Add(Me.tabAddRemov)
        Me.TabControl1.Controls.Add(Me.tabFiles)
        Me.TabControl1.Controls.Add(Me.tabSoftInstalledByUser)
        Me.TabControl1.Controls.Add(Me.tabMicrosoftUpdates)
        Me.TabControl1.Controls.Add(Me.tabAdvertisement)
        Me.TabControl1.Location = New System.Drawing.Point(12, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1015, 639)
        Me.TabControl1.TabIndex = 73
        '
        'Hardware
        '
        Me.Hardware.AutoScroll = True
        Me.Hardware.Controls.Add(Me.DtDiskSpaceDataGridView)
        Me.Hardware.Controls.Add(Me.Label9)
        Me.Hardware.Controls.Add(Me.GroupBox4)
        Me.Hardware.Controls.Add(Me.GroupBox3)
        Me.Hardware.Controls.Add(Me.gbComputer)
        Me.Hardware.Controls.Add(Me.GroupBox2)
        Me.Hardware.Controls.Add(Me.GroupBox1)
        Me.Hardware.Location = New System.Drawing.Point(4, 22)
        Me.Hardware.Name = "Hardware"
        Me.Hardware.Padding = New System.Windows.Forms.Padding(3)
        Me.Hardware.Size = New System.Drawing.Size(1007, 613)
        Me.Hardware.TabIndex = 0
        Me.Hardware.Text = "Hardware"
        Me.Hardware.UseVisualStyleBackColor = True
        '
        'DtDiskSpaceDataGridView
        '
        Me.DtDiskSpaceDataGridView.AllowUserToAddRows = False
        Me.DtDiskSpaceDataGridView.AllowUserToDeleteRows = False
        Me.DtDiskSpaceDataGridView.AutoGenerateColumns = False
        Me.DtDiskSpaceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtDiskSpaceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn50})
        Me.DtDiskSpaceDataGridView.DataSource = Me.DtDiskSpaceBindingSource
        Me.DtDiskSpaceDataGridView.Location = New System.Drawing.Point(26, 475)
        Me.DtDiskSpaceDataGridView.Name = "DtDiskSpaceDataGridView"
        Me.DtDiskSpaceDataGridView.Size = New System.Drawing.Size(953, 129)
        Me.DtDiskSpaceDataGridView.TabIndex = 74
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "DeviceID0"
        Me.DataGridViewTextBoxColumn16.HeaderText = "DeviceID0"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Description0"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Description0"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 91
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "VolumeName0"
        Me.DataGridViewTextBoxColumn32.HeaderText = "VolumeName0"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "FileSystem0"
        Me.DataGridViewTextBoxColumn33.HeaderText = "FileSystem0"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Disk_Size GB"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Disk_Size GB"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Free_Space GB"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Free_Space GB"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "TimeStamp"
        Me.DataGridViewTextBoxColumn36.HeaderText = "TimeStamp"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 85
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SystemName0"
        Me.DataGridViewTextBoxColumn13.HeaderText = "SystemName0"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 5
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "SMS_Installed_Sites0"
        Me.DataGridViewTextBoxColumn50.HeaderText = "SMS_Installed_Sites0"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 5
        '
        'DtDiskSpaceBindingSource
        '
        Me.DtDiskSpaceBindingSource.DataMember = "dtDiskSpace"
        Me.DtDiskSpaceBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 459)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Disk Drive(s)"
        '
        'tabNetwork
        '
        Me.tabNetwork.Controls.Add(Me.DtNetworkInfoDataGridView)
        Me.tabNetwork.Location = New System.Drawing.Point(4, 22)
        Me.tabNetwork.Name = "tabNetwork"
        Me.tabNetwork.Size = New System.Drawing.Size(1007, 613)
        Me.tabNetwork.TabIndex = 5
        Me.tabNetwork.Text = "Network"
        Me.tabNetwork.UseVisualStyleBackColor = True
        '
        'DtNetworkInfoDataGridView
        '
        Me.DtNetworkInfoDataGridView.AllowUserToAddRows = False
        Me.DtNetworkInfoDataGridView.AllowUserToDeleteRows = False
        Me.DtNetworkInfoDataGridView.AllowUserToOrderColumns = True
        Me.DtNetworkInfoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtNetworkInfoDataGridView.AutoGenerateColumns = False
        Me.DtNetworkInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtNetworkInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49})
        Me.DtNetworkInfoDataGridView.DataSource = Me.DtNetworkInfoBindingSource
        Me.DtNetworkInfoDataGridView.Location = New System.Drawing.Point(3, 20)
        Me.DtNetworkInfoDataGridView.Name = "DtNetworkInfoDataGridView"
        Me.DtNetworkInfoDataGridView.Size = New System.Drawing.Size(1095, 272)
        Me.DtNetworkInfoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Netbios_Name0"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Netbios_Name0"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 5
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "IPAddress0"
        Me.DataGridViewTextBoxColumn44.HeaderText = "IPAddress0"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "MACAddress0"
        Me.DataGridViewTextBoxColumn47.HeaderText = "MACAddress0"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "ProductName0"
        Me.DataGridViewTextBoxColumn38.HeaderText = "ProductName0"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 5
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "DefaultIPGateway0"
        Me.DataGridViewTextBoxColumn39.HeaderText = "DefaultIPGateway0"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "DHCPEnabled0"
        Me.DataGridViewTextBoxColumn40.HeaderText = "DHCPEnabled0"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "DHCPServer0"
        Me.DataGridViewTextBoxColumn41.HeaderText = "DHCPServer0"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "DNSDomain0"
        Me.DataGridViewTextBoxColumn42.HeaderText = "DNSDomain0"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "DNSHostName0"
        Me.DataGridViewTextBoxColumn43.HeaderText = "DNSHostName0"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "IPEnabled0"
        Me.DataGridViewTextBoxColumn45.HeaderText = "IPEnabled0"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "IPSubnet0"
        Me.DataGridViewTextBoxColumn46.HeaderText = "IPSubnet0"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "NetTimeStamp"
        Me.DataGridViewTextBoxColumn48.HeaderText = "NetTimeStamp"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "SMS_Installed_Sites0"
        Me.DataGridViewTextBoxColumn49.HeaderText = "SMS_Installed_Sites0"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DtNetworkInfoBindingSource
        '
        Me.DtNetworkInfoBindingSource.DataMember = "dtNetworkInfo"
        Me.DtNetworkInfoBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'tabAutoStart
        '
        Me.tabAutoStart.Controls.Add(Me.GroupBox8)
        Me.tabAutoStart.Controls.Add(Me.DtAutoStartProgramsDataGridView)
        Me.tabAutoStart.Location = New System.Drawing.Point(4, 22)
        Me.tabAutoStart.Name = "tabAutoStart"
        Me.tabAutoStart.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAutoStart.Size = New System.Drawing.Size(1007, 613)
        Me.tabAutoStart.TabIndex = 1
        Me.tabAutoStart.Text = "Auto Start"
        Me.tabAutoStart.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtAutoStartFileName)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.txtAutoStartPubName)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.txtAutoStartDesc)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(398, 55)
        Me.GroupBox8.TabIndex = 29
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Filter"
        '
        'txtAutoStartFileName
        '
        Me.txtAutoStartFileName.Location = New System.Drawing.Point(267, 23)
        Me.txtAutoStartFileName.Name = "txtAutoStartFileName"
        Me.txtAutoStartFileName.Size = New System.Drawing.Size(100, 20)
        Me.txtAutoStartFileName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "File Name"
        '
        'txtAutoStartPubName
        '
        Me.txtAutoStartPubName.Location = New System.Drawing.Point(46, 23)
        Me.txtAutoStartPubName.Name = "txtAutoStartPubName"
        Me.txtAutoStartPubName.Size = New System.Drawing.Size(100, 20)
        Me.txtAutoStartPubName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Publisher"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'txtAutoStartDesc
        '
        Me.txtAutoStartDesc.Location = New System.Drawing.Point(155, 23)
        Me.txtAutoStartDesc.Name = "txtAutoStartDesc"
        Me.txtAutoStartDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtAutoStartDesc.TabIndex = 3
        '
        'DtAutoStartProgramsDataGridView
        '
        Me.DtAutoStartProgramsDataGridView.AllowUserToAddRows = False
        Me.DtAutoStartProgramsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtAutoStartProgramsDataGridView.AutoGenerateColumns = False
        Me.DtAutoStartProgramsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtAutoStartProgramsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn6})
        Me.DtAutoStartProgramsDataGridView.ContextMenuStrip = Me.cmsRightClickMenu
        Me.DtAutoStartProgramsDataGridView.DataSource = Me.DtAutoStartProgramsBindingSource
        Me.DtAutoStartProgramsDataGridView.Location = New System.Drawing.Point(6, 67)
        Me.DtAutoStartProgramsDataGridView.Name = "DtAutoStartProgramsDataGridView"
        Me.DtAutoStartProgramsDataGridView.Size = New System.Drawing.Size(1001, 543)
        Me.DtAutoStartProgramsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Netbios_Name0"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Computer"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description0"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 85
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FileName0"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FileName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 5
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FileVersion0"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FileVersion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 83
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TimeStamp"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TimeStamp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 85
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Publisher0"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Publisher"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "StartupValue0"
        Me.DataGridViewTextBoxColumn8.HeaderText = "StartupValue"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 93
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Location0"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'cmsRightClickMenu
        '
        Me.cmsRightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintGridToolStripMenuItem})
        Me.cmsRightClickMenu.Name = "cmsRightClickMenu"
        Me.cmsRightClickMenu.Size = New System.Drawing.Size(125, 26)
        '
        'PrintGridToolStripMenuItem
        '
        Me.PrintGridToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem, Me.SelectedRowsToolStripMenuItem})
        Me.PrintGridToolStripMenuItem.Name = "PrintGridToolStripMenuItem"
        Me.PrintGridToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PrintGridToolStripMenuItem.Text = "Print Grid"
        '
        'AllRowsToolStripMenuItem
        '
        Me.AllRowsToolStripMenuItem.Name = "AllRowsToolStripMenuItem"
        Me.AllRowsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AllRowsToolStripMenuItem.Text = "All Rows"
        '
        'SelectedRowsToolStripMenuItem
        '
        Me.SelectedRowsToolStripMenuItem.Name = "SelectedRowsToolStripMenuItem"
        Me.SelectedRowsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SelectedRowsToolStripMenuItem.Text = "Selected Rows"
        '
        'DtAutoStartProgramsBindingSource
        '
        Me.DtAutoStartProgramsBindingSource.DataMember = "dtAutoStartPrograms"
        Me.DtAutoStartProgramsBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'tabServices
        '
        Me.tabServices.Controls.Add(Me.GroupBox7)
        Me.tabServices.Controls.Add(Me.lblServicesStatus)
        Me.tabServices.Controls.Add(Me.DtServicesDataGridView)
        Me.tabServices.Location = New System.Drawing.Point(4, 22)
        Me.tabServices.Name = "tabServices"
        Me.tabServices.Size = New System.Drawing.Size(1007, 613)
        Me.tabServices.TabIndex = 2
        Me.tabServices.Text = "Services"
        Me.tabServices.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtServicesMode)
        Me.GroupBox7.Controls.Add(Me.txtServicesDisplayName)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.txtServicesPath)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtServicesType)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(481, 55)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Filter"
        '
        'txtServicesMode
        '
        Me.txtServicesMode.Location = New System.Drawing.Point(363, 29)
        Me.txtServicesMode.Name = "txtServicesMode"
        Me.txtServicesMode.Size = New System.Drawing.Size(100, 20)
        Me.txtServicesMode.TabIndex = 15
        '
        'txtServicesDisplayName
        '
        Me.txtServicesDisplayName.Location = New System.Drawing.Point(39, 29)
        Me.txtServicesDisplayName.Name = "txtServicesDisplayName"
        Me.txtServicesDisplayName.Size = New System.Drawing.Size(100, 20)
        Me.txtServicesDisplayName.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(365, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Start Mode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Display Name"
        '
        'txtServicesPath
        '
        Me.txtServicesPath.Location = New System.Drawing.Point(151, 29)
        Me.txtServicesPath.Name = "txtServicesPath"
        Me.txtServicesPath.Size = New System.Drawing.Size(100, 20)
        Me.txtServicesPath.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(259, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Services Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Path"
        '
        'txtServicesType
        '
        Me.txtServicesType.Location = New System.Drawing.Point(257, 29)
        Me.txtServicesType.Name = "txtServicesType"
        Me.txtServicesType.Size = New System.Drawing.Size(100, 20)
        Me.txtServicesType.TabIndex = 13
        '
        'lblServicesStatus
        '
        Me.lblServicesStatus.AutoSize = True
        Me.lblServicesStatus.Location = New System.Drawing.Point(934, 0)
        Me.lblServicesStatus.Name = "lblServicesStatus"
        Me.lblServicesStatus.Size = New System.Drawing.Size(45, 13)
        Me.lblServicesStatus.TabIndex = 28
        Me.lblServicesStatus.Text = "Label14"
        '
        'DtServicesDataGridView
        '
        Me.DtServicesDataGridView.AllowUserToAddRows = False
        Me.DtServicesDataGridView.AllowUserToDeleteRows = False
        Me.DtServicesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtServicesDataGridView.AutoGenerateColumns = False
        Me.DtServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtServicesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn18})
        Me.DtServicesDataGridView.ContextMenuStrip = Me.cmsRightClickMenu
        Me.DtServicesDataGridView.DataSource = Me.DtServicesBindingSource
        Me.DtServicesDataGridView.Location = New System.Drawing.Point(6, 64)
        Me.DtServicesDataGridView.Name = "DtServicesDataGridView"
        Me.DtServicesDataGridView.Size = New System.Drawing.Size(1102, 635)
        Me.DtServicesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Netbios_Name0"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Netbios_Name0"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 5
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DisplayName0"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DisplayName0"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 225
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PathName0"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PathName0"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 325
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ServiceType0"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ServiceType0"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "StartMode0"
        Me.DataGridViewTextBoxColumn14.HeaderText = "StartMode0"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "StartName0"
        Me.DataGridViewTextBoxColumn15.HeaderText = "StartName0"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "TimeStamp"
        Me.DataGridViewTextBoxColumn18.HeaderText = "TimeStamp"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DtServicesBindingSource
        '
        Me.DtServicesBindingSource.DataMember = "dtServices"
        Me.DtServicesBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'tabAddRemov
        '
        Me.tabAddRemov.Controls.Add(Me.chkIncludeKBArticle)
        Me.tabAddRemov.Controls.Add(Me.DtAddRemoveProgramsDataGridView)
        Me.tabAddRemov.Controls.Add(Me.GroupBox5)
        Me.tabAddRemov.Controls.Add(Me.lblAddRemoveStatus)
        Me.tabAddRemov.Controls.Add(Me.btnGetAddRemoveData)
        Me.tabAddRemov.Location = New System.Drawing.Point(4, 22)
        Me.tabAddRemov.Name = "tabAddRemov"
        Me.tabAddRemov.Size = New System.Drawing.Size(1007, 613)
        Me.tabAddRemov.TabIndex = 3
        Me.tabAddRemov.Text = "Add Remove Software"
        Me.tabAddRemov.UseVisualStyleBackColor = True
        '
        'chkIncludeKBArticle
        '
        Me.chkIncludeKBArticle.AutoSize = True
        Me.chkIncludeKBArticle.Location = New System.Drawing.Point(300, 20)
        Me.chkIncludeKBArticle.Name = "chkIncludeKBArticle"
        Me.chkIncludeKBArticle.Size = New System.Drawing.Size(110, 17)
        Me.chkIncludeKBArticle.TabIndex = 30
        Me.chkIncludeKBArticle.Text = "Include KB Article"
        Me.chkIncludeKBArticle.UseVisualStyleBackColor = True
        '
        'DtAddRemoveProgramsDataGridView
        '
        Me.DtAddRemoveProgramsDataGridView.AutoGenerateColumns = False
        Me.DtAddRemoveProgramsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtAddRemoveProgramsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn65})
        Me.DtAddRemoveProgramsDataGridView.DataSource = Me.DtAddRemoveProgramsBindingSource
        Me.DtAddRemoveProgramsDataGridView.Location = New System.Drawing.Point(3, 65)
        Me.DtAddRemoveProgramsDataGridView.Name = "DtAddRemoveProgramsDataGridView"
        Me.DtAddRemoveProgramsDataGridView.Size = New System.Drawing.Size(1001, 545)
        Me.DtAddRemoveProgramsDataGridView.TabIndex = 29
        '
        'DtAddRemoveProgramsBindingSource
        '
        Me.DtAddRemoveProgramsBindingSource.DataMember = "dtAddRemovePrograms"
        Me.DtAddRemoveProgramsBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtAddRemovInstalledLocation)
        Me.GroupBox5.Controls.Add(Me.txtAddRemNormalizedName)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(263, 55)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Filter"
        '
        'txtAddRemovInstalledLocation
        '
        Me.txtAddRemovInstalledLocation.Location = New System.Drawing.Point(127, 29)
        Me.txtAddRemovInstalledLocation.Name = "txtAddRemovInstalledLocation"
        Me.txtAddRemovInstalledLocation.Size = New System.Drawing.Size(100, 20)
        Me.txtAddRemovInstalledLocation.TabIndex = 21
        '
        'txtAddRemNormalizedName
        '
        Me.txtAddRemNormalizedName.Location = New System.Drawing.Point(15, 29)
        Me.txtAddRemNormalizedName.Name = "txtAddRemNormalizedName"
        Me.txtAddRemNormalizedName.Size = New System.Drawing.Size(100, 20)
        Me.txtAddRemNormalizedName.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Display Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(129, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Installed Location"
        '
        'lblAddRemoveStatus
        '
        Me.lblAddRemoveStatus.AutoSize = True
        Me.lblAddRemoveStatus.Location = New System.Drawing.Point(727, 20)
        Me.lblAddRemoveStatus.Name = "lblAddRemoveStatus"
        Me.lblAddRemoveStatus.Size = New System.Drawing.Size(45, 13)
        Me.lblAddRemoveStatus.TabIndex = 27
        Me.lblAddRemoveStatus.Text = "Label14"
        '
        'btnGetAddRemoveData
        '
        Me.btnGetAddRemoveData.Location = New System.Drawing.Point(506, 14)
        Me.btnGetAddRemoveData.Name = "btnGetAddRemoveData"
        Me.btnGetAddRemoveData.Size = New System.Drawing.Size(104, 33)
        Me.btnGetAddRemoveData.TabIndex = 2
        Me.btnGetAddRemoveData.Text = "Get Software List"
        Me.btnGetAddRemoveData.UseVisualStyleBackColor = True
        '
        'tabFiles
        '
        Me.tabFiles.Controls.Add(Me.GroupBox6)
        Me.tabFiles.Controls.Add(Me.lblFilesStatus)
        Me.tabFiles.Controls.Add(Me.btnGetFiles)
        Me.tabFiles.Controls.Add(Me.DtFilesListDataGridView)
        Me.tabFiles.Location = New System.Drawing.Point(4, 22)
        Me.tabFiles.Name = "tabFiles"
        Me.tabFiles.Size = New System.Drawing.Size(1007, 613)
        Me.tabFiles.TabIndex = 4
        Me.tabFiles.Text = "Files"
        Me.tabFiles.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtFilesFilePath)
        Me.GroupBox6.Controls.Add(Me.txtFilesFileName)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txtFilesFileDesc)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(399, 55)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Filter"
        '
        'txtFilesFilePath
        '
        Me.txtFilesFilePath.Location = New System.Drawing.Point(264, 26)
        Me.txtFilesFilePath.Name = "txtFilesFilePath"
        Me.txtFilesFilePath.Size = New System.Drawing.Size(100, 20)
        Me.txtFilesFilePath.TabIndex = 23
        '
        'txtFilesFileName
        '
        Me.txtFilesFileName.Location = New System.Drawing.Point(46, 26)
        Me.txtFilesFileName.Name = "txtFilesFileName"
        Me.txtFilesFileName.Size = New System.Drawing.Size(100, 20)
        Me.txtFilesFileName.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(48, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "File Name"
        '
        'txtFilesFileDesc
        '
        Me.txtFilesFileDesc.Location = New System.Drawing.Point(158, 26)
        Me.txtFilesFileDesc.Name = "txtFilesFileDesc"
        Me.txtFilesFileDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtFilesFileDesc.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(266, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "File Path"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(160, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "File Desc"
        '
        'lblFilesStatus
        '
        Me.lblFilesStatus.AutoSize = True
        Me.lblFilesStatus.Location = New System.Drawing.Point(440, 10)
        Me.lblFilesStatus.Name = "lblFilesStatus"
        Me.lblFilesStatus.Size = New System.Drawing.Size(45, 13)
        Me.lblFilesStatus.TabIndex = 28
        Me.lblFilesStatus.Text = "Label14"
        '
        'btnGetFiles
        '
        Me.btnGetFiles.Location = New System.Drawing.Point(443, 29)
        Me.btnGetFiles.Name = "btnGetFiles"
        Me.btnGetFiles.Size = New System.Drawing.Size(92, 30)
        Me.btnGetFiles.TabIndex = 27
        Me.btnGetFiles.Text = "Get Files"
        Me.btnGetFiles.UseVisualStyleBackColor = True
        '
        'DtFilesListDataGridView
        '
        Me.DtFilesListDataGridView.AllowUserToAddRows = False
        Me.DtFilesListDataGridView.AllowUserToDeleteRows = False
        Me.DtFilesListDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtFilesListDataGridView.AutoGenerateColumns = False
        Me.DtFilesListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtFilesListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.DtFilesListDataGridView.ContextMenuStrip = Me.cmsRightClickMenu
        Me.DtFilesListDataGridView.DataSource = Me.DtFilesListBindingSource
        Me.DtFilesListDataGridView.Location = New System.Drawing.Point(7, 62)
        Me.DtFilesListDataGridView.Name = "DtFilesListDataGridView"
        Me.DtFilesListDataGridView.Size = New System.Drawing.Size(1101, 640)
        Me.DtFilesListDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Netbios_Name0"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Netbios_Name0"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 5
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "FileName"
        Me.DataGridViewTextBoxColumn20.HeaderText = "FileName"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 150
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "FileDescription"
        Me.DataGridViewTextBoxColumn21.HeaderText = "FileDescription"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 150
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "FilePath"
        Me.DataGridViewTextBoxColumn22.HeaderText = "FilePath"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 300
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "FileModifiedDate"
        Me.DataGridViewTextBoxColumn23.HeaderText = "FileModifiedDate"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "RecModifiedDate"
        Me.DataGridViewTextBoxColumn24.HeaderText = "RecModifiedDate"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "File Size (MB)"
        Me.DataGridViewTextBoxColumn25.HeaderText = "File Size (MB)"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "FileVersion"
        Me.DataGridViewTextBoxColumn26.HeaderText = "FileVersion"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 150
        '
        'DtFilesListBindingSource
        '
        Me.DtFilesListBindingSource.DataMember = "dtFilesList"
        Me.DtFilesListBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'tabSoftInstalledByUser
        '
        Me.tabSoftInstalledByUser.Controls.Add(Me.DtSoftwareInstalledByUserDataGridView)
        Me.tabSoftInstalledByUser.Location = New System.Drawing.Point(4, 22)
        Me.tabSoftInstalledByUser.Name = "tabSoftInstalledByUser"
        Me.tabSoftInstalledByUser.Size = New System.Drawing.Size(1007, 613)
        Me.tabSoftInstalledByUser.TabIndex = 7
        Me.tabSoftInstalledByUser.Text = "SoftInstalledByUser"
        Me.tabSoftInstalledByUser.UseVisualStyleBackColor = True
        '
        'DtSoftwareInstalledByUserDataGridView
        '
        Me.DtSoftwareInstalledByUserDataGridView.AllowUserToAddRows = False
        Me.DtSoftwareInstalledByUserDataGridView.AllowUserToDeleteRows = False
        Me.DtSoftwareInstalledByUserDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtSoftwareInstalledByUserDataGridView.AutoGenerateColumns = False
        Me.DtSoftwareInstalledByUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtSoftwareInstalledByUserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55})
        Me.DtSoftwareInstalledByUserDataGridView.ContextMenuStrip = Me.cmsRightClickMenu
        Me.DtSoftwareInstalledByUserDataGridView.DataSource = Me.DtSoftwareInstalledByUserBindingSource
        Me.DtSoftwareInstalledByUserDataGridView.Location = New System.Drawing.Point(3, 79)
        Me.DtSoftwareInstalledByUserDataGridView.Name = "DtSoftwareInstalledByUserDataGridView"
        Me.DtSoftwareInstalledByUserDataGridView.Size = New System.Drawing.Size(1105, 620)
        Me.DtSoftwareInstalledByUserDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "Publisher"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Publisher"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Width = 75
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "Product Name"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "Version"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Version"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "Install Date"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Install Date"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Width = 85
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "Path"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Path"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.Width = 54
        '
        'DtSoftwareInstalledByUserBindingSource
        '
        Me.DtSoftwareInstalledByUserBindingSource.DataMember = "dtSoftwareInstalledByUser"
        Me.DtSoftwareInstalledByUserBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'tabMicrosoftUpdates
        '
        Me.tabMicrosoftUpdates.Controls.Add(Me.lblMSUpdates)
        Me.tabMicrosoftUpdates.Controls.Add(Me.DtSoftwareUpdatesDataGridView)
        Me.tabMicrosoftUpdates.Location = New System.Drawing.Point(4, 22)
        Me.tabMicrosoftUpdates.Name = "tabMicrosoftUpdates"
        Me.tabMicrosoftUpdates.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMicrosoftUpdates.Size = New System.Drawing.Size(1007, 613)
        Me.tabMicrosoftUpdates.TabIndex = 8
        Me.tabMicrosoftUpdates.Text = "Microsoft Updates"
        Me.tabMicrosoftUpdates.UseVisualStyleBackColor = True
        '
        'lblMSUpdates
        '
        Me.lblMSUpdates.AutoSize = True
        Me.lblMSUpdates.Location = New System.Drawing.Point(484, 7)
        Me.lblMSUpdates.Name = "lblMSUpdates"
        Me.lblMSUpdates.Size = New System.Drawing.Size(0, 13)
        Me.lblMSUpdates.TabIndex = 1
        '
        'DtSoftwareUpdatesDataGridView
        '
        Me.DtSoftwareUpdatesDataGridView.AllowUserToAddRows = False
        Me.DtSoftwareUpdatesDataGridView.AllowUserToDeleteRows = False
        Me.DtSoftwareUpdatesDataGridView.AllowUserToOrderColumns = True
        Me.DtSoftwareUpdatesDataGridView.AutoGenerateColumns = False
        Me.DtSoftwareUpdatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtSoftwareUpdatesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64})
        Me.DtSoftwareUpdatesDataGridView.DataSource = Me.DtSoftwareUpdatesBindingSource
        Me.DtSoftwareUpdatesDataGridView.Location = New System.Drawing.Point(6, 40)
        Me.DtSoftwareUpdatesDataGridView.Name = "DtSoftwareUpdatesDataGridView"
        Me.DtSoftwareUpdatesDataGridView.Size = New System.Drawing.Size(995, 572)
        Me.DtSoftwareUpdatesDataGridView.TabIndex = 0
        '
        'DtSoftwareUpdatesBindingSource
        '
        Me.DtSoftwareUpdatesBindingSource.DataMember = "dtSoftwareUpdates"
        Me.DtSoftwareUpdatesBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'DtHardwareTableAdapter
        '
        Me.DtHardwareTableAdapter.ClearBeforeFill = True
        '
        'DtFilesListTableAdapter
        '
        Me.DtFilesListTableAdapter.ClearBeforeFill = True
        '
        'DtDiskSpaceTableAdapter
        '
        Me.DtDiskSpaceTableAdapter.ClearBeforeFill = True
        '
        'DtSoftwareInstalledByUserTableAdapter
        '
        Me.DtSoftwareInstalledByUserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ADLookup.SMS_EAIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DtAutoStartProgramsTableAdapter
        '
        Me.DtAutoStartProgramsTableAdapter.ClearBeforeFill = True
        '
        'DtServicesTableAdapter
        '
        Me.DtServicesTableAdapter.ClearBeforeFill = True
        '
        'DtNetworkInfoTableAdapter
        '
        Me.DtNetworkInfoTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(709, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 28)
        Me.btnClose.TabIndex = 74
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DtSoftwareUpdatesTableAdapter1
        '
        Me.DtSoftwareUpdatesTableAdapter1.ClearBeforeFill = True
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.BackColor = System.Drawing.Color.Transparent
        Me.LabelHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader.Location = New System.Drawing.Point(219, 1)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(129, 24)
        Me.LabelHeader.TabIndex = 75
        Me.LabelHeader.Text = "SCCM  INFO"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DtAddRemoveProgramsTableAdapter1
        '
        Me.DtAddRemoveProgramsTableAdapter1.ClearBeforeFill = True
        '
        'tabAdvertisement
        '
        Me.tabAdvertisement.Controls.Add(Me.DtAdvertisementDetailDataGridView)
        Me.tabAdvertisement.Location = New System.Drawing.Point(4, 22)
        Me.tabAdvertisement.Name = "tabAdvertisement"
        Me.tabAdvertisement.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdvertisement.Size = New System.Drawing.Size(1007, 613)
        Me.tabAdvertisement.TabIndex = 9
        Me.tabAdvertisement.Text = "Advertisement Info"
        Me.tabAdvertisement.UseVisualStyleBackColor = True
        '
        'DtAdvertisementDetailBindingSource
        '
        Me.DtAdvertisementDetailBindingSource.DataMember = "dtAdvertisementDetail"
        Me.DtAdvertisementDetailBindingSource.DataSource = Me.SMS_EAIDataSet
        '
        'DtAdvertisementDetailTableAdapter
        '
        Me.DtAdvertisementDetailTableAdapter.ClearBeforeFill = True
        '
        'DtAdvertisementDetailDataGridView
        '
        Me.DtAdvertisementDetailDataGridView.AllowUserToAddRows = False
        Me.DtAdvertisementDetailDataGridView.AllowUserToDeleteRows = False
        Me.DtAdvertisementDetailDataGridView.AllowUserToOrderColumns = True
        Me.DtAdvertisementDetailDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtAdvertisementDetailDataGridView.AutoGenerateColumns = False
        Me.DtAdvertisementDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtAdvertisementDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn68, Me.DataGridViewTextBoxColumn69, Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn71, Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn74})
        Me.DtAdvertisementDetailDataGridView.DataSource = Me.DtAdvertisementDetailBindingSource
        Me.DtAdvertisementDetailDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.DtAdvertisementDetailDataGridView.Name = "DtAdvertisementDetailDataGridView"
        Me.DtAdvertisementDetailDataGridView.Size = New System.Drawing.Size(1001, 601)
        Me.DtAdvertisementDetailDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "Advertisement id"
        Me.DataGridViewTextBoxColumn67.HeaderText = "Advertisement id"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "Advertisement Name"
        Me.DataGridViewTextBoxColumn68.HeaderText = "Advertisement Name"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn69.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn70.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "Package Name"
        Me.DataGridViewTextBoxColumn71.HeaderText = "Package Name"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "Program Name"
        Me.DataGridViewTextBoxColumn72.HeaderText = "Program Name"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "Site"
        Me.DataGridViewTextBoxColumn73.HeaderText = "Site"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "PresentTime"
        Me.DataGridViewTextBoxColumn74.HeaderText = "PresentTime"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "ArticleID"
        Me.DataGridViewTextBoxColumn58.HeaderText = "ArticleID"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "BulletinID"
        Me.DataGridViewTextBoxColumn59.HeaderText = "BulletinID"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn60.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "StateName"
        Me.DataGridViewTextBoxColumn61.HeaderText = "StateName"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "LastStatusCheckTime"
        Me.DataGridViewTextBoxColumn62.HeaderText = "LastStatusCheckTime"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "LastEnforcementMessageTime"
        Me.DataGridViewTextBoxColumn63.HeaderText = "LastEnforcementMessageTime"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "SMS_Installed_Sites0"
        Me.DataGridViewTextBoxColumn64.HeaderText = "SMS_Installed_Sites0"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "NormalizedName"
        Me.DataGridViewTextBoxColumn28.HeaderText = "NormalizedName"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "ProductVersion0"
        Me.DataGridViewTextBoxColumn29.HeaderText = "ProductVersion0"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "InstalledLocation0"
        Me.DataGridViewTextBoxColumn30.HeaderText = "InstalledLocation0"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "InstallDate0"
        Me.DataGridViewTextBoxColumn31.HeaderText = "InstallDate0"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "SMS_Installed_Sites0"
        Me.DataGridViewTextBoxColumn65.HeaderText = "SMS_Installed_Sites0"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        '
        'Sccmfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 692)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.DtHardwareBindingNavigator)
        Me.Name = "Sccmfrm"
        Me.Text = "SCCM INFO"
        CType(Me.DtHardwareBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DtHardwareBindingNavigator.ResumeLayout(False)
        Me.DtHardwareBindingNavigator.PerformLayout()
        CType(Me.DtHardwareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_EAIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbComputer.ResumeLayout(False)
        Me.gbComputer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Hardware.ResumeLayout(False)
        Me.Hardware.PerformLayout()
        CType(Me.DtDiskSpaceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDiskSpaceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNetwork.ResumeLayout(False)
        CType(Me.DtNetworkInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtNetworkInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAutoStart.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.DtAutoStartProgramsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsRightClickMenu.ResumeLayout(False)
        CType(Me.DtAutoStartProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServices.ResumeLayout(False)
        Me.tabServices.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DtServicesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAddRemov.ResumeLayout(False)
        Me.tabAddRemov.PerformLayout()
        CType(Me.DtAddRemoveProgramsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtAddRemoveProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tabFiles.ResumeLayout(False)
        Me.tabFiles.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DtFilesListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtFilesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSoftInstalledByUser.ResumeLayout(False)
        CType(Me.DtSoftwareInstalledByUserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtSoftwareInstalledByUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMicrosoftUpdates.ResumeLayout(False)
        Me.tabMicrosoftUpdates.PerformLayout()
        CType(Me.DtSoftwareUpdatesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtSoftwareUpdatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdvertisement.ResumeLayout(False)
        CType(Me.DtAdvertisementDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtAdvertisementDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SMS_EAIDataSet As SMS_EAIDataSet
    Friend WithEvents DtHardwareBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtHardwareTableAdapter As SMS_EAIDataSetTableAdapters.dtHardwareTableAdapter
    Friend WithEvents TableAdapterManager As SMS_EAIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DtHardwareBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Netbios_Name0TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Proc_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsMulticore0TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Service_PackTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OSD_VersionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BiosDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BiosManufacturerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BiosNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SerialNumber0TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SMBIOSBIOSVersion0TextBox As System.Windows.Forms.TextBox
    Friend WithEvents RamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Video_DescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VideoDriverVersionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Video_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VideoRamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Computer_ManufacturerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Computer_ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfProcessors0TextBox As System.Windows.Forms.TextBox
    Friend WithEvents gbComputer As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LastBootUpTime0Label1 As System.Windows.Forms.Label
    Friend WithEvents OS_CaptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VIdeo_Driver_DateLabel2 As System.Windows.Forms.Label
    Friend WithEvents OS_InstallDateLabel2 As System.Windows.Forms.Label
    Friend WithEvents OSTimeStampLabel2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Hardware As System.Windows.Forms.TabPage
    Friend WithEvents tabAutoStart As System.Windows.Forms.TabPage
    Friend WithEvents tabServices As System.Windows.Forms.TabPage
    Friend WithEvents tabAddRemov As System.Windows.Forms.TabPage
    Friend WithEvents tabFiles As System.Windows.Forms.TabPage
    Friend WithEvents tabNetwork As System.Windows.Forms.TabPage
    Friend WithEvents btnGetAddRemoveData As System.Windows.Forms.Button
    Friend WithEvents DtAutoStartProgramsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtAutoStartProgramsTableAdapter As ADLookup.SMS_EAIDataSetTableAdapters.dtAutoStartProgramsTableAdapter
    Friend WithEvents DtAutoStartProgramsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DtServicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtServicesTableAdapter As ADLookup.SMS_EAIDataSetTableAdapters.dtServicesTableAdapter
    Friend WithEvents DtServicesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmsRightClickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PrintGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAutoStartFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAutoStartDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAutoStartPubName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtServicesMode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtServicesType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtServicesPath As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtServicesDisplayName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAddRemovInstalledLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAddRemNormalizedName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtFilesFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFilesFileDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFilesFileName As System.Windows.Forms.TextBox
    Friend WithEvents DtFilesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtFilesListTableAdapter As ADLookup.SMS_EAIDataSetTableAdapters.dtFilesListTableAdapter
    Friend WithEvents DtFilesListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DtAddRemoveProgramsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnGetFiles As System.Windows.Forms.Button
    Friend WithEvents lblAddRemoveStatus As System.Windows.Forms.Label
    Friend WithEvents lblServicesStatus As System.Windows.Forms.Label
    Friend WithEvents lblFilesStatus As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtDiskSpaceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtDiskSpaceTableAdapter As ADLookup.SMS_EAIDataSetTableAdapters.dtDiskSpaceTableAdapter
    Friend WithEvents DtNetworkInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtNetworkInfoTableAdapter As ADLookup.SMS_EAIDataSetTableAdapters.dtNetworkInfoTableAdapter
    Friend WithEvents tabSoftInstalledByUser As System.Windows.Forms.TabPage
    Friend WithEvents DtSoftwareInstalledByUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtSoftwareInstalledByUserTableAdapter As ADLookup.SMS_EAIDataSetTableAdapters.dtSoftwareInstalledByUserTableAdapter
    Friend WithEvents DtSoftwareInstalledByUserDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtNetworkInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtDiskSpaceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents tabMicrosoftUpdates As System.Windows.Forms.TabPage
    Friend WithEvents DtSoftwareUpdatesTableAdapter1 As ADLookup.SMS_EAIDataSetTableAdapters.dtSoftwareUpdatesTableAdapter
    Friend WithEvents DtSoftwareUpdatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtSoftwareUpdatesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LabelHeader As System.Windows.Forms.Label
    Friend WithEvents DtAddRemoveProgramsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DtAddRemoveProgramsTableAdapter1 As ADLookup.SMS_EAIDataSetTableAdapters.dtAddRemoveProgramsTableAdapter
    Friend WithEvents chkIncludeKBArticle As System.Windows.Forms.CheckBox
    Friend WithEvents lblMSUpdates As System.Windows.Forms.Label
    Friend WithEvents tabAdvertisement As System.Windows.Forms.TabPage
    Friend WithEvents DtAdvertisementDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtAdvertisementDetailTableAdapter As ADLookup.SMS_EAIDataSetTableAdapters.dtAdvertisementDetailTableAdapter
    Friend WithEvents DtAdvertisementDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
