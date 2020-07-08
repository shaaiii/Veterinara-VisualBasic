Public Class AltaMascotas
    Private Sub AceptarMascotabtn_Click(sender As Object, e As EventArgs) Handles AceptarMascotabtn.Click
        Dim NombreMascota As String
        NombreMascota = NombreMascotaInput.Text

        Dim AñoNacimiento As Integer
        AñoNacimiento = AñoNacimientoInput.Text

        Dim CIDueño As Integer
        CIDueño = CIDueñoInput.Text
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class