﻿Public Class E_Atiende
    Protected _id As Integer
    Protected _nombre_c As String
    Protected _fecha As Date
    Protected _motivo As String
    Protected _paciente As New E_Paciente
    Protected _medico As New E_Medico

    Property Paciente As E_Paciente
        Get
            Return _paciente
        End Get
        Set(value As E_Paciente)
            _paciente = value
        End Set
    End Property
    Property Medico As E_Medico
        Get
            Return _medico
        End Get
        Set(value As E_Medico)
            _medico = value
        End Set
    End Property

    Property ID As Integer 'id de consulta
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property NombreConsulta As String
        Get
            Return _nombre_c
        End Get
        Set(value As String)
            _nombre_c = value
        End Set
    End Property
    Property Motivo As String
        Get
            Return _motivo
        End Get
        Set(value As String)
            _motivo = value
        End Set
    End Property

    Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(nombre, motivo)
        _nombre_c = nombre
    End Sub

End Class
