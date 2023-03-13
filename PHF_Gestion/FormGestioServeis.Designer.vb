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
            MyBase.Dispose(disposing, components
)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestioServeis))
        Me.lblGestioServeiTitleName = New System.Windows.Forms.Label()
        Me.lblGestioServeiTitle = New System.Windows.Forms.Label()
        Me.txtGestioServeiName = New System.Windows.Forms.TextBox()
        Me.btnGestioServeiSave = New System.Windows.Forms.Button()
        Me.btnGestioServeiCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGestioServeiTitleName
        '
        Me.lblGestioServeiTitleName.AutoSize = True
        Me.lblGestioServeiTitleName.Location = New System.Drawing.Point(93, 118)
        Me.lblGestioServeiTitleName.Name = "lblGestioServeiTitleName"
        Me.lblGestioServeiTitleName.Size = New System.Drawing.Size(86, 20)
        Me.lblGestioServeiTitleName.TabIndex = 0
        Me.lblGestioServeiTitleName.Text = "Nom Servei"
        '
        'lblGestioServeiTitle
        '
        Me.lblGestioServeiTitle.AutoSize = True
        Me.lblGestioServeiTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGestioServeiTitle.Location = New System.Drawing.Point(171, 33)
        Me.lblGestioServeiTitle.Name = "lblGestioServeiTitle"
        Me.lblGestioServeiTitle.Size = New System.Drawing.Size(97, 41)
        Me.lblGestioServeiTitle.TabIndex = 1
        Me.lblGestioServeiTitle.Text = "Servei"
        '
        'txtGestioServeiName
        '
        Me.txtGestioServeiName.Location = New System.Drawing.Point(210, 115)
        Me.txtGestioServeiName.Name = "txtGestioServeiName"
        Me.txtGestioServeiName.Size = New System.Drawing.Size(125, 27)
        Me.txtGestioServeiName.TabIndex = 2
        '
        'btnGestioServeiSave
        '
        Me.btnGestioServeiSave.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioServeiSave.Location = New System.Drawing.Point(251, 208)
        Me.btnGestioServeiSave.Name = "btnGestioServeiSave"
        Me.btnGestioServeiSave.Size = New System.Drawing.Size(169, 72)
        Me.btnGestioServeiSave.TabIndex = 3
        Me.btnGestioServeiSave.Text = "Guardar"
        Me.btnGestioServeiSave.UseVisualStyleBackColor = False
        '
        'btnGestioServeiCancel
        '
        Me.btnGestioServeiCancel.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGestioServeiCancel.Location = New System.Drawing.Point(23, 208)
        Me.btnGestioServeiCancel.Name = "btnGestioServeiCancel"
        Me.btnGestioServeiCancel.Size = New System.Drawing.Size(169, 72)
        Me.btnGestioServeiCancel.TabIndex = 4
        Me.btnGestioServeiCancel.Text = "Cancelar"
        Me.btnGestioServeiCancel.UseVisualStyleBackColor = False
        '
        'FormGestioServeis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(433, 308)
        Me.Controls.Add(Me.btnGestioServeiCancel)
        Me.Controls.Add(Me.btnGestioServeiSave)
        Me.Controls.Add(Me.txtGestioServeiName)
        Me.Controls.Add(Me.lblGestioServeiTitle)
        Me.Controls.Add(Me.lblGestioServeiTitleName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGestioServeis"
        Me.Text = "Gestio Servei"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGestioServeiTitleName As Label
    Friend WithEvents lblGestioServeiTitle As Label
    Friend WithEvents txtGestioServeiName As TextBox
    Friend WithEvents btnGestioServeiSave As Button
    Friend WithEvents btnGestioServeiCancel As Button
End Class
