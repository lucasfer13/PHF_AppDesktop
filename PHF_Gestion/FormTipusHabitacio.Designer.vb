<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTipusHabitacio
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
        lblFTipusHabitacioTitol = New Label()
        lblFTipusHabitacioNom = New Label()
        lblFTipusHabitacio = New Label()
        lblFTipusHabitacioPreu = New Label()
        txtFTipusHabitacioNom = New TextBox()
        txtFTipusHabitacioDesc = New TextBox()
        txtFTipusHabitacioPreu = New TextBox()
        spcFTipusHabitacioSeparador = New SplitContainer()
        btnFTipusHabitacioEliminarAnimal = New Button()
        btnFTipusHabitacioAfegirAnimal = New Button()
        lblFTipusHabitacioTitolAnimal = New Label()
        dgvFTipusHabitacioAnimals = New DataGridView()
        btnFTipusHabitacioEnrere = New Button()
        btnFTipusHabitacioModificar = New Button()
        btnFTipusHabitacioGuardar = New Button()
        btnFTipusHabitacioEliminar = New Button()
        CType(spcFTipusHabitacioSeparador, ComponentModel.ISupportInitialize).BeginInit()
        spcFTipusHabitacioSeparador.Panel1.SuspendLayout()
        spcFTipusHabitacioSeparador.Panel2.SuspendLayout()
        spcFTipusHabitacioSeparador.SuspendLayout()
        CType(dgvFTipusHabitacioAnimals, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFTipusHabitacioTitol
        ' 
        lblFTipusHabitacioTitol.Anchor = AnchorStyles.Top
        lblFTipusHabitacioTitol.AutoSize = True
        lblFTipusHabitacioTitol.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblFTipusHabitacioTitol.Location = New Point(357, 28)
        lblFTipusHabitacioTitol.Name = "lblFTipusHabitacioTitol"
        lblFTipusHabitacioTitol.Size = New Size(189, 31)
        lblFTipusHabitacioTitol.TabIndex = 0
        lblFTipusHabitacioTitol.Text = "Tipus d'habitació"' 
        ' lblFTipusHabitacioNom
        ' 
        lblFTipusHabitacioNom.AutoSize = True
        lblFTipusHabitacioNom.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblFTipusHabitacioNom.Location = New Point(40, 45)
        lblFTipusHabitacioNom.Name = "lblFTipusHabitacioNom"
        lblFTipusHabitacioNom.Size = New Size(56, 25)
        lblFTipusHabitacioNom.TabIndex = 1
        lblFTipusHabitacioNom.Text = "Nom:"' 
        ' lblFTipusHabitacio
        ' 
        lblFTipusHabitacio.AutoSize = True
        lblFTipusHabitacio.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblFTipusHabitacio.Location = New Point(40, 91)
        lblFTipusHabitacio.Name = "lblFTipusHabitacio"
        lblFTipusHabitacio.Size = New Size(98, 25)
        lblFTipusHabitacio.TabIndex = 2
        lblFTipusHabitacio.Text = "Descripció:"' 
        ' lblFTipusHabitacioPreu
        ' 
        lblFTipusHabitacioPreu.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblFTipusHabitacioPreu.AutoSize = True
        lblFTipusHabitacioPreu.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblFTipusHabitacioPreu.Location = New Point(40, 212)
        lblFTipusHabitacioPreu.Name = "lblFTipusHabitacioPreu"
        lblFTipusHabitacioPreu.Size = New Size(51, 25)
        lblFTipusHabitacioPreu.TabIndex = 3
        lblFTipusHabitacioPreu.Text = "Preu:"' 
        ' txtFTipusHabitacioNom
        ' 
        txtFTipusHabitacioNom.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFTipusHabitacioNom.Location = New Point(184, 46)
        txtFTipusHabitacioNom.Name = "txtFTipusHabitacioNom"
        txtFTipusHabitacioNom.Size = New Size(226, 27)
        txtFTipusHabitacioNom.TabIndex = 4
        ' 
        ' txtFTipusHabitacioDesc
        ' 
        txtFTipusHabitacioDesc.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtFTipusHabitacioDesc.Location = New Point(184, 91)
        txtFTipusHabitacioDesc.Multiline = True
        txtFTipusHabitacioDesc.Name = "txtFTipusHabitacioDesc"
        txtFTipusHabitacioDesc.Size = New Size(226, 97)
        txtFTipusHabitacioDesc.TabIndex = 5
        ' 
        ' txtFTipusHabitacioPreu
        ' 
        txtFTipusHabitacioPreu.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtFTipusHabitacioPreu.Location = New Point(184, 212)
        txtFTipusHabitacioPreu.Name = "txtFTipusHabitacioPreu"
        txtFTipusHabitacioPreu.Size = New Size(226, 27)
        txtFTipusHabitacioPreu.TabIndex = 6
        ' 
        ' spcFTipusHabitacioSeparador
        ' 
        spcFTipusHabitacioSeparador.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        spcFTipusHabitacioSeparador.Location = New Point(31, 82)
        spcFTipusHabitacioSeparador.Name = "spcFTipusHabitacioSeparador"' 
        ' spcFTipusHabitacioSeparador.Panel1
        ' 
        spcFTipusHabitacioSeparador.Panel1.Controls.Add(lblFTipusHabitacioNom)
        spcFTipusHabitacioSeparador.Panel1.Controls.Add(txtFTipusHabitacioPreu)
        spcFTipusHabitacioSeparador.Panel1.Controls.Add(lblFTipusHabitacio)
        spcFTipusHabitacioSeparador.Panel1.Controls.Add(txtFTipusHabitacioDesc)
        spcFTipusHabitacioSeparador.Panel1.Controls.Add(lblFTipusHabitacioPreu)
        spcFTipusHabitacioSeparador.Panel1.Controls.Add(txtFTipusHabitacioNom)
        ' 
        ' spcFTipusHabitacioSeparador.Panel2
        ' 
        spcFTipusHabitacioSeparador.Panel2.Controls.Add(btnFTipusHabitacioEliminarAnimal)
        spcFTipusHabitacioSeparador.Panel2.Controls.Add(btnFTipusHabitacioAfegirAnimal)
        spcFTipusHabitacioSeparador.Panel2.Controls.Add(lblFTipusHabitacioTitolAnimal)
        spcFTipusHabitacioSeparador.Panel2.Controls.Add(dgvFTipusHabitacioAnimals)
        spcFTipusHabitacioSeparador.Size = New Size(891, 309)
        spcFTipusHabitacioSeparador.SplitterDistance = 451
        spcFTipusHabitacioSeparador.TabIndex = 7
        ' 
        ' btnFTipusHabitacioEliminarAnimal
        ' 
        btnFTipusHabitacioEliminarAnimal.BackColor = Color.Aquamarine
        btnFTipusHabitacioEliminarAnimal.Location = New Point(269, 32)
        btnFTipusHabitacioEliminarAnimal.Name = "btnFTipusHabitacioEliminarAnimal"
        btnFTipusHabitacioEliminarAnimal.Size = New Size(83, 29)
        btnFTipusHabitacioEliminarAnimal.TabIndex = 3
        btnFTipusHabitacioEliminarAnimal.Text = "Eliminar"
        btnFTipusHabitacioEliminarAnimal.UseVisualStyleBackColor = False
        ' 
        ' btnFTipusHabitacioAfegirAnimal
        ' 
        btnFTipusHabitacioAfegirAnimal.BackColor = Color.Aquamarine
        btnFTipusHabitacioAfegirAnimal.Location = New Point(165, 32)
        btnFTipusHabitacioAfegirAnimal.Name = "btnFTipusHabitacioAfegirAnimal"
        btnFTipusHabitacioAfegirAnimal.Size = New Size(83, 29)
        btnFTipusHabitacioAfegirAnimal.TabIndex = 2
        btnFTipusHabitacioAfegirAnimal.Text = "Afegir"
        btnFTipusHabitacioAfegirAnimal.UseVisualStyleBackColor = False
        ' 
        ' lblFTipusHabitacioTitolAnimal
        ' 
        lblFTipusHabitacioTitolAnimal.AutoSize = True
        lblFTipusHabitacioTitolAnimal.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblFTipusHabitacioTitolAnimal.Location = New Point(25, 29)
        lblFTipusHabitacioTitolAnimal.Name = "lblFTipusHabitacioTitolAnimal"
        lblFTipusHabitacioTitolAnimal.Size = New Size(134, 25)
        lblFTipusHabitacioTitolAnimal.TabIndex = 1
        lblFTipusHabitacioTitolAnimal.Text = "Tipus d'animals"' 
        ' dgvFTipusHabitacioAnimals
        ' 
        dgvFTipusHabitacioAnimals.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvFTipusHabitacioAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFTipusHabitacioAnimals.Location = New Point(25, 67)
        dgvFTipusHabitacioAnimals.Name = "dgvFTipusHabitacioAnimals"
        dgvFTipusHabitacioAnimals.RowHeadersWidth = 51
        dgvFTipusHabitacioAnimals.RowTemplate.Height = 29
        dgvFTipusHabitacioAnimals.Size = New Size(366, 212)
        dgvFTipusHabitacioAnimals.TabIndex = 0
        ' 
        ' btnFTipusHabitacioEnrere
        ' 
        btnFTipusHabitacioEnrere.Anchor = AnchorStyles.Bottom
        btnFTipusHabitacioEnrere.BackColor = Color.Aquamarine
        btnFTipusHabitacioEnrere.Location = New Point(181, 418)
        btnFTipusHabitacioEnrere.Name = "btnFTipusHabitacioEnrere"
        btnFTipusHabitacioEnrere.Size = New Size(138, 61)
        btnFTipusHabitacioEnrere.TabIndex = 8
        btnFTipusHabitacioEnrere.Text = "Enrere"
        btnFTipusHabitacioEnrere.UseVisualStyleBackColor = False
        ' 
        ' btnFTipusHabitacioModificar
        ' 
        btnFTipusHabitacioModificar.Anchor = AnchorStyles.Bottom
        btnFTipusHabitacioModificar.BackColor = Color.Aquamarine
        btnFTipusHabitacioModificar.Location = New Point(345, 418)
        btnFTipusHabitacioModificar.Name = "btnFTipusHabitacioModificar"
        btnFTipusHabitacioModificar.Size = New Size(138, 61)
        btnFTipusHabitacioModificar.TabIndex = 9
        btnFTipusHabitacioModificar.Text = "Modificar"
        btnFTipusHabitacioModificar.UseVisualStyleBackColor = False
        ' 
        ' btnFTipusHabitacioGuardar
        ' 
        btnFTipusHabitacioGuardar.Anchor = AnchorStyles.Bottom
        btnFTipusHabitacioGuardar.BackColor = Color.Aquamarine
        btnFTipusHabitacioGuardar.Location = New Point(512, 418)
        btnFTipusHabitacioGuardar.Name = "btnFTipusHabitacioGuardar"
        btnFTipusHabitacioGuardar.Size = New Size(138, 61)
        btnFTipusHabitacioGuardar.TabIndex = 10
        btnFTipusHabitacioGuardar.Text = "Guardar"
        btnFTipusHabitacioGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnFTipusHabitacioEliminar
        ' 
        btnFTipusHabitacioEliminar.Anchor = AnchorStyles.Bottom
        btnFTipusHabitacioEliminar.BackColor = Color.Aquamarine
        btnFTipusHabitacioEliminar.Location = New Point(682, 418)
        btnFTipusHabitacioEliminar.Name = "btnFTipusHabitacioEliminar"
        btnFTipusHabitacioEliminar.Size = New Size(138, 61)
        btnFTipusHabitacioEliminar.TabIndex = 11
        btnFTipusHabitacioEliminar.Text = "Eliminar"
        btnFTipusHabitacioEliminar.UseVisualStyleBackColor = False
        ' 
        ' FormTipusHabitacio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(979, 491)
        Controls.Add(btnFTipusHabitacioEliminar)
        Controls.Add(btnFTipusHabitacioGuardar)
        Controls.Add(btnFTipusHabitacioModificar)
        Controls.Add(btnFTipusHabitacioEnrere)
        Controls.Add(spcFTipusHabitacioSeparador)
        Controls.Add(lblFTipusHabitacioTitol)
        MinimumSize = New Size(997, 538)
        Name = "FormTipusHabitacio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Formulari Tipus Habitacio"
        spcFTipusHabitacioSeparador.Panel1.ResumeLayout(False)
        spcFTipusHabitacioSeparador.Panel1.PerformLayout()
        spcFTipusHabitacioSeparador.Panel2.ResumeLayout(False)
        spcFTipusHabitacioSeparador.Panel2.PerformLayout()
        CType(spcFTipusHabitacioSeparador, ComponentModel.ISupportInitialize).EndInit()
        spcFTipusHabitacioSeparador.ResumeLayout(False)
        CType(dgvFTipusHabitacioAnimals, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFTipusHabitacioTitol As Label
    Friend WithEvents lblFTipusHabitacioNom As Label
    Friend WithEvents lblFTipusHabitacio As Label
    Friend WithEvents lblFTipusHabitacioPreu As Label
    Friend WithEvents txtFTipusHabitacioNom As TextBox
    Friend WithEvents txtFTipusHabitacioDesc As TextBox
    Friend WithEvents txtFTipusHabitacioPreu As TextBox
    Friend WithEvents spcFTipusHabitacioSeparador As SplitContainer
    Friend WithEvents btnFTipusHabitacioEnrere As Button
    Friend WithEvents btnFTipusHabitacioModificar As Button
    Friend WithEvents btnFTipusHabitacioGuardar As Button
    Friend WithEvents btnFTipusHabitacioEliminar As Button
    Friend WithEvents btnFTipusHabitacioEliminarAnimal As Button
    Friend WithEvents btnFTipusHabitacioAfegirAnimal As Button
    Friend WithEvents lblFTipusHabitacioTitolAnimal As Label
    Friend WithEvents dgvFTipusHabitacioAnimals As DataGridView
End Class
