Imports System.ComponentModel

Public Class GestioCameres
    Private Sub btnCameresEnrere_Click(sender As Object, e As EventArgs) Handles btnCameresEnrere.Click
        Me.Close()
    End Sub

    Private Sub GestioCameres_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        GestióGuarderia.Show()
    End Sub

    Private Sub btnCameresAfegir_Click(sender As Object, e As EventArgs) Handles btnCameresAfegir.Click
        Me.Hide()
        CameraForm.Show()
    End Sub
End Class