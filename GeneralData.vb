Imports System
Imports System.Management
Imports System.IO
Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.Office.Interop
Imports System.Threading
Imports System.Xml


Public Class GeneralData

    Dim iRowSelected As Integer
    Public dt As DataTable
    Dim dtfReports As DataTable
    Dim xmlDoc As New XmlDocument()

    ' generic structure to use in combo and listboxes to link a text value with a pointer 
    Public Structure ListItem
        Public Text As String
        Public Value As Integer
        Public Sub New(ByVal sText As String)
            Text = sText
        End Sub
        Public Sub New(ByVal sText As String, ByVal iValue As String)
            Text = sText
            Value = iValue
        End Sub
        Public Overrides Function ToString() As String
            ToString = Text
        End Function
    End Structure

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

    Public Sub RefreshGrid()
        Dim sSql As String = "N/A"
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.DataGridView1.DataSource = Nothing

            ' List box filled from SQL.XML file in EXE folder.

            ClearFilters()
            HideFilters()

            Dim sQuerySelected As String
            Dim sDbServer As String
            Dim sDatabase As String
            Me.txtSQL.Text = ""
            sQuerySelected = cmbQuery.Text


            If cmbQuery.Text = "ZCustom" Then
                Dim sTable As String
                sTable = InputBox("Input View or Table to select from below ", "Custom Select Query")
                sSql = "Select * from " & sTable
                Me.txtSQL.Text = sSql
                LabelHeader.Text = "DB" & Me.cmbCompany.Text & " " & sTable
            Else
                sSql = GetSQLFromXML(sQuerySelected)
                sDatabase = GetDatabaseFromXML(sQuerySelected)
                sDbServer = GetDBServerFromXML(sQuerySelected)

                If sDbServer <> "" Then
                    cmbServer.Text = sDbServer
                End If

                If sDatabase <> "" Then    ' Database Defined
                    cmbCompany.Text = sDatabase
                ElseIf sDbServer = "STL01APP" Then
                    'cmbCompany.Text = "200"   ' Set to Default Database 200
                End If

                LabelHeader.Text = "DB " & Me.cmbCompany.Text & " " & cmbQuery.Text
            End If
            If chkShowSQL.Checked Then
                Me.txtSQL.Text = sSql
            End If
            dt = GetDTfromSQL(sSql)

            DataGridView1.DataSource = dt
            dtfReports = dt
            Me.DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet
            Me.DataGridView1.Refresh()

            Me.DataGridView1.ContextMenuStrip = Me.cmsUser
            'DataGridView1.DataSource = dt
            SetRowsFound()
            SetUpFilter()
        Catch ex As Exception
            LogError(ex.Message)
            Me.txtSQL.Text += vbCrLf & ex.Message & vbCrLf & ssql
        Finally
            Me.labelLastUpdate.Text = "Last Refreshed: " & Now
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Public Function GetSQLFromXML(SQueryName As String) As String
        Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Query")
        Dim queryname As String = ""
        Dim sSqlOut As String = ""
        For Each node As XmlNode In nodes
            QueryName = node.SelectSingleNode("QueryName").InnerText
            If queryname = SQueryName Then
                sSqlOut = node.SelectSingleNode("SQL").InnerText
                Exit For
            End If
        Next
        Return sSqlOut

    End Function


    Public Function GetDataBaseFromXML(SQueryName As String) As String
        Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Query")
        Dim queryname As String = ""
        Dim sDBOut As String = ""
        Try
            For Each node As XmlNode In nodes
                queryname = node.SelectSingleNode("QueryName").InnerText
                If queryname = SQueryName Then
                    sDBOut = node.SelectSingleNode("DataBase").InnerText
                    Exit For
                End If
            Next
            Return sDBOut
        Catch ex As Exception
            Return sDBOut
        End Try
    End Function
    Public Function GetDBServerFromXML(SQueryName As String) As String
        Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Query")
        Dim queryname As String = ""
        Dim sDBServerOut As String = ""
        Try
            For Each node As XmlNode In nodes
                queryname = node.SelectSingleNode("QueryName").InnerText
                If queryname = SQueryName Then
                    sDBServerOut = node.SelectSingleNode("DBServer").InnerText
                    Exit For
                End If
            Next
            Return sDBServerOut
        Catch ex As Exception
            Return sDBServerOut
        End Try

    End Function


    Public Sub FillInCombo()
        Try
            cmbQuery.Items.Clear()
            xmlDoc.Load(My.Application.Info.DirectoryPath & "\sql.xml")
            Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Query")
            Dim QueryName As String = "", SQL As String = ""
            For Each node As XmlNode In nodes
                QueryName = node.SelectSingleNode("QueryName").InnerText
                SQL = node.SelectSingleNode("SQL").InnerText
                cmbQuery.Items.Add(QueryName)
                '    MessageBox.Show(QueryName & " " & SQL)
            Next
            cmbQuery.Items.Add("ZCustom")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub SetRowsFound()
        Me.tsslStatus.Text = "Rows Found: " & DataGridView1.RowCount
    End Sub

    Public Function GetDTfromSQL(sSql As String) As DataTable

        Try
            Dim sConnection As String = "server=" & Me.cmbServer.Text & ";database=" & Me.cmbCompany.Text & ";Trusted_Connection=True;"

            Dim objDataAdapter As New SqlDataAdapter(sSql, sConnection)
            Dim dsResult As New DataSet("OuResult")

            If Not IsNothing(objDataAdapter) Then
                ' Fill data into dataset
                objDataAdapter.Fill(dsResult)

                objDataAdapter.Dispose()
            End If

            GetDTfromSQL = dsResult.Tables(0)
        Catch ex As Exception
            LogError("Error GetDTFromSQL. " & vbCrLf & sSql & vbCrLf & ex.Message)
            Me.txtSQL.Text += vbCrLf & ex.Message
            MsgBox("Error GetDTFromSQL. " & vbCrLf & sSql & vbCrLf & ex.Message)
            GetDTfromSQL = Nothing
        End Try

    End Function

    Private Sub cmbQuery_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbQuery.SelectedValueChanged
        'RefreshGrid()
    End Sub
    Private Sub AllRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, True)
    End Sub

    Private Sub SelectedRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, False)
    End Sub

    Private Sub AllRowsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(DataGridView1)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SelectedRowsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(DataGridView1, True)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        RefreshGrid()
    End Sub

    Public Sub SetUpFilter()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim col As DataGridViewColumn

        For Each col In DataGridView1.Columns
            'Skipping Date Fields in Filter area
            If InStr(col.HeaderText.ToUpper, "DATE") < 1 And InStr(col.HeaderText.ToUpper, "TIME") < 1 Then
                i += 1
                Select Case i
                    Case 1
                        lbl1.Text = col.HeaderText
                        lbl1.Visible = True
                        txt1.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl1.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl1.Tag = "Date"
                        Else
                            lbl1.Tag = "Text"
                        End If
                    Case 2
                        lbl2.Text = col.HeaderText
                        lbl2.Visible = True
                        txt2.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl2.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl2.Tag = "Date"
                        Else
                            lbl2.Tag = "Text"
                        End If
                    Case 3
                        lbl3.Text = col.HeaderText
                        lbl3.Visible = True
                        txt3.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl3.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl3.Tag = "Date"
                        Else
                            lbl3.Tag = "Text"
                        End If
                    Case 4
                        lbl4.Text = col.HeaderText
                        lbl4.Visible = True
                        txt4.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl4.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl4.Tag = "Date"
                        Else
                            lbl4.Tag = "Text"
                        End If
                    Case 5
                        lbl5.Text = col.HeaderText
                        lbl5.Visible = True
                        txt5.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl5.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl5.Tag = "Date"
                        Else
                            lbl5.Tag = "Text"
                        End If
                    Case 6
                        lbl6.Text = col.HeaderText
                        lbl6.Visible = True
                        txt6.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl6.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl6.Tag = "Date"
                        Else
                            lbl6.Tag = "Text"
                        End If
                    Case 7
                        lbl7.Text = col.HeaderText
                        lbl7.Visible = True
                        txt7.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl7.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl7.Tag = "Date"
                        Else
                            lbl7.Tag = "Text"
                        End If
                    Case 8
                        lbl8.Text = col.HeaderText
                        lbl8.Visible = True
                        txt8.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl8.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl8.Tag = "Date"
                        Else
                            lbl8.Tag = "Text"
                        End If
                    Case 9
                        lbl9.Text = col.HeaderText
                        lbl9.Visible = True
                        txt9.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl9.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl9.Tag = "Date"
                        Else
                            lbl9.Tag = "Text"
                        End If
                    Case 10
                        lbl10.Text = col.HeaderText
                        lbl10.Visible = True
                        txt10.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl10.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl10.Tag = "Date"
                        Else
                            lbl10.Tag = "Text"
                        End If
                    Case 11
                        lbl11.Text = col.HeaderText
                        lbl11.Visible = True
                        txt11.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl11.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl11.Tag = "Date"
                        Else
                            lbl11.Tag = "Text"
                        End If
                    Case 12
                        lbl12.Text = col.HeaderText
                        lbl12.Visible = True
                        txt12.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl12.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl12.Tag = "Date"
                        Else
                            lbl12.Tag = "Text"
                        End If
                    Case 13
                        lbl13.Text = col.HeaderText
                        lbl13.Visible = True
                        txt13.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl13.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl13.Tag = "Date"
                        Else
                            lbl13.Tag = "Text"
                        End If
                    Case 14
                        lbl14.Text = col.HeaderText
                        lbl14.Visible = True
                        txt14.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl14.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl14.Tag = "Date"
                        Else
                            lbl14.Tag = "Text"
                        End If
                    Case 15
                        lbl15.Text = col.HeaderText
                        lbl15.Visible = True
                        txt15.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl15.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl15.Tag = "Date"
                        Else
                            lbl15.Tag = "Text"
                        End If
                    Case 16
                        lbl16.Text = col.HeaderText
                        lbl16.Visible = True
                        txt16.Visible = True
                        If col.ValueType Is GetType(Integer) Or col.ValueType Is GetType(Byte) Then
                            lbl16.Tag = "Integer"
                        ElseIf col.ValueType Is GetType(Date) Then
                            lbl16.Tag = "Date"
                        Else
                            lbl16.Tag = "Text"
                        End If

                    Case Else

                End Select
            End If 'Skipping Date Fields in Filter area

        Next

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
                    If ctrltb(0).Text.Length > 1 Or Not hasoperator(ctrltb(0).Text) Then
                        ctrllb = GroupBox1.Controls.Find("lbl" & i, False)
                        If sTemp.Length > 0 Then
                            If ctrllb(0).Tag = "Text" Then
                                If Not hasoperator(ctrltb(0).Text) Then
                                    sTemp += " and [" & ctrllb(0).Text & "] like '*" & ctrltb(0).Text & "*'"
                                Else
                                    sTemp += " and [" & ctrllb(0).Text & "]" & getOperatorAndString(ctrltb(0).Text)
                                End If
                            Else
                                sTemp += " And [" & ctrllb(0).Text & "] = " & ctrltb(0).Text
                            End If
                        Else
                            If ctrllb(0).Tag = "Text" Then
                                If Not hasoperator(ctrltb(0).Text) Then
                                    sTemp += " [" & ctrllb(0).Text & "] like '*" & ctrltb(0).Text & "*'"
                                Else
                                    sTemp += "[" & ctrllb(0).Text & "]" & getOperatorAndString(ctrltb(0).Text)
                                End If
                            Else
                                sTemp += " [" & ctrllb(0).Text & "] = " & ctrltb(0).Text
                            End If
                        End If
                    End If
                End If
            Next

            Dim DV As New DataView(dt)

            DV.RowFilter = sTemp
            dtfReports = DV.ToTable
            DataGridView1.DataSource = dtfReports
            Me.tsslStatus.Text = "Rows: " & DataGridView1.Rows.Count

        Catch ex As Exception
            MsgBox("Error In Filter." & vbCrLf & ex.Message)
            LogError("Filter Error " & ex.Message)
        End Try
    End Sub

    Private Sub txt1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt1.KeyUp, txt2.KeyUp, txt3.KeyUp, txt4.KeyUp, txt5.KeyUp, txt6.KeyUp, txt7.KeyUp, txt8.KeyUp, txt9.KeyUp, txt10.KeyUp, txt11.KeyUp, txt12.KeyUp, txt13.KeyUp, txt14.KeyUp, txt15.KeyUp, txt16.KeyUp
        FilterGrid()
    End Sub

    Private Sub GeneralData_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillInCombo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frm As New EditXML
        frm.Show()
    End Sub

    Private Sub cmbReloadCombo_Click(sender As Object, e As EventArgs) Handles cmbReloadCombo.Click
        FillInCombo()
    End Sub

    Private Sub CopyCtrlCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCtrlCToolStripMenuItem.Click
        My.Computer.Keyboard.SendKeys("^{C}")
    End Sub

    Private Sub AllRowsToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles AllRowsToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        'ExportToExcel(dtf)
        ExportToExcel(DataGridView1)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SelectedRowsToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles SelectedRowsToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        'ExportToExcel(dtf)
        ExportToExcel(DataGridView1, True)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AllRowsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AllRowsToolStripMenuItem.Click
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, True)
    End Sub

    Private Sub SelectedRowsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SelectedRowsToolStripMenuItem.Click
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, False)
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        ClearFilters()
        HideFilters()

        dt = GetEmailsFromAD()

        DataGridView1.DataSource = dt
        dtfReports = dt
        Me.DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet
        Me.DataGridView1.Refresh()

        Me.DataGridView1.ContextMenuStrip = Me.cmsUser
        'DataGridView1.DataSource = dt
        SetRowsFound()
        SetUpFilter()
    End Sub

    Private Sub LoadCSV()

        Dim myStream As Stream = Nothing
        Dim sOpenFile As String
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            sOpenFile = openFileDialog1.SafeFileName

            Dim folder = Path.GetDirectoryName(openFileDialog1.FileName)
            Dim CnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & folder & ";Extended Properties=""text;HDR=Yes;FMT=Delimited"";"
            'Dim dt As New DataTable
            dt = New DataTable
            Using Adp As New OleDbDataAdapter("select * from [" & sOpenFile & "]", CnStr)
                Adp.Fill(dt)
            End Using
            DataGridView1.DataSource = dt
            dtfReports = dt
            Me.DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet
            Me.DataGridView1.Refresh()

            Me.DataGridView1.ContextMenuStrip = Me.cmsUser
            'DataGridView1.DataSource = dt

            SetRowsFound()
            SetUpFilter()
        Else
            MsgBox("No File Selected.", vbInformation)
        End If
    End Sub

    Private Sub btnLoadCSV_Click(sender As Object, e As EventArgs) Handles btnLoadCSV.Click
        LoadCSV()
    End Sub

    Private Sub PasteFromClipboard()
        'When you copy the Excel Cells in Clipboard it goes in Tab delimited columns and Rows in New Lines
        'So Get all the Rows by splitting it on a NewLine Character

        dt = New DataTable

        Dim Rows() As String = Clipboard.GetText().Split(Environment.NewLine)
        Dim Cols() As String
        Dim DR As DataRow

        For i As Int32 = 0 To Rows.Length - 1
            'Then For Each Row get the Columns which are tab Seperated
            Cols = Rows(i).Split(vbTab)
            'DT.NewRow()
            DR = dt.NewRow() 'ProductionDataSet1.Tables("ProductionData").NewRow()
            'Now create a DataRow to be added to the underlying DataTable
            For j As Int32 = 0 To Cols.Length - 1
                'Now loop for each Column and Add the column data
                If dt.Columns.Count > j Then
                    'If (j = 2) Then
                    'This is just for eg. that I have assumed that the Third COlumn (index 2) is say a Numeric Column
                    'then you need to convert it to numeric before adding to the DataRow, similarly for other data types
                    'DR(j) = Convert.ToInt32(Cols(j))
                    'Else
                    If IsNumeric(Cols(j)) Then
                        DR(j) = Convert.ToDouble(Cols(j))
                    Else
                        DR(j) = 0
                    End If
                    'End If
                End If
            Next
            dt.Rows.Add(DR)

        Next
        DataGridView1.DataSource = dt
        dtfReports = dt
        Me.DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet
        Me.DataGridView1.Refresh()

        Me.DataGridView1.ContextMenuStrip = Me.cmsUser
        'DataGridView1.DataSource = dt

        SetRowsFound()
        SetUpFilter()
    End Sub

    Private Sub btnPasteFromClip_Click(sender As Object, e As EventArgs) Handles btnPasteFromClip.Click
        PasteFromClipboard()
    End Sub
End Class