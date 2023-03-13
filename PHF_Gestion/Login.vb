Imports System.ComponentModel

Public Class Login
    Private valid As Boolean = False
    Private Sub btnLoginEntrar_Click(sender As Object, e As EventArgs) Handles btnLoginEntrar.Click
        MenuPrincipal.Show()
        valid = True
        Me.Close()
    End Sub

    Private Sub Login_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If Not valid Then
            MenuPrincipal.Close()
        End If
    End Sub
End Class
