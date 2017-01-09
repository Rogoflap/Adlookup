<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralData
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelLastUpdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbQuery = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintGridToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportGridToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.txt16 = New System.Windows.Forms.TextBox()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.txt8 = New System.Windows.Forms.TextBox()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.txt15 = New System.Windows.Forms.TextBox()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.txt7 = New System.Windows.Forms.TextBox()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.txt14 = New System.Windows.Forms.TextBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.txt13 = New System.Windows.Forms.TextBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.txt12 = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.txt11 = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.txt9 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsUser.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.labelLastUpdate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 752)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1252, 22)
        Me.StatusStrip1.TabIndex = 36
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
        Me.DataGridView1.Location = New System.Drawing.Point(9, 141)
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
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1241, 598)
        Me.DataGridView1.TabIndex = 35
        Me.DataGridView1.TabStop = False
        '
        'cmbQuery
        '
        Me.cmbQuery.FormattingEnabled = True
        Me.cmbQuery.Items.AddRange(New Object() {"Item Last Usage", "BOL", "ConfirmShip", "Customer List", "DIFF QOH", "Dropship Order", "Late Order", "LOC QOH", "New Item Created", "Order Loc DropShip", "PO Email", "PO Request", "Price Code List", "Quarintine Inventory", "RMA", "Serial QOH", "Transit Transfer Approved", "Unique Ship Via Codes", "Vendor Sales Person", "Exact Users - Roles", "Exact Table List", "WISYS Users", "PO Cost VS Standard", "99999 Contacts"})
        Me.cmbQuery.Location = New System.Drawing.Point(92, 21)
        Me.cmbQuery.Name = "cmbQuery"
        Me.cmbQuery.Size = New System.Drawing.Size(348, 21)
        Me.cmbQuery.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Query"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 50000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'PrintGridToolStripMenuItem1
        '
        Me.PrintGridToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem, Me.SelectedRowsToolStripMenuItem})
        Me.PrintGridToolStripMenuItem1.Name = "PrintGridToolStripMenuItem1"
        Me.PrintGridToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
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
        'ExportGridToExcelToolStripMenuItem
        '
        Me.ExportGridToExcelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem1, Me.SelectedRowsToolStripMenuItem1})
        Me.ExportGridToExcelToolStripMenuItem.Name = "ExportGridToExcelToolStripMenuItem"
        Me.ExportGridToExcelToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
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
        'cmsUser
        '
        Me.cmsUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintGridToolStripMenuItem1, Me.ExportGridToExcelToolStripMenuItem})
        Me.cmsUser.Name = "ContextMenuStrip1"
        Me.cmsUser.Size = New System.Drawing.Size(176, 48)
        '
        'cmbCompany
        '
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Items.AddRange(New Object() {"100", "200", "210", "250", "260", "270", "630", "640", "660", "680"})
        Me.cmbCompany.Location = New System.Drawing.Point(14, 21)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(66, 21)
        Me.cmbCompany.TabIndex = 41
        Me.cmbCompany.Text = "200"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(44, 11)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(61, 13)
        Me.lbl1.TabIndex = 42
        Me.lbl1.Text = "Parameter1"
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.BackColor = System.Drawing.Color.Transparent
        Me.LabelHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader.Location = New System.Drawing.Point(547, 13)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(116, 29)
        Me.LabelHeader.TabIndex = 43
        Me.LabelHeader.Text = "AD INFO"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(446, 19)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefresh.TabIndex = 44
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl16)
        Me.GroupBox1.Controls.Add(Me.txt16)
        Me.GroupBox1.Controls.Add(Me.lbl8)
        Me.GroupBox1.Controls.Add(Me.txt8)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.lbl15)
        Me.GroupBox1.Controls.Add(Me.txt15)
        Me.GroupBox1.Controls.Add(Me.lbl7)
        Me.GroupBox1.Controls.Add(Me.txt7)
        Me.GroupBox1.Controls.Add(Me.lbl14)
        Me.GroupBox1.Controls.Add(Me.txt14)
        Me.GroupBox1.Controls.Add(Me.lbl6)
        Me.GroupBox1.Controls.Add(Me.txt6)
        Me.GroupBox1.Controls.Add(Me.lbl13)
        Me.GroupBox1.Controls.Add(Me.txt13)
        Me.GroupBox1.Controls.Add(Me.lbl5)
        Me.GroupBox1.Controls.Add(Me.txt5)
        Me.GroupBox1.Controls.Add(Me.lbl12)
        Me.GroupBox1.Controls.Add(Me.txt12)
        Me.GroupBox1.Controls.Add(Me.lbl4)
        Me.GroupBox1.Controls.Add(Me.txt4)
        Me.GroupBox1.Controls.Add(Me.lbl11)
        Me.GroupBox1.Controls.Add(Me.txt11)
        Me.GroupBox1.Controls.Add(Me.lbl3)
        Me.GroupBox1.Controls.Add(Me.txt3)
        Me.GroupBox1.Controls.Add(Me.lbl10)
        Me.GroupBox1.Controls.Add(Me.txt10)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.lbl9)
        Me.GroupBox1.Controls.Add(Me.txt9)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1017, 89)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'lbl16
        '
        Me.lbl16.AutoSize = True
        Me.lbl16.Location = New System.Drawing.Point(818, 50)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(55, 13)
        Me.lbl16.TabIndex = 65
        Me.lbl16.Text = "Parameter"
        '
        'txt16
        '
        Me.txt16.Location = New System.Drawing.Point(821, 63)
        Me.txt16.Name = "txt16"
        Me.txt16.Size = New System.Drawing.Size(102, 20)
        Me.txt16.TabIndex = 21
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Location = New System.Drawing.Point(818, 14)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(55, 13)
        Me.lbl8.TabIndex = 63
        Me.lbl8.Text = "Parameter"
        '
        'txt8
        '
        Me.txt8.Location = New System.Drawing.Point(821, 27)
        Me.txt8.Name = "txt8"
        Me.txt8.Size = New System.Drawing.Size(102, 20)
        Me.txt8.TabIndex = 13
        '
        'lbl15
        '
        Me.lbl15.AutoSize = True
        Me.lbl15.Location = New System.Drawing.Point(707, 50)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(55, 13)
        Me.lbl15.TabIndex = 61
        Me.lbl15.Text = "Parameter"
        '
        'txt15
        '
        Me.txt15.Location = New System.Drawing.Point(710, 63)
        Me.txt15.Name = "txt15"
        Me.txt15.Size = New System.Drawing.Size(102, 20)
        Me.txt15.TabIndex = 20
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Location = New System.Drawing.Point(707, 14)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(55, 13)
        Me.lbl7.TabIndex = 59
        Me.lbl7.Text = "Parameter"
        '
        'txt7
        '
        Me.txt7.Location = New System.Drawing.Point(710, 27)
        Me.txt7.Name = "txt7"
        Me.txt7.Size = New System.Drawing.Size(102, 20)
        Me.txt7.TabIndex = 12
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.Location = New System.Drawing.Point(599, 50)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(55, 13)
        Me.lbl14.TabIndex = 57
        Me.lbl14.Text = "Parameter"
        '
        'txt14
        '
        Me.txt14.Location = New System.Drawing.Point(602, 63)
        Me.txt14.Name = "txt14"
        Me.txt14.Size = New System.Drawing.Size(102, 20)
        Me.txt14.TabIndex = 19
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(599, 14)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(55, 13)
        Me.lbl6.TabIndex = 55
        Me.lbl6.Text = "Parameter"
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(602, 27)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(102, 20)
        Me.txt6.TabIndex = 11
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Location = New System.Drawing.Point(488, 50)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(55, 13)
        Me.lbl13.TabIndex = 53
        Me.lbl13.Text = "Parameter"
        '
        'txt13
        '
        Me.txt13.Location = New System.Drawing.Point(491, 63)
        Me.txt13.Name = "txt13"
        Me.txt13.Size = New System.Drawing.Size(102, 20)
        Me.txt13.TabIndex = 18
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(488, 14)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(55, 13)
        Me.lbl5.TabIndex = 51
        Me.lbl5.Text = "Parameter"
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(491, 27)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(102, 20)
        Me.txt5.TabIndex = 10
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Location = New System.Drawing.Point(377, 50)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(55, 13)
        Me.lbl12.TabIndex = 49
        Me.lbl12.Text = "Parameter"
        '
        'txt12
        '
        Me.txt12.Location = New System.Drawing.Point(380, 63)
        Me.txt12.Name = "txt12"
        Me.txt12.Size = New System.Drawing.Size(102, 20)
        Me.txt12.TabIndex = 17
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(377, 14)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(55, 13)
        Me.lbl4.TabIndex = 47
        Me.lbl4.Text = "Parameter"
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(380, 27)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(102, 20)
        Me.txt4.TabIndex = 9
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(266, 50)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(55, 13)
        Me.lbl11.TabIndex = 45
        Me.lbl11.Text = "Parameter"
        '
        'txt11
        '
        Me.txt11.Location = New System.Drawing.Point(269, 63)
        Me.txt11.Name = "txt11"
        Me.txt11.Size = New System.Drawing.Size(102, 20)
        Me.txt11.TabIndex = 16
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(266, 14)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(55, 13)
        Me.lbl3.TabIndex = 43
        Me.lbl3.Text = "Parameter"
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(269, 27)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(102, 20)
        Me.txt3.TabIndex = 8
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(155, 50)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(55, 13)
        Me.lbl10.TabIndex = 41
        Me.lbl10.Text = "Parameter"
        '
        'txt10
        '
        Me.txt10.Location = New System.Drawing.Point(158, 63)
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(102, 20)
        Me.txt10.TabIndex = 15
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(155, 14)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(55, 13)
        Me.lbl2.TabIndex = 39
        Me.lbl2.Text = "Parameter"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(158, 27)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(102, 20)
        Me.txt2.TabIndex = 7
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Location = New System.Drawing.Point(44, 50)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(55, 13)
        Me.lbl9.TabIndex = 37
        Me.lbl9.Text = "Parameter"
        '
        'txt9
        '
        Me.txt9.Location = New System.Drawing.Point(47, 63)
        Me.txt9.Name = "txt9"
        Me.txt9.Size = New System.Drawing.Size(102, 20)
        Me.txt9.TabIndex = 14
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(47, 27)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(102, 20)
        Me.txt1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "DB"
        '
        'GeneralData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 774)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.cmbCompany)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbQuery)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "GeneralData"
        Me.Text = "GeneralData"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsUser.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbQuery As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PrintGridToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AllRowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportGridToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllRowsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents cmsUser As ContextMenuStrip
    Friend WithEvents cmbCompany As ComboBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents LabelHeader As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl16 As Label
    Friend WithEvents txt16 As TextBox
    Friend WithEvents lbl8 As Label
    Friend WithEvents txt8 As TextBox
    Friend WithEvents lbl15 As Label
    Friend WithEvents txt15 As TextBox
    Friend WithEvents lbl7 As Label
    Friend WithEvents txt7 As TextBox
    Friend WithEvents lbl14 As Label
    Friend WithEvents txt14 As TextBox
    Friend WithEvents lbl6 As Label
    Friend WithEvents txt6 As TextBox
    Friend WithEvents lbl13 As Label
    Friend WithEvents txt13 As TextBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents txt5 As TextBox
    Friend WithEvents lbl12 As Label
    Friend WithEvents txt12 As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txt4 As TextBox
    Friend WithEvents lbl11 As Label
    Friend WithEvents txt11 As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txt3 As TextBox
    Friend WithEvents lbl10 As Label
    Friend WithEvents txt10 As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents lbl9 As Label
    Friend WithEvents txt9 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents labelLastUpdate As ToolStripStatusLabel
End Class
