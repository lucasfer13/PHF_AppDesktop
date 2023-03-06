<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AfegirServei
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
        Dim btnAfegirServeiAfegir As System.Windows.Forms.Button
        Dim btnAfegirServeiEliminar As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AfegirServei))
        Me.dgvAfegirServeiLlista = New System.Windows.Forms.DataGridView()
        Me.pcbAfegirServeiUsuari = New System.Windows.Forms.PictureBox()
        Me.lblAfegirServeiTitol = New System.Windows.Forms.Label()
        btnAfegirServeiAfegir = New System.Windows.Forms.Button()
        btnAfegirServeiEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvAfegirServeiLlista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbAfegirServeiUsuari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAfegirServeiLlista
        '
        Me.dgvAfegirServeiLlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAfegirServeiLlista.Location = New System.Drawing.Point(12, 91)
        Me.dgvAfegirServeiLlista.Name = "dgvAfegirServeiLlista"
        Me.dgvAfegirServeiLlista.RowHeadersWidth = 51
        Me.dgvAfegirServeiLlista.RowTemplate.Height = 29
        Me.dgvAfegirServeiLlista.Size = New System.Drawing.Size(550, 347)
        Me.dgvAfegirServeiLlista.TabIndex = 0
        '
        'btnAfegirServeiAfegir
        '
        btnAfegirServeiAfegir.BackColor = System.Drawing.Color.Aquamarine
        btnAfegirServeiAfegir.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        btnAfegirServeiAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAfegirServeiAfegir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        btnAfegirServeiAfegir.Location = New System.Drawing.Point(588, 182)
        btnAfegirServeiAfegir.Name = "btnAfegirServeiAfegir"
        btnAfegirServeiAfegir.Size = New System.Drawing.Size(121, 32)
        btnAfegirServeiAfegir.TabIndex = 1
        btnAfegirServeiAfegir.Text = "Afegir Servei"
        btnAfegirServeiAfegir.UseVisualStyleBackColor = False
        '
        'btnAfegirServeiEliminar
        '
        btnAfegirServeiEliminar.BackColor = System.Drawing.Color.Aquamarine
        btnAfegirServeiEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        btnAfegirServeiEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnAfegirServeiEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        btnAfegirServeiEliminar.Location = New System.Drawing.Point(588, 282)
        btnAfegirServeiEliminar.Name = "btnAfegirServeiEliminar"
        btnAfegirServeiEliminar.Size = New System.Drawing.Size(121, 32)
        btnAfegirServeiEliminar.TabIndex = 2
        btnAfegirServeiEliminar.Text = "Eliminar Servei"
        btnAfegirServeiEliminar.UseVisualStyleBackColor = False
        '
        'pcbAfegirServeiUsuari
        '
        Me.pcbAfegirServeiUsuari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbAfegirServeiUsuari.Image = Global.PHF_Gestion.My.Resources.Resources.pngegg
        Me.pcbAfegirServeiUsuari.Location = New System.Drawing.Point(710, 12)
        Me.pcbAfegirServeiUsuari.Name = "pcbAfegirServeiUsuari"
        Me.pcbAfegirServeiUsuari.Size = New System.Drawing.Size(59, 62)
        Me.pcbAfegirServeiUsuari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbAfegirServeiUsuari.TabIndex = 5
        Me.pcbAfegirServeiUsuari.TabStop = False
        '
        'lblAfegirServeiTitol
        '
        Me.lblAfegirServeiTitol.AutoSize = True
        Me.lblAfegirServeiTitol.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAfegirServeiTitol.Location = New System.Drawing.Point(12, 25)
        Me.lblAfegirServeiTitol.Name = "lblAfegirServeiTitol"
        Me.lblAfegirServeiTitol.Size = New System.Drawing.Size(224, 39)
        Me.lblAfegirServeiTitol.TabIndex = 6
        Me.lblAfegirServeiTitol.Text = "Afegir Serveis"
        '
        'AfegirServei
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAfegirServeiTitol)
        Me.Controls.Add(Me.pcbAfegirServeiUsuari)
        Me.Controls.Add(btnAfegirServeiEliminar)
        Me.Controls.Add(btnAfegirServeiAfegir)
        Me.Controls.Add(Me.dgvAfegirServeiLlista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AfegirServei"
        Me.Text = "Pet Hotel Finder"
        CType(Me.dgvAfegirServeiLlista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbAfegirServeiUsuari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAfegirServeiLlista As DataGridView
    Friend WithEvents btnAfegirServeiAfegir As Button
    Friend WithEvents pcbAfegirServeiUsuari As PictureBox
    Friend WithEvents lblAfegirServeiTitol As Label
End Class
