Imports System.ComponentModel
Imports Data
Imports Mysqlx

Public Class InformacionGuarderia
    Public guarderia As DataRow
    Private idPC As Integer
    Private idPais As Integer
    Private contError As Integer

    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub

    Private Sub InformacionGuarderia_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If btnInformacioGuarderiaGuardar.Enabled Then
            If MsgBox(My.Resources.MisatjeAdvertenciaModificant, MessageBoxButtons.YesNo, My.Resources.Advertencia) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
        If guarderia Is Nothing Then
            MenuGestioGuarderies.Show()
        End If
    End Sub

    Private Sub setRead()
        txtInformacioGuarderiaNom.Enabled = False
        txtInformacioGuarderiaCIF.Enabled = False
        txtInformacioGuarderiaCarrer.Enabled = False
        txtInformacioGuarderiaDescripcio.Enabled = False
        txtInformacioGuarderiaPorta.Enabled = False
        btnInformacioGuarderiaAfegirImatge.Enabled = False
        btnInformacioGuarderiaEliminarImatge.Enabled = False
        btnInformacioGuarderiaAfegirServei.Enabled = False
        btnInformacioGuarderiaEliminarServei.Enabled = False
        btnInformacioGuarderiaAfegirVacances.Enabled = False
        btnInformacioGuarderiaEliminarVacances.Enabled = False
        btnInformacioGuarderiaMunicipi.Enabled = False
        btnInformacioGuarderiaPais.Enabled = False
        txtInformacioGuarderiaTelefon.Enabled = False
        txtInformacioGuarderiaCorreu.Enabled = False

        btnInformacioGuarderiaGuardar.Enabled = False
        btnInformacioGuarderiaModificar.Enabled = True
        If MenuPrincipal.user.Rows(0).Item(11) = 1 Then
            btnInformacioGuarderiaEliminar.Enabled = True
        End If
    End Sub

    Private Sub setModify()
        txtInformacioGuarderiaNom.Enabled = True
        txtInformacioGuarderiaCIF.Enabled = True
        txtInformacioGuarderiaCarrer.Enabled = True
        txtInformacioGuarderiaDescripcio.Enabled = True
        txtInformacioGuarderiaPorta.Enabled = True
        btnInformacioGuarderiaAfegirImatge.Enabled = True
        btnInformacioGuarderiaEliminarImatge.Enabled = True
        btnInformacioGuarderiaAfegirServei.Enabled = True
        btnInformacioGuarderiaEliminarServei.Enabled = True
        btnInformacioGuarderiaAfegirVacances.Enabled = True
        btnInformacioGuarderiaEliminarVacances.Enabled = True
        btnInformacioGuarderiaPais.Enabled = True
        txtInformacioGuarderiaTelefon.Enabled = True
        txtInformacioGuarderiaCorreu.Enabled = True

        btnInformacioGuarderiaMunicipi.Enabled = False
        btnInformacioGuarderiaGuardar.Enabled = True
        btnInformacioGuarderiaEliminar.Enabled = False
        btnInformacioGuarderiaModificar.Enabled = False
    End Sub

    Private Sub btnInformacioGuarderiaEnrere_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaEnrere.Click
        Me.Close()
    End Sub

    Private Sub btnInformacioGuarderiaGuardar_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaGuardar.Click
        contError = 0
        Me.ValidateChildren()
        If contError = 0 Then
            If guarderia Is Nothing Then
                guardar()
                Me.Close()
                MenuGestioGuarderies.cargar()
            Else
                modificar()
                setRead()
                MenuGestioGuarderies.cargar()
            End If
        End If
    End Sub

    Private Sub guardar()
        Dim sql As New ConnectionBD
        sql.insertGuarderia(txtInformacioGuarderiaCIF.Text, txtInformacioGuarderiaNom.Text, txtInformacioGuarderiaDescripcio.Text, txtInformacioGuarderiaCorreu.Text, txtInformacioGuarderiaTelefon.Text, idPC, txtInformacioGuarderiaCarrer.Text, txtInformacioGuarderiaPorta.Text)
    End Sub

    Private Sub modificar()
        Dim sql As New ConnectionBD
        sql.modifyGuarderia(txtInformacioGuarderiaCIF.Text, txtInformacioGuarderiaNom.Text, txtInformacioGuarderiaDescripcio.Text, txtInformacioGuarderiaCorreu.Text, txtInformacioGuarderiaTelefon.Text, idPC, txtInformacioGuarderiaCarrer.Text, txtInformacioGuarderiaPorta.Text, guarderia.Item(0))
    End Sub

    Private Sub txtInformacioGuarderia_Validating(sender As TextBox, e As CancelEventArgs) Handles txtInformacioGuarderiaCIF.Validating, txtInformacioGuarderiaNom.Validating, txtInformacioGuarderiaDescripcio.Validating, txtInformacioGuarderiaPais.Validating, txtInformacioGuarderiaMunicipi.Validating, txtInformacioGuarderiaCP.Validating, txtInformacioGuarderiaCarrer.Validating, txtInformacioGuarderiaPorta.Validating, txtInformacioGuarderiaTelefon.Validating, txtInformacioGuarderiaCorreu.Validating
        Dim validated As Boolean = True
        If String.IsNullOrEmpty(sender.Text) Then
            contError += 1
            validated = False
            erpInformacioGuarderiaErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If validated Then
            erpInformacioGuarderiaErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub InformacionGuarderia_Load(sender As Object, e As EventArgs) Handles Me.Load
        If guarderia Is Nothing Then
            setModify()
            btnInformacioGuarderiaAfegirVacances.Enabled = False
            btnInformacioGuarderiaEliminarVacances.Enabled = False
            btnInformacioGuarderiaAfegirServei.Enabled = False
            btnInformacioGuarderiaEliminarServei.Enabled = False
        Else
            setValues()
            setRead()
        End If
    End Sub

    Private Sub btnInformacioGuarderiaPais_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaPais.Click
        Dim pais As New LlistatPaisos
        pais.ShowDialog()
        If Not pais.getId = Nothing Then
            idPais = pais.getId
            txtInformacioGuarderiaPais.Text = pais.getNomPais
            btnInformacioGuarderiaMunicipi.Enabled = True
            erpInformacioGuarderiaErrors.SetError(txtInformacioGuarderiaPais, "")
        End If
    End Sub

    Private Sub btnInformacioGuarderiaMunicipi_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaMunicipi.Click
        Dim municipis As New LlistatMunicipi(idPais)
        municipis.ShowDialog()
        If Not municipis.getIdPC = Nothing Then
            idPC = municipis.getIdPC
            Dim sql As New ConnectionBD
            Dim data As DataTable
            data = sql.getDireccio(idPC, idPais)
            txtInformacioGuarderiaCP.Text = data.Rows(0).Item(0)
            txtInformacioGuarderiaMunicipi.Text = data.Rows(0).Item(1)
            txtInformacioGuarderiaPais.Text = data.Rows(0).Item(2)
            erpInformacioGuarderiaErrors.SetError(txtInformacioGuarderiaMunicipi, "")
            erpInformacioGuarderiaErrors.SetError(txtInformacioGuarderiaCP, "")
        End If
    End Sub

    Private Sub btnInformacioGuarderiaAfegirServei_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaAfegirServei.Click
        Dim llistaServeis As New LlistatServeis
        llistaServeis.ShowDialog()
        If Not llistaServeis.getIdServei = Nothing Then
            Dim sql As New ConnectionBD
            sql.addGuarderiaServei(guarderia.Item(0), llistaServeis.getIdServei)
        End If
    End Sub

    Private Sub btnInformacioGuarderiaAfegirVacances_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaAfegirVacances.Click
        Dim llistaVacances As New FormVacances
        llistaVacances.ShowDialog()
        If Not llistaVacances.dataFinal = Nothing And Not llistaVacances.dataInici = Nothing Then
            Dim sql As New ConnectionBD
            sql.createVacances(guarderia.Item(0), llistaVacances.dataInici, llistaVacances.dataFinal)
            loadForeign()
        End If
    End Sub

    Private Sub btnInformacioGuarderiaEliminarVacances_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaEliminarVacances.Click
        If bdgInformacioGuarderiaVistaVacances.Current IsNot Nothing Then
            Dim sql As New ConnectionBD
            sql.deleteVacances(bdgInformacioGuarderiaVistaVacances.Current.Row.Item(0))
            loadForeign()
        End If
    End Sub

    Private Sub btnInformacioGuarderiaEliminarServei_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaEliminarServei.Click
        If bdgInformacioGuarderiaVistaServeis.Current IsNot Nothing Then
            Dim sql As New ConnectionBD
            sql.deleteGuarderiaServei(guarderia.Item(0), CType(bdgInformacioGuarderiaVistaServeis.Current, DataRowView).Row.Item(0))
            loadForeign()
        End If
    End Sub

    Private Sub setValues()
        txtInformacioGuarderiaCIF.Text = guarderia.Item(1)
        txtInformacioGuarderiaNom.Text = guarderia.Item(2)
        txtInformacioGuarderiaDescripcio.Text = guarderia.Item(3)
        txtInformacioGuarderiaCorreu.Text = guarderia.Item(4)
        txtInformacioGuarderiaTelefon.Text = guarderia.Item(5)
        txtInformacioGuarderiaCarrer.Text = guarderia.Item(7)
        txtInformacioGuarderiaPorta.Text = guarderia.Item(8)
        loadForeign()
    End Sub

    Private Sub loadForeign()
        Dim sql As New ConnectionBD
        Dim dt As DataTable
        dt = sql.getDireccioByCP(guarderia.Item(6))
        bdgInformacioGuarderiaVistaServeis.DataSource = sql.getGuarderiaServeis(guarderia.Item(0))
        dtvInformacioGuarderiaServeis.DataSource = bdgInformacioGuarderiaVistaServeis
        bdgInformacioGuarderiaVistaVacances.DataSource = sql.getGuarderiaVacances(guarderia.Item(0))
        dgvInformacioGuarderia.DataSource = bdgInformacioGuarderiaVistaVacances
        idPC = dt.Rows(0).Item(0)
        idPais = dt.Rows(0).Item(1)
        txtInformacioGuarderiaCP.Text = dt.Rows(0).Item(2)
        txtInformacioGuarderiaMunicipi.Text = dt.Rows(0).Item(3)
        txtInformacioGuarderiaPais.Text = dt.Rows(0).Item(4)
    End Sub

    Private Sub btnInformacioGuarderiaModificar_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaModificar.Click
        setModify()
    End Sub

    Private Sub btnInformacioGuarderiaEliminar_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaEliminar.Click
        Dim sql As New ConnectionBD
        sql.deleteGuarderia(guarderia.Item(0))
        MenuGestioGuarderies.cargar()
        guarderia = Nothing
        Me.Close()
    End Sub
End Class