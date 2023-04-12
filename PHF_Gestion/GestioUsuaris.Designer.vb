<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestioUsuaris
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GestioUsuaris))
        dgvGestioUsuarisLlista = New DataGridView()
        lblGestioUsuarisBuscarTitol = New Label()
        txtGestioUsuarisBuscar = New TextBox()
        btnGestioUsuarisResetBuscar = New Button()
        btnGestioUsuarisAfegir = New Button()
        btnGestioUsuarisEnrere = New Button()
        bdgGestioUsuarisVista = New BindingSource(components)
        CType(dgvGestioUsuarisLlista, ComponentModel.ISupportInitialize).BeginInit()
        CType(bdgGestioUsuarisVista, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvGestioUsuarisLlista
        ' 
        dgvGestioUsuarisLlista.AllowUserToAddRows = False
        dgvGestioUsuarisLlista.AllowUserToDeleteRows = False
        dgvGestioUsuarisLlista.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvGestioUsuarisLlista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGestioUsuarisLlista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGestioUsuarisLlista.Location = New Point(12, 12)
        dgvGestioUsuarisLlista.Name = "dgvGestioUsuarisLlista"
        dgvGestioUsuarisLlista.ReadOnly = True
        dgvGestioUsuarisLlista.RowHeadersWidth = 51
        dgvGestioUsuarisLlista.RowTemplate.Height = 29
        dgvGestioUsuarisLlista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGestioUsuarisLlista.Size = New Size(450, 436)
        dgvGestioUsuarisLlista.TabIndex = 0
        ' 
        ' lblGestioUsuarisBuscarTitol
        ' 
        lblGestioUsuarisBuscarTitol.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblGestioUsuarisBuscarTitol.AutoSize = True
        lblGestioUsuarisBuscarTitol.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioUsuarisBuscarTitol.Location = New Point(553, 12)
        lblGestioUsuarisBuscarTitol.Name = "lblGestioUsuarisBuscarTitol"
        lblGestioUsuarisBuscarTitol.Size = New Size(125, 28)
        lblGestioUsuarisBuscarTitol.TabIndex = 1
        lblGestioUsuarisBuscarTitol.Text = "Buscar usuari"' 
        ' txtGestioUsuarisBuscar
        ' 
        txtGestioUsuarisBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtGestioUsuarisBuscar.Location = New Point(498, 52)
        txtGestioUsuarisBuscar.Name = "txtGestioUsuarisBuscar"
        txtGestioUsuarisBuscar.Size = New Size(180, 27)
        txtGestioUsuarisBuscar.TabIndex = 2
        ' 
        ' btnGestioUsuarisResetBuscar
        ' 
        btnGestioUsuarisResetBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGestioUsuarisResetBuscar.BackColor = Color.Aquamarine
        btnGestioUsuarisResetBuscar.Location = New Point(684, 50)
        btnGestioUsuarisResetBuscar.Name = "btnGestioUsuarisResetBuscar"
        btnGestioUsuarisResetBuscar.Size = New Size(67, 29)
        btnGestioUsuarisResetBuscar.TabIndex = 3
        btnGestioUsuarisResetBuscar.Text = "Reset"
        btnGestioUsuarisResetBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnGestioUsuarisAfegir
        ' 
        btnGestioUsuarisAfegir.Anchor = AnchorStyles.Right
        btnGestioUsuarisAfegir.BackColor = Color.Aquamarine
        btnGestioUsuarisAfegir.Location = New Point(543, 209)
        btnGestioUsuarisAfegir.Name = "btnGestioUsuarisAfegir"
        btnGestioUsuarisAfegir.Size = New Size(135, 61)
        btnGestioUsuarisAfegir.TabIndex = 4
        btnGestioUsuarisAfegir.Text = "Afegir usuari"
        btnGestioUsuarisAfegir.UseVisualStyleBackColor = False
        ' 
        ' btnGestioUsuarisEnrere
        ' 
        btnGestioUsuarisEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGestioUsuarisEnrere.BackColor = Color.Aquamarine
        btnGestioUsuarisEnrere.Location = New Point(543, 387)
        btnGestioUsuarisEnrere.Name = "btnGestioUsuarisEnrere"
        btnGestioUsuarisEnrere.Size = New Size(135, 61)
        btnGestioUsuarisEnrere.TabIndex = 5
        btnGestioUsuarisEnrere.Text = "Enrere"
        btnGestioUsuarisEnrere.UseVisualStyleBackColor = False
        ' 
        ' GestioUsuaris
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(773, 460)
        Controls.Add(btnGestioUsuarisEnrere)
        Controls.Add(btnGestioUsuarisAfegir)
        Controls.Add(btnGestioUsuarisResetBuscar)
        Controls.Add(txtGestioUsuarisBuscar)
        Controls.Add(lblGestioUsuarisBuscarTitol)
        Controls.Add(dgvGestioUsuarisLlista)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(791, 507)
        Name = "GestioUsuaris"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Gestio usuaris"
        WindowState = FormWindowState.Maximized
        CType(dgvGestioUsuarisLlista, ComponentModel.ISupportInitialize).EndInit()
        CType(bdgGestioUsuarisVista, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvGestioUsuarisLlista As DataGridView
    Friend WithEvents lblGestioUsuarisBuscarTitol As Label
    Friend WithEvents txtGestioUsuarisBuscar As TextBox
    Friend WithEvents btnGestioUsuarisResetBuscar As Button
    Friend WithEvents btnGestioUsuarisAfegir As Button
    Friend WithEvents btnGestioUsuarisEnrere As Button
    Friend WithEvents bdgGestioUsuarisVista As BindingSource
End Class
