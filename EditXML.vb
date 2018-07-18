Imports System.Data.SqlClient
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.Office.Interop
Imports System.Threading
Imports System.Xml


Public Class EditXML

    Dim bSaved As Boolean = False

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If bSaved Then
            Me.Close()
        End If

    End Sub

    Private Sub EditXML_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            Dim xmlDoc As New XmlDocument()
            Dim tnNode As TreeNode
            xmlDoc.Load(My.Application.Info.DirectoryPath & "\sql.xml") '<— Change this path with a valid XML file
            tvXML.Nodes.Clear()
            tvXML.Nodes.Add(xmlDoc.DocumentElement.Name)
            tnNode = New TreeNode
            tnNode = tvXML.Nodes(0)
            AddNode(xmlDoc.DocumentElement, tnNode)
        Catch xmlEx As XmlException
            MessageBox.Show(xmlEx.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub AddNode(ByVal inXmlNode As XmlNode, ByVal inTreeNode As TreeNode)
        Dim xNode As XmlNode
        Dim tNode As TreeNode
        Dim nodeList As XmlNodeList
        Dim i As Integer
        If inXmlNode.HasChildNodes Then
            nodeList = inXmlNode.ChildNodes
            i = 0
            While i <= nodeList.Count - 1
                xNode = inXmlNode.ChildNodes(i)
                inTreeNode.Nodes.Add(New TreeNode(xNode.Name))
                tNode = inTreeNode.Nodes(i)
                AddNode(xNode, tNode)
                i += 1
            End While
        Else
            inTreeNode.Text = (inXmlNode.OuterXml).Trim
        End If

    End Sub

    Private Sub btnSaveXML_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveXML.Click

    End Sub
End Class