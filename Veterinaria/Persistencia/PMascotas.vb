Public Class PMascotas
    Dim conexion As New Npgsql.NpgsqlConnection()

    Public Function buscarMascota(id As Integer) As Mascotas
        Dim mascotaBuscada As New Mascotas
        Try

            Dim claseConexion As New PConexion

            Dim conetionPP = claseConexion.OpenConexion()
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = conetionPP

            Dim cadenaDeComandos = "Select * from mascotas m inner join persona p on p.ci = m.cipersona where id = @id_"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@id_", NpgsqlTypes.NpgsqlDbType.Integer).Value = id

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows Then
                Lector.Read()

                mascotaBuscada.Id = Convert.ToInt32(Lector(0).ToString)
                mascotaBuscada.Nombre = Lector(1).ToString
                mascotaBuscada.AñoNacimiento = Convert.ToInt32(Lector(2).ToString)
                mascotaBuscada.Dueño.Ci = Convert.ToInt32(Lector(3).ToString)
            End If

        Catch ex As Exception

        End Try

        Return mascotaBuscada

    End Function

    Public Sub altaMascota(mascota As Mascotas)
        Try
            Dim clasecnn = New PConexion
            conexion = clasecnn.OpenConexion()
            Dim cmd = New Npgsql.NpgsqlCommand()
                cmd.Connection = conexion
                Dim cadenaComando = "INSERT INTO mascotas (id, nombre, añonacimiento, cipersona) VALUES(@id_, @nombre_, @añonacimiento_, @cipersona_);"
                cmd.CommandText = cadenaComando

                cmd.Parameters.Add("@id_", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascota.Id
                cmd.Parameters.Add("@nombre_", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = mascota.Nombre
                cmd.Parameters.Add("@añonacimiento_", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascota.AñoNacimiento
                cmd.Parameters.Add("@cipersona_", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascota.Dueño.Ci

                Dim resultado As Integer

                resultado = cmd.ExecuteNonQuery()


        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub modificarMascota(newMascota As Mascotas)
        Dim Connection
        Try
            Dim classConnection = New PConexion
            Connection = classConnection.OpenConexion()

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComando = "UPDATE mascotas Set nombre = @nombre_, añonacimiento = @añonacimiento_ where id = @id_ ;"
            cmd.CommandText = cadenaDeComando

            cmd.Parameters.Add("@id_", NpgsqlTypes.NpgsqlDbType.Integer).Value = newMascota.Id
            cmd.Parameters.Add("@nombre_", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = newMascota.Nombre
            cmd.Parameters.Add("@añonacimiento_", NpgsqlTypes.NpgsqlDbType.Integer).Value = newMascota.AñoNacimiento

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Sub

    Public Function listarMascotas() As List(Of Mascotas)
        Try
            Dim listaMascota As New List(Of Mascotas)

            Dim claseConexion As New PConexion

            conexion = claseConexion.OpenConexion()
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim cadenaDeComandos = "SELECT * FROM mascotas"

            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows() Then
                While Lector.Read()
                    Dim mascota As New Mascotas
                    mascota.Id = Convert.ToInt32(Lector(0).ToString)
                    mascota.Nombre = Lector(1).ToString
                    mascota.AñoNacimiento = Convert.ToInt32(Lector(2).ToString)
                    mascota.Dueño.Ci = Convert.ToInt32(Lector(3).ToString)
                    listaMascota.Add(mascota)
                End While
            End If

            Return listaMascota
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function
End Class
