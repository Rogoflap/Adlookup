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




Module Utility
    Public sLogfileName As String = My.Settings.LogFile
    Public sEmailTo As String = My.Settings.SendTo
    Public sLdap As String
    Public Const sXMLOutput As String = "ADLookupData"
    Public Const MOD_ALT As Integer = &H1 'Alt key
    Public Const WM_HOTKEY As Integer = &H312

    'Public dt As DataTable
    'Public dtf As DataTable
    Public dtUserIDFullName As DataTable
    Public dtMemberof As DataTable
    Public dtShares As DataTable
    Public dtfShares As DataTable
    Public sDataTableType As String
    Public sCompName As String = ""
    Public sDameWareFile As String
    Public sSiteID As String = "EAI"
    Public sLoadType As String
    Public dcUserIDFullname As Dictionary(Of String, String)

    <DllImport("User32.dll")>
    Public Function RegisterHotKey(ByVal hwnd As IntPtr,
                            ByVal id As Integer, ByVal fsModifiers As Integer,
                            ByVal vk As Integer) As Integer
    End Function

    <DllImport("User32.dll")>
    Public Function UnregisterHotKey(ByVal hwnd As IntPtr,
                        ByVal id As Integer) As Integer
    End Function

    Public Function GetDomainControllers() As List(Of String)
        Dim DcList As New List(Of String)
        Using Searcher As New DirectorySearcher(New DirectoryEntry)
            Searcher.Filter = "(primaryGroupID=516)"
            For Each DC As SearchResult In Searcher.FindAll
                DcList.Add(DC.GetDirectoryEntry.Name.Remove(0, 3))
            Next
        End Using

        Return DcList
    End Function

    Public Sub SetLdap(dc As String)
        sLdap = My.Settings.LDAP
    End Sub

    'Public Function GetComputerSharesAllComputers(dgv As DataGridView) As DataTable

    '    dtShares = New DataTable("SharesOnComputer")

    '    dtShares.Columns.Add(New DataColumn("Computer Name", GetType(System.String)))
    '    dtShares.Columns.Add(New DataColumn("Drive", GetType(System.String)))
    '    dtShares.Columns.Add(New DataColumn("Share Folder", GetType(System.String)))
    '    dtShares.Columns.Add(New DataColumn("Status", GetType(System.String)))
    '    Dim dr As DataRow
    '    Dim dgr As DataGridViewRow

    '    For Each dgr In dgv.Rows
    '        sCompName = dgr.Cells(0).Value 'Computer Name
    '        Dim Evaluator = New Thread(Sub() AddComputerShares(sCompName))

    '        'AddComputerShares(sCompName)
    '        'dr = dtShares.NewRow
    '        'sCompName = dgr.Cells(0).Value 'Computer Name
    '        'dr(0) = sCompName
    '        'Dim Path As ManagementPath = New ManagementPath
    '        'Dim Shares As ManagementClass = Nothing
    '        'Dim CO As ConnectionOptions = New ConnectionOptions

    '        ''CO.Username = "Administrator    "
    '        ''CO.Password = "XXXXXXXXXXX"
    '        'Path.Server = sCompName ' use . for local server, else server name
    '        'Path.NamespacePath = "root\CIMV2"
    '        ''    Path.RelativePath = "Win32_Share"
    '        ''Path.RelativePath = "Win32_LogicalDisk"
    '        'Path.RelativePath = "win32_MappedLogicalDisk"

    '        'Dim Scope As ManagementScope = New ManagementScope(Path, CO)
    '        'Dim Options As ObjectGetOptions = New ObjectGetOptions(Nothing, New TimeSpan(0, 0, 0, 5), True)

    '        'Try
    '        '    Shares = New ManagementClass(Scope, Path, Options)
    '        '    Dim MOC As ManagementObjectCollection = Shares.GetInstances()
    '        '    Dim MO As ManagementObject
    '        '    For Each MO In MOC
    '        '        'sOut += (MO("Name") & " " & MO("description")) & vbCrLf
    '        '        'sOut += (MO("DeviceID") & " " & MO("ProviderName")) & vbCrLf
    '        '        dr(1) = MO("DeviceID")
    '        '        dr(2) = MO("ProviderName")
    '        '        'sOut += (MO("DeviceID") & vbTab & MO("ProviderName")) & vbCrLf
    '        '        dtShares.Rows.Add(dr)
    '        '        dr = dtShares.NewRow
    '        '        dr(0) = sCompName
    '        '    Next
    '        'Catch e As Exception
    '        '    dr(3) = e.Message
    '        '    dtShares.Rows.Add(dr)
    '        '    ' MsgBox("Error getting Mapped Drives for: " & sCompName & " " & e.Message)
    '        '    ' LogError("Error getting Mapped Drives for: " & sCompName & " " & e.Message)
    '        'Finally
    '        '    Shares.Dispose()
    '        'End Try
    '    Next dgr
    '    Return dtShares

    'End Function

    'Public Sub AddComputerShares(sComputerName As String)
    '    Dim sOut As String = "Realtime Shares mapped for " & sComputerName & vbCrLf & vbCrLf
    '    Dim Path As ManagementPath = New ManagementPath
    '    Dim Shares As ManagementClass = Nothing
    '    Dim CO As ConnectionOptions = New ConnectionOptions
    '    Dim dr As DataRow
    '    dr = dtShares.NewRow
    '    dr(0) = sCompName
    '    Path.Server = sComputerName ' use . for local server, else server name
    '    Path.NamespacePath = "root\CIMV2"
    '    Path.RelativePath = "Win32_Share"
    '    Path.RelativePath = "Win32_LogicalDisk"
    '    Path.RelativePath = "win32_MappedLogicalDisk"

    '    Dim Scope As ManagementScope = New ManagementScope(Path, CO)
    '    Dim Options As ObjectGetOptions = New ObjectGetOptions(Nothing, New TimeSpan(0, 0, 0, 5), True)
    '    Try
    '        Shares = New ManagementClass(Scope, Path, Options)
    '        Dim MOC As ManagementObjectCollection = Shares.GetInstances()
    '        Dim MO As ManagementObject
    '        For Each MO In MOC
    '            dr(1) = MO("DeviceID")
    '            dr(2) = MO("ProviderName")
    '            dtShares.Rows.Add(dr)
    '            dr = dtShares.NewRow
    '            dr(0) = sCompName
    '        Next
    '    Catch e As Exception
    '        dr(3) = e.Message
    '        dtShares.Rows.Add(dr)
    '    Finally
    '        Shares.Dispose()
    '    End Try
    'End Sub

    Public Function ShowComputerShares(sComputerName As String) As String
        Dim sOut As String = "Realtime Shares mapped for " & sComputerName & vbCrLf & vbCrLf
        Dim Path As ManagementPath = New ManagementPath
        Dim Shares As ManagementClass = Nothing
        Dim CO As ConnectionOptions = New ConnectionOptions

        'CO.Username = "Administrator    "
        'CO.Password = "XXXXXXXXXXX"
        Path.Server = sComputerName ' use . for local server, else server name
        Path.NamespacePath = "root\CIMV2"
        Path.RelativePath = "Win32_Share"
        Path.RelativePath = "Win32_LogicalDisk"
        Path.RelativePath = "win32_MappedLogicalDisk"

        Dim Scope As ManagementScope = New ManagementScope(Path, CO)
        Dim Options As ObjectGetOptions = New ObjectGetOptions(Nothing, New TimeSpan(0, 0, 0, 5), True)

        Try
            Shares = New ManagementClass(Scope, Path, Options)
            Dim MOC As ManagementObjectCollection = Shares.GetInstances()
            Dim MO As ManagementObject
            For Each MO In MOC
                'sOut += (MO("Name") & " " & MO("description")) & vbCrLf
                'sOut += (MO("DeviceID") & " " & MO("ProviderName")) & vbCrLf
                sOut += (MO("DeviceID") & vbTab & MO("ProviderName")) & vbCrLf
            Next
        Catch e As Exception
            MsgBox("Error getting Mapped Drives for: " & sComputerName & " " & e.Message)
            LogError("Error getting Mapped Drives for: " & sComputerName & " " & e.Message)
        Finally
            Shares.Dispose()
        End Try
        ShowComputerShares = sOut
    End Function



    Public Sub SaveDataXML()
        'Try
        '    Dim sFilename As String
        '    sFilename = Application.StartupPath & "\" & sXMLOutput
        '    dt.WriteXmlSchema(sFilename & ".xsd")
        '    dt.WriteXml(sFilename & ".xml", False)
        '    MsgBox("Saved Data to " & sFilename)
        'Catch ex As Exception
        '    LogError("Error Saving Data to XML" & ex.Message & vbTab & ex.StackTrace)
        '    sendMail("Error Saving Data to XML", ex.Message & vbTab & ex.StackTrace)
        'End Try
    End Sub

    Public Function LoadXMLData() As DataTable
        'Try
        '    Dim sFilename As String
        '    dt = Nothing
        '    dt = New DataTable
        '    sFilename = Application.StartupPath & "\" & sXMLOutput
        '    dt.ReadXmlSchema(sFilename & ".xsd")
        '    dt.ReadXml(sFilename & ".xml")
        '    LoadXMLData = dt
        '    'DataGridView1.DataSource = dt
        '    'SetRowsFound()
        '    MsgBox("Loaded Saved Data from " & sFilename)
        'Catch ex As Exception
        '    LogError("Error Loading Data from XML" & ex.Message & vbTab & ex.StackTrace)
        '    sendMail("Error Loading Data From XML", ex.Message & vbTab & ex.StackTrace)
        '    LoadXMLData = Nothing
        'End Try

    End Function

    Public Function GetMembersOfGroup(SGroupName As String) As DataTable
        Dim dt As DataTable
        Dim dr As DataRow


        Dim de As New DirectoryEntry(sLdap)

        Dim MemberSearcher As New DirectorySearcher

        With MemberSearcher
            .SearchRoot = de
            .Filter = "(&(ObjectClass=Group)(CN=" & SGroupName & "))"
            .PropertiesToLoad.Add("SAMAccountName")
            .PropertiesToLoad.Add("Name")
            .PropertiesToLoad.Add("UID")
            .PropertiesToLoad.Add("distinguishedName")
            .PropertiesToLoad.Add("mail")
            .PropertiesToLoad.Add("Title")
            '.PropertiesToLoad.Add("")
            '.PropertiesToLoad.Add("")
        End With
        dt = New DataTable("Members")
        dt.Columns.Add(New DataColumn("Name", GetType(System.String)))
        'dt.Columns.Add(New DataColumn("UserID", GetType(System.String)))
        'dt.Columns.Add(New DataColumn("LOC", GetType(System.String)))
        'dt.Columns.Add(New DataColumn("GroupName", GetType(System.String)))
        'dt.Columns.Add(New DataColumn("OU", GetType(System.String)))
        'Dim findUser As DirectorySearcher = New DirectorySearcher(de, MemberSearcher.Filter)
        With MemberSearcher
            .SearchRoot = de
            .Filter = "(&(ObjectClass=Group)(CN=" & SGroupName & "))"
            .PropertiesToLoad.Add("Member")
        End With

        Dim mySearchResults As SearchResult = MemberSearcher.FindOne()

        For Each User In mySearchResults.Properties("Member")
            dr = dt.NewRow
            dr(0) = GetCNfromString(User)
            dt.Rows.Add(dr)
        Next
        Return dt
    End Function


    Public Function GetMemberOfInfo() As DataTable

        Try
            Dim directory As DirectoryEntry = New DirectoryEntry(sLdap)
            Dim filter As String = "(&(objectCategory=person)(objectClass=user))"
            Dim dt As DataTable
            '(objectClass=contact)(objectClass=user)

            Dim findUser As DirectorySearcher = New DirectorySearcher(directory, filter)
            findUser.PropertiesToLoad.Clear()
            findUser.PropertiesToLoad.Add("SAMAccountName")
            findUser.PropertiesToLoad.Add("Name")
            findUser.PropertiesToLoad.Add("uid")
            findUser.PropertiesToLoad.Add("cn")
            findUser.PropertiesToLoad.Add("memberof")
            findUser.PropertiesToLoad.Add("distinguishedName")
            findUser.PropertiesToLoad.Add("telephoneNumber")
            findUser.PropertiesToLoad.Add("showInAddressBook")


            Dim adResults As SearchResultCollection
            findUser.SizeLimit = 20000
            findUser.PageSize = 20000

            dt = New DataTable("MemberOf")

            dt.Columns.Add(New DataColumn("Name", GetType(System.String)))
            dt.Columns.Add(New DataColumn("UserID", GetType(System.String)))
            dt.Columns.Add(New DataColumn("LOC", GetType(System.String)))
            dt.Columns.Add(New DataColumn("GroupName", GetType(System.String)))
            dt.Columns.Add(New DataColumn("OU", GetType(System.String)))
            'dt.Columns.Add(New DataColumn("distinguishedName", GetType(System.String)))

            Dim dr As DataRow
            adResults = findUser.FindAll
            For Each adResult As SearchResult In adResults
                ' add the results to the datatable 
                If adResult.Properties("distinguishedName").Count > 0 Then
                    Dim sOu As String
                    sOu = adResult.Properties("distinguishedName")(0).ToString
                    'If Not (InStr(sOu, "Generic") > 0 Or InStr(sOu, "Disabled Users") > 0) Then
                    'If InStr(sOu, "Winchester") > 0 Or InStr(sOu, "Corporate") > 0 Or InStr(sOu, "Chlor") > 0 Then ') And (InStr(sOu, "Users") > 0) Then

                    '    If adResult.Properties("showInAddressBook").Count > 0 Then
                    If adResult.Properties("memberof").Count > 0 Then
                        Dim i As Integer = 0
                        For i = 0 To adResult.Properties("memberof").Count - 1
                            dr = dt.NewRow()
                            dr(0) = adResult.Properties("cn")(0).ToString()
                            dr(1) = adResult.Properties("sAMAccountName")(0).ToString()
                            dr(2) = getLocation(adResult.Properties("cn")(0).ToString())
                            dr(3) = GetGroupPath(adResult.Properties("memberof")(i).ToString())
                            dr(4) = GetOuPath(adResult.Properties("memberof")(i).ToString())
                            ' dr(4) = GetOuPath(adResult.Properties("distinguishedName")(0).ToString())
                            dt.Rows.Add(dr)
                        Next
                    End If
                End If
            Next
            Return dt
        Catch ex As Exception
            'Me.Cursor = Cursors.Default
            MsgBox("Error." & vbCrLf & ex.Message)
            LogError("GetUserADinfo " & ex.Message & vbCrLf & ex.StackTrace)
            sendMail("GetUserADinfo ", ex.Message & vbCrLf & ex.StackTrace)
            Return Nothing
        End Try

    End Function

    Public Function GetPrinterInfo() As DataTable

        Try
            Dim directory As DirectoryEntry = New DirectoryEntry(sLdap)
            Dim filter As String = "(&(objectCategory=printQueue))"
            Dim dt As DataTable
            '(objectClass=contact)(objectClass=user)

            Dim findUser As DirectorySearcher = New DirectorySearcher(directory, filter)


            '            printspooling = PrintAfterSpooled
            '            url = http : //DE01TS.corp.local/Lexmark XM1140 (Labor)
            'shortservername = DE01TS
            '            drivername = Lexmark Universal v2
            'printmaxyextent = 3600
            '            printkeepprintedjobs = False
            '            cn = DE01TS - Lexmark XM1140 (Labor)
            'printendtime = 60
            '            printminyextent = 762
            '            printstaplingsupported = False
            '            printlanguage = HPGL2
            '            servername = DE01TS.corp.local
            '            dscorepropagationdata = 10 / 26 / 2016 12:42:29 PM
            'dscorepropagationdata = 1 / 1 / 1601 12:00:02 AM
            'printnumberup = 6
            '            Exception thrown: 'System.InvalidCastException' in Microsoft.VisualBasic.dll
            'Operator '&' is not defined for string "objectguid =  " and type 'Byte()'.
            '        driverversion = 1025
            '        whencreated = 9 / 11 / 2016 1:03:31 AM
            'usnchanged = 17267816
            '        printmemory = 4096
            '        whenchanged = 9 / 11 / 2016 1:21:41 AM
            'printorientationssupported = LANDSCAPE
            '        printorientationssupported = PORTRAIT
            '        name = DE01TS - Lexmark XM1140 (Labor)
            'printrateunit = PagesPerMinute
            '        printmaxxextent = 2159
            '        objectcategory = CN = Print() - Queue,CN=Schema,CN=Configuration,DC=corp,DC=local
            'printcollate = True
            '        instancetype = 4
            '        printmediaready = A4
            '        versionnumber = 4
            '        printmediasupported = Universal
            '        printmediasupported = Oficio(México)(216 x 340 mm)
            '        printmediasupported = A6
            '        printmediasupported = Envelope Monarch
            'printmediasupported = Envelope B5
            'printmediasupported = Envelope C5
            'printmediasupported = Envelope DL
            'printmediasupported = Envelope #10
            'printmediasupported = Envelope #9
            'printmediasupported = Folio
            '        printmediasupported = B5(JIS)
            '        printmediasupported = A5
            '        printmediasupported = A4
            '        printmediasupported = Executive
            '        printmediasupported = Statement
            '        printmediasupported = Legal
            '        printmediasupported = Letter
            '        printstarttime = 60
            '        adspath = LDAP : //stl02DC/CN=DE01TS-Lexmark XM1140 (Labor),CN=DE01TS,OU=DE01TS,OU=TS,OU=Servers,OU=Corp,DC=corp,DC=local
            'printrate = 45
            '        portname = 10.1.20.101
            'distinguishedname = CN = DE01TS - Lexmark XM1140 (Labor),CN=DE01TS,OU=DE01TS,OU=TS,OU=Servers,OU=Corp,DC=corp,DC=local
            'objectclass = top
            '        objectclass = leaf
            '        objectclass = connectionPoint
            '        objectclass = printQueue
            '        printpagesperminute = 45
            '        usncreated = 17267816
            '        printminxextent = 762
            '        printsharename = Lexmark XM1140 (Labor)
            'flags = 0
            '        printmaxresolutionsupported = 1200
            '        printername = Lexmark XM1140 (Labor)
            'printbinnames = Manual Envelope
            'printbinnames = Manual Paper
            'printbinnames = Multipurpose Feeder
            'printbinnames = Tray 4
            'printbinnames = Tray 3
            'printbinnames = Tray 2
            'printbinnames = Tray 1
            'printbinnames = Use printer settings
            'printbinnames = Automatically Select
            'priority = 1
            '        uncname =  \\ DE01TS.corp.local \ Lexmark XM1140 (Labor)
            'printduplexsupported = True
            '        printcolor = False




            findUser.PropertiesToLoad.Clear()
            findUser.PropertiesToLoad.Add("cn")
            findUser.PropertiesToLoad.Add("DriverName")
            findUser.PropertiesToLoad.Add("printstaplingsupported")
            findUser.PropertiesToLoad.Add("printlanguage")
            findUser.PropertiesToLoad.Add("portname")
            findUser.PropertiesToLoad.Add("servername")
            findUser.PropertiesToLoad.Add("whencreated")
            findUser.PropertiesToLoad.Add("printmemory")
            findUser.PropertiesToLoad.Add("name")
            findUser.PropertiesToLoad.Add("printcollate")
            findUser.PropertiesToLoad.Add("printrate")
            findUser.PropertiesToLoad.Add("printsharename")
            findUser.PropertiesToLoad.Add("printduplexsupported")
            findUser.PropertiesToLoad.Add("printcolor")

            Dim adResults As SearchResultCollection
            findUser.SizeLimit = 20000
            findUser.PageSize = 20000

            dt = New DataTable("Printer")
            dt.Columns.Add(New DataColumn("cn", GetType(System.String)))
            dt.Columns.Add(New DataColumn("ShareName", GetType(System.String)))
            dt.Columns.Add(New DataColumn("DriverName", GetType(System.String)))
            dt.Columns.Add(New DataColumn("PortName", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Created", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Memory", GetType(System.String)))
            dt.Columns.Add(New DataColumn("ServerName", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Name", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Status", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Comments", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Color", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Duplex", GetType(System.String)))
            dt.Columns.Add(New DataColumn("PrintRate", GetType(System.String)))

            'dt.Columns.Add(New DataColumn("distinguishedName", GetType(System.String)))

            Dim dr As DataRow
            adResults = findUser.FindAll
            For Each adResult As SearchResult In adResults
                ' add the results to the datatable 
                dr = dt.NewRow()
                Try
                    dr(0) = adResult.Properties("cn")(0).ToString()
                    dr(1) = adResult.Properties("PrintShareName")(0).ToString()
                    dr(2) = adResult.Properties("DriverName")(0).ToString()
                    dr(3) = "http://" & adResult.Properties("PortName")(0).ToString()
                    dr(4) = adResult.Properties("whencreated")(0).ToString()
                    If adResult.Properties("printmemory").Count > 0 Then
                        dr(5) = adResult.Properties("printmemory")(0).ToString()
                    End If
                    dr(6) = adResult.Properties("ServerName")(0).ToString()
                    dr(7) = adResult.Properties("Name")(0).ToString()
                    dr(8) = "" 'adResult.Properties("Status")(0).ToString()
                    dr(9) = "" 'adResult.Properties("description")(0).ToString()
                    dr(10) = adResult.Properties("PrintColor")(0).ToString()
                    dr(11) = adResult.Properties("PrintDuplexsupported")(0).ToString()
                    If adResult.Properties("Printrate").Count > 0 Then
                        dr(12) = adResult.Properties("Printrate")(0).ToString()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                dt.Rows.Add(dr)
            Next

            Return dt
        Catch ex As Exception
            'Me.Cursor = Cursors.Default
            MsgBox("Error." & vbCrLf & ex.Message)
            LogError("GetUserADinfo " & ex.Message & vbCrLf & ex.StackTrace)
            sendMail("GetUserADinfo ", ex.Message & vbCrLf & ex.StackTrace)
            Return Nothing
        End Try

    End Function




    Public Function GetGroupPath(ByVal StrPath As String) As String
        Dim sTemp() As String
        Dim sOut As String = ""
        Try
            sTemp = Split(StrPath, ", ")
            sOut = Mid(sTemp(0), 4)
            Return sOut
        Catch ex As Exception
            Return " - -" & sOut
        End Try
    End Function

    Public Function GetOuPath(ByVal strpath As String) As String
        Dim sTemp() As String
        Dim sOut As String = ""
        Dim sDC As String = ""
        Dim i As Integer = 0
        Try
            sTemp = Split(strpath, ", ")

            For i = 0 To sTemp.Length - 1
                If InStr(sTemp(i), "DC") > 0 Then
                    sDC += Mid(sTemp(i), 4) & "."
                End If
            Next
            'remove Last Period
            sDC = Mid(sDC, 1, sDC.Length - 1)

            For i = sTemp.Length - 3 To 2 Step -1
                If InStr(sTemp(i), "CN=") < 2 Or InStr(sTemp(i), "=") < 2 Then
                    sOut += "\" & Mid(sTemp(i), 4)
                End If
            Next

            sOut = sDC & sOut
            Return sOut
        Catch ex As Exception
            Return "-- " & sOut
        End Try
    End Function



    Public Function GetOUList() As DataTable

        Try
            Dim sConnection As String ' = "server=olinsccmsql;database=SMS_EAI;Trusted_Connection=True;"
            Dim ssql As String

            ssql = "Select distinct Netbios_Name0 As ComputerName, vras.System_OU_Name0  As OU" &
                    " from v_RA_System_SystemOUName vras INNER JOIN v_R_System vrs " &
                    " On vrs.ResourceID = vras.ResourceID " &
                    " where System_OU_Name0 In  " &
                    " (Select distinct max(System_OU_Name0) " &
                    " from v_RA_System_SystemOUName  " &
                    " where vras.ResourceID = v_RA_System_SystemOUName .ResourceID) " &
                    " ORDER by Netbios_Name0,System_OU_Name0"

            Dim objDataAdapter As New SqlDataAdapter(ssql, sConnection)
            Dim dsResult As New DataSet("OuResult")

            If Not IsNothing(objDataAdapter) Then
                ' Fill data into dataset
                objDataAdapter.Fill(dsResult)

                objDataAdapter.Dispose()
            End If

            GetOUList = dsResult.Tables(0)
        Catch ex As Exception
            LogError("Error Getting OU Info. " & ex.Message)
            MsgBox(ex.Message)
            GetOUList = Nothing
        End Try

    End Function

    Public Function GetContactsLocal(dt As DataTable) As DataTable
        ' Create Outlook application.

        Dim oApp As Outlook.Application = New Outlook.Application()

        ' Get NameSpace and Logon.
        Dim oNS As Outlook.NameSpace = oApp.GetNamespace("mapi")
        'oNS.Logon("Outlook", Missing.Value, False, True) ' TODO:

        ' Get the first contact from the Contacts folder.
        Dim cContacts As Outlook.MAPIFolder = oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts)

        Dim oItems As Outlook.Items = cContacts.Items

        Dim oCt As Outlook.ContactItem

        Try
            Dim obj As Object
            For i As Integer = 1 To oItems.Count
                obj = oItems(i)
                If TypeOf obj Is Outlook.ContactItem Then
                    oCt = oItems(i)
                    Try
                        Dim dr As DataRow
                        dr = dt.NewRow()
                        ' Display some common properties.
                        Debug.Print(oCt.FullName)
                        dr(0) = oCt.FullName
                        dr(1) = GetPhoneNumbers(oCt)
                        dr(2) = GetEmails(oCt)
                        dr(5) = oCt.BusinessAddress
                        dr(8) = "PERSONAL"
                        dt.Rows.Add(dr)
                    Catch ex As Exception
                        LogError("Error Parsing Local Contacts: " & ex.Message)
                    End Try
                End If
            Next
        Catch ex As Exception
            LogError("Error Parsing Local Contacts: " & ex.Message)
        Finally

            ' Display
            'oCt.Display(True)

            ' Log off.
            oNS.Logoff()

            ' Clean up.
            oApp = Nothing
            oNS = Nothing
            oItems = Nothing
            oCt = Nothing

        End Try

        Return dt

    End Function

    Public Function GetPhoneNumbers(oct As Outlook.ContactItem) As String
        Dim sOut As String = ""
        Try
            If Not IsNothing(oct.BusinessTelephoneNumber) Then
                If oct.BusinessTelephoneNumber.Length > 0 Then
                    sOut += "(W) " & oct.BusinessTelephoneNumber
                End If
            End If

            If Not IsNothing(oct.MobileTelephoneNumber) Then
                If oct.MobileTelephoneNumber.Length > 0 Then
                    If sOut.Length > 1 Then
                        sOut += vbCrLf
                    End If
                    sOut += " (C) " & oct.MobileTelephoneNumber
                End If
            End If

            If Not IsNothing(oct.HomeTelephoneNumber) Then
                If oct.HomeTelephoneNumber.Length > 0 Then
                    If sOut.Length > 1 Then
                        sOut += vbCrLf
                    End If
                    sOut += "vbcrlf (H) " & oct.HomeTelephoneNumber
                End If
            End If
        Catch ex As Exception
            LogError("Error Getting PhoneNumber: " & oct.FullName, ex.StackTrace)
        End Try

        Return sOut

    End Function

    Public Sub SaveFormSettings(frm As SCCMReports)
        My.Settings.SCCMReportOpen = "Y"
        My.Settings.SCCMReportHeight = frm.Height
        My.Settings.SCCMReportWidth = frm.Width
        My.Settings.SCCMReportX = frm.Location.X
        My.Settings.SCCMReportY = frm.Location.Y
        My.Settings.Save()
    End Sub




    Public Function GetEmails(oct As Outlook.ContactItem) As String
        Dim sOut As String = ""
        Try
            If Not IsNothing(oct.Email1Address) Then
                If oct.Email1Address.Length > 0 Then
                    If InStr(oct.Email1Address, "@") > 1 Then
                        sOut += oct.Email1Address
                    End If
                End If
            End If

            If Not IsNothing(oct.Email2Address) Then
                If oct.Email2Address.Length > 0 Then
                    If InStr(oct.Email2Address, "@") > 1 Then
                        If sOut.Length > 1 Then
                            sOut += vbCrLf
                        End If
                        sOut += vbCrLf & oct.Email2Address
                    End If
                End If
            End If

            If Not IsNothing(oct.Email3Address) Then
                If oct.Email3Address.Length > 0 Then
                    If InStr(oct.Email3Address, "@") > 1 Then
                        If sOut.Length > 1 Then
                            sOut += vbCrLf
                        End If
                        sOut += vbCrLf & oct.Email3Address
                    End If
                End If
            End If
        Catch ex As Exception
            LogError("Error Getting Email(s): " & oct.FullName, ex.StackTrace)
        End Try

        Return sOut

    End Function
    Public Sub FillUserIDFullName()

        Dim directory As DirectoryEntry = New DirectoryEntry(sLdap)
        Dim filter As String = "(&(objectCategory=person)(objectClass=user))"
        Dim findUser As DirectorySearcher = New DirectorySearcher(directory, filter)
        Try
            findUser.PropertiesToLoad.Clear()
            findUser.PropertiesToLoad.Add("sAMAccountName")
            findUser.PropertiesToLoad.Add("cn")
            findUser.PropertiesToLoad.Add("distinguishedName")
            findUser.PropertiesToLoad.Add("showinaddressbook")
            findUser.PropertiesToLoad.Add("telephonenumber")
            Dim adResults As SearchResultCollection
            findUser.SizeLimit = 20000
            findUser.PageSize = 20000
            dcUserIDFullname = New Dictionary(Of String, String)
            dcUserIDFullname.Clear()
            adResults = findUser.FindAll
            For Each adResult As SearchResult In adResults
                ' add the results to the datatable 
                Try
                    If adResult.Properties("distinguishedName").Count > 0 Then
                        Dim sOu As String
                        sOu = adResult.Properties("distinguishedName")(0).ToString
                        If adResult.Properties("telephoneNumber").Count > 0 Or adResult.Properties("Company").Count > 0 Then
                            dcUserIDFullname.Add(adResult.Properties("sAMAccountName")(0).ToString().ToUpper, adResult.Properties("CN")(0).ToString())
                        End If
                    End If
                Catch ex As Exception
                    LogError("Error Trying something in FillUserIDFUllName. " & ex.Message)
                End Try

            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Function LongFromLargeInteger(lg As Integer) As Long

    End Function

    Public Function LongToDate(lDate As Long) As Date

    End Function


    Public Function GetUserADInfo(Optional AddMemberInfo As Boolean = False) As DataTable
        Try
            MainParent.ToolStripStatusLabel.Text = "Sending query to Active Directory"
            MainParent.Refresh()
            Dim directory As DirectoryEntry = New DirectoryEntry(sLdap)
            Dim filter As String = "(&(objectCategory=person)(objectClass=user))"
            '(objectClass=contact)(objectClass=user)
            Dim dt As DataTable

            Dim findUser As DirectorySearcher = New DirectorySearcher(directory, filter)
            findUser.PropertiesToLoad.Clear()
            findUser.PropertiesToLoad.Add("SAMAccountName")
            findUser.PropertiesToLoad.Add("Name")
            findUser.PropertiesToLoad.Add("distinguishedName")
            findUser.PropertiesToLoad.Add("Title")        'showInAddressBook
            findUser.PropertiesToLoad.Add("uid")
            findUser.PropertiesToLoad.Add("givenname")
            findUser.PropertiesToLoad.Add("displayname")
            findUser.PropertiesToLoad.Add("cn")
            findUser.PropertiesToLoad.Add("mail")
            findUser.PropertiesToLoad.Add("telephoneNumber")
            findUser.PropertiesToLoad.Add("mobile")

            'findUser.PropertiesToLoad.Add("postaladdress")
            findUser.PropertiesToLoad.Add("streetaddress")
            findUser.PropertiesToLoad.Add("l") 'City
            findUser.PropertiesToLoad.Add("postalcode") 'Zipcode
            findUser.PropertiesToLoad.Add("st") 'State


            findUser.PropertiesToLoad.Add("ipphone")
            findUser.PropertiesToLoad.Add("memberof")
            'findUser.PropertiesToLoad.Add("homedrive")
            findUser.PropertiesToLoad.Add("homedirectory")
            findUser.PropertiesToLoad.Add("ou")
            findUser.PropertiesToLoad.Add("Company")
            findUser.PropertiesToLoad.Add("Manager")

            findUser.PropertiesToLoad.Add("AccountExpires")
            findUser.PropertiesToLoad.Add("LockOutTime")
            findUser.PropertiesToLoad.Add("lastLogon")
            findUser.PropertiesToLoad.Add("pwdLastSet")
            findUser.PropertiesToLoad.Add("disabled")
            findUser.PropertiesToLoad.Add("WhenCreated")
            findUser.PropertiesToLoad.Add("WhenChanged")
            findUser.PropertiesToLoad.Add("physicaldeliveryofficename")
            findUser.PropertiesToLoad.Add("info")
            findUser.PropertiesToLoad.Add("UserAccountControl")


            Dim adResults As SearchResultCollection
            findUser.SizeLimit = 20000
            findUser.PageSize = 20000
            dt = New DataTable("AD_Users")

            dt.Columns.Add(New DataColumn("Name", GetType(System.String)))          '0
            dt.Columns.Add(New DataColumn("Telephone", GetType(System.String)))     '1
            dt.Columns.Add(New DataColumn("Email", GetType(System.String)))         '2
            dt.Columns.Add(New DataColumn("UserID", GetType(System.String)))        '3
            dt.Columns.Add(New DataColumn("Title", GetType(System.String)))      '4
            dt.Columns.Add(New DataColumn("StreetAddress", GetType(System.String))) '5
            dt.Columns.Add(New DataColumn("LOC", GetType(System.String)))          '6
            'dt.Columns.Add(New DataColumn("HomeDrive", GetType(System.String)))
            dt.Columns.Add(New DataColumn("HomeDirectory", GetType(System.String))) '7
            dt.Columns.Add(New DataColumn("Company", GetType(System.String)))       '8
            dt.Columns.Add(New DataColumn("Manager", GetType(System.String)))           '9

            dt.Columns.Add(New DataColumn("Status", GetType(System.String))) '10
            dt.Columns.Add(New DataColumn("LastLogon", GetType(System.DateTime)))       '11
            dt.Columns.Add(New DataColumn("pwdLastSet", GetType(System.DateTime)))      '12
            dt.Columns.Add(New DataColumn("LockOutTime", GetType(System.DateTime)))     '13

            dt.Columns.Add(New DataColumn("Created", GetType(System.DateTime)))     '14
            dt.Columns.Add(New DataColumn("Changed", GetType(System.DateTime)))     '15

            If AddMemberInfo Then
                dt.Columns.Add(New DataColumn("MemberOf", GetType(System.String)))      '16
                dt.Columns.Add(New DataColumn("OU", GetType(System.String)))            '17
            End If

            Dim dr As DataRow
            adResults = findUser.FindAll
            MainParent.ToolStripStatusLabel.Text = "Recieved Results now parsing data...."
            MainParent.Refresh()
            Dim iCnt As Integer = 1
            Dim iSkip As Integer = 0
            For Each adResult As SearchResult In adResults
                ' add the results to the datatable 
                If iCnt Mod 100 = 0 Then
                    MainParent.ToolStripStatusLabel.Text = "Recieved Results now parsing record " & iCnt
                    MainParent.Refresh()
                End If
                Try
                    If adResult.Properties("distinguishedName").Count > 0 Then
                        Dim sOu As String
                        sOu = adResult.Properties("distinguishedName")(0).ToString
                        ' If adResult.Properties("telephoneNumber").Count > 0 Or adResult.Properties("Company").Count > 0 Then
                        'If adResult.Properties("showInAddressBook").Count > 0 Then
                        dr = dt.NewRow()

                        dr(0) = adResult.Properties("cn")(0).ToString()
                        If adResult.Properties("telephoneNumber").Count > 0 Then
                            dr(1) = adResult.Properties("telephoneNumber")(0).ToString()
                        End If

                        If adResult.Properties("mail").Count > 0 Then
                            dr(2) = adResult.Properties("mail")(0).ToString()
                        End If

                        dr(3) = adResult.Properties("sAMAccountName")(0).ToString()


                        If adResult.Properties("Title").Count > 0 Then
                            dr(4) = adResult.Properties("Title")(0).ToString()
                        End If

                        If adResult.Properties("streetaddress").Count > 0 Then
                            dr(5) = adResult.Properties("streetaddress")(0).ToString()
                        End If

                        If adResult.Properties("l").Count > 0 Then
                            dr(5) += ", " & adResult.Properties("l")(0).ToString  'City
                        End If

                        If adResult.Properties("st").Count > 0 Then
                            dr(5) += " " & adResult.Properties("st")(0).ToString()  'State
                        End If

                        If adResult.Properties("postalcode").Count > 0 Then
                            dr(5) += " " & adResult.Properties("postalcode")(0).ToString()  'Zipcode
                        End If

                        If adResult.Properties("Physicaldeliveryofficename").Count > 0 Then
                            dr(6) = adResult.Properties("Physicaldeliveryofficename")(0).ToString()
                        End If

                        If adResult.Properties("homedirectory").Count > 0 Then
                            dr(7) = adResult.Properties("homedirectory")(0).ToString()
                        End If

                        'Get Location of User

                        If adResult.Properties("Company").Count > 0 Then
                            dr(8) = adResult.Properties("Company")(0).ToString()
                        End If

                        If adResult.Properties("Manager").Count > 0 Then
                            dr(9) = Mid(adResult.Properties("Manager")(0).ToString(), 4, (InStr(adResult.Properties("Manager")(0).ToString(), ",")) - 4)
                        End If

                        'dr(9) = getLocation(adResult.Properties("cn")(0).ToString())
                        If adResult.Properties("UserAccountControl").Count > 0 Then
                            Dim Iresult As Int64
                            Dim sText As String
                            Iresult = adResult.Properties("UserAccountControl")(0)
                            Select Case Iresult
                                Case 512
                                    sText = "Enabled Account"
                                Case 514
                                    sText = "Disabled Account"
                                Case 544
                                    sText = "Enabled, Password Not Required"
                                Case 546
                                    sText = "Disabled, Password Not Required"
                                Case 2080
                                    sText = "Interdomain_trust_Account, Password Not Required"
                                Case 66048
                                    sText = "Enabled, Password Doesn't Expire"
                                Case 66050
                                    sText = "Disabled, Password Doesn't Expire"
                                Case 66080
                                    sText = "Enabled, Password Doesn't Expire & Not Required"
                                Case 66082
                                    sText = "Disabled, Password Doesn't Expire & Not Required"
                                Case 262656
                                    sText = "Enabled, Smartcard Required"
                                Case 262658
                                    sText = "Disabled, Smartcard Required"
                                Case 262688
                                    sText = "Enabled, Smartcard Required, Password Not Required"
                                Case 262690
                                    sText = "Disabled, Smartcard Required, Password Not Required"
                                Case 328192
                                    sText = "Enabled, Smartcard Required, Password Doesn't Expire"
                                Case 328194
                                    sText = "Disabled, Smartcard Required, Password Doesn't Expire"
                                Case 328224
                                    sText = "Enabled, Smartcard Required, Password Doesn't Expire & Not Required"
                                Case 328226
                                    sText = "Disabled, Smartcard Required, Password Doesn't Expire & Not Required"
                                Case Else
                                    sText = Iresult & ": N/A"
                            End Select
                            dr(10) = sText
                        End If

                        Try
                            If adResult.Properties("lastLogon").Count > 0 Then
                                If adResult.Properties("lastLogon")(0) > 0 Then
                                    dr(11) = Date.FromFileTime(adResult.Properties("lastLogon")(0))
                                End If
                            End If
                        Catch
                        End Try

                        Try
                            If adResult.Properties("pwdLastSet").Count > 0 Then
                                If adResult.Properties("pwdLastSet")(0) > 0 Then
                                    dr(12) = Date.FromFileTime(adResult.Properties("pwdLastSet")(0))
                                End If
                            End If
                        Catch
                        End Try

                        Try
                            If adResult.Properties("LockoutTime").Count > 0 Then
                                If adResult.Properties("LockoutTime")(0) > 0 Then
                                    dr(13) = Date.FromFileTime(adResult.Properties("LockoutTime")(0))
                                End If
                            End If
                        Catch
                        End Try


                        Try
                            If adResult.Properties("WhenCreated").Count > 0 Then
                                dr(14) = adResult.Properties("WhenCreated")(0)
                            End If
                        Catch
                        End Try

                        Try
                            If adResult.Properties("WhenChanged").Count > 0 Then
                                dr(15) = adResult.Properties("WhenChanged")(0)
                            End If
                        Catch
                        End Try

                        If AddMemberInfo Then
                            If adResult.Properties("memberof").Count > 0 Then
                                Dim sTemp As String = ""
                                Dim i As Integer = 0
                                For i = 0 To adResult.Properties("memberof").Count - 1
                                    sTemp += GetGroupPath(adResult.Properties("memberof")(i).ToString())
                                    sTemp += vbCrLf
                                Next
                                dr(16) = sTemp
                            End If

                            If adResult.Properties("distinguishedName").Count > 0 Then
                                dr(17) = GetOuPath(adResult.Properties("distinguishedName")(0).ToString())
                            End If

                        End If 'ADMember

                        dt.Rows.Add(dr)

                    End If 'Telephone Number isn't blank or Company isn't blank.
                    '  End If  'Disginguished Name isn't blank
                    'End If 
                    'End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                iCnt += 1
            Next
            adResults.Dispose()
            MainParent.ToolStripStatusLabel.Text = "Finished " & dt.Rows.Count & " rows "
            MainParent.Refresh()
            Return dt

        Catch ex As Exception
            'Me.Cursor = Cursors.Default
            MsgBox("Error." & vbCrLf & ex.Message)
            LogError("GetUserADinfo " & ex.Message & vbCrLf & ex.StackTrace)
            sendMail("GetUserADinfo ", ex.Message & vbCrLf & ex.StackTrace)
            Return Nothing
        End Try

    End Function
    Public Function GetNameFromUserid(sUserID As String) As String

        Dim stemp As String = ""
        Try
            If dcUserIDFullname.ContainsKey(sUserID.ToUpper) Then
                stemp = dcUserIDFullname.Item(sUserID.ToUpper)
            End If
        Catch ex As Exception
            LogError("Error Finding Name for user:   " & sUserID, ex.Message)
        End Try

        Return stemp
    End Function

    Public Function GetGroupInfo() As DataTable
        Dim dt As DataTable
        Try

            Dim directory As DirectoryEntry = New DirectoryEntry(sLdap)
            Dim filter As String = "(objectCategory=Group)"
            Dim findUser As DirectorySearcher = New DirectorySearcher(directory, filter)
            'findUser.PropertiesToLoad.Clear()
            'findUser.PropertiesToLoad.Add("CN")
            'findUser.PropertiesToLoad.Add("DisplayName")
            'findUser.PropertiesToLoad.Add("Description")
            'findUser.PropertiesToLoad.Add("DistinguishedName")
            'findUser.PropertiesToLoad.Add("sAMAccountName")
            'findUser.PropertiesToLoad.Add("Created")
            'findUser.PropertiesToLoad.Add("memberof")
            'findUser.PropertiesToLoad.Add("members")

            Dim adResults As SearchResultCollection
            findUser.SizeLimit = 20000
            findUser.PageSize = 20000
            dt = New DataTable("Groups")

            dt.Columns.Add(New DataColumn("Name", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Mail", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Description", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Created", GetType(System.DateTime)))
            dt.Columns.Add(New DataColumn("MemberOf", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Members", GetType(System.String)))
            dt.Columns.Add(New DataColumn("ADSPath", GetType(System.String)))

            Dim dr As DataRow
            findUser.SearchScope = SearchScope.Subtree
            adResults = findUser.FindAll
            For Each adResult As SearchResult In adResults
                ' add the results to the datatable 

                'For Each prop In adResult.Properties
                '    Debug.Print(prop.propertyname & " " & prop.value)
                'Next

                Dim sOu As String
                Dim iRow As Integer = 0

                dr = dt.NewRow()
                iRow = iRow + 1
                Try
                    If adResult.Properties("Name")(0).ToString.Length > 0 Then
                        dr(0) = adResult.Properties("Name")(0).ToString()
                    End If
                Catch ex As Exception
                End Try

                Try
                    If adResult.Properties("Mail").Count > 0 Then
                        dr(1) = adResult.Properties("Mail")(0).ToString()
                    End If
                Catch ex As Exception
                End Try


                Try
                    If adResult.Properties("Description")(0).ToString.Length > 0 Then
                        dr(2) = adResult.Properties("Description")(0).ToString()
                    End If
                Catch ex As Exception
                End Try

                'If adResult.Properties("WhenCreated")(0).count > 0 Then
                dr(3) = adResult.Properties("WhenCreated")(0).ToString
                'End If

                Dim sTemp As String = ""
                Try
                    If adResult.Properties("MemberOf").Count > 0 Then
                        Dim i As Integer = 0
                        For i = 0 To adResult.Properties("memberof").Count - 1
                            sTemp += GetCNfromString(adResult.Properties("memberof")(i).ToString())
                            sTemp += vbCrLf
                        Next
                        dr(4) = sTemp
                    End If
                Catch ex As Exception
                    dr(4) = sTemp
                End Try
                Try
                    If adResult.Properties("Member").Count > 0 Then
                        Dim i As Integer = 0
                        For i = 0 To adResult.Properties("member").Count - 1
                            sTemp += GetCNfromString(adResult.Properties("member")(i).ToString())
                            sTemp += vbCrLf
                        Next
                        dr(5) = sTemp
                    End If
                Catch ex As Exception
                    dr(5) = sTemp
                End Try


                If adResult.Properties("adsPath").Count > 0 Then
                    dr(6) = Mid(adResult.Properties("adsPath")(0).ToString(), 8)
                End If


                dt.Rows.Add(dr)

            Next
            Return dt
        Catch ex As Exception

            MsgBox("Error." & vbCrLf & ex.Message)
            LogError("GetUserADinfo " & ex.Message & vbCrLf & ex.StackTrace)
            ' sendMail("GetUserADinfo ", ex.Message & vbCrLf & ex.StackTrace)
            Return dt
        End Try
    End Function

    Public Function GetCNfromString(sIn As String) As String
        Dim ibeg As Integer
        Dim iend As String
        Dim sTemp As String
        Dim sOut As String = ""
        Try
            sTemp = sIn
            iend = InStr(sTemp, ",")
            sOut = Mid(sIn, 4, iend - 4)
        Catch ex As Exception
            Return sOut
        End Try

        Return sOut
    End Function

    Public Function getComputerADInfo() As DataTable
        Try

            Dim directory As DirectoryEntry = New DirectoryEntry(sLdap)
            Dim filter As String = "(objectCategory=computer)"
            Dim findUser As DirectorySearcher = New DirectorySearcher(directory, filter)
            Dim dt As DataTable

            findUser.PropertiesToLoad.Clear()
            findUser.PropertiesToLoad.Add("Name")
            findUser.PropertiesToLoad.Add("distinguishedName")
            findUser.PropertiesToLoad.Add("operatingsystemversion")
            findUser.PropertiesToLoad.Add("uid")
            findUser.PropertiesToLoad.Add("givenname")
            findUser.PropertiesToLoad.Add("displayname")
            findUser.PropertiesToLoad.Add("cn")
            findUser.PropertiesToLoad.Add("lastlogon")
            findUser.PropertiesToLoad.Add("operatingsystem")
            findUser.PropertiesToLoad.Add("serviceprincipalname")
            findUser.PropertiesToLoad.Add("homephone")
            findUser.PropertiesToLoad.Add("ou")

            Dim adResults As SearchResultCollection
            findUser.SizeLimit = 20000
            findUser.PageSize = 20000
            dt = New DataTable("Computers")

            dt.Columns.Add(New DataColumn("USER", GetType(System.String)))
            dt.Columns.Add(New DataColumn("USERID", GetType(System.String)))
            dt.Columns.Add(New DataColumn("Name", GetType(System.String)))
            dt.Columns.Add(New DataColumn("OS", GetType(System.String)))
            dt.Columns.Add(New DataColumn("SP", GetType(System.String)))
            dt.Columns.Add(New DataColumn("LOC", GetType(System.String)))
            dt.Columns.Add(New DataColumn("OU", GetType(System.String)))

            Dim dr As DataRow
            adResults = findUser.FindAll
            For Each adResult As SearchResult In adResults
                ' add the results to the datatable 

                Dim sOu As String
                Dim iRow As Integer = 0
                sOu = adResult.Properties("distinguishedName")(0).ToString

                dr = dt.NewRow()

                If adResult.Properties("cn")(0).ToString().Length > 9 Then
                    dr(iRow) = GetNameFromUserid(adResult.Properties("cn")(0).ToString().Substring(4, 6).ToUpper)
                End If

                If adResult.Properties("cn")(0).ToString().Length > 9 Then
                    dr(iRow + 1) = adResult.Properties("cn")(0).ToString().Substring(4, 6)
                End If

                dr(iRow + 2) = adResult.Properties("cn")(0).ToString()

                If adResult.Properties("operatingsystem").Count > 0 Then
                    dr(iRow + 3) = adResult.Properties("operatingsystem")(0).ToString()
                End If

                If adResult.Properties("operatingsystemversion").Count > 0 Then
                    dr(iRow + 4) = adResult.Properties("operatingsystemversion")(0).ToString()
                End If

                If adResult.Properties("cn")(0).ToString.Length > 4 Then
                    dr(iRow + 5) = adResult.Properties("cn")(0).ToString.Trim.Substring(0, 4)
                Else
                    dr(iRow + 5) = adResult.Properties("cn")(0).ToString.Trim
                End If

                If adResult.Properties("distinguishedName").Count > 0 Then
                    dr(iRow + 6) = GetOuPath(adResult.Properties("distinguishedName")(0).ToString())
                End If
                dt.Rows.Add(dr)

            Next
            Return dt
        Catch ex As Exception
            MsgBox("Error." & vbCrLf & ex.Message)
            LogError("GetUserADinfo " & ex.Message & vbCrLf & ex.StackTrace)
            sendMail("GetUserADinfo ", ex.Message & vbCrLf & ex.StackTrace)
            Return Nothing
        End Try
    End Function


    Public Sub LogError(ByVal sExMessage As String, Optional ByVal sStackTrace As String = "")
        Try
            Dim sComputer As String
            Dim sUser As String
            Dim sMsg As String
            Dim sFileName As String


            sFileName = sLogfileName & Format(Now(), "yyyy_MM_dd") & "_ADSLookup.log"
            sComputer = My.Computer.Name
            sUser = My.User.Name

            sMsg = Now() & vbTab & sUser & vbTab & sComputer & vbTab & sExMessage & vbTab & sStackTrace

            Try
                FileOpen(22, sFileName, OpenMode.Append)
            Catch ex As Exception
                FileOpen(22, sLogfileName & "adslookup1.Log", OpenMode.Append)
            End Try
            PrintLine(22, sMsg)
            FileClose(22)
        Catch e As Exception
            sendMail("Error logging", e.Message & vbCrLf & e.StackTrace)
            'System.Diagnostics.Debug.WriteLine("Error   sending To answer midwest " & Now)
        End Try
    End Sub

    Public Function Ping(sComputerName As String) As String
        Dim sOut As String = ""
        sOut = "Pinging " & sComputerName & vbCrLf & vbCrLf
        Try
            Dim MyPing As New System.Net.NetworkInformation.Ping
            Dim Myreply As System.Net.NetworkInformation.PingReply = MyPing.Send(sComputerName)

            Select Case Myreply.Status
                Case Net.NetworkInformation.IPStatus.Success
                    sOut += "Successfully pinged " & Myreply.Address.ToString & vbCrLf & vbCrLf & " Roundtrip time Is: " & Myreply.RoundtripTime & " ms"
                Case Net.NetworkInformation.IPStatus.TimedOut
                    sOut += "Timeout while pinging "
                Case Net.NetworkInformation.IPStatus.TimeExceeded
                    sOut += "TimeExceeded while pinging "
                Case Net.NetworkInformation.IPStatus.TtlExpired
                    sOut += "Ttl Expired while pinging "
                Case Net.NetworkInformation.IPStatus.Unknown
                    sOut += "Unknown Error pinging "
            End Select
        Catch pe As System.Net.NetworkInformation.PingException
            sOut = "Ping request could not find host " & sComputerName & vbCrLf & vbCrLf & " Please check the name and try again."
            LogError("Error Pinging " & sComputerName & " " & pe.InnerException.Message)
        Catch ex As Exception
            LogError("Error Pinging " & sComputerName & " " & ex.Message)
            sOut = "Error Pinging " & sComputerName & vbCrLf & ex.Message
        End Try
        Ping = sOut
    End Function

    Public Function PingSimple(sComputerName As String) As Boolean
        Dim bGood As Boolean = False

        Try
            Dim MyPing As New System.Net.NetworkInformation.Ping
            Dim Myreply As System.Net.NetworkInformation.PingReply = MyPing.Send(sComputerName)

            Select Case Myreply.Status
                Case Net.NetworkInformation.IPStatus.Success
                    bGood = True
            End Select
        Catch pe As System.Net.NetworkInformation.PingException
            Return bGood
        Catch ex As Exception
            Return bGood
        End Try
        Return bGood
    End Function

    Public Function ParseString(sin As String, Optional sType As String = "USERINFO") As String
        Dim sOut As String = ""
        Dim iBeg As Integer
        Dim iEnd As Integer
        Select Case sType
            Case "USERINFO"
                iBeg = InStr(sin, ".net.") + 6
                iEnd = InStr(sin, "The command")
                If iEnd = 0 Then
                    sOut = sin
                Else
                    sOut = Mid(sin, iBeg, iEnd - iBeg)
                End If
            Case "PING"
                iBeg = InStr(sin, "Pinging")
                If InStr(sin, "Average =") > 1 Then
                    iEnd = InStr(sin, "Average =") + 15
                End If

                If iBeg = 0 Then 'Failed Ping
                    iBeg = InStr(sin, ">")
                    iEnd = InStr(sin, "again.") + 6
                End If
                If iEnd = 0 Then 'Failed Ping
                    iEnd = InStr(sin, "loss)") + 6
                End If
                If iEnd = 0 Then
                    sOut = "Failed to Ping machine"
                Else
                    sOut = Mid(sin, iBeg, iEnd - iBeg)
                End If
            Case "COMPINFO"
                iBeg = InStr(sin, ".net.") + 6
                iEnd = InStr(sin, "The command")
                sOut = Mid(sin, iBeg, sin.Length - iEnd)
        End Select

        Return sOut

    End Function

    Public Function GetCurrentUserName() As String
        Dim sTemp() As String
        sTemp = Split(My.User.Name, "\")
        GetCurrentUserName = sTemp(sTemp.Length - 1)
    End Function

    Public Function isSCCMUser(sUserID As String) As Boolean
        Dim bSCCM As Boolean = False
        Dim sGroupList As String
        Dim scommand As String = "net users " & sUserID & " /domain"
        'sCommand = "NET GROUP " & Chr(34) & sGroup & Chr(34) & " /Domain"
        sGroupList = ParseString(RunDosCommand(scommand))
        If InStr(LCase(sGroupList), "sccm") > 0 Then
            bSCCM = True
        End If
        isSCCMUser = bSCCM
    End Function

    Public Sub sendMailRTF(sSubject As String, sBody As RichTextBox, Optional sTo As String = "", Optional sFrom As String = "ADlookup@NoWhere.com")
        If sTo.Length = 0 Then
            sTo = sEmailTo
        End If

        Try
            Dim mymail = CreateObject("CDO.Message")
            mymail.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2
            mymail.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/smtpserver") = ""
            mymail.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25
            mymail.from = sFrom
            mymail.subject = "ADLookup User: " & My.User.Name & " " & My.Computer.Name & " " & sSubject
            mymail.to = sTo
            mymail.bodyformat = Outlook.OlBodyFormat.olFormatRichText
            mymail.textBody = sBody.Rtf
            mymail.configuration.fields.update()
            'mymail.send()

            LogError("Trying to send email: " & sSubject.ToString & vbCrLf & vbCrLf & sBody.ToString)

        Catch e As Exception

            LogError(e.Message)
            'System.Diagnostics.Debug.WriteLine("error   sending to answer midwest " & Now)
        End Try
    End Sub



    Public Sub sendMail(sSubject As String, sBody As String, Optional sTo As String = "", Optional sFrom As String = "ADLookup@NoWhere.Com")
        If sTo.Length = 0 Then
            sTo = sEmailTo
        End If

        Try
            Dim mymail = CreateObject("CDO.Message")
            mymail.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2
            mymail.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/smtpserver") = ""
            mymail.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25
            mymail.from = sFrom
            mymail.subject = "ADLookup User: " & My.User.Name & " " & My.Computer.Name & " " & sSubject
            mymail.to = sTo
            mymail.textBody = sBody
            mymail.configuration.fields.update()
            'mymail.send()
            LogError("Trying to send email:  " & sSubject & vbCrLf & vbCrLf & sBody)
        Catch e As Exception
            LogError(e.Message)
            'System.Diagnostics.Debug.WriteLine("error   sending to answer midwest " & Now)
        End Try
    End Sub

    Public Function RunDosCommand(sCommand As String) As String
        Try
            Dim myProcess As Process = New Process
            Dim sAppPath As String = Application.StartupPath
            Dim s As String
            Dim sTemp As String = sCommand
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.StartInfo.RedirectStandardError = True
            myProcess.Start()
            Dim sIn As StreamWriter = myProcess.StandardInput
            sIn.AutoFlush = True

            Dim sOut As StreamReader = myProcess.StandardOutput
            Dim sErr As StreamReader = myProcess.StandardError
            '        sIn.Write("dir c:\windows\system32\*.com" & _
            '          System.Environment.NewLine)
            sIn.Write(sTemp &
               System.Environment.NewLine)
            sIn.Write("exit" & System.Environment.NewLine)
            s = sOut.ReadToEnd()
            If Not myProcess.HasExited Then
                myProcess.Kill()
            End If

            '  MessageBox.Show("The 'dir' command window was " & _
            '    " closed at: " & myProcess.ExitTime & "." & _
            '    System.Environment.NewLine & "Exit Code: " & _
            '    myProcess.ExitCode)

            sIn.Close()
            sOut.Close()
            sErr.Close()
            myProcess.Close()
            RunDosCommand = s
        Catch ex As Exception
            LogError("Error Running Dos Command: " & sCommand & vbCrLf & ex.Message)
            MsgBox(ex.Message)
            RunDosCommand = "Error"
        End Try

    End Function

    Public Sub ExportToExcel(dgv As DataGridView, Optional bSelectedRows As Boolean = False)
        Dim _excel As New Excel.Application
        Dim wBook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        Dim dgr As DataGridViewRow
        Dim dgc As DataGridViewColumn

        Try
            wBook = _excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()
            _excel.Visible = False
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dgc In dgv.Columns
                colIndex = colIndex + 1
                wSheet.Cells(1, colIndex) = dgc.HeaderText
            Next

            For Each dgr In dgv.Rows
                colIndex = 0
                If Not bSelectedRows Then
                    rowIndex = rowIndex + 1
                    For Each dgc In dgv.Columns
                        colIndex = colIndex + 1
                        wSheet.Cells(rowIndex + 1, colIndex) = dgr.Cells(dgc.Index).Value
                    Next
                Else
                    If dgr.Selected Then
                        rowIndex = rowIndex + 1
                        For Each dgc In dgv.Columns
                            colIndex = colIndex + 1
                            wSheet.Cells(rowIndex + 1, colIndex) = dgr.Cells(dgc.Index).Value
                        Next
                    End If
                End If
            Next
            wSheet.Columns.AutoFit()
            _excel.Visible = True
            ReleaseObject(wSheet)
            ReleaseObject(wBook)
            ReleaseObject(_excel)
            GC.Collect()
        Catch ex As Exception
            ReleaseObject(_excel)
            MsgBox("Error Exporting:  " & ex.Message)
        End Try

    End Sub
    Public Sub ExportToExcel(ByVal dtTemp As DataTable) ', ByVal filepath As String)
        'Dim strFileName As String = filepath
        'If System.IO.File.Exists(strFileName) Then
        ' If (MessageBox.Show("Do you want to replace from the existing file?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
        ' System.IO.File.Delete(strFileName)
        ' Else
        ' Return
        ' End If

        'End If
        Dim _excel As New Excel.Application
        Dim wBook As Excel.Workbook
        Dim wSheet As Excel.Worksheet


        wBook = _excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()
        Dim dt As System.Data.DataTable = dtTemp
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0
        'If CheckBox1.Checked Then
        For Each dc In dt.Columns
            colIndex = colIndex + 1
            wSheet.Cells(1, colIndex) = dc.ColumnName
        Next
        'End If
        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        wSheet.Columns.AutoFit()
        'wBook.SaveAs(strFileName)

        ReleaseObject(wSheet)
        'wBook.Close(False)
        ReleaseObject(wBook)
        '_excel.Quit()
        'ReleaseObject(_excel)
        GC.Collect()
        MessageBox.Show("File Export Successfully!")
        _excel.Visible = True
    End Sub
    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Public Function checkUpper(ByVal str As String) As Boolean
        If Strings.StrComp(str, Strings.UCase(str)) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function getLocation(sName As String) As String
        Dim sLoc() As String
        Dim sout As String = ""
        sLoc = Split(sName, " ")
        For Each s As String In sLoc
            If checkUpper(s) And s.Length > 2 And InStr(s, ",") = 0 Then
                Return s
            End If
        Next
        Return sout
    End Function

    Public Function getSubfolders(sFolderpath As String) As String()
        Dim sout() As String
        Try
            sout = System.IO.Directory.GetDirectories(sFolderpath)
            getSubfolders = sout
        Catch ex As Exception
            getSubfolders = {}
        End Try

    End Function

    Public Function isFileInDirectories(sDirectories() As String, sFileName As String) As Boolean
        Dim bexists As Boolean = False
        For Each Str As String In sDirectories
            'Get the files foreach of those Directories using
            Dim files() As String = System.IO.Directory.GetFiles(Str, sFileName)
            If files.Count > 0 Then
                bexists = True
                sDameWareFile = Str & "\" & sFileName
            End If
        Next
        Return bexists
    End Function

    Public Function DameWareRemoteExists() As Boolean
        Dim bExists As Boolean = False
        Dim sFile As String = "DWRCC.exe"
        Dim sfileName As String = ""
        Dim sFolder1 As String = "C:\Program Files\DameWare Development\"
        Dim sFolder2 As String = "C:\Program Files (x86)\SolarWinds\"
        Dim sFolder3 As String = "C:\Program Files\SolarWinds\"

        'then get the folders foreach of those drives using:
        Dim directories() As String = getSubfolders(sFolder1)
        'will also work to get the directories in the each of the returned directories
        If directories.Length > 0 Then
            bExists = isFileInDirectories(directories, sFile)
        End If

        If Not bExists Then
            directories = getSubfolders(sFolder2)
            If directories.Length > 0 Then
                bExists = isFileInDirectories(directories, sFile)
            End If
        End If

        If Not bExists Then
            directories = getSubfolders(sFolder3)
            If directories.Length > 0 Then
                bExists = isFileInDirectories(directories, sFile)
            End If
        End If
        Return bExists

    End Function

    Public Sub ReadInXML()
        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode As XmlNodeList
        Dim i As Integer
        Dim str As String
        Dim fs As New FileStream("SQL.xml", FileMode.Open, FileAccess.Read)
        xmldoc.Load(fs)
        xmlnode = xmldoc.GetElementsByTagName("SQL")
        For i = 0 To xmlnode.Count - 1
            xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
            str = xmlnode(i).ChildNodes.Item(0).InnerText.Trim() & "  " & xmlnode(i).ChildNodes.Item(1).InnerText.Trim() & "  " & xmlnode(i).ChildNodes.Item(2).InnerText.Trim()
            MsgBox(str)
        Next
    End Sub

    Public Function GetAttachment(sEmailID As String) As String
        Dim tempApp As Outlook.Application
        Dim tempInbox As Outlook.MAPIFolder
        Dim InboxItems As Outlook.Items
        Dim dt As New DataTable
        Dim sFileName As String = ""

        'Dim objattachments, objAttach
        tempApp = CreateObject("Outlook.Application")
        'tempInbox = tempApp.GetNamespace("Mapi").Folders("Empower@Accellacorp.com").Folders("Inbox").Folders(sSubFolder)
        'InboxItems = tempInbox.Items
        Dim oMail As Outlook.MailItem
        'oMail = tempApp.GetNamespace("Mapi").Folders("Empower@Accellacorp.com").getitemfromid(sEmailID)
        oMail = tempApp.GetNamespace("Mapi").GetItemFromID(sEmailID)
        Try
            File.Delete("C:\Temp\" & oMail.Attachments(1).FileName)
            oMail.Attachments(1).SaveAsFile("C:\Temp\" & oMail.Attachments(1).FileName)
            sFileName = "C:\Temp\" & oMail.Attachments(1).FileName
        Catch ex As Exception
        End Try
        Return sFileName
    End Function

    Public Function GetInvoiceEMails(sSubFolder As String) As DataTable
        Dim tempApp As Outlook.Application
        Dim tempInbox As Outlook.MAPIFolder
        Dim InboxItems As Outlook.Items
        Dim dt As New DataTable

        'Dim objattachments, objAttach
        tempApp = CreateObject("Outlook.Application")

        If sSubFolder = "Inbox" Then
            tempInbox = tempApp.GetNamespace("Mapi").Folders("Empower@Accellacorp.com").Folders("Inbox")
        Else
            tempInbox = tempApp.GetNamespace("Mapi").Folders("Empower@Accellacorp.com").Folders("Inbox").Folders(sSubFolder)
        End If

        'tempInbox = tempApp.GetNamespace("Mapi").GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox)
        InboxItems = tempInbox.Items
        Dim newMail As Object 'Outlook.MailItem
        Dim oMail As Outlook.MailItem
        Dim rptItem As Outlook.ReportItem
        Dim fldrs As Outlook.Folder


        dt = New DataTable("Inbox")
        dt.Columns.Add(New DataColumn("ID", GetType(System.String)))          '0
        dt.Columns.Add(New DataColumn("Dat", GetType(System.DateTime)))          '0
        dt.Columns.Add(New DataColumn("Dat2", GetType(System.String)))          '0
        dt.Columns.Add(New DataColumn("From", GetType(System.String)))     '1
        dt.Columns.Add(New DataColumn("To", GetType(System.String)))         '2
        dt.Columns.Add(New DataColumn("CC", GetType(System.String)))         '2
        dt.Columns.Add(New DataColumn("Subject", GetType(System.String)))        '3
        dt.Columns.Add(New DataColumn("Body", GetType(System.String)))      '4
        dt.Columns.Add(New DataColumn("Type", GetType(System.String))) '5
        dt.Columns.Add(New DataColumn("Attachment", GetType(System.String)))         '2
        dt.Columns.Add(New DataColumn("Attachment Name", GetType(System.String)))         '2
        Dim dr As DataRow

        For Each fldrs In tempInbox.Folders
            Debug.Print(fldrs.EntryID & " : " & fldrs.Name)
        Next

        For Each newMail In InboxItems
            dr = dt.NewRow
            Debug.Print("ObjectType: " & TypeName(newMail))
            If (TypeOf newMail Is Outlook.MailItem) Then     'Email Found
                oMail = newMail
                'Debug.Print(newMail.Subject)
                dr("ID") = oMail.EntryID
                dr("Dat") = oMail.ReceivedTime
                dr("Dat2") = oMail.ReceivedTime
                dr("Subject") = oMail.Subject
                dr("To") = oMail.To
                dr("CC") = oMail.CC
                If oMail.Attachments.Count > 0 Then
                    dr("Attachment") = "Yes"
                    dr("Attachment Name") = oMail.Attachments(1).FileName
                Else
                    dr("Attachment") = "No"
                End If
                dr("Body") = oMail.Body
                dr("Type") = "MailItem"
                dr("From") = oMail.Sender.Name
                dt.Rows.Add(dr)
            ElseIf (TypeOf newMail Is Outlook.ReportItem) Then   ' Undeliverable found
                rptItem = newMail
                dr("Dat") = rptItem.CreationTime
                dr("Dat2") = rptItem.CreationTime
                dr("Subject") = rptItem.Subject
                'dr("To") = rptItem.
                'dr("CC") = rptItem.CC
                'dr("BCC") = rptItem.BCC
                dr("Body") = System.Text.Encoding.UTF8.GetString(System.Text.Encoding.Unicode.GetBytes(rptItem.Body)) 'rptItem.Body
                dr("Type") = "ReportItem"
                'dr("From") = rptItem.Send
                dt.Rows.Add(dr)
                'Debug.Print(rptItem.Subject)
                'Debug.Print(rptItem.Body)
            Else 'Found Something else besides email / undeliverable
                Debug.Print("********** " & TypeName(newMail) & " ***************")
            End If

            'If newMail.UnRead Then
            'Dim des As String = newMail.Body
            'if u want to delete
            'newMail.Delete()

            'End If
        Next
        InboxItems = Nothing
        tempInbox = Nothing
        tempApp = Nothing
        Return dt
    End Function
End Module
