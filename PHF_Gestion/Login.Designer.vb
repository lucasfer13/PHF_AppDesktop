<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        pcbLoginLogo = New PictureBox()
        txtLoginPassword = New MaskedTextBox()
        txtLoginUsuari = New TextBox()
        btnLoginEntrar = New Button()
        pcbLoginUsuari = New PictureBox()
        pcbLoginPassword = New PictureBox()
        erpLoginError = New ErrorProvider(components)
        lblLoginUsuari = New Label()
        lblLoginContrasenya = New Label()
        CType(pcbLoginLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcbLoginUsuari, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcbLoginPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(erpLoginError, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pcbLoginLogo
        ' 
        pcbLoginLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pcbLoginLogo.Image = CType(resources.GetObject("pcbLoginLogo.Image"), Image)
        pcbLoginLogo.Location = New Point(43, 56)
        pcbLoginLogo.Name = "pcbLoginLogo"
        pcbLoginLogo.Size = New Size(301, 280)
        pcbLoginLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pcbLoginLogo.TabIndex = 0
        pcbLoginLogo.TabStop = False
        ' 
        ' txtLoginPassword
        ' 
        txtLoginPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtLoginPassword.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals
        txtLoginPassword.Font = New Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtLoginPassword.InsertKeyMode = InsertKeyMode.Insert
        txtLoginPassword.Location = New Point(490, 226)
        txtLoginPassword.Name = "txtLoginPassword"
        txtLoginPassword.PasswordChar = "●"c
        txtLoginPassword.Size = New Size(249, 26)
        txtLoginPassword.TabIndex = 2
        ' 
        ' txtLoginUsuari
        ' 
        txtLoginUsuari.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtLoginUsuari.Font = New Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtLoginUsuari.Location = New Point(490, 118)
        txtLoginUsuari.Name = "txtLoginUsuari"
        txtLoginUsuari.Size = New Size(249, 26)
        txtLoginUsuari.TabIndex = 1
        ' 
        ' btnLoginEntrar
        ' 
        btnLoginEntrar.BackColor = Color.Aquamarine
        btnLoginEntrar.FlatAppearance.BorderColor = Color.Aquamarine
        btnLoginEntrar.Font = New Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLoginEntrar.Location = New Point(566, 293)
        btnLoginEntrar.Name = "btnLoginEntrar"
        btnLoginEntrar.Size = New Size(173, 80)
        btnLoginEntrar.TabIndex = 3
        btnLoginEntrar.Text = "Entra"
        btnLoginEntrar.UseVisualStyleBackColor = False
        ' 
        ' pcbLoginUsuari
        ' 
        pcbLoginUsuari.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pcbLoginUsuari.Image = My.Resources.Resources.pngegg
        pcbLoginUsuari.Location = New Point(415, 92)
        pcbLoginUsuari.Name = "pcbLoginUsuari"
        pcbLoginUsuari.Size = New Size(50, 52)
        pcbLoginUsuari.SizeMode = PictureBoxSizeMode.StretchImage
        pcbLoginUsuari.TabIndex = 4
        pcbLoginUsuari.TabStop = False
        ' 
        ' pcbLoginPassword
        ' 
        pcbLoginPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pcbLoginPassword.Image = My.Resources.Resources.pngeggpaswd
        pcbLoginPassword.Location = New Point(415, 200)
        pcbLoginPassword.Name = "pcbLoginPassword"
        pcbLoginPassword.Size = New Size(50, 52)
        pcbLoginPassword.SizeMode = PictureBoxSizeMode.StretchImage
        pcbLoginPassword.TabIndex = 5
        pcbLoginPassword.TabStop = False
        ' 
        ' erpLoginError
        ' 
        erpLoginError.ContainerControl = Me
        ' 
        ' lblLoginUsuari
        ' 
        lblLoginUsuari.AutoSize = True
        lblLoginUsuari.Location = New Point(490, 92)
        lblLoginUsuari.Name = "lblLoginUsuari"
        lblLoginUsuari.Size = New Size(50, 20)
        lblLoginUsuari.TabIndex = 8
        lblLoginUsuari.Text = "Usuari"' 
        ' lblLoginContrasenya
        ' 
        lblLoginContrasenya.AutoSize = True
        lblLoginContrasenya.Location = New Point(490, 200)
        lblLoginContrasenya.Name = "lblLoginContrasenya"
        lblLoginContrasenya.Size = New Size(90, 20)
        lblLoginContrasenya.TabIndex = 9
        lblLoginContrasenya.Text = "Contrasenya"' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(795, 419)
        Controls.Add(lblLoginContrasenya)
        Controls.Add(lblLoginUsuari)
        Controls.Add(pcbLoginPassword)
        Controls.Add(pcbLoginUsuari)
        Controls.Add(btnLoginEntrar)
        Controls.Add(txtLoginUsuari)
        Controls.Add(txtLoginPassword)
        Controls.Add(pcbLoginLogo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(813, 466)
        MinimumSize = New Size(813, 466)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pet Hotel Finder"
        CType(pcbLoginLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(pcbLoginUsuari, ComponentModel.ISupportInitialize).EndInit()
        CType(pcbLoginPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(erpLoginError, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pcbLoginLogo As PictureBox
    Friend WithEvents txtLoginPassword As MaskedTextBox
    Friend WithEvents txtLoginUsuari As TextBox
    Friend WithEvents btnLoginEntrar As Button
    Friend WithEvents pcbLoginUsuari As PictureBox
    Friend WithEvents pcbLoginPassword As PictureBox
    Friend WithEvents erpLoginError As ErrorProvider
    Friend WithEvents lblLoginContrasenya As Label
    Friend WithEvents lblLoginUsuari As Label
End Class
