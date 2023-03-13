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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(TipusAnimal))
        lblAnimalAnimal = New Label()
        txtgestAnimalnom = New TextBox()
        Label1 = New Label()
        btnAnimalAfeg = New Button()
        btnAnimalElimin = New Button()
        btnAnimalBack = New Button()
        SuspendLayout()
        ' 
        ' lblAnimalAnimal
        ' 
        lblAnimalAnimal.AutoSize = True
        lblAnimalAnimal.Font = New Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblAnimalAnimal.Location = New Point(118, 164)
        lblAnimalAnimal.Name = "lblAnimalAnimal"
        lblAnimalAnimal.Size = New Size(103, 34)
        lblAnimalAnimal.TabIndex = 0
        lblAnimalAnimal.Text = "Animal"' 
        ' txtgestAnimalnom
        ' 
        txtgestAnimalnom.Location = New Point(299, 171)
        txtgestAnimalnom.Name = "txtgestAnimalnom"
        txtgestAnimalnom.Size = New Size(318, 27)
        txtgestAnimalnom.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(35, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 34)
        Label1.TabIndex = 6
        Label1.Text = "Tipus Animal "' 
        ' btnAnimalAfeg
        ' 
        btnAnimalAfeg.BackColor = Color.Aquamarine
        btnAnimalAfeg.Location = New Point(482, 306)
        btnAnimalAfeg.Name = "btnAnimalAfeg"
        btnAnimalAfeg.Size = New Size(135, 64)
        btnAnimalAfeg.TabIndex = 7
        btnAnimalAfeg.Text = "Afegir"
        btnAnimalAfeg.UseVisualStyleBackColor = False
        ' 
        ' btnAnimalElimin
        ' 
        btnAnimalElimin.BackColor = Color.Aquamarine
        btnAnimalElimin.Location = New Point(289, 306)
        btnAnimalElimin.Name = "btnAnimalElimin"
        btnAnimalElimin.Size = New Size(135, 64)
        btnAnimalElimin.TabIndex = 8
        btnAnimalElimin.Text = "Eliminar"
        btnAnimalElimin.UseVisualStyleBackColor = False
        ' 
        ' btnAnimalBack
        ' 
        btnAnimalBack.BackColor = Color.Aquamarine
        btnAnimalBack.Location = New Point(102, 306)
        btnAnimalBack.Name = "btnAnimalBack"
        btnAnimalBack.Size = New Size(135, 64)
        btnAnimalBack.TabIndex = 9
        btnAnimalBack.Text = "Enrrere"
        btnAnimalBack.UseVisualStyleBackColor = False
        ' 
        ' TipusAnimal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(698, 429)
        Controls.Add(btnAnimalBack)
        Controls.Add(btnAnimalElimin)
        Controls.Add(btnAnimalAfeg)
        Controls.Add(Label1)
        Controls.Add(txtgestAnimalnom)
        Controls.Add(lblAnimalAnimal)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "TipusAnimal"
        Text = "Tipus Animal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAnimalAnimal As Label
    Friend WithEvents txtgestAnimalnom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAnimalAfeg As Button
    Friend WithEvents btnAnimalElimin As Button
    Friend WithEvents btnAnimalBack As Button
End Class
