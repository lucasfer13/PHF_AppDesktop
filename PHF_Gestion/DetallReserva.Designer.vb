<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallReserva
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DetallReserva))
        dgvDetallReservaLiniesReserva = New DataGridView()
        btnDetallReservaEnrere = New Button()
        lblDetallReservaTitolDataI = New Label()
        lblDetallReservaTitolDataF = New Label()
        lblDetallReservaTitolPreu = New Label()
        lblDetallReservaTitolClient = New Label()
        lblDetallReservaTitol = New Label()
        lblDetallReservaValorPreu = New Label()
        lblDetallReservaValorClient = New Label()
        lblDetallReservaValorDataI = New Label()
        lblDetallReservaValorDataF = New Label()
        CType(dgvDetallReservaLiniesReserva, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDetallReservaLiniesReserva
        ' 
        dgvDetallReservaLiniesReserva.AllowUserToAddRows = False
        dgvDetallReservaLiniesReserva.AllowUserToDeleteRows = False
        dgvDetallReservaLiniesReserva.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetallReservaLiniesReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetallReservaLiniesReserva.Location = New Point(12, 225)
        dgvDetallReservaLiniesReserva.Name = "dgvDetallReservaLiniesReserva"
        dgvDetallReservaLiniesReserva.ReadOnly = True
        dgvDetallReservaLiniesReserva.RowHeadersWidth = 51
        dgvDetallReservaLiniesReserva.RowTemplate.Height = 29
        dgvDetallReservaLiniesReserva.Size = New Size(908, 237)
        dgvDetallReservaLiniesReserva.TabIndex = 0
        ' 
        ' btnDetallReservaEnrere
        ' 
        btnDetallReservaEnrere.Anchor = AnchorStyles.Bottom
        btnDetallReservaEnrere.BackColor = Color.Aquamarine
        btnDetallReservaEnrere.Location = New Point(399, 486)
        btnDetallReservaEnrere.Name = "btnDetallReservaEnrere"
        btnDetallReservaEnrere.Size = New Size(141, 53)
        btnDetallReservaEnrere.TabIndex = 1
        btnDetallReservaEnrere.Text = "Enrere"
        btnDetallReservaEnrere.UseVisualStyleBackColor = False
        ' 
        ' lblDetallReservaTitolDataI
        ' 
        lblDetallReservaTitolDataI.AutoSize = True
        lblDetallReservaTitolDataI.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetallReservaTitolDataI.Location = New Point(12, 78)
        lblDetallReservaTitolDataI.Name = "lblDetallReservaTitolDataI"
        lblDetallReservaTitolDataI.Size = New Size(97, 28)
        lblDetallReservaTitolDataI.TabIndex = 2
        lblDetallReservaTitolDataI.Text = "Data inici:"' 
        ' lblDetallReservaTitolDataF
        ' 
        lblDetallReservaTitolDataF.AutoSize = True
        lblDetallReservaTitolDataF.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetallReservaTitolDataF.Location = New Point(12, 141)
        lblDetallReservaTitolDataF.Name = "lblDetallReservaTitolDataF"
        lblDetallReservaTitolDataF.Size = New Size(77, 28)
        lblDetallReservaTitolDataF.TabIndex = 3
        lblDetallReservaTitolDataF.Text = "Data Fi:"' 
        ' lblDetallReservaTitolPreu
        ' 
        lblDetallReservaTitolPreu.Anchor = AnchorStyles.Top
        lblDetallReservaTitolPreu.AutoSize = True
        lblDetallReservaTitolPreu.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetallReservaTitolPreu.Location = New Point(366, 78)
        lblDetallReservaTitolPreu.Name = "lblDetallReservaTitolPreu"
        lblDetallReservaTitolPreu.Size = New Size(101, 28)
        lblDetallReservaTitolPreu.TabIndex = 4
        lblDetallReservaTitolPreu.Text = "Preu total:"' 
        ' lblDetallReservaTitolClient
        ' 
        lblDetallReservaTitolClient.Anchor = AnchorStyles.Top
        lblDetallReservaTitolClient.AutoSize = True
        lblDetallReservaTitolClient.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetallReservaTitolClient.Location = New Point(366, 141)
        lblDetallReservaTitolClient.Name = "lblDetallReservaTitolClient"
        lblDetallReservaTitolClient.Size = New Size(112, 28)
        lblDetallReservaTitolClient.TabIndex = 5
        lblDetallReservaTitolClient.Text = "Nom client:"' 
        ' lblDetallReservaTitol
        ' 
        lblDetallReservaTitol.Anchor = AnchorStyles.Top
        lblDetallReservaTitol.AutoSize = True
        lblDetallReservaTitol.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetallReservaTitol.Location = New Point(344, 9)
        lblDetallReservaTitol.Name = "lblDetallReservaTitol"
        lblDetallReservaTitol.Size = New Size(196, 41)
        lblDetallReservaTitol.TabIndex = 6
        lblDetallReservaTitol.Text = "Detall reserva"' 
        ' lblDetallReservaValorPreu
        ' 
        lblDetallReservaValorPreu.AutoSize = True
        lblDetallReservaValorPreu.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetallReservaValorPreu.Location = New Point(512, 78)
        lblDetallReservaValorPreu.Name = "lblDetallReservaValorPreu"
        lblDetallReservaValorPreu.Size = New Size(0, 28)
        lblDetallReservaValorPreu.TabIndex = 7
        ' 
        ' lblDetallReservaValorClient
        ' 
        lblDetallReservaValorClient.AutoSize = True
        lblDetallReservaValorClient.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetallReservaValorClient.Location = New Point(512, 141)
        lblDetallReservaValorClient.Name = "lblDetallReservaValorClient"
        lblDetallReservaValorClient.Size = New Size(0, 28)
        lblDetallReservaValorClient.TabIndex = 8
        ' 
        ' lblDetallReservaValorDataI
        ' 
        lblDetallReservaValorDataI.AutoSize = True
        lblDetallReservaValorDataI.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetallReservaValorDataI.Location = New Point(126, 78)
        lblDetallReservaValorDataI.Name = "lblDetallReservaValorDataI"
        lblDetallReservaValorDataI.Size = New Size(0, 28)
        lblDetallReservaValorDataI.TabIndex = 9
        ' 
        ' lblDetallReservaValorDataF
        ' 
        lblDetallReservaValorDataF.AutoSize = True
        lblDetallReservaValorDataF.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetallReservaValorDataF.Location = New Point(126, 141)
        lblDetallReservaValorDataF.Name = "lblDetallReservaValorDataF"
        lblDetallReservaValorDataF.Size = New Size(0, 28)
        lblDetallReservaValorDataF.TabIndex = 10
        ' 
        ' DetallReserva
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(932, 551)
        Controls.Add(lblDetallReservaValorDataF)
        Controls.Add(lblDetallReservaValorDataI)
        Controls.Add(lblDetallReservaValorClient)
        Controls.Add(lblDetallReservaValorPreu)
        Controls.Add(lblDetallReservaTitol)
        Controls.Add(lblDetallReservaTitolClient)
        Controls.Add(lblDetallReservaTitolPreu)
        Controls.Add(lblDetallReservaTitolDataF)
        Controls.Add(lblDetallReservaTitolDataI)
        Controls.Add(btnDetallReservaEnrere)
        Controls.Add(dgvDetallReservaLiniesReserva)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(950, 598)
        Name = "DetallReserva"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DetallReserva"
        CType(dgvDetallReservaLiniesReserva, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDetallReservaLiniesReserva As DataGridView
    Friend WithEvents btnDetallReservaEnrere As Button
    Friend WithEvents lblDetallReservaTitolDataI As Label
    Friend WithEvents lblDetallReservaTitolDataF As Label
    Friend WithEvents lblDetallReservaTitolPreu As Label
    Friend WithEvents lblDetallReservaTitolClient As Label
    Friend WithEvents lblDetallReservaTitol As Label
    Friend WithEvents lblDetallReservaValorPreu As Label
    Friend WithEvents lblDetallReservaValorClient As Label
    Friend WithEvents lblDetallReservaValorDataI As Label
    Friend WithEvents lblDetallReservaValorDataF As Label
End Class
