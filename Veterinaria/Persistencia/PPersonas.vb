Public Class PPersonas
    Dim conexion As New Npgsql.NpgsqlConnection()
    Public Sub altaPersona(personita As Personas)
        Try
            Dim clasecnn = New PConexion
            conexion = clasecnn.OpenConexion()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion

            Dim cadenaComando = "INSERT INTO persona (ci, nombre, direccion) VALUES(@ci, @nombre, @direccion);"
            cmd.CommandText = cadenaComando

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personita.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personita.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personita.Direccion
            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
