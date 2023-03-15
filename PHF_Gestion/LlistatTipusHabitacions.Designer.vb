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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LlistatTipusHabitacions))
        dgvTipusHabitacionsLlistat = New DataGridView()
        lblTipusHabitacionsTitol = New Label()
        txtTipusHabitacionsBuscar = New TextBox()
        btnTipusHabitacionsReset = New Button()
        btnTipusHabitacioAfegir = New Button()
        btnTipusHabitacioEnrere = New Button()
        CType(dgvTipusHabitacionsLlistat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTipusHabitacionsLlistat
        ' 
        dgvTipusHabitacionsLlistat.AllowUserToAddRows = False
        dgvTipusHabitacionsLlistat.AllowUserToDeleteRows = False
        dgvTipusHabitacionsLlistat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTipusHabitacionsLlistat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTipusHabitacionsLlistat.Location = New Point(12, 12)
        dgvTipusHabitacionsLlistat.Name = "dgvTipusHabitacionsLlistat"
        dgvTipusHabitacionsLlistat.ReadOnly = True
        dgvTipusHabitacionsLlistat.RowHeadersWidth = 51
        dgvTipusHabitacionsLlistat.RowTemplate.Height = 29
        dgvTipusHabitacionsLlistat.Size = New Size(483, 426)
        dgvTipusHabitacionsLlistat.TabIndex = 0
        ' 
        ' lblTipusHabitacionsTitol
        ' 
        lblTipusHabitacionsTitol.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTipusHabitacionsTitol.AutoSize = True
        lblTipusHabitacionsTitol.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblTipusHabitacionsTitol.Location = New Point(566, 12)
        lblTipusHabitacionsTitol.Name = "lblTipusHabitacionsTitol"
        lblTipusHabitacionsTitol.Size = New Size(231, 38)
        lblTipusHabitacionsTitol.TabIndex = 1
        lblTipusHabitacionsTitol.Text = "Tipus habitacions"' 
        ' txtTipusHabitacionsBuscar
        ' 
        txtTipusHabitacionsBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTipusHabitacionsBuscar.Location = New Point(544, 68)
        txtTipusHabitacionsBuscar.Name = "txtTipusHabitacionsBuscar"
        txtTipusHabitacionsBuscar.Size = New Size(188, 27)
        txtTipusHabitacionsBuscar.TabIndex = 2
        ' 
        ' btnTipusHabitacionsReset
        ' 
        btnTipusHabitacionsReset.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTipusHabitacionsReset.BackColor = Color.Aquamarine
        btnTipusHabitacionsReset.Location = New Point(746, 68)
        btnTipusHabitacionsReset.Name = "btnTipusHabitacionsReset"
        btnTipusHabitacionsReset.Size = New Size(89, 27)
        btnTipusHabitacionsReset.TabIndex = 3
        btnTipusHabitacionsReset.Text = "Reset"
        btnTipusHabitacionsReset.UseVisualStyleBackColor = False
        ' 
        ' btnTipusHabitacioAfegir
        ' 
        btnTipusHabitacioAfegir.Anchor = AnchorStyles.Right
        btnTipusHabitacioAfegir.BackColor = Color.Aquamarine
        btnTipusHabitacioAfegir.Location = New Point(618, 202)
        btnTipusHabitacioAfegir.Name = "btnTipusHabitacioAfegir"
        btnTipusHabitacioAfegir.Size = New Size(129, 61)
        btnTipusHabitacioAfegir.TabIndex = 4
        btnTipusHabitacioAfegir.Text = "Afegir Tipus d'habitació"
        btnTipusHabitacioAfegir.UseVisualStyleBackColor = False
        ' 
        ' btnTipusHabitacioEnrere
        ' 
        btnTipusHabitacioEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnTipusHabitacioEnrere.BackColor = Color.Aquamarine
        btnTipusHabitacioEnrere.Location = New Point(618, 381)
        btnTipusHabitacioEnrere.Name = "btnTipusHabitacioEnrere"
        btnTipusHabitacioEnrere.Size = New Size(129, 61)
        btnTipusHabitacioEnrere.TabIndex = 5
        btnTipusHabitacioEnrere.Text = "Enrere"
        btnTipusHabitacioEnrere.UseVisualStyleBackColor = False
        ' 
        ' LlistatTipusHabitacions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(856, 455)
        Controls.Add(btnTipusHabitacioEnrere)
        Controls.Add(btnTipusHabitacioAfegir)
        Controls.Add(btnTipusHabitacionsReset)
        Controls.Add(txtTipusHabitacionsBuscar)
        Controls.Add(lblTipusHabitacionsTitol)
        Controls.Add(dgvTipusHabitacionsLlistat)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(874, 502)
        Name = "LlistatTipusHabitacions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Tipus Habitacions"
        WindowState = FormWindowState.Maximized
        CType(dgvTipusHabitacionsLlistat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTipusHabitacionsLlistat As DataGridView
    Friend WithEvents lblTipusHabitacionsTitol As Label
    Friend WithEvents txtTipusHabitacionsBuscar As TextBox
    Friend WithEvents btnTipusHabitacionsReset As Button
    Friend WithEvents btnTipusHabitacioAfegir As Button
    Friend WithEvents btnTipusHabitacioEnrere As Button
End Class
