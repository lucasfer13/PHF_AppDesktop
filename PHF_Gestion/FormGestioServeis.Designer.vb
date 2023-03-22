<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestioServeis
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormGestioServeis))
        lblGestioServeiTitleName = New Label()
        lblGestioServeiTitle = New Label()
        txtGestioServeiName = New TextBox()
        btnGestioServeiSave = New Button()
        btnGestioServeiCancel = New Button()
        btnGestioServeiEliminar = New Button()
        btnGestioServeiModify = New Button()
        txtGestioServeiDescripcio = New TextBox()
        lblGestioServeiDescripcio = New Label()
        erpGestioServeiErrors = New ErrorProvider(components)
        CType(erpGestioServeiErrors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblGestioServeiTitleName
        ' 
        lblGestioServeiTitleName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblGestioServeiTitleName.AutoSize = True
        lblGestioServeiTitleName.Location = New Point(62, 117)
        lblGestioServeiTitleName.Name = "lblGestioServeiTitleName"
        lblGestioServeiTitleName.Size = New Size(86, 20)
        lblGestioServeiTitleName.TabIndex = 0
        lblGestioServeiTitleName.Text = "Nom Servei"' 
        ' lblGestioServeiTitle
        ' 
        lblGestioServeiTitle.Anchor = AnchorStyles.Top
        lblGestioServeiTitle.AutoSize = True
        lblGestioServeiTitle.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioServeiTitle.Location = New Point(314, 9)
        lblGestioServeiTitle.Name = "lblGestioServeiTitle"
        lblGestioServeiTitle.Size = New Size(97, 41)
        lblGestioServeiTitle.TabIndex = 1
        lblGestioServeiTitle.Text = "Servei"' 
        ' txtGestioServeiName
        ' 
        txtGestioServeiName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtGestioServeiName.Enabled = False
        txtGestioServeiName.Location = New Point(171, 110)
        txtGestioServeiName.Name = "txtGestioServeiName"
        txtGestioServeiName.Size = New Size(475, 27)
        txtGestioServeiName.TabIndex = 1
        ' 
        ' btnGestioServeiSave
        ' 
        btnGestioServeiSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGestioServeiSave.BackColor = Color.Aquamarine
        btnGestioServeiSave.Enabled = False
        btnGestioServeiSave.Location = New Point(555, 316)
        btnGestioServeiSave.Name = "btnGestioServeiSave"
        btnGestioServeiSave.Size = New Size(156, 71)
        btnGestioServeiSave.TabIndex = 6
        btnGestioServeiSave.Text = "Guardar"
        btnGestioServeiSave.UseVisualStyleBackColor = False
        ' 
        ' btnGestioServeiCancel
        ' 
        btnGestioServeiCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnGestioServeiCancel.BackColor = Color.Aquamarine
        btnGestioServeiCancel.Location = New Point(15, 316)
        btnGestioServeiCancel.Name = "btnGestioServeiCancel"
        btnGestioServeiCancel.Size = New Size(156, 71)
        btnGestioServeiCancel.TabIndex = 3
        btnGestioServeiCancel.Text = "Enrere"
        btnGestioServeiCancel.UseVisualStyleBackColor = False
        ' 
        ' btnGestioServeiEliminar
        ' 
        btnGestioServeiEliminar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGestioServeiEliminar.BackColor = Color.Aquamarine
        btnGestioServeiEliminar.Location = New Point(375, 316)
        btnGestioServeiEliminar.Name = "btnGestioServeiEliminar"
        btnGestioServeiEliminar.Size = New Size(156, 71)
        btnGestioServeiEliminar.TabIndex = 5
        btnGestioServeiEliminar.Text = "Eliminar"
        btnGestioServeiEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnGestioServeiModify
        ' 
        btnGestioServeiModify.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGestioServeiModify.BackColor = Color.Aquamarine
        btnGestioServeiModify.Location = New Point(195, 316)
        btnGestioServeiModify.Name = "btnGestioServeiModify"
        btnGestioServeiModify.Size = New Size(156, 71)
        btnGestioServeiModify.TabIndex = 4
        btnGestioServeiModify.Text = "Modificar"
        btnGestioServeiModify.UseVisualStyleBackColor = False
        ' 
        ' txtGestioServeiDescripcio
        ' 
        txtGestioServeiDescripcio.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtGestioServeiDescripcio.Enabled = False
        txtGestioServeiDescripcio.Location = New Point(171, 183)
        txtGestioServeiDescripcio.Multiline = True
        txtGestioServeiDescripcio.Name = "txtGestioServeiDescripcio"
        txtGestioServeiDescripcio.Size = New Size(475, 69)
        txtGestioServeiDescripcio.TabIndex = 2
        ' 
        ' lblGestioServeiDescripcio
        ' 
        lblGestioServeiDescripcio.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblGestioServeiDescripcio.AutoSize = True
        lblGestioServeiDescripcio.Location = New Point(62, 183)
        lblGestioServeiDescripcio.Name = "lblGestioServeiDescripcio"
        lblGestioServeiDescripcio.Size = New Size(90, 20)
        lblGestioServeiDescripcio.TabIndex = 8
        lblGestioServeiDescripcio.Text = "Descripción:"' 
        ' erpGestioServeiErrors
        ' 
        erpGestioServeiErrors.ContainerControl = Me
        ' 
        ' FormGestioServeis
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(713, 399)
        Controls.Add(lblGestioServeiDescripcio)
        Controls.Add(txtGestioServeiDescripcio)
        Controls.Add(btnGestioServeiModify)
        Controls.Add(btnGestioServeiEliminar)
        Controls.Add(btnGestioServeiCancel)
        Controls.Add(btnGestioServeiSave)
        Controls.Add(txtGestioServeiName)
        Controls.Add(lblGestioServeiTitle)
        Controls.Add(lblGestioServeiTitleName)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(731, 446)
        Name = "FormGestioServeis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Servei"
        CType(erpGestioServeiErrors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGestioServeiTitleName As Label
    Friend WithEvents lblGestioServeiTitle As Label
    Friend WithEvents txtGestioServeiName As TextBox
    Friend WithEvents btnGestioServeiSave As Button
    Friend WithEvents btnGestioServeiCancel As Button
    Friend WithEvents btnGestioServeiEliminar As Button
    Friend WithEvents btnGestioServeiModify As Button
    Friend WithEvents txtGestioServeiDescripcio As TextBox
    Friend WithEvents lblGestioServeiDescripcio As Label
    Friend WithEvents erpGestioServeiErrors As ErrorProvider
End Class
