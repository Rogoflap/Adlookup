<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserGroupInfo

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserGroupInfo))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmsUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintGridToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowUserInfoSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMemberOfInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportGridToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelLastUpdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbUserAdGroup = New System.Windows.Forms.GroupBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMemberOf = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMembers = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cbdomainlist = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDomain = New System.Windows.Forms.Label()
        Me.LabelHeader = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsUser.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbUserAdGroup.SuspendLayout()
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
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ContextMenuStrip = Me.cmsUser
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(908, 336)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.TabStop = False
        '
        'cmsUser
        '
        Me.cmsUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintGridToolStripMenuItem1, Me.ShowUserInfoSummaryToolStripMenuItem, Me.ShowMemberOfInfoToolStripMenuItem, Me.ExportGridToExcelToolStripMenuItem})
        Me.cmsUser.Name = "ContextMenuStrip1"
        Me.cmsUser.Size = New System.Drawing.Size(207, 92)
        '
        'PrintGridToolStripMenuItem1
        '
        Me.PrintGridToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem, Me.SelectedRowsToolStripMenuItem})
        Me.PrintGridToolStripMenuItem1.Name = "PrintGridToolStripMenuItem1"
        Me.PrintGridToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
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
        Me.ShowUserInfoSummaryToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ShowUserInfoSummaryToolStripMenuItem.Text = "Show Members of Group"
        '
        'ShowMemberOfInfoToolStripMenuItem
        '
        Me.ShowMemberOfInfoToolStripMenuItem.Name = "ShowMemberOfInfoToolStripMenuItem"
        Me.ShowMemberOfInfoToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ShowMemberOfInfoToolStripMenuItem.Text = "Show Member of Info"
        '
        'ExportGridToExcelToolStripMenuItem
        '
        Me.ExportGridToExcelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem1, Me.SelectedRowsToolStripMenuItem1})
        Me.ExportGridToExcelToolStripMenuItem.Name = "ExportGridToExcelToolStripMenuItem"
        Me.ExportGridToExcelToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 24)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(329, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(332, 39)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(176, 20)
        Me.txtDescription.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Name"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(6, 40)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(159, 20)
        Me.txtFullName.TabIndex = 32
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.labelLastUpdate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 500)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(932, 22)
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
        Me.labelLastUpdate.Size = New System.Drawing.Size(121, 17)
        Me.labelLastUpdate.Text = "ToolStripStatusLabel1"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 50000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRefresh, Me.ToolStripButton1, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(932, 31)
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(111, 28)
        Me.ToolStripButton1.Text = "Show Grid Lines"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'gbUserAdGroup
        '
        Me.gbUserAdGroup.Controls.Add(Me.txtMail)
        Me.gbUserAdGroup.Controls.Add(Me.Label1)
        Me.gbUserAdGroup.Controls.Add(Me.Label20)
        Me.gbUserAdGroup.Controls.Add(Me.txtMemberOf)
        Me.gbUserAdGroup.Controls.Add(Me.Label14)
        Me.gbUserAdGroup.Controls.Add(Me.txtMembers)
        Me.gbUserAdGroup.Controls.Add(Me.Label10)
        Me.gbUserAdGroup.Controls.Add(Me.txtFullName)
        Me.gbUserAdGroup.Controls.Add(Me.txtDescription)
        Me.gbUserAdGroup.Controls.Add(Me.Label11)
        Me.gbUserAdGroup.Location = New System.Drawing.Point(12, 56)
        Me.gbUserAdGroup.Name = "gbUserAdGroup"
        Me.gbUserAdGroup.Size = New System.Drawing.Size(908, 65)
        Me.gbUserAdGroup.TabIndex = 25
        Me.gbUserAdGroup.TabStop = False
        Me.gbUserAdGroup.Text = "User Group"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(166, 39)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(159, 20)
        Me.txtMail.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Mail"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(514, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "MemberOf"
        '
        'txtMemberOf
        '
        Me.txtMemberOf.Location = New System.Drawing.Point(514, 39)
        Me.txtMemberOf.Name = "txtMemberOf"
        Me.txtMemberOf.Size = New System.Drawing.Size(176, 20)
        Me.txtMemberOf.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(693, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Members"
        '
        'txtMembers
        '
        Me.txtMembers.Location = New System.Drawing.Point(696, 39)
        Me.txtMembers.Name = "txtMembers"
        Me.txtMembers.Size = New System.Drawing.Size(155, 20)
        Me.txtMembers.TabIndex = 34
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
        'UserGroupInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 522)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.gbUserAdGroup)
        Me.Controls.Add(Me.lblDomain)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbdomainlist)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UserGroupInfo"
        Me.Text = "Outlook Contact Lookup   (Alt-Space to Hide / Visible)"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsUser.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.gbUserAdGroup.ResumeLayout(false)
        Me.gbUserAdGroup.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents gbUserAdGroup As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMemberOf As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMembers As System.Windows.Forms.TextBox
    Friend WithEvents LabelHeader As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AllRowsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents labelLastUpdate As ToolStripStatusLabel
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label1 As Label
End Class
