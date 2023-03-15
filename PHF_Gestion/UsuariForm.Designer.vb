<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(UsuariForm))
        lblUsuariTitol = New Label()
        lblUsuariGuarderia = New Label()
        dgvUsuariGuarderies = New DataGridView()
        btnUsuariAfegirGuarderia = New Button()
        btnUsuariElminarGuarderia = New Button()
        lblUsuariNom = New Label()
        lblUsuariCognom1 = New Label()
        lblUsuariCognom2 = New Label()
        lblUsuariNomUsuari = New Label()
        lblUsuariContrasenya = New Label()
        lblUsuariDI = New Label()
        lblUsuariCorreu = New Label()
        lblUsuariTelefon = New Label()
        gpbUsuariTipusUsuaris = New GroupBox()
        robUsuariSupervisor = New RadioButton()
        robUsuariAdminstrador = New RadioButton()
        txtUsuariNom = New TextBox()
        txtUsuariCognom1 = New TextBox()
        txtUsuariCognom2 = New TextBox()
        txtUsuariDI = New TextBox()
        txtUsuariNomUsuari = New TextBox()
        txtUsuariContrasenya = New TextBox()
        txtUsuariCorreu = New TextBox()
        txtUsuariTelefon = New TextBox()
        btnUsuariGuardar = New Button()
        btnUsuariEliminar = New Button()
        btnUsuariEnrere = New Button()
        SplitContainer1 = New SplitContainer()
        CType(dgvUsuariGuarderies, ComponentModel.ISupportInitialize).BeginInit()
        gpbUsuariTipusUsuaris.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblUsuariTitol
        ' 
        lblUsuariTitol.Anchor = AnchorStyles.Top
        lblUsuariTitol.AutoSize = True
        lblUsuariTitol.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsuariTitol.Location = New Point(461, 23)
        lblUsuariTitol.Name = "lblUsuariTitol"
        lblUsuariTitol.Size = New Size(125, 50)
        lblUsuariTitol.TabIndex = 0
        lblUsuariTitol.Text = "Usuari"' 
        ' lblUsuariGuarderia
        ' 
        lblUsuariGuarderia.AutoSize = True
        lblUsuariGuarderia.Location = New Point(31, 22)
        lblUsuariGuarderia.Name = "lblUsuariGuarderia"
        lblUsuariGuarderia.Size = New Size(80, 20)
        lblUsuariGuarderia.TabIndex = 1
        lblUsuariGuarderia.Text = "Guarderies"' 
        ' dgvUsuariGuarderies
        ' 
        dgvUsuariGuarderies.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsuariGuarderies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuariGuarderies.Location = New Point(31, 68)
        dgvUsuariGuarderies.Name = "dgvUsuariGuarderies"
        dgvUsuariGuarderies.RowHeadersWidth = 51
        dgvUsuariGuarderies.RowTemplate.Height = 29
        dgvUsuariGuarderies.Size = New Size(411, 392)
        dgvUsuariGuarderies.TabIndex = 2
        ' 
        ' btnUsuariAfegirGuarderia
        ' 
        btnUsuariAfegirGuarderia.BackColor = Color.Aquamarine
        btnUsuariAfegirGuarderia.Location = New Point(123, 18)
        btnUsuariAfegirGuarderia.Name = "btnUsuariAfegirGuarderia"
        btnUsuariAfegirGuarderia.Size = New Size(84, 29)
        btnUsuariAfegirGuarderia.TabIndex = 3
        btnUsuariAfegirGuarderia.Text = "Afegir"
        btnUsuariAfegirGuarderia.UseVisualStyleBackColor = False
        ' 
        ' btnUsuariElminarGuarderia
        ' 
        btnUsuariElminarGuarderia.BackColor = Color.Aquamarine
        btnUsuariElminarGuarderia.Location = New Point(224, 18)
        btnUsuariElminarGuarderia.Name = "btnUsuariElminarGuarderia"
        btnUsuariElminarGuarderia.Size = New Size(84, 29)
        btnUsuariElminarGuarderia.TabIndex = 4
        btnUsuariElminarGuarderia.Text = "Eliminar"
        btnUsuariElminarGuarderia.UseVisualStyleBackColor = False
        ' 
        ' lblUsuariNom
        ' 
        lblUsuariNom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblUsuariNom.AutoSize = True
        lblUsuariNom.Location = New Point(9, 42)
        lblUsuariNom.Name = "lblUsuariNom"
        lblUsuariNom.Size = New Size(45, 20)
        lblUsuariNom.TabIndex = 5
        lblUsuariNom.Text = "Nom:"' 
        ' lblUsuariCognom1
        ' 
        lblUsuariCognom1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblUsuariCognom1.AutoSize = True
        lblUsuariCognom1.Location = New Point(9, 80)
        lblUsuariCognom1.Name = "lblUsuariCognom1"
        lblUsuariCognom1.Size = New Size(81, 20)
        lblUsuariCognom1.TabIndex = 6
        lblUsuariCognom1.Text = "Cognom 1:"' 
        ' lblUsuariCognom2
        ' 
        lblUsuariCognom2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblUsuariCognom2.AutoSize = True
        lblUsuariCognom2.Location = New Point(9, 118)
        lblUsuariCognom2.Name = "lblUsuariCognom2"
        lblUsuariCognom2.Size = New Size(81, 20)
        lblUsuariCognom2.TabIndex = 7
        lblUsuariCognom2.Text = "Cognom 2:"' 
        ' lblUsuariNomUsuari
        ' 
        lblUsuariNomUsuari.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblUsuariNomUsuari.AutoSize = True
        lblUsuariNomUsuari.Location = New Point(9, 194)
        lblUsuariNomUsuari.Name = "lblUsuariNomUsuari"
        lblUsuariNomUsuari.Size = New Size(88, 20)
        lblUsuariNomUsuari.TabIndex = 8
        lblUsuariNomUsuari.Text = "Nom usuari:"' 
        ' lblUsuariContrasenya
        ' 
        lblUsuariContrasenya.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblUsuariContrasenya.AutoSize = True
        lblUsuariContrasenya.Location = New Point(9, 232)
        lblUsuariContrasenya.Name = "lblUsuariContrasenya"
        lblUsuariContrasenya.Size = New Size(93, 20)
        lblUsuariContrasenya.TabIndex = 9
        lblUsuariContrasenya.Text = "Contrasenya:"' 
        ' lblUsuariDI
        ' 
        lblUsuariDI.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblUsuariDI.AutoSize = True
        lblUsuariDI.Location = New Point(9, 156)
        lblUsuariDI.Name = "lblUsuariDI"
        lblUsuariDI.Size = New Size(27, 20)
        lblUsuariDI.TabIndex = 10
        lblUsuariDI.Text = "DI:"' 
        ' lblUsuariCorreu
        ' 
        lblUsuariCorreu.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblUsuariCorreu.AutoSize = True
        lblUsuariCorreu.Location = New Point(9, 270)
        lblUsuariCorreu.Name = "lblUsuariCorreu"
        lblUsuariCorreu.Size = New Size(56, 20)
        lblUsuariCorreu.TabIndex = 11
        lblUsuariCorreu.Text = "Correu:"' 
        ' lblUsuariTelefon
        ' 
        lblUsuariTelefon.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblUsuariTelefon.AutoSize = True
        lblUsuariTelefon.Location = New Point(9, 308)
        lblUsuariTelefon.Name = "lblUsuariTelefon"
        lblUsuariTelefon.Size = New Size(61, 20)
        lblUsuariTelefon.TabIndex = 12
        lblUsuariTelefon.Text = "Telefón:"' 
        ' gpbUsuariTipusUsuaris
        ' 
        gpbUsuariTipusUsuaris.Anchor = AnchorStyles.Bottom
        gpbUsuariTipusUsuaris.Controls.Add(robUsuariSupervisor)
        gpbUsuariTipusUsuaris.Controls.Add(robUsuariAdminstrador)
        gpbUsuariTipusUsuaris.Location = New Point(112, 354)
        gpbUsuariTipusUsuaris.Name = "gpbUsuariTipusUsuaris"
        gpbUsuariTipusUsuaris.Size = New Size(250, 125)
        gpbUsuariTipusUsuaris.TabIndex = 13
        gpbUsuariTipusUsuaris.TabStop = False
        gpbUsuariTipusUsuaris.Text = "Tipus Usuari"' 
        ' robUsuariSupervisor
        ' 
        robUsuariSupervisor.AutoSize = True
        robUsuariSupervisor.Location = New Point(54, 82)
        robUsuariSupervisor.Name = "robUsuariSupervisor"
        robUsuariSupervisor.Size = New Size(99, 24)
        robUsuariSupervisor.TabIndex = 1
        robUsuariSupervisor.TabStop = True
        robUsuariSupervisor.Text = "Supervisor"
        robUsuariSupervisor.UseVisualStyleBackColor = True
        ' 
        ' robUsuariAdminstrador
        ' 
        robUsuariAdminstrador.AutoSize = True
        robUsuariAdminstrador.Location = New Point(54, 48)
        robUsuariAdminstrador.Name = "robUsuariAdminstrador"
        robUsuariAdminstrador.Size = New Size(125, 24)
        robUsuariAdminstrador.TabIndex = 0
        robUsuariAdminstrador.TabStop = True
        robUsuariAdminstrador.Text = "Administrador"
        robUsuariAdminstrador.UseVisualStyleBackColor = True
        ' 
        ' txtUsuariNom
        ' 
        txtUsuariNom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsuariNom.Location = New Point(134, 42)
        txtUsuariNom.Name = "txtUsuariNom"
        txtUsuariNom.Size = New Size(305, 27)
        txtUsuariNom.TabIndex = 14
        ' 
        ' txtUsuariCognom1
        ' 
        txtUsuariCognom1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsuariCognom1.Location = New Point(134, 80)
        txtUsuariCognom1.Name = "txtUsuariCognom1"
        txtUsuariCognom1.Size = New Size(305, 27)
        txtUsuariCognom1.TabIndex = 15
        ' 
        ' txtUsuariCognom2
        ' 
        txtUsuariCognom2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsuariCognom2.Location = New Point(134, 118)
        txtUsuariCognom2.Name = "txtUsuariCognom2"
        txtUsuariCognom2.Size = New Size(305, 27)
        txtUsuariCognom2.TabIndex = 16
        ' 
        ' txtUsuariDI
        ' 
        txtUsuariDI.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsuariDI.Location = New Point(134, 153)
        txtUsuariDI.Name = "txtUsuariDI"
        txtUsuariDI.Size = New Size(305, 27)
        txtUsuariDI.TabIndex = 17
        ' 
        ' txtUsuariNomUsuari
        ' 
        txtUsuariNomUsuari.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsuariNomUsuari.Location = New Point(134, 194)
        txtUsuariNomUsuari.Name = "txtUsuariNomUsuari"
        txtUsuariNomUsuari.Size = New Size(305, 27)
        txtUsuariNomUsuari.TabIndex = 18
        ' 
        ' txtUsuariContrasenya
        ' 
        txtUsuariContrasenya.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsuariContrasenya.Location = New Point(134, 232)
        txtUsuariContrasenya.Name = "txtUsuariContrasenya"
        txtUsuariContrasenya.Size = New Size(305, 27)
        txtUsuariContrasenya.TabIndex = 19
        ' 
        ' txtUsuariCorreu
        ' 
        txtUsuariCorreu.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsuariCorreu.Location = New Point(134, 270)
        txtUsuariCorreu.Name = "txtUsuariCorreu"
        txtUsuariCorreu.Size = New Size(305, 27)
        txtUsuariCorreu.TabIndex = 20
        ' 
        ' txtUsuariTelefon
        ' 
        txtUsuariTelefon.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsuariTelefon.Location = New Point(134, 306)
        txtUsuariTelefon.Name = "txtUsuariTelefon"
        txtUsuariTelefon.Size = New Size(305, 27)
        txtUsuariTelefon.TabIndex = 21
        ' 
        ' btnUsuariGuardar
        ' 
        btnUsuariGuardar.Anchor = AnchorStyles.Bottom
        btnUsuariGuardar.BackColor = Color.Aquamarine
        btnUsuariGuardar.Location = New Point(254, 647)
        btnUsuariGuardar.Name = "btnUsuariGuardar"
        btnUsuariGuardar.Size = New Size(158, 61)
        btnUsuariGuardar.TabIndex = 22
        btnUsuariGuardar.Text = "Guardar"
        btnUsuariGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnUsuariEliminar
        ' 
        btnUsuariEliminar.Anchor = AnchorStyles.Bottom
        btnUsuariEliminar.BackColor = Color.Aquamarine
        btnUsuariEliminar.Location = New Point(461, 647)
        btnUsuariEliminar.Name = "btnUsuariEliminar"
        btnUsuariEliminar.Size = New Size(158, 61)
        btnUsuariEliminar.TabIndex = 23
        btnUsuariEliminar.Text = "Eliminar"
        btnUsuariEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnUsuariEnrere
        ' 
        btnUsuariEnrere.Anchor = AnchorStyles.Bottom
        btnUsuariEnrere.BackColor = Color.Aquamarine
        btnUsuariEnrere.Location = New Point(677, 647)
        btnUsuariEnrere.Name = "btnUsuariEnrere"
        btnUsuariEnrere.Size = New Size(158, 61)
        btnUsuariEnrere.TabIndex = 24
        btnUsuariEnrere.Text = "Enrere"
        btnUsuariEnrere.UseVisualStyleBackColor = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SplitContainer1.Location = New Point(29, 110)
        SplitContainer1.Name = "SplitContainer1"' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(lblUsuariNom)
        SplitContainer1.Panel1.Controls.Add(lblUsuariCognom1)
        SplitContainer1.Panel1.Controls.Add(lblUsuariCognom2)
        SplitContainer1.Panel1.Controls.Add(lblUsuariNomUsuari)
        SplitContainer1.Panel1.Controls.Add(txtUsuariTelefon)
        SplitContainer1.Panel1.Controls.Add(lblUsuariContrasenya)
        SplitContainer1.Panel1.Controls.Add(txtUsuariCorreu)
        SplitContainer1.Panel1.Controls.Add(lblUsuariDI)
        SplitContainer1.Panel1.Controls.Add(txtUsuariContrasenya)
        SplitContainer1.Panel1.Controls.Add(lblUsuariCorreu)
        SplitContainer1.Panel1.Controls.Add(txtUsuariNomUsuari)
        SplitContainer1.Panel1.Controls.Add(lblUsuariTelefon)
        SplitContainer1.Panel1.Controls.Add(txtUsuariDI)
        SplitContainer1.Panel1.Controls.Add(gpbUsuariTipusUsuaris)
        SplitContainer1.Panel1.Controls.Add(txtUsuariCognom2)
        SplitContainer1.Panel1.Controls.Add(txtUsuariNom)
        SplitContainer1.Panel1.Controls.Add(txtUsuariCognom1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(dgvUsuariGuarderies)
        SplitContainer1.Panel2.Controls.Add(lblUsuariGuarderia)
        SplitContainer1.Panel2.Controls.Add(btnUsuariAfegirGuarderia)
        SplitContainer1.Panel2.Controls.Add(btnUsuariElminarGuarderia)
        SplitContainer1.Size = New Size(966, 496)
        SplitContainer1.SplitterDistance = 477
        SplitContainer1.TabIndex = 25
        ' 
        ' UsuariForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1069, 734)
        Controls.Add(SplitContainer1)
        Controls.Add(btnUsuariEnrere)
        Controls.Add(btnUsuariEliminar)
        Controls.Add(btnUsuariGuardar)
        Controls.Add(lblUsuariTitol)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1087, 781)
        Name = "UsuariForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Formulari usuari"
        WindowState = FormWindowState.Maximized
        CType(dgvUsuariGuarderies, ComponentModel.ISupportInitialize).EndInit()
        gpbUsuariTipusUsuaris.ResumeLayout(False)
        gpbUsuariTipusUsuaris.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsuariTitol As Label
    Friend WithEvents lblUsuariGuarderia As Label
    Friend WithEvents dgvUsuariGuarderies As DataGridView
    Friend WithEvents btnUsuariAfegirGuarderia As Button
    Friend WithEvents btnUsuariElminarGuarderia As Button
    Friend WithEvents lblUsuariNom As Label
    Friend WithEvents lblUsuariCognom1 As Label
    Friend WithEvents lblUsuariCognom2 As Label
    Friend WithEvents lblUsuariNomUsuari As Label
    Friend WithEvents lblUsuariContrasenya As Label
    Friend WithEvents lblUsuariDI As Label
    Friend WithEvents lblUsuariCorreu As Label
    Friend WithEvents lblUsuariTelefon As Label
    Friend WithEvents gpbUsuariTipusUsuaris As GroupBox
    Friend WithEvents robUsuariSupervisor As RadioButton
    Friend WithEvents robUsuariAdminstrador As RadioButton
    Friend WithEvents txtUsuariNom As TextBox
    Friend WithEvents txtUsuariCognom1 As TextBox
    Friend WithEvents txtUsuariCognom2 As TextBox
    Friend WithEvents txtUsuariDI As TextBox
    Friend WithEvents txtUsuariNomUsuari As TextBox
    Friend WithEvents txtUsuariContrasenya As TextBox
    Friend WithEvents txtUsuariCorreu As TextBox
    Friend WithEvents txtUsuariTelefon As TextBox
    Friend WithEvents btnUsuariGuardar As Button
    Friend WithEvents btnUsuariEliminar As Button
    Friend WithEvents btnUsuariEnrere As Button
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
