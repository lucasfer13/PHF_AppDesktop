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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestioCameres))
        Me.dgvCameresLlistat = New System.Windows.Forms.DataGridView()
        Me.btnCameresAfegir = New System.Windows.Forms.Button()
        Me.btnCameresEnrere = New System.Windows.Forms.Button()
        Me.lblCameresTitolBucar = New System.Windows.Forms.Label()
        Me.txtCameresBuscar = New System.Windows.Forms.TextBox()
        Me.btnCameresResetBusqueda = New System.Windows.Forms.Button()
        Me.bdgGestioCameresVista = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvCameresLlistat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdgGestioCameresVista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCameresLlistat
        '
        Me.dgvCameresLlistat.AllowUserToAddRows = False
        Me.dgvCameresLlistat.AllowUserToDeleteRows = False
        Me.dgvCameresLlistat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCameresLlistat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCameresLlistat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCameresLlistat.Location = New System.Drawing.Point(10, 9)
        Me.dgvCameresLlistat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCameresLlistat.MultiSelect = False
        Me.dgvCameresLlistat.Name = "dgvCameresLlistat"
        Me.dgvCameresLlistat.ReadOnly = True
        Me.dgvCameresLlistat.RowHeadersWidth = 51
        Me.dgvCameresLlistat.RowTemplate.Height = 29
        Me.dgvCameresLlistat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCameresLlistat.Size = New System.Drawing.Size(411, 314)
        Me.dgvCameresLlistat.TabIndex = 0
        '
        'btnCameresAfegir
        '
        Me.btnCameresAfegir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCameresAfegir.BackColor = System.Drawing.Color.Aquamarine
        Me.btnCameresAfegir.Location = New System.Drawing.Point(485, 121)
        Me.btnCameresAfegir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCameresAfegir.Name = "btnCameresAfegir"
        Me.btnCameresAfegir.Size = New System.Drawing.Size(154, 58)
        Me.btnCameresAfegir.TabIndex = 1
        Me.btnCameresAfegir.Text = "Afegir camera"
        Me.btnCameresAfegir.UseVisualStyleBackColor = False
        '
        'btnCameresEnrere
        '
        Me.btnCameresEnrere.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCameresEnrere.BackColor = System.Drawing.Color.Aquamarine
        Me.btnCameresEnrere.Location = New System.Drawing.Point(485, 265)
        Me.btnCameresEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCameresEnrere.Name = "btnCameresEnrere"
        Me.btnCameresEnrere.Size = New System.Drawing.Size(154, 58)
        Me.btnCameresEnrere.TabIndex = 2
        Me.btnCameresEnrere.Text = "Enrere"
        Me.btnCameresEnrere.UseVisualStyleBackColor = False
        '
        'lblCameresTitolBucar
        '
        Me.lblCameresTitolBucar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCameresTitolBucar.AutoSize = True
        Me.lblCameresTitolBucar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCameresTitolBucar.Location = New System.Drawing.Point(496, 16)
        Me.lblCameresTitolBucar.Name = "lblCameresTitolBucar"
        Me.lblCameresTitolBucar.Size = New System.Drawing.Size(105, 20)
        Me.lblCameresTitolBucar.TabIndex = 3
        Me.lblCameresTitolBucar.Text = "Buscar camera"
        '
        'txtCameresBuscar
        '
        Me.txtCameresBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCameresBuscar.Location = New System.Drawing.Point(462, 49)
        Me.txtCameresBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCameresBuscar.Name = "txtCameresBuscar"
        Me.txtCameresBuscar.Size = New System.Drawing.Size(154, 23)
        Me.txtCameresBuscar.TabIndex = 4
        '
        'btnCameresResetBusqueda
        '
        Me.btnCameresResetBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCameresResetBusqueda.BackColor = System.Drawing.Color.Aquamarine
        Me.btnCameresResetBusqueda.Location = New System.Drawing.Point(621, 46)
        Me.btnCameresResetBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCameresResetBusqueda.Name = "btnCameresResetBusqueda"
        Me.btnCameresResetBusqueda.Size = New System.Drawing.Size(55, 25)
        Me.btnCameresResetBusqueda.TabIndex = 5
        Me.btnCameresResetBusqueda.Text = "Reset"
        Me.btnCameresResetBusqueda.UseVisualStyleBackColor = False
        '
        'GestioCameres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(710, 338)
        Me.Controls.Add(Me.btnCameresResetBusqueda)
        Me.Controls.Add(Me.txtCameresBuscar)
        Me.Controls.Add(Me.lblCameresTitolBucar)
        Me.Controls.Add(Me.btnCameresEnrere)
        Me.Controls.Add(Me.btnCameresAfegir)
        Me.Controls.Add(Me.dgvCameresLlistat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(726, 377)
        Me.Name = "GestioCameres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHF - Gestio cameres"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvCameresLlistat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdgGestioCameresVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCameresAfegir As Button
    Friend WithEvents btnCameresEnrere As Button
    Friend WithEvents lblCameresTitolBucar As Label
    Friend WithEvents txtCameresBuscar As TextBox
    Friend WithEvents btnCameresResetBusqueda As Button
    Friend WithEvents bdgGestioCameresVista As BindingSource
    Public WithEvents dgvCameresLlistat As DataGridView
End Class
