﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        btnMenuPrinGestioGuarderies = New Button()
        pcbMenuPrinLogo = New PictureBox()
        btnMenuPrinGestioServeis = New Button()
        btnMenuPrinGestioAnimals = New Button()
        pcbMenuPrincipalUsuari = New PictureBox()
        btnMenuPrincipalGestioUsuaris = New Button()
        btnMenuPrincipalSortir = New Button()
        CType(pcbMenuPrinLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcbMenuPrincipalUsuari, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnMenuPrinGestioGuarderies
        ' 
        btnMenuPrinGestioGuarderies.Anchor = AnchorStyles.None
        btnMenuPrinGestioGuarderies.BackColor = Color.Aquamarine
        btnMenuPrinGestioGuarderies.FlatAppearance.BorderColor = Color.Aquamarine
        btnMenuPrinGestioGuarderies.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMenuPrinGestioGuarderies.Location = New Point(209, 146)
        btnMenuPrinGestioGuarderies.Margin = New Padding(3, 2, 3, 2)
        btnMenuPrinGestioGuarderies.Name = "btnMenuPrinGestioGuarderies"
        btnMenuPrinGestioGuarderies.Size = New Size(149, 87)
        btnMenuPrinGestioGuarderies.TabIndex = 1
        btnMenuPrinGestioGuarderies.Text = "Gestió de guarderies"
        btnMenuPrinGestioGuarderies.UseVisualStyleBackColor = False
        ' 
        ' pcbMenuPrinLogo
        ' 
        pcbMenuPrinLogo.Anchor = AnchorStyles.Top
        pcbMenuPrinLogo.Image = CType(resources.GetObject("pcbMenuPrinLogo.Image"), Image)
        pcbMenuPrinLogo.Location = New Point(289, 9)
        pcbMenuPrinLogo.Margin = New Padding(3, 2, 3, 2)
        pcbMenuPrinLogo.Name = "pcbMenuPrinLogo"
        pcbMenuPrinLogo.Size = New Size(134, 103)
        pcbMenuPrinLogo.SizeMode = PictureBoxSizeMode.Zoom
        pcbMenuPrinLogo.TabIndex = 2
        pcbMenuPrinLogo.TabStop = False
        ' 
        ' btnMenuPrinGestioServeis
        ' 
        btnMenuPrinGestioServeis.Anchor = AnchorStyles.None
        btnMenuPrinGestioServeis.BackColor = Color.Aquamarine
        btnMenuPrinGestioServeis.FlatAppearance.BorderColor = Color.Aquamarine
        btnMenuPrinGestioServeis.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMenuPrinGestioServeis.Location = New Point(374, 146)
        btnMenuPrinGestioServeis.Margin = New Padding(3, 2, 3, 2)
        btnMenuPrinGestioServeis.Name = "btnMenuPrinGestioServeis"
        btnMenuPrinGestioServeis.Size = New Size(149, 87)
        btnMenuPrinGestioServeis.TabIndex = 3
        btnMenuPrinGestioServeis.Text = "Gestió de serveis"
        btnMenuPrinGestioServeis.UseVisualStyleBackColor = False
        ' 
        ' btnMenuPrinGestioAnimals
        ' 
        btnMenuPrinGestioAnimals.Anchor = AnchorStyles.None
        btnMenuPrinGestioAnimals.BackColor = Color.Aquamarine
        btnMenuPrinGestioAnimals.FlatAppearance.BorderColor = Color.Aquamarine
        btnMenuPrinGestioAnimals.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMenuPrinGestioAnimals.Location = New Point(209, 253)
        btnMenuPrinGestioAnimals.Margin = New Padding(3, 2, 3, 2)
        btnMenuPrinGestioAnimals.Name = "btnMenuPrinGestioAnimals"
        btnMenuPrinGestioAnimals.Size = New Size(149, 87)
        btnMenuPrinGestioAnimals.TabIndex = 4
        btnMenuPrinGestioAnimals.Text = "Gestió d'animals"
        btnMenuPrinGestioAnimals.UseVisualStyleBackColor = False
        ' 
        ' pcbMenuPrincipalUsuari
        ' 
        pcbMenuPrincipalUsuari.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pcbMenuPrincipalUsuari.Cursor = Cursors.Hand
        pcbMenuPrincipalUsuari.Image = My.Resources.Resources.pngegg
        pcbMenuPrincipalUsuari.Location = New Point(643, 9)
        pcbMenuPrincipalUsuari.Margin = New Padding(3, 2, 3, 2)
        pcbMenuPrincipalUsuari.Name = "pcbMenuPrincipalUsuari"
        pcbMenuPrincipalUsuari.Size = New Size(62, 46)
        pcbMenuPrincipalUsuari.SizeMode = PictureBoxSizeMode.Zoom
        pcbMenuPrincipalUsuari.TabIndex = 6
        pcbMenuPrincipalUsuari.TabStop = False
        ' 
        ' btnMenuPrincipalGestioUsuaris
        ' 
        btnMenuPrincipalGestioUsuaris.Anchor = AnchorStyles.None
        btnMenuPrincipalGestioUsuaris.BackColor = Color.Aquamarine
        btnMenuPrincipalGestioUsuaris.FlatAppearance.BorderColor = Color.Aquamarine
        btnMenuPrincipalGestioUsuaris.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMenuPrincipalGestioUsuaris.Location = New Point(374, 253)
        btnMenuPrincipalGestioUsuaris.Margin = New Padding(3, 2, 3, 2)
        btnMenuPrincipalGestioUsuaris.Name = "btnMenuPrincipalGestioUsuaris"
        btnMenuPrincipalGestioUsuaris.Size = New Size(149, 87)
        btnMenuPrincipalGestioUsuaris.TabIndex = 7
        btnMenuPrincipalGestioUsuaris.Text = "Gestió usuaris"
        btnMenuPrincipalGestioUsuaris.UseVisualStyleBackColor = False
        ' 
        ' btnMenuPrincipalSortir
        ' 
        btnMenuPrincipalSortir.Anchor = AnchorStyles.Bottom
        btnMenuPrincipalSortir.BackColor = Color.Aquamarine
        btnMenuPrincipalSortir.FlatAppearance.BorderColor = Color.Aquamarine
        btnMenuPrincipalSortir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMenuPrincipalSortir.Location = New Point(304, 378)
        btnMenuPrincipalSortir.Margin = New Padding(3, 2, 3, 2)
        btnMenuPrincipalSortir.Name = "btnMenuPrincipalSortir"
        btnMenuPrincipalSortir.Size = New Size(110, 41)
        btnMenuPrincipalSortir.TabIndex = 8
        btnMenuPrincipalSortir.Text = "Sortir"
        btnMenuPrincipalSortir.UseVisualStyleBackColor = False
        ' 
        ' MenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.LightSteelBlue
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(728, 434)
        Controls.Add(btnMenuPrincipalSortir)
        Controls.Add(btnMenuPrincipalGestioUsuaris)
        Controls.Add(pcbMenuPrincipalUsuari)
        Controls.Add(btnMenuPrinGestioAnimals)
        Controls.Add(btnMenuPrinGestioServeis)
        Controls.Add(pcbMenuPrinLogo)
        Controls.Add(btnMenuPrinGestioGuarderies)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(746, 481)
        Name = "MenuPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pet Hotel Finder Gestion"
        CType(pcbMenuPrinLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(pcbMenuPrincipalUsuari, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnMenuPrinGestioGuarderies As Button
    Friend WithEvents pcbMenuPrinLogo As PictureBox
    Friend WithEvents btnMenuPrinGestioServeis As Button
    Friend WithEvents btnMenuPrinGestioAnimals As Button
    Friend WithEvents pcbMenuPrincipalUsuari As PictureBox
    Friend WithEvents btnMenuPrincipalGestioUsuaris As Button
    Friend WithEvents btnMenuPrincipalSortir As Button
End Class
