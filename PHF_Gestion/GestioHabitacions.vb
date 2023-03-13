Imports System.ComponentModel

Public Class GestioHabitacions
    Private Sub btnGestioHabitacionsEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioHabitacionsEnrere.Click
        Me.Close()
    End Sub

    Private Sub GestioHabitacions_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        GestióGuarderia.Show()
    End Sub

    Private Sub btnGestioHabitacionsAfegir_Click(sender As Object, e As EventArgs) Handles btnGestioHabitacionsAfegir.Click
        Me.Hide()
        FormulariHabitacio.Show()
    End Sub

    Private Sub btnGestioHabitacionsAfegirVaries_Click(sender As Object, e As EventArgs) Handles btnGestioHabitacionsAfegirVaries.Click
        Me.Hide()
        FormulariMoltesHabitacions.Show()
    End Sub
End Class