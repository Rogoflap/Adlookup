<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInfo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmsUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintGridToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowUserInfoSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMemberOfInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportGridToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCtrlCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnlockUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnlockPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelLastUpdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cbdomainlist = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDomain = New System.Windows.Forms.Label()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtManager = New System.Windows.Forms.TextBox()
        Me.lbluserou = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUserOU = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblMemberOf = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtUserMemberOf = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.cbAddMemberofInfo = New System.Windows.Forms.CheckBox()
        Me.cbLocalContacts = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmsUser.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbUser.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmsUser
        '
        Me.cmsUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintGridToolStripMenuItem1, Me.ShowUserInfoSummaryToolStripMenuItem, Me.ShowMemberOfInfoToolStripMenuItem, Me.ExportGridToExcelToolStripMenuItem, Me.CopyCtrlCToolStripMenuItem, Me.UnlockUserToolStripMenuItem})
        Me.cmsUser.Name = "ContextMenuStrip1"
        Me.cmsUser.Size = New System.Drawing.Size(208, 136)
        '
        'PrintGridToolStripMenuItem1
        '
        Me.PrintGridToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem, Me.SelectedRowsToolStripMenuItem})
        Me.PrintGridToolStripMenuItem1.Name = "PrintGridToolStripMenuItem1"
        Me.PrintGridToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.PrintGridToolStripMenuItem1.Text = "Print Grid"
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
        'ShowUserInfoSummaryToolStripMenuItem
        '
        Me.ShowUserInfoSummaryToolStripMenuItem.Name = "ShowUserInfoSummaryToolStripMenuItem"
        Me.ShowUserInfoSummaryToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ShowUserInfoSummaryToolStripMenuItem.Text = "Show User Info Summary"
        '
        'ShowMemberOfInfoToolStripMenuItem
        '
        Me.ShowMemberOfInfoToolStripMenuItem.Name = "ShowMemberOfInfoToolStripMenuItem"
        Me.ShowMemberOfInfoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ShowMemberOfInfoToolStripMenuItem.Text = "Show Members of Group"
        '
        'ExportGridToExcelToolStripMenuItem
        '
        Me.ExportGridToExcelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem1, Me.SelectedRowsToolStripMenuItem1})
        Me.ExportGridToExcelToolStripMenuItem.Name = "ExportGridToExcelToolStripMenuItem"
        Me.ExportGridToExcelToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ExportGridToExcelToolStripMenuItem.Text = "Export Grid to Excel"
        '
        'AllRowsToolStripMenuItem1
        '
        Me.AllRowsToolStripMenuItem1.Name = "AllRowsToolStripMenuItem1"
        Me.AllRowsToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.AllRowsToolStripMenuItem1.Text = "All Rows"
        '
        'SelectedRowsToolStripMenuItem1
        '
        Me.SelectedRowsToolStripMenuItem1.Name = "SelectedRowsToolStripMenuItem1"
        Me.SelectedRowsToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.SelectedRowsToolStripMenuItem1.Text = "Selected Rows"
        '
        'CopyCtrlCToolStripMenuItem
        '
        Me.CopyCtrlCToolStripMenuItem.Name = "CopyCtrlCToolStripMenuItem"
        Me.CopyCtrlCToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CopyCtrlCToolStripMenuItem.Text = "Copy - Ctrl + C"
        '
        'UnlockUserToolStripMenuItem
        '
        Me.UnlockUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnlockPasswordToolStripMenuItem, Me.ToolStripSeparator2, Me.ResetPasswordToolStripMenuItem})
        Me.UnlockUserToolStripMenuItem.Name = "UnlockUserToolStripMenuItem"
        Me.UnlockUserToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.UnlockUserToolStripMenuItem.Text = "User Account"
        '
        'UnlockPasswordToolStripMenuItem
        '
        Me.UnlockPasswordToolStripMenuItem.Name = "UnlockPasswordToolStripMenuItem"
        Me.UnlockPasswordToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.UnlockPasswordToolStripMenuItem.Text = "Unlock User"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'ResetPasswordToolStripMenuItem
        '
        Me.ResetPasswordToolStripMenuItem.Name = "ResetPasswordToolStripMenuItem"
        Me.ResetPasswordToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ResetPasswordToolStripMenuItem.Text = "Reset Users Password"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1531, 24)
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 593)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1531, 22)
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
        'labelLastUpdate
        '
        Me.labelLastUpdate.Name = "labelLastUpdate"
        Me.labelLastUpdate.Size = New System.Drawing.Size(41, 17)
        Me.labelLastUpdate.Text = "Label2"
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1531, 31)
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
        Me.Label13.Location = New System.Drawing.Point(621, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Domain Controller"
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Location = New System.Drawing.Point(717, 29)
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
        Me.LabelHeader.Location = New System.Drawing.Point(261, 23)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(116, 29)
        Me.LabelHeader.TabIndex = 32
        Me.LabelHeader.Text = "AD INFO"
        '
        'gbUser
        '
        Me.gbUser.Controls.Add(Me.Label9)
        Me.gbUser.Controls.Add(Me.txtStatus)
        Me.gbUser.Controls.Add(Me.Label5)
        Me.gbUser.Controls.Add(Me.txtCompany)
        Me.gbUser.Controls.Add(Me.Label18)
        Me.gbUser.Controls.Add(Me.txtManager)
        Me.gbUser.Controls.Add(Me.lbluserou)
        Me.gbUser.Controls.Add(Me.txtName)
        Me.gbUser.Controls.Add(Me.txtUserOU)
        Me.gbUser.Controls.Add(Me.txtUserName)
        Me.gbUser.Controls.Add(Me.lblMemberOf)
        Me.gbUser.Controls.Add(Me.txtemail)
        Me.gbUser.Controls.Add(Me.txtUserMemberOf)
        Me.gbUser.Controls.Add(Me.txtPhone)
        Me.gbUser.Controls.Add(Me.Label8)
        Me.gbUser.Controls.Add(Me.Label1)
        Me.gbUser.Controls.Add(Me.txtLoc)
        Me.gbUser.Controls.Add(Me.Label2)
        Me.gbUser.Controls.Add(Me.Label6)
        Me.gbUser.Controls.Add(Me.Label3)
        Me.gbUser.Controls.Add(Me.Label7)
        Me.gbUser.Controls.Add(Me.Label4)
        Me.gbUser.Controls.Add(Me.txtAddress)
        Me.gbUser.Controls.Add(Me.txtTitle)
        Me.gbUser.Location = New System.Drawing.Point(12, 56)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Size = New System.Drawing.Size(1507, 93)
        Me.gbUser.TabIndex = 34
        Me.gbUser.TabStop = False
        Me.gbUser.Text = "User"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1057, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(1059, 54)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(139, 20)
        Me.txtStatus.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(807, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Company"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(810, 53)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(111, 20)
        Me.txtCompany.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(926, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Manager"
        '
        'txtManager
        '
        Me.txtManager.Location = New System.Drawing.Point(928, 54)
        Me.txtManager.Name = "txtManager"
        Me.txtManager.Size = New System.Drawing.Size(125, 20)
        Me.txtManager.TabIndex = 8
        '
        'lbluserou
        '
        Me.lbluserou.AutoSize = True
        Me.lbluserou.Location = New System.Drawing.Point(1350, 38)
        Me.lbluserou.Name = "lbluserou"
        Me.lbluserou.Size = New System.Drawing.Size(23, 13)
        Me.lbluserou.TabIndex = 41
        Me.lbluserou.Text = "OU"
        Me.lbluserou.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(10, 54)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'txtUserOU
        '
        Me.txtUserOU.Location = New System.Drawing.Point(1353, 54)
        Me.txtUserOU.Name = "txtUserOU"
        Me.txtUserOU.Size = New System.Drawing.Size(145, 20)
        Me.txtUserOU.TabIndex = 9
        Me.txtUserOU.Visible = False
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(328, 54)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(77, 20)
        Me.txtUserName.TabIndex = 4
        '
        'lblMemberOf
        '
        Me.lblMemberOf.AutoSize = True
        Me.lblMemberOf.Location = New System.Drawing.Point(1203, 38)
        Me.lblMemberOf.Name = "lblMemberOf"
        Me.lblMemberOf.Size = New System.Drawing.Size(59, 13)
        Me.lblMemberOf.TabIndex = 39
        Me.lblMemberOf.Text = "Member Of"
        Me.lblMemberOf.Visible = False
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(222, 54)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 3
        '
        'txtUserMemberOf
        '
        Me.txtUserMemberOf.Location = New System.Drawing.Point(1206, 54)
        Me.txtUserMemberOf.Name = "txtUserMemberOf"
        Me.txtUserMemberOf.Size = New System.Drawing.Size(141, 20)
        Me.txtUserMemberOf.TabIndex = 8
        Me.txtUserMemberOf.Visible = False
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(116, 54)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(721, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "LOC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "UserID"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(724, 54)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(76, 20)
        Me.txtLoc.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(542, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(409, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Phone"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(545, 54)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(173, 20)
        Me.txtAddress.TabIndex = 6
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(411, 54)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(126, 20)
        Me.txtTitle.TabIndex = 5
        '
        'cbAddMemberofInfo
        '
        Me.cbAddMemberofInfo.AutoSize = True
        Me.cbAddMemberofInfo.Location = New System.Drawing.Point(429, 38)
        Me.cbAddMemberofInfo.Name = "cbAddMemberofInfo"
        Me.cbAddMemberofInfo.Size = New System.Drawing.Size(123, 17)
        Me.cbAddMemberofInfo.TabIndex = 45
        Me.cbAddMemberofInfo.Text = "Add User Group Info"
        Me.cbAddMemberofInfo.UseVisualStyleBackColor = True
        '
        'cbLocalContacts
        '
        Me.cbLocalContacts.AutoSize = True
        Me.cbLocalContacts.Location = New System.Drawing.Point(429, 21)
        Me.cbLocalContacts.Name = "cbLocalContacts"
        Me.cbLocalContacts.Size = New System.Drawing.Size(119, 17)
        Me.cbLocalContacts.TabIndex = 42
        Me.cbLocalContacts.Text = "Add Local Contacts"
        Me.cbLocalContacts.UseVisualStyleBackColor = True
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
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
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
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(12, 155)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1507, 429)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.TabStop = False
        '
        'UserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1531, 615)
        Me.Controls.Add(Me.gbUser)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.cbAddMemberofInfo)
        Me.Controls.Add(Me.lblDomain)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbdomainlist)
        Me.Controls.Add(Me.cbLocalContacts)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UserInfo"
        Me.Text = "Outlook Contact Lookup "
        Me.cmsUser.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbUser.ResumeLayout(False)
        Me.gbUser.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents cmsUser As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PrintGridToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowUserInfoSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMemberOfInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbdomainlist As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblDomain As System.Windows.Forms.Label
    Friend WithEvents ExportGridToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents LabelHeader As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbUser As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtManager As System.Windows.Forms.TextBox
    Friend WithEvents cbLocalContacts As System.Windows.Forms.CheckBox
    Friend WithEvents lbluserou As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserOU As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblMemberOf As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtUserMemberOf As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents cbAddMemberofInfo As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents AllRowsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents labelLastUpdate As ToolStripStatusLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UnlockUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnlockPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
