<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LlistatTipusHabitacions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LlistatTipusHabitacions))
        Me.dgvTipusHabitacionsLlistat = New System.Windows.Forms.DataGridView()
        Me.lblTipusHabitacionsTitol = New System.Windows.Forms.Label()
        Me.txtTipusHabitacionsBuscar = New System.Windows.Forms.TextBox()
        Me.btnTipusHabitacionsReset = New System.Windows.Forms.Button()
        Me.btnTipusHabitacioAfegir = New System.Windows.Forms.Button()
        Me.btnTipusHabitacioEnrere = New System.Windows.Forms.Button()
        Me.bdgLListatTHabitacionsVista = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvTipusHabitacionsLlistat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdgLListatTHabitacionsVista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTipusHabitacionsLlistat
        '
        Me.dgvTipusHabitacionsLlistat.AllowUserToAddRows = False
        Me.dgvTipusHabitacionsLlistat.AllowUserToDeleteRows = False
        Me.dgvTipusHabitacionsLlistat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTipusHabitacionsLlistat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipusHabitacionsLlistat.Location = New System.Drawing.Point(10, 9)
        Me.dgvTipusHabitacionsLlistat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTipusHabitacionsLlistat.MultiSelect = False
        Me.dgvTipusHabitacionsLlistat.Name = "dgvTipusHabitacionsLlistat"
        Me.dgvTipusHabitacionsLlistat.ReadOnly = True
        Me.dgvTipusHabitacionsLlistat.RowHeadersWidth = 51
        Me.dgvTipusHabitacionsLlistat.RowTemplate.Height = 29
        Me.dgvTipusHabitacionsLlistat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTipusHabitacionsLlistat.Size = New System.Drawing.Size(423, 320)
        Me.dgvTipusHabitacionsLlistat.TabIndex = 0
        '
        'lblTipusHabitacionsTitol
        '
        Me.lblTipusHabitacionsTitol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipusHabitacionsTitol.AutoSize = True
        Me.lblTipusHabitacionsTitol.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTipusHabitacionsTitol.Location = New System.Drawing.Point(495, 9)
        Me.lblTipusHabitacionsTitol.Name = "lblTipusHabitacionsTitol"
        Me.lblTipusHabitacionsTitol.Size = New System.Drawing.Size(178, 30)
        Me.lblTipusHabitacionsTitol.TabIndex = 1
        Me.lblTipusHabitacionsTitol.Text = "Tipus habitacions"
        '
        'txtTipusHabitacionsBuscar
        '
        Me.txtTipusHabitacionsBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipusHabitacionsBuscar.Location = New System.Drawing.Point(476, 51)
        Me.txtTipusHabitacionsBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTipusHabitacionsBuscar.Name = "txtTipusHabitacionsBuscar"
        Me.txtTipusHabitacionsBuscar.Size = New System.Drawing.Size(165, 23)
        Me.txtTipusHabitacionsBuscar.TabIndex = 2
        '
        'btnTipusHabitacionsReset
        '
        Me.btnTipusHabitacionsReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTipusHabitacionsReset.BackColor = System.Drawing.Color.Aquamarine
        Me.btnTipusHabitacionsReset.Location = New System.Drawing.Point(653, 51)
        Me.btnTipusHabitacionsReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTipusHabitacionsReset.Name = "btnTipusHabitacionsReset"
        Me.btnTipusHabitacionsReset.Size = New System.Drawing.Size(78, 20)
        Me.btnTipusHabitacionsReset.TabIndex = 3
        Me.btnTipusHabitacionsReset.Text = "Reset"
        Me.btnTipusHabitacionsReset.UseVisualStyleBackColor = False
        '
        'btnTipusHabitacioAfegir
        '
        Me.btnTipusHabitacioAfegir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnTipusHabitacioAfegir.BackColor = System.Drawing.Color.Aquamarine
        Me.btnTipusHabitacioAfegir.Location = New System.Drawing.Point(541, 152)
        Me.btnTipusHabitacioAfegir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTipusHabitacioAfegir.Name = "btnTipusHabitacioAfegir"
        Me.btnTipusHabitacioAfegir.Size = New System.Drawing.Size(113, 46)
        Me.btnTipusHabitacioAfegir.TabIndex = 4
        Me.btnTipusHabitacioAfegir.Text = "Afegir Tipus d'habitació"
        Me.btnTipusHabitacioAfegir.UseVisualStyleBackColor = False
        '
        'btnTipusHabitacioEnrere
        '
        Me.btnTipusHabitacioEnrere.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTipusHabitacioEnrere.BackColor = System.Drawing.Color.Aquamarine
        Me.btnTipusHabitacioEnrere.Location = New System.Drawing.Point(541, 286)
        Me.btnTipusHabitacioEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTipusHabitacioEnrere.Name = "btnTipusHabitacioEnrere"
        Me.btnTipusHabitacioEnrere.Size = New System.Drawing.Size(113, 46)
        Me.btnTipusHabitacioEnrere.TabIndex = 5
        Me.btnTipusHabitacioEnrere.Text = "Enrere"
        Me.btnTipusHabitacioEnrere.UseVisualStyleBackColor = False
        '
        'LlistatTipusHabitacions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(751, 347)
        Me.Controls.Add(Me.btnTipusHabitacioEnrere)
        Me.Controls.Add(Me.btnTipusHabitacioAfegir)
        Me.Controls.Add(Me.btnTipusHabitacionsReset)
        Me.Controls.Add(Me.txtTipusHabitacionsBuscar)
        Me.Controls.Add(Me.lblTipusHabitacionsTitol)
        Me.Controls.Add(Me.dgvTipusHabitacionsLlistat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(767, 386)
        Me.Name = "LlistatTipusHabitacions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHF - Tipus Habitacions"
        CType(Me.dgvTipusHabitacionsLlistat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdgLListatTHabitacionsVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTipusHabitacionsLlistat As DataGridView
    Friend WithEvents lblTipusHabitacionsTitol As Label
    Friend WithEvents txtTipusHabitacionsBuscar As TextBox
    Friend WithEvents btnTipusHabitacionsReset As Button
    Friend WithEvents btnTipusHabitacioAfegir As Button
    Friend WithEvents btnTipusHabitacioEnrere As Button
    Friend WithEvents bdgLListatTHabitacionsVista As BindingSource
End Class
