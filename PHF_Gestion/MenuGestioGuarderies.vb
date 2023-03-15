Imports System.ComponentModel

Public Class MenuGestioGuarderies
    Private Sub btnMenuGestGuarderiesAfegGuarderia_Click(sender As Object, e As EventArgs) Handles btnMenuGestGuarderiesAfegGuarderia.Click
        Dim guarderia As New InformacionGuarderia(True)
        guarderia.Show()
        Me.Hide()
    End Sub

    Private Sub MenuGestioGuarderies_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub btnGestioGuarderiesEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioGuarderiesEnrere.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As MouseEventArgs) Handles dgvMenuGuarderiesLlistat.MouseClick
        GestioGuarderia.Show()
        Me.Hide()
    End Sub
End Class