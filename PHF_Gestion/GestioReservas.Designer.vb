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
        btnReservesPendents = New Button()
        btnDenegarReserva = New Button()
        dtpReservesFiltrarData = New DateTimePicker()
        lblGestioReservesTitolBuscar = New Label()
        btnGestioReservesEnrere = New Button()
        btnMostrarTotesReserves = New Button()
        CType(dgvGestioReservesReserves, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvGestioReservesReserves
        ' 
        dgvGestioReservesReserves.AllowUserToAddRows = False
        dgvGestioReservesReserves.AllowUserToDeleteRows = False
        dgvGestioReservesReserves.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvGestioReservesReserves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGestioReservesReserves.Location = New Point(12, 12)
        dgvGestioReservesReserves.Name = "dgvGestioReservesReserves"
        dgvGestioReservesReserves.ReadOnly = True
        dgvGestioReservesReserves.RowHeadersWidth = 51
        dgvGestioReservesReserves.RowTemplate.Height = 29
        dgvGestioReservesReserves.Size = New Size(471, 496)
        dgvGestioReservesReserves.TabIndex = 0
        ' 
        ' btnReservesPendents
        ' 
        btnReservesPendents.Anchor = AnchorStyles.Right
        btnReservesPendents.BackColor = Color.Aquamarine
        btnReservesPendents.Location = New Point(565, 168)
        btnReservesPendents.Name = "btnReservesPendents"
        btnReservesPendents.Size = New Size(95, 82)
        btnReservesPendents.TabIndex = 1
        btnReservesPendents.Text = "Reserves Pendents"
        btnReservesPendents.UseVisualStyleBackColor = False
        ' 
        ' btnDenegarReserva
        ' 
        btnDenegarReserva.Anchor = AnchorStyles.Right
        btnDenegarReserva.BackColor = Color.Aquamarine
        btnDenegarReserva.Location = New Point(565, 256)
        btnDenegarReserva.Name = "btnDenegarReserva"
        btnDenegarReserva.Size = New Size(196, 82)
        btnDenegarReserva.TabIndex = 2
        btnDenegarReserva.Text = "Denegar reserva"
        btnDenegarReserva.UseVisualStyleBackColor = False
        ' 
        ' dtpReservesFiltrarData
        ' 
        dtpReservesFiltrarData.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dtpReservesFiltrarData.Location = New Point(518, 73)
        dtpReservesFiltrarData.Name = "dtpReservesFiltrarData"
        dtpReservesFiltrarData.Size = New Size(276, 27)
        dtpReservesFiltrarData.TabIndex = 3
        ' 
        ' lblGestioReservesTitolBuscar
        ' 
        lblGestioReservesTitolBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblGestioReservesTitolBuscar.AutoSize = True
        lblGestioReservesTitolBuscar.Location = New Point(594, 28)
        lblGestioReservesTitolBuscar.Name = "lblGestioReservesTitolBuscar"
        lblGestioReservesTitolBuscar.Size = New Size(122, 20)
        lblGestioReservesTitolBuscar.TabIndex = 4
        lblGestioReservesTitolBuscar.Text = "Buscar por fecha:"' 
        ' btnGestioReservesEnrere
        ' 
        btnGestioReservesEnrere.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGestioReservesEnrere.BackColor = Color.Aquamarine
        btnGestioReservesEnrere.Location = New Point(565, 426)
        btnGestioReservesEnrere.Name = "btnGestioReservesEnrere"
        btnGestioReservesEnrere.Size = New Size(196, 82)
        btnGestioReservesEnrere.TabIndex = 5
        btnGestioReservesEnrere.Text = "Enrere"
        btnGestioReservesEnrere.UseVisualStyleBackColor = False
        ' 
        ' btnMostrarTotesReserves
        ' 
        btnMostrarTotesReserves.Anchor = AnchorStyles.Right
        btnMostrarTotesReserves.BackColor = Color.Aquamarine
        btnMostrarTotesReserves.Location = New Point(666, 168)
        btnMostrarTotesReserves.Name = "btnMostrarTotesReserves"
        btnMostrarTotesReserves.Size = New Size(95, 82)
        btnMostrarTotesReserves.TabIndex = 6
        btnMostrarTotesReserves.Text = "Totes Reserves"
        btnMostrarTotesReserves.UseVisualStyleBackColor = False
        ' 
        ' GestioReservas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(851, 528)
        Controls.Add(btnMostrarTotesReserves)
        Controls.Add(btnGestioReservesEnrere)
        Controls.Add(lblGestioReservesTitolBuscar)
        Controls.Add(dtpReservesFiltrarData)
        Controls.Add(btnDenegarReserva)
        Controls.Add(btnReservesPendents)
        Controls.Add(dgvGestioReservesReserves)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(869, 575)
        Name = "GestioReservas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Gestio reserves"
        WindowState = FormWindowState.Maximized
        CType(dgvGestioReservesReserves, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvGestioReservesReserves As DataGridView
    Friend WithEvents btnReservesPendents As Button
    Friend WithEvents btnDenegarReserva As Button
    Friend WithEvents dtpReservesFiltrarData As DateTimePicker
    Friend WithEvents lblGestioReservesTitolBuscar As Label
    Friend WithEvents btnGestioReservesEnrere As Button
    Friend WithEvents btnMostrarTotesReserves As Button
End Class
