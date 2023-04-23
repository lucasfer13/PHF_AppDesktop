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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Valoracions))
        Me.btnValoracioEnrere = New System.Windows.Forms.Button()
        Me.lblValoracioTitol = New System.Windows.Forms.Label()
        Me.dgvValoriacioLlistat = New System.Windows.Forms.DataGridView()
        Me.dtpValoracioFiltrarData = New System.Windows.Forms.DateTimePicker()
        Me.btnValoracioResetFilter = New System.Windows.Forms.Button()
        Me.bdgValoracionsVista = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvValoriacioLlistat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdgValoracionsVista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnValoracioEnrere
        '
        Me.btnValoracioEnrere.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnValoracioEnrere.BackColor = System.Drawing.Color.Aquamarine
        Me.btnValoracioEnrere.Location = New System.Drawing.Point(82, 259)
        Me.btnValoracioEnrere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnValoracioEnrere.Name = "btnValoracioEnrere"
        Me.btnValoracioEnrere.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnValoracioEnrere.Size = New System.Drawing.Size(163, 48)
        Me.btnValoracioEnrere.TabIndex = 0
        Me.btnValoracioEnrere.Text = "Enrere"
        Me.btnValoracioEnrere.UseVisualStyleBackColor = False
        '
        'lblValoracioTitol
        '
        Me.lblValoracioTitol.AutoSize = True
        Me.lblValoracioTitol.Font = New System.Drawing.Font("Sitka Small", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblValoracioTitol.Location = New System.Drawing.Point(46, 21)
        Me.lblValoracioTitol.Name = "lblValoracioTitol"
        Me.lblValoracioTitol.Size = New System.Drawing.Size(208, 43)
        Me.lblValoracioTitol.TabIndex = 2
        Me.lblValoracioTitol.Text = "Valoracions"
        '
        'dgvValoriacioLlistat
        '
        Me.dgvValoriacioLlistat.AllowUserToAddRows = False
        Me.dgvValoriacioLlistat.AllowUserToDeleteRows = False
        Me.dgvValoriacioLlistat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvValoriacioLlistat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValoriacioLlistat.Location = New System.Drawing.Point(339, 36)
        Me.dgvValoriacioLlistat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvValoriacioLlistat.Name = "dgvValoriacioLlistat"
        Me.dgvValoriacioLlistat.ReadOnly = True
        Me.dgvValoriacioLlistat.RowHeadersWidth = 51
        Me.dgvValoriacioLlistat.RowTemplate.Height = 29
        Me.dgvValoriacioLlistat.Size = New System.Drawing.Size(347, 271)
        Me.dgvValoriacioLlistat.TabIndex = 4
        '
        'dtpValoracioFiltrarData
        '
        Me.dtpValoracioFiltrarData.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtpValoracioFiltrarData.Location = New System.Drawing.Point(14, 129)
        Me.dtpValoracioFiltrarData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpValoracioFiltrarData.Name = "dtpValoracioFiltrarData"
        Me.dtpValoracioFiltrarData.Size = New System.Drawing.Size(219, 23)
        Me.dtpValoracioFiltrarData.TabIndex = 5
        '
        'btnValoracioResetFilter
        '
        Me.btnValoracioResetFilter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnValoracioResetFilter.BackColor = System.Drawing.Color.Aquamarine
        Me.btnValoracioResetFilter.Location = New System.Drawing.Point(238, 129)
        Me.btnValoracioResetFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnValoracioResetFilter.Name = "btnValoracioResetFilter"
        Me.btnValoracioResetFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnValoracioResetFilter.Size = New System.Drawing.Size(66, 22)
        Me.btnValoracioResetFilter.TabIndex = 6
        Me.btnValoracioResetFilter.Text = "Reset"
        Me.btnValoracioResetFilter.UseVisualStyleBackColor = False
        '
        'Valoracions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(733, 332)
        Me.Controls.Add(Me.btnValoracioResetFilter)
        Me.Controls.Add(Me.dtpValoracioFiltrarData)
        Me.Controls.Add(Me.dgvValoriacioLlistat)
        Me.Controls.Add(Me.lblValoracioTitol)
        Me.Controls.Add(Me.btnValoracioEnrere)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(749, 371)
        Me.Name = "Valoracions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHF - Valoracions"
        CType(Me.dgvValoriacioLlistat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdgValoracionsVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValoracioEnrere As Button
    Friend WithEvents lblValoracioTitol As Label
    Friend WithEvents dgvValoriacioLlistat As DataGridView
    Friend WithEvents dtpValoracioFiltrarData As DateTimePicker
    Friend WithEvents btnValoracioResetFilter As Button
    Friend WithEvents bdgValoracionsVista As BindingSource
End Class
