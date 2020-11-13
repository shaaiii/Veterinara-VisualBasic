Public Class LMascotas
    Public Function listarMascotas() As List(Of Mascotas)
        Dim persistencia As New PMascotas
        Return persistencia.listarMascotas()
    End Function
    Public Function buscarMascota(id As Integer) As Mascotas
        Dim persistencia As New PMascotas
        Return persistencia.buscarMascota(id)
    End Function
    Public Sub AltaMascota(mascota As Mascotas)
        Dim persistencia As New PMascotas
        persistencia.altaMascota(mascota)
    End Sub
    Public Sub ModificarMascota(mascota As Mascotas)
        Dim persistencia As New PMascotas
        persistencia.modificarMascota(mascota)
    End Sub
End Class
