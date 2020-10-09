Public Class ListarPersona
    Private Sub ListarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPersona.SelectedIndexChanged
        Dim iterador As Integer = 0
        Dim stringTelEliminado = ListPersona.SelectedItems(0).SubItems(0).Text

    End Sub
End Class