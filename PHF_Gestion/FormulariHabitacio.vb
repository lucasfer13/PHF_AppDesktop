Imports System.ComponentModel

Public Class FormulariHabitacio
    Private Sub btnFormulariHabitacioEnrere_Click(sender As Object, e As EventArgs) Handles btnFormulariHabitacioEnrere.Click
        Me.Close()
    End Sub

    Private Sub FormulariHabitacio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GestioHabitacions.Show()
    End Sub
End Class