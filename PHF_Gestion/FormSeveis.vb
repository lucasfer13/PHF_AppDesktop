Imports System.ComponentModel

Public Class FormSeveis

    Private Sub btnServeisAdd_Click(sender As Object, e As EventArgs) Handles btnServeisAdd.Click
        Me.Hide()
        FormGestioServeis.Show()
    End Sub

    Private Sub btnServeisBack_Click(sender As Object, e As EventArgs) Handles btnServeisBack.Click
        Me.Close()
    End Sub

    Private Sub FormSeveis_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub
End Class