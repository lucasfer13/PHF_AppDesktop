Imports Data

Public Class LlistaGuarderies
    Private Const FILTER = "cif LIKE '*{0}*' OR nom LIKE '*{0}*' OR correu LIKE '*{0}*'"
    Public row As DataRow
    Private Sub txtLlistaGuarderiesBuscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtLlistaGuarderiesBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            bgdLlistatGuarderieslVista.Filter = String.Format(FILTER, sender.Text)
            If (bgdLlistatGuarderieslVista.Count = 0) Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bgdLlistatGuarderieslVista.RemoveFilter()
            End If
        End If
    End Sub

    Private Sub cargar()
        Dim sql As New ConnectionBD
        bgdLlistatGuarderieslVista.DataSource = sql.getGuarderies
        dgvLlistaGuarderiesLlista.DataSource = bgdLlistatGuarderieslVista
    End Sub

    Private Sub btnLlistaGuarderiesBack_Click(sender As Object, e As EventArgs) Handles btnLlistaGuarderiesBack.Click
        Me.Close()
    End Sub

    Private Sub LlistaGuarderies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub dgvLlistaGuarderiesLlista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLlistaGuarderiesLlista.CellClick
        If e.RowIndex >= 0 Then
            row = CType(bgdLlistatGuarderieslVista.DataSource, DataTable).Select("idGuarderia = " & dgvLlistaGuarderiesLlista.Rows(e.RowIndex).Cells(0).Value)(0)
            Me.Close()
        End If
    End Sub
End Class