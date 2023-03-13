<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulariMoltesHabitacions
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
        lblAfegirHabitacionsTitol = New Label()
        lblAfegirHabitacionsQuantitat = New Label()
        lblAfegirHabitacionsTipus = New Label()
        nudAfegirHabitacionsQuantitat = New NumericUpDown()
        cmbAfegirHabitacionsTipus = New ComboBox()
        btnAfegirHabitacionsGuardar = New Button()
        btnAfegirHabitacionsEnrere = New Button()
        CType(nudAfegirHabitacionsQuantitat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblAfegirHabitacionsTitol
        ' 
        lblAfegirHabitacionsTitol.Anchor = AnchorStyles.Top
        lblAfegirHabitacionsTitol.AutoSize = True
        lblAfegirHabitacionsTitol.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblAfegirHabitacionsTitol.Location = New Point(200, 49)
        lblAfegirHabitacionsTitol.Name = "lblAfegirHabitacionsTitol"
        lblAfegirHabitacionsTitol.Size = New Size(200, 31)
        lblAfegirHabitacionsTitol.TabIndex = 0
        lblAfegirHabitacionsTitol.Text = "Afegir habitacions"' 
        ' lblAfegirHabitacionsQuantitat
        ' 
        lblAfegirHabitacionsQuantitat.AutoSize = True
        lblAfegirHabitacionsQuantitat.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblAfegirHabitacionsQuantitat.Location = New Point(71, 121)
        lblAfegirHabitacionsQuantitat.Name = "lblAfegirHabitacionsQuantitat"
        lblAfegirHabitacionsQuantitat.Size = New Size(185, 25)
        lblAfegirHabitacionsQuantitat.TabIndex = 1
        lblAfegirHabitacionsQuantitat.Text = "Quantitat habitacions:"' 
        ' lblAfegirHabitacionsTipus
        ' 
        lblAfegirHabitacionsTipus.AutoSize = True
        lblAfegirHabitacionsTipus.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblAfegirHabitacionsTipus.Location = New Point(71, 192)
        lblAfegirHabitacionsTipus.Name = "lblAfegirHabitacionsTipus"
        lblAfegirHabitacionsTipus.Size = New Size(150, 25)
        lblAfegirHabitacionsTipus.TabIndex = 2
        lblAfegirHabitacionsTipus.Text = "Tipus d'habitació:"' 
        ' nudAfegirHabitacionsQuantitat
        ' 
        nudAfegirHabitacionsQuantitat.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        nudAfegirHabitacionsQuantitat.Location = New Point(302, 123)
        nudAfegirHabitacionsQuantitat.Name = "nudAfegirHabitacionsQuantitat"
        nudAfegirHabitacionsQuantitat.Size = New Size(241, 27)
        nudAfegirHabitacionsQuantitat.TabIndex = 3
        ' 
        ' cmbAfegirHabitacionsTipus
        ' 
        cmbAfegirHabitacionsTipus.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbAfegirHabitacionsTipus.FormattingEnabled = True
        cmbAfegirHabitacionsTipus.Location = New Point(302, 193)
        cmbAfegirHabitacionsTipus.Name = "cmbAfegirHabitacionsTipus"
        cmbAfegirHabitacionsTipus.Size = New Size(241, 28)
        cmbAfegirHabitacionsTipus.TabIndex = 4
        ' 
        ' btnAfegirHabitacionsGuardar
        ' 
        btnAfegirHabitacionsGuardar.Anchor = AnchorStyles.Bottom
        btnAfegirHabitacionsGuardar.BackColor = Color.Aquamarine
        btnAfegirHabitacionsGuardar.Location = New Point(345, 293)
        btnAfegirHabitacionsGuardar.Name = "btnAfegirHabitacionsGuardar"
        btnAfegirHabitacionsGuardar.Size = New Size(119, 47)
        btnAfegirHabitacionsGuardar.TabIndex = 12
        btnAfegirHabitacionsGuardar.Text = "Guardar"
        btnAfegirHabitacionsGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnAfegirHabitacionsEnrere
        ' 
        btnAfegirHabitacionsEnrere.Anchor = AnchorStyles.Bottom
        btnAfegirHabitacionsEnrere.BackColor = Color.Aquamarine
        btnAfegirHabitacionsEnrere.Location = New Point(150, 293)
        btnAfegirHabitacionsEnrere.Name = "btnAfegirHabitacionsEnrere"
        btnAfegirHabitacionsEnrere.Size = New Size(119, 47)
        btnAfegirHabitacionsEnrere.TabIndex = 9
        btnAfegirHabitacionsEnrere.Text = "Enrere"
        btnAfegirHabitacionsEnrere.UseVisualStyleBackColor = False
        ' 
        ' FormulariMoltesHabitacions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(613, 363)
        Controls.Add(btnAfegirHabitacionsGuardar)
        Controls.Add(btnAfegirHabitacionsEnrere)
        Controls.Add(cmbAfegirHabitacionsTipus)
        Controls.Add(nudAfegirHabitacionsQuantitat)
        Controls.Add(lblAfegirHabitacionsTipus)
        Controls.Add(lblAfegirHabitacionsQuantitat)
        Controls.Add(lblAfegirHabitacionsTitol)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimumSize = New Size(631, 410)
        Name = "FormulariMoltesHabitacions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Afegir Habitacions"
        CType(nudAfegirHabitacionsQuantitat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAfegirHabitacionsTitol As Label
    Friend WithEvents lblAfegirHabitacionsQuantitat As Label
    Friend WithEvents lblAfegirHabitacionsTipus As Label
    Friend WithEvents nudAfegirHabitacionsQuantitat As NumericUpDown
    Friend WithEvents cmbAfegirHabitacionsTipus As ComboBox
    Friend WithEvents btnAfegirHabitacionsGuardar As Button
    Friend WithEvents btnAfegirHabitacionsEnrere As Button
End Class
