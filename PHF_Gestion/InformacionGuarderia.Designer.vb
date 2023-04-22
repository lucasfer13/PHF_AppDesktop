<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformacionGuarderia
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(InformacionGuarderia))
        btnInformacioGuarderiaEnrere = New Button()
        btnInformacioGuarderiaModificar = New Button()
        lblInformacioGuarderiaNom = New Label()
        lblInformacioGuarderiaDescripcio = New Label()
        iglInformacioGuarderiaImatges = New ImageList(components)
        lblInformacioGuarderiaImatges = New Label()
        flpInformacioGuarderiaImatges = New FlowLayoutPanel()
        btnInformacioGuarderiaAfegirImatge = New Button()
        btnInformacioGuarderiaEliminarImatge = New Button()
        txtInformacioGuarderiaDescripcio = New TextBox()
        txtInformacioGuarderiaNom = New TextBox()
        lblInformacioGuarderiaPais = New Label()
        lblInformacioGuarderiaMuncipi = New Label()
        lblInformacioGuarderiaPorta = New Label()
        lblInformacioGuarderiaCP = New Label()
        lblInformacioGuarderiaCarrer = New Label()
        txtInformacioGuarderiaPais = New TextBox()
        txtInformacioGuarderiaMunicipi = New TextBox()
        txtInformacioGuarderiaCP = New TextBox()
        txtInformacioGuarderiaCarrer = New TextBox()
        txtInformacioGuarderiaPorta = New TextBox()
        btnInformacioGuarderiaMunicipi = New Button()
        btnInformacioGuarderiaPais = New Button()
        dgvInformacioGuarderia = New DataGridView()
        dtvInformacioGuarderiaServeis = New DataGridView()
        lblInformacioGuarderiaServei = New Label()
        btnInformacioGuarderiaAfegirServei = New Button()
        btnInformacioGuarderiaEliminarServei = New Button()
        btnInformacioGuarderiaEliminarVacances = New Button()
        btnInformacioGuarderiaAfegirVacances = New Button()
        lblInformacioGuarderiaVacances = New Label()
        lblInformacioGuarderiaTitol = New Label()
        stcInformacioGuarderiaSeparador = New SplitContainer()
        txtInformacioGuarderiaCIF = New TextBox()
        lblInformacioGuarderiaCIF = New Label()
        txtInformacioGuarderiaTelefon = New TextBox()
        lblInformacioGuarderiaTelefon = New Label()
        txtInformacioGuarderiaCorreu = New TextBox()
        lblInformacioGuarderiaCorreu = New Label()
        tlpInformacioGuarderiaTaules = New TableLayoutPanel()
        pnlInformacioGuarderiaVacances = New Panel()
        pnlInformacioGuarderiaServeis = New Panel()
        btnInformacioGuarderiaGuardar = New Button()
        btnInformacioGuarderiaEliminar = New Button()
        erpInformacioGuarderiaErrors = New ErrorProvider(components)
        bdgInformacioGuarderiaVistaServeis = New BindingSource(components)
        bdgInformacioGuarderiaVistaVacances = New BindingSource(components)
        CType(dgvInformacioGuarderia, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvInformacioGuarderiaServeis, ComponentModel.ISupportInitialize).BeginInit()
        CType(stcInformacioGuarderiaSeparador, ComponentModel.ISupportInitialize).BeginInit()
        stcInformacioGuarderiaSeparador.Panel1.SuspendLayout()
        stcInformacioGuarderiaSeparador.Panel2.SuspendLayout()
        stcInformacioGuarderiaSeparador.SuspendLayout()
        tlpInformacioGuarderiaTaules.SuspendLayout()
        pnlInformacioGuarderiaVacances.SuspendLayout()
        pnlInformacioGuarderiaServeis.SuspendLayout()
        CType(erpInformacioGuarderiaErrors, ComponentModel.ISupportInitialize).BeginInit()
        CType(bdgInformacioGuarderiaVistaServeis, ComponentModel.ISupportInitialize).BeginInit()
        CType(bdgInformacioGuarderiaVistaVacances, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnInformacioGuarderiaEnrere
        ' 
        btnInformacioGuarderiaEnrere.Anchor = AnchorStyles.Bottom
        btnInformacioGuarderiaEnrere.BackColor = Color.Aquamarine
        btnInformacioGuarderiaEnrere.Location = New Point(354, 936)
        btnInformacioGuarderiaEnrere.Name = "btnInformacioGuarderiaEnrere"
        btnInformacioGuarderiaEnrere.Size = New Size(134, 69)
        btnInformacioGuarderiaEnrere.TabIndex = 19
        btnInformacioGuarderiaEnrere.Text = "Enrere"
        btnInformacioGuarderiaEnrere.UseVisualStyleBackColor = False
        ' 
        ' btnInformacioGuarderiaModificar
        ' 
        btnInformacioGuarderiaModificar.Anchor = AnchorStyles.Bottom
        btnInformacioGuarderiaModificar.BackColor = Color.Aquamarine
        btnInformacioGuarderiaModificar.Location = New Point(668, 936)
        btnInformacioGuarderiaModificar.Name = "btnInformacioGuarderiaModificar"
        btnInformacioGuarderiaModificar.Size = New Size(134, 69)
        btnInformacioGuarderiaModificar.TabIndex = 21
        btnInformacioGuarderiaModificar.Text = "Modificar"
        btnInformacioGuarderiaModificar.UseVisualStyleBackColor = False
        ' 
        ' lblInformacioGuarderiaNom
        ' 
        lblInformacioGuarderiaNom.AutoSize = True
        lblInformacioGuarderiaNom.Location = New Point(61, 80)
        lblInformacioGuarderiaNom.Name = "lblInformacioGuarderiaNom"
        lblInformacioGuarderiaNom.Size = New Size(45, 20)
        lblInformacioGuarderiaNom.TabIndex = 3
        lblInformacioGuarderiaNom.Text = "Nom:"' 
        ' lblInformacioGuarderiaDescripcio
        ' 
        lblInformacioGuarderiaDescripcio.AutoSize = True
        lblInformacioGuarderiaDescripcio.Location = New Point(61, 117)
        lblInformacioGuarderiaDescripcio.Name = "lblInformacioGuarderiaDescripcio"
        lblInformacioGuarderiaDescripcio.Size = New Size(82, 20)
        lblInformacioGuarderiaDescripcio.TabIndex = 4
        lblInformacioGuarderiaDescripcio.Text = "Descripció:"' 
        ' iglInformacioGuarderiaImatges
        ' 
        iglInformacioGuarderiaImatges.ColorDepth = ColorDepth.Depth8Bit
        iglInformacioGuarderiaImatges.ImageSize = New Size(16, 16)
        iglInformacioGuarderiaImatges.TransparentColor = Color.Transparent
        ' 
        ' lblInformacioGuarderiaImatges
        ' 
        lblInformacioGuarderiaImatges.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInformacioGuarderiaImatges.AutoSize = True
        lblInformacioGuarderiaImatges.Location = New Point(62, 543)
        lblInformacioGuarderiaImatges.Name = "lblInformacioGuarderiaImatges"
        lblInformacioGuarderiaImatges.Size = New Size(65, 20)
        lblInformacioGuarderiaImatges.TabIndex = 5
        lblInformacioGuarderiaImatges.Text = "Imatges:"' 
        ' flpInformacioGuarderiaImatges
        ' 
        flpInformacioGuarderiaImatges.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flpInformacioGuarderiaImatges.Location = New Point(64, 579)
        flpInformacioGuarderiaImatges.Name = "flpInformacioGuarderiaImatges"
        flpInformacioGuarderiaImatges.Size = New Size(529, 249)
        flpInformacioGuarderiaImatges.TabIndex = 6
        ' 
        ' btnInformacioGuarderiaAfegirImatge
        ' 
        btnInformacioGuarderiaAfegirImatge.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnInformacioGuarderiaAfegirImatge.BackColor = Color.Aquamarine
        btnInformacioGuarderiaAfegirImatge.Location = New Point(185, 533)
        btnInformacioGuarderiaAfegirImatge.Name = "btnInformacioGuarderiaAfegirImatge"
        btnInformacioGuarderiaAfegirImatge.Size = New Size(97, 30)
        btnInformacioGuarderiaAfegirImatge.TabIndex = 12
        btnInformacioGuarderiaAfegirImatge.Text = "Afegir"
        btnInformacioGuarderiaAfegirImatge.UseVisualStyleBackColor = False
        ' 
        ' btnInformacioGuarderiaEliminarImatge
        ' 
        btnInformacioGuarderiaEliminarImatge.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnInformacioGuarderiaEliminarImatge.BackColor = Color.Aquamarine
        btnInformacioGuarderiaEliminarImatge.Location = New Point(307, 533)
        btnInformacioGuarderiaEliminarImatge.Name = "btnInformacioGuarderiaEliminarImatge"
        btnInformacioGuarderiaEliminarImatge.Size = New Size(89, 30)
        btnInformacioGuarderiaEliminarImatge.TabIndex = 13
        btnInformacioGuarderiaEliminarImatge.Text = "Eliminar"
        btnInformacioGuarderiaEliminarImatge.UseVisualStyleBackColor = False
        ' 
        ' txtInformacioGuarderiaDescripcio
        ' 
        txtInformacioGuarderiaDescripcio.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaDescripcio.Location = New Point(185, 114)
        txtInformacioGuarderiaDescripcio.Multiline = True
        txtInformacioGuarderiaDescripcio.Name = "txtInformacioGuarderiaDescripcio"
        txtInformacioGuarderiaDescripcio.Size = New Size(344, 69)
        txtInformacioGuarderiaDescripcio.TabIndex = 2
        ' 
        ' txtInformacioGuarderiaNom
        ' 
        txtInformacioGuarderiaNom.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaNom.Location = New Point(185, 77)
        txtInformacioGuarderiaNom.Name = "txtInformacioGuarderiaNom"
        txtInformacioGuarderiaNom.Size = New Size(344, 27)
        txtInformacioGuarderiaNom.TabIndex = 1
        ' 
        ' lblInformacioGuarderiaPais
        ' 
        lblInformacioGuarderiaPais.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInformacioGuarderiaPais.AutoSize = True
        lblInformacioGuarderiaPais.Location = New Point(65, 204)
        lblInformacioGuarderiaPais.Name = "lblInformacioGuarderiaPais"
        lblInformacioGuarderiaPais.Size = New Size(37, 20)
        lblInformacioGuarderiaPais.TabIndex = 11
        lblInformacioGuarderiaPais.Text = "Pais:"' 
        ' lblInformacioGuarderiaMuncipi
        ' 
        lblInformacioGuarderiaMuncipi.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInformacioGuarderiaMuncipi.AutoSize = True
        lblInformacioGuarderiaMuncipi.Location = New Point(65, 252)
        lblInformacioGuarderiaMuncipi.Name = "lblInformacioGuarderiaMuncipi"
        lblInformacioGuarderiaMuncipi.Size = New Size(69, 20)
        lblInformacioGuarderiaMuncipi.TabIndex = 12
        lblInformacioGuarderiaMuncipi.Text = "Municipi:"' 
        ' lblInformacioGuarderiaPorta
        ' 
        lblInformacioGuarderiaPorta.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInformacioGuarderiaPorta.AutoSize = True
        lblInformacioGuarderiaPorta.Location = New Point(65, 384)
        lblInformacioGuarderiaPorta.Name = "lblInformacioGuarderiaPorta"
        lblInformacioGuarderiaPorta.Size = New Size(46, 20)
        lblInformacioGuarderiaPorta.TabIndex = 13
        lblInformacioGuarderiaPorta.Text = "Porta:"' 
        ' lblInformacioGuarderiaCP
        ' 
        lblInformacioGuarderiaCP.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInformacioGuarderiaCP.AutoSize = True
        lblInformacioGuarderiaCP.Location = New Point(65, 302)
        lblInformacioGuarderiaCP.Name = "lblInformacioGuarderiaCP"
        lblInformacioGuarderiaCP.Size = New Size(29, 20)
        lblInformacioGuarderiaCP.TabIndex = 14
        lblInformacioGuarderiaCP.Text = "CP:"' 
        ' lblInformacioGuarderiaCarrer
        ' 
        lblInformacioGuarderiaCarrer.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInformacioGuarderiaCarrer.AutoSize = True
        lblInformacioGuarderiaCarrer.Location = New Point(65, 345)
        lblInformacioGuarderiaCarrer.Name = "lblInformacioGuarderiaCarrer"
        lblInformacioGuarderiaCarrer.Size = New Size(52, 20)
        lblInformacioGuarderiaCarrer.TabIndex = 15
        lblInformacioGuarderiaCarrer.Text = "Carrer:"' 
        ' txtInformacioGuarderiaPais
        ' 
        txtInformacioGuarderiaPais.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaPais.Enabled = False
        txtInformacioGuarderiaPais.Location = New Point(188, 201)
        txtInformacioGuarderiaPais.Name = "txtInformacioGuarderiaPais"
        txtInformacioGuarderiaPais.Size = New Size(266, 27)
        txtInformacioGuarderiaPais.TabIndex = 3
        ' 
        ' txtInformacioGuarderiaMunicipi
        ' 
        txtInformacioGuarderiaMunicipi.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaMunicipi.Enabled = False
        txtInformacioGuarderiaMunicipi.Location = New Point(188, 249)
        txtInformacioGuarderiaMunicipi.Name = "txtInformacioGuarderiaMunicipi"
        txtInformacioGuarderiaMunicipi.Size = New Size(266, 27)
        txtInformacioGuarderiaMunicipi.TabIndex = 5
        ' 
        ' txtInformacioGuarderiaCP
        ' 
        txtInformacioGuarderiaCP.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaCP.Enabled = False
        txtInformacioGuarderiaCP.Location = New Point(188, 295)
        txtInformacioGuarderiaCP.Name = "txtInformacioGuarderiaCP"
        txtInformacioGuarderiaCP.Size = New Size(340, 27)
        txtInformacioGuarderiaCP.TabIndex = 7
        ' 
        ' txtInformacioGuarderiaCarrer
        ' 
        txtInformacioGuarderiaCarrer.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaCarrer.Location = New Point(188, 338)
        txtInformacioGuarderiaCarrer.Name = "txtInformacioGuarderiaCarrer"
        txtInformacioGuarderiaCarrer.Size = New Size(340, 27)
        txtInformacioGuarderiaCarrer.TabIndex = 8
        ' 
        ' txtInformacioGuarderiaPorta
        ' 
        txtInformacioGuarderiaPorta.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaPorta.Location = New Point(188, 381)
        txtInformacioGuarderiaPorta.Name = "txtInformacioGuarderiaPorta"
        txtInformacioGuarderiaPorta.Size = New Size(340, 27)
        txtInformacioGuarderiaPorta.TabIndex = 9
        ' 
        ' btnInformacioGuarderiaMunicipi
        ' 
        btnInformacioGuarderiaMunicipi.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnInformacioGuarderiaMunicipi.BackColor = Color.Aquamarine
        btnInformacioGuarderiaMunicipi.Location = New Point(477, 249)
        btnInformacioGuarderiaMunicipi.Name = "btnInformacioGuarderiaMunicipi"
        btnInformacioGuarderiaMunicipi.Size = New Size(73, 27)
        btnInformacioGuarderiaMunicipi.TabIndex = 6
        btnInformacioGuarderiaMunicipi.Text = "..."
        btnInformacioGuarderiaMunicipi.UseVisualStyleBackColor = False
        ' 
        ' btnInformacioGuarderiaPais
        ' 
        btnInformacioGuarderiaPais.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnInformacioGuarderiaPais.BackColor = Color.Aquamarine
        btnInformacioGuarderiaPais.Location = New Point(477, 201)
        btnInformacioGuarderiaPais.Name = "btnInformacioGuarderiaPais"
        btnInformacioGuarderiaPais.Size = New Size(69, 27)
        btnInformacioGuarderiaPais.TabIndex = 4
        btnInformacioGuarderiaPais.Text = "..."
        btnInformacioGuarderiaPais.UseVisualStyleBackColor = False
        ' 
        ' dgvInformacioGuarderia
        ' 
        dgvInformacioGuarderia.AllowUserToAddRows = False
        dgvInformacioGuarderia.AllowUserToDeleteRows = False
        dgvInformacioGuarderia.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvInformacioGuarderia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInformacioGuarderia.Location = New Point(3, 42)
        dgvInformacioGuarderia.MultiSelect = False
        dgvInformacioGuarderia.Name = "dgvInformacioGuarderia"
        dgvInformacioGuarderia.ReadOnly = True
        dgvInformacioGuarderia.RowHeadersWidth = 51
        dgvInformacioGuarderia.RowTemplate.Height = 29
        dgvInformacioGuarderia.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInformacioGuarderia.Size = New Size(613, 371)
        dgvInformacioGuarderia.TabIndex = 23
        ' 
        ' dtvInformacioGuarderiaServeis
        ' 
        dtvInformacioGuarderiaServeis.AllowUserToAddRows = False
        dtvInformacioGuarderiaServeis.AllowUserToDeleteRows = False
        dtvInformacioGuarderiaServeis.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dtvInformacioGuarderiaServeis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvInformacioGuarderiaServeis.Location = New Point(3, 40)
        dtvInformacioGuarderiaServeis.MultiSelect = False
        dtvInformacioGuarderiaServeis.Name = "dtvInformacioGuarderiaServeis"
        dtvInformacioGuarderiaServeis.ReadOnly = True
        dtvInformacioGuarderiaServeis.RowHeadersWidth = 51
        dtvInformacioGuarderiaServeis.RowTemplate.Height = 29
        dtvInformacioGuarderiaServeis.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtvInformacioGuarderiaServeis.Size = New Size(613, 377)
        dtvInformacioGuarderiaServeis.TabIndex = 24
        ' 
        ' lblInformacioGuarderiaServei
        ' 
        lblInformacioGuarderiaServei.AutoSize = True
        lblInformacioGuarderiaServei.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblInformacioGuarderiaServei.Location = New Point(3, 9)
        lblInformacioGuarderiaServei.Name = "lblInformacioGuarderiaServei"
        lblInformacioGuarderiaServei.Size = New Size(77, 28)
        lblInformacioGuarderiaServei.TabIndex = 25
        lblInformacioGuarderiaServei.Text = "Serveis:"' 
        ' btnInformacioGuarderiaAfegirServei
        ' 
        btnInformacioGuarderiaAfegirServei.BackColor = Color.Aquamarine
        btnInformacioGuarderiaAfegirServei.Location = New Point(86, 9)
        btnInformacioGuarderiaAfegirServei.Name = "btnInformacioGuarderiaAfegirServei"
        btnInformacioGuarderiaAfegirServei.Size = New Size(95, 28)
        btnInformacioGuarderiaAfegirServei.TabIndex = 17
        btnInformacioGuarderiaAfegirServei.Text = "Afegir"
        btnInformacioGuarderiaAfegirServei.UseVisualStyleBackColor = False
        ' 
        ' btnInformacioGuarderiaEliminarServei
        ' 
        btnInformacioGuarderiaEliminarServei.BackColor = Color.Aquamarine
        btnInformacioGuarderiaEliminarServei.Location = New Point(196, 9)
        btnInformacioGuarderiaEliminarServei.Name = "btnInformacioGuarderiaEliminarServei"
        btnInformacioGuarderiaEliminarServei.Size = New Size(88, 28)
        btnInformacioGuarderiaEliminarServei.TabIndex = 18
        btnInformacioGuarderiaEliminarServei.Text = "Eliminar"
        btnInformacioGuarderiaEliminarServei.UseVisualStyleBackColor = False
        ' 
        ' btnInformacioGuarderiaEliminarVacances
        ' 
        btnInformacioGuarderiaEliminarVacances.BackColor = Color.Aquamarine
        btnInformacioGuarderiaEliminarVacances.Location = New Point(204, 8)
        btnInformacioGuarderiaEliminarVacances.Name = "btnInformacioGuarderiaEliminarVacances"
        btnInformacioGuarderiaEliminarVacances.Size = New Size(80, 30)
        btnInformacioGuarderiaEliminarVacances.TabIndex = 15
        btnInformacioGuarderiaEliminarVacances.Text = "Eliminar"
        btnInformacioGuarderiaEliminarVacances.UseVisualStyleBackColor = False
        ' 
        ' btnInformacioGuarderiaAfegirVacances
        ' 
        btnInformacioGuarderiaAfegirVacances.BackColor = Color.Aquamarine
        btnInformacioGuarderiaAfegirVacances.Location = New Point(107, 8)
        btnInformacioGuarderiaAfegirVacances.Name = "btnInformacioGuarderiaAfegirVacances"
        btnInformacioGuarderiaAfegirVacances.Size = New Size(80, 30)
        btnInformacioGuarderiaAfegirVacances.TabIndex = 14
        btnInformacioGuarderiaAfegirVacances.Text = "Afegir"
        btnInformacioGuarderiaAfegirVacances.UseVisualStyleBackColor = False
        ' 
        ' lblInformacioGuarderiaVacances
        ' 
        lblInformacioGuarderiaVacances.AutoSize = True
        lblInformacioGuarderiaVacances.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblInformacioGuarderiaVacances.Location = New Point(3, 6)
        lblInformacioGuarderiaVacances.Name = "lblInformacioGuarderiaVacances"
        lblInformacioGuarderiaVacances.Size = New Size(94, 28)
        lblInformacioGuarderiaVacances.TabIndex = 28
        lblInformacioGuarderiaVacances.Text = "Vacances:"' 
        ' lblInformacioGuarderiaTitol
        ' 
        lblInformacioGuarderiaTitol.Anchor = AnchorStyles.Top
        lblInformacioGuarderiaTitol.AutoSize = True
        lblInformacioGuarderiaTitol.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblInformacioGuarderiaTitol.Location = New Point(447, 3)
        lblInformacioGuarderiaTitol.Name = "lblInformacioGuarderiaTitol"
        lblInformacioGuarderiaTitol.Size = New Size(294, 41)
        lblInformacioGuarderiaTitol.TabIndex = 31
        lblInformacioGuarderiaTitol.Text = "Informació guarderia"' 
        ' stcInformacioGuarderiaSeparador
        ' 
        stcInformacioGuarderiaSeparador.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        stcInformacioGuarderiaSeparador.Location = New Point(12, 47)
        stcInformacioGuarderiaSeparador.Name = "stcInformacioGuarderiaSeparador"' 
        ' stcInformacioGuarderiaSeparador.Panel1
        ' 
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaCIF)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaCIF)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaTelefon)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaTelefon)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaCorreu)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaCorreu)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaPorta)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaNom)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaDescripcio)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaImatges)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(flpInformacioGuarderiaImatges)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(btnInformacioGuarderiaAfegirImatge)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(btnInformacioGuarderiaEliminarImatge)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaDescripcio)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaNom)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaPais)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(btnInformacioGuarderiaPais)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaMuncipi)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(btnInformacioGuarderiaMunicipi)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaPorta)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaCP)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaCarrer)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(lblInformacioGuarderiaCarrer)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaCP)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaPais)
        stcInformacioGuarderiaSeparador.Panel1.Controls.Add(txtInformacioGuarderiaMunicipi)
        ' 
        ' stcInformacioGuarderiaSeparador.Panel2
        ' 
        stcInformacioGuarderiaSeparador.Panel2.Controls.Add(tlpInformacioGuarderiaTaules)
        stcInformacioGuarderiaSeparador.Size = New Size(1281, 853)
        stcInformacioGuarderiaSeparador.SplitterDistance = 646
        stcInformacioGuarderiaSeparador.TabIndex = 32
        ' 
        ' txtInformacioGuarderiaCIF
        ' 
        txtInformacioGuarderiaCIF.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaCIF.Location = New Point(185, 35)
        txtInformacioGuarderiaCIF.Name = "txtInformacioGuarderiaCIF"
        txtInformacioGuarderiaCIF.Size = New Size(344, 27)
        txtInformacioGuarderiaCIF.TabIndex = 0
        ' 
        ' lblInformacioGuarderiaCIF
        ' 
        lblInformacioGuarderiaCIF.AutoSize = True
        lblInformacioGuarderiaCIF.Location = New Point(61, 42)
        lblInformacioGuarderiaCIF.Name = "lblInformacioGuarderiaCIF"
        lblInformacioGuarderiaCIF.Size = New Size(32, 20)
        lblInformacioGuarderiaCIF.TabIndex = 29
        lblInformacioGuarderiaCIF.Text = "CIF:"' 
        ' txtInformacioGuarderiaTelefon
        ' 
        txtInformacioGuarderiaTelefon.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaTelefon.Location = New Point(187, 464)
        txtInformacioGuarderiaTelefon.Name = "txtInformacioGuarderiaTelefon"
        txtInformacioGuarderiaTelefon.Size = New Size(340, 27)
        txtInformacioGuarderiaTelefon.TabIndex = 11
        ' 
        ' lblInformacioGuarderiaTelefon
        ' 
        lblInformacioGuarderiaTelefon.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInformacioGuarderiaTelefon.AutoSize = True
        lblInformacioGuarderiaTelefon.Location = New Point(64, 467)
        lblInformacioGuarderiaTelefon.Name = "lblInformacioGuarderiaTelefon"
        lblInformacioGuarderiaTelefon.Size = New Size(61, 20)
        lblInformacioGuarderiaTelefon.TabIndex = 23
        lblInformacioGuarderiaTelefon.Text = "Telefon:"' 
        ' txtInformacioGuarderiaCorreu
        ' 
        txtInformacioGuarderiaCorreu.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtInformacioGuarderiaCorreu.Location = New Point(187, 421)
        txtInformacioGuarderiaCorreu.Name = "txtInformacioGuarderiaCorreu"
        txtInformacioGuarderiaCorreu.Size = New Size(340, 27)
        txtInformacioGuarderiaCorreu.TabIndex = 10
        ' 
        ' lblInformacioGuarderiaCorreu
        ' 
        lblInformacioGuarderiaCorreu.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInformacioGuarderiaCorreu.AutoSize = True
        lblInformacioGuarderiaCorreu.Location = New Point(64, 428)
        lblInformacioGuarderiaCorreu.Name = "lblInformacioGuarderiaCorreu"
        lblInformacioGuarderiaCorreu.Size = New Size(56, 20)
        lblInformacioGuarderiaCorreu.TabIndex = 24
        lblInformacioGuarderiaCorreu.Text = "Correu:"' 
        ' tlpInformacioGuarderiaTaules
        ' 
        tlpInformacioGuarderiaTaules.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpInformacioGuarderiaTaules.ColumnCount = 1
        tlpInformacioGuarderiaTaules.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpInformacioGuarderiaTaules.Controls.Add(pnlInformacioGuarderiaVacances, 0, 0)
        tlpInformacioGuarderiaTaules.Controls.Add(pnlInformacioGuarderiaServeis, 0, 1)
        tlpInformacioGuarderiaTaules.Location = New Point(3, 5)
        tlpInformacioGuarderiaTaules.Name = "tlpInformacioGuarderiaTaules"
        tlpInformacioGuarderiaTaules.RowCount = 2
        tlpInformacioGuarderiaTaules.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpInformacioGuarderiaTaules.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpInformacioGuarderiaTaules.Size = New Size(625, 845)
        tlpInformacioGuarderiaTaules.TabIndex = 0
        ' 
        ' pnlInformacioGuarderiaVacances
        ' 
        pnlInformacioGuarderiaVacances.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlInformacioGuarderiaVacances.Controls.Add(lblInformacioGuarderiaVacances)
        pnlInformacioGuarderiaVacances.Controls.Add(btnInformacioGuarderiaEliminarVacances)
        pnlInformacioGuarderiaVacances.Controls.Add(dgvInformacioGuarderia)
        pnlInformacioGuarderiaVacances.Controls.Add(btnInformacioGuarderiaAfegirVacances)
        pnlInformacioGuarderiaVacances.Location = New Point(3, 3)
        pnlInformacioGuarderiaVacances.Name = "pnlInformacioGuarderiaVacances"
        pnlInformacioGuarderiaVacances.Size = New Size(619, 416)
        pnlInformacioGuarderiaVacances.TabIndex = 1
        ' 
        ' pnlInformacioGuarderiaServeis
        ' 
        pnlInformacioGuarderiaServeis.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlInformacioGuarderiaServeis.Controls.Add(lblInformacioGuarderiaServei)
        pnlInformacioGuarderiaServeis.Controls.Add(dtvInformacioGuarderiaServeis)
        pnlInformacioGuarderiaServeis.Controls.Add(btnInformacioGuarderiaAfegirServei)
        pnlInformacioGuarderiaServeis.Controls.Add(btnInformacioGuarderiaEliminarServei)
        pnlInformacioGuarderiaServeis.Location = New Point(3, 425)
        pnlInformacioGuarderiaServeis.Name = "pnlInformacioGuarderiaServeis"
        pnlInformacioGuarderiaServeis.Size = New Size(619, 417)
        pnlInformacioGuarderiaServeis.TabIndex = 0
        ' 
        ' btnInformacioGuarderiaGuardar
        ' 
        btnInformacioGuarderiaGuardar.Anchor = AnchorStyles.Bottom
        btnInformacioGuarderiaGuardar.BackColor = Color.Aquamarine
        btnInformacioGuarderiaGuardar.Location = New Point(829, 936)
        btnInformacioGuarderiaGuardar.Name = "btnInformacioGuarderiaGuardar"
        btnInformacioGuarderiaGuardar.Size = New Size(134, 69)
        btnInformacioGuarderiaGuardar.TabIndex = 22
        btnInformacioGuarderiaGuardar.Text = "Guardar"
        btnInformacioGuarderiaGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnInformacioGuarderiaEliminar
        ' 
        btnInformacioGuarderiaEliminar.Anchor = AnchorStyles.Bottom
        btnInformacioGuarderiaEliminar.BackColor = Color.Aquamarine
        btnInformacioGuarderiaEliminar.Location = New Point(511, 936)
        btnInformacioGuarderiaEliminar.Name = "btnInformacioGuarderiaEliminar"
        btnInformacioGuarderiaEliminar.Size = New Size(134, 69)
        btnInformacioGuarderiaEliminar.TabIndex = 20
        btnInformacioGuarderiaEliminar.Text = "Eliminar"
        btnInformacioGuarderiaEliminar.UseVisualStyleBackColor = False
        ' 
        ' erpInformacioGuarderiaErrors
        ' 
        erpInformacioGuarderiaErrors.ContainerControl = Me
        ' 
        ' InformacionGuarderia
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1302, 1017)
        Controls.Add(btnInformacioGuarderiaEliminar)
        Controls.Add(btnInformacioGuarderiaGuardar)
        Controls.Add(stcInformacioGuarderiaSeparador)
        Controls.Add(lblInformacioGuarderiaTitol)
        Controls.Add(btnInformacioGuarderiaModificar)
        Controls.Add(btnInformacioGuarderiaEnrere)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1320, 1018)
        Name = "InformacionGuarderia"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PHF - Informació Guarderia"
        WindowState = FormWindowState.Maximized
        CType(dgvInformacioGuarderia, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvInformacioGuarderiaServeis, ComponentModel.ISupportInitialize).EndInit()
        stcInformacioGuarderiaSeparador.Panel1.ResumeLayout(False)
        stcInformacioGuarderiaSeparador.Panel1.PerformLayout()
        stcInformacioGuarderiaSeparador.Panel2.ResumeLayout(False)
        CType(stcInformacioGuarderiaSeparador, ComponentModel.ISupportInitialize).EndInit()
        stcInformacioGuarderiaSeparador.ResumeLayout(False)
        tlpInformacioGuarderiaTaules.ResumeLayout(False)
        pnlInformacioGuarderiaVacances.ResumeLayout(False)
        pnlInformacioGuarderiaVacances.PerformLayout()
        pnlInformacioGuarderiaServeis.ResumeLayout(False)
        pnlInformacioGuarderiaServeis.PerformLayout()
        CType(erpInformacioGuarderiaErrors, ComponentModel.ISupportInitialize).EndInit()
        CType(bdgInformacioGuarderiaVistaServeis, ComponentModel.ISupportInitialize).EndInit()
        CType(bdgInformacioGuarderiaVistaVacances, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInformacioGuarderiaEnrere As Button
    Friend WithEvents btnInformacioGuarderiaModificar As Button
    Friend WithEvents lblInformacioGuarderiaNom As Label
    Friend WithEvents lblInformacioGuarderiaDescripcio As Label
    Friend WithEvents iglInformacioGuarderiaImatges As ImageList
    Friend WithEvents lblInformacioGuarderiaImatges As Label
    Friend WithEvents flpInformacioGuarderiaImatges As FlowLayoutPanel
    Friend WithEvents btnInformacioGuarderiaAfegirImatge As Button
    Friend WithEvents btnInformacioGuarderiaEliminarImatge As Button
    Friend WithEvents txtInformacioGuarderiaDescripcio As TextBox
    Friend WithEvents txtInformacioGuarderiaNom As TextBox
    Friend WithEvents lblInformacioGuarderiaPais As Label
    Friend WithEvents lblInformacioGuarderiaMuncipi As Label
    Friend WithEvents lblInformacioGuarderiaPorta As Label
    Friend WithEvents lblInformacioGuarderiaCP As Label
    Friend WithEvents lblInformacioGuarderiaCarrer As Label
    Friend WithEvents txtInformacioGuarderiaPais As TextBox
    Friend WithEvents txtInformacioGuarderiaMunicipi As TextBox
    Friend WithEvents txtInformacioGuarderiaCP As TextBox
    Friend WithEvents txtInformacioGuarderiaCarrer As TextBox
    Friend WithEvents txtInformacioGuarderiaPorta As TextBox
    Friend WithEvents btnInformacioGuarderiaMunicipi As Button
    Friend WithEvents btnInformacioGuarderiaPais As Button
    Friend WithEvents dgvInformacioGuarderia As DataGridView
    Friend WithEvents dtvInformacioGuarderiaServeis As DataGridView
    Friend WithEvents lblInformacioGuarderiaServei As Label
    Friend WithEvents btnInformacioGuarderiaAfegirServei As Button
    Friend WithEvents btnInformacioGuarderiaEliminarServei As Button
    Friend WithEvents btnInformacioGuarderiaEliminarVacances As Button
    Friend WithEvents btnInformacioGuarderiaAfegirVacances As Button
    Friend WithEvents lblInformacioGuarderiaVacances As Label
    Friend WithEvents lblInformacioGuarderiaTitol As Label
    Friend WithEvents stcInformacioGuarderiaSeparador As SplitContainer
    Friend WithEvents tlpInformacioGuarderiaTaules As TableLayoutPanel
    Friend WithEvents pnlInformacioGuarderiaVacances As Panel
    Friend WithEvents pnlInformacioGuarderiaServeis As Panel
    Friend WithEvents btnInformacioGuarderiaGuardar As Button
    Friend WithEvents btnInformacioGuarderiaEliminar As Button
    Friend WithEvents erpInformacioGuarderiaErrors As ErrorProvider
    Friend WithEvents txtInformacioGuarderiaTelefon As TextBox
    Friend WithEvents lblInformacioGuarderiaTelefon As Label
    Friend WithEvents txtInformacioGuarderiaCorreu As TextBox
    Friend WithEvents lblInformacioGuarderiaCorreu As Label
    Friend WithEvents txtInformacioGuarderiaCIF As TextBox
    Friend WithEvents lblInformacioGuarderiaCIF As Label
    Friend WithEvents bdgInformacioGuarderiaVistaServeis As BindingSource
    Friend WithEvents bdgInformacioGuarderiaVistaVacances As BindingSource
End Class
