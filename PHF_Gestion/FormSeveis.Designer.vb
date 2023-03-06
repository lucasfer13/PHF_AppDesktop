<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeveis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSeveis))
        Me.dgvServeis = New System.Windows.Forms.DataGridView()
        Me.btnServeisAdd = New System.Windows.Forms.Button()
        Me.btnServeisModify = New System.Windows.Forms.Button()
        Me.btnServeisBack = New System.Windows.Forms.Button()
        Me.btnServeisDelete = New System.Windows.Forms.Button()
        CType(Me.dgvServeis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvServeis
        '
        Me.dgvServeis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvServeis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServeis.Location = New System.Drawing.Point(12, 9)
        Me.dgvServeis.Name = "dgvServeis"
        Me.dgvServeis.RowHeadersWidth = 51
        Me.dgvServeis.RowTemplate.Height = 29
        Me.dgvServeis.Size = New System.Drawing.Size(583, 494)
        Me.dgvServeis.TabIndex = 0
        '
        'btnServeisAdd
        '
        Me.btnServeisAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnServeisAdd.BackColor = System.Drawing.Color.Aquamarine
        Me.btnServeisAdd.Location = New System.Drawing.Point(667, 12)
        Me.btnServeisAdd.Name = "btnServeisAdd"
        Me.btnServeisAdd.Size = New System.Drawing.Size(185, 94)
        Me.btnServeisAdd.TabIndex = 1
        Me.btnServeisAdd.Text = "Afegir Servei"
        Me.btnServeisAdd.UseVisualStyleBackColor = False
        '
        'btnServeisModify
        '
        Me.btnServeisModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnServeisModify.BackColor = System.Drawing.Color.Aquamarine
        Me.btnServeisModify.Location = New System.Drawing.Point(667, 112)
        Me.btnServeisModify.Name = "btnServeisModify"
        Me.btnServeisModify.Size = New System.Drawing.Size(185, 94)
        Me.btnServeisModify.TabIndex = 2
        Me.btnServeisModify.Text = "Modificar"
        Me.btnServeisModify.UseVisualStyleBackColor = False
        '
        'btnServeisBack
        '
        Me.btnServeisBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnServeisBack.BackColor = System.Drawing.Color.Aquamarine
        Me.btnServeisBack.Location = New System.Drawing.Point(667, 409)
        Me.btnServeisBack.Name = "btnServeisBack"
        Me.btnServeisBack.Size = New System.Drawing.Size(185, 94)
        Me.btnServeisBack.TabIndex = 3
        Me.btnServeisBack.Text = "Atras"
        Me.btnServeisBack.UseVisualStyleBackColor = False
        '
        'btnServeisDelete
        '
        Me.btnServeisDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnServeisDelete.BackColor = System.Drawing.Color.Aquamarine
        Me.btnServeisDelete.Location = New System.Drawing.Point(667, 212)
        Me.btnServeisDelete.Name = "btnServeisDelete"
        Me.btnServeisDelete.Size = New System.Drawing.Size(185, 94)
        Me.btnServeisDelete.TabIndex = 4
        Me.btnServeisDelete.Text = "Eliminar"
        Me.btnServeisDelete.UseVisualStyleBackColor = False
        '
        'FormSeveis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(904, 515)
        Me.Controls.Add(Me.btnServeisDelete)
        Me.Controls.Add(Me.btnServeisBack)
        Me.Controls.Add(Me.btnServeisModify)
        Me.Controls.Add(Me.btnServeisAdd)
        Me.Controls.Add(Me.dgvServeis)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(922, 562)
        Me.Name = "FormSeveis"
        Me.Text = "Serveis"
        CType(Me.dgvServeis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvServeis As DataGridView
    Friend WithEvents btnServeisAdd As Button
    Friend WithEvents btnServeisModify As Button
    Friend WithEvents btnServeisBack As Button
    Friend WithEvents btnServeisDelete As Button
End Class
