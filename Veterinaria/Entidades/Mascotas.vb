Public Class Mascotas
    Dim _nombre As String
    Dim _dueño As Personas
    Dim _añoNac As Integer
    Dim _id As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Dueño As Personas
        Get
            Return _dueño
        End Get
        Set(value As Personas)
            _dueño = value
        End Set
    End Property
    Public Property AñoNacimiento As Integer
        Get
            Return _añoNac
        End Get
        Set(value As Integer)
            _añoNac = value
        End Set
    End Property
    Public Sub Mascotas()

    End Sub
    Public Sub Mascotas(nombre_ As String, dueño_ As Personas, añoNaci_ As Integer, id_ As Integer)
        Nombre = nombre_
        Dueño = dueño_
        AñoNacimiento = añoNaci_
        Id = id_
    End Sub
End Class
