Imports System.ComponentModel
Imports Data

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

    Private Sub MenuGestioGuarderies_Load(sender As Object, e As EventArgs)
        Dim sql As New ConnectionBD
        bdgGestioGuarderiesVista.DataSource = sql.getGuarderies
        dgvMenuGuarderiesLlistat.DataSource = bdgGestioGuarderiesVista
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub
End Class