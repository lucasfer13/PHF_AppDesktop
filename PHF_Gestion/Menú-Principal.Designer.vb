<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menú_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menú_Principal))
        Me.btnMenuPrinGestioGuarderies = New System.Windows.Forms.Button()
        Me.pcbMenuPrinLogo = New System.Windows.Forms.PictureBox()
        Me.btnMenuPrinGestioServeis = New System.Windows.Forms.Button()
        Me.btnMenuPrinGestioAnimals = New System.Windows.Forms.Button()
        Me.pcbMenuGestGuarderiesUsuari = New System.Windows.Forms.PictureBox()
        CType(Me.pcbMenuPrinLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMenuGestGuarderiesUsuari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenuPrinGestioGuarderies
        '
        Me.btnMenuPrinGestioGuarderies.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioGuarderies.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioGuarderies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrinGestioGuarderies.Location = New System.Drawing.Point(316, 177)
        Me.btnMenuPrinGestioGuarderies.Name = "btnMenuPrinGestioGuarderies"
        Me.btnMenuPrinGestioGuarderies.Size = New System.Drawing.Size(126, 55)
        Me.btnMenuPrinGestioGuarderies.TabIndex = 1
        Me.btnMenuPrinGestioGuarderies.Text = "Gestió de guarderies"
        Me.btnMenuPrinGestioGuarderies.UseVisualStyleBackColor = False
        '
        'pcbMenuPrinLogo
        '
        Me.pcbMenuPrinLogo.Image = CType(resources.GetObject("pcbMenuPrinLogo.Image"), System.Drawing.Image)
        Me.pcbMenuPrinLogo.Location = New System.Drawing.Point(294, 12)
        Me.pcbMenuPrinLogo.Name = "pcbMenuPrinLogo"
        Me.pcbMenuPrinLogo.Size = New System.Drawing.Size(168, 159)
        Me.pcbMenuPrinLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbMenuPrinLogo.TabIndex = 2
        Me.pcbMenuPrinLogo.TabStop = False
        '
        'btnMenuPrinGestioServeis
        '
        Me.btnMenuPrinGestioServeis.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioServeis.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioServeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrinGestioServeis.Location = New System.Drawing.Point(316, 257)
        Me.btnMenuPrinGestioServeis.Name = "btnMenuPrinGestioServeis"
        Me.btnMenuPrinGestioServeis.Size = New System.Drawing.Size(126, 55)
        Me.btnMenuPrinGestioServeis.TabIndex = 3
        Me.btnMenuPrinGestioServeis.Text = "Gestió de serveis"
        Me.btnMenuPrinGestioServeis.UseVisualStyleBackColor = False
        '
        'btnMenuPrinGestioAnimals
        '
        Me.btnMenuPrinGestioAnimals.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioAnimals.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrinGestioAnimals.Location = New System.Drawing.Point(316, 337)
        Me.btnMenuPrinGestioAnimals.Name = "btnMenuPrinGestioAnimals"
        Me.btnMenuPrinGestioAnimals.Size = New System.Drawing.Size(126, 55)
        Me.btnMenuPrinGestioAnimals.TabIndex = 4
        Me.btnMenuPrinGestioAnimals.Text = "Gestió d'animals"
        Me.btnMenuPrinGestioAnimals.UseVisualStyleBackColor = False
        '
        'pcbMenuGestGuarderiesUsuari
        '
        Me.pcbMenuGestGuarderiesUsuari.Image = Global.PHF_Gestion.My.Resources.Resources.pngegg
        Me.pcbMenuGestGuarderiesUsuari.Location = New System.Drawing.Point(700, 12)
        Me.pcbMenuGestGuarderiesUsuari.Name = "pcbMenuGestGuarderiesUsuari"
        Me.pcbMenuGestGuarderiesUsuari.Size = New System.Drawing.Size(71, 62)
        Me.pcbMenuGestGuarderiesUsuari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbMenuGestGuarderiesUsuari.TabIndex = 6
        Me.pcbMenuGestGuarderiesUsuari.TabStop = False
        '
        'Menú_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(795, 419)
        Me.Controls.Add(Me.pcbMenuGestGuarderiesUsuari)
        Me.Controls.Add(Me.btnMenuPrinGestioAnimals)
        Me.Controls.Add(Me.btnMenuPrinGestioServeis)
        Me.Controls.Add(Me.pcbMenuPrinLogo)
        Me.Controls.Add(Me.btnMenuPrinGestioGuarderies)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(813, 466)
        Me.MinimumSize = New System.Drawing.Size(813, 466)
        Me.Name = "Menú_Principal"
        Me.Text = "Pet Hotel Finder"
        CType(Me.pcbMenuPrinLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMenuGestGuarderiesUsuari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMenuPrinGestioGuarderies As Button
    Friend WithEvents pcbMenuPrinLogo As PictureBox
    Friend WithEvents btnMenuPrinGestioServeis As Button
    Friend WithEvents btnMenuPrinGestioAnimals As Button
    Friend WithEvents pcbMenuGestGuarderiesUsuari As PictureBox
End Class
