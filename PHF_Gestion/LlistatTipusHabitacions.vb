Imports System.ComponentModel

Public Class LlistatTipusHabitacions
    Private Sub btnTipusHabitacioEnrere_Click(sender As Object, e As EventArgs) Handles btnTipusHabitacioEnrere.Click
        Me.Close()
    End Sub

    Private Sub btnTipusHabitacioAfegir_Click(sender As Object, e As EventArgs) Handles btnTipusHabitacioAfegir.Click
        FormTipusHabitacio.Show()
    End Sub

    Private Sub dgvTipusHabitacionsLlistat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipusHabitacionsLlistat.Click
        FormTipusHabitacio.Show()
    End Sub
End Class