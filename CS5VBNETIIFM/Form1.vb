Imports System.Xml

Public Class Form1
    Dim nombre As String
    Dim docXML As XmlDocument = New XmlDocument()
    Dim nodosList As XmlNodeList
    Dim nodoXML As XmlNode

    Private Sub leerXMLActores(cargaXMl As String)

        Try
            docXML.Load(cargaXMl)
            ' Estoy leyendo el XML en Row para simular una lectura en produccin real
            nodosList = docXML.SelectNodes("actores/actor")
            For Each nodoXML In nodosList
                actorNameCB.Items.Add(nodoXML.ChildNodes.Item(1).InnerText + " " + nodoXML.ChildNodes.Item(2).InnerText)
            Next



        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)

        End Try

    End Sub

    Private Sub loadXMLBtn_Click(sender As Object, e As EventArgs) Handles loadXMLBtn.Click
        loadXMLDialog.ShowDialog()

        If loadXMLDialog.FileName <> "" Then

            leerXMLActores(loadXMLDialog.FileName)
            actorNameCB.Visible = True
            MessageBox.Show("Carga de XML realizada")
        Else
            MessageBox.Show("No se carg un archivo XML")
        End If


    End Sub
End Class
