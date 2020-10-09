Public Class LPersonas
    Public Sub altaPersona(persona As Personas)
        Dim persistencia As New PPersonas
        persistencia.altaPersona(persona)
    End Sub
    Public Function buscarPersona(CI As Integer) As Personas
        Dim persistencia As New PPersonas
        Return persistencia.BuscarPersona(CI)
    End Function
    Public Function listarPersona(CI As Integer) As  List(Of Personas)
        Dim persistencia As New PPersonas
        Return persistencia.listarPersona(CI)
    End Function
End Class
