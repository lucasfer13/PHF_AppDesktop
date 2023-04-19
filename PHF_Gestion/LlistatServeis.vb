Imports Data

Public Class LlistatServeis
    Private idServei As Integer
    Private FILTER = "Nom LIKE '*{0}*'"
    Private Sub LlistatServeis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As New ConnectionBD()
        bdgLlistatServeisVista.DataSource = sql.getServeis()
        dgvLlistaServeisLlista.DataSource = bdgLlistatServeisVista
    End Sub

    Public Function getIdServei() As Integer
        Return idServei
    End Function

    Private Sub dgvLlistaServeisLlista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLlistaServeisLlista.CellContentClick
        If e.RowIndex >= 0 Then
            idServei = bdgLlistatServeisVista.Current.Row.Item(0)
            Me.Close()
        End If
    End Sub

    Private Sub txtLlistaServeisBuscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtLlistaServeisBuscar.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            bdgLlistatServeisVista.Filter = String.Format(FILTER, sender.Text)
            If bdgLlistatServeisVista.Count = 0 Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bdgLlistatServeisVista.RemoveFilter()
            End If
        End If
    End Sub

    Private Sub btnLlistaServeisReset_Click(sender As Object, e As EventArgs) Handles btnLlistaServeisReset.Click
        bdgLlistatServeisVista.RemoveFilter()
    End Sub

    Private Sub btnLlistaServeisBack_Click(sender As Object, e As EventArgs) Handles btnLlistaServeisBack.Click
        Me.Close()
    End Sub
End Class