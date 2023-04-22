<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LlistatServeis
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LlistatServeis))
        lblLlistaServeisBuscar = New Label()
        btnLlistaServeisReset = New Button()
        btnLlistaServeisBack = New Button()
        txtLlistaServeisBuscar = New TextBox()
        lblLlistatServeisTitol = New Label()
        dgvLlistaServeisLlista = New DataGridView()
        bdgLlistatServeisVista = New BindingSource(components)
        CType(dgvLlistaServeisLlista, ComponentModel.ISupportInitialize).BeginInit()
        CType(bdgLlistatServeisVista, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblLlistaServeisBuscar
        ' 
        lblLlistaServeisBuscar.AutoSize = True
        lblLlistaServeisBuscar.Location = New Point(11, 70)
        lblLlistaServeisBuscar.Name = "lblLlistaServeisBuscar"
        lblLlistaServeisBuscar.Size = New Size(55, 20)
        lblLlistaServeisBuscar.TabIndex = 17
        lblLlistaServeisBuscar.Text = "Buscar:"' 
        ' btnLlistaServeisReset
        ' 
        btnLlistaServeisReset.BackColor = Color.Aquamarine
        btnLlistaServeisReset.Location = New Point(261, 66)
        btnLlistaServeisReset.Name = "btnLlistaServeisReset"
        btnLlistaServeisReset.Size = New Size(77, 28)
        btnLlistaServeisReset.TabIndex = 13
        btnLlistaServeisReset.Text = "Reset"
        btnLlistaServeisReset.UseVisualStyleBackColor = False
        ' 
        ' btnLlistaServeisBack
        ' 
        btnLlistaServeisBack.Anchor = AnchorStyles.Bottom
        btnLlistaServeisBack.BackColor = Color.Aquamarine
        btnLlistaServeisBack.Location = New Point(371, 455)
        btnLlistaServeisBack.Name = "btnLlistaServeisBack"
        btnLlistaServeisBack.Size = New Size(132, 55)
        btnLlistaServeisBack.TabIndex = 14
        btnLlistaServeisBack.Text = "Enrere"
        btnLlistaServeisBack.UseVisualStyleBackColor = False
        ' 
        ' txtLlistaServeisBuscar
        ' 
        txtLlistaServeisBuscar.Location = New Point(92, 67)
        txtLlistaServeisBuscar.Name = "txtLlistaServeisBuscar"
        txtLlistaServeisBuscar.Size = New Size(163, 27)
        txtLlistaServeisBuscar.TabIndex = 12
        ' 
        ' lblLlistatServeisTitol
        ' 
        lblLlistatServeisTitol.Anchor = AnchorStyles.Top
        lblLlistatServeisTitol.AutoSize = True
        lblLlistatServeisTitol.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLlistatServeisTitol.Location = New Point(303, 9)
        lblLlistatServeisTitol.Name = "lblLlistatServeisTitol"
        lblLlistatServeisTitol.Size = New Size(268, 38)
        lblLlistatServeisTitol.TabIndex = 16
        lblLlistatServeisTitol.Text = "Selecciona un servei"' 
        ' dgvLlistaServeisLlista
        ' 
        dgvLlistaServeisLlista.AllowUserToAddRows = False
        dgvLlistaServeisLlista.AllowUserToDeleteRows = False
        dgvLlistaServeisLlista.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLlistaServeisLlista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLlistaServeisLlista.Location = New Point(11, 107)
        dgvLlistaServeisLlista.MultiSelect = False
        dgvLlistaServeisLlista.Name = "dgvLlistaServeisLlista"
        dgvLlistaServeisLlista.ReadOnly = True
        dgvLlistaServeisLlista.RowHeadersWidth = 51
        dgvLlistaServeisLlista.RowTemplate.Height = 29
        dgvLlistaServeisLlista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLlistaServeisLlista.Size = New Size(851, 331)
        dgvLlistaServeisLlista.TabIndex = 15
        ' 
        ' LlistatServeis
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(874, 522)
        Controls.Add(lblLlistaServeisBuscar)
        Controls.Add(btnLlistaServeisReset)
        Controls.Add(btnLlistaServeisBack)
        Controls.Add(txtLlistaServeisBuscar)
        Controls.Add(lblLlistatServeisTitol)
        Controls.Add(dgvLlistaServeisLlista)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(892, 569)
        Name = "LlistatServeis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Llistat Serveis"
        CType(dgvLlistaServeisLlista, ComponentModel.ISupportInitialize).EndInit()
        CType(bdgLlistatServeisVista, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLlistaServeisBuscar As Label
    Friend WithEvents btnLlistaServeisReset As Button
    Friend WithEvents btnLlistaServeisBack As Button
    Friend WithEvents txtLlistaServeisBuscar As TextBox
    Friend WithEvents lblLlistatServeisTitol As Label
    Friend WithEvents dgvLlistaServeisLlista As DataGridView
    Friend WithEvents bdgLlistatServeisVista As BindingSource
End Class
