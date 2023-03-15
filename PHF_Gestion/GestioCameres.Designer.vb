<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestioCameres
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GestioCameres))
        dgvCameresLlistat = New DataGridView()
        btnCameresAfegir = New Button()
        btnCameresEnrere = New Button()
        lblCameresTitolBucar = New Label()
        txtCameresBuscar = New TextBox()
        btnCameresResetBusqueda = New Button()
        CType(dgvCameresLlistat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvCameresLlistat
        ' 
        dgvCameresLlistat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCameresLlistat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCameresLlistat.Location = New Point(12, 12)
        dgvCameresLlistat.Name = "dgvCameresLlistat"
        dgvCameresLlistat.RowHeadersWidth = 51
        dgvCameresLlistat.RowTemplate.Height = 29
        dgvCameresLlistat.Size = New Size(470, 418)
        dgvCameresLlistat.TabIndex = 0
        ' 
        ' btnCameresAfegir
        ' 
        btnCameresAfegir.Anchor = AnchorStyles.Right
        btnCameresAfegir.BackColor = Color.Aquamarine
        btnCameresAfegir.Location = New Point(554, 161)
        btnCameresAfegir.Name = "btnCameresAfegir"
        btnCameresAfegir.Size = New Size(176, 77)
        btnCameresAfegir.TabIndex = 1
        btnCameresAfegir.Text = "Afegir camera"
        btnCameresAfegir.UseVisualStyleBackColor = False
        ' 
        ' btnCameresEnrere
        ' 
        btnCameresEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCameresEnrere.BackColor = Color.Aquamarine
        btnCameresEnrere.Location = New Point(554, 353)
        btnCameresEnrere.Name = "btnCameresEnrere"
        btnCameresEnrere.Size = New Size(176, 77)
        btnCameresEnrere.TabIndex = 2
        btnCameresEnrere.Text = "Enrere"
        btnCameresEnrere.UseVisualStyleBackColor = False
        ' 
        ' lblCameresTitolBucar
        ' 
        lblCameresTitolBucar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCameresTitolBucar.AutoSize = True
        lblCameresTitolBucar.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblCameresTitolBucar.Location = New Point(567, 22)
        lblCameresTitolBucar.Name = "lblCameresTitolBucar"
        lblCameresTitolBucar.Size = New Size(125, 25)
        lblCameresTitolBucar.TabIndex = 3
        lblCameresTitolBucar.Text = "Buscar camera"' 
        ' txtCameresBuscar
        ' 
        txtCameresBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCameresBuscar.Location = New Point(528, 65)
        txtCameresBuscar.Name = "txtCameresBuscar"
        txtCameresBuscar.Size = New Size(176, 27)
        txtCameresBuscar.TabIndex = 4
        ' 
        ' btnCameresResetBusqueda
        ' 
        btnCameresResetBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCameresResetBusqueda.BackColor = Color.Aquamarine
        btnCameresResetBusqueda.Location = New Point(710, 62)
        btnCameresResetBusqueda.Name = "btnCameresResetBusqueda"
        btnCameresResetBusqueda.Size = New Size(63, 33)
        btnCameresResetBusqueda.TabIndex = 5
        btnCameresResetBusqueda.Text = "Reset"
        btnCameresResetBusqueda.UseVisualStyleBackColor = False
        ' 
        ' GestioCameres
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(809, 442)
        Controls.Add(btnCameresResetBusqueda)
        Controls.Add(txtCameresBuscar)
        Controls.Add(lblCameresTitolBucar)
        Controls.Add(btnCameresEnrere)
        Controls.Add(btnCameresAfegir)
        Controls.Add(dgvCameresLlistat)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(827, 489)
        Name = "GestioCameres"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Gestio cameres"
        WindowState = FormWindowState.Maximized
        CType(dgvCameresLlistat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCameresLlistat As DataGridView
    Friend WithEvents btnCameresAfegir As Button
    Friend WithEvents btnCameresEnrere As Button
    Friend WithEvents lblCameresTitolBucar As Label
    Friend WithEvents txtCameresBuscar As TextBox
    Friend WithEvents btnCameresResetBusqueda As Button
End Class
