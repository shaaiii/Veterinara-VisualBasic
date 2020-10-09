Public Class AltaPersona
    Private Const V As Boolean = True
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
        TelefonoPersonaInput.Enabled = False
        DireccionPersonaInput.Enabled = False
        NombrePersonaInput.Enabled = False
        lv_telefono.Enabled = False
        AceptarPersonaBtn.Enabled = False
        ModificarPersona.Enabled = False
        CancelarPersonabtn.Enabled = False
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ModificarPersona.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cedula As Integer
        cedula = CIPersonaInput.Text
        Dim personaNueva As Personas
        Dim logica As New LPersonas
        personaNueva = logica.buscarPersona(cedula)

        NombrePersonaInput.Enabled = True
        DireccionPersonaInput.Enabled = True
        TelefonoPersonaInput.Enabled = True
        lv_telefono.Enabled = True

        If IsNothing(personaNueva) Then
            AceptarPersonaBtn.Enabled = True
            CancelarPersonabtn.Enabled = True
        Else
            AceptarPersonaBtn.Enabled = True
            ModificarPersona.Enabled = True
            NombrePersonaInput.Text = personaNueva.Nombre
            DireccionPersonaInput.Text = personaNueva.Direccion
        End If
    End Sub

    Private Sub CIPersonaInput_TextChanged(sender As Object, e As EventArgs) Handles CIPersonaInput.TextChanged

    End Sub
End Class
