<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenúGestióGuarderies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenúGestióGuarderies))
        Me.lblMenuGestGuarderiesTitol = New System.Windows.Forms.Label()
        Me.pcbMenuGestGuarderiesUsuari = New System.Windows.Forms.PictureBox()
        Me.btnMenuGestGuarderiesAfegGuarderia = New System.Windows.Forms.Button()
        Me.btnMenuGestGuarderiesEliminarGuarderia = New System.Windows.Forms.Button()
        Me.btnMenuGestGuarderiesAtras = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.pcbMenuGestGuarderiesUsuari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMenuGestGuarderiesTitol
        '
        Me.lblMenuGestGuarderiesTitol.AutoSize = True
        Me.lblMenuGestGuarderiesTitol.Font = New System.Drawing.Font("Sitka Small", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMenuGestGuarderiesTitol.Location = New System.Drawing.Point(12, 9)
        Me.lblMenuGestGuarderiesTitol.Name = "lblMenuGestGuarderiesTitol"
        Me.lblMenuGestGuarderiesTitol.Size = New System.Drawing.Size(331, 42)
        Me.lblMenuGestGuarderiesTitol.TabIndex = 0
        Me.lblMenuGestGuarderiesTitol.Text = "Gestió de Guarderies"
        '
        'pcbMenuGestGuarderiesUsuari
        '
        Me.pcbMenuGestGuarderiesUsuari.Image = Global.PHF_Gestion.My.Resources.Resources.pngegg
        Me.pcbMenuGestGuarderiesUsuari.Location = New System.Drawing.Point(694, 12)
        Me.pcbMenuGestGuarderiesUsuari.Name = "pcbMenuGestGuarderiesUsuari"
        Me.pcbMenuGestGuarderiesUsuari.Size = New System.Drawing.Size(71, 62)
        Me.pcbMenuGestGuarderiesUsuari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbMenuGestGuarderiesUsuari.TabIndex = 1
        Me.pcbMenuGestGuarderiesUsuari.TabStop = False
        '
        'btnMenuGestGuarderiesAfegGuarderia
        '
        Me.btnMenuGestGuarderiesAfegGuarderia.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuGestGuarderiesAfegGuarderia.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuGestGuarderiesAfegGuarderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuGestGuarderiesAfegGuarderia.Location = New System.Drawing.Point(577, 156)
        Me.btnMenuGestGuarderiesAfegGuarderia.Name = "btnMenuGestGuarderiesAfegGuarderia"
        Me.btnMenuGestGuarderiesAfegGuarderia.Size = New System.Drawing.Size(123, 51)
        Me.btnMenuGestGuarderiesAfegGuarderia.TabIndex = 3
        Me.btnMenuGestGuarderiesAfegGuarderia.Text = "Afegir Guarderia"
        Me.btnMenuGestGuarderiesAfegGuarderia.UseVisualStyleBackColor = False
        '
        'btnMenuGestGuarderiesEliminarGuarderia
        '
        Me.btnMenuGestGuarderiesEliminarGuarderia.BackColor = System.Drawing.Color.Aquamarine
        Me.btnMenuGestGuarderiesEliminarGuarderia.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnMenuGestGuarderiesEliminarGuarderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuGestGuarderiesEliminarGuarderia.Location = New System.Drawing.Point(577, 238)
        Me.btnMenuGestGuarderiesEliminarGuarderia.Name = "btnMenuGestGuarderiesEliminarGuarderia"
        Me.btnMenuGestGuarderiesEliminarGuarderia.Size = New System.Drawing.Size(123, 61)
        Me.btnMenuGestGuarderiesEliminarGuarderia.TabIndex = 4
        Me.btnMenuGestGuarderiesEliminarGuarderia.Text = "Eliminar Guarderia"
        Me.btnMenuGestGuarderiesEliminarGuarderia.UseVisualStyleBackColor = False
        '
        'btnMenuGestGuarderiesAtras
        '
        Me.btnMenuGestGuarderiesAtras.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnMenuGestGuarderiesAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMenuGestGuarderiesAtras.Enabled = False
        Me.btnMenuGestGuarderiesAtras.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.btnMenuGestGuarderiesAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuGestGuarderiesAtras.Font = New System.Drawing.Font("Segoe UI", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMenuGestGuarderiesAtras.Image = CType(resources.GetObject("btnMenuGestGuarderiesAtras.Image"), System.Drawing.Image)
        Me.btnMenuGestGuarderiesAtras.Location = New System.Drawing.Point(721, 372)
        Me.btnMenuGestGuarderiesAtras.Name = "btnMenuGestGuarderiesAtras"
        Me.btnMenuGestGuarderiesAtras.Size = New System.Drawing.Size(44, 35)
        Me.btnMenuGestGuarderiesAtras.TabIndex = 6
        Me.btnMenuGestGuarderiesAtras.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(478, 335)
        Me.DataGridView1.TabIndex = 7
        '
        'MenúGestióGuarderies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(795, 419)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnMenuGestGuarderiesAtras)
        Me.Controls.Add(Me.btnMenuGestGuarderiesEliminarGuarderia)
        Me.Controls.Add(Me.btnMenuGestGuarderiesAfegGuarderia)
        Me.Controls.Add(Me.pcbMenuGestGuarderiesUsuari)
        Me.Controls.Add(Me.lblMenuGestGuarderiesTitol)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(813, 466)
        Me.MinimumSize = New System.Drawing.Size(813, 466)
        Me.Name = "MenúGestióGuarderies"
        Me.Text = "Pet Hotel Finder"
        CType(Me.pcbMenuGestGuarderiesUsuari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenuGestGuarderiesTitol As Label
    Friend WithEvents pcbMenuGestGuarderiesUsuari As PictureBox
    Friend WithEvents btnMenuGestGuarderiesAfegGuarderia As Button
    Friend WithEvents btnMenuGestGuarderiesEliminarGuarderia As Button
    Protected WithEvents btnMenuGestGuarderiesAtras As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
