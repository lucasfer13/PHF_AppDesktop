Imports System.ComponentModel

Public Class TipusAnimal


    Private Sub btnAnimalBack_Click(sender As Object, e As EventArgs) Handles btnAnimalBack.Click
        Me.Close()
    End Sub

    Private Sub TipusAnimal_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        GestioTipusAnimals.Show()
    End Sub

    Private Sub btnAnimalAfeg_Click(sender As Object, e As EventArgs) Handles btnAnimalAfeg.Click
        Me.Close()
    End Sub
End Class