Imports System.ComponentModel

Public Class GestioUsuaris
    Private Sub btnGestioUsuarisEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioUsuarisEnrere.Click
        Me.Close()
    End Sub

    Private Sub GestioUsuaris_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub btnGestioUsuarisAfegir_Click(sender As Object, e As EventArgs) Handles btnGestioUsuarisAfegir.Click
        UsuariForm.Show()
        Me.Hide()
    End Sub
End Class