<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LlistatMunicipi
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LlistatMunicipi))
        bdgLlistatMunicipiVista = New BindingSource(components)
        dgvLlistatMunicipisLlista = New DataGridView()
        btnLlistaMunicipisEnrere = New Button()
        lblLlistatMunicipisTitol = New Label()
        txtLlistatMunicipisBuscar = New TextBox()
        lblLlistatMunicipisBuscar = New Label()
        Button1 = New Button()
        CType(bdgLlistatMunicipiVista, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvLlistatMunicipisLlista, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLlistatMunicipisLlista
        ' 
        dgvLlistatMunicipisLlista.AllowUserToAddRows = False
        dgvLlistatMunicipisLlista.AllowUserToDeleteRows = False
        dgvLlistatMunicipisLlista.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLlistatMunicipisLlista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLlistatMunicipisLlista.Location = New Point(12, 133)
        dgvLlistatMunicipisLlista.MultiSelect = False
        dgvLlistatMunicipisLlista.Name = "dgvLlistatMunicipisLlista"
        dgvLlistatMunicipisLlista.ReadOnly = True
        dgvLlistatMunicipisLlista.RowHeadersWidth = 51
        dgvLlistatMunicipisLlista.RowTemplate.Height = 29
        dgvLlistatMunicipisLlista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLlistatMunicipisLlista.Size = New Size(857, 313)
        dgvLlistatMunicipisLlista.TabIndex = 0
        ' 
        ' btnLlistaMunicipisEnrere
        ' 
        btnLlistaMunicipisEnrere.Anchor = AnchorStyles.Bottom
        btnLlistaMunicipisEnrere.BackColor = Color.Aquamarine
        btnLlistaMunicipisEnrere.Location = New Point(366, 476)
        btnLlistaMunicipisEnrere.Name = "btnLlistaMunicipisEnrere"
        btnLlistaMunicipisEnrere.Size = New Size(149, 60)
        btnLlistaMunicipisEnrere.TabIndex = 3
        btnLlistaMunicipisEnrere.Text = "Enrere"
        btnLlistaMunicipisEnrere.UseVisualStyleBackColor = False
        ' 
        ' lblLlistatMunicipisTitol
        ' 
        lblLlistatMunicipisTitol.Anchor = AnchorStyles.Top
        lblLlistatMunicipisTitol.AutoSize = True
        lblLlistatMunicipisTitol.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLlistatMunicipisTitol.Location = New Point(289, 20)
        lblLlistatMunicipisTitol.Name = "lblLlistatMunicipisTitol"
        lblLlistatMunicipisTitol.Size = New Size(302, 38)
        lblLlistatMunicipisTitol.TabIndex = 8
        lblLlistatMunicipisTitol.Text = "Selecciona un municipi"' 
        ' txtLlistatMunicipisBuscar
        ' 
        txtLlistatMunicipisBuscar.Location = New Point(77, 86)
        txtLlistatMunicipisBuscar.Name = "txtLlistatMunicipisBuscar"
        txtLlistatMunicipisBuscar.Size = New Size(193, 27)
        txtLlistatMunicipisBuscar.TabIndex = 1
        ' 
        ' lblLlistatMunicipisBuscar
        ' 
        lblLlistatMunicipisBuscar.AutoSize = True
        lblLlistatMunicipisBuscar.Location = New Point(12, 89)
        lblLlistatMunicipisBuscar.Name = "lblLlistatMunicipisBuscar"
        lblLlistatMunicipisBuscar.Size = New Size(59, 20)
        lblLlistatMunicipisBuscar.TabIndex = 10
        lblLlistatMunicipisBuscar.Text = "Buscar: "' 
        ' Button1
        ' 
        Button1.BackColor = Color.Aquamarine
        Button1.Location = New Point(289, 86)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 27)
        Button1.TabIndex = 2
        Button1.Text = "Reset"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LlistatMunicipi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(881, 548)
        Controls.Add(Button1)
        Controls.Add(lblLlistatMunicipisBuscar)
        Controls.Add(txtLlistatMunicipisBuscar)
        Controls.Add(lblLlistatMunicipisTitol)
        Controls.Add(btnLlistaMunicipisEnrere)
        Controls.Add(dgvLlistatMunicipisLlista)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(899, 595)
        Name = "LlistatMunicipi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Llistat Municipis"
        CType(bdgLlistatMunicipiVista, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvLlistatMunicipisLlista, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bdgLlistatMunicipiVista As BindingSource
    Friend WithEvents dgvLlistatMunicipisLlista As DataGridView
    Friend WithEvents btnLlistaMunicipisEnrere As Button
    Friend WithEvents lblLlistatMunicipisTitol As Label
    Friend WithEvents txtLlistatMunicipisBuscar As TextBox
    Friend WithEvents lblLlistatMunicipisBuscar As Label
    Friend WithEvents Button1 As Button
End Class
