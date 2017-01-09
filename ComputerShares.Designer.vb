<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Computershares
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
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.cmsComputer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PingMachineToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCCMInfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamewareMachineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteDesktopMachineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintGridToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportGridToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowComputerSharesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllComputersInGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGetData = New System.Windows.Forms.Button()
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvReports,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsComputer.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'dgvReports
        '
        Me.dgvReports.AllowUserToAddRows = false
        Me.dgvReports.AllowUserToDeleteRows = false
        Me.dgvReports.AllowUserToOrderColumns = true
        Me.dgvReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.ContextMenuStrip = Me.cmsComputer
        Me.dgvReports.Location = New System.Drawing.Point(-6, 140)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.Size = New System.Drawing.Size(1057, 357)
        Me.dgvReports.TabIndex = 0
        '
        'cmsComputer
        '
        Me.cmsComputer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PingMachineToolStripMenuItem1, Me.SCCMInfoToolStripMenuItem1, Me.DamewareMachineToolStripMenuItem, Me.RemoteDesktopMachineToolStripMenuItem, Me.PrintGridToolStripMenuItem2, Me.ExportGridToExcelToolStripMenuItem, Me.ShowComputerSharesToolStripMenuItem})
        Me.cmsComputer.Name = "cmsComputer"
        Me.cmsComputer.Size = New System.Drawing.Size(211, 158)
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
        '
        'DamewareMachineToolStripMenuItem
        '
        Me.DamewareMachineToolStripMenuItem.Name = "DamewareMachineToolStripMenuItem"
        Me.DamewareMachineToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.DamewareMachineToolStripMenuItem.Text = "Dameware Machine"
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
        'ExportGridToExcelToolStripMenuItem
        '
        Me.ExportGridToExcelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem, Me.SelectedRowsToolStripMenuItem})
        Me.ExportGridToExcelToolStripMenuItem.Name = "ExportGridToExcelToolStripMenuItem"
        Me.ExportGridToExcelToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ExportGridToExcelToolStripMenuItem.Text = "Export Grid to Excel"
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
        'ShowComputerSharesToolStripMenuItem
        '
        Me.ShowComputerSharesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllComputersInGridToolStripMenuItem})
        Me.ShowComputerSharesToolStripMenuItem.Name = "ShowComputerSharesToolStripMenuItem"
        Me.ShowComputerSharesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ShowComputerSharesToolStripMenuItem.Text = "Show Computer Shares"
        '
        'AllComputersInGridToolStripMenuItem
        '
        Me.AllComputersInGridToolStripMenuItem.Name = "AllComputersInGridToolStripMenuItem"
        Me.AllComputersInGridToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AllComputersInGridToolStripMenuItem.Text = "All Computers in Grid"
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(529, 17)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(92, 30)
        Me.btnGetData.TabIndex = 5
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl16)
        Me.GroupBox1.Controls.Add(Me.txt16)
        Me.GroupBox1.Controls.Add(Me.lbl8)
        Me.GroupBox1.Controls.Add(Me.txt8)
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
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1017, 89)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Filter"
        '
        'lbl16
        '
        Me.lbl16.AutoSize = true
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
        Me.lbl8.AutoSize = true
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
        Me.lbl15.AutoSize = true
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
        Me.lbl7.AutoSize = true
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
        Me.lbl14.AutoSize = true
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
        Me.lbl6.AutoSize = true
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
        Me.lbl13.AutoSize = true
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
        Me.lbl5.AutoSize = true
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
        Me.lbl12.AutoSize = true
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
        Me.lbl4.AutoSize = true
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
        Me.lbl11.AutoSize = true
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
        Me.lbl3.AutoSize = true
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
        Me.lbl10.AutoSize = true
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
        Me.lbl2.AutoSize = true
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
        Me.lbl9.AutoSize = true
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
        'lbl1
        '
        Me.lbl1.AutoSize = true
        Me.lbl1.Location = New System.Drawing.Point(44, 14)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(55, 13)
        Me.lbl1.TabIndex = 35
        Me.lbl1.Text = "Parameter"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(47, 27)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(102, 20)
        Me.txt1.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label21.Location = New System.Drawing.Point(806, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(216, 29)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "Computer Shares"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 500)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1053, 22)
        Me.StatusStrip1.TabIndex = 77
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(644, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 30)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Refresh "
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Computershares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 522)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.dgvReports)
        Me.Name = "Computershares"
        Me.Text = "Computer Shares"
        CType(Me.dgvReports,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsComputer.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents dgvReports As System.Windows.Forms.DataGridView
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents cmsComputer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PingMachineToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SCCMInfoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DamewareMachineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteDesktopMachineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintGridToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllRowsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportGridToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents txt14 As System.Windows.Forms.TextBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents txt6 As System.Windows.Forms.TextBox
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents txt13 As System.Windows.Forms.TextBox
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents txt12 As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents txt11 As System.Windows.Forms.TextBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents txt10 As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents txt9 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl16 As System.Windows.Forms.Label
    Friend WithEvents txt16 As System.Windows.Forms.TextBox
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents txt8 As System.Windows.Forms.TextBox
    Friend WithEvents lbl15 As System.Windows.Forms.Label
    Friend WithEvents txt15 As System.Windows.Forms.TextBox
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents txt7 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AllRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectedRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowComputerSharesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllComputersInGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
