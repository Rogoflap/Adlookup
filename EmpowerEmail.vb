Imports Microsoft.Office.Interop

Public Class EmpowerEmail
    Dim iRowSelected As Integer
    Public dt As DataTable
    Dim dtfReports As DataTable

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
    Private Sub GetEmpowerFolders()
        Dim tempApp As Outlook.Application
        Dim tempInbox As Outlook.MAPIFolder
        Dim InboxItems As Outlook.Items
        Dim dt As New DataTable

        'Dim objattachments, objAttach
        tempApp = CreateObject("Outlook.Application")
        tempInbox = tempApp.GetNamespace("Mapi").Folders("Empower@Accellacorp.com").Folders("Inbox")
        'tempInbox = tempApp.GetNamespace("Mapi").Folders("Empower@Accellacorp.com").Folders("Inbox").Folders(sSubFolder)
        'tempInbox = tempApp.GetNamespace("Mapi").GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox)
        InboxItems = tempInbox.Items
        'Dim newMail As Object 'Outlook.MailItem
        'Dim oMail As Outlook.MailItem
        'Dim rptItem As Outlook.ReportItem
        Dim fldrs As Outlook.Folder
        cmbInboxFoders.Items.Add("Inbox")
        For Each fldrs In tempInbox.Folders
            cmbInboxFoders.Items.Add(fldrs.Name)
        Next

    End Sub
    Public Sub SetRowsFound()
        Me.tsslStatus.Text = "Rows Found: " & DataGridView1.RowCount
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
                    ctrllb = GroupBox1.Controls.Find("lbl" & i, False)
                    If sTemp.Length > 0 Then
                        If ctrllb(0).Tag = "Text" Then
                            sTemp += " and [" & ctrllb(0).Text & "] like '*" & ctrltb(0).Text & "*'"
                        Else
                            sTemp += " and [" & ctrllb(0).Text & "] = " & ctrltb(0).Text
                        End If
                    Else
                        If ctrllb(0).Tag = "Text" Then
                            sTemp += " [" & ctrllb(0).Text & "] like '*" & ctrltb(0).Text & "*'"
                        Else
                            sTemp += " [" & ctrllb(0).Text & "] = " & ctrltb(0).Text
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

    Private Sub btnGetEmail_Click(sender As Object, e As EventArgs) Handles btnGetEmail.Click
        Me.Cursor = Cursors.WaitCursor

        Me.DataGridView1.DataSource = Nothing

        ' List box filled from SQL.XML file in EXE folder.
        ClearFilters()
        HideFilters()
        dt = GetInvoiceEMails(cmbInboxFoders.Text)
        DataGridView1.DataSource = dt
        dtfReports = dt
        Me.DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet
        Me.DataGridView1.Refresh()
        Me.DataGridView1.ContextMenuStrip = Me.cmsUser
        'DataGridView1.DataSource = dt
        SetRowsFound()
        SetUpFilter()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub EmpowerEmail_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetEmpowerFolders()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        'WebBrowser1.DocumentText = DataGridView1.Rows(e.RowIndex).Cells("Body").Value
        Dim sFilename As String = ""
        WebBrowser1.DocumentText = ""
        WebBrowser1.Navigate("")
        If DataGridView1.Rows(e.RowIndex).Cells("Type").Value = "MailItem" Then
            sFilename = GetAttachment(DataGridView1.Rows(e.RowIndex).Cells("ID").Value)
            lblTo.Text = "TO: " & DataGridView1.Rows(e.RowIndex).Cells("TO").Value
            lblCC.Text = "CC: " & DataGridView1.Rows(e.RowIndex).Cells("CC").Value
            lblSubject.Text = "Subject: " & DataGridView1.Rows(e.RowIndex).Cells("Subject").Value
            txtBody.Text = DataGridView1.Rows(e.RowIndex).Cells("Body").Value
            lblDate.Text = "Received: " & DataGridView1.Rows(e.RowIndex).Cells("Dat").Value
        Else
            lblTo.Text = "TO: " & DataGridView1.Rows(e.RowIndex).Cells("TO").Value
            lblCC.Text = "CC: " & DataGridView1.Rows(e.RowIndex).Cells("CC").Value
            lblSubject.Text = "Subject: " & DataGridView1.Rows(e.RowIndex).Cells("Subject").Value
            lblDate.Text = "Received: " & DataGridView1.Rows(e.RowIndex).Cells("Dat").Value
        End If

        If DataGridView1.Rows(e.RowIndex).Cells("Type").Value = "MailItem" And sFilename <> "" Then
            WebBrowser1.Navigate(sFilename)
        Else
            WebBrowser1.DocumentText = DataGridView1.Rows(e.RowIndex).Cells("Body").Value
        End If
    End Sub

End Class