<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulariHabitacio
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
        lblFormulariHabitacioTitol = New Label()
        lblFormulariHabitacioNumeracio = New Label()
        txtFormulariHabitacioNumeracio = New TextBox()
        lblFormulariHabitacioTipus = New Label()
        cmbFormulariHabitacioTipus = New ComboBox()
        btnFormulariHabitacioEnrere = New Button()
        btnFormulariHabitacioModificar = New Button()
        btnFormulariHabitacioEliminar = New Button()
        btnFormulariHabitacioGuardar = New Button()
        SuspendLayout()
        ' 
        ' lblFormulariHabitacioTitol
        ' 
        lblFormulariHabitacioTitol.Anchor = AnchorStyles.Top
        lblFormulariHabitacioTitol.AutoSize = True
        lblFormulariHabitacioTitol.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblFormulariHabitacioTitol.Location = New Point(279, 25)
        lblFormulariHabitacioTitol.Name = "lblFormulariHabitacioTitol"
        lblFormulariHabitacioTitol.Size = New Size(143, 41)
        lblFormulariHabitacioTitol.TabIndex = 0
        lblFormulariHabitacioTitol.Text = "Habitació"' 
        ' lblFormulariHabitacioNumeracio
        ' 
        lblFormulariHabitacioNumeracio.AutoSize = True
        lblFormulariHabitacioNumeracio.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblFormulariHabitacioNumeracio.Location = New Point(56, 109)
        lblFormulariHabitacioNumeracio.Name = "lblFormulariHabitacioNumeracio"
        lblFormulariHabitacioNumeracio.Size = New Size(102, 25)
        lblFormulariHabitacioNumeracio.TabIndex = 1
        lblFormulariHabitacioNumeracio.Text = "Numeració:"' 
        ' txtFormulariHabitacioNumeracio
        ' 
        txtFormulariHabitacioNumeracio.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFormulariHabitacioNumeracio.Location = New Point(225, 110)
        txtFormulariHabitacioNumeracio.Name = "txtFormulariHabitacioNumeracio"
        txtFormulariHabitacioNumeracio.Size = New Size(366, 27)
        txtFormulariHabitacioNumeracio.TabIndex = 2
        ' 
        ' lblFormulariHabitacioTipus
        ' 
        lblFormulariHabitacioTipus.AutoSize = True
        lblFormulariHabitacioTipus.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblFormulariHabitacioTipus.Location = New Point(56, 181)
        lblFormulariHabitacioTipus.Name = "lblFormulariHabitacioTipus"
        lblFormulariHabitacioTipus.Size = New Size(135, 25)
        lblFormulariHabitacioTipus.TabIndex = 3
        lblFormulariHabitacioTipus.Text = "Tipus habitació:"' 
        ' cmbFormulariHabitacioTipus
        ' 
        cmbFormulariHabitacioTipus.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbFormulariHabitacioTipus.FormattingEnabled = True
        cmbFormulariHabitacioTipus.Location = New Point(225, 182)
        cmbFormulariHabitacioTipus.Name = "cmbFormulariHabitacioTipus"
        cmbFormulariHabitacioTipus.Size = New Size(366, 28)
        cmbFormulariHabitacioTipus.TabIndex = 4
        ' 
        ' btnFormulariHabitacioEnrere
        ' 
        btnFormulariHabitacioEnrere.Anchor = AnchorStyles.Bottom
        btnFormulariHabitacioEnrere.BackColor = Color.Aquamarine
        btnFormulariHabitacioEnrere.Location = New Point(50, 341)
        btnFormulariHabitacioEnrere.Name = "btnFormulariHabitacioEnrere"
        btnFormulariHabitacioEnrere.Size = New Size(119, 47)
        btnFormulariHabitacioEnrere.TabIndex = 5
        btnFormulariHabitacioEnrere.Text = "Enrere"
        btnFormulariHabitacioEnrere.UseVisualStyleBackColor = False
        ' 
        ' btnFormulariHabitacioModificar
        ' 
        btnFormulariHabitacioModificar.Anchor = AnchorStyles.Bottom
        btnFormulariHabitacioModificar.BackColor = Color.Aquamarine
        btnFormulariHabitacioModificar.Location = New Point(209, 341)
        btnFormulariHabitacioModificar.Name = "btnFormulariHabitacioModificar"
        btnFormulariHabitacioModificar.Size = New Size(119, 47)
        btnFormulariHabitacioModificar.TabIndex = 6
        btnFormulariHabitacioModificar.Text = "Modificar"
        btnFormulariHabitacioModificar.UseVisualStyleBackColor = False
        ' 
        ' btnFormulariHabitacioEliminar
        ' 
        btnFormulariHabitacioEliminar.Anchor = AnchorStyles.Bottom
        btnFormulariHabitacioEliminar.BackColor = Color.Aquamarine
        btnFormulariHabitacioEliminar.Location = New Point(372, 341)
        btnFormulariHabitacioEliminar.Name = "btnFormulariHabitacioEliminar"
        btnFormulariHabitacioEliminar.Size = New Size(119, 47)
        btnFormulariHabitacioEliminar.TabIndex = 7
        btnFormulariHabitacioEliminar.Text = "Eliminar"
        btnFormulariHabitacioEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnFormulariHabitacioGuardar
        ' 
        btnFormulariHabitacioGuardar.Anchor = AnchorStyles.Bottom
        btnFormulariHabitacioGuardar.BackColor = Color.Aquamarine
        btnFormulariHabitacioGuardar.Location = New Point(525, 341)
        btnFormulariHabitacioGuardar.Name = "btnFormulariHabitacioGuardar"
        btnFormulariHabitacioGuardar.Size = New Size(119, 47)
        btnFormulariHabitacioGuardar.TabIndex = 8
        btnFormulariHabitacioGuardar.Text = "Guardar"
        btnFormulariHabitacioGuardar.UseVisualStyleBackColor = False
        ' 
        ' FormulariHabitacio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(690, 413)
        Controls.Add(btnFormulariHabitacioGuardar)
        Controls.Add(btnFormulariHabitacioEliminar)
        Controls.Add(btnFormulariHabitacioModificar)
        Controls.Add(btnFormulariHabitacioEnrere)
        Controls.Add(cmbFormulariHabitacioTipus)
        Controls.Add(lblFormulariHabitacioTipus)
        Controls.Add(txtFormulariHabitacioNumeracio)
        Controls.Add(lblFormulariHabitacioNumeracio)
        Controls.Add(lblFormulariHabitacioTitol)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimumSize = New Size(687, 460)
        Name = "FormulariHabitacio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Formulari Habitació"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFormulariHabitacioTitol As Label
    Friend WithEvents lblFormulariHabitacioNumeracio As Label
    Friend WithEvents txtFormulariHabitacioNumeracio As TextBox
    Friend WithEvents lblFormulariHabitacioTipus As Label
    Friend WithEvents cmbFormulariHabitacioTipus As ComboBox
    Friend WithEvents btnFormulariHabitacioEnrere As Button
    Friend WithEvents btnFormulariHabitacioModificar As Button
    Friend WithEvents btnFormulariHabitacioEliminar As Button
    Friend WithEvents btnFormulariHabitacioGuardar As Button
End Class
