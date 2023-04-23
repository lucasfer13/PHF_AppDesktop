Imports Data

Public Class LlistatTipusAnimals
    Private idTAnimal As Integer = Nothing
    Private FILTER = "Nom LIKE '*{0}*'"

    Private Sub LlistatTAnimal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sql As New ConnectionBD
        bdgLlistatTAnimaliVista.DataSource = sql.getTAnimal
        dgvLlistatTAnimalsLlista.DataSource = bdgLlistatTAnimaliVista
    End Sub

    Private Sub btnLlistaTAnimalEnrere_Click(sender As Object, e As EventArgs) Handles btnLlistatTAnimalsEnrere.Click
        Me.Close()
    End Sub

    Public Function getIdTanimal() As Integer
        Return idTAnimal
    End Function

    Private Sub dgvLlistatTAnimalLlista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLlistatTAnimalsLlista.CellClick
        If e.RowIndex >= 0 Then
            idTAnimal = CType(bdgLlistatTAnimaliVista.Current, DataRowView).Row.Item(0)
            Me.Close()
        End If
    End Sub

    Private Sub txtLlistatTAnimalBuscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtLlistatTAnimalBuscar.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            bdgLlistatTAnimaliVista.Filter = String.Format(FILTER, sender.Text)
            If bdgLlistatTAnimaliVista.Count = 0 Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bdgLlistatTAnimaliVista.RemoveFilter()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        bdgLlistatTAnimaliVista.RemoveFilter()
    End Sub
End Class