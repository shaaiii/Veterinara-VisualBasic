Public Class LPersonas
    Public Sub altaPersona(persona As Personas)
        Dim persistencia As New PPersonas
        persistencia.altaPersona(persona)
    End Sub
    Public Function buscarPersona(CI As Integer) As Personas
        Dim persistencia As New PPersonas
        Return persistencia.BuscarPersona(CI)
    End Function
    Public Function listarPersona() As List(Of Personas)
        Dim persistencia As New PPersonas
        Return persistencia.listarPersonas()
    End Function
    Public Sub modificarPersona(persona As Personas)
        Dim persistencia As New PPersonas
        persistencia.modificarPersona(persona)
    End Sub
End Class
