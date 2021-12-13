Imports System.Xml
Imports MySql.Data.MySqlClient

Public Class Form1

    'Variables para el XML
    Dim docXML As XmlDocument = New XmlDocument()
    Dim nodosList As XmlNodeList
    Dim nodoXML As XmlNode

    ' Conexin MySQL
    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=sakila"


    ' funcin solo con fines de testear la conexin con la base de datos
    Public Sub textConection()

        Dim Conexion As New MySqlConnection(connString)

        Try

            Conexion.Open()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

            Exit Sub

        End Try

        MessageBox.Show("Conectado")

        Conexion.Close()

    End Sub

    Public Function listadoActor() As DataSet
        Dim Conexion As New MySqlConnection(connString)

        Conexion.Open()

        Dim Query As String = "SELECT * FROM `empleados` LIMIT 1000;"

        Dim Adaptador As MySqlDataAdapter

        Dim dataSet As New DataSet

        Adaptador = New MySqlDataAdapter(Query, Conexion)

        Adaptador.Fill(dataSet, "empleado")

        Return dataSet


    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textConection()
    End Sub

    Private Sub leerXMLActores(cargaXMl As String)

        Try
            docXML.Load(cargaXMl)
            ' Estoy leyendo el XML en Row para simular una lectura en produccin real
            nodosList = docXML.SelectNodes("actores/actor")
            For Each nodoXML In nodosList
                actorNameCB.Items.Add(nodoXML.ChildNodes.Item(0).InnerText + " - " + nodoXML.ChildNodes.Item(1).InnerText + " " + nodoXML.ChildNodes.Item(2).InnerText)
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

    Private Sub actorNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles actorNameCB.SelectedIndexChanged

        MessageBox.Show(idActor(actorNameCB.SelectedItem.ToString))

    End Sub

    Public Function idActor(actorSeleccionado As String) As Int32
        ' extraigo el nombre completo del item seleccionado para seprar el ID del nombre 
        Dim idACtorSeleccionado = Int32.Parse(actorSeleccionado.Substring(0, actorSeleccionado.LastIndexOf(" - ")))
        ' MessageBox.Show(idACtorSeleccionado.Trim)

        Return idACtorSeleccionado

    End Function
End Class
