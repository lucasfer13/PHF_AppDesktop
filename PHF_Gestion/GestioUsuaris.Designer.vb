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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GestioUsuaris))
        DataGridView1 = New DataGridView()
        lblGestioUsuarisBuscarTitol = New Label()
        txtGestioUsuarisBuscar = New TextBox()
        btnGestioUsuarisResetBuscar = New Button()
        btnGestioUsuarisAfegir = New Button()
        btnGestioUsuarisEnrere = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(450, 436)
        DataGridView1.TabIndex = 0
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
        Controls.Add(DataGridView1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(791, 507)
        Name = "GestioUsuaris"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Gestio usuaris"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblGestioUsuarisBuscarTitol As Label
    Friend WithEvents txtGestioUsuarisBuscar As TextBox
    Friend WithEvents btnGestioUsuarisResetBuscar As Button
    Friend WithEvents btnGestioUsuarisAfegir As Button
    Friend WithEvents btnGestioUsuarisEnrere As Button
End Class
