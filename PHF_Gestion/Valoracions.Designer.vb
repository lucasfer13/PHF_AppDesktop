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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Valoracions))
        btnValoracioEnrere = New Button()
        lblValoracioTitol = New Label()
        dgvValoriacioLlistat = New DataGridView()
        dtpValoracioFiltrarData = New DateTimePicker()
        btnValoracioResetFilter = New Button()
        CType(dgvValoriacioLlistat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnValoracioEnrere
        ' 
        btnValoracioEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnValoracioEnrere.BackColor = Color.Aquamarine
        btnValoracioEnrere.Location = New Point(94, 345)
        btnValoracioEnrere.Name = "btnValoracioEnrere"
        btnValoracioEnrere.RightToLeft = RightToLeft.Yes
        btnValoracioEnrere.Size = New Size(186, 64)
        btnValoracioEnrere.TabIndex = 0
        btnValoracioEnrere.Text = "Enrere"
        btnValoracioEnrere.UseVisualStyleBackColor = False
        ' 
        ' lblValoracioTitol
        ' 
        lblValoracioTitol.AutoSize = True
        lblValoracioTitol.Font = New Font("Sitka Small", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblValoracioTitol.Location = New Point(53, 28)
        lblValoracioTitol.Name = "lblValoracioTitol"
        lblValoracioTitol.Size = New Size(255, 53)
        lblValoracioTitol.TabIndex = 2
        lblValoracioTitol.Text = "Valoracions"' 
        ' dgvValoriacioLlistat
        ' 
        dgvValoriacioLlistat.AllowUserToAddRows = False
        dgvValoriacioLlistat.AllowUserToDeleteRows = False
        dgvValoriacioLlistat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvValoriacioLlistat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvValoriacioLlistat.Location = New Point(387, 48)
        dgvValoriacioLlistat.Name = "dgvValoriacioLlistat"
        dgvValoriacioLlistat.ReadOnly = True
        dgvValoriacioLlistat.RowHeadersWidth = 51
        dgvValoriacioLlistat.RowTemplate.Height = 29
        dgvValoriacioLlistat.Size = New Size(397, 361)
        dgvValoriacioLlistat.TabIndex = 4
        ' 
        ' dtpValoracioFiltrarData
        ' 
        dtpValoracioFiltrarData.Anchor = AnchorStyles.Left
        dtpValoracioFiltrarData.Location = New Point(16, 172)
        dtpValoracioFiltrarData.Name = "dtpValoracioFiltrarData"
        dtpValoracioFiltrarData.Size = New Size(250, 27)
        dtpValoracioFiltrarData.TabIndex = 5
        ' 
        ' btnValoracioResetFilter
        ' 
        btnValoracioResetFilter.Anchor = AnchorStyles.Left
        btnValoracioResetFilter.BackColor = Color.Aquamarine
        btnValoracioResetFilter.Location = New Point(272, 172)
        btnValoracioResetFilter.Name = "btnValoracioResetFilter"
        btnValoracioResetFilter.RightToLeft = RightToLeft.Yes
        btnValoracioResetFilter.Size = New Size(75, 30)
        btnValoracioResetFilter.TabIndex = 6
        btnValoracioResetFilter.Text = "Reset"
        btnValoracioResetFilter.UseVisualStyleBackColor = False
        ' 
        ' Valoracions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(836, 435)
        Controls.Add(btnValoracioResetFilter)
        Controls.Add(dtpValoracioFiltrarData)
        Controls.Add(dgvValoriacioLlistat)
        Controls.Add(lblValoracioTitol)
        Controls.Add(btnValoracioEnrere)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(854, 482)
        Name = "Valoracions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Valoracions"
        WindowState = FormWindowState.Maximized
        CType(dgvValoriacioLlistat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnValoracioEnrere As Button
    Friend WithEvents lblValoracioTitol As Label
    Friend WithEvents dgvValoriacioLlistat As DataGridView
    Friend WithEvents dtpValoracioFiltrarData As DateTimePicker
    Friend WithEvents btnValoracioResetFilter As Button
End Class
