<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LlistatPaisos
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LlistatPaisos))
        btnLlistaGuarderiesReset = New Button()
        btnLlistaGuarderiesBack = New Button()
        txtLlistaGuarderiesBuscar = New TextBox()
        lblLlistatPaisosTitol = New Label()
        dgvLlistaGuarderiesLlista = New DataGridView()
        Label1 = New Label()
        bgsLlistatPaisosVista = New BindingSource(components)
        CType(dgvLlistaGuarderiesLlista, ComponentModel.ISupportInitialize).BeginInit()
        CType(bgsLlistatPaisosVista, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLlistaGuarderiesReset
        ' 
        btnLlistaGuarderiesReset.BackColor = Color.Aquamarine
        btnLlistaGuarderiesReset.Location = New Point(262, 87)
        btnLlistaGuarderiesReset.Name = "btnLlistaGuarderiesReset"
        btnLlistaGuarderiesReset.Size = New Size(77, 28)
        btnLlistaGuarderiesReset.TabIndex = 2
        btnLlistaGuarderiesReset.Text = "Reset"
        btnLlistaGuarderiesReset.UseVisualStyleBackColor = False
        ' 
        ' btnLlistaGuarderiesBack
        ' 
        btnLlistaGuarderiesBack.Anchor = AnchorStyles.Bottom
        btnLlistaGuarderiesBack.BackColor = Color.Aquamarine
        btnLlistaGuarderiesBack.Location = New Point(356, 440)
        btnLlistaGuarderiesBack.Name = "btnLlistaGuarderiesBack"
        btnLlistaGuarderiesBack.Size = New Size(132, 55)
        btnLlistaGuarderiesBack.TabIndex = 3
        btnLlistaGuarderiesBack.Text = "Enrere"
        btnLlistaGuarderiesBack.UseVisualStyleBackColor = False
        ' 
        ' txtLlistaGuarderiesBuscar
        ' 
        txtLlistaGuarderiesBuscar.Location = New Point(93, 88)
        txtLlistaGuarderiesBuscar.Name = "txtLlistaGuarderiesBuscar"
        txtLlistaGuarderiesBuscar.Size = New Size(163, 27)
        txtLlistaGuarderiesBuscar.TabIndex = 1
        ' 
        ' lblLlistatPaisosTitol
        ' 
        lblLlistatPaisosTitol.Anchor = AnchorStyles.Top
        lblLlistatPaisosTitol.AutoSize = True
        lblLlistatPaisosTitol.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLlistatPaisosTitol.Location = New Point(300, 20)
        lblLlistatPaisosTitol.Name = "lblLlistatPaisosTitol"
        lblLlistatPaisosTitol.Size = New Size(245, 38)
        lblLlistatPaisosTitol.TabIndex = 7
        lblLlistatPaisosTitol.Text = "Selecciona un pais"' 
        ' dgvLlistaGuarderiesLlista
        ' 
        dgvLlistaGuarderiesLlista.AllowUserToAddRows = False
        dgvLlistaGuarderiesLlista.AllowUserToDeleteRows = False
        dgvLlistaGuarderiesLlista.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLlistaGuarderiesLlista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLlistaGuarderiesLlista.Location = New Point(12, 125)
        dgvLlistaGuarderiesLlista.MultiSelect = False
        dgvLlistaGuarderiesLlista.Name = "dgvLlistaGuarderiesLlista"
        dgvLlistaGuarderiesLlista.ReadOnly = True
        dgvLlistaGuarderiesLlista.RowHeadersWidth = 51
        dgvLlistaGuarderiesLlista.RowTemplate.Height = 29
        dgvLlistaGuarderiesLlista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLlistaGuarderiesLlista.Size = New Size(820, 298)
        dgvLlistaGuarderiesLlista.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 11
        Label1.Text = "Buscar:"' 
        ' LlistatPaisos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(844, 496)
        Controls.Add(Label1)
        Controls.Add(btnLlistaGuarderiesReset)
        Controls.Add(btnLlistaGuarderiesBack)
        Controls.Add(txtLlistaGuarderiesBuscar)
        Controls.Add(lblLlistatPaisosTitol)
        Controls.Add(dgvLlistaGuarderiesLlista)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(862, 543)
        Name = "LlistatPaisos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Llistat Paisos"
        CType(dgvLlistaGuarderiesLlista, ComponentModel.ISupportInitialize).EndInit()
        CType(bgsLlistatPaisosVista, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLlistaGuarderiesReset As Button
    Friend WithEvents btnLlistaGuarderiesBack As Button
    Friend WithEvents txtLlistaGuarderiesBuscar As TextBox
    Friend WithEvents lblLlistatPaisosTitol As Label
    Friend WithEvents dgvLlistaGuarderiesLlista As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents bgsLlistatPaisosVista As BindingSource
End Class
