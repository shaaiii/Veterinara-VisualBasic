Public Class AltaPersona
    Dim listaTel As New List(Of Integer)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles TitleAltaPersona.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles DireccionPersonaText.Click

    End Sub

    Private Sub AceptarPersonaBtn_Click(sender As Object, e As EventArgs) Handles AceptarPersonaBtn.Click
        Dim personaNueva As Personas

        Dim NombrePersona As String
        NombrePersona = NombrePersonaInput.Text
        personaNueva.Nombre = NombrePersona

        Dim CIPersona As Integer
        CIPersona = CIPersonaInput.Text
        personaNueva.Ci = CIPersona

        Dim DireccionPersona As String
        DireccionPersona = DireccionPersonaInput.Text
        personaNueva.Direccion = DireccionPersona

        personaNueva.Listatelefono = listaTel

        Dim logica As LPersonas
        logica.altaPersona(personaNueva)

    End Sub

    Private Sub Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TelefonoPersona As Integer
        TelefonoPersona = TelefonoPersonaInput.Text
        listaTel.Add(TelefonoPersona)
        lv_telefono.Items.Add(TelefonoPersona)

        TelefonoPersonaInput.Text = ""

    End Sub

    Private Sub lv_telefono_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_telefono.SelectedIndexChanged
        Dim telefonoEliminado As Integer
        Dim iterador As Integer = 0
        Dim stringTelEliminado = lv_telefono.SelectedItems(0).SubItems(0).Text
        telefonoEliminado = Convert.ToInt32(stringTelEliminado)

        While iterador < listaTel.Count
            If telefonoEliminado = listaTel.Item(iterador) Then
                listaTel.Remove(telefonoEliminado)
                iterador = listaTel.Count
            End If
            iterador = iterador + 1
        End While

        lv_telefono.Clear()
        iterador = 0
        While iterador < listaTel.Count
            lv_telefono.Items.Add(listaTel.Item(iterador))
            iterador = iterador + 1
        End While
    End Sub
End Class
