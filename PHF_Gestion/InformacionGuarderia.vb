Imports System.ComponentModel
Imports Data

Public Class InformacionGuarderia
    Private guarderia As DataRow
    Private idPC As Integer
    Private idPais As Integer

    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub

    Private Sub InformacionGuarderia_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If guarderia IsNot Nothing Then
            MenuGestioGuarderies.Show()
        Else
            GestioGuarderia.Show()
        End If
    End Sub

    Private Sub setRead()
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

        btnInformacioGuarderiaGuardar.Enabled = False
        btnInformacioGuarderiaModificar.Enabled = True
        btnInformacioGuarderiaEliminar.Enabled = True
    End Sub

    Private Sub setModify()
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

        btnInformacioGuarderiaMunicipi.Enabled = False
        btnInformacioGuarderiaGuardar.Enabled = True
        btnInformacioGuarderiaEliminar.Enabled = False
        btnInformacioGuarderiaModificar.Enabled = False
    End Sub

    Private Sub btnInformacioGuarderiaEnrere_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaEnrere.Click
        Me.Close()
    End Sub

    Private Sub btnInformacioGuarderiaGuardar_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaGuardar.Click
        If guarderia Is Nothing Then
            guardar()
            Me.Close()
        Else
            modificar()
            setRead()
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
        If String.IsNullOrEmpty(sender.Text) Then
            e.Cancel = True
            erpInformacioGuarderiaErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If Not e.Cancel Then
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
        End If
    End Sub

    Private Sub btnInformacioGuarderiaEliminarVacances_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaEliminarVacances.Click
        If bdgInformacioGuarderiaVistaVacances.Current IsNot Nothing Then
            Dim sql As New ConnectionBD
            sql.deleteVacances(bdgInformacioGuarderiaVistaVacances.Current.Row(0).Item(0))
        End If
    End Sub

    Private Sub btnInformacioGuarderiaEliminarServei_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaEliminarServei.Click
        If bdgInformacioGuarderiaVistaServeis.Current IsNot Nothing Then
            Dim sql As New ConnectionBD
            sql.deleteVacances(bdgInformacioGuarderiaVistaServeis.Current.Row(0).Item(0))
        End If
    End Sub
End Class