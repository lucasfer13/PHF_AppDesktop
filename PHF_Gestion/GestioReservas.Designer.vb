<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestioReservas
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GestioReservas))
        dgvGestioReservesReserves = New DataGridView()
        btnGestioReservesEnrere = New Button()
        CType(dgvGestioReservesReserves, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvGestioReservesReserves
        ' 
        dgvGestioReservesReserves.AllowUserToAddRows = False
        dgvGestioReservesReserves.AllowUserToDeleteRows = False
        dgvGestioReservesReserves.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvGestioReservesReserves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGestioReservesReserves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGestioReservesReserves.Location = New Point(12, 12)
        dgvGestioReservesReserves.Name = "dgvGestioReservesReserves"
        dgvGestioReservesReserves.ReadOnly = True
        dgvGestioReservesReserves.RowHeadersWidth = 51
        dgvGestioReservesReserves.RowTemplate.Height = 29
        dgvGestioReservesReserves.Size = New Size(827, 394)
        dgvGestioReservesReserves.TabIndex = 0
        ' 
        ' btnGestioReservesEnrere
        ' 
        btnGestioReservesEnrere.Anchor = AnchorStyles.Bottom
        btnGestioReservesEnrere.BackColor = Color.Aquamarine
        btnGestioReservesEnrere.Location = New Point(327, 434)
        btnGestioReservesEnrere.Name = "btnGestioReservesEnrere"
        btnGestioReservesEnrere.Size = New Size(196, 82)
        btnGestioReservesEnrere.TabIndex = 5
        btnGestioReservesEnrere.Text = "Enrere"
        btnGestioReservesEnrere.UseVisualStyleBackColor = False
        ' 
        ' GestioReservas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(851, 528)
        Controls.Add(btnGestioReservesEnrere)
        Controls.Add(dgvGestioReservesReserves)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(869, 575)
        Name = "GestioReservas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Gestio reserves"
        WindowState = FormWindowState.Maximized
        CType(dgvGestioReservesReserves, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvGestioReservesReserves As DataGridView
    Friend WithEvents btnGestioReservesEnrere As Button
End Class
