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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TipusAnimal))
        Me.lblAnimalAnimal = New System.Windows.Forms.Label()
        Me.txtgestAnimalnom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAnimalAfeg = New System.Windows.Forms.Button()
        Me.btnAnimalElimin = New System.Windows.Forms.Button()
        Me.btnAnimalBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAnimalAnimal
        '
        Me.lblAnimalAnimal.AutoSize = True
        Me.lblAnimalAnimal.Font = New System.Drawing.Font("Sitka Small", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAnimalAnimal.Location = New System.Drawing.Point(118, 164)
        Me.lblAnimalAnimal.Name = "lblAnimalAnimal"
        Me.lblAnimalAnimal.Size = New System.Drawing.Size(103, 34)
        Me.lblAnimalAnimal.TabIndex = 0
        Me.lblAnimalAnimal.Text = "Animal"
        '
        'txtgestAnimalnom
        '
        Me.txtgestAnimalnom.Location = New System.Drawing.Point(299, 171)
        Me.txtgestAnimalnom.Name = "txtgestAnimalnom"
        Me.txtgestAnimalnom.Size = New System.Drawing.Size(318, 27)
        Me.txtgestAnimalnom.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(35, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 34)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tipus Animal "
        '
        'btnAnimalAfeg
        '
        Me.btnAnimalAfeg.BackColor = System.Drawing.Color.Aquamarine
        Me.btnAnimalAfeg.Location = New System.Drawing.Point(482, 306)
        Me.btnAnimalAfeg.Name = "btnAnimalAfeg"
        Me.btnAnimalAfeg.Size = New System.Drawing.Size(135, 64)
        Me.btnAnimalAfeg.TabIndex = 7
        Me.btnAnimalAfeg.Text = "Afegir"
        Me.btnAnimalAfeg.UseVisualStyleBackColor = False
        '
        'btnAnimalElimin
        '
        Me.btnAnimalElimin.BackColor = System.Drawing.Color.Aquamarine
        Me.btnAnimalElimin.Location = New System.Drawing.Point(289, 306)
        Me.btnAnimalElimin.Name = "btnAnimalElimin"
        Me.btnAnimalElimin.Size = New System.Drawing.Size(135, 64)
        Me.btnAnimalElimin.TabIndex = 8
        Me.btnAnimalElimin.Text = "Eliminar"
        Me.btnAnimalElimin.UseVisualStyleBackColor = False
        '
        'btnAnimalBack
        '
        Me.btnAnimalBack.BackColor = System.Drawing.Color.Aquamarine
        Me.btnAnimalBack.Location = New System.Drawing.Point(102, 306)
        Me.btnAnimalBack.Name = "btnAnimalBack"
        Me.btnAnimalBack.Size = New System.Drawing.Size(135, 64)
        Me.btnAnimalBack.TabIndex = 9
        Me.btnAnimalBack.Text = "Enrrere"
        Me.btnAnimalBack.UseVisualStyleBackColor = False
        '
        'TipusAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(698, 429)
        Me.Controls.Add(Me.btnAnimalBack)
        Me.Controls.Add(Me.btnAnimalElimin)
        Me.Controls.Add(Me.btnAnimalAfeg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtgestAnimalnom)
        Me.Controls.Add(Me.lblAnimalAnimal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TipusAnimal"
        Me.Text = "Tipus Animal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAnimalAnimal As Label
    Friend WithEvents txtgestAnimalnom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAnimalAfeg As Button
    Friend WithEvents btnAnimalElimin As Button
    Friend WithEvents btnAnimalBack As Button
End Class
