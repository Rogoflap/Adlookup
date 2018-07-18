Imports System.Xml

Public Class SQLQueryEditor

    Dim xmlDoc As New XmlDocument()
    Dim bAddNew As Boolean = False

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

    Private Sub cmbQueries_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbQueries.SelectedIndexChanged
        Dim sQuerySelected As String
        sQuerySelected = cmbQueries.Text
        lblID.Text = GetIDFromXML(sQuerySelected)
        txtQueryName.Text = cmbQueries.Text
        txtSQL.Text = GetSQLFromXML(sQuerySelected)
        cmbDBName.Text = GetDataBaseFromXML(sQuerySelected)
        cmbDBServer.Text = GetDBServerFromXML(sQuerySelected)
    End Sub


    Private Sub SQLQueryEditor_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadQueries()
    End Sub

    Private Sub SaveNewQuery()
        'Dim taskid As String
        'Dim status As String
        'Dim Tskid, stats As String

        'Tskid = taskid.ToString.Trim
        'stats = Status.ToString.Trim

        Dim myDoc As Xml.XmlDocument = New Xml.XmlDocument
        myDoc.Load(My.Application.Info.DirectoryPath & "\sql.xml")

        Dim root As XmlNode = myDoc.DocumentElement
        Dim myElement As XmlElement = myDoc.CreateElement("Query")

        Dim xID As XmlElement = myDoc.CreateElement("ID")
        xID.InnerText = lblID.Text

        Dim xQueryName As XmlElement = myDoc.CreateElement("QueryName")
        xQueryName.InnerText = txtQueryName.Text

        Dim xDBServer As XmlElement = myDoc.CreateElement("DBServer")
        xDBServer.InnerText = cmbDBServer.Text

        Dim xDatabase As XmlElement = myDoc.CreateElement("DataBase")
        xDatabase.InnerText = cmbDBName.Text

        Dim xSQL As XmlElement = myDoc.CreateElement("SQL")
        xSQL.InnerText = txtSQL.Text

        root.AppendChild(myElement)
        myElement.AppendChild(xID)
        myElement.AppendChild(xQueryName)
        myElement.AppendChild(xDBServer)
        myElement.AppendChild(xDatabase)
        myElement.AppendChild(xSQL)
        myDoc.Save(My.Application.Info.DirectoryPath & "\sql.xml")
    End Sub

    Private Sub UpdateQuery()
        xmlDoc.Load(My.Application.Info.DirectoryPath & "\sql.xml")
        Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Query")
        For Each node As XmlNode In nodes
            'Loop though till you get correct ID in XML
            If node.SelectSingleNode("ID").InnerText = lblID.Text Then
                node.SelectSingleNode("QueryName").InnerText = txtQueryName.Text
                Dim xNodeTest As XmlNode = node.SelectSingleNode("DBServer")

                If xNodeTest IsNot Nothing Then
                    node.SelectSingleNode("DBServer").InnerText = cmbDBServer.Text
                End If
                xNodeTest = node.SelectSingleNode("DataBase")

                If xNodeTest IsNot Nothing Then
                    node.SelectSingleNode("DataBase").InnerText = cmbDBName.Text
                End If

                node.SelectSingleNode("SQL").InnerText = txtSQL.Text
                xmlDoc.Save(My.Application.Info.DirectoryPath & "\sql.xml")
                MsgBox("Query Updated.", vbInformation, "Query Updated and Saved.")
                Exit For
            End If
        Next
        LoadQueries()
    End Sub

    Private Sub LoadQueries()
        Try
            cmbQueries.Items.Clear()
            xmlDoc.Load(My.Application.Info.DirectoryPath & "\sql.xml")
            Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Query")
            Dim QueryName As String = "", SQL As String = ""
            For Each node As XmlNode In nodes
                QueryName = node.SelectSingleNode("QueryName").InnerText
                SQL = node.SelectSingleNode("SQL").InnerText
                cmbQueries.Items.Add(QueryName)
                '    MessageBox.Show(QueryName & " " & SQL)
            Next
            cmbQueries.Items.Add(" Add New")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ClearFields()
        bAddNew = True
        txtQueryName.Text = ""
        txtSQL.Text = ""
        cmbDBName.Text = ""
        cmbDBServer.Text = ""
        lblID.Text = GetMaxIDFromXML() + 1
    End Sub

    Private Sub cmdLoadData_Click(sender As System.Object, e As System.EventArgs) Handles cmdAddNew.Click
        ClearFields()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not bAddNew Then
            UpdateQuery()
        Else
            SaveNewQuery()
            MsgBox("Saved New Query", vbInformation, "Saved New Query.")
        End If

    End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class