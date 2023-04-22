<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CameraForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CameraForm))
        Me.lblGestioCameraTitol = New System.Windows.Forms.Label()
        Me.lblGestioCameraTitolURL = New System.Windows.Forms.Label()
        Me.txtGestioCameraURL = New System.Windows.Forms.TextBox()
        Me.txtGestioCameraDescripció = New System.Windows.Forms.TextBox()
        Me.lblGestioCameraTitolDescripcio = New System.Windows.Forms.Label()
        Me.txtGestioCameraUsuari = New System.Windows.Forms.TextBox()
        Me.lblGestioCameraTitolUsuari = New System.Windows.Forms.Label()
        Me.txtGestioCameraContrasenya = New System.Windows.Forms.TextBox()
        Me.lblGestioCameraTitolContrasenya = New System.Windows.Forms.Label()
        Me.btnGestioCameraGuardar = New System.Windows.Forms.Button()
        Me.btnGestioCameraEliminar = New System.Windows.Forms.Button()
        Me.btnGestioCameraEnrere = New System.Windows.Forms.Button()
        Me.btnGestioCameraModificar = New System.Windows.Forms.Button()
        Me.erpFormCameraErrors = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.erpFormCameraErrors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGestioCameraTitol
        '
        Me.lblGestioCameraTitol.AutoSize = True
        Me.lblGestioCameraTitol.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGestioCameraTitol.Location = New System.Drawing.Point(331, 26)
        Me.lblGestioCameraTitol.Name = "lblGestioCameraTitol"
        Me.lblGestioCameraTitol.Size = New System.Drawing.Size(119, 41)
        Me.lblGestioCameraTitol.TabIndex = 0
        Me.lblGestioCameraTitol.Text = "Camera"
        '
        'lblGestioCameraTitolURL
        '
        Me.lblGestioCameraTitolURL.AutoSize = True
        Me.lblGestioCameraTitolURL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGestioCameraTitolURL.Location = New System.Drawing.Point(44, 100)
        Me.lblGestioCameraTitolURL.Name = "lblGestioCameraTitolURL"
        Me.lblGestioCameraTitolURL.Size = New System.Drawing.Size(46, 21)
        Me.lblGestioCameraTitolURL.TabIndex = 1
        Me.lblGestioCameraTitolURL.Text = "URL: "
        '
        'txtGestioCameraURL
        '
        Me.txtGestioCameraURL.Location = New System.Drawing.Point(164, 104)
        Me.txtGestioCameraURL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGestioCameraURL.Name = "txtGestioCameraURL"
        Me.txtGestioCameraURL.Size = New System.Drawing.Size(204, 23)
        Me.txtGestioCameraURL.TabIndex = 2
        '
        'txtGestioCameraDescripció
        '
        Me.txtGestioCameraDescripció.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGestioCameraDescripció.Location = New System.Drawing.Point(164, 141)
        Me.txtGestioCameraDescripció.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGestioCameraDescripció.Multiline = True
        Me.txtGestioCameraDescripció.Name = "txtGestioCameraDescripció"
        Me.txtGestioCameraDescripció.Size = New System.Drawing.Size(204, 134)
        Me.txtGestioCameraDescripció.TabIndex = 4
        '
        'lblGestioCameraTitolDescripcio
        '
        Me.lblGestioCameraTitolDescripcio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGestioCameraTitolDescripcio.AutoSize = True
        Me.lblGestioCameraTitolDescripcio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGestioCameraTitolDescripcio.Location = New System.Drawing.Point(44, 138)
        Me.lblGestioCameraTitolDescripcio.Name = "lblGestioCameraTitolDescripcio"
        Me.lblGestioCameraTitolDescripcio.Size = New System.Drawing.Size(89, 21)
        Me.lblGestioCameraTitolDescripcio.TabIndex = 3
        Me.lblGestioCameraTitolDescripcio.Text = "Descripció: "
        '
        'txtGestioCameraUsuari
        '
        Me.txtGestioCameraUsuari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGestioCameraUsuari.Location = New System.Drawing.Point(554, 104)
        Me.txtGestioCameraUsuari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGestioCameraUsuari.Name = "txtGestioCameraUsuari"
        Me.txtGestioCameraUsuari.Size = New System.Drawing.Size(204, 23)
        Me.txtGestioCameraUsuari.TabIndex = 6
        '
        'lblGestioCameraTitolUsuari
        '
        Me.lblGestioCameraTitolUsuari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGestioCameraTitolUsuari.AutoSize = True
        Me.lblGestioCameraTitolUsuari.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGestioCameraTitolUsuari.Location = New System.Drawing.Point(415, 100)
        Me.lblGestioCameraTitolUsuari.Name = "lblGestioCameraTitolUsuari"
        Me.lblGestioCameraTitolUsuari.Size = New System.Drawing.Size(62, 21)
        Me.lblGestioCameraTitolUsuari.TabIndex = 5
        Me.lblGestioCameraTitolUsuari.Text = "Usuari: "
        '
        'txtGestioCameraContrasenya
        '
        Me.txtGestioCameraContrasenya.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGestioCameraContrasenya.Location = New System.Drawing.Point(554, 141)
        Me.txtGestioCameraContrasenya.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGestioCameraContrasenya.Name = "txtGestioCameraContrasenya"
        Me.txtGestioCameraContrasenya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtGestioCameraContrasenya.Size = New System.Drawing.Size(204, 23)
        Me.txtGestioCameraContrasenya.TabIndex = 8
        '
        'lblGestioCameraTitolContrasenya
        '
        Me.lblGestioCameraTitolContrasenya.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGestioCameraTitolContrasenya.AutoSize = True
        Me.lblGestioCameraTitolContrasenya.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGestioCameraTitolContrasenya.Location = New System.Drawing.Point(415, 138)
        Me.lblGestioCameraTitolContrasenya.Name = "lblGestioCameraTitolContrasenya"
        Me.lblGestioCameraTitolContrasenya.Size = New System.Drawing.Size(104, 21)
        Me.lblGestioCameraTitolContrasenya.TabIndex = 7
        Me.lblGestioCameraTitolContrasenya.Text = "Contrasenya: "
        '
        'btnGestioCameraGuardar
        '
        Me.btnGestioCameraGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGestioCameraGuardar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioCameraGuardar.Location = New System.Drawing.Point(433, 310)
        Me.btnGestioCameraGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestioCameraGuardar.Name = "btnGestioCameraGuardar"
        Me.btnGestioCameraGuardar.Size = New System.Drawing.Size(127, 55)
        Me.btnGestioCameraGuardar.TabIndex = 9
        Me.btnGestioCameraGuardar.Text = "Guardar"
        Me.btnGestioCameraGuardar.UseVisualStyleBackColor = False
        '
        'btnGestioCameraEliminar
        '
        Me.btnGestioCameraEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGestioCameraEliminar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioCameraEliminar.Location = New System.Drawing.Point(583, 310)
        Me.btnGestioCameraEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestioCameraEliminar.Name = "btnGestioCameraEliminar"
        Me.btnGestioCameraEliminar.Size = New System.Drawing.Size(127, 55)
        Me.btnGestioCameraEliminar.TabIndex = 10
        Me.btnGestioCameraEliminar.Text = "Eliminar"
        Me.btnGestioCameraEliminar.UseVisualStyleBackColor = False
        '
        'btnGestioCameraEnrere
        '
        Me.btnGestioCameraEnrere.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGestioCameraEnrere.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioCameraEnrere.Location = New System.Drawing.Point(135, 310)
        Me.btnGestioCameraEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestioCameraEnrere.Name = "btnGestioCameraEnrere"
        Me.btnGestioCameraEnrere.Size = New System.Drawing.Size(127, 55)
        Me.btnGestioCameraEnrere.TabIndex = 11
        Me.btnGestioCameraEnrere.Text = "Enrere"
        Me.btnGestioCameraEnrere.UseVisualStyleBackColor = False
        '
        'btnGestioCameraModificar
        '
        Me.btnGestioCameraModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGestioCameraModificar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioCameraModificar.Location = New System.Drawing.Point(285, 310)
        Me.btnGestioCameraModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestioCameraModificar.Name = "btnGestioCameraModificar"
        Me.btnGestioCameraModificar.Size = New System.Drawing.Size(127, 55)
        Me.btnGestioCameraModificar.TabIndex = 12
        Me.btnGestioCameraModificar.Text = "Modificar"
        Me.btnGestioCameraModificar.UseVisualStyleBackColor = False
        '
        'erpFormCameraErrors
        '
        Me.erpFormCameraErrors.ContainerControl = Me
        '
        'CameraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(837, 397)
        Me.Controls.Add(Me.btnGestioCameraModificar)
        Me.Controls.Add(Me.btnGestioCameraEnrere)
        Me.Controls.Add(Me.btnGestioCameraEliminar)
        Me.Controls.Add(Me.btnGestioCameraGuardar)
        Me.Controls.Add(Me.txtGestioCameraContrasenya)
        Me.Controls.Add(Me.lblGestioCameraTitolContrasenya)
        Me.Controls.Add(Me.txtGestioCameraUsuari)
        Me.Controls.Add(Me.lblGestioCameraTitolUsuari)
        Me.Controls.Add(Me.txtGestioCameraDescripció)
        Me.Controls.Add(Me.lblGestioCameraTitolDescripcio)
        Me.Controls.Add(Me.txtGestioCameraURL)
        Me.Controls.Add(Me.lblGestioCameraTitolURL)
        Me.Controls.Add(Me.lblGestioCameraTitol)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(843, 419)
        Me.Name = "CameraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHF - Formulari camera"
        CType(Me.erpFormCameraErrors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGestioCameraTitol As Label
    Friend WithEvents lblGestioCameraTitolURL As Label
    Friend WithEvents txtGestioCameraURL As TextBox
    Friend WithEvents txtGestioCameraDescripció As TextBox
    Friend WithEvents lblGestioCameraTitolDescripcio As Label
    Friend WithEvents txtGestioCameraUsuari As TextBox
    Friend WithEvents lblGestioCameraTitolUsuari As Label
    Friend WithEvents txtGestioCameraContrasenya As TextBox
    Friend WithEvents lblGestioCameraTitolContrasenya As Label
    Friend WithEvents btnGestioCameraGuardar As Button
    Friend WithEvents btnGestioCameraEliminar As Button
    Friend WithEvents btnGestioCameraEnrere As Button
    Friend WithEvents btnGestioCameraModificar As Button
    Friend WithEvents erpFormCameraErrors As ErrorProvider
End Class
