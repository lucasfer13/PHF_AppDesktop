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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CameraForm))
        lblGestioCameraTitol = New Label()
        lblGestioCameraTitolURL = New Label()
        txtGestioCameraURL = New TextBox()
        txtGestioCameraDescripció = New TextBox()
        lblGestioCameraTitolDescripcio = New Label()
        txtGestioCameraUsuari = New TextBox()
        lblGestioCameraTitolUsuari = New Label()
        txtGestioCameraContrasenya = New TextBox()
        lblGestioCameraTitolContrasenya = New Label()
        btnGestioCameraGuardar = New Button()
        btnGestioCameraEliminar = New Button()
        btnGestioCameraEnrere = New Button()
        btnGestioCameraModificar = New Button()
        SuspendLayout()
        ' 
        ' lblGestioCameraTitol
        ' 
        lblGestioCameraTitol.AutoSize = True
        lblGestioCameraTitol.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioCameraTitol.Location = New Point(378, 34)
        lblGestioCameraTitol.Name = "lblGestioCameraTitol"
        lblGestioCameraTitol.Size = New Size(147, 50)
        lblGestioCameraTitol.TabIndex = 0
        lblGestioCameraTitol.Text = "Camera"' 
        ' lblGestioCameraTitolURL
        ' 
        lblGestioCameraTitolURL.AutoSize = True
        lblGestioCameraTitolURL.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioCameraTitolURL.Location = New Point(50, 134)
        lblGestioCameraTitolURL.Name = "lblGestioCameraTitolURL"
        lblGestioCameraTitolURL.Size = New Size(56, 28)
        lblGestioCameraTitolURL.TabIndex = 1
        lblGestioCameraTitolURL.Text = "URL: "' 
        ' txtGestioCameraURL
        ' 
        txtGestioCameraURL.Location = New Point(187, 138)
        txtGestioCameraURL.Name = "txtGestioCameraURL"
        txtGestioCameraURL.Size = New Size(233, 27)
        txtGestioCameraURL.TabIndex = 2
        ' 
        ' txtGestioCameraDescripció
        ' 
        txtGestioCameraDescripció.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtGestioCameraDescripció.Location = New Point(187, 188)
        txtGestioCameraDescripció.Multiline = True
        txtGestioCameraDescripció.Name = "txtGestioCameraDescripció"
        txtGestioCameraDescripció.Size = New Size(233, 155)
        txtGestioCameraDescripció.TabIndex = 4
        ' 
        ' lblGestioCameraTitolDescripcio
        ' 
        lblGestioCameraTitolDescripcio.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblGestioCameraTitolDescripcio.AutoSize = True
        lblGestioCameraTitolDescripcio.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioCameraTitolDescripcio.Location = New Point(50, 184)
        lblGestioCameraTitolDescripcio.Name = "lblGestioCameraTitolDescripcio"
        lblGestioCameraTitolDescripcio.Size = New Size(112, 28)
        lblGestioCameraTitolDescripcio.TabIndex = 3
        lblGestioCameraTitolDescripcio.Text = "Descripció: "' 
        ' txtGestioCameraUsuari
        ' 
        txtGestioCameraUsuari.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtGestioCameraUsuari.Location = New Point(622, 138)
        txtGestioCameraUsuari.Name = "txtGestioCameraUsuari"
        txtGestioCameraUsuari.Size = New Size(233, 27)
        txtGestioCameraUsuari.TabIndex = 6
        ' 
        ' lblGestioCameraTitolUsuari
        ' 
        lblGestioCameraTitolUsuari.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblGestioCameraTitolUsuari.AutoSize = True
        lblGestioCameraTitolUsuari.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioCameraTitolUsuari.Location = New Point(463, 134)
        lblGestioCameraTitolUsuari.Name = "lblGestioCameraTitolUsuari"
        lblGestioCameraTitolUsuari.Size = New Size(76, 28)
        lblGestioCameraTitolUsuari.TabIndex = 5
        lblGestioCameraTitolUsuari.Text = "Usuari: "' 
        ' txtGestioCameraContrasenya
        ' 
        txtGestioCameraContrasenya.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtGestioCameraContrasenya.Location = New Point(622, 188)
        txtGestioCameraContrasenya.Name = "txtGestioCameraContrasenya"
        txtGestioCameraContrasenya.PasswordChar = "*"c
        txtGestioCameraContrasenya.Size = New Size(233, 27)
        txtGestioCameraContrasenya.TabIndex = 8
        ' 
        ' lblGestioCameraTitolContrasenya
        ' 
        lblGestioCameraTitolContrasenya.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblGestioCameraTitolContrasenya.AutoSize = True
        lblGestioCameraTitolContrasenya.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioCameraTitolContrasenya.Location = New Point(463, 184)
        lblGestioCameraTitolContrasenya.Name = "lblGestioCameraTitolContrasenya"
        lblGestioCameraTitolContrasenya.Size = New Size(129, 28)
        lblGestioCameraTitolContrasenya.TabIndex = 7
        lblGestioCameraTitolContrasenya.Text = "Contrasenya: "' 
        ' btnGestioCameraGuardar
        ' 
        btnGestioCameraGuardar.Anchor = AnchorStyles.Bottom
        btnGestioCameraGuardar.BackColor = Color.Aquamarine
        btnGestioCameraGuardar.Location = New Point(489, 391)
        btnGestioCameraGuardar.Name = "btnGestioCameraGuardar"
        btnGestioCameraGuardar.Size = New Size(145, 73)
        btnGestioCameraGuardar.TabIndex = 9
        btnGestioCameraGuardar.Text = "Guardar"
        btnGestioCameraGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnGestioCameraEliminar
        ' 
        btnGestioCameraEliminar.Anchor = AnchorStyles.Bottom
        btnGestioCameraEliminar.BackColor = Color.Aquamarine
        btnGestioCameraEliminar.Location = New Point(661, 391)
        btnGestioCameraEliminar.Name = "btnGestioCameraEliminar"
        btnGestioCameraEliminar.Size = New Size(145, 73)
        btnGestioCameraEliminar.TabIndex = 10
        btnGestioCameraEliminar.Text = "Eliminar"
        btnGestioCameraEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnGestioCameraEnrere
        ' 
        btnGestioCameraEnrere.Anchor = AnchorStyles.Bottom
        btnGestioCameraEnrere.BackColor = Color.Aquamarine
        btnGestioCameraEnrere.Location = New Point(148, 391)
        btnGestioCameraEnrere.Name = "btnGestioCameraEnrere"
        btnGestioCameraEnrere.Size = New Size(145, 73)
        btnGestioCameraEnrere.TabIndex = 11
        btnGestioCameraEnrere.Text = "Enrere"
        btnGestioCameraEnrere.UseVisualStyleBackColor = False
        ' 
        ' btnGestioCameraModificar
        ' 
        btnGestioCameraModificar.Anchor = AnchorStyles.Bottom
        btnGestioCameraModificar.BackColor = Color.Aquamarine
        btnGestioCameraModificar.Location = New Point(320, 391)
        btnGestioCameraModificar.Name = "btnGestioCameraModificar"
        btnGestioCameraModificar.Size = New Size(145, 73)
        btnGestioCameraModificar.TabIndex = 12
        btnGestioCameraModificar.Text = "Modificar"
        btnGestioCameraModificar.UseVisualStyleBackColor = False
        ' 
        ' CameraForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(943, 499)
        Controls.Add(btnGestioCameraModificar)
        Controls.Add(btnGestioCameraEnrere)
        Controls.Add(btnGestioCameraEliminar)
        Controls.Add(btnGestioCameraGuardar)
        Controls.Add(txtGestioCameraContrasenya)
        Controls.Add(lblGestioCameraTitolContrasenya)
        Controls.Add(txtGestioCameraUsuari)
        Controls.Add(lblGestioCameraTitolUsuari)
        Controls.Add(txtGestioCameraDescripció)
        Controls.Add(lblGestioCameraTitolDescripcio)
        Controls.Add(txtGestioCameraURL)
        Controls.Add(lblGestioCameraTitolURL)
        Controls.Add(lblGestioCameraTitol)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(961, 546)
        Name = "CameraForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Formulari camera"
        ResumeLayout(False)
        PerformLayout()
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
End Class
