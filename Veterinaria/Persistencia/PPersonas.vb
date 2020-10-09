Public Class PPersonas
    Dim conexion As New Npgsql.NpgsqlConnection()

    Public Function buscarPersona(cedula As Integer) As Personas
        Dim personaBuscada As New Personas
        Try

            Dim claseConexion As New PConexion

            Dim conetionPP = claseConexion.OpenConexion()
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = conetionPP

            Dim cadenaDeComandos = "Select * from persona where ci = @ci"
            Dim comandTel = "Select telefono from telefono where personaci = @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = cedula

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows Then
                Lector.Read()

                personaBuscada.Ci = Convert.ToInt32(Lector(0).ToString)
                personaBuscada.Nombre = Lector(1).ToString
                personaBuscada.Direccion = Lector(2).ToString
            End If

        Catch ex As Exception

        End Try

        Return personaBuscada

    End Function

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

            If resultado = 1 Then
                Dim i = 0
                While i < personita.Listatelefono.Count
                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = conexion
                    cadenaComando = "insert into telefono(ci, telefono) values(@ci, @telefono)"
                    cmd.CommandText = cadenaComando

                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personita.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = personita.Listatelefono.Item(i)

                    resultado = cmd.ExecuteNonQuery()
                    i += 1
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub modificarPersona(nuevaPersona As Personas)
        Dim Connection
        Try
            Dim classConnection = New PConexion
            Connection = classConnection.OpenConexion()

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComando = "INSERT INTO Personas (ci,nombre,direccion) VALUES (@ci_,@nombre_,@direccion_);"
            cmd.CommandText = cadenaDeComando

            cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Ci
            cmd.Parameters.Add("@nombre_", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nuevaPersona.Nombre
            cmd.Parameters.Add("@direccion_", NpgsqlTypes.NpgsqlDbType.Varchar, 150).Value = nuevaPersona.Direccion
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
            If resultado = 1 Then
                Dim i As Integer
                i = 0
                cadenaDeComando = "DELETE * FROM telefono WHERE telefono.personaci = @ci"
                cmd.CommandText = cadenaDeComando
                cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Ci
                resultado = cmd.ExecuteNonQuery()
                'Modificar telefonos
                While i < nuevaPersona.Listatelefono.Count
                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = Connection

                    cadenaDeComando = "INSERT INTO telefono (personaci, telefono) VALUES (@ci_,@telefono_);"
                    cmd.CommandText = cadenaDeComando

                    cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Ci
                    cmd.Parameters.Add("@telefono_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Listatelefono.Item(i)

                    resultado = cmd.ExecuteNonQuery()
                    i = i + 1
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Sub

    Public Function listarPersona() As List(Of Personas)
        Try
            Dim listaPersonas As List(Of Personas)

            Dim claseConexion As New PConexion

            conexion = claseConexion.OpenConexion()
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim cadenaDeComandos = "SELECT * FROM PERSONA"

            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()

                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function
End Class
