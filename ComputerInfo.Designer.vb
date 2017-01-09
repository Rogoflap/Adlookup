<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComputerInfo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComputerInfo))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cmsComputer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PingMachineToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCCMInfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamewareMachineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteDesktopMachineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintGridToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbdomainlist = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDomain = New System.Windows.Forms.Label()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.gbComp = New System.Windows.Forms.GroupBox()
        Me.txtCompUser = New System.Windows.Forms.TextBox()
        Me.lblCompName = New System.Windows.Forms.Label()
        Me.txtCompUserID = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextCompOu = New System.Windows.Forms.TextBox()
        Me.txtCompLoc = New System.Windows.Forms.TextBox()
        Me.ServicePrincipal = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCompCompName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.labelLastUpdate = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.cmsComputer.SuspendLayout()
        Me.gbComp.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1177, 336)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1201, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshGridToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ReadToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        Me.DataToolStripMenuItem.Visible = False
        '
        'RefreshGridToolStripMenuItem
        '
        Me.RefreshGridToolStripMenuItem.Name = "RefreshGridToolStripMenuItem"
        Me.RefreshGridToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.RefreshGridToolStripMenuItem.Text = "Refresh Grid"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SaveToolStripMenuItem.Text = "Save To XML"
        Me.SaveToolStripMenuItem.Visible = False
        '
        'ReadToolStripMenuItem
        '
        Me.ReadToolStripMenuItem.Name = "ReadToolStripMenuItem"
        Me.ReadToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ReadToolStripMenuItem.Text = "Read From XML"
        Me.ReadToolStripMenuItem.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.labelLastUpdate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 500)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1201, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(46, 17)
        Me.tsslStatus.Text = "Testing"
        Me.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 50000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRefresh, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1201, 31)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbRefresh
        '
        Me.tsbRefresh.Image = CType(resources.GetObject("tsbRefresh.Image"), System.Drawing.Image)
        Me.tsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(74, 28)
        Me.tsbRefresh.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(111, 28)
        Me.ToolStripButton1.Text = "Show Grid Lines"
        '
        'cmsComputer
        '
        Me.cmsComputer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PingMachineToolStripMenuItem1, Me.SCCMInfoToolStripMenuItem1, Me.DamewareMachineToolStripMenuItem, Me.RemoteDesktopMachineToolStripMenuItem, Me.PrintGridToolStripMenuItem2, Me.ExportToExcelToolStripMenuItem})
        Me.cmsComputer.Name = "cmsComputer"
        Me.cmsComputer.Size = New System.Drawing.Size(211, 136)
        '
        'PingMachineToolStripMenuItem1
        '
        Me.PingMachineToolStripMenuItem1.Name = "PingMachineToolStripMenuItem1"
        Me.PingMachineToolStripMenuItem1.Size = New System.Drawing.Size(210, 22)
        Me.PingMachineToolStripMenuItem1.Text = "Ping Machine"
        '
        'SCCMInfoToolStripMenuItem1
        '
        Me.SCCMInfoToolStripMenuItem1.Name = "SCCMInfoToolStripMenuItem1"
        Me.SCCMInfoToolStripMenuItem1.Size = New System.Drawing.Size(210, 22)
        Me.SCCMInfoToolStripMenuItem1.Text = "SCCM Info"
        Me.SCCMInfoToolStripMenuItem1.Visible = False
        '
        'DamewareMachineToolStripMenuItem
        '
        Me.DamewareMachineToolStripMenuItem.Name = "DamewareMachineToolStripMenuItem"
        Me.DamewareMachineToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.DamewareMachineToolStripMenuItem.Text = "Dameware Machine"
        Me.DamewareMachineToolStripMenuItem.Visible = False
        '
        'RemoteDesktopMachineToolStripMenuItem
        '
        Me.RemoteDesktopMachineToolStripMenuItem.Name = "RemoteDesktopMachineToolStripMenuItem"
        Me.RemoteDesktopMachineToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.RemoteDesktopMachineToolStripMenuItem.Text = "Remote Desktop Machine"
        '
        'PrintGridToolStripMenuItem2
        '
        Me.PrintGridToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem2, Me.SelectedRowsToolStripMenuItem2})
        Me.PrintGridToolStripMenuItem2.Name = "PrintGridToolStripMenuItem2"
        Me.PrintGridToolStripMenuItem2.Size = New System.Drawing.Size(210, 22)
        Me.PrintGridToolStripMenuItem2.Text = "Print Grid"
        '
        'AllRowsToolStripMenuItem2
        '
        Me.AllRowsToolStripMenuItem2.Name = "AllRowsToolStripMenuItem2"
        Me.AllRowsToolStripMenuItem2.Size = New System.Drawing.Size(149, 22)
        Me.AllRowsToolStripMenuItem2.Text = "All Rows"
        '
        'SelectedRowsToolStripMenuItem2
        '
        Me.SelectedRowsToolStripMenuItem2.Name = "SelectedRowsToolStripMenuItem2"
        Me.SelectedRowsToolStripMenuItem2.Size = New System.Drawing.Size(149, 22)
        Me.SelectedRowsToolStripMenuItem2.Text = "Selected Rows"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem, Me.SelectedRowsToolStripMenuItem})
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export To Excel"
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
        'cbdomainlist
        '
        Me.cbdomainlist.FormattingEnabled = True
        Me.cbdomainlist.Location = New System.Drawing.Point(771, 21)
        Me.cbdomainlist.Name = "cbdomainlist"
        Me.cbdomainlist.Size = New System.Drawing.Size(179, 21)
        Me.cbdomainlist.TabIndex = 29
        Me.cbdomainlist.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(544, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Domain Controller"
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Location = New System.Drawing.Point(640, 29)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(45, 13)
        Me.lblDomain.TabIndex = 31
        Me.lblDomain.Text = "Label14"
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.BackColor = System.Drawing.Color.Transparent
        Me.LabelHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader.Location = New System.Drawing.Point(288, 17)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(116, 29)
        Me.LabelHeader.TabIndex = 32
        Me.LabelHeader.Text = "AD INFO"
        '
        'gbComp
        '
        Me.gbComp.Controls.Add(Me.txtCompUser)
        Me.gbComp.Controls.Add(Me.lblCompName)
        Me.gbComp.Controls.Add(Me.txtCompUserID)
        Me.gbComp.Controls.Add(Me.Label21)
        Me.gbComp.Controls.Add(Me.Label19)
        Me.gbComp.Controls.Add(Me.TextCompOu)
        Me.gbComp.Controls.Add(Me.txtCompLoc)
        Me.gbComp.Controls.Add(Me.ServicePrincipal)
        Me.gbComp.Controls.Add(Me.txtVersion)
        Me.gbComp.Controls.Add(Me.Label17)
        Me.gbComp.Controls.Add(Me.txtOS)
        Me.gbComp.Controls.Add(Me.Label16)
        Me.gbComp.Controls.Add(Me.txtCompCompName)
        Me.gbComp.Controls.Add(Me.Label15)
        Me.gbComp.Location = New System.Drawing.Point(12, 66)
        Me.gbComp.Name = "gbComp"
        Me.gbComp.Size = New System.Drawing.Size(891, 83)
        Me.gbComp.TabIndex = 28
        Me.gbComp.TabStop = False
        Me.gbComp.Text = "Computer Info"
        '
        'txtCompUser
        '
        Me.txtCompUser.Location = New System.Drawing.Point(13, 59)
        Me.txtCompUser.Name = "txtCompUser"
        Me.txtCompUser.Size = New System.Drawing.Size(108, 20)
        Me.txtCompUser.TabIndex = 26
        '
        'lblCompName
        '
        Me.lblCompName.AutoSize = True
        Me.lblCompName.Location = New System.Drawing.Point(10, 43)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(29, 13)
        Me.lblCompName.TabIndex = 47
        Me.lblCompName.Text = "User"
        '
        'txtCompUserID
        '
        Me.txtCompUserID.Location = New System.Drawing.Point(130, 59)
        Me.txtCompUserID.Name = "txtCompUserID"
        Me.txtCompUserID.Size = New System.Drawing.Size(74, 20)
        Me.txtCompUserID.TabIndex = 27
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(128, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "UserID"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(651, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 13)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "OU"
        '
        'TextCompOu
        '
        Me.TextCompOu.Location = New System.Drawing.Point(649, 59)
        Me.TextCompOu.Name = "TextCompOu"
        Me.TextCompOu.Size = New System.Drawing.Size(219, 20)
        Me.TextCompOu.TabIndex = 42
        '
        'txtCompLoc
        '
        Me.txtCompLoc.Location = New System.Drawing.Point(540, 59)
        Me.txtCompLoc.Name = "txtCompLoc"
        Me.txtCompLoc.Size = New System.Drawing.Size(100, 20)
        Me.txtCompLoc.TabIndex = 32
        '
        'ServicePrincipal
        '
        Me.ServicePrincipal.AutoSize = True
        Me.ServicePrincipal.Location = New System.Drawing.Point(546, 43)
        Me.ServicePrincipal.Name = "ServicePrincipal"
        Me.ServicePrincipal.Size = New System.Drawing.Size(28, 13)
        Me.ServicePrincipal.TabIndex = 33
        Me.ServicePrincipal.Text = "LOC"
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(431, 59)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(100, 20)
        Me.txtVersion.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(435, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "SP"
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(322, 59)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(100, 20)
        Me.txtOS.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(329, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "OS"
        '
        'txtCompCompName
        '
        Me.txtCompCompName.Location = New System.Drawing.Point(213, 59)
        Me.txtCompCompName.Name = "txtCompCompName"
        Me.txtCompCompName.Size = New System.Drawing.Size(100, 20)
        Me.txtCompCompName.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(211, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Computer Name"
        '
        'labelLastUpdate
        '
        Me.labelLastUpdate.Name = "labelLastUpdate"
        Me.labelLastUpdate.Size = New System.Drawing.Size(41, 17)
        Me.labelLastUpdate.Text = "Label2"
        '
        'ComputerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 522)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.gbComp)
        Me.Controls.Add(Me.lblDomain)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbdomainlist)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ComputerInfo"
        Me.Text = "Outlook Contact Lookup   (Alt-Space to Hide / Visible)"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.cmsComputer.ResumeLayout(False)
        Me.gbComp.ResumeLayout(False)
        Me.gbComp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents cmsComputer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PingMachineToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SCCMInfoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DamewareMachineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteDesktopMachineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintGridToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllRowsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbdomainlist As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblDomain As System.Windows.Forms.Label
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents LabelHeader As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbComp As System.Windows.Forms.GroupBox
    Friend WithEvents txtCompUser As System.Windows.Forms.TextBox
    Friend WithEvents lblCompName As System.Windows.Forms.Label
    Friend WithEvents txtCompUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextCompOu As System.Windows.Forms.TextBox
    Friend WithEvents txtCompLoc As System.Windows.Forms.TextBox
    Friend WithEvents ServicePrincipal As System.Windows.Forms.Label
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCompCompName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents AllRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents labelLastUpdate As ToolStripStatusLabel
End Class
