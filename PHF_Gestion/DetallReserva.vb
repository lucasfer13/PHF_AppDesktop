Imports System.ComponentModel

Public Class DetallReserva
    Private Sub btnDetallReservaEnrere_Click(sender As Object, e As EventArgs) Handles btnDetallReservaEnrere.Click
        Me.Close()
    End Sub

    Private Sub DetallReserva_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GestioReservas.Show()
    End Sub
End Class