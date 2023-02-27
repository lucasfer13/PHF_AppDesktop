<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Valoracions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Valoracions))
        Me.btnValoraciobck = New System.Windows.Forms.Button()
        Me.tblValoracionsView = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnValoraciobck
        '
        Me.btnValoraciobck.BackColor = System.Drawing.Color.Aquamarine
        Me.btnValoraciobck.Location = New System.Drawing.Point(53, 345)
        Me.btnValoraciobck.Name = "btnValoraciobck"
        Me.btnValoraciobck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnValoraciobck.Size = New System.Drawing.Size(186, 64)
        Me.btnValoraciobck.TabIndex = 0
        Me.btnValoraciobck.Text = "Back"
        Me.btnValoraciobck.UseVisualStyleBackColor = False
        '
        'tblValoracionsView
        '
        Me.tblValoracionsView.ColumnCount = 1
        Me.tblValoracionsView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblValoracionsView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblValoracionsView.Location = New System.Drawing.Point(464, 28)
        Me.tblValoracionsView.Name = "tblValoracionsView"
        Me.tblValoracionsView.RowCount = 2
        Me.tblValoracionsView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.28084!))
        Me.tblValoracionsView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.71916!))
        Me.tblValoracionsView.Size = New System.Drawing.Size(285, 381)
        Me.tblValoracionsView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(53, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valoracions"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Valoracions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tblValoracionsView)
        Me.Controls.Add(Me.btnValoraciobck)
        Me.Name = "Valoracions"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValoraciobck As Button
    Friend WithEvents tblValoracionsView As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
