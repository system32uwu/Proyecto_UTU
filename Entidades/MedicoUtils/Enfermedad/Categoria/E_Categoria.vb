﻿Public Class E_Categoria
    Protected _nombre As String
    Protected _descripcion As String
    Protected _errCode As Integer

    Property ErrCode As Integer
        Get
            Return _errCode
        End Get
        Set(value As Integer)
            _errCode = value
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

    Property Descripcion As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(nombre As String, descripcion As String)
        _nombre = nombre
        _descripcion = descripcion
    End Sub

End Class