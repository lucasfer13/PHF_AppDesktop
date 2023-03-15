Imports System.ComponentModel

Public Class FormTipusHabitacio
    Private Sub btnFTipusHabitacioEnrere_Click(sender As Object, e As EventArgs) Handles btnFTipusHabitacioEnrere.Click
        Me.Close()
    End Sub

    Private Sub FormTipusHabitacio_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        LlistatTipusHabitacions.Show()
    End Sub
End Class