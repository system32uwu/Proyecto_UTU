﻿Imports Entidades
Imports ADODB
Imports ADODB.DataTypeEnum
Imports ADODB.CommandTypeEnum
Imports ADODB.ParameterDirectionEnum
Imports ADODB.CursorLocationEnum
Public Class D_Paciente
    Inherits D_Usuario
    Dim conexion As New Connection
    Public Function ListarPacientesCI(ci As String) As E_Paciente
        Dim leer As New Recordset
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "BuscarPACIENTExCI",
            .ActiveConnection = conexion
        }

        Dim intCI As Integer = Val(ci)

        Dim u As New E_Paciente With {
        .Cedula = intCI
        }

        cmd.Parameters.Append(cmd.CreateParameter("@cedula", adInteger, adParamInput, 8, intCI))
        Console.WriteLine("conexion : " & conexion.State)
        Try
            leer = cmd.Execute()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conexion.Close()
            Return u
        End Try
        Console.WriteLine("cantidad " & leer.RecordCount)

        Do While Not leer.EOF
            u = New E_Paciente With {
                 .Cedula = intCI,
                 .Nombre1 = leer("nombre1").Value,
                 .Nombre2 = leer("nombre2").Value,
                 .Apellido1 = leer("apellido1").Value,
                 .Apellido2 = leer("apellido2").Value,
                 .Correo = leer("correo").Value,
                 .Direccion = New List(Of String)(New String() {leer("direccion_calle").Value, leer("direccion_nroPuerta").Value}),
                 .Foto = leer("foto").Value,
                 .Estado_civil = leer("e_civil").Value,
                 .FechaNacimiento = leer("fecha_nac").Value,
                 .Ocupacion = leer("ocupacion").Value,
                 .Sexo = leer("sexo").Value
                }
            leer.MoveNext()
        Loop

        Dim lista As New List(Of String)

        'lista.Add(leer("telefono").Value.ToString())

        'u.TelefonosLista = lista
        Console.WriteLine(u.Nombre1)
        Console.WriteLine(u.Cedula)
        leer.Close()
        conexion.Close()

        Return u
    End Function

    Public Function AltaPaciente(u As E_Paciente) As Integer
        Dim code = MyBase.AltaUsuarioSIBIM(u)

        Select Case code
            Case 1
                conexion.ConnectionString = retornarCString()
                conexion.CursorLocation = CursorLocationEnum.adUseClient
                conexion.Open()

                Dim cmd As New Command With {
                    .CommandType = adCmdStoredProc,
                    .CommandText = "AltaPaciente",
                    .ActiveConnection = conexion
                }
                cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula.ToString().Length, u.Cedula))
                cmd.Parameters.Append(cmd.CreateParameter("@OCUPACION", adVarChar, adParamInput, 50, u.Ocupacion))
                cmd.Parameters.Append(cmd.CreateParameter("@E_CIVIL", adVarChar, adParamInput, 7, u.Estado_civil))
                cmd.Parameters.Append(cmd.CreateParameter("@FECHA_NAC", adDBDate, adParamInput, 50, u.FechaNacimiento))
                cmd.Parameters.Append(cmd.CreateParameter("@ETAPA", adChar, adParamInput, 1, u.Etapa.ToString()))
                cmd.Parameters.Append(cmd.CreateParameter("@SEXO", adChar, adParamInput, 1, u.Sexo.ToString()))

                Try
                    cmd.Execute() 'EJECUTO ALTA PACIENTESIBIM
                    conexion.Close()
                    Return 1
                Catch ex As Exception
                    conexion.Close()
                    Return 0 'No se pudo crear paciente
                End Try
            Case Else
                Return code
        End Select

    End Function

    Public Sub ModificarPaciente(u As E_Paciente)
        conexion.ConnectionString = retornarCString()
        conexion.CursorLocation = CursorLocationEnum.adUseClient
        conexion.Open()

        Dim cmd As New Command With {
            .CommandType = adCmdStoredProc,
            .CommandText = "AltaUsuarioSIBIM",
            .ActiveConnection = conexion
        }

        cmd.Parameters.Append(cmd.CreateParameter("@CI", adInteger, adParamInput, u.Cedula))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE1", adVarChar, adParamInput, 30, u.Nombre1))
        cmd.Parameters.Append(cmd.CreateParameter("@NOMBRE2", adVarChar, adParamInput, 30, u.Nombre2))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO1", adVarChar, adParamInput, 30, u.Apellido1))
        cmd.Parameters.Append(cmd.CreateParameter("@APELLIDO2", adVarChar, adParamInput, 30, u.Apellido2))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_C", adVarChar, adParamInput, 160, u.Direccion(0)))
        cmd.Parameters.Append(cmd.CreateParameter("@DIRECCION_N", adInteger, adParamInput, 4, CInt(u.Direccion(1))))
        cmd.Parameters.Append(cmd.CreateParameter("@ACTIVO", adInteger, adParamInput, 1, u.Activo))
        cmd.Parameters.Append(cmd.CreateParameter("@CORREO", adVarChar, adParamInput, 50, u.Correo))
        Dim ParametroFoto = cmd.CreateParameter("@FOTO", adLongVarBinary, adParamInput, u.Foto.Length)
        ParametroFoto.AppendChunk(u.Foto)
        cmd.Parameters.Append(ParametroFoto)

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