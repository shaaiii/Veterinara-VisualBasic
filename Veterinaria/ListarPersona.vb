Public Class ListarPersona
    Private Sub ListarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logica As New LPersonas
        Dim listaPersonas As List(Of Personas)
        listaPersonas = logica.listarPersona()
        For Each persona As Personas In listaPersonas
            ListPersona.Items.Add(persona.Nombre)
        Next
    End Sub

    Private Sub ListPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPersona.SelectedIndexChanged

    End Sub
End Class