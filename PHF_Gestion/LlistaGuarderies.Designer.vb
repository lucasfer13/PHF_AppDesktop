<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LlistaGuarderies
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LlistaGuarderies))
        dgvLlistaGuarderiesLlista = New DataGridView()
        lblLlistatGuarderiesTitol = New Label()
        lblLlistatGuarderiesBuscar = New Label()
        txtLlistaGuarderiesBuscar = New TextBox()
        btnLlistaGuarderiesBack = New Button()
        btnLlistaGuarderiesReset = New Button()
        bgdLlistatGuarderieslVista = New BindingSource(components)
        CType(dgvLlistaGuarderiesLlista, ComponentModel.ISupportInitialize).BeginInit()
        CType(bgdLlistatGuarderieslVista, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLlistaGuarderiesLlista
        ' 
        dgvLlistaGuarderiesLlista.AllowUserToAddRows = False
        dgvLlistaGuarderiesLlista.AllowUserToDeleteRows = False
        dgvLlistaGuarderiesLlista.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLlistaGuarderiesLlista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLlistaGuarderiesLlista.Location = New Point(12, 107)
        dgvLlistaGuarderiesLlista.MultiSelect = False
        dgvLlistaGuarderiesLlista.Name = "dgvLlistaGuarderiesLlista"
        dgvLlistaGuarderiesLlista.ReadOnly = True
        dgvLlistaGuarderiesLlista.RowHeadersWidth = 51
        dgvLlistaGuarderiesLlista.RowTemplate.Height = 29
        dgvLlistaGuarderiesLlista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLlistaGuarderiesLlista.Size = New Size(776, 283)
        dgvLlistaGuarderiesLlista.TabIndex = 0
        ' 
        ' lblLlistatGuarderiesTitol
        ' 
        lblLlistatGuarderiesTitol.Anchor = AnchorStyles.Top
        lblLlistatGuarderiesTitol.AutoSize = True
        lblLlistatGuarderiesTitol.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLlistatGuarderiesTitol.Location = New Point(236, 9)
        lblLlistatGuarderiesTitol.Name = "lblLlistatGuarderiesTitol"
        lblLlistatGuarderiesTitol.Size = New Size(328, 38)
        lblLlistatGuarderiesTitol.TabIndex = 1
        lblLlistatGuarderiesTitol.Text = "Selecciona una guarderia"' 
        ' lblLlistatGuarderiesBuscar
        ' 
        lblLlistatGuarderiesBuscar.AutoSize = True
        lblLlistatGuarderiesBuscar.Location = New Point(12, 71)
        lblLlistatGuarderiesBuscar.Name = "lblLlistatGuarderiesBuscar"
        lblLlistatGuarderiesBuscar.Size = New Size(55, 20)
        lblLlistatGuarderiesBuscar.TabIndex = 2
        lblLlistatGuarderiesBuscar.Text = "Buscar:"' 
        ' txtLlistaGuarderiesBuscar
        ' 
        txtLlistaGuarderiesBuscar.Location = New Point(82, 68)
        txtLlistaGuarderiesBuscar.Name = "txtLlistaGuarderiesBuscar"
        txtLlistaGuarderiesBuscar.Size = New Size(163, 27)
        txtLlistaGuarderiesBuscar.TabIndex = 3
        ' 
        ' btnLlistaGuarderiesBack
        ' 
        btnLlistaGuarderiesBack.Anchor = AnchorStyles.Bottom
        btnLlistaGuarderiesBack.BackColor = Color.Aquamarine
        btnLlistaGuarderiesBack.Location = New Point(334, 412)
        btnLlistaGuarderiesBack.Name = "btnLlistaGuarderiesBack"
        btnLlistaGuarderiesBack.Size = New Size(132, 55)
        btnLlistaGuarderiesBack.TabIndex = 4
        btnLlistaGuarderiesBack.Text = "Enrere"
        btnLlistaGuarderiesBack.UseVisualStyleBackColor = False
        ' 
        ' btnLlistaGuarderiesReset
        ' 
        btnLlistaGuarderiesReset.BackColor = Color.Aquamarine
        btnLlistaGuarderiesReset.Location = New Point(251, 67)
        btnLlistaGuarderiesReset.Name = "btnLlistaGuarderiesReset"
        btnLlistaGuarderiesReset.Size = New Size(77, 28)
        btnLlistaGuarderiesReset.TabIndex = 5
        btnLlistaGuarderiesReset.Text = "Reset"
        btnLlistaGuarderiesReset.UseVisualStyleBackColor = False
        ' 
        ' LlistaGuarderies
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(801, 490)
        Controls.Add(btnLlistaGuarderiesReset)
        Controls.Add(btnLlistaGuarderiesBack)
        Controls.Add(txtLlistaGuarderiesBuscar)
        Controls.Add(lblLlistatGuarderiesBuscar)
        Controls.Add(lblLlistatGuarderiesTitol)
        Controls.Add(dgvLlistaGuarderiesLlista)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LlistaGuarderies"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LlistaGuarderies"
        CType(dgvLlistaGuarderiesLlista, ComponentModel.ISupportInitialize).EndInit()
        CType(bgdLlistatGuarderieslVista, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvLlistaGuarderiesLlista As DataGridView
    Friend WithEvents lblLlistatGuarderiesTitol As Label
    Friend WithEvents lblLlistatGuarderiesBuscar As Label
    Friend WithEvents txtLlistaGuarderiesBuscar As TextBox
    Friend WithEvents btnLlistaGuarderiesBack As Button
    Friend WithEvents btnLlistaGuarderiesReset As Button
    Friend WithEvents bgdLlistatGuarderieslVista As BindingSource
End Class
