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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormulariHabitacio))
        Me.lblFormulariHabitacioTitol = New System.Windows.Forms.Label()
        Me.lblFormulariHabitacioNumeracio = New System.Windows.Forms.Label()
        Me.txtFormulariHabitacioNumeracio = New System.Windows.Forms.TextBox()
        Me.lblFormulariHabitacioTipus = New System.Windows.Forms.Label()
        Me.cmbFormulariHabitacioTipus = New System.Windows.Forms.ComboBox()
        Me.btnFormulariHabitacioEnrere = New System.Windows.Forms.Button()
        Me.btnFormulariHabitacioModificar = New System.Windows.Forms.Button()
        Me.btnFormulariHabitacioEliminar = New System.Windows.Forms.Button()
        Me.btnFormulariHabitacioGuardar = New System.Windows.Forms.Button()
        Me.erpFormHabitacioErrors = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.erpFormHabitacioErrors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormulariHabitacioTitol
        '
        Me.lblFormulariHabitacioTitol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFormulariHabitacioTitol.AutoSize = True
        Me.lblFormulariHabitacioTitol.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFormulariHabitacioTitol.Location = New System.Drawing.Point(244, 19)
        Me.lblFormulariHabitacioTitol.Name = "lblFormulariHabitacioTitol"
        Me.lblFormulariHabitacioTitol.Size = New System.Drawing.Size(114, 32)
        Me.lblFormulariHabitacioTitol.TabIndex = 0
        Me.lblFormulariHabitacioTitol.Text = "Habitació"
        '
        'lblFormulariHabitacioNumeracio
        '
        Me.lblFormulariHabitacioNumeracio.AutoSize = True
        Me.lblFormulariHabitacioNumeracio.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFormulariHabitacioNumeracio.Location = New System.Drawing.Point(49, 82)
        Me.lblFormulariHabitacioNumeracio.Name = "lblFormulariHabitacioNumeracio"
        Me.lblFormulariHabitacioNumeracio.Size = New System.Drawing.Size(85, 20)
        Me.lblFormulariHabitacioNumeracio.TabIndex = 1
        Me.lblFormulariHabitacioNumeracio.Text = "Numeració:"
        '
        'txtFormulariHabitacioNumeracio
        '
        Me.txtFormulariHabitacioNumeracio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormulariHabitacioNumeracio.Location = New System.Drawing.Point(197, 82)
        Me.txtFormulariHabitacioNumeracio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFormulariHabitacioNumeracio.Name = "txtFormulariHabitacioNumeracio"
        Me.txtFormulariHabitacioNumeracio.Size = New System.Drawing.Size(321, 23)
        Me.txtFormulariHabitacioNumeracio.TabIndex = 2
        '
        'lblFormulariHabitacioTipus
        '
        Me.lblFormulariHabitacioTipus.AutoSize = True
        Me.lblFormulariHabitacioTipus.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFormulariHabitacioTipus.Location = New System.Drawing.Point(49, 136)
        Me.lblFormulariHabitacioTipus.Name = "lblFormulariHabitacioTipus"
        Me.lblFormulariHabitacioTipus.Size = New System.Drawing.Size(113, 20)
        Me.lblFormulariHabitacioTipus.TabIndex = 3
        Me.lblFormulariHabitacioTipus.Text = "Tipus habitació:"
        '
        'cmbFormulariHabitacioTipus
        '
        Me.cmbFormulariHabitacioTipus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFormulariHabitacioTipus.FormattingEnabled = True
        Me.cmbFormulariHabitacioTipus.Location = New System.Drawing.Point(197, 136)
        Me.cmbFormulariHabitacioTipus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbFormulariHabitacioTipus.Name = "cmbFormulariHabitacioTipus"
        Me.cmbFormulariHabitacioTipus.Size = New System.Drawing.Size(321, 23)
        Me.cmbFormulariHabitacioTipus.TabIndex = 4
        '
        'btnFormulariHabitacioEnrere
        '
        Me.btnFormulariHabitacioEnrere.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFormulariHabitacioEnrere.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFormulariHabitacioEnrere.Location = New System.Drawing.Point(44, 256)
        Me.btnFormulariHabitacioEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFormulariHabitacioEnrere.Name = "btnFormulariHabitacioEnrere"
        Me.btnFormulariHabitacioEnrere.Size = New System.Drawing.Size(104, 35)
        Me.btnFormulariHabitacioEnrere.TabIndex = 5
        Me.btnFormulariHabitacioEnrere.Text = "Enrere"
        Me.btnFormulariHabitacioEnrere.UseVisualStyleBackColor = False
        '
        'btnFormulariHabitacioModificar
        '
        Me.btnFormulariHabitacioModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFormulariHabitacioModificar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFormulariHabitacioModificar.Location = New System.Drawing.Point(183, 256)
        Me.btnFormulariHabitacioModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFormulariHabitacioModificar.Name = "btnFormulariHabitacioModificar"
        Me.btnFormulariHabitacioModificar.Size = New System.Drawing.Size(104, 35)
        Me.btnFormulariHabitacioModificar.TabIndex = 6
        Me.btnFormulariHabitacioModificar.Text = "Modificar"
        Me.btnFormulariHabitacioModificar.UseVisualStyleBackColor = False
        '
        'btnFormulariHabitacioEliminar
        '
        Me.btnFormulariHabitacioEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFormulariHabitacioEliminar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFormulariHabitacioEliminar.Location = New System.Drawing.Point(326, 256)
        Me.btnFormulariHabitacioEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFormulariHabitacioEliminar.Name = "btnFormulariHabitacioEliminar"
        Me.btnFormulariHabitacioEliminar.Size = New System.Drawing.Size(104, 35)
        Me.btnFormulariHabitacioEliminar.TabIndex = 7
        Me.btnFormulariHabitacioEliminar.Text = "Eliminar"
        Me.btnFormulariHabitacioEliminar.UseVisualStyleBackColor = False
        '
        'btnFormulariHabitacioGuardar
        '
        Me.btnFormulariHabitacioGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFormulariHabitacioGuardar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnFormulariHabitacioGuardar.Location = New System.Drawing.Point(459, 256)
        Me.btnFormulariHabitacioGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFormulariHabitacioGuardar.Name = "btnFormulariHabitacioGuardar"
        Me.btnFormulariHabitacioGuardar.Size = New System.Drawing.Size(104, 35)
        Me.btnFormulariHabitacioGuardar.TabIndex = 8
        Me.btnFormulariHabitacioGuardar.Text = "Guardar"
        Me.btnFormulariHabitacioGuardar.UseVisualStyleBackColor = False
        '
        'erpFormHabitacioErrors
        '
        Me.erpFormHabitacioErrors.ContainerControl = Me
        '
        'FormulariHabitacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(604, 316)
        Me.Controls.Add(Me.btnFormulariHabitacioGuardar)
        Me.Controls.Add(Me.btnFormulariHabitacioEliminar)
        Me.Controls.Add(Me.btnFormulariHabitacioModificar)
        Me.Controls.Add(Me.btnFormulariHabitacioEnrere)
        Me.Controls.Add(Me.cmbFormulariHabitacioTipus)
        Me.Controls.Add(Me.lblFormulariHabitacioTipus)
        Me.Controls.Add(Me.txtFormulariHabitacioNumeracio)
        Me.Controls.Add(Me.lblFormulariHabitacioNumeracio)
        Me.Controls.Add(Me.lblFormulariHabitacioTitol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(603, 355)
        Me.Name = "FormulariHabitacio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHF - Formulari Habitació"
        CType(Me.erpFormHabitacioErrors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents erpFormHabitacioErrors As ErrorProvider
End Class
