﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGestioGuarderies
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MenuGestioGuarderies))
        lblMenuGestGuarderiesTitol = New Label()
        btnMenuGestGuarderiesAfegGuarderia = New Button()
        dgvMenuGuarderiesLlistat = New DataGridView()
        btnGestioGuarderiesEnrere = New Button()
        bdgGestioGuarderiesVista = New BindingSource(components)
        txtGestioGuarderiesBuscar = New TextBox()
        btnGestioGuarderiesReset = New Button()
        lblGestioGuarderiesBuscar = New Label()
        CType(dgvMenuGuarderiesLlistat, ComponentModel.ISupportInitialize).BeginInit()
        CType(bdgGestioGuarderiesVista, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMenuGestGuarderiesTitol
        ' 
        lblMenuGestGuarderiesTitol.AutoSize = True
        lblMenuGestGuarderiesTitol.Font = New Font("Sitka Small", 16.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblMenuGestGuarderiesTitol.Location = New Point(12, 9)
        lblMenuGestGuarderiesTitol.Name = "lblMenuGestGuarderiesTitol"
        lblMenuGestGuarderiesTitol.Size = New Size(330, 40)
        lblMenuGestGuarderiesTitol.TabIndex = 0
        lblMenuGestGuarderiesTitol.Text = "Gestió de Guarderies"' 
        ' btnMenuGestGuarderiesAfegGuarderia
        ' 
        btnMenuGestGuarderiesAfegGuarderia.Anchor = AnchorStyles.Right
        btnMenuGestGuarderiesAfegGuarderia.BackColor = Color.Aquamarine
        btnMenuGestGuarderiesAfegGuarderia.FlatAppearance.BorderColor = Color.Aquamarine
        btnMenuGestGuarderiesAfegGuarderia.Location = New Point(578, 156)
        btnMenuGestGuarderiesAfegGuarderia.Name = "btnMenuGestGuarderiesAfegGuarderia"
        btnMenuGestGuarderiesAfegGuarderia.Size = New Size(123, 51)
        btnMenuGestGuarderiesAfegGuarderia.TabIndex = 3
        btnMenuGestGuarderiesAfegGuarderia.Text = "Afegir Guarderia"
        btnMenuGestGuarderiesAfegGuarderia.UseVisualStyleBackColor = False
        ' 
        ' dgvMenuGuarderiesLlistat
        ' 
        dgvMenuGuarderiesLlistat.AllowUserToAddRows = False
        dgvMenuGuarderiesLlistat.AllowUserToDeleteRows = False
        dgvMenuGuarderiesLlistat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMenuGuarderiesLlistat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMenuGuarderiesLlistat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMenuGuarderiesLlistat.Location = New Point(12, 72)
        dgvMenuGuarderiesLlistat.MultiSelect = False
        dgvMenuGuarderiesLlistat.Name = "dgvMenuGuarderiesLlistat"
        dgvMenuGuarderiesLlistat.ReadOnly = True
        dgvMenuGuarderiesLlistat.RowHeadersWidth = 51
        dgvMenuGuarderiesLlistat.RowTemplate.Height = 29
        dgvMenuGuarderiesLlistat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMenuGuarderiesLlistat.Size = New Size(463, 323)
        dgvMenuGuarderiesLlistat.TabIndex = 7
        ' 
        ' btnGestioGuarderiesEnrere
        ' 
        btnGestioGuarderiesEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGestioGuarderiesEnrere.BackColor = Color.Aquamarine
        btnGestioGuarderiesEnrere.FlatAppearance.BorderColor = Color.Aquamarine
        btnGestioGuarderiesEnrere.Location = New Point(578, 333)
        btnGestioGuarderiesEnrere.Name = "btnGestioGuarderiesEnrere"
        btnGestioGuarderiesEnrere.Size = New Size(123, 61)
        btnGestioGuarderiesEnrere.TabIndex = 8
        btnGestioGuarderiesEnrere.Text = "Enrere"
        btnGestioGuarderiesEnrere.UseVisualStyleBackColor = False
        ' 
        ' txtGestioGuarderiesBuscar
        ' 
        txtGestioGuarderiesBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtGestioGuarderiesBuscar.Location = New Point(512, 72)
        txtGestioGuarderiesBuscar.Name = "txtGestioGuarderiesBuscar"
        txtGestioGuarderiesBuscar.Size = New Size(189, 27)
        txtGestioGuarderiesBuscar.TabIndex = 9
        ' 
        ' btnGestioGuarderiesReset
        ' 
        btnGestioGuarderiesReset.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGestioGuarderiesReset.BackColor = Color.Aquamarine
        btnGestioGuarderiesReset.FlatAppearance.BorderColor = Color.Aquamarine
        btnGestioGuarderiesReset.Location = New Point(713, 68)
        btnGestioGuarderiesReset.Name = "btnGestioGuarderiesReset"
        btnGestioGuarderiesReset.Size = New Size(70, 34)
        btnGestioGuarderiesReset.TabIndex = 10
        btnGestioGuarderiesReset.Text = "Reset"
        btnGestioGuarderiesReset.UseVisualStyleBackColor = False
        ' 
        ' lblGestioGuarderiesBuscar
        ' 
        lblGestioGuarderiesBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblGestioGuarderiesBuscar.AutoSize = True
        lblGestioGuarderiesBuscar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioGuarderiesBuscar.Location = New Point(553, 18)
        lblGestioGuarderiesBuscar.Name = "lblGestioGuarderiesBuscar"
        lblGestioGuarderiesBuscar.Size = New Size(157, 28)
        lblGestioGuarderiesBuscar.TabIndex = 11
        lblGestioGuarderiesBuscar.Text = "Buscar guarderia"' 
        ' MenuGestioGuarderies
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(795, 419)
        Controls.Add(lblGestioGuarderiesBuscar)
        Controls.Add(btnGestioGuarderiesReset)
        Controls.Add(txtGestioGuarderiesBuscar)
        Controls.Add(btnGestioGuarderiesEnrere)
        Controls.Add(dgvMenuGuarderiesLlistat)
        Controls.Add(btnMenuGestGuarderiesAfegGuarderia)
        Controls.Add(lblMenuGestGuarderiesTitol)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(813, 466)
        Name = "MenuGestioGuarderies"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pet Hotel Finder"
        WindowState = FormWindowState.Maximized
        CType(dgvMenuGuarderiesLlistat, ComponentModel.ISupportInitialize).EndInit()
        CType(bdgGestioGuarderiesVista, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMenuGestGuarderiesTitol As Label
    Friend WithEvents btnMenuGestGuarderiesAfegGuarderia As Button
    Friend WithEvents dgvMenuGuarderiesLlistat As DataGridView
    Friend WithEvents btnGestioGuarderiesEnrere As Button
    Friend WithEvents bdgGestioGuarderiesVista As BindingSource
    Friend WithEvents txtGestioGuarderiesBuscar As TextBox
    Friend WithEvents btnGestioGuarderiesReset As Button
    Friend WithEvents lblGestioGuarderiesBuscar As Label
End Class
