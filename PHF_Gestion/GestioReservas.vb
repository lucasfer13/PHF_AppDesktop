Imports System.ComponentModel

Public Class GestioReservas
    Private Sub btnGestioReservesEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioReservesEnrere.Click
        Me.Close()
    End Sub

    Private Sub GestioReservas_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        GestioGuarderia.Show()
    End Sub

    Private Sub dgvGestioReservesReserves_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGestioReservesReserves.Click
        Me.Hide()
        DetallReserva.Show()
    End Sub
End Class