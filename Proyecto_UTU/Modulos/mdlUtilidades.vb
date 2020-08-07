﻿Module mdlUtilidades

    Public Function ImportarFormulario() As List(Of Object)

        Dim abrirFormulario As New OpenFileDialog
        abrirFormulario.Filter = "XML|*.xml"
        abrirFormulario.Title = "Abrir Formulario"
        abrirFormulario.RestoreDirectory = True
        Dim archivo As New Xml.XmlDocument
        Dim path As String = ""

        If abrirFormulario.ShowDialog() = DialogResult.OK Then
            path = System.IO.Path.GetFullPath(abrirFormulario.FileName.ToString())
            archivo.Load(path)
        End If

        'Dim gestor As New GestorXML

        'Return gestor.generarInstancias(archivo)

    End Function

    Public Sub GuardarFormulario(lista_controles As List(Of Object))

        'Dim archivo As New Xml.XmlDocument
        'Dim gestor As New GestorXML

        'Dim xmlstring As String = gestor.guardarXML(lista_controles)
        'archivo.LoadXml(xmlstring)

        'Dim guardarFormulario As New SaveFileDialog
        'guardarFormulario.Filter = "XML|*.xml"
        'guardarFormulario.Title = "Guardar Formulario"
        'guardarFormulario.RestoreDirectory = True

        'If guardarFormulario.ShowDialog() = DialogResult.OK Then
        '    Dim path As String = System.IO.Path.GetFullPath(guardarFormulario.FileName.ToString())
        '    archivo.Save(path)
        'End If

    End Sub

    Public Function RemoverEspacios(list1 As String()) As String()

        If Not list1 Is Nothing Then
            For Each i In list1

                i.Trim()

            Next

            Return list1

        End If
        Return list1
    End Function

    Public Sub LimpiarControles(contenedor As Control)
        For Each control As Control In contenedor.Controls

            Select Case control.GetType().ToString().Replace("System.Windows.Forms.", "")

                Case "TextBox"
                    Dim txt = DirectCast(control, TextBox)
                    txt.Text = String.Empty
                Case "ComboBox"
                    Dim cbox = DirectCast(control, ComboBox)

                    If cbox.DropDownStyle = ComboBoxStyle.DropDown Then
                        control.ResetText()
                    Else
                        cbox.SelectedIndex = 0
                    End If
                Case "CheckBox"
                    Dim chk = DirectCast(control, CheckBox)
                    chk.Checked = CheckState.Unchecked

                Case "DataGridView"
                    Dim dgw = DirectCast(control, DataGridView)
                    dgw.Rows.Clear()
            End Select
        Next
    End Sub

End Module