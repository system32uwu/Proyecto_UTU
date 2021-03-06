﻿Public Class E_Formulario
    Protected _id As Integer
    Protected _nombre As String
    Protected _xml As String
    Protected _v_previa As Byte()
    Protected _preguntasYrespuestas As New List(Of PreguntaRespuesta)
    Protected _enfermedad As New E_Enfermedad
    Protected _analisis As New E_Analisis
    Protected _tratamiento As New E_Tratamiento
    Protected _atiende As New E_Atiende
    Protected _errCode As Integer

    Property ErrCode As Integer
        Get
            Return _errCode
        End Get
        Set(value As Integer)
            _errCode = value
        End Set
    End Property
    Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property XML As String
        Get
            Return _xml
        End Get
        Set(value As String)
            _xml = value
        End Set
    End Property

    Property VistaPrevia As Byte()
        Get
            Return _v_previa
        End Get
        Set(value As Byte())
            _v_previa = value
        End Set
    End Property
    Property PreguntasYRespuestas As List(Of PreguntaRespuesta)
        Get
            Return _preguntasYrespuestas
        End Get
        Set(value As List(Of PreguntaRespuesta))
            _preguntasYrespuestas = value
        End Set
    End Property
    Property Enfermedad As E_Enfermedad
        Get
            Return _enfermedad
        End Get
        Set(value As E_Enfermedad)
            _enfermedad = value
        End Set
    End Property

    Property Analisis As E_Analisis
        Get
            Return _analisis
        End Get
        Set(value As E_Analisis)
            _analisis = value
        End Set
    End Property

    Property Tratamiento As E_Tratamiento
        Get
            Return _tratamiento
        End Get
        Set(value As E_Tratamiento)
            _tratamiento = value
        End Set
    End Property

    Property Atiende As E_Atiende
        Get
            Return _atiende
        End Get
        Set(value As E_Atiende)
            _atiende = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(nombre As String, xml As String, vPrevia As Byte())
        _nombre = nombre
        _xml = xml
        _v_previa = vPrevia
    End Sub

End Class