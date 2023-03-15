Imports System.ComponentModel

Public Class Valoracions
    Private Sub btnValoracioEnrere_Click(sender As Object, e As EventArgs) Handles btnValoracioEnrere.Click
        Me.Close()
    End Sub

    Private Sub Valoracions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GestioGuarderia.Show()
    End Sub
End Class