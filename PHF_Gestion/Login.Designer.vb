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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.pcbLoginLogo = New System.Windows.Forms.PictureBox()
        Me.txtLoginPassword = New System.Windows.Forms.MaskedTextBox()
        Me.txtLoginUsuari = New System.Windows.Forms.TextBox()
        Me.btnLoginEntrar = New System.Windows.Forms.Button()
        Me.pcbLoginUsuari = New System.Windows.Forms.PictureBox()
        Me.pcbLoginPassword = New System.Windows.Forms.PictureBox()
        Me.lblLoginUsuari = New System.Windows.Forms.TextBox()
        Me.lblLoginPassword = New System.Windows.Forms.TextBox()
        CType(Me.pcbLoginLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbLoginUsuari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbLoginPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbLoginLogo
        '
        Me.pcbLoginLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbLoginLogo.Image = CType(resources.GetObject("pcbLoginLogo.Image"), System.Drawing.Image)
        Me.pcbLoginLogo.Location = New System.Drawing.Point(43, 56)
        Me.pcbLoginLogo.Name = "pcbLoginLogo"
        Me.pcbLoginLogo.Size = New System.Drawing.Size(301, 280)
        Me.pcbLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbLoginLogo.TabIndex = 0
        Me.pcbLoginLogo.TabStop = False
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoginPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtLoginPassword.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLoginPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txtLoginPassword.Location = New System.Drawing.Point(490, 226)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtLoginPassword.Size = New System.Drawing.Size(249, 26)
        Me.txtLoginPassword.TabIndex = 1
        '
        'txtLoginUsuari
        '
        Me.txtLoginUsuari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoginUsuari.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLoginUsuari.Location = New System.Drawing.Point(490, 118)
        Me.txtLoginUsuari.Name = "txtLoginUsuari"
        Me.txtLoginUsuari.Size = New System.Drawing.Size(249, 26)
        Me.txtLoginUsuari.TabIndex = 2
        '
        'btnLoginEntrar
        '
        Me.btnLoginEntrar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnLoginEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnLoginEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginEntrar.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLoginEntrar.Location = New System.Drawing.Point(566, 293)
        Me.btnLoginEntrar.Name = "btnLoginEntrar"
        Me.btnLoginEntrar.Size = New System.Drawing.Size(173, 80)
        Me.btnLoginEntrar.TabIndex = 3
        Me.btnLoginEntrar.Text = "Entra"
        Me.btnLoginEntrar.UseVisualStyleBackColor = False
        '
        'pcbLoginUsuari
        '
        Me.pcbLoginUsuari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbLoginUsuari.Image = Global.PHF_Gestion.My.Resources.Resources.pngegg
        Me.pcbLoginUsuari.Location = New System.Drawing.Point(415, 92)
        Me.pcbLoginUsuari.Name = "pcbLoginUsuari"
        Me.pcbLoginUsuari.Size = New System.Drawing.Size(50, 52)
        Me.pcbLoginUsuari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbLoginUsuari.TabIndex = 4
        Me.pcbLoginUsuari.TabStop = False
        '
        'pcbLoginPassword
        '
        Me.pcbLoginPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbLoginPassword.Image = Global.PHF_Gestion.My.Resources.Resources.pngeggpaswd
        Me.pcbLoginPassword.Location = New System.Drawing.Point(415, 200)
        Me.pcbLoginPassword.Name = "pcbLoginPassword"
        Me.pcbLoginPassword.Size = New System.Drawing.Size(50, 52)
        Me.pcbLoginPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbLoginPassword.TabIndex = 5
        Me.pcbLoginPassword.TabStop = False
        '
        'lblLoginUsuari
        '
        Me.lblLoginUsuari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoginUsuari.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblLoginUsuari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblLoginUsuari.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLoginUsuari.Location = New System.Drawing.Point(490, 85)
        Me.lblLoginUsuari.Name = "lblLoginUsuari"
        Me.lblLoginUsuari.Size = New System.Drawing.Size(125, 19)
        Me.lblLoginUsuari.TabIndex = 6
        Me.lblLoginUsuari.Text = "Usuari"
        '
        'lblLoginPassword
        '
        Me.lblLoginPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoginPassword.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblLoginPassword.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLoginPassword.Location = New System.Drawing.Point(490, 192)
        Me.lblLoginPassword.Name = "lblLoginPassword"
        Me.lblLoginPassword.Size = New System.Drawing.Size(125, 19)
        Me.lblLoginPassword.TabIndex = 7
        Me.lblLoginPassword.Text = "Contrasenya"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(795, 419)
        Me.Controls.Add(Me.lblLoginPassword)
        Me.Controls.Add(Me.lblLoginUsuari)
        Me.Controls.Add(Me.pcbLoginPassword)
        Me.Controls.Add(Me.pcbLoginUsuari)
        Me.Controls.Add(Me.btnLoginEntrar)
        Me.Controls.Add(Me.txtLoginUsuari)
        Me.Controls.Add(Me.txtLoginPassword)
        Me.Controls.Add(Me.pcbLoginLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(813, 466)
        Me.MinimumSize = New System.Drawing.Size(813, 466)
        Me.Name = "Login"
        Me.Text = "Pet Hotel Finder"
        CType(Me.pcbLoginLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbLoginUsuari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbLoginPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbLoginLogo As PictureBox
    Friend WithEvents txtLoginPassword As MaskedTextBox
    Friend WithEvents txtLoginUsuari As TextBox
    Friend WithEvents btnLoginEntrar As Button
    Friend WithEvents pcbLoginUsuari As PictureBox
    Friend WithEvents pcbLoginPassword As PictureBox
    Friend WithEvents lblLoginUsuari As TextBox
    Friend WithEvents lblLoginPassword As TextBox
End Class
