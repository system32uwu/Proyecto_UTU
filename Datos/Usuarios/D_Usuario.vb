﻿Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Public Class D_Usuario
    Inherits D_UsuarioMYSQL
    Dim conexion As New Connection
    Public Function BuscarUsuariosCI(ci As String) As E_Usuario
        Dim leer As New Recordset
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarUSUARIOxCI",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, ci))

        leer = cmd.Execute()

        Dim u As New E_Usuario

        While Not leer.EOF
            u = New E_Usuario With {
             .Cedula = leer("CI").Value,
             .Nombre1 = leer("nombre1").Value,
             .Nombre2 = leer("nombre2").Value,
             .Apellido1 = leer("apellido1").Value,
             .Apellido2 = leer("apellido2").Value,
             .Correo = leer("correo").Value,
             .Direccion = New List(Of String)(New String() {leer("direccion_calle").Value, leer("direccion_nroPuerta").Value}),
             .Foto = leer("foto").Value
            }

            u.TelefonosLista.Add(leer("telefono").Value)
        End While


        leer.Close()
        conexion.Close()


        Return u
    End Function

    Public Function UsuarioExiste(ci As String) As Integer
        Dim leer As New Recordset
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "USUARIOEXISTE",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, ci))
        cmd.Parameters.Append(cmd.CreateParameter("@EXISTE", adInteger, adParamOutput))

        leer = cmd.Execute()

        Dim existe As Integer = leer("@EXISTE").Value

        leer.Close()
        conexion.Close()

        Return existe
    End Function

    Public Overridable Function AltaUsuarioSIBIM(u As E_Usuario) As Integer

        Dim mysqlUser As New E_UsuarioMYSQL("u" & u.Cedula, u.Contrasena, u.Rol)
        If MyBase.AltaUsuario(mysqlUser) = 1 Then
            conexion.ConnectionString = retornarCString()
            conexion.CursorLocation = CursorLocationEnum.adUseClient
            conexion.Open()

            Dim cmd As New Command With {
                .CommandType = adCmdStoredProc,
                .CommandText = "AltaUsuario",
                .ActiveConnection = conexion
            }
            cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
            cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE1", adVarChar, adParamInput, 30, u.Nombre1))
            cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE2", adVarChar, adParamInput, 30, u.Nombre2))
            cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO1", adVarChar, adParamInput, 30, u.Apellido1))
            cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO2", adVarChar, adParamInput, 30, u.Apellido2))
            cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_C", adVarChar, adParamInput, 160, u.Direccion(0)))
            cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_N", adInteger, adParamInput, 4, CInt(u.Direccion(1))))
            cmd.Parameters.Append(cmd.CreateParameter("@ACTIVO", adBoolean, adParamInput, 1, u.Activo))
            cmd.Parameters.Append(cmd.CreateParameter("@CORREO", adVarChar, adParamInput, 50, u.Correo))
            Dim ParametroFoto = cmd.CreateParameter("@FOTO", adLongVarBinary, adParamInput, u.Foto.Length)
            ParametroFoto.AppendChunk(u.Foto)
            cmd.Parameters.Append(ParametroFoto)

            Try
                cmd.Execute() 'EJECUTO ALTA USUARIOMYSQL-USUARIOSIBIM
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
                Return 0 'No se pudo crear usuario
            End Try

            If AltaUsuarioTelefono(u) Then
                Return 1 'todo ok
            Else
                Return 3 'Falla alta telefono
            End If

        Else
            Return 2 'no se pudo crear usuario mysql
        End If

    End Function

    Public Function AltaUsuarioTelefono(u As E_Usuario) As Integer

        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        For Each t As String In u.TelefonosLista
            Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaUsuarioTelefono",
            .ActiveConnection = conexion
            }
            cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
            cmd.Parameters.Append(cmd.CreateParameter("@TELEFONO", adInteger, adParamInput, t.Length, CInt(t)))
            Try
                cmd.Execute()
                Console.WriteLine("exec")
            Catch ex As Exception
                conexion.Close()
                u.ErrMsg = "Error ingresando el teléfono: " & t
                Return 0 ' no se pudo ingresar telefono
            End Try
        Next

        conexion.Close()
        Return 1
    End Function

    Public Sub ModificarUsuario(u As E_Usuario)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "ModificarUsuario",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE1", adVarChar, adParamInput, 30, u.Nombre1))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE2", adVarChar, adParamInput, 30, u.Nombre2))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO1", adVarChar, adParamInput, 30, u.Apellido1))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO2", adVarChar, adParamInput, 30, u.Apellido2))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_C", adVarChar, adParamInput, 160, u.Direccion(0)))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_N", adInteger, adParamInput, CInt(u.Direccion(1))))
        cmd.Parameters.Append(cmd.CreateParameter("@ACTIVO", adInteger, adParamInput, u.Activo))
        cmd.Parameters.Append(cmd.CreateParameter("@CORREO", adVarChar, adParamInput, 50, u.Correo))
        cmd.Parameters.Append(cmd.CreateParameter("@FOTO", adBinary, adParamInput, 160, u.Foto))

        cmd.Execute()
        conexion.Close()
    End Sub

    Public Sub BajaLogicaUsuario(u As E_Usuario)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BajaLogicaUsuario",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@CI", u.Cedula))
        cmd.Execute()
        conexion.Close()
    End Sub

    Public Sub AltaLogicaUsuario(u As E_Usuario)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaLogicaUsuario",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@CI", u.Cedula))
        cmd.Execute()
        conexion.Close()
    End Sub

End Class