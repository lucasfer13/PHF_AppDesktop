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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GestióGuarderia))
        lblGestGuarderiaTitol = New Label()
        lblGestGuarderiaNomGuarderia = New Label()
        btnGestGuarderiaAfegCameres = New Button()
        btnGestGuarderiaAfegirHabitacio = New Button()
        btnGestGuarderiaModificar = New Button()
        btnGestGuarderiaAfegirTipusHabitacio = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lblGestGuarderiaTitol
        ' 
        lblGestGuarderiaTitol.AutoSize = True
        lblGestGuarderiaTitol.Font = New Font("Sitka Small", 16.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblGestGuarderiaTitol.Location = New Point(12, 37)
        lblGestGuarderiaTitol.Name = "lblGestGuarderiaTitol"
        lblGestGuarderiaTitol.Size = New Size(180, 40)
        lblGestGuarderiaTitol.TabIndex = 1
        lblGestGuarderiaTitol.Text = "Guarderia:" ' 
        ' lblGestGuarderiaNomGuarderia
        ' 
        lblGestGuarderiaNomGuarderia.AutoSize = True
        lblGestGuarderiaNomGuarderia.Font = New Font("Sitka Small", 16.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblGestGuarderiaNomGuarderia.Location = New Point(199, 37)
        lblGestGuarderiaNomGuarderia.Name = "lblGestGuarderiaNomGuarderia"
        lblGestGuarderiaNomGuarderia.Size = New Size(98, 40)
        lblGestGuarderiaNomGuarderia.TabIndex = 2
        lblGestGuarderiaNomGuarderia.Text = "         " ' 
        ' btnGestGuarderiaAfegCameres
        ' 
        btnGestGuarderiaAfegCameres.BackColor = Color.Aquamarine
        btnGestGuarderiaAfegCameres.FlatAppearance.BorderColor = Color.Aquamarine
        btnGestGuarderiaAfegCameres.Location = New Point(79, 132)
        btnGestGuarderiaAfegCameres.Name = "btnGestGuarderiaAfegCameres"
        btnGestGuarderiaAfegCameres.Size = New Size(136, 73)
        btnGestGuarderiaAfegCameres.TabIndex = 5
        btnGestGuarderiaAfegCameres.Text = "Afegir Cámeres"
        btnGestGuarderiaAfegCameres.UseVisualStyleBackColor = False
        ' 
        ' btnGestGuarderiaAfegirHabitacio
        ' 
        btnGestGuarderiaAfegirHabitacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGestGuarderiaAfegirHabitacio.BackColor = Color.Aquamarine
        btnGestGuarderiaAfegirHabitacio.FlatAppearance.BorderColor = Color.Aquamarine
        btnGestGuarderiaAfegirHabitacio.Location = New Point(296, 132)
        btnGestGuarderiaAfegirHabitacio.Name = "btnGestGuarderiaAfegirHabitacio"
        btnGestGuarderiaAfegirHabitacio.Size = New Size(144, 73)
        btnGestGuarderiaAfegirHabitacio.TabIndex = 6
        btnGestGuarderiaAfegirHabitacio.Text = "Afegir Habitació"
        btnGestGuarderiaAfegirHabitacio.UseVisualStyleBackColor = False
        ' 
        ' btnGestGuarderiaModificar
        ' 
        btnGestGuarderiaModificar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGestGuarderiaModificar.BackColor = Color.Aquamarine
        btnGestGuarderiaModificar.FlatAppearance.BorderColor = Color.Aquamarine
        btnGestGuarderiaModificar.Location = New Point(296, 247)
        btnGestGuarderiaModificar.Name = "btnGestGuarderiaModificar"
        btnGestGuarderiaModificar.Size = New Size(144, 67)
        btnGestGuarderiaModificar.TabIndex = 8
        btnGestGuarderiaModificar.Text = "Modificar Guarderia"
        btnGestGuarderiaModificar.UseVisualStyleBackColor = False
        ' 
        ' btnGestGuarderiaAfegirTipusHabitacio
        ' 
        btnGestGuarderiaAfegirTipusHabitacio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnGestGuarderiaAfegirTipusHabitacio.BackColor = Color.Aquamarine
        btnGestGuarderiaAfegirTipusHabitacio.FlatAppearance.BorderColor = Color.Aquamarine
        btnGestGuarderiaAfegirTipusHabitacio.Location = New Point(79, 247)
        btnGestGuarderiaAfegirTipusHabitacio.Name = "btnGestGuarderiaAfegirTipusHabitacio"
        btnGestGuarderiaAfegirTipusHabitacio.Size = New Size(136, 67)
        btnGestGuarderiaAfegirTipusHabitacio.TabIndex = 9
        btnGestGuarderiaAfegirTipusHabitacio.Text = "Afegir Tipus Habitació"
        btnGestGuarderiaAfegirTipusHabitacio.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom
        Button1.BackColor = Color.Aquamarine
        Button1.FlatAppearance.BorderColor = Color.Aquamarine
        Button1.Location = New Point(188, 358)
        Button1.Name = "Button1"
        Button1.Size = New Size(123, 51)
        Button1.TabIndex = 10
        Button1.Text = "Enrere"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' GestióGuarderia
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(511, 433)
        Controls.Add(Button1)
        Controls.Add(btnGestGuarderiaAfegirTipusHabitacio)
        Controls.Add(btnGestGuarderiaModificar)
        Controls.Add(btnGestGuarderiaAfegirHabitacio)
        Controls.Add(btnGestGuarderiaAfegCameres)
        Controls.Add(lblGestGuarderiaNomGuarderia)
        Controls.Add(lblGestGuarderiaTitol)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "GestióGuarderia"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pet Hotel Finder"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGestGuarderiaTitol As Label
    Friend WithEvents lblGestGuarderiaNomGuarderia As Label
    Friend WithEvents btnGestGuarderiaAfegCameres As Button
    Friend WithEvents btnGestGuarderiaAfegirHabitacio As Button
    Friend WithEvents btnGestGuarderiaModificar As Button
    Friend WithEvents btnGestGuarderiaAfegirTipusHabitacio As Button
    Friend WithEvents Button1 As Button
End Class
