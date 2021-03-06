﻿Imports Entidades
Public Class frmCargarTarjetasP
    Protected _listaC As New List(Of E_Atiende)
    Protected _c_seleccionada As E_Atiende
    Property ListaConsultas As List(Of E_Atiende)
        Get
            Return _listaC
        End Get
        Set(value As List(Of E_Atiende))
            _listaC = value
        End Set
    End Property

    Property ConsultaSeleccionada As E_Atiende
        Get
            Return _c_seleccionada
        End Get
        Set(value As E_Atiende)
            _c_seleccionada = value
        End Set
    End Property
    Private Sub frmCargarTarjetasP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblAcciones.Enabled = False 'por defecto dejo las acciones desactivadas, para que se habiliten el medico tiene que seleccionar alguna de las tarjetas
        RefrescarTarjetas()
    End Sub

    Sub RefrescarTarjetas()
        tblTarjetas.Controls.Clear()
        tblTarjetas.RowStyles.Clear()
        tblTarjetas.RowCount = 1
        If ListaConsultas.Count > 0 Then
            For Each consulta As E_Atiende In ListaConsultas
                If Not consulta Is ListaConsultas.Last() Then
                    tblTarjetas.RowCount += 1
                End If
                Dim tarjeta = New TarjetaPaciente With {.MiConsulta = consulta}
                tblTarjetas.Controls.Add(tarjeta)
                tarjeta.Anchor += AnchorStyles.Bottom
                tarjeta.Anchor += AnchorStyles.Right
                addHandlers(tarjeta)
            Next
        End If
        tarjetasResponsive()

    End Sub

    Sub tarjetasResponsive()
        Dim filas As Integer = tblTarjetas.RowCount
        Dim height_prom As Integer = 100 / filas

        For i = 0 To filas - 1 'ajustar alto de las filas del tbl
            tblTarjetas.RowStyles.Add(New RowStyle(SizeType.Percent, height_prom))
        Next
    End Sub


    Sub addHandlers(tarjeta As TarjetaPaciente)
        AddHandler tarjeta.MouseDown, AddressOf SeleccionarTarjetaDeTBL
    End Sub

    Public Sub SeleccionarTarjetaDeTBL(sender As Object, e As MouseEventArgs)
        Refresh()
        Console.WriteLine(sender.Name)
        If sender.GetType() = GetType(TarjetaPaciente) Then
            Dim tj = DirectCast(sender, TarjetaPaciente)
            ConsultaSeleccionada = tj.MiConsulta
            Dim g As Graphics = tblTarjetas.CreateGraphics
            Dim r As Rectangle = tj.DisplayRectangle
            Dim rect As New Rectangle(tj.Location.X - 2, tj.Location.Y - 2, r.Width + 5, r.Height + 5)

            ControlPaint.DrawBorder(g, rect,
                                    Color.Red, 10, ButtonBorderStyle.Solid,
                                    Color.Red, 10, ButtonBorderStyle.Solid,
                                    Color.Red, 10, ButtonBorderStyle.Solid,
                                    Color.Red, 10, ButtonBorderStyle.Solid)
            tblAcciones.Enabled = True
        Else
            tblAcciones.Enabled = False
        End If
    End Sub

    Private Sub btnVerConsultasPrevias_Click(sender As Object, e As EventArgs) Handles btnVerConsultasPrevias.Click
        Dim frmDg As New frmDiagnosticos
        frmDg.CI_Paciente = ConsultaSeleccionada.Paciente.Cedula
        frmDg.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
End Class