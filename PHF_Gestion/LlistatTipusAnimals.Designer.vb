<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LlistatTipusAnimals
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LlistatTipusAnimals))
        Me.bdgLlistatTAnimaliVista = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvLlistatTAnimalsLlista = New System.Windows.Forms.DataGridView()
        Me.btnLlistatTAnimalsEnrere = New System.Windows.Forms.Button()
        Me.lblLlistatTAnimalTitol = New System.Windows.Forms.Label()
        Me.txtLlistatTAnimalBuscar = New System.Windows.Forms.TextBox()
        Me.lblLlistatTAnimalBuscar = New System.Windows.Forms.Label()
        Me.btnLlistatTAnimalsReset = New System.Windows.Forms.Button()
        CType(Me.bdgLlistatTAnimaliVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLlistatTAnimalsLlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLlistatTAnimalsLlista
        '
        Me.dgvLlistatTAnimalsLlista.AllowUserToAddRows = False
        Me.dgvLlistatTAnimalsLlista.AllowUserToDeleteRows = False
        Me.dgvLlistatTAnimalsLlista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLlistatTAnimalsLlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLlistatTAnimalsLlista.Location = New System.Drawing.Point(10, 100)
        Me.dgvLlistatTAnimalsLlista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvLlistatTAnimalsLlista.MultiSelect = False
        Me.dgvLlistatTAnimalsLlista.Name = "dgvLlistatTAnimalsLlista"
        Me.dgvLlistatTAnimalsLlista.ReadOnly = True
        Me.dgvLlistatTAnimalsLlista.RowHeadersWidth = 51
        Me.dgvLlistatTAnimalsLlista.RowTemplate.Height = 29
        Me.dgvLlistatTAnimalsLlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLlistatTAnimalsLlista.Size = New System.Drawing.Size(750, 235)
        Me.dgvLlistatTAnimalsLlista.TabIndex = 0
        '
        'btnLlistatTAnimalsEnrere
        '
        Me.btnLlistatTAnimalsEnrere.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLlistatTAnimalsEnrere.BackColor = System.Drawing.Color.Aquamarine
        Me.btnLlistatTAnimalsEnrere.Location = New System.Drawing.Point(320, 357)
        Me.btnLlistatTAnimalsEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLlistatTAnimalsEnrere.Name = "btnLlistatTAnimalsEnrere"
        Me.btnLlistatTAnimalsEnrere.Size = New System.Drawing.Size(130, 45)
        Me.btnLlistatTAnimalsEnrere.TabIndex = 3
        Me.btnLlistatTAnimalsEnrere.Text = "Enrere"
        Me.btnLlistatTAnimalsEnrere.UseVisualStyleBackColor = False
        '
        'lblLlistatTAnimalTitol
        '
        Me.lblLlistatTAnimalTitol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLlistatTAnimalTitol.AutoSize = True
        Me.lblLlistatTAnimalTitol.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLlistatTAnimalTitol.Location = New System.Drawing.Point(240, 9)
        Me.lblLlistatTAnimalTitol.Name = "lblLlistatTAnimalTitol"
        Me.lblLlistatTAnimalTitol.Size = New System.Drawing.Size(284, 30)
        Me.lblLlistatTAnimalTitol.TabIndex = 8
        Me.lblLlistatTAnimalTitol.Text = "Selecciona un tipus d'animal"
        '
        'txtLlistatTAnimalBuscar
        '
        Me.txtLlistatTAnimalBuscar.Location = New System.Drawing.Point(67, 64)
        Me.txtLlistatTAnimalBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLlistatTAnimalBuscar.Name = "txtLlistatTAnimalBuscar"
        Me.txtLlistatTAnimalBuscar.Size = New System.Drawing.Size(169, 23)
        Me.txtLlistatTAnimalBuscar.TabIndex = 1
        '
        'lblLlistatTAnimalBuscar
        '
        Me.lblLlistatTAnimalBuscar.AutoSize = True
        Me.lblLlistatTAnimalBuscar.Location = New System.Drawing.Point(10, 67)
        Me.lblLlistatTAnimalBuscar.Name = "lblLlistatTAnimalBuscar"
        Me.lblLlistatTAnimalBuscar.Size = New System.Drawing.Size(48, 15)
        Me.lblLlistatTAnimalBuscar.TabIndex = 10
        Me.lblLlistatTAnimalBuscar.Text = "Buscar: "
        '
        'btnLlistatTAnimalsReset
        '
        Me.btnLlistatTAnimalsReset.BackColor = System.Drawing.Color.Aquamarine
        Me.btnLlistatTAnimalsReset.Location = New System.Drawing.Point(253, 64)
        Me.btnLlistatTAnimalsReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLlistatTAnimalsReset.Name = "btnLlistatTAnimalsReset"
        Me.btnLlistatTAnimalsReset.Size = New System.Drawing.Size(69, 20)
        Me.btnLlistatTAnimalsReset.TabIndex = 2
        Me.btnLlistatTAnimalsReset.Text = "Reset"
        Me.btnLlistatTAnimalsReset.UseVisualStyleBackColor = False
        '
        'LlistatTipusAnimals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(773, 417)
        Me.Controls.Add(Me.btnLlistatTAnimalsReset)
        Me.Controls.Add(Me.lblLlistatTAnimalBuscar)
        Me.Controls.Add(Me.txtLlistatTAnimalBuscar)
        Me.Controls.Add(Me.lblLlistatTAnimalTitol)
        Me.Controls.Add(Me.btnLlistatTAnimalsEnrere)
        Me.Controls.Add(Me.dgvLlistatTAnimalsLlista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(789, 456)
        Me.Name = "LlistatTipusAnimals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHF - Llistat Tipus Animals"
        CType(Me.bdgLlistatTAnimaliVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLlistatTAnimalsLlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bdgLlistatTAnimaliVista As BindingSource
    Friend WithEvents dgvLlistatTAnimalsLlista As DataGridView
    Friend WithEvents btnLlistatTAnimalsEnrere As Button
    Friend WithEvents lblLlistatTAnimalTitol As Label
    Friend WithEvents txtLlistatTAnimalBuscar As TextBox
    Friend WithEvents lblLlistatTAnimalBuscar As Label
    Friend WithEvents btnLlistatTAnimalsReset As Button
End Class
