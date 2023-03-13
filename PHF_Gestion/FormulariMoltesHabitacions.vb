Imports System.ComponentModel

Public Class FormulariMoltesHabitacions
    Private Sub btnAfegirHabitacionsGuardar_Click(sender As Object, e As EventArgs) Handles btnAfegirHabitacionsGuardar.Click
        Me.Close()
    End Sub

    Private Sub FormulariMoltesHabitacions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GestioHabitacions.Show()
    End Sub
End Class