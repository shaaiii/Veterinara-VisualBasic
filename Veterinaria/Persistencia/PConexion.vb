Public Class PConexion
    Public Function OpenConexion() As Npgsql.NpgsqlConnection
        Dim conexion As Npgsql.NpgsqlConnection
        Try
            conexion = New Npgsql.NpgsqlConnection()
            Dim cadenaDeConexion As String
            cadenaDeConexion = "Server=127.0.0.0;Port=5432;User Id='postgres';Password='root';Database=ejemplo"
            conexion.ConnectionString = cadenaDeConexion
            conexion.Open()
        Catch ex As Exception
            conexion.Close()
            Throw ex
        End Try
        Return conexion
    End Function

End Class
