Public Class AltaPersona
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles TitleAltaPersona.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles DireccionPersonaText.Click

    End Sub

    Private Sub AceptarPersonaBtn_Click(sender As Object, e As EventArgs) Handles AceptarPersonaBtn.Click
        Dim NombrePersona As String
        NombrePersona = NombrePersonaInput.Text

        Dim CIPersona As Integer
        CIPersona = CIPersonaInput.Text

        Dim DireccionPersona As String
        DireccionPersona = DireccionPersonaInput.Text

        Dim TelefonoPersona As Integer
        TelefonoPersona = TelefonoPersonaInput.Text

    End Sub

    Private Sub Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
