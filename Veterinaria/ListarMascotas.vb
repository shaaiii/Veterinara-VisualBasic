Public Class ListarMascotas
    Private Sub ListarMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logica As New LMascotas
        Dim listaMascotas As List(Of Mascotas)
        listaMascotas = logica.listarMascotas()
        For Each mascota As Mascotas In listaMascotas
            listMascotas.Items.Add(mascota.Nombre)
        Next
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listMascotas.SelectedIndexChanged

    End Sub
End Class