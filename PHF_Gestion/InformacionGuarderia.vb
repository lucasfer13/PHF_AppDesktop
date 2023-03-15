Imports System.ComponentModel

Public Class InformacionGuarderia
    Private afegir As Boolean

    Public Sub New(afegir As Boolean)
        InitializeComponent()
        Me.afegir = afegir
    End Sub

    Private Sub InformacionGuarderia_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If afegir Then
            MenuGestioGuarderies.Show()
        Else
            GestioGuarderia.Show()
        End If
    End Sub

    Private Sub btnInformacioGuarderiaEnrere_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaEnrere.Click
        Me.Close()
    End Sub

    Private Sub btnInformacioGuarderiaGuardar_Click(sender As Object, e As EventArgs) Handles btnInformacioGuarderiaGuardar.Click
        Me.Close()
    End Sub

End Class