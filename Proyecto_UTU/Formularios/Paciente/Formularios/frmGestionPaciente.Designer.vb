﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionPaciente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionPaciente))
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblDireccionTXT = New System.Windows.Forms.Label()
        Me.lblEscolaridad = New System.Windows.Forms.Label()
        Me.lblEscolaridadTXT = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblEstadoCivilTXT = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.lblOcupacionTXT = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblSexoTXT = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblEdadTXT = New System.Windows.Forms.Label()
        Me.lblAcompanante = New System.Windows.Forms.Label()
        Me.lblAcompananteTXT = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblTelefonoTXT = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblApellidosTXT = New System.Windows.Forms.Label()
        Me.lblNombresTXT = New System.Windows.Forms.Label()
        Me.pBoxFotoPaciente = New System.Windows.Forms.PictureBox()
        Me.lblCedulaTXT = New System.Windows.Forms.Label()
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(420, 314)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(86, 20)
        Me.lblDireccion.TabIndex = 75
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblDireccionTXT
        '
        Me.lblDireccionTXT.AutoSize = True
        Me.lblDireccionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTXT.Location = New System.Drawing.Point(551, 314)
        Me.lblDireccionTXT.Name = "lblDireccionTXT"
        Me.lblDireccionTXT.Size = New System.Drawing.Size(81, 20)
        Me.lblDireccionTXT.TabIndex = 74
        Me.lblDireccionTXT.Text = "Dirección"
        '
        'lblEscolaridad
        '
        Me.lblEscolaridad.AutoSize = True
        Me.lblEscolaridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscolaridad.Location = New System.Drawing.Point(420, 282)
        Me.lblEscolaridad.Name = "lblEscolaridad"
        Me.lblEscolaridad.Size = New System.Drawing.Size(102, 20)
        Me.lblEscolaridad.TabIndex = 73
        Me.lblEscolaridad.Text = "Escolaridad:"
        '
        'lblEscolaridadTXT
        '
        Me.lblEscolaridadTXT.AutoSize = True
        Me.lblEscolaridadTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscolaridadTXT.Location = New System.Drawing.Point(551, 282)
        Me.lblEscolaridadTXT.Name = "lblEscolaridadTXT"
        Me.lblEscolaridadTXT.Size = New System.Drawing.Size(97, 20)
        Me.lblEscolaridadTXT.TabIndex = 72
        Me.lblEscolaridadTXT.Text = "Escolaridad"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(420, 248)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(100, 20)
        Me.lblEstadoCivil.TabIndex = 71
        Me.lblEstadoCivil.Text = "Estado civíl:"
        '
        'lblEstadoCivilTXT
        '
        Me.lblEstadoCivilTXT.AutoSize = True
        Me.lblEstadoCivilTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivilTXT.Location = New System.Drawing.Point(551, 248)
        Me.lblEstadoCivilTXT.Name = "lblEstadoCivilTXT"
        Me.lblEstadoCivilTXT.Size = New System.Drawing.Size(95, 20)
        Me.lblEstadoCivilTXT.TabIndex = 70
        Me.lblEstadoCivilTXT.Text = "Estado civil"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(420, 216)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(94, 20)
        Me.lblOcupacion.TabIndex = 69
        Me.lblOcupacion.Text = "Ocupación:"
        '
        'lblOcupacionTXT
        '
        Me.lblOcupacionTXT.AutoSize = True
        Me.lblOcupacionTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacionTXT.Location = New System.Drawing.Point(551, 216)
        Me.lblOcupacionTXT.Name = "lblOcupacionTXT"
        Me.lblOcupacionTXT.Size = New System.Drawing.Size(89, 20)
        Me.lblOcupacionTXT.TabIndex = 68
        Me.lblOcupacionTXT.Text = "Ocupación"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(419, 186)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(51, 20)
        Me.lblSexo.TabIndex = 67
        Me.lblSexo.Text = "Sexo:"
        '
        'lblSexoTXT
        '
        Me.lblSexoTXT.AutoSize = True
        Me.lblSexoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoTXT.Location = New System.Drawing.Point(551, 186)
        Me.lblSexoTXT.Name = "lblSexoTXT"
        Me.lblSexoTXT.Size = New System.Drawing.Size(46, 20)
        Me.lblSexoTXT.TabIndex = 66
        Me.lblSexoTXT.Text = "Sexo"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(419, 154)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(52, 20)
        Me.lblEdad.TabIndex = 65
        Me.lblEdad.Text = "Edad:"
        '
        'lblEdadTXT
        '
        Me.lblEdadTXT.AutoSize = True
        Me.lblEdadTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdadTXT.Location = New System.Drawing.Point(551, 154)
        Me.lblEdadTXT.Name = "lblEdadTXT"
        Me.lblEdadTXT.Size = New System.Drawing.Size(47, 20)
        Me.lblEdadTXT.TabIndex = 64
        Me.lblEdadTXT.Text = "Edad"
        '
        'lblAcompanante
        '
        Me.lblAcompanante.AutoSize = True
        Me.lblAcompanante.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcompanante.Location = New System.Drawing.Point(420, 379)
        Me.lblAcompanante.Name = "lblAcompanante"
        Me.lblAcompanante.Size = New System.Drawing.Size(116, 20)
        Me.lblAcompanante.TabIndex = 62
        Me.lblAcompanante.Text = "Acompañante:"
        '
        'lblAcompananteTXT
        '
        Me.lblAcompananteTXT.AutoSize = True
        Me.lblAcompananteTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcompananteTXT.Location = New System.Drawing.Point(551, 379)
        Me.lblAcompananteTXT.Name = "lblAcompananteTXT"
        Me.lblAcompananteTXT.Size = New System.Drawing.Size(181, 20)
        Me.lblAcompananteTXT.TabIndex = 61
        Me.lblAcompananteTXT.Text = "NOM ACOMPAÑANTE"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(420, 347)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(78, 20)
        Me.lblTelefono.TabIndex = 60
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblTelefonoTXT
        '
        Me.lblTelefonoTXT.AutoSize = True
        Me.lblTelefonoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoTXT.Location = New System.Drawing.Point(551, 347)
        Me.lblTelefonoTXT.Name = "lblTelefonoTXT"
        Me.lblTelefonoTXT.Size = New System.Drawing.Size(108, 20)
        Me.lblTelefonoTXT.TabIndex = 59
        Me.lblTelefonoTXT.Text = "TELEFONO1"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(420, 51)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(66, 20)
        Me.lblCedula.TabIndex = 58
        Me.lblCedula.Text = "Cédula:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(420, 120)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(73, 20)
        Me.lblApellido.TabIndex = 57
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(420, 86)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(73, 20)
        Me.lblNombres.TabIndex = 56
        Me.lblNombres.Text = "Nombre:"
        '
        'lblApellidosTXT
        '
        Me.lblApellidosTXT.AutoSize = True
        Me.lblApellidosTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosTXT.Location = New System.Drawing.Point(551, 120)
        Me.lblApellidosTXT.Name = "lblApellidosTXT"
        Me.lblApellidosTXT.Size = New System.Drawing.Size(208, 20)
        Me.lblApellidosTXT.TabIndex = 55
        Me.lblApellidosTXT.Text = "APELLIDO 1 APELLIDO 2"
        '
        'lblNombresTXT
        '
        Me.lblNombresTXT.AutoSize = True
        Me.lblNombresTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombresTXT.Location = New System.Drawing.Point(551, 86)
        Me.lblNombresTXT.Name = "lblNombresTXT"
        Me.lblNombresTXT.Size = New System.Drawing.Size(190, 20)
        Me.lblNombresTXT.TabIndex = 54
        Me.lblNombresTXT.Text = "NOMBRE 1 NOMBRE 2"
        '
        'pBoxFotoPaciente
        '
        Me.pBoxFotoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxFotoPaciente.Image = CType(resources.GetObject("pBoxFotoPaciente.Image"), System.Drawing.Image)
        Me.pBoxFotoPaciente.Location = New System.Drawing.Point(41, 51)
        Me.pBoxFotoPaciente.Name = "pBoxFotoPaciente"
        Me.pBoxFotoPaciente.Size = New System.Drawing.Size(359, 348)
        Me.pBoxFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxFotoPaciente.TabIndex = 53
        Me.pBoxFotoPaciente.TabStop = False
        '
        'lblCedulaTXT
        '
        Me.lblCedulaTXT.AutoSize = True
        Me.lblCedulaTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaTXT.Location = New System.Drawing.Point(551, 51)
        Me.lblCedulaTXT.Name = "lblCedulaTXT"
        Me.lblCedulaTXT.Size = New System.Drawing.Size(61, 20)
        Me.lblCedulaTXT.TabIndex = 76
        Me.lblCedulaTXT.Text = "Cédula"
        '
        'frmGestionPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 551)
        Me.Controls.Add(Me.lblCedulaTXT)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblDireccionTXT)
        Me.Controls.Add(Me.lblEscolaridad)
        Me.Controls.Add(Me.lblEscolaridadTXT)
        Me.Controls.Add(Me.lblEstadoCivil)
        Me.Controls.Add(Me.lblEstadoCivilTXT)
        Me.Controls.Add(Me.lblOcupacion)
        Me.Controls.Add(Me.lblOcupacionTXT)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblSexoTXT)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblEdadTXT)
        Me.Controls.Add(Me.lblAcompanante)
        Me.Controls.Add(Me.lblAcompananteTXT)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblTelefonoTXT)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.lblApellidosTXT)
        Me.Controls.Add(Me.lblNombresTXT)
        Me.Controls.Add(Me.pBoxFotoPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGestionPaciente"
        Me.Text = "frmGestionPaciente"
        CType(Me.pBoxFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblDireccionTXT As Label
    Friend WithEvents lblEscolaridad As Label
    Friend WithEvents lblEscolaridadTXT As Label
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblEstadoCivilTXT As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents lblOcupacionTXT As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblSexoTXT As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblEdadTXT As Label
    Friend WithEvents lblAcompanante As Label
    Friend WithEvents lblAcompananteTXT As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblTelefonoTXT As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblApellidosTXT As Label
    Friend WithEvents lblNombresTXT As Label
    Friend WithEvents pBoxFotoPaciente As PictureBox
    Friend WithEvents lblCedulaTXT As Label
End Class