﻿Imports Entidades
Imports Datos
Public Class N_Paciente

    Dim objDatos As New D_Paciente

    Public Function ListarUsuariosCI(CI As String)
        Return objDatos.ListarPacientesCI(CI)
    End Function
    Public Function UsuarioExiste(CI As String)
        Return objDatos.UsuarioExiste(CI)
    End Function
    Public Sub AltaPaciente(u As E_Paciente)
        objDatos.AltaPaciente(u)
    End Sub

    Public Sub ModificacionPaciente(u As E_Paciente)
        objDatos.ModificarPaciente(u)
    End Sub

    Public Sub BajaLogicaPaciente(u As E_Paciente)
        objDatos.BajaLogicaUsuario(u)
    End Sub

    Public Sub AltaLogicaPaciente(u As E_Paciente)
        objDatos.AltaLogicaUsuario(u)
    End Sub

End Class
