<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVacances
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormVacances))
        txtVacancesValidador = New TextBox()
        dtpVacancesDataInici = New DateTimePicker()
        dtpVacancesDataFinal = New DateTimePicker()
        btnVacancesGuardar = New Button()
        lblVacancesDataInici = New Label()
        lblVacancesDataFinal = New Label()
        erpVacancesErrors = New ErrorProvider(components)
        CType(erpVacancesErrors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtVacancesValidador
        ' 
        txtVacancesValidador.Location = New Point(587, 85)
        txtVacancesValidador.Name = "txtVacancesValidador"
        txtVacancesValidador.Size = New Size(125, 27)
        txtVacancesValidador.TabIndex = 0
        txtVacancesValidador.Visible = False
        ' 
        ' dtpVacancesDataInici
        ' 
        dtpVacancesDataInici.Location = New Point(74, 51)
        dtpVacancesDataInici.Name = "dtpVacancesDataInici"
        dtpVacancesDataInici.Size = New Size(250, 27)
        dtpVacancesDataInici.TabIndex = 1
        ' 
        ' dtpVacancesDataFinal
        ' 
        dtpVacancesDataFinal.Location = New Point(462, 51)
        dtpVacancesDataFinal.Name = "dtpVacancesDataFinal"
        dtpVacancesDataFinal.Size = New Size(250, 27)
        dtpVacancesDataFinal.TabIndex = 2
        ' 
        ' btnVacancesGuardar
        ' 
        btnVacancesGuardar.BackColor = Color.Aquamarine
        btnVacancesGuardar.Location = New Point(316, 129)
        btnVacancesGuardar.Name = "btnVacancesGuardar"
        btnVacancesGuardar.Size = New Size(128, 48)
        btnVacancesGuardar.TabIndex = 3
        btnVacancesGuardar.Text = "Guardar"
        btnVacancesGuardar.UseVisualStyleBackColor = False
        ' 
        ' lblVacancesDataInici
        ' 
        lblVacancesDataInici.AutoSize = True
        lblVacancesDataInici.Location = New Point(74, 28)
        lblVacancesDataInici.Name = "lblVacancesDataInici"
        lblVacancesDataInici.Size = New Size(75, 20)
        lblVacancesDataInici.TabIndex = 4
        lblVacancesDataInici.Text = "Data inici:"' 
        ' lblVacancesDataFinal
        ' 
        lblVacancesDataFinal.AutoSize = True
        lblVacancesDataFinal.Location = New Point(462, 28)
        lblVacancesDataFinal.Name = "lblVacancesDataFinal"
        lblVacancesDataFinal.Size = New Size(77, 20)
        lblVacancesDataFinal.TabIndex = 5
        lblVacancesDataFinal.Text = "Data final:"' 
        ' erpVacancesErrors
        ' 
        erpVacancesErrors.ContainerControl = Me
        ' 
        ' FormVacances
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(760, 199)
        Controls.Add(lblVacancesDataFinal)
        Controls.Add(lblVacancesDataInici)
        Controls.Add(btnVacancesGuardar)
        Controls.Add(dtpVacancesDataFinal)
        Controls.Add(dtpVacancesDataInici)
        Controls.Add(txtVacancesValidador)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormVacances"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Vacances"
        CType(erpVacancesErrors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtVacancesValidador As TextBox
    Friend WithEvents dtpVacancesDataInici As DateTimePicker
    Friend WithEvents dtpVacancesDataFinal As DateTimePicker
    Friend WithEvents btnVacancesGuardar As Button
    Friend WithEvents lblVacancesDataInici As Label
    Friend WithEvents lblVacancesDataFinal As Label
    Friend WithEvents erpVacancesErrors As ErrorProvider
End Class
