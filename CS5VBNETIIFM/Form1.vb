Imports System.Xml
Imports MySql.Data.MySqlClient

Public Class Form1

    'Variables para el XML
    Dim docXML As XmlDocument = New XmlDocument()
    Dim nodosList As XmlNodeList
    Dim nodoXML As XmlNode

    ' Conexin MySQL
    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=sakila"
    Dim reader As MySqlDataReader

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
            MessageBox.Show("Error XML: " + ex.Message)

        End Try

    End Sub

    Private Sub loadXMLBtn_Click(sender As Object, e As EventArgs) Handles loadXMLBtn.Click
        loadXMLDialog.ShowDialog()

        If loadXMLDialog.FileName <> "" Then

            leerXMLActores(loadXMLDialog.FileName)
            actorNameCB.Visible = True
            actorLabel.Visible = True
            MessageBox.Show("Carga de XML realizada")
        Else
            MessageBox.Show("No se carg un archivo XML")
        End If


    End Sub

    Private Sub actorNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles actorNameCB.SelectedIndexChanged

        ' MessageBox.Show(idActor(actorNameCB.SelectedItem.ToString))
        titulosActorRelacionado(idActor(actorNameCB.SelectedItem.ToString))


    End Sub

    Public Function idActor(actorSeleccionado As String) As Int32
        ' extraigo el nombre completo del item seleccionado para seprar el ID del nombre 
        Dim idACtorSeleccionado = Int32.Parse(actorSeleccionado.Substring(0, actorSeleccionado.LastIndexOf(" - ")))
        ' MessageBox.Show(idACtorSeleccionado.Trim)

        Return idACtorSeleccionado

    End Function

    Public Function idFilm(filmSeleccionado As String) As Int32
        ' extraigo el nombre completo del item seleccionado para seprar el ID del nombre 
        Dim idFilmSeleccionado = Int32.Parse(filmSeleccionado.Substring(0, filmSeleccionado.LastIndexOf(" - ")))

        Return idFilmSeleccionado

    End Function

    Public Sub titulosActorRelacionado(idActor As Int32)
        Dim Conexion As New MySqlConnection(connString)

        Conexion.Open()
        Dim Query As String = "select f.film_id, f.title " &
                            "From actor a " &
                            "inner join film_actor fa " &
                            "on fa.actor_id = a.actor_id " &
                            "inner join film f " &
                            "on f.film_id = fa.film_id " &
                            "where a.actor_id = @idActor"

        Try
            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            comando.Parameters.AddWithValue("@idActor", idActor)
            reader = comando.ExecuteReader()

            ' limpio los items antes de cargar los nuevos
            filmsListBox.Items.Clear()

            While reader.Read()
                filmsListBox.Items.Add(reader(0).ToString + " - " + reader(1).ToString)
            End While
            filmsListBox.Visible = True
            filmsLabel.Visible = True


        Catch ex As Exception
            MessageBox.Show("Error llenado de Film: " + ex.Message)
        Finally
            Conexion.Close()
        End Try

    End Sub

    Private Sub filmsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filmsListBox.SelectedIndexChanged
        ' MessageBox.Show("Test de click ")
        detallesFilmRelacionado(idFilm(filmsListBox.SelectedItem.ToString))

    End Sub

    Public Sub detallesFilmRelacionado(idFilm As Int32)
        Dim Conexion As New MySqlConnection(connString)

        Conexion.Open()
        Dim Query As String = "Select f.description, f.release_year, f.length, f.rating, f.special_features, l.name, c.name " &
                               "From film f " &
                               "inner Join language l " &
                                    "On l.language_id = f.language_id " &
                                "Left Join film_category fc " &
                                    "On fc.film_id = f.film_id " &
                                "Left Join category c " &
                                    "On c.category_id = fc.category_id " &
                                "where f.film_id = @idFilm"



        Try
            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            comando.Parameters.AddWithValue("@idFilm", idFilm)
            reader = comando.ExecuteReader()

            ' limpio los items antes de cargar los nuevos
            idiomasLB.Items.Clear()
            CategoryLB.Items.Clear()

            While reader.Read()
                idiomasLB.Items.Add(reader(5))
                CategoryLB.Items.Add(reader(6))
            End While
            detalleGB.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error llenado de ListBox Detalle Film: " + ex.Message)
        Finally
            Conexion.Close()
        End Try

    End Sub



End Class
