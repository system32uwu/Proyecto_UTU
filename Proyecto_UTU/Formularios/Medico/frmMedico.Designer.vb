﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMedico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnamnesisMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdentificacionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrevistaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenericoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiebreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DolorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulariosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFormularioMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedorFormularios = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionMenuItem, Me.AnamnesisMenuItem, Me.FormulariosMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionMenuItem
        '
        Me.GestionMenuItem.Name = "GestionMenuItem"
        Me.GestionMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.GestionMenuItem.Text = "Gestión"
        '
        'AnamnesisMenuItem
        '
        Me.AnamnesisMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdentificacionMenuItem, Me.EntrevistaMenuItem})
        Me.AnamnesisMenuItem.Name = "AnamnesisMenuItem"
        Me.AnamnesisMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.AnamnesisMenuItem.Text = "Anamnésis"
        '
        'IdentificacionMenuItem
        '
        Me.IdentificacionMenuItem.Name = "IdentificacionMenuItem"
        Me.IdentificacionMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.IdentificacionMenuItem.Text = "Identificación"
        '
        'EntrevistaMenuItem
        '
        Me.EntrevistaMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenericoToolStripMenuItem, Me.FiebreToolStripMenuItem, Me.DolorToolStripMenuItem, Me.OtroToolStripMenuItem})
        Me.EntrevistaMenuItem.Name = "EntrevistaMenuItem"
        Me.EntrevistaMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EntrevistaMenuItem.Text = "Entrevista"
        '
        'GenericoToolStripMenuItem
        '
        Me.GenericoToolStripMenuItem.Name = "GenericoToolStripMenuItem"
        Me.GenericoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.GenericoToolStripMenuItem.Text = "Genérico"
        '
        'FiebreToolStripMenuItem
        '
        Me.FiebreToolStripMenuItem.Name = "FiebreToolStripMenuItem"
        Me.FiebreToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FiebreToolStripMenuItem.Text = "Fiebre"
        '
        'DolorToolStripMenuItem
        '
        Me.DolorToolStripMenuItem.Name = "DolorToolStripMenuItem"
        Me.DolorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DolorToolStripMenuItem.Text = "Dolor"
        '
        'OtroToolStripMenuItem
        '
        Me.OtroToolStripMenuItem.Name = "OtroToolStripMenuItem"
        Me.OtroToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OtroToolStripMenuItem.Text = "Otro"
        '
        'FormulariosMenuItem
        '
        Me.FormulariosMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearFormularioMenuItem})
        Me.FormulariosMenuItem.Name = "FormulariosMenuItem"
        Me.FormulariosMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.FormulariosMenuItem.Text = "Formularios"
        '
        'CrearFormularioMenuItem
        '
        Me.CrearFormularioMenuItem.Name = "CrearFormularioMenuItem"
        Me.CrearFormularioMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.CrearFormularioMenuItem.Text = "Crear Formulario"
        '
        'pnlContenedorFormularios
        '
        Me.pnlContenedorFormularios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedorFormularios.AutoSize = True
        Me.pnlContenedorFormularios.Location = New System.Drawing.Point(0, 27)
        Me.pnlContenedorFormularios.Name = "pnlContenedorFormularios"
        Me.pnlContenedorFormularios.Size = New System.Drawing.Size(896, 555)
        Me.pnlContenedorFormularios.TabIndex = 1
        '
        'frmMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 583)
        Me.Controls.Add(Me.pnlContenedorFormularios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Médico - Hospital xxxx xxxx"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionMenuItem As ToolStripMenuItem
    Friend WithEvents AnamnesisMenuItem As ToolStripMenuItem
    Friend WithEvents pnlContenedorFormularios As Panel
    Friend WithEvents IdentificacionMenuItem As ToolStripMenuItem
    Friend WithEvents FormulariosMenuItem As ToolStripMenuItem
    Friend WithEvents CrearFormularioMenuItem As ToolStripMenuItem
    Friend WithEvents EntrevistaMenuItem As ToolStripMenuItem
    Friend WithEvents GenericoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiebreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DolorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtroToolStripMenuItem As ToolStripMenuItem
End Class
