Imports System.ComponentModel
Imports Data

Public Class FormSeveis
    Private Const FILTER As String = "nom LIKE '*{0}*' OR descripcio LIKE '*{1}*'"
    Private Sub btnServeisAdd_Click(sender As Object, e As EventArgs) Handles btnServeisAdd.Click
        Me.Hide()
        Dim fgs As New FormGestioServeis(Nothing)
        fgs.Show()
    End Sub

    Private Sub btnServeisBack_Click(sender As Object, e As EventArgs) Handles btnServeisBack.Click
        Me.Close()
    End Sub

    Private Sub FormSeveis_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub FormSeveis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Public Sub loadData()
        Dim sql As New ConnectionBD
        bdgServeisVista.DataSource = sql.getServeis
        dgvServeis.DataSource = bdgServeisVista
        dgvServeis.Columns.Item(0).Visible = False
    End Sub

    Private Sub dgvServeis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServeis.CellClick
        If e.RowIndex >= 0 Then
            Dim dt As DataTable = bdgServeisVista.DataSource
            Dim dr As DataRow = dt.Select("idServei = " & dgvServeis.Rows.Item(e.RowIndex).Cells.Item(0).Value)(0)
            Dim fgs As New FormGestioServeis(dr)
            fgs.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtServeisBuscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtServeisBuscar.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            bdgServeisVista.Filter = String.Format(FILTER, sender.Text, sender.Text)
            If bdgServeisVista.Count = 0 Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bdgServeisVista.RemoveFilter()
            End If
        End If
    End Sub

    Private Sub btnServeisReset_Click(sender As Object, e As EventArgs) Handles btnServeisReset.Click
        bdgServeisVista.RemoveFilter()
    End Sub
End Class