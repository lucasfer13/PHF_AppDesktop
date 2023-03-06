<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestióGuarderia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestióGuarderia))
        Me.lblGestGuarderiaTitol = New System.Windows.Forms.Label()
        Me.lblGestGuarderiaNomGuarderia = New System.Windows.Forms.Label()
        Me.btnGestGuarderiaAfegServei = New System.Windows.Forms.Button()
        Me.btnGestGuarderiaAfegCameres = New System.Windows.Forms.Button()
        Me.btnGestGuarderiaAfegirHabitacio = New System.Windows.Forms.Button()
        Me.pcbGestGuarderiaUsuari = New System.Windows.Forms.PictureBox()
        Me.btnGestGuarderiaModificar = New System.Windows.Forms.Button()
        Me.btnGestGuarderiaAfegirTipusHabitacio = New System.Windows.Forms.Button()
        CType(Me.pcbGestGuarderiaUsuari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGestGuarderiaTitol
        '
        Me.lblGestGuarderiaTitol.AutoSize = True
        Me.lblGestGuarderiaTitol.Font = New System.Drawing.Font("Sitka Small", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGestGuarderiaTitol.Location = New System.Drawing.Point(12, 37)
        Me.lblGestGuarderiaTitol.Name = "lblGestGuarderiaTitol"
        Me.lblGestGuarderiaTitol.Size = New System.Drawing.Size(181, 42)
        Me.lblGestGuarderiaTitol.TabIndex = 1
        Me.lblGestGuarderiaTitol.Text = "Guarderia:"
        '
        'lblGestGuarderiaNomGuarderia
        '
        Me.lblGestGuarderiaNomGuarderia.AutoSize = True
        Me.lblGestGuarderiaNomGuarderia.Font = New System.Drawing.Font("Sitka Small", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGestGuarderiaNomGuarderia.Location = New System.Drawing.Point(199, 37)
        Me.lblGestGuarderiaNomGuarderia.Name = "lblGestGuarderiaNomGuarderia"
        Me.lblGestGuarderiaNomGuarderia.Size = New System.Drawing.Size(99, 42)
        Me.lblGestGuarderiaNomGuarderia.TabIndex = 2
        Me.lblGestGuarderiaNomGuarderia.Text = "         "
        '
        'btnGestGuarderiaAfegServei
        '
        Me.btnGestGuarderiaAfegServei.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegServei.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegServei.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestGuarderiaAfegServei.Location = New System.Drawing.Point(70, 200)
        Me.btnGestGuarderiaAfegServei.Name = "btnGestGuarderiaAfegServei"
        Me.btnGestGuarderiaAfegServei.Size = New System.Drawing.Size(123, 51)
        Me.btnGestGuarderiaAfegServei.TabIndex = 4
        Me.btnGestGuarderiaAfegServei.Text = "Afegir Servei"
        Me.btnGestGuarderiaAfegServei.UseVisualStyleBackColor = False
        '
        'btnGestGuarderiaAfegCameres
        '
        Me.btnGestGuarderiaAfegCameres.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegCameres.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegCameres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestGuarderiaAfegCameres.Location = New System.Drawing.Point(300, 200)
        Me.btnGestGuarderiaAfegCameres.Name = "btnGestGuarderiaAfegCameres"
        Me.btnGestGuarderiaAfegCameres.Size = New System.Drawing.Size(123, 51)
        Me.btnGestGuarderiaAfegCameres.TabIndex = 5
        Me.btnGestGuarderiaAfegCameres.Text = "Afegir Cámeres"
        Me.btnGestGuarderiaAfegCameres.UseVisualStyleBackColor = False
        '
        'btnGestGuarderiaAfegirHabitacio
        '
        Me.btnGestGuarderiaAfegirHabitacio.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegirHabitacio.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegirHabitacio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestGuarderiaAfegirHabitacio.Location = New System.Drawing.Point(300, 318)
        Me.btnGestGuarderiaAfegirHabitacio.Name = "btnGestGuarderiaAfegirHabitacio"
        Me.btnGestGuarderiaAfegirHabitacio.Size = New System.Drawing.Size(123, 51)
        Me.btnGestGuarderiaAfegirHabitacio.TabIndex = 6
        Me.btnGestGuarderiaAfegirHabitacio.Text = "Afegir Habitació"
        Me.btnGestGuarderiaAfegirHabitacio.UseVisualStyleBackColor = False
        '
        'pcbGestGuarderiaUsuari
        '
        Me.pcbGestGuarderiaUsuari.Image = Global.PHF_Gestion.My.Resources.Resources.pngegg
        Me.pcbGestGuarderiaUsuari.Location = New System.Drawing.Point(717, 17)
        Me.pcbGestGuarderiaUsuari.Name = "pcbGestGuarderiaUsuari"
        Me.pcbGestGuarderiaUsuari.Size = New System.Drawing.Size(71, 62)
        Me.pcbGestGuarderiaUsuari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbGestGuarderiaUsuari.TabIndex = 7
        Me.pcbGestGuarderiaUsuari.TabStop = False
        '
        'btnGestGuarderiaModificar
        '
        Me.btnGestGuarderiaModificar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaModificar.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestGuarderiaModificar.Location = New System.Drawing.Point(534, 265)
        Me.btnGestGuarderiaModificar.Name = "btnGestGuarderiaModificar"
        Me.btnGestGuarderiaModificar.Size = New System.Drawing.Size(123, 51)
        Me.btnGestGuarderiaModificar.TabIndex = 8
        Me.btnGestGuarderiaModificar.Text = "Modificar Guarderia"
        Me.btnGestGuarderiaModificar.UseVisualStyleBackColor = False
        '
        'btnGestGuarderiaAfegirTipusHabitacio
        '
        Me.btnGestGuarderiaAfegirTipusHabitacio.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegirTipusHabitacio.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnGestGuarderiaAfegirTipusHabitacio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestGuarderiaAfegirTipusHabitacio.Location = New System.Drawing.Point(70, 318)
        Me.btnGestGuarderiaAfegirTipusHabitacio.Name = "btnGestGuarderiaAfegirTipusHabitacio"
        Me.btnGestGuarderiaAfegirTipusHabitacio.Size = New System.Drawing.Size(123, 51)
        Me.btnGestGuarderiaAfegirTipusHabitacio.TabIndex = 9
        Me.btnGestGuarderiaAfegirTipusHabitacio.Text = "Afegir Tipus Habitació"
        Me.btnGestGuarderiaAfegirTipusHabitacio.UseVisualStyleBackColor = False
        '
        'GestióGuarderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGestGuarderiaAfegirTipusHabitacio)
        Me.Controls.Add(Me.btnGestGuarderiaModificar)
        Me.Controls.Add(Me.pcbGestGuarderiaUsuari)
        Me.Controls.Add(Me.btnGestGuarderiaAfegirHabitacio)
        Me.Controls.Add(Me.btnGestGuarderiaAfegCameres)
        Me.Controls.Add(Me.btnGestGuarderiaAfegServei)
        Me.Controls.Add(Me.lblGestGuarderiaNomGuarderia)
        Me.Controls.Add(Me.lblGestGuarderiaTitol)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestióGuarderia"
        Me.Text = "Pet Hotel Finder"
        CType(Me.pcbGestGuarderiaUsuari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGestGuarderiaTitol As Label
    Friend WithEvents lblGestGuarderiaNomGuarderia As Label
    Friend WithEvents btnGestGuarderiaAfegServei As Button
    Friend WithEvents btnGestGuarderiaAfegCameres As Button
    Friend WithEvents btnGestGuarderiaAfegirHabitacio As Button
    Friend WithEvents pcbGestGuarderiaUsuari As PictureBox
    Friend WithEvents btnGestGuarderiaModificar As Button
    Friend WithEvents btnGestGuarderiaAfegirTipusHabitacio As Button
End Class
