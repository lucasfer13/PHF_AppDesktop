Imports System.ComponentModel

Public Class CameraForm
    Private Sub btnGestioCameraEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioCameraEnrere.Click
        Me.Close()
    End Sub

    Private Sub CameraForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GestioCameres.Show()
    End Sub
End Class