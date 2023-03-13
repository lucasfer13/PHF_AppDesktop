Imports System.ComponentModel

Public Class UsuariForm
    Private Sub UsuariForm_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        GestioUsuaris.Show()
    End Sub

    Private Sub btnUsuariGuardar_Click(sender As Object, e As EventArgs) Handles btnUsuariGuardar.Click
        Me.Close()
    End Sub
End Class