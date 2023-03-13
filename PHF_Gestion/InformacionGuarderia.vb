Imports System.ComponentModel

Public Class InformacionGuarderia
    Private afegir As Boolean

    Public Sub New(afegir As Boolean)
        Me.afegir = afegir
    End Sub

    Private Sub InformacionGuarderia_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If afegir Then
            MenúGestióGuarderies.Show()
        Else
            GestióGuarderia.Show()
        End If
    End Sub

    Private Sub btnInformacioGuarderiaEnrere_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaEnrere.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class