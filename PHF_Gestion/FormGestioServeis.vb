Imports System.ComponentModel
Imports System.Runtime.Serialization

Public Class FormGestioServeis
    Private Sub btnGestioServeiCancel_Click(sender As Object, e As EventArgs) Handles btnGestioServeiCancel.Click
        Me.Close()
    End Sub

    Private Sub FormGestioServeis_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        FormSeveis.Show()
    End Sub
End Class