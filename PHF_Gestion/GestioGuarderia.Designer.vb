<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestioGuarderia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestioGuarderia))
        Me.lblGestGuarderiaTitol = New System.Windows.Forms.Label()
        Me.lblGestGuarderiaNomGuarderia = New System.Windows.Forms.Label()
        Me.btnGestGuarderiaAfegCameres = New System.Windows.Forms.Button()
        Me.btnGestGuarderiaAfegirHabitacio = New System.Windows.Forms.Button()
        Me.btnGestGuarderiaModificar = New System.Windows.Forms.Button()
        Me.btnGestGuarderiaAfegirTipusHabitacio = New System.Windows.Forms.Button()
        Me.btnGestioGuarderiaEnrere = New System.Windows.Forms.Button()
        Me.btnGestioGuarderiaValoracions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGestGuarderiaTitol
        '
        Me.lblGestGuarderiaTitol.AutoSize = True
        Me.lblGestGuarderiaTitol.Font = New System.Drawing.Font("Sitka Small", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGestGuarderiaTitol.Location = New System.Drawing.Point(10, 28)
        Me.lblGestGuarderiaTitol.Name = "lblGestGuarderiaTitol"
        Me.lblGestGuarderiaTitol.Size = New System.Drawing.Size(147, 33)
        Me.lblGestGuarderiaTitol.TabIndex = 1
        Me.lblGestGuarderiaTitol.Text = "Guarderia:"
        '
        'lblGestGuarderiaNomGuarderia
        '
        Me.lblGestGuarderiaNomGuarderia.AutoSize = True
        Me.lblGestGuarderiaNomGuarderia.Font = New System.Drawing.Font("Sitka Small", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGestGuarderiaNomGuarderia.Location = New System.Drawing.Point(162, 28)
        Me.lblGestGuarderiaNomGuarderia.Name = "lblGestGuarderiaNomGuarderia"
        Me.lblGestGuarderiaNomGuarderia.Size = New System.Drawing.Size(78, 33)
        Me.lblGestGuarderiaNomGuarderia.TabIndex = 2
        Me.lblGestGuarderiaNomGuarderia.Text = "         "
        '
        'btnGestGuarderiaAfegCameres
        '
        Me.btnGestGuarderiaAfegCameres.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegCameres.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegCameres.Location = New System.Drawing.Point(66, 86)
        Me.btnGestGuarderiaAfegCameres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestGuarderiaAfegCameres.Name = "btnGestGuarderiaAfegCameres"
        Me.btnGestGuarderiaAfegCameres.Size = New System.Drawing.Size(119, 55)
        Me.btnGestGuarderiaAfegCameres.TabIndex = 5
        Me.btnGestGuarderiaAfegCameres.Text = "Afegir Cámeres"
        Me.btnGestGuarderiaAfegCameres.UseVisualStyleBackColor = False
        '
        'btnGestGuarderiaAfegirHabitacio
        '
        Me.btnGestGuarderiaAfegirHabitacio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGestGuarderiaAfegirHabitacio.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegirHabitacio.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegirHabitacio.Location = New System.Drawing.Point(252, 86)
        Me.btnGestGuarderiaAfegirHabitacio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestGuarderiaAfegirHabitacio.Name = "btnGestGuarderiaAfegirHabitacio"
        Me.btnGestGuarderiaAfegirHabitacio.Size = New System.Drawing.Size(126, 55)
        Me.btnGestGuarderiaAfegirHabitacio.TabIndex = 6
        Me.btnGestGuarderiaAfegirHabitacio.Text = "Afegir Habitació"
        Me.btnGestGuarderiaAfegirHabitacio.UseVisualStyleBackColor = False
        '
        'btnGestGuarderiaModificar
        '
        Me.btnGestGuarderiaModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGestGuarderiaModificar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaModificar.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaModificar.Location = New System.Drawing.Point(252, 182)
        Me.btnGestGuarderiaModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestGuarderiaModificar.Name = "btnGestGuarderiaModificar"
        Me.btnGestGuarderiaModificar.Size = New System.Drawing.Size(126, 50)
        Me.btnGestGuarderiaModificar.TabIndex = 8
        Me.btnGestGuarderiaModificar.Text = "Modificar Guarderia"
        Me.btnGestGuarderiaModificar.UseVisualStyleBackColor = False
        '
        'btnGestGuarderiaAfegirTipusHabitacio
        '
        Me.btnGestGuarderiaAfegirTipusHabitacio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGestGuarderiaAfegirTipusHabitacio.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegirTipusHabitacio.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegirTipusHabitacio.Location = New System.Drawing.Point(66, 182)
        Me.btnGestGuarderiaAfegirTipusHabitacio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestGuarderiaAfegirTipusHabitacio.Name = "btnGestGuarderiaAfegirTipusHabitacio"
        Me.btnGestGuarderiaAfegirTipusHabitacio.Size = New System.Drawing.Size(119, 50)
        Me.btnGestGuarderiaAfegirTipusHabitacio.TabIndex = 9
        Me.btnGestGuarderiaAfegirTipusHabitacio.Text = "Afegir Tipus Habitació"
        Me.btnGestGuarderiaAfegirTipusHabitacio.UseVisualStyleBackColor = False
        '
        'btnGestioGuarderiaEnrere
        '
        Me.btnGestioGuarderiaEnrere.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGestioGuarderiaEnrere.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioGuarderiaEnrere.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestioGuarderiaEnrere.Location = New System.Drawing.Point(9, 317)
        Me.btnGestioGuarderiaEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestioGuarderiaEnrere.Name = "btnGestioGuarderiaEnrere"
        Me.btnGestioGuarderiaEnrere.Size = New System.Drawing.Size(108, 38)
        Me.btnGestioGuarderiaEnrere.TabIndex = 10
        Me.btnGestioGuarderiaEnrere.Text = "Enrere"
        Me.btnGestioGuarderiaEnrere.UseVisualStyleBackColor = False
        '
        'btnGestioGuarderiaValoracions
        '
        Me.btnGestioGuarderiaValoracions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGestioGuarderiaValoracions.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioGuarderiaValoracions.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestioGuarderiaValoracions.Location = New System.Drawing.Point(162, 259)
        Me.btnGestioGuarderiaValoracions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestioGuarderiaValoracions.Name = "btnGestioGuarderiaValoracions"
        Me.btnGestioGuarderiaValoracions.Size = New System.Drawing.Size(119, 50)
        Me.btnGestioGuarderiaValoracions.TabIndex = 11
        Me.btnGestioGuarderiaValoracions.Text = "Mostrar valoracions"
        Me.btnGestioGuarderiaValoracions.UseVisualStyleBackColor = False
        '
        'GestioGuarderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(444, 364)
        Me.Controls.Add(Me.btnGestioGuarderiaValoracions)
        Me.Controls.Add(Me.btnGestioGuarderiaEnrere)
        Me.Controls.Add(Me.btnGestGuarderiaAfegirTipusHabitacio)
        Me.Controls.Add(Me.btnGestGuarderiaModificar)
        Me.Controls.Add(Me.btnGestGuarderiaAfegirHabitacio)
        Me.Controls.Add(Me.btnGestGuarderiaAfegCameres)
        Me.Controls.Add(Me.lblGestGuarderiaNomGuarderia)
        Me.Controls.Add(Me.lblGestGuarderiaTitol)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GestioGuarderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pet Hotel Finder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGestGuarderiaTitol As Label
    Friend WithEvents lblGestGuarderiaNomGuarderia As Label
    Friend WithEvents btnGestGuarderiaAfegCameres As Button
    Friend WithEvents btnGestGuarderiaAfegirHabitacio As Button
    Friend WithEvents btnGestGuarderiaModificar As Button
    Friend WithEvents btnGestGuarderiaAfegirTipusHabitacio As Button
    Friend WithEvents btnGestioGuarderiaEnrere As Button
    Friend WithEvents btnGestioGuarderiaValoracions As Button
End Class
