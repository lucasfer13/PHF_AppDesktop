<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DadesUsuari
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DadesUsuari))
        pcbDadesUsuariFotoPerfil = New PictureBox()
        btnDadesUsuariModificar = New Button()
        btnDadesUsuariGuardar = New Button()
        lblDadesUsuariTitol = New Label()
        btnDadesUsuariSeleccionarImatge = New Button()
        lblDadesUsuariNom = New Label()
        lblDadesUsuariCognom1 = New Label()
        lblDadesUsuariCognom2 = New Label()
        lblDadesUsuariNomUsuari = New Label()
        txtDadesUsuariTelefon = New TextBox()
        lblDadesUsuariContrasenya = New Label()
        txtDadesUsuariCorreu = New TextBox()
        lblDadesUsuariDI = New Label()
        lblDadesUsuariCorreu = New Label()
        txtDadesUsuariNomUsuari = New TextBox()
        lblDadesUsuariTelefon = New Label()
        txtDadesUsuariDI = New TextBox()
        txtDadesUsuariCognom2 = New TextBox()
        txtDadesUsuariNom = New TextBox()
        txtDadesUsuariCognom1 = New TextBox()
        btnDadesUsuariEnrere = New Button()
        btnDadesUsuariTencarSessio = New Button()
        btnDadesUsuariChangePass = New Button()
        erpDadesUsuariErrors = New ErrorProvider(components)
        CType(pcbDadesUsuariFotoPerfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(erpDadesUsuariErrors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pcbDadesUsuariFotoPerfil
        ' 
        pcbDadesUsuariFotoPerfil.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pcbDadesUsuariFotoPerfil.BackColor = SystemColors.Control
        pcbDadesUsuariFotoPerfil.Location = New Point(651, 41)
        pcbDadesUsuariFotoPerfil.Name = "pcbDadesUsuariFotoPerfil"
        pcbDadesUsuariFotoPerfil.Size = New Size(156, 130)
        pcbDadesUsuariFotoPerfil.TabIndex = 0
        pcbDadesUsuariFotoPerfil.TabStop = False
        ' 
        ' btnDadesUsuariModificar
        ' 
        btnDadesUsuariModificar.BackColor = Color.Aquamarine
        btnDadesUsuariModificar.Location = New Point(180, 41)
        btnDadesUsuariModificar.Name = "btnDadesUsuariModificar"
        btnDadesUsuariModificar.Size = New Size(94, 34)
        btnDadesUsuariModificar.TabIndex = 1
        btnDadesUsuariModificar.Text = "Modificar"
        btnDadesUsuariModificar.UseVisualStyleBackColor = False
        ' 
        ' btnDadesUsuariGuardar
        ' 
        btnDadesUsuariGuardar.BackColor = Color.Aquamarine
        btnDadesUsuariGuardar.Enabled = False
        btnDadesUsuariGuardar.Location = New Point(297, 41)
        btnDadesUsuariGuardar.Name = "btnDadesUsuariGuardar"
        btnDadesUsuariGuardar.Size = New Size(94, 34)
        btnDadesUsuariGuardar.TabIndex = 2
        btnDadesUsuariGuardar.Text = "Guardar"
        btnDadesUsuariGuardar.UseVisualStyleBackColor = False
        ' 
        ' lblDadesUsuariTitol
        ' 
        lblDadesUsuariTitol.AutoSize = True
        lblDadesUsuariTitol.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDadesUsuariTitol.Location = New Point(32, 47)
        lblDadesUsuariTitol.Name = "lblDadesUsuariTitol"
        lblDadesUsuariTitol.Size = New Size(126, 28)
        lblDadesUsuariTitol.TabIndex = 3
        lblDadesUsuariTitol.Text = "Dades Usuari"' 
        ' btnDadesUsuariSeleccionarImatge
        ' 
        btnDadesUsuariSeleccionarImatge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDadesUsuariSeleccionarImatge.BackColor = Color.Aquamarine
        btnDadesUsuariSeleccionarImatge.Location = New Point(651, 189)
        btnDadesUsuariSeleccionarImatge.Name = "btnDadesUsuariSeleccionarImatge"
        btnDadesUsuariSeleccionarImatge.Size = New Size(156, 43)
        btnDadesUsuariSeleccionarImatge.TabIndex = 4
        btnDadesUsuariSeleccionarImatge.Text = "Imatge Perfil"
        btnDadesUsuariSeleccionarImatge.UseVisualStyleBackColor = False
        ' 
        ' lblDadesUsuariNom
        ' 
        lblDadesUsuariNom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDadesUsuariNom.AutoSize = True
        lblDadesUsuariNom.Location = New Point(55, 108)
        lblDadesUsuariNom.Name = "lblDadesUsuariNom"
        lblDadesUsuariNom.Size = New Size(45, 20)
        lblDadesUsuariNom.TabIndex = 22
        lblDadesUsuariNom.Text = "Nom:"' 
        ' lblDadesUsuariCognom1
        ' 
        lblDadesUsuariCognom1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDadesUsuariCognom1.AutoSize = True
        lblDadesUsuariCognom1.Location = New Point(55, 146)
        lblDadesUsuariCognom1.Name = "lblDadesUsuariCognom1"
        lblDadesUsuariCognom1.Size = New Size(81, 20)
        lblDadesUsuariCognom1.TabIndex = 23
        lblDadesUsuariCognom1.Text = "Cognom 1:"' 
        ' lblDadesUsuariCognom2
        ' 
        lblDadesUsuariCognom2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDadesUsuariCognom2.AutoSize = True
        lblDadesUsuariCognom2.Location = New Point(55, 184)
        lblDadesUsuariCognom2.Name = "lblDadesUsuariCognom2"
        lblDadesUsuariCognom2.Size = New Size(81, 20)
        lblDadesUsuariCognom2.TabIndex = 24
        lblDadesUsuariCognom2.Text = "Cognom 2:"' 
        ' lblDadesUsuariNomUsuari
        ' 
        lblDadesUsuariNomUsuari.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDadesUsuariNomUsuari.AutoSize = True
        lblDadesUsuariNomUsuari.Location = New Point(55, 260)
        lblDadesUsuariNomUsuari.Name = "lblDadesUsuariNomUsuari"
        lblDadesUsuariNomUsuari.Size = New Size(88, 20)
        lblDadesUsuariNomUsuari.TabIndex = 25
        lblDadesUsuariNomUsuari.Text = "Nom usuari:"' 
        ' txtDadesUsuariTelefon
        ' 
        txtDadesUsuariTelefon.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDadesUsuariTelefon.Enabled = False
        txtDadesUsuariTelefon.Location = New Point(180, 372)
        txtDadesUsuariTelefon.Name = "txtDadesUsuariTelefon"
        txtDadesUsuariTelefon.Size = New Size(393, 27)
        txtDadesUsuariTelefon.TabIndex = 37
        ' 
        ' lblDadesUsuariContrasenya
        ' 
        lblDadesUsuariContrasenya.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDadesUsuariContrasenya.AutoSize = True
        lblDadesUsuariContrasenya.Location = New Point(55, 298)
        lblDadesUsuariContrasenya.Name = "lblDadesUsuariContrasenya"
        lblDadesUsuariContrasenya.Size = New Size(93, 20)
        lblDadesUsuariContrasenya.TabIndex = 26
        lblDadesUsuariContrasenya.Text = "Contrasenya:"' 
        ' txtDadesUsuariCorreu
        ' 
        txtDadesUsuariCorreu.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDadesUsuariCorreu.Enabled = False
        txtDadesUsuariCorreu.Location = New Point(180, 336)
        txtDadesUsuariCorreu.Name = "txtDadesUsuariCorreu"
        txtDadesUsuariCorreu.Size = New Size(393, 27)
        txtDadesUsuariCorreu.TabIndex = 36
        ' 
        ' lblDadesUsuariDI
        ' 
        lblDadesUsuariDI.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDadesUsuariDI.AutoSize = True
        lblDadesUsuariDI.Location = New Point(55, 222)
        lblDadesUsuariDI.Name = "lblDadesUsuariDI"
        lblDadesUsuariDI.Size = New Size(27, 20)
        lblDadesUsuariDI.TabIndex = 27
        lblDadesUsuariDI.Text = "DI:"' 
        ' lblDadesUsuariCorreu
        ' 
        lblDadesUsuariCorreu.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDadesUsuariCorreu.AutoSize = True
        lblDadesUsuariCorreu.Location = New Point(55, 336)
        lblDadesUsuariCorreu.Name = "lblDadesUsuariCorreu"
        lblDadesUsuariCorreu.Size = New Size(56, 20)
        lblDadesUsuariCorreu.TabIndex = 28
        lblDadesUsuariCorreu.Text = "Correu:"' 
        ' txtDadesUsuariNomUsuari
        ' 
        txtDadesUsuariNomUsuari.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDadesUsuariNomUsuari.Enabled = False
        txtDadesUsuariNomUsuari.Location = New Point(180, 260)
        txtDadesUsuariNomUsuari.Name = "txtDadesUsuariNomUsuari"
        txtDadesUsuariNomUsuari.Size = New Size(393, 27)
        txtDadesUsuariNomUsuari.TabIndex = 34
        ' 
        ' lblDadesUsuariTelefon
        ' 
        lblDadesUsuariTelefon.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDadesUsuariTelefon.AutoSize = True
        lblDadesUsuariTelefon.Location = New Point(55, 374)
        lblDadesUsuariTelefon.Name = "lblDadesUsuariTelefon"
        lblDadesUsuariTelefon.Size = New Size(61, 20)
        lblDadesUsuariTelefon.TabIndex = 29
        lblDadesUsuariTelefon.Text = "Telefón:"' 
        ' txtDadesUsuariDI
        ' 
        txtDadesUsuariDI.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDadesUsuariDI.Enabled = False
        txtDadesUsuariDI.Location = New Point(180, 219)
        txtDadesUsuariDI.Name = "txtDadesUsuariDI"
        txtDadesUsuariDI.Size = New Size(393, 27)
        txtDadesUsuariDI.TabIndex = 33
        ' 
        ' txtDadesUsuariCognom2
        ' 
        txtDadesUsuariCognom2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDadesUsuariCognom2.Enabled = False
        txtDadesUsuariCognom2.Location = New Point(180, 184)
        txtDadesUsuariCognom2.Name = "txtDadesUsuariCognom2"
        txtDadesUsuariCognom2.Size = New Size(393, 27)
        txtDadesUsuariCognom2.TabIndex = 32
        ' 
        ' txtDadesUsuariNom
        ' 
        txtDadesUsuariNom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDadesUsuariNom.Enabled = False
        txtDadesUsuariNom.Location = New Point(180, 108)
        txtDadesUsuariNom.Name = "txtDadesUsuariNom"
        txtDadesUsuariNom.Size = New Size(393, 27)
        txtDadesUsuariNom.TabIndex = 30
        ' 
        ' txtDadesUsuariCognom1
        ' 
        txtDadesUsuariCognom1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDadesUsuariCognom1.Enabled = False
        txtDadesUsuariCognom1.Location = New Point(180, 146)
        txtDadesUsuariCognom1.Name = "txtDadesUsuariCognom1"
        txtDadesUsuariCognom1.Size = New Size(393, 27)
        txtDadesUsuariCognom1.TabIndex = 31
        ' 
        ' btnDadesUsuariEnrere
        ' 
        btnDadesUsuariEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnDadesUsuariEnrere.BackColor = Color.Aquamarine
        btnDadesUsuariEnrere.Location = New Point(12, 458)
        btnDadesUsuariEnrere.Name = "btnDadesUsuariEnrere"
        btnDadesUsuariEnrere.Size = New Size(131, 69)
        btnDadesUsuariEnrere.TabIndex = 38
        btnDadesUsuariEnrere.Text = "Enrere"
        btnDadesUsuariEnrere.UseVisualStyleBackColor = False
        ' 
        ' btnDadesUsuariTencarSessio
        ' 
        btnDadesUsuariTencarSessio.Anchor = AnchorStyles.Bottom
        btnDadesUsuariTencarSessio.BackColor = Color.Aquamarine
        btnDadesUsuariTencarSessio.Location = New Point(374, 458)
        btnDadesUsuariTencarSessio.Name = "btnDadesUsuariTencarSessio"
        btnDadesUsuariTencarSessio.Size = New Size(131, 69)
        btnDadesUsuariTencarSessio.TabIndex = 39
        btnDadesUsuariTencarSessio.Text = "Tencar Sessio"
        btnDadesUsuariTencarSessio.UseVisualStyleBackColor = False
        ' 
        ' btnDadesUsuariChangePass
        ' 
        btnDadesUsuariChangePass.BackColor = Color.Aquamarine
        btnDadesUsuariChangePass.Enabled = False
        btnDadesUsuariChangePass.Location = New Point(180, 294)
        btnDadesUsuariChangePass.Name = "btnDadesUsuariChangePass"
        btnDadesUsuariChangePass.Size = New Size(167, 36)
        btnDadesUsuariChangePass.TabIndex = 40
        btnDadesUsuariChangePass.Text = "Canviar contrasenya"
        btnDadesUsuariChangePass.UseVisualStyleBackColor = False
        ' 
        ' erpDadesUsuariErrors
        ' 
        erpDadesUsuariErrors.ContainerControl = Me
        ' 
        ' DadesUsuari
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(840, 539)
        Controls.Add(btnDadesUsuariChangePass)
        Controls.Add(btnDadesUsuariTencarSessio)
        Controls.Add(btnDadesUsuariEnrere)
        Controls.Add(lblDadesUsuariNom)
        Controls.Add(lblDadesUsuariCognom1)
        Controls.Add(lblDadesUsuariCognom2)
        Controls.Add(lblDadesUsuariNomUsuari)
        Controls.Add(txtDadesUsuariTelefon)
        Controls.Add(lblDadesUsuariContrasenya)
        Controls.Add(txtDadesUsuariCorreu)
        Controls.Add(lblDadesUsuariDI)
        Controls.Add(lblDadesUsuariCorreu)
        Controls.Add(txtDadesUsuariNomUsuari)
        Controls.Add(lblDadesUsuariTelefon)
        Controls.Add(txtDadesUsuariDI)
        Controls.Add(txtDadesUsuariCognom2)
        Controls.Add(txtDadesUsuariNom)
        Controls.Add(txtDadesUsuariCognom1)
        Controls.Add(btnDadesUsuariSeleccionarImatge)
        Controls.Add(lblDadesUsuariTitol)
        Controls.Add(btnDadesUsuariGuardar)
        Controls.Add(btnDadesUsuariModificar)
        Controls.Add(pcbDadesUsuariFotoPerfil)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(858, 586)
        Name = "DadesUsuari"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Perfil"
        CType(pcbDadesUsuariFotoPerfil, ComponentModel.ISupportInitialize).EndInit()
        CType(erpDadesUsuariErrors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pcbDadesUsuariFotoPerfil As PictureBox
    Friend WithEvents btnDadesUsuariModificar As Button
    Friend WithEvents btnDadesUsuariGuardar As Button
    Friend WithEvents lblDadesUsuariTitol As Label
    Friend WithEvents btnDadesUsuariSeleccionarImatge As Button
    Friend WithEvents lblDadesUsuariNom As Label
    Friend WithEvents lblDadesUsuariCognom1 As Label
    Friend WithEvents lblDadesUsuariCognom2 As Label
    Friend WithEvents lblDadesUsuariNomUsuari As Label
    Friend WithEvents txtDadesUsuariTelefon As TextBox
    Friend WithEvents lblDadesUsuariContrasenya As Label
    Friend WithEvents txtDadesUsuariCorreu As TextBox
    Friend WithEvents lblDadesUsuariDI As Label
    Friend WithEvents lblDadesUsuariCorreu As Label
    Friend WithEvents txtDadesUsuariNomUsuari As TextBox
    Friend WithEvents lblDadesUsuariTelefon As Label
    Friend WithEvents txtDadesUsuariDI As TextBox
    Friend WithEvents txtDadesUsuariCognom2 As TextBox
    Friend WithEvents txtDadesUsuariNom As TextBox
    Friend WithEvents txtDadesUsuariCognom1 As TextBox
    Friend WithEvents btnDadesUsuariEnrere As Button
    Friend WithEvents btnDadesUsuariTencarSessio As Button
    Friend WithEvents btnDadesUsuariChangePass As Button
    Friend WithEvents erpDadesUsuariErrors As ErrorProvider
End Class
