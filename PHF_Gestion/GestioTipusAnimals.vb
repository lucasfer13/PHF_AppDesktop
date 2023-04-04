Imports System.ComponentModel
Imports Data

Public Class GestioTipusAnimals
    Private Const FILTER = "nom LIKE '*{0}*'"
    Private Sub btnTipusAnimalEnrere_Click(sender As Object, e As EventArgs) Handles btnTipusAnimalEnrere.Click
        Me.Close()
    End Sub

    Private Sub GestioTipusAnimals_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub btnTipusAnimalAfegir_Click(sender As Object, e As EventArgs) Handles btnTipusAnimalAfegir.Click
        Dim form As New TipusAnimal(Nothing)
        form.Show()
        Me.Hide()
    End Sub

    Private Sub GestioTipusAnimals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Public Sub cargar()
        Dim con As New ConnectionBD
        Dim dt As DataTable = con.getTAnimal
        bdgGestioTipusAnimalsVista.DataSource = dt
        dgvTipusAnimalsLlistat.DataSource = bdgGestioTipusAnimalsVista
        dgvTipusAnimalsLlistat.Columns.Item(0).Visible = False
    End Sub

    Private Sub dgvTipusAnimalsLlistat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipusAnimalsLlistat.CellClick
        If e.RowIndex >= 0 Then
            Dim form As New TipusAnimal(CType(bdgGestioTipusAnimalsVista.DataSource, DataTable).Select("idTipusAnimal = " & dgvTipusAnimalsLlistat.Rows.Item(e.RowIndex).Cells.Item(0).Value)(0))
            form.ShowDialog()
        End If
    End Sub

    Private Sub txtTipusAnimalBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipusAnimalBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            bdgGestioTipusAnimalsVista.Filter = String.Format(FILTER, txtTipusAnimalBuscar.Text)
            If bdgGestioTipusAnimalsVista.Count = 0 Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bdgGestioTipusAnimalsVista.RemoveFilter()
            End If
        End If
    End Sub

    Private Sub btnTipusAnimalReset_Click(sender As Object, e As EventArgs) Handles btnTipusAnimalReset.Click
        bdgGestioTipusAnimalsVista.RemoveFilter()
    End Sub
End Class