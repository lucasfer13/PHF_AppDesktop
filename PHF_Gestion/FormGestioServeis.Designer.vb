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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormGestioServeis))
        lblGestioServeiTitleName = New Label()
        lblGestioServeiTitle = New Label()
        txtGestioServeiName = New TextBox()
        btnGestioServeiSave = New Button()
        btnGestioServeiCancel = New Button()
        SuspendLayout()
        ' 
        ' lblGestioServeiTitleName
        ' 
        lblGestioServeiTitleName.Anchor = AnchorStyles.None
        lblGestioServeiTitleName.AutoSize = True
        lblGestioServeiTitleName.Location = New Point(93, 118)
        lblGestioServeiTitleName.Name = "lblGestioServeiTitleName"
        lblGestioServeiTitleName.Size = New Size(86, 20)
        lblGestioServeiTitleName.TabIndex = 0
        lblGestioServeiTitleName.Text = "Nom Servei"' 
        ' lblGestioServeiTitle
        ' 
        lblGestioServeiTitle.Anchor = AnchorStyles.Top
        lblGestioServeiTitle.AutoSize = True
        lblGestioServeiTitle.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblGestioServeiTitle.Location = New Point(171, 33)
        lblGestioServeiTitle.Name = "lblGestioServeiTitle"
        lblGestioServeiTitle.Size = New Size(97, 41)
        lblGestioServeiTitle.TabIndex = 1
        lblGestioServeiTitle.Text = "Servei"' 
        ' txtGestioServeiName
        ' 
        txtGestioServeiName.Anchor = AnchorStyles.None
        txtGestioServeiName.Location = New Point(210, 115)
        txtGestioServeiName.Name = "txtGestioServeiName"
        txtGestioServeiName.Size = New Size(125, 27)
        txtGestioServeiName.TabIndex = 2
        ' 
        ' btnGestioServeiSave
        ' 
        btnGestioServeiSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGestioServeiSave.BackColor = Color.Aquamarine
        btnGestioServeiSave.Location = New Point(251, 208)
        btnGestioServeiSave.Name = "btnGestioServeiSave"
        btnGestioServeiSave.Size = New Size(169, 72)
        btnGestioServeiSave.TabIndex = 3
        btnGestioServeiSave.Text = "Guardar"
        btnGestioServeiSave.UseVisualStyleBackColor = False
        ' 
        ' btnGestioServeiCancel
        ' 
        btnGestioServeiCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnGestioServeiCancel.BackColor = Color.Aquamarine
        btnGestioServeiCancel.Location = New Point(23, 208)
        btnGestioServeiCancel.Name = "btnGestioServeiCancel"
        btnGestioServeiCancel.Size = New Size(169, 72)
        btnGestioServeiCancel.TabIndex = 4
        btnGestioServeiCancel.Text = "Cancelar"
        btnGestioServeiCancel.UseVisualStyleBackColor = False
        ' 
        ' FormGestioServeis
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(436, 291)
        Controls.Add(btnGestioServeiCancel)
        Controls.Add(btnGestioServeiSave)
        Controls.Add(txtGestioServeiName)
        Controls.Add(lblGestioServeiTitle)
        Controls.Add(lblGestioServeiTitleName)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormGestioServeis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Servei"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGestioServeiTitleName As Label
    Friend WithEvents lblGestioServeiTitle As Label
    Friend WithEvents txtGestioServeiName As TextBox
    Friend WithEvents btnGestioServeiSave As Button
    Friend WithEvents btnGestioServeiCancel As Button
End Class
