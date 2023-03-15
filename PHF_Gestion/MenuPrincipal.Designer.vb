<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.btnMenuPrinGestioGuarderies = New System.Windows.Forms.Button()
        Me.pcbMenuPrinLogo = New System.Windows.Forms.PictureBox()
        Me.btnMenuPrinGestioServeis = New System.Windows.Forms.Button()
        Me.btnMenuPrinGestioAnimals = New System.Windows.Forms.Button()
        Me.pcbMenuPrincipalUsuari = New System.Windows.Forms.PictureBox()
        Me.btnMenuPrincipalGestioUsuaris = New System.Windows.Forms.Button()
        Me.btnMenuPrincipalSortir = New System.Windows.Forms.Button()
        CType(Me.pcbMenuPrinLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMenuPrincipalUsuari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenuPrinGestioGuarderies
        '
        Me.btnMenuPrinGestioGuarderies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMenuPrinGestioGuarderies.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioGuarderies.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioGuarderies.Location = New System.Drawing.Point(210, 125)
        Me.btnMenuPrinGestioGuarderies.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuPrinGestioGuarderies.Name = "btnMenuPrinGestioGuarderies"
        Me.btnMenuPrinGestioGuarderies.Size = New System.Drawing.Size(110, 41)
        Me.btnMenuPrinGestioGuarderies.TabIndex = 1
        Me.btnMenuPrinGestioGuarderies.Text = "Gestió de guarderies"
        Me.btnMenuPrinGestioGuarderies.UseVisualStyleBackColor = False
        '
        'pcbMenuPrinLogo
        '
        Me.pcbMenuPrinLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pcbMenuPrinLogo.Image = CType(resources.GetObject("pcbMenuPrinLogo.Image"), System.Drawing.Image)
        Me.pcbMenuPrinLogo.Location = New System.Drawing.Point(273, 9)
        Me.pcbMenuPrinLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbMenuPrinLogo.Name = "pcbMenuPrinLogo"
        Me.pcbMenuPrinLogo.Size = New System.Drawing.Size(134, 103)
        Me.pcbMenuPrinLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbMenuPrinLogo.TabIndex = 2
        Me.pcbMenuPrinLogo.TabStop = False
        '
        'btnMenuPrinGestioServeis
        '
        Me.btnMenuPrinGestioServeis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMenuPrinGestioServeis.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioServeis.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioServeis.Location = New System.Drawing.Point(358, 125)
        Me.btnMenuPrinGestioServeis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuPrinGestioServeis.Name = "btnMenuPrinGestioServeis"
        Me.btnMenuPrinGestioServeis.Size = New System.Drawing.Size(110, 41)
        Me.btnMenuPrinGestioServeis.TabIndex = 3
        Me.btnMenuPrinGestioServeis.Text = "Gestió de serveis"
        Me.btnMenuPrinGestioServeis.UseVisualStyleBackColor = False
        '
        'btnMenuPrinGestioAnimals
        '
        Me.btnMenuPrinGestioAnimals.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMenuPrinGestioAnimals.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioAnimals.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrinGestioAnimals.Location = New System.Drawing.Point(210, 196)
        Me.btnMenuPrinGestioAnimals.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuPrinGestioAnimals.Name = "btnMenuPrinGestioAnimals"
        Me.btnMenuPrinGestioAnimals.Size = New System.Drawing.Size(110, 41)
        Me.btnMenuPrinGestioAnimals.TabIndex = 4
        Me.btnMenuPrinGestioAnimals.Text = "Gestió d'animals"
        Me.btnMenuPrinGestioAnimals.UseVisualStyleBackColor = False
        '
        'pcbMenuPrincipalUsuari
        '
        Me.pcbMenuPrincipalUsuari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbMenuPrincipalUsuari.Image = Global.PHF_Gestion.My.Resources.Resources.pngegg
        Me.pcbMenuPrincipalUsuari.Location = New System.Drawing.Point(612, 9)
        Me.pcbMenuPrincipalUsuari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbMenuPrincipalUsuari.Name = "pcbMenuPrincipalUsuari"
        Me.pcbMenuPrincipalUsuari.Size = New System.Drawing.Size(62, 46)
        Me.pcbMenuPrincipalUsuari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbMenuPrincipalUsuari.TabIndex = 6
        Me.pcbMenuPrincipalUsuari.TabStop = False
        '
        'btnMenuPrincipalGestioUsuaris
        '
        Me.btnMenuPrincipalGestioUsuaris.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMenuPrincipalGestioUsuaris.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrincipalGestioUsuaris.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrincipalGestioUsuaris.Location = New System.Drawing.Point(358, 196)
        Me.btnMenuPrincipalGestioUsuaris.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuPrincipalGestioUsuaris.Name = "btnMenuPrincipalGestioUsuaris"
        Me.btnMenuPrincipalGestioUsuaris.Size = New System.Drawing.Size(110, 41)
        Me.btnMenuPrincipalGestioUsuaris.TabIndex = 7
        Me.btnMenuPrincipalGestioUsuaris.Text = "Gestió usuaris"
        Me.btnMenuPrincipalGestioUsuaris.UseVisualStyleBackColor = False
        '
        'btnMenuPrincipalSortir
        '
        Me.btnMenuPrincipalSortir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnMenuPrincipalSortir.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrincipalSortir.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuPrincipalSortir.Location = New System.Drawing.Point(288, 264)
        Me.btnMenuPrincipalSortir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuPrincipalSortir.Name = "btnMenuPrincipalSortir"
        Me.btnMenuPrincipalSortir.Size = New System.Drawing.Size(110, 41)
        Me.btnMenuPrincipalSortir.TabIndex = 8
        Me.btnMenuPrincipalSortir.Text = "Sortir"
        Me.btnMenuPrincipalSortir.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(697, 320)
        Me.Controls.Add(Me.btnMenuPrincipalSortir)
        Me.Controls.Add(Me.btnMenuPrincipalGestioUsuaris)
        Me.Controls.Add(Me.pcbMenuPrincipalUsuari)
        Me.Controls.Add(Me.btnMenuPrinGestioAnimals)
        Me.Controls.Add(Me.btnMenuPrinGestioServeis)
        Me.Controls.Add(Me.pcbMenuPrinLogo)
        Me.Controls.Add(Me.btnMenuPrinGestioGuarderies)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(713, 359)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pet Hotel Finder Gestion"
        CType(Me.pcbMenuPrinLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMenuPrincipalUsuari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMenuPrinGestioGuarderies As Button
    Friend WithEvents pcbMenuPrinLogo As PictureBox
    Friend WithEvents btnMenuPrinGestioServeis As Button
    Friend WithEvents btnMenuPrinGestioAnimals As Button
    Friend WithEvents pcbMenuPrincipalUsuari As PictureBox
    Friend WithEvents btnMenuPrincipalGestioUsuaris As Button
    Friend WithEvents btnMenuPrincipalSortir As Button
End Class
