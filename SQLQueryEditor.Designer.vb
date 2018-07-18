<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQLQueryEditor
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbDBServer = New System.Windows.Forms.ComboBox()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.cmbDBName = New System.Windows.Forms.ComboBox()
        Me.txtQueryName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbQueries = New System.Windows.Forms.ComboBox()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(498, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbDBServer
        '
        Me.cmbDBServer.FormattingEnabled = True
        Me.cmbDBServer.Location = New System.Drawing.Point(173, 100)
        Me.cmbDBServer.Name = "cmbDBServer"
        Me.cmbDBServer.Size = New System.Drawing.Size(315, 21)
        Me.cmbDBServer.TabIndex = 3
        '
        'txtSQL
        '
        Me.txtSQL.Location = New System.Drawing.Point(173, 154)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(515, 276)
        Me.txtSQL.TabIndex = 5
        '
        'cmbDBName
        '
        Me.cmbDBName.FormattingEnabled = True
        Me.cmbDBName.Location = New System.Drawing.Point(173, 127)
        Me.cmbDBName.Name = "cmbDBName"
        Me.cmbDBName.Size = New System.Drawing.Size(315, 21)
        Me.cmbDBName.TabIndex = 4
        '
        'txtQueryName
        '
        Me.txtQueryName.Location = New System.Drawing.Point(173, 74)
        Me.txtQueryName.Name = "txtQueryName"
        Me.txtQueryName.Size = New System.Drawing.Size(515, 20)
        Me.txtQueryName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Query Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DB Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Database"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "SQL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Current Queries"
        '
        'cmbQueries
        '
        Me.cmbQueries.FormattingEnabled = True
        Me.cmbQueries.Location = New System.Drawing.Point(173, 21)
        Me.cmbQueries.Name = "cmbQueries"
        Me.cmbQueries.Size = New System.Drawing.Size(434, 21)
        Me.cmbQueries.TabIndex = 1
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(613, 21)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNew.TabIndex = 11
        Me.cmdAddNew.Text = "Add New"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ID"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(175, 51)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "ID"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(613, 436)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'SQLQueryEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 493)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbQueries)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQueryName)
        Me.Controls.Add(Me.cmbDBName)
        Me.Controls.Add(Me.txtSQL)
        Me.Controls.Add(Me.cmbDBServer)
        Me.Controls.Add(Me.Button1)
        Me.Name = "SQLQueryEditor"
        Me.Text = "SQLQueryEditor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbDBServer As System.Windows.Forms.ComboBox
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents cmbDBName As System.Windows.Forms.ComboBox
    Friend WithEvents txtQueryName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbQueries As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
