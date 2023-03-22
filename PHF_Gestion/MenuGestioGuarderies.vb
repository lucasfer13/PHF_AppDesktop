Imports System.ComponentModel

Public Class MenuGestioGuarderies
    Private Sub btnMenuGestGuarderiesAfegGuarderia_Click(sender As Object, e As EventArgs)
        Dim guarderia As New InformacionGuarderia(True)
        guarderia.Show()
        Me.Hide()
    End Sub

    Private Sub MenuGestioGuarderies_Closing(sender As Object, e As CancelEventArgs)
        MenuPrincipal.Show()
    End Sub

    Private Sub btnGestioGuarderiesEnrere_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As MouseEventArgs)
        GestioGuarderia.Show()
        Me.Hide()
    End Sub
End Class