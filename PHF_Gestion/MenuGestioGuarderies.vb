Imports System.ComponentModel
Imports Data

Public Class MenuGestioGuarderies

    Private Sub MenuGestioGuarderies_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub btnGestioGuarderiesEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioGuarderiesEnrere.Click
        Me.Close()
    End Sub

    Private Sub MenuGestioGuarderies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As New ConnectionBD
        bdgGestioGuarderiesVista.DataSource = sql.getGuarderies
        dgvMenuGuarderiesLlistat.DataSource = bdgGestioGuarderiesVista
    End Sub

    Private Sub Buscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGestioGuarderiesBuscar.KeyDown, txtGestioGuarderiesBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub btnMenuGestGuarderiesAfegGuarderia_Click_1(sender As Object, e As EventArgs) Handles btnMenuGestGuarderiesAfegGuarderia.Click
        Dim info As New InformacionGuarderia(Nothing)
        info.Show()
        Me.Hide()
    End Sub
End Class