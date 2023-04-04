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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormSeveis))
        dgvServeis = New DataGridView()
        btnServeisAdd = New Button()
        btnServeisBack = New Button()
        lblServeisTitol = New Label()
        txtServeisBuscar = New TextBox()
        btnServeisReset = New Button()
        bdgServeisVista = New BindingSource(components)
        CType(dgvServeis, ComponentModel.ISupportInitialize).BeginInit()
        CType(bdgServeisVista, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvServeis
        ' 
        dgvServeis.AllowUserToAddRows = False
        dgvServeis.AllowUserToDeleteRows = False
        dgvServeis.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvServeis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvServeis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvServeis.Location = New Point(12, 9)
        dgvServeis.MultiSelect = False
        dgvServeis.Name = "dgvServeis"
        dgvServeis.ReadOnly = True
        dgvServeis.RowHeadersWidth = 51
        dgvServeis.RowTemplate.Height = 29
        dgvServeis.Size = New Size(727, 597)
        dgvServeis.TabIndex = 0
        ' 
        ' btnServeisAdd
        ' 
        btnServeisAdd.Anchor = AnchorStyles.Right
        btnServeisAdd.BackColor = Color.Aquamarine
        btnServeisAdd.Location = New Point(811, 224)
        btnServeisAdd.Name = "btnServeisAdd"
        btnServeisAdd.Size = New Size(185, 94)
        btnServeisAdd.TabIndex = 1
        btnServeisAdd.Text = "Afegir Servei"
        btnServeisAdd.UseVisualStyleBackColor = False
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
        Controls.Add(btnServeisBack)
        Controls.Add(btnServeisAdd)
        Controls.Add(dgvServeis)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1066, 665)
        Name = "FormSeveis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Serveis"
        WindowState = FormWindowState.Maximized
        CType(dgvServeis, ComponentModel.ISupportInitialize).EndInit()
        CType(bdgServeisVista, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvServeis As DataGridView
    Friend WithEvents btnServeisAdd As Button
    Friend WithEvents btnServeisBack As Button
    Friend WithEvents lblServeisTitol As Label
    Friend WithEvents txtServeisBuscar As TextBox
    Friend WithEvents btnServeisReset As Button
    Friend WithEvents bdgServeisVista As BindingSource
End Class
