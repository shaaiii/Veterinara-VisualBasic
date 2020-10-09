Public Class Inicio
    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click


    End Sub

    Private Sub MascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotaToolStripMenuItem.Click
        AltaMascotas.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        AltaPersona.ShowDialog()
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        ListarPersona.ShowDialog()
    End Sub
End Class