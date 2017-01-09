Imports System
Imports System.Management
Imports System.IO
Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Data.SqlClient
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

        Try


            Me.DataGridView1.DataSource = Nothing

            ' Current List in Combo Box
            'Name                     View Called
            'Item Last Usage            VW_1LastUsage
            'BOL                        VW_BOL
            'ConfirmShip                VW_ConfirmShip
            'Custsomer List             
            'DIFF QOH                   vw_DiffQOH
            'Dropship Order             vw_DropShipOrder
            'Late Order                 VW_LateOrder
            'Loc QOH                    vw_LocQOH
            'New Item Created           VW_NewItemCreated
            'Order Loc DropShip         vw_OrderLocDropShip
            'PO Email                   vw_POEmail
            'PO Request                 vw_POReq
            'Price Code List
            'Quarintine Inventory       vw_QuarantineInventory
            'RMA                        vw_RMA
            'Serial QOH                 vw_SerialQOH
            'Transit Transfer Approved  vw_TransitInvApproved
            'Unique Ship Via Codes
            'Vendor Sales Person
            'Exact Table List           SELECT * From DDTables
            'Exact Users - Roles
            'WISYS Users
            'PO Cost VS Standard
            '99999 Contacts             vw_999999Contacts

            ClearFilters()
            HideFilters()

            Dim sQuerySelected As String
            Dim sSql As String

            sQuerySelected = cmbQuery.Text

            sSql = GetSQLFromXML(sQuerySelected)

            'Select Case sQuerySelected
            '    Case "99999 Contacts"
            '        sSql = "Select db_name(), * from vw_999999Contacts"
            '    Case "BOL"
            '        sSql = "Select db_name(),* from VW_BOL"
            '    Case "ConfirmShip"
            '        sSql = "Select db_name(), * from  VW_ConfirmShip"
            '    Case "Customer List"
            '        sSql = "Select db_name(),* from arcusfil_wv"
            '    Case "DIFF QOH"
            '        sSql = "Select db_Name(), * from vw_DiffQOH"
            '    Case "Dropship Order"
            '        sSql = "Select db_name(), * from vw_DropShipOrder"
            '    Case "Late Order"
            '        sSql = "Select db_name(), * from VW_LateOrder"
            '    Case "LOC QOH"
            '        sSql = "Select db_Name(), * from vw_LocQOH"
            '    Case "New Item Created"
            '        sSql = "Select db_Name(), * from VW_NewItemCreated"
            '    Case "Order Loc DropShip"
            '        sSql = "Select db_Name(), * from vw_OrderLocDropShip"
            '    Case "PO Email"
            '        sSql = "Select db_name(), * from vw_POEmail"
            '    Case "PO Request"
            '        sSql = "Select db_Name(), * from vw_POReq"
            '    Case "Price Code List"
            '        sSql = "select p.cd_tp, case p.cd_tp  "
            '        sSql += " when 1 then 'Customer and Item' "
            '        sSql += " when 2 then 'Customer and Product Category' "
            '        sSql += " When 3 Then 'Customer Type and Item' "
            '        sSql += " when 4 then 'Customer Type and Product Category' "
            '        sSql += " When 5 Then 'Customer Only' "
            '        sSql += " when 6 then 'Item Only' "
            '        sSql += " When 7 Then 'Customer Type Only' "
            '        sSql += " When 8 Then 'Product Category Only' else cast(p.cd_tp as CHAR(1)) end as code_desc "
            '        sSql += " , ltrim(p.cd_tp_1_cust_no) as cus_no , c.cmp_name as cus_name , rtrim(cd_tp_1_item_no) as item_no "
            '        sSql += " , i.item_desc_1, p.start_dt, p.end_dt, cd_prc_basis as price_basis, minimum_qty_1 , prc_or_disc_1 , minimum_qty_2 "
            '        sSql += " , prc_or_disc_2, minimum_qty_3, prc_or_disc_3, minimum_qty_4, prc_or_disc_4 "
            '        sSql += " from oeprcfil_sql p left outer join imitmidx_sql i on p.cd_tp_1_item_no = i.item_no Left outer join cicmpy c on p.cd_tp_1_cust_no = c.debcode "
            '    Case "Quarintine Inventory"
            '        sSql = "Select db_name(), * from vw_QuarantineInventory"
            '    Case "RMA"
            '        sSql = "Select db_name(), * from vw_RMA"
            '    Case "Serial QOH"
            '        sSql = "Select db_name(),* from vw_SerialQOH"
            '    Case "Serial QOH"
            '        sSql = "Select db_Name(), * from vw_SerialQOH"
            '    Case "Transit Transfer Approved"
            '        sSql = "Select db_Name(),* from vw_TransitInvApproved"
            '    Case "Unique Ship Via Codes"
            '        sSql = "select distinct b.bedrnr as 'company', o.ship_via_cd, z.code_desc "
            '        sSql += " from oehdrhst_sql o left outer join zAR_Ship_Via z on o.ship_via_cd = z.sy_code cross join bedryf b  "
            '    Case "Vendor Sales Person"
            '        sSql = "SELECT db_name(), cicmpy.id,cmp_name, CompanyType,SalesPersonNumber, h.fullname as SalesPerson,AccountTypeCode,ClassificationId "
            '        sSql += " FROM  [cicmpy] inner join humres h on h.id = SalesPersonNumber"
            '    Case "Exact Users - Roles"
            '        sSql = "select db_name() as [DB],pwr.role_name,pwr.descr64, "
            '        sSql += " hr.fullname,hr.sur_name,hr.first_name,hr.mail,hr.job_title, "
            '        sSql += " hr.adres1,hr.adres2,hr.woonpl,hr.postcode,hr.telnr_prv,hr.faxnr, "
            '        sSql += " hr.usr_id,hr.job_level As [Sec Lev],hr.pur_limit,hr.VacancyStartDate,hr.blocked "
            '        sSql += " from [humres] hr  "
            '        sSql += " left join pwruc uru on uru.res_id = hr.res_id "
            '        sSql += " left join pwrole pwr on pwr.role_id = uru.role_id "
            '    Case "Exact Table List"
            '        sSql = "SELECT db_name(), * From DDTables"
            '    Case "WISYS Users"
            '        sSql = "select db_name() as DBNAME,username,fullname,admin,securitylvl,isdeleted From wsUsers"
            '    Case "Item Last Usage"
            '        sSql = "Select db_name(),* from VW_1LastUsage"
            '    Case "PPV", "PO Cost VS Standard"
            '        sSql = "Select db_name(),* from vw_pocostvrsstd"
            'End Select
            dt = GetDTfromSQL(sSql)

            DataGridView1.DataSource = dt
            dtfReports = dt

            Me.Cursor = Cursors.WaitCursor
            Me.DataGridView1.Refresh()

            LabelHeader.Text = cmbQuery.Text
            Me.DataGridView1.ContextMenuStrip = Me.cmsUser
            'DataGridView1.DataSource = dt
            SetRowsFound()
            SetUpFilter()
        Catch ex As Exception
            LogError(ex.Message)
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
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub SetRowsFound()
        Me.tsslStatus.Text = "Rows Found: " & DataGridView1.RowCount
    End Sub

    Public Function GetDTfromSQL(sSql As String) As DataTable

        Try
            Dim sConnection As String = "server=stl01app;database=" & Me.cmbCompany.Text & ";Trusted_Connection=True;"

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
            MsgBox("Error GetDTFromSQL. " & vbCrLf & sSql & vbCrLf & ex.Message)
            GetDTfromSQL = Nothing
        End Try

    End Function

    Private Sub cmbQuery_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbQuery.SelectedValueChanged
        RefreshGrid()
    End Sub
    Private Sub AllRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem.Click
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, True)
    End Sub

    Private Sub SelectedRowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem.Click
        PrintDGV.Print_DataGridView(Me.DataGridView1, "Results for " & dt.TableName, False)
    End Sub

    Private Sub AllRowsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AllRowsToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        ExportToExcel(DataGridView1)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SelectedRowsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SelectedRowsToolStripMenuItem1.Click
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
                    Case 2
                        lbl2.Text = col.HeaderText
                        lbl2.Visible = True
                        txt2.Visible = True
                    Case 3
                        lbl3.Text = col.HeaderText
                        lbl3.Visible = True
                        txt3.Visible = True
                    Case 4
                        lbl4.Text = col.HeaderText
                        lbl4.Visible = True
                        txt4.Visible = True
                    Case 5
                        lbl5.Text = col.HeaderText
                        lbl5.Visible = True
                        txt5.Visible = True
                    Case 6
                        lbl6.Text = col.HeaderText
                        lbl6.Visible = True
                        txt6.Visible = True
                    Case 7
                        lbl7.Text = col.HeaderText
                        lbl7.Visible = True
                        txt7.Visible = True
                    Case 8
                        lbl8.Text = col.HeaderText
                        lbl8.Visible = True
                        txt8.Visible = True
                    Case 9
                        lbl9.Text = col.HeaderText
                        lbl9.Visible = True
                        txt9.Visible = True
                    Case 10
                        lbl10.Text = col.HeaderText
                        lbl10.Visible = True
                        txt10.Visible = True
                    Case 11
                        lbl11.Text = col.HeaderText
                        lbl11.Visible = True
                        txt11.Visible = True
                    Case 12
                        lbl12.Text = col.HeaderText
                        lbl12.Visible = True
                        txt12.Visible = True
                    Case 13
                        lbl13.Text = col.HeaderText
                        lbl13.Visible = True
                        txt13.Visible = True
                    Case 14
                        lbl14.Text = col.HeaderText
                        lbl14.Visible = True
                        txt14.Visible = True
                    Case 15
                        lbl15.Text = col.HeaderText
                        lbl15.Visible = True
                        txt15.Visible = True
                    Case 16
                        lbl16.Text = col.HeaderText
                        lbl16.Visible = True
                        txt16.Visible = True

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
                        sTemp += " and [" & ctrllb(0).Text & "] like '*" & ctrltb(0).Text & "*'"
                    Else
                        sTemp += " [" & ctrllb(0).Text & "] like '*" & ctrltb(0).Text & "*'"
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
End Class