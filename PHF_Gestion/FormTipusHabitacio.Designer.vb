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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTipusHabitacio))
        Me.lblFTipusHabitacioTitol = New System.Windows.Forms.Label()
        Me.lblFTipusHabitacioNom = New System.Windows.Forms.Label()
        Me.lblFTipusHabitacio = New System.Windows.Forms.Label()
        Me.lblFTipusHabitacioPreu = New System.Windows.Forms.Label()
        Me.txtFTipusHabitacioNom = New System.Windows.Forms.TextBox()
        Me.txtFTipusHabitacioDesc = New System.Windows.Forms.TextBox()
        Me.txtFTipusHabitacioPreu = New System.Windows.Forms.TextBox()
        Me.spcFTipusHabitacioSeparador = New System.Windows.Forms.SplitContainer()
        Me.btnFTipusHabitacioEliminarAnimal = New System.Windows.Forms.Button()
        Me.btnFTipusHabitacioAfegirAnimal = New System.Windows.Forms.Button()
        Me.lblFTipusHabitacioTitolAnimal = New System.Windows.Forms.Label()
        Me.dgvFTipusHabitacioAnimals = New System.Windows.Forms.DataGridView()
        Me.btnFTipusHabitacioEnrere = New System.Windows.Forms.Button()
        Me.btnFTipusHabitacioModificar = New System.Windows.Forms.Button()
        Me.btnFTipusHabitacioGuardar = New System.Windows.Forms.Button()
        Me.btnFTipusHabitacioEliminar = New System.Windows.Forms.Button()
        Me.erpFromTHabitacioError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bdgFromThabitacioAnimalVista = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.spcFTipusHabitacioSeparador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcFTipusHabitacioSeparador.Panel1.SuspendLayout()
        Me.spcFTipusHabitacioSeparador.Panel2.SuspendLayout()
        Me.spcFTipusHabitacioSeparador.SuspendLayout()
        CType(Me.dgvFTipusHabitacioAnimals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpFromTHabitacioError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdgFromThabitacioAnimalVista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFTipusHabitacioTitol
        '
        Me.lblFTipusHabitacioTitol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFTipusHabitacioTitol.AutoSize = True
        Me.lblFTipusHabitacioTitol.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFTipusHabitacioTitol.Location = New System.Drawing.Point(312, 21)
        Me.lblFTipusHabitacioTitol.Name = "lblFTipusHabitacioTitol"
        Me.lblFTipusHabitacioTitol.Size = New System.Drawing.Size(155, 25)
        Me.lblFTipusHabitacioTitol.TabIndex = 0
        Me.lblFTipusHabitacioTitol.Text = "Tipus d'habitació"
        '
        'lblFTipusHabitacioNom
        '
        Me.lblFTipusHabitacioNom.AutoSize = True
        Me.lblFTipusHabitacioNom.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFTipusHabitacioNom.Location = New System.Drawing.Point(35, 34)
        Me.lblFTipusHabitacioNom.Name = "lblFTipusHabitacioNom"
        Me.lblFTipusHabitacioNom.Size = New System.Drawing.Size(45, 20)
        Me.lblFTipusHabitacioNom.TabIndex = 1
        Me.lblFTipusHabitacioNom.Text = "Nom:"
        '
        'lblFTipusHabitacio
        '
        Me.lblFTipusHabitacio.AutoSize = True
        Me.lblFTipusHabitacio.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFTipusHabitacio.Location = New System.Drawing.Point(35, 68)
        Me.lblFTipusHabitacio.Name = "lblFTipusHabitacio"
        Me.lblFTipusHabitacio.Size = New System.Drawing.Size(82, 20)
        Me.lblFTipusHabitacio.TabIndex = 2
        Me.lblFTipusHabitacio.Text = "Descripció:"
        '
        'lblFTipusHabitacioPreu
        '
        Me.lblFTipusHabitacioPreu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFTipusHabitacioPreu.AutoSize = True
        Me.lblFTipusHabitacioPreu.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFTipusHabitacioPreu.Location = New System.Drawing.Point(35, 159)
        Me.lblFTipusHabitacioPreu.Name = "lblFTipusHabitacioPreu"
        Me.lblFTipusHabitacioPreu.Size = New System.Drawing.Size(41, 20)
        Me.lblFTipusHabitacioPreu.TabIndex = 3
        Me.lblFTipusHabitacioPreu.Text = "Preu:"
        '
        'txtFTipusHabitacioNom
        '
        Me.txtFTipusHabitacioNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFTipusHabitacioNom.Location = New System.Drawing.Point(161, 34)
        Me.txtFTipusHabitacioNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFTipusHabitacioNom.Name = "txtFTipusHabitacioNom"
        Me.txtFTipusHabitacioNom.Size = New System.Drawing.Size(197, 23)
        Me.txtFTipusHabitacioNom.TabIndex = 4
        '
        'txtFTipusHabitacioDesc
        '
        Me.txtFTipusHabitacioDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFTipusHabitacioDesc.Location = New System.Drawing.Point(161, 68)
        Me.txtFTipusHabitacioDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFTipusHabitacioDesc.Multiline = True
        Me.txtFTipusHabitacioDesc.Name = "txtFTipusHabitacioDesc"
        Me.txtFTipusHabitacioDesc.Size = New System.Drawing.Size(197, 74)
        Me.txtFTipusHabitacioDesc.TabIndex = 5
        '
        'txtFTipusHabitacioPreu
        '
        Me.txtFTipusHabitacioPreu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFTipusHabitacioPreu.Location = New System.Drawing.Point(161, 159)
        Me.txtFTipusHabitacioPreu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFTipusHabitacioPreu.Name = "txtFTipusHabitacioPreu"
        Me.txtFTipusHabitacioPreu.Size = New System.Drawing.Size(197, 23)
        Me.txtFTipusHabitacioPreu.TabIndex = 6
        '
        'spcFTipusHabitacioSeparador
        '
        Me.spcFTipusHabitacioSeparador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spcFTipusHabitacioSeparador.Location = New System.Drawing.Point(27, 62)
        Me.spcFTipusHabitacioSeparador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.spcFTipusHabitacioSeparador.Name = "spcFTipusHabitacioSeparador"
        '
        'spcFTipusHabitacioSeparador.Panel1
        '
        Me.spcFTipusHabitacioSeparador.Panel1.Controls.Add(Me.lblFTipusHabitacioNom)
        Me.spcFTipusHabitacioSeparador.Panel1.Controls.Add(Me.txtFTipusHabitacioPreu)
        Me.spcFTipusHabitacioSeparador.Panel1.Controls.Add(Me.lblFTipusHabitacio)
        Me.spcFTipusHabitacioSeparador.Panel1.Controls.Add(Me.txtFTipusHabitacioDesc)
        Me.spcFTipusHabitacioSeparador.Panel1.Controls.Add(Me.lblFTipusHabitacioPreu)
        Me.spcFTipusHabitacioSeparador.Panel1.Controls.Add(Me.txtFTipusHabitacioNom)
        '
        'spcFTipusHabitacioSeparador.Panel2
        '
        Me.spcFTipusHabitacioSeparador.Panel2.Controls.Add(Me.btnFTipusHabitacioEliminarAnimal)
        Me.spcFTipusHabitacioSeparador.Panel2.Controls.Add(Me.btnFTipusHabitacioAfegirAnimal)
        Me.spcFTipusHabitacioSeparador.Panel2.Controls.Add(Me.lblFTipusHabitacioTitolAnimal)
        Me.spcFTipusHabitacioSeparador.Panel2.Controls.Add(Me.dgvFTipusHabitacioAnimals)
        Me.spcFTipusHabitacioSeparador.Size = New System.Drawing.Size(780, 232)
        Me.spcFTipusHabitacioSeparador.SplitterDistance = 394
        Me.spcFTipusHabitacioSeparador.TabIndex = 7
        '
        'btnFTipusHabitacioEliminarAnimal
        '
        Me.btnFTipusHabitacioEliminarAnimal.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFTipusHabitacioEliminarAnimal.Location = New System.Drawing.Point(235, 24)
        Me.btnFTipusHabitacioEliminarAnimal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFTipusHabitacioEliminarAnimal.Name = "btnFTipusHabitacioEliminarAnimal"
        Me.btnFTipusHabitacioEliminarAnimal.Size = New System.Drawing.Size(73, 22)
        Me.btnFTipusHabitacioEliminarAnimal.TabIndex = 3
        Me.btnFTipusHabitacioEliminarAnimal.Text = "Eliminar"
        Me.btnFTipusHabitacioEliminarAnimal.UseVisualStyleBackColor = False
        '
        'btnFTipusHabitacioAfegirAnimal
        '
        Me.btnFTipusHabitacioAfegirAnimal.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFTipusHabitacioAfegirAnimal.Location = New System.Drawing.Point(144, 24)
        Me.btnFTipusHabitacioAfegirAnimal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFTipusHabitacioAfegirAnimal.Name = "btnFTipusHabitacioAfegirAnimal"
        Me.btnFTipusHabitacioAfegirAnimal.Size = New System.Drawing.Size(73, 22)
        Me.btnFTipusHabitacioAfegirAnimal.TabIndex = 2
        Me.btnFTipusHabitacioAfegirAnimal.Text = "Afegir"
        Me.btnFTipusHabitacioAfegirAnimal.UseVisualStyleBackColor = False
        '
        'lblFTipusHabitacioTitolAnimal
        '
        Me.lblFTipusHabitacioTitolAnimal.AutoSize = True
        Me.lblFTipusHabitacioTitolAnimal.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFTipusHabitacioTitolAnimal.Location = New System.Drawing.Point(22, 22)
        Me.lblFTipusHabitacioTitolAnimal.Name = "lblFTipusHabitacioTitolAnimal"
        Me.lblFTipusHabitacioTitolAnimal.Size = New System.Drawing.Size(111, 20)
        Me.lblFTipusHabitacioTitolAnimal.TabIndex = 1
        Me.lblFTipusHabitacioTitolAnimal.Text = "Tipus d'animals"
        '
        'dgvFTipusHabitacioAnimals
        '
        Me.dgvFTipusHabitacioAnimals.AllowUserToAddRows = False
        Me.dgvFTipusHabitacioAnimals.AllowUserToDeleteRows = False
        Me.dgvFTipusHabitacioAnimals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFTipusHabitacioAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFTipusHabitacioAnimals.Location = New System.Drawing.Point(22, 50)
        Me.dgvFTipusHabitacioAnimals.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvFTipusHabitacioAnimals.Name = "dgvFTipusHabitacioAnimals"
        Me.dgvFTipusHabitacioAnimals.ReadOnly = True
        Me.dgvFTipusHabitacioAnimals.RowHeadersWidth = 51
        Me.dgvFTipusHabitacioAnimals.RowTemplate.Height = 29
        Me.dgvFTipusHabitacioAnimals.Size = New System.Drawing.Size(320, 159)
        Me.dgvFTipusHabitacioAnimals.TabIndex = 0
        '
        'btnFTipusHabitacioEnrere
        '
        Me.btnFTipusHabitacioEnrere.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFTipusHabitacioEnrere.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFTipusHabitacioEnrere.Location = New System.Drawing.Point(158, 314)
        Me.btnFTipusHabitacioEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFTipusHabitacioEnrere.Name = "btnFTipusHabitacioEnrere"
        Me.btnFTipusHabitacioEnrere.Size = New System.Drawing.Size(121, 46)
        Me.btnFTipusHabitacioEnrere.TabIndex = 8
        Me.btnFTipusHabitacioEnrere.Text = "Enrere"
        Me.btnFTipusHabitacioEnrere.UseVisualStyleBackColor = False
        '
        'btnFTipusHabitacioModificar
        '
        Me.btnFTipusHabitacioModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFTipusHabitacioModificar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFTipusHabitacioModificar.Location = New System.Drawing.Point(302, 314)
        Me.btnFTipusHabitacioModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFTipusHabitacioModificar.Name = "btnFTipusHabitacioModificar"
        Me.btnFTipusHabitacioModificar.Size = New System.Drawing.Size(121, 46)
        Me.btnFTipusHabitacioModificar.TabIndex = 9
        Me.btnFTipusHabitacioModificar.Text = "Modificar"
        Me.btnFTipusHabitacioModificar.UseVisualStyleBackColor = False
        '
        'btnFTipusHabitacioGuardar
        '
        Me.btnFTipusHabitacioGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFTipusHabitacioGuardar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFTipusHabitacioGuardar.Location = New System.Drawing.Point(448, 314)
        Me.btnFTipusHabitacioGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFTipusHabitacioGuardar.Name = "btnFTipusHabitacioGuardar"
        Me.btnFTipusHabitacioGuardar.Size = New System.Drawing.Size(121, 46)
        Me.btnFTipusHabitacioGuardar.TabIndex = 10
        Me.btnFTipusHabitacioGuardar.Text = "Guardar"
        Me.btnFTipusHabitacioGuardar.UseVisualStyleBackColor = False
        '
        'btnFTipusHabitacioEliminar
        '
        Me.btnFTipusHabitacioEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFTipusHabitacioEliminar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFTipusHabitacioEliminar.Location = New System.Drawing.Point(597, 314)
        Me.btnFTipusHabitacioEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFTipusHabitacioEliminar.Name = "btnFTipusHabitacioEliminar"
        Me.btnFTipusHabitacioEliminar.Size = New System.Drawing.Size(121, 46)
        Me.btnFTipusHabitacioEliminar.TabIndex = 11
        Me.btnFTipusHabitacioEliminar.Text = "Eliminar"
        Me.btnFTipusHabitacioEliminar.UseVisualStyleBackColor = False
        '
        'erpFromTHabitacioError
        '
        Me.erpFromTHabitacioError.ContainerControl = Me
        '
        'FormTipusHabitacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(858, 374)
        Me.Controls.Add(Me.btnFTipusHabitacioEliminar)
        Me.Controls.Add(Me.btnFTipusHabitacioGuardar)
        Me.Controls.Add(Me.btnFTipusHabitacioModificar)
        Me.Controls.Add(Me.btnFTipusHabitacioEnrere)
        Me.Controls.Add(Me.spcFTipusHabitacioSeparador)
        Me.Controls.Add(Me.lblFTipusHabitacioTitol)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(874, 413)
        Me.Name = "FormTipusHabitacio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHF - Formulari Tipus Habitacio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.spcFTipusHabitacioSeparador.Panel1.ResumeLayout(False)
        Me.spcFTipusHabitacioSeparador.Panel1.PerformLayout()
        Me.spcFTipusHabitacioSeparador.Panel2.ResumeLayout(False)
        Me.spcFTipusHabitacioSeparador.Panel2.PerformLayout()
        CType(Me.spcFTipusHabitacioSeparador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcFTipusHabitacioSeparador.ResumeLayout(False)
        CType(Me.dgvFTipusHabitacioAnimals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpFromTHabitacioError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdgFromThabitacioAnimalVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents erpFromTHabitacioError As ErrorProvider
    Friend WithEvents bdgFromThabitacioAnimalVista As BindingSource
End Class
