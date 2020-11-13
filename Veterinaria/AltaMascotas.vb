Public Class AltaMascotas
    Private Sub AltaMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NombreMascotaInput.Enabled = False
        CIDueñoInput.Enabled = False
        AñoNacimientoInput.Enabled = False
        AceptarMascotabtn.Enabled = False
        ModificarMascota.Enabled = False
        CancelarMascotabtn.Enabled = False
    End Sub
    Private Sub AceptarMascotabtn_Click(sender As Object, e As EventArgs) Handles AceptarMascotabtn.Click
        Try
            Dim MascotaNueva As New Mascotas()
            Dim NuevoDueño As New Personas()

            Dim NombreMascota As String
            NombreMascota = NombreMascotaInput.Text
            MascotaNueva.Nombre = NombreMascota

            Dim AñoNacimiento As Integer
            AñoNacimiento = AñoNacimientoInput.Text
            MascotaNueva.AñoNacimiento = AñoNacimiento

            Dim id As Integer
            id = idMascotaInput.Text
            MascotaNueva.Id = id

            Dim CIDueño As Integer
            CIDueño = CIDueñoInput.Text
            NuevoDueño.Ci = CIDueño
            MascotaNueva.Dueño = NuevoDueño

            Dim logica As New LMascotas
            logica.AltaMascota(MascotaNueva)
            MsgBox("Se agrego la mascota correctamente")
        Catch ex As Exception
            MsgBox("Hubo un error con los datos, " + ex.Message)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonBuscarMascota_Click(sender As Object, e As EventArgs) Handles buttonBuscarMascota.Click
        Dim id As Integer
        id = idMascotaInput.Text
        Dim mascotaNueva As New Mascotas()
        Dim Dueño As New Personas()
        Dim logica As New LMascotas
        mascotaNueva = logica.buscarMascota(id)

        NombreMascotaInput.Enabled = True
        AñoNacimientoInput.Enabled = True
        CIDueñoInput.Enabled = True

        If IsNothing(mascotaNueva) Then
            AceptarMascotabtn.Enabled = True
            CancelarMascotabtn.Enabled = True
        Else
            AceptarMascotabtn.Enabled = True
            ModificarMascota.Enabled = True
            CancelarMascotabtn.Enabled = True
            NombreMascotaInput.Text = mascotaNueva.Nombre
            AñoNacimientoInput.Text = mascotaNueva.AñoNacimiento
            CIDueñoInput.Enabled = False
        End If
    End Sub


    Private Sub ModificarMascota_Click(sender As Object, e As EventArgs) Handles ModificarMascota.Click
        Dim id As Integer
        Dim nombre As String
        Dim añoNacimiento As Integer
        Dim ciDueño As String

        id = idMascotaInput.Text
        nombre = NombreMascotaInput.Text
        añoNacimiento = AñoNacimientoInput.Text
        ciDueño = CIDueñoInput.Text

        Dim nuevaMascota As New Mascotas()
        nuevaMascota.Id = id
        nuevaMascota.Nombre = nombre
        nuevaMascota.AñoNacimiento = añoNacimiento

        Dim logica As New LMascotas

        logica.ModificarMascota(nuevaMascota)

        MsgBox("Se modifico la mascota correctamente")

    End Sub

    Private Sub CancelarMascotabtn_Click(sender As Object, e As EventArgs) Handles CancelarMascotabtn.Click
        idMascotaInput.Clear()
        NombreMascotaInput.Clear()
        AñoNacimientoInput.Clear()
    End Sub
End Class