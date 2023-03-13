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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormSeveis))
        dgvServeis = New DataGridView()
        btnServeisAdd = New Button()
        btnServeisModify = New Button()
        btnServeisBack = New Button()
        btnServeisDelete = New Button()
        lblServeisTitol = New Label()
        txtServeisBuscar = New TextBox()
        btnServeisReset = New Button()
        CType(dgvServeis, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvServeis
        ' 
        dgvServeis.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvServeis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvServeis.Location = New Point(12, 9)
        dgvServeis.Name = "dgvServeis"
        dgvServeis.RowHeadersWidth = 51
        dgvServeis.RowTemplate.Height = 29
        dgvServeis.Size = New Size(727, 597)
        dgvServeis.TabIndex = 0
        ' 
        ' btnServeisAdd
        ' 
        btnServeisAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnServeisAdd.BackColor = Color.Aquamarine
        btnServeisAdd.Location = New Point(811, 132)
        btnServeisAdd.Name = "btnServeisAdd"
        btnServeisAdd.Size = New Size(185, 94)
        btnServeisAdd.TabIndex = 1
        btnServeisAdd.Text = "Afegir Servei"
        btnServeisAdd.UseVisualStyleBackColor = False
        ' 
        ' btnServeisModify
        ' 
        btnServeisModify.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnServeisModify.BackColor = Color.Aquamarine
        btnServeisModify.Location = New Point(811, 232)
        btnServeisModify.Name = "btnServeisModify"
        btnServeisModify.Size = New Size(185, 94)
        btnServeisModify.TabIndex = 2
        btnServeisModify.Text = "Modificar"
        btnServeisModify.UseVisualStyleBackColor = False
        ' 
        ' btnServeisBack
        ' 
        btnServeisBack.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnServeisBack.BackColor = Color.Aquamarine
        btnServeisBack.Location = New Point(811, 512)
        btnServeisBack.Name = "btnServeisBack"
        btnServeisBack.Size = New Size(185, 94)
        btnServeisBack.TabIndex = 3
        btnServeisBack.Text = "Atras"
        btnServeisBack.UseVisualStyleBackColor = False
        ' 
        ' btnServeisDelete
        ' 
        btnServeisDelete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnServeisDelete.BackColor = Color.Aquamarine
        btnServeisDelete.Location = New Point(811, 332)
        btnServeisDelete.Name = "btnServeisDelete"
        btnServeisDelete.Size = New Size(185, 94)
        btnServeisDelete.TabIndex = 4
        btnServeisDelete.Text = "Eliminar"
        btnServeisDelete.UseVisualStyleBackColor = False
        ' 
        ' lblServeisTitol
        ' 
        lblServeisTitol.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblServeisTitol.AutoSize = True
        lblServeisTitol.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblServeisTitol.Location = New Point(838, 9)
        lblServeisTitol.Name = "lblServeisTitol"
        lblServeisTitol.Size = New Size(104, 38)
        lblServeisTitol.TabIndex = 5
        lblServeisTitol.Text = "Serveis"' 
        ' txtServeisBuscar
        ' 
        txtServeisBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtServeisBuscar.Location = New Point(783, 69)
        txtServeisBuscar.Name = "txtServeisBuscar"
        txtServeisBuscar.Size = New Size(159, 27)
        txtServeisBuscar.TabIndex = 6
        ' 
        ' btnServeisReset
        ' 
        btnServeisReset.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnServeisReset.BackColor = Color.Aquamarine
        btnServeisReset.Location = New Point(948, 69)
        btnServeisReset.Name = "btnServeisReset"
        btnServeisReset.Size = New Size(73, 27)
        btnServeisReset.TabIndex = 7
        btnServeisReset.Text = "Reset"
        btnServeisReset.UseVisualStyleBackColor = False
        ' 
        ' FormSeveis
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1048, 618)
        Controls.Add(btnServeisReset)
        Controls.Add(txtServeisBuscar)
        Controls.Add(lblServeisTitol)
        Controls.Add(btnServeisDelete)
        Controls.Add(btnServeisBack)
        Controls.Add(btnServeisModify)
        Controls.Add(btnServeisAdd)
        Controls.Add(dgvServeis)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1066, 665)
        Name = "FormSeveis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Serveis"
        CType(dgvServeis, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvServeis As DataGridView
    Friend WithEvents btnServeisAdd As Button
    Friend WithEvents btnServeisModify As Button
    Friend WithEvents btnServeisBack As Button
    Friend WithEvents btnServeisDelete As Button
    Friend WithEvents lblServeisTitol As Label
    Friend WithEvents txtServeisBuscar As TextBox
    Friend WithEvents btnServeisReset As Button
End Class
