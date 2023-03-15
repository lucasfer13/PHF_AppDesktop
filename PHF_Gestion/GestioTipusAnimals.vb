Imports System.ComponentModel

Public Class GestioTipusAnimals
    Private Sub btnTipusAnimalEnrere_Click(sender As Object, e As EventArgs) Handles btnTipusAnimalEnrere.Click
        Me.Close()
    End Sub

    Private Sub GestioTipusAnimals_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub btnTipusAnimalAfegir_Click(sender As Object, e As EventArgs) Handles btnTipusAnimalAfegir.Click
        TipusAnimal.Show()
        Me.Hide()
    End Sub

    Private Sub dgvTipusAnimalsLlistat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipusAnimalsLlistat.Click
        TipusAnimal.Show()
        Me.Hide()
    End Sub
End Class