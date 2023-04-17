Imports System.ComponentModel
Imports Data

Public Class InformacionGuarderia
    Private guarderia As DataRow

    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub

    Private Sub InformacionGuarderia_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
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

        btnInformacioGuarderiaGuardar.Enabled = True
        btnInformacioGuarderiaModificar.Enabled = False
        btnInformacioGuarderiaEliminar.Enabled = False
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
    End Sub

    Private Sub modificar()
        Dim sql As New ConnectionBD
    End Sub

    Private Sub txtInformacioGuarderia_Validating(sender As TextBox, e As CancelEventArgs) Handles txtInformacioGuarderiaNom.Validating, txtInformacioGuarderiaCarrer.Validating, txtInformacioGuarderiaCP.Validating, txtInformacioGuarderiaPorta.Validating, txtInformacioGuarderiaDescripcio.Validating, txtInformacioGuarderiaTelefon.Validating, txtInformacioGuarderiaCorreu.Validating
        If String.IsNullOrEmpty(sender.Text) Then
            e.Cancel = True
            erpInformacioGuarderiaErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If Not e.Cancel Then
            erpInformacioGuarderiaErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub InformacionGuarderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If guarderia Is Nothing Then
            setModify()
        Else
            setRead()
        End If
    End Sub
End Class