Imports System.ComponentModel

Public Class MenúGestióGuarderies
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMenuGestGuarderiesAfegGuarderia.Click
        Dim guarderia As New InformacionGuarderia(True)
        guarderia.Show()
        Me.Hide()
    End Sub

    Private Sub MenúGestióGuarderies_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub btnGestioGuarderiesEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioGuarderiesEnrere.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.Click
        GestióGuarderia.Show()
        Me.Hide()
    End Sub

    Private Sub MenúGestióGuarderies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class