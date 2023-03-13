Imports System.ComponentModel

Public Class GestioHabitacions
    Private Sub btnGestioHabitacionsEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioHabitacionsEnrere.Click
        Me.Close()
    End Sub

    Private Sub GestioHabitacions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GestióGuarderia.Show()
    End Sub
End Class