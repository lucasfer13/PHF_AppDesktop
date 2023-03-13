<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenúGestióGuarderies
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MenúGestióGuarderies))
        lblMenuGestGuarderiesTitol = New Label()
        btnMenuGestGuarderiesAfegGuarderia = New Button()
        btnMenuGestGuarderiesEliminarGuarderia = New Button()
        btnMenuGestGuarderiesEnrere = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        btnMenuGestGuarderiesAfegGuarderia.Location = New Point(578, 129)
        btnMenuGestGuarderiesAfegGuarderia.Name = "btnMenuGestGuarderiesAfegGuarderia"
        btnMenuGestGuarderiesAfegGuarderia.Size = New Size(123, 51)
        btnMenuGestGuarderiesAfegGuarderia.TabIndex = 3
        btnMenuGestGuarderiesAfegGuarderia.Text = "Afegir Guarderia"
        btnMenuGestGuarderiesAfegGuarderia.UseVisualStyleBackColor = False
        ' 
        ' btnMenuGestGuarderiesEliminarGuarderia
        ' 
        btnMenuGestGuarderiesEliminarGuarderia.Anchor = AnchorStyles.Right
        btnMenuGestGuarderiesEliminarGuarderia.BackColor = Color.Aquamarine
        btnMenuGestGuarderiesEliminarGuarderia.FlatAppearance.BorderColor = Color.Aquamarine
        btnMenuGestGuarderiesEliminarGuarderia.Location = New Point(578, 211)
        btnMenuGestGuarderiesEliminarGuarderia.Name = "btnMenuGestGuarderiesEliminarGuarderia"
        btnMenuGestGuarderiesEliminarGuarderia.Size = New Size(123, 61)
        btnMenuGestGuarderiesEliminarGuarderia.TabIndex = 4
        btnMenuGestGuarderiesEliminarGuarderia.Text = "Eliminar Guarderia"
        btnMenuGestGuarderiesEliminarGuarderia.UseVisualStyleBackColor = False
        ' 
        ' btnMenuGestGuarderiesEnrere
        ' 
        btnMenuGestGuarderiesEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnMenuGestGuarderiesEnrere.BackColor = Color.LightSteelBlue
        btnMenuGestGuarderiesEnrere.BackgroundImageLayout = ImageLayout.Center
        btnMenuGestGuarderiesEnrere.Enabled = False
        btnMenuGestGuarderiesEnrere.FlatAppearance.BorderColor = Color.LightSteelBlue
        btnMenuGestGuarderiesEnrere.FlatStyle = FlatStyle.Flat
        btnMenuGestGuarderiesEnrere.Font = New Font("Segoe UI", 3F, FontStyle.Regular, GraphicsUnit.Point)
        btnMenuGestGuarderiesEnrere.Image = CType(resources.GetObject("btnMenuGestGuarderiesEnrere.Image"), Image)
        btnMenuGestGuarderiesEnrere.Location = New Point(618, 345)
        btnMenuGestGuarderiesEnrere.Name = "btnMenuGestGuarderiesEnrere"
        btnMenuGestGuarderiesEnrere.Size = New Size(44, 35)
        btnMenuGestGuarderiesEnrere.TabIndex = 6
        btnMenuGestGuarderiesEnrere.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 72)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(478, 335)
        DataGridView1.TabIndex = 7
        ' 
        ' MenúGestióGuarderies
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(795, 432)
        Controls.Add(DataGridView1)
        Controls.Add(btnMenuGestGuarderiesEnrere)
        Controls.Add(btnMenuGestGuarderiesEliminarGuarderia)
        Controls.Add(btnMenuGestGuarderiesAfegGuarderia)
        Controls.Add(lblMenuGestGuarderiesTitol)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(813, 466)
        Name = "MenúGestióGuarderies"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pet Hotel Finder"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMenuGestGuarderiesTitol As Label
    Friend WithEvents btnMenuGestGuarderiesAfegGuarderia As Button
    Friend WithEvents btnMenuGestGuarderiesEliminarGuarderia As Button
    Protected WithEvents btnMenuGestGuarderiesEnrere As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
