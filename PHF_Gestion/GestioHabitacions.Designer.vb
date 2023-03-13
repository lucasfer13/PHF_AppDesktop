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
        dgvGestioHabitacionsLlistat = New DataGridView()
        lblGestioHabitacionsTitol = New Label()
        txtGestioHabitacionsBuscar = New TextBox()
        btnGestioHabitacionsReset = New Button()
        btnGestioHabitacionsAfegir = New Button()
        btnGestioHabitacionsAfegirVaries = New Button()
        btnGestioHabitacionsEnrere = New Button()
        CType(dgvGestioHabitacionsLlistat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvGestioHabitacionsLlistat
        ' 
        dgvGestioHabitacionsLlistat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvGestioHabitacionsLlistat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGestioHabitacionsLlistat.Location = New Point(12, 12)
        dgvGestioHabitacionsLlistat.Name = "dgvGestioHabitacionsLlistat"
        dgvGestioHabitacionsLlistat.RowHeadersWidth = 51
        dgvGestioHabitacionsLlistat.RowTemplate.Height = 29
        dgvGestioHabitacionsLlistat.Size = New Size(475, 416)
        dgvGestioHabitacionsLlistat.TabIndex = 0
        ' 
        ' lblGestioHabitacionsTitol
        ' 
        lblGestioHabitacionsTitol.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblGestioHabitacionsTitol.AutoSize = True
        lblGestioHabitacionsTitol.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioHabitacionsTitol.Location = New Point(578, 12)
        lblGestioHabitacionsTitol.Name = "lblGestioHabitacionsTitol"
        lblGestioHabitacionsTitol.Size = New Size(115, 28)
        lblGestioHabitacionsTitol.TabIndex = 1
        lblGestioHabitacionsTitol.Text = "Habitacions"' 
        ' txtGestioHabitacionsBuscar
        ' 
        txtGestioHabitacionsBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtGestioHabitacionsBuscar.Location = New Point(528, 52)
        txtGestioHabitacionsBuscar.Name = "txtGestioHabitacionsBuscar"
        txtGestioHabitacionsBuscar.Size = New Size(175, 27)
        txtGestioHabitacionsBuscar.TabIndex = 2
        ' 
        ' btnGestioHabitacionsReset
        ' 
        btnGestioHabitacionsReset.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGestioHabitacionsReset.BackColor = Color.Aquamarine
        btnGestioHabitacionsReset.Location = New Point(709, 51)
        btnGestioHabitacionsReset.Name = "btnGestioHabitacionsReset"
        btnGestioHabitacionsReset.Size = New Size(79, 29)
        btnGestioHabitacionsReset.TabIndex = 3
        btnGestioHabitacionsReset.Text = "Reset"
        btnGestioHabitacionsReset.UseVisualStyleBackColor = False
        ' 
        ' btnGestioHabitacionsAfegir
        ' 
        btnGestioHabitacionsAfegir.Anchor = AnchorStyles.Right
        btnGestioHabitacionsAfegir.BackColor = Color.Aquamarine
        btnGestioHabitacionsAfegir.Location = New Point(578, 149)
        btnGestioHabitacionsAfegir.Name = "btnGestioHabitacionsAfegir"
        btnGestioHabitacionsAfegir.Size = New Size(126, 58)
        btnGestioHabitacionsAfegir.TabIndex = 4
        btnGestioHabitacionsAfegir.Text = "Afegir habitacio"
        btnGestioHabitacionsAfegir.UseVisualStyleBackColor = False
        ' 
        ' btnGestioHabitacionsAfegirVaries
        ' 
        btnGestioHabitacionsAfegirVaries.Anchor = AnchorStyles.Right
        btnGestioHabitacionsAfegirVaries.BackColor = Color.Aquamarine
        btnGestioHabitacionsAfegirVaries.Location = New Point(578, 228)
        btnGestioHabitacionsAfegirVaries.Name = "btnGestioHabitacionsAfegirVaries"
        btnGestioHabitacionsAfegirVaries.Size = New Size(126, 58)
        btnGestioHabitacionsAfegirVaries.TabIndex = 5
        btnGestioHabitacionsAfegirVaries.Text = "Afegir moltes habitacions"
        btnGestioHabitacionsAfegirVaries.UseVisualStyleBackColor = False
        ' 
        ' btnGestioHabitacionsEnrere
        ' 
        btnGestioHabitacionsEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGestioHabitacionsEnrere.BackColor = Color.Aquamarine
        btnGestioHabitacionsEnrere.Location = New Point(577, 370)
        btnGestioHabitacionsEnrere.Name = "btnGestioHabitacionsEnrere"
        btnGestioHabitacionsEnrere.Size = New Size(126, 58)
        btnGestioHabitacionsEnrere.TabIndex = 6
        btnGestioHabitacionsEnrere.Text = "Enrere"
        btnGestioHabitacionsEnrere.UseVisualStyleBackColor = False
        ' 
        ' GestioHabitacions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(800, 440)
        Controls.Add(btnGestioHabitacionsEnrere)
        Controls.Add(btnGestioHabitacionsAfegirVaries)
        Controls.Add(btnGestioHabitacionsAfegir)
        Controls.Add(btnGestioHabitacionsReset)
        Controls.Add(txtGestioHabitacionsBuscar)
        Controls.Add(lblGestioHabitacionsTitol)
        Controls.Add(dgvGestioHabitacionsLlistat)
        MinimumSize = New Size(818, 487)
        Name = "GestioHabitacions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Gestió Habitacions"
        CType(dgvGestioHabitacionsLlistat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvGestioHabitacionsLlistat As DataGridView
    Friend WithEvents lblGestioHabitacionsTitol As Label
    Friend WithEvents txtGestioHabitacionsBuscar As TextBox
    Friend WithEvents btnGestioHabitacionsReset As Button
    Friend WithEvents btnGestioHabitacionsAfegir As Button
    Friend WithEvents btnGestioHabitacionsAfegirVaries As Button
    Friend WithEvents btnGestioHabitacionsEnrere As Button
End Class
