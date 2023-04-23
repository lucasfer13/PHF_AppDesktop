<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestioHabitacions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestioHabitacions))
        Me.dgvGestioHabitacionsLlistat = New System.Windows.Forms.DataGridView()
        Me.lblGestioHabitacionsTitol = New System.Windows.Forms.Label()
        Me.txtGestioHabitacionsBuscar = New System.Windows.Forms.TextBox()
        Me.btnGestioHabitacionsReset = New System.Windows.Forms.Button()
        Me.btnGestioHabitacionsAfegir = New System.Windows.Forms.Button()
        Me.btnGestioHabitacionsEnrere = New System.Windows.Forms.Button()
        Me.bdgGestioHabitacionsVista = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvGestioHabitacionsLlistat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdgGestioHabitacionsVista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGestioHabitacionsLlistat
        '
        Me.dgvGestioHabitacionsLlistat.AllowUserToAddRows = False
        Me.dgvGestioHabitacionsLlistat.AllowUserToDeleteRows = False
        Me.dgvGestioHabitacionsLlistat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGestioHabitacionsLlistat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGestioHabitacionsLlistat.Location = New System.Drawing.Point(10, 9)
        Me.dgvGestioHabitacionsLlistat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvGestioHabitacionsLlistat.MultiSelect = False
        Me.dgvGestioHabitacionsLlistat.Name = "dgvGestioHabitacionsLlistat"
        Me.dgvGestioHabitacionsLlistat.ReadOnly = True
        Me.dgvGestioHabitacionsLlistat.RowHeadersWidth = 51
        Me.dgvGestioHabitacionsLlistat.RowTemplate.Height = 29
        Me.dgvGestioHabitacionsLlistat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGestioHabitacionsLlistat.Size = New System.Drawing.Size(416, 312)
        Me.dgvGestioHabitacionsLlistat.TabIndex = 0
        '
        'lblGestioHabitacionsTitol
        '
        Me.lblGestioHabitacionsTitol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGestioHabitacionsTitol.AutoSize = True
        Me.lblGestioHabitacionsTitol.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGestioHabitacionsTitol.Location = New System.Drawing.Point(506, 9)
        Me.lblGestioHabitacionsTitol.Name = "lblGestioHabitacionsTitol"
        Me.lblGestioHabitacionsTitol.Size = New System.Drawing.Size(91, 21)
        Me.lblGestioHabitacionsTitol.TabIndex = 1
        Me.lblGestioHabitacionsTitol.Text = "Habitacions"
        '
        'txtGestioHabitacionsBuscar
        '
        Me.txtGestioHabitacionsBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGestioHabitacionsBuscar.Location = New System.Drawing.Point(462, 39)
        Me.txtGestioHabitacionsBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGestioHabitacionsBuscar.Name = "txtGestioHabitacionsBuscar"
        Me.txtGestioHabitacionsBuscar.Size = New System.Drawing.Size(154, 23)
        Me.txtGestioHabitacionsBuscar.TabIndex = 2
        '
        'btnGestioHabitacionsReset
        '
        Me.btnGestioHabitacionsReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGestioHabitacionsReset.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioHabitacionsReset.Location = New System.Drawing.Point(620, 38)
        Me.btnGestioHabitacionsReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestioHabitacionsReset.Name = "btnGestioHabitacionsReset"
        Me.btnGestioHabitacionsReset.Size = New System.Drawing.Size(69, 22)
        Me.btnGestioHabitacionsReset.TabIndex = 3
        Me.btnGestioHabitacionsReset.Text = "Reset"
        Me.btnGestioHabitacionsReset.UseVisualStyleBackColor = False
        '
        'btnGestioHabitacionsAfegir
        '
        Me.btnGestioHabitacionsAfegir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnGestioHabitacionsAfegir.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioHabitacionsAfegir.Location = New System.Drawing.Point(506, 136)
        Me.btnGestioHabitacionsAfegir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestioHabitacionsAfegir.Name = "btnGestioHabitacionsAfegir"
        Me.btnGestioHabitacionsAfegir.Size = New System.Drawing.Size(110, 44)
        Me.btnGestioHabitacionsAfegir.TabIndex = 4
        Me.btnGestioHabitacionsAfegir.Text = "Afegir habitacio"
        Me.btnGestioHabitacionsAfegir.UseVisualStyleBackColor = False
        '
        'btnGestioHabitacionsEnrere
        '
        Me.btnGestioHabitacionsEnrere.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGestioHabitacionsEnrere.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioHabitacionsEnrere.Location = New System.Drawing.Point(505, 278)
        Me.btnGestioHabitacionsEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestioHabitacionsEnrere.Name = "btnGestioHabitacionsEnrere"
        Me.btnGestioHabitacionsEnrere.Size = New System.Drawing.Size(110, 44)
        Me.btnGestioHabitacionsEnrere.TabIndex = 6
        Me.btnGestioHabitacionsEnrere.Text = "Enrere"
        Me.btnGestioHabitacionsEnrere.UseVisualStyleBackColor = False
        '
        'GestioHabitacions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(702, 336)
        Me.Controls.Add(Me.btnGestioHabitacionsEnrere)
        Me.Controls.Add(Me.btnGestioHabitacionsAfegir)
        Me.Controls.Add(Me.btnGestioHabitacionsReset)
        Me.Controls.Add(Me.txtGestioHabitacionsBuscar)
        Me.Controls.Add(Me.lblGestioHabitacionsTitol)
        Me.Controls.Add(Me.dgvGestioHabitacionsLlistat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(718, 375)
        Me.Name = "GestioHabitacions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHF - Gestió Habitacions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvGestioHabitacionsLlistat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdgGestioHabitacionsVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGestioHabitacionsLlistat As DataGridView
    Friend WithEvents lblGestioHabitacionsTitol As Label
    Friend WithEvents txtGestioHabitacionsBuscar As TextBox
    Friend WithEvents btnGestioHabitacionsReset As Button
    Friend WithEvents btnGestioHabitacionsAfegir As Button
    Friend WithEvents btnGestioHabitacionsEnrere As Button
    Friend WithEvents bdgGestioHabitacionsVista As BindingSource
End Class
