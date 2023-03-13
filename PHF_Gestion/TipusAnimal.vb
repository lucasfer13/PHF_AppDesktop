Imports System.ComponentModel

Public Class TipusAnimal

    Private Sub btnAnimalBack_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnAnimalBack_Click_1(sender As Object, e As EventArgs) Handles btnAnimalBack.Click
        GestioTipusAnimals.Show()
    End Sub

    Private Sub TipusAnimal_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Me.Close()
    End Sub

    Private Sub btnAnimalAfeg_Click(sender As Object, e As EventArgs) Handles btnAnimalAfeg.Click
        Me.Close()
    End Sub
End Class