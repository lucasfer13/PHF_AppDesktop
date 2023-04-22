Imports System.ComponentModel
Imports Data

Public Class MenuGestioGuarderies
    Private FILTER = "Nom LIKE '*{0}*' OR CIF LIKE '*{0}*'"
    Private Sub MenuGestioGuarderies_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub btnGestioGuarderiesEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioGuarderiesEnrere.Click
        Me.Close()
    End Sub

    Private Sub MenuGestioGuarderies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        dgvMenuGuarderiesLlistat.DataSource = bdgGestioGuarderiesVista
    End Sub

    Public Sub cargar()
        Dim sql As New ConnectionBD
        If MenuPrincipal.user.Rows(0).Item(11) = 1 Then
            bdgGestioGuarderiesVista.DataSource = sql.getGuarderies
        Else
            bdgGestioGuarderiesVista.DataSource = sql.guarderiesGestionadesUsuari(MenuPrincipal.user.Rows(0).Item(0))
        End If
    End Sub

    Private Sub Buscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtGestioGuarderiesBuscar.KeyDown, txtGestioGuarderiesBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            bdgGestioGuarderiesVista.Filter = String.Format(FILTER, sender.Text)
        End If
    End Sub

    Private Sub btnMenuGestGuarderiesAfegGuarderia_Click_1(sender As Object, e As EventArgs) Handles btnMenuGestGuarderiesAfegGuarderia.Click
        Dim info As New InformacionGuarderia(Nothing)
        info.Show()
        Me.Hide()
    End Sub

    Private Sub dgvMenuGuarderiesLlistat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenuGuarderiesLlistat.CellClick
        If e.RowIndex >= 0 Then
            Dim gestioGuarderia As New GestioGuarderia(CType(bdgGestioGuarderiesVista.DataSource, DataTable).Select("idGuarderia = " & dgvMenuGuarderiesLlistat.Rows(e.RowIndex).Cells(0).Value)(0))
            gestioGuarderia.Show()
            Me.Hide()
        End If
    End Sub
End Class