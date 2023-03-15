<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestioTipusAnimals
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GestioTipusAnimals))
        dgvTipusAnimalsLlistat = New DataGridView()
        lblTipusAnimalsTitol = New Label()
        txtTipusAnimalBuscar = New TextBox()
        btnTipusAnimalReset = New Button()
        btnTipusAnimalAfegir = New Button()
        btnTipusAnimalEnrere = New Button()
        CType(dgvTipusAnimalsLlistat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTipusAnimalsLlistat
        ' 
        dgvTipusAnimalsLlistat.AllowUserToAddRows = False
        dgvTipusAnimalsLlistat.AllowUserToDeleteRows = False
        dgvTipusAnimalsLlistat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTipusAnimalsLlistat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTipusAnimalsLlistat.Location = New Point(12, 12)
        dgvTipusAnimalsLlistat.Name = "dgvTipusAnimalsLlistat"
        dgvTipusAnimalsLlistat.ReadOnly = True
        dgvTipusAnimalsLlistat.RowHeadersWidth = 51
        dgvTipusAnimalsLlistat.RowTemplate.Height = 29
        dgvTipusAnimalsLlistat.Size = New Size(435, 426)
        dgvTipusAnimalsLlistat.TabIndex = 0
        ' 
        ' lblTipusAnimalsTitol
        ' 
        lblTipusAnimalsTitol.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTipusAnimalsTitol.AutoSize = True
        lblTipusAnimalsTitol.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblTipusAnimalsTitol.Location = New Point(540, 12)
        lblTipusAnimalsTitol.Name = "lblTipusAnimalsTitol"
        lblTipusAnimalsTitol.Size = New Size(176, 31)
        lblTipusAnimalsTitol.TabIndex = 1
        lblTipusAnimalsTitol.Text = "Tipus d'Animals"' 
        ' txtTipusAnimalBuscar
        ' 
        txtTipusAnimalBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTipusAnimalBuscar.BackColor = SystemColors.ButtonHighlight
        txtTipusAnimalBuscar.Location = New Point(492, 75)
        txtTipusAnimalBuscar.Name = "txtTipusAnimalBuscar"
        txtTipusAnimalBuscar.Size = New Size(197, 27)
        txtTipusAnimalBuscar.TabIndex = 2
        ' 
        ' btnTipusAnimalReset
        ' 
        btnTipusAnimalReset.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTipusAnimalReset.BackColor = Color.Aquamarine
        btnTipusAnimalReset.Location = New Point(695, 75)
        btnTipusAnimalReset.Name = "btnTipusAnimalReset"
        btnTipusAnimalReset.Size = New Size(81, 29)
        btnTipusAnimalReset.TabIndex = 3
        btnTipusAnimalReset.Text = "Reset"
        btnTipusAnimalReset.UseVisualStyleBackColor = False
        ' 
        ' btnTipusAnimalAfegir
        ' 
        btnTipusAnimalAfegir.Anchor = AnchorStyles.Right
        btnTipusAnimalAfegir.BackColor = Color.Aquamarine
        btnTipusAnimalAfegir.Location = New Point(540, 193)
        btnTipusAnimalAfegir.Name = "btnTipusAnimalAfegir"
        btnTipusAnimalAfegir.Size = New Size(170, 65)
        btnTipusAnimalAfegir.TabIndex = 4
        btnTipusAnimalAfegir.Text = "Afegir tipus d'animal"
        btnTipusAnimalAfegir.UseVisualStyleBackColor = False
        ' 
        ' btnTipusAnimalEnrere
        ' 
        btnTipusAnimalEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnTipusAnimalEnrere.BackColor = Color.Aquamarine
        btnTipusAnimalEnrere.Location = New Point(540, 373)
        btnTipusAnimalEnrere.Name = "btnTipusAnimalEnrere"
        btnTipusAnimalEnrere.Size = New Size(170, 65)
        btnTipusAnimalEnrere.TabIndex = 5
        btnTipusAnimalEnrere.Text = "Enrere"
        btnTipusAnimalEnrere.UseVisualStyleBackColor = False
        ' 
        ' GestioTipusAnimals
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btnTipusAnimalEnrere)
        Controls.Add(btnTipusAnimalAfegir)
        Controls.Add(btnTipusAnimalReset)
        Controls.Add(txtTipusAnimalBuscar)
        Controls.Add(lblTipusAnimalsTitol)
        Controls.Add(dgvTipusAnimalsLlistat)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(818, 497)
        Name = "GestioTipusAnimals"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Tipus d'animals"
        WindowState = FormWindowState.Maximized
        CType(dgvTipusAnimalsLlistat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTipusAnimalsLlistat As DataGridView
    Friend WithEvents lblTipusAnimalsTitol As Label
    Friend WithEvents txtTipusAnimalBuscar As TextBox
    Friend WithEvents btnTipusAnimalReset As Button
    Friend WithEvents btnTipusAnimalAfegir As Button
    Friend WithEvents btnTipusAnimalEnrere As Button
End Class
