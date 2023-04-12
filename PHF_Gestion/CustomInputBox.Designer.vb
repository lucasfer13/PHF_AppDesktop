<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomInputBox
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
        txtCanviContrasenyaPass = New TextBox()
        lblCanviContrasenyaTitol = New Label()
        btnCanviContrasenyaCancelar = New Button()
        btnCanviContrasenyaAcceptar = New Button()
        SuspendLayout()
        ' 
        ' txtCanviContrasenyaPass
        ' 
        txtCanviContrasenyaPass.Location = New Point(42, 93)
        txtCanviContrasenyaPass.Name = "txtCanviContrasenyaPass"
        txtCanviContrasenyaPass.PasswordChar = "*"c
        txtCanviContrasenyaPass.Size = New Size(345, 27)
        txtCanviContrasenyaPass.TabIndex = 0
        ' 
        ' lblCanviContrasenyaTitol
        ' 
        lblCanviContrasenyaTitol.Location = New Point(42, 30)
        lblCanviContrasenyaTitol.Name = "lblCanviContrasenyaTitol"
        lblCanviContrasenyaTitol.Size = New Size(345, 41)
        lblCanviContrasenyaTitol.TabIndex = 1
        ' 
        ' btnCanviContrasenyaCancelar
        ' 
        btnCanviContrasenyaCancelar.Location = New Point(293, 145)
        btnCanviContrasenyaCancelar.Name = "btnCanviContrasenyaCancelar"
        btnCanviContrasenyaCancelar.Size = New Size(94, 29)
        btnCanviContrasenyaCancelar.TabIndex = 2
        btnCanviContrasenyaCancelar.Text = "Cancelar"
        btnCanviContrasenyaCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnCanviContrasenyaAcceptar
        ' 
        btnCanviContrasenyaAcceptar.Location = New Point(193, 145)
        btnCanviContrasenyaAcceptar.Name = "btnCanviContrasenyaAcceptar"
        btnCanviContrasenyaAcceptar.Size = New Size(94, 29)
        btnCanviContrasenyaAcceptar.TabIndex = 3
        btnCanviContrasenyaAcceptar.Text = "Acceptar"
        btnCanviContrasenyaAcceptar.UseVisualStyleBackColor = True
        ' 
        ' CustomInputBox
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(425, 186)
        Controls.Add(btnCanviContrasenyaAcceptar)
        Controls.Add(btnCanviContrasenyaCancelar)
        Controls.Add(lblCanviContrasenyaTitol)
        Controls.Add(txtCanviContrasenyaPass)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "CustomInputBox"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Canvi contrasenya"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCanviContrasenyaPass As TextBox
    Friend WithEvents lblCanviContrasenyaTitol As Label
    Friend WithEvents btnCanviContrasenyaCancelar As Button
    Friend WithEvents btnCanviContrasenyaAcceptar As Button
End Class
