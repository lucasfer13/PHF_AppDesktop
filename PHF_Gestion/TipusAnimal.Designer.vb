<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipusAnimal
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(TipusAnimal))
        lblAnimalAnimal = New Label()
        txtgestAnimalnom = New TextBox()
        Label1 = New Label()
        btnAnimalAfeg = New Button()
        btnAnimalElimin = New Button()
        btnAnimalBack = New Button()
        btnTipusAnimalModify = New Button()
        erpTipusAnimalErrors = New ErrorProvider(components)
        CType(erpTipusAnimalErrors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblAnimalAnimal
        ' 
        lblAnimalAnimal.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblAnimalAnimal.AutoSize = True
        lblAnimalAnimal.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblAnimalAnimal.Location = New Point(122, 133)
        lblAnimalAnimal.Name = "lblAnimalAnimal"
        lblAnimalAnimal.Size = New Size(59, 20)
        lblAnimalAnimal.TabIndex = 0
        lblAnimalAnimal.Text = "Animal:"' 
        ' txtgestAnimalnom
        ' 
        txtgestAnimalnom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtgestAnimalnom.Enabled = False
        txtgestAnimalnom.Location = New Point(262, 130)
        txtgestAnimalnom.Name = "txtgestAnimalnom"
        txtgestAnimalnom.Size = New Size(291, 27)
        txtgestAnimalnom.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(275, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 31)
        Label1.TabIndex = 6
        Label1.Text = "Tipus Animal "' 
        ' btnAnimalAfeg
        ' 
        btnAnimalAfeg.Anchor = AnchorStyles.Bottom
        btnAnimalAfeg.BackColor = Color.Aquamarine
        btnAnimalAfeg.Enabled = False
        btnAnimalAfeg.Location = New Point(526, 261)
        btnAnimalAfeg.Name = "btnAnimalAfeg"
        btnAnimalAfeg.Size = New Size(135, 64)
        btnAnimalAfeg.TabIndex = 5
        btnAnimalAfeg.Text = "Afegir"
        btnAnimalAfeg.UseVisualStyleBackColor = False
        ' 
        ' btnAnimalElimin
        ' 
        btnAnimalElimin.Anchor = AnchorStyles.Bottom
        btnAnimalElimin.BackColor = Color.Aquamarine
        btnAnimalElimin.Location = New Point(190, 261)
        btnAnimalElimin.Name = "btnAnimalElimin"
        btnAnimalElimin.Size = New Size(135, 64)
        btnAnimalElimin.TabIndex = 3
        btnAnimalElimin.Text = "Eliminar"
        btnAnimalElimin.UseVisualStyleBackColor = False
        ' 
        ' btnAnimalBack
        ' 
        btnAnimalBack.Anchor = AnchorStyles.Bottom
        btnAnimalBack.BackColor = Color.Aquamarine
        btnAnimalBack.Location = New Point(22, 261)
        btnAnimalBack.Name = "btnAnimalBack"
        btnAnimalBack.Size = New Size(135, 64)
        btnAnimalBack.TabIndex = 2
        btnAnimalBack.Text = "Enrrere"
        btnAnimalBack.UseVisualStyleBackColor = False
        ' 
        ' btnTipusAnimalModify
        ' 
        btnTipusAnimalModify.Anchor = AnchorStyles.Bottom
        btnTipusAnimalModify.BackColor = Color.Aquamarine
        btnTipusAnimalModify.Location = New Point(358, 261)
        btnTipusAnimalModify.Name = "btnTipusAnimalModify"
        btnTipusAnimalModify.Size = New Size(135, 64)
        btnTipusAnimalModify.TabIndex = 4
        btnTipusAnimalModify.Text = "Modificar"
        btnTipusAnimalModify.UseVisualStyleBackColor = False
        ' 
        ' erpTipusAnimalErrors
        ' 
        erpTipusAnimalErrors.ContainerControl = Me
        ' 
        ' TipusAnimal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(676, 355)
        Controls.Add(btnTipusAnimalModify)
        Controls.Add(btnAnimalBack)
        Controls.Add(btnAnimalElimin)
        Controls.Add(btnAnimalAfeg)
        Controls.Add(Label1)
        Controls.Add(txtgestAnimalnom)
        Controls.Add(lblAnimalAnimal)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(694, 402)
        Name = "TipusAnimal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tipus Animal"
        CType(erpTipusAnimalErrors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAnimalAnimal As Label
    Friend WithEvents txtgestAnimalnom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAnimalAfeg As Button
    Friend WithEvents btnAnimalElimin As Button
    Friend WithEvents btnAnimalBack As Button
    Friend WithEvents btnTipusAnimalModify As Button
    Friend WithEvents erpTipusAnimalErrors As ErrorProvider
End Class
