Imports System.ComponentModel

Public Class MenúGestióGuarderies
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMenuGestGuarderiesAfegGuarderia.Click
        'Afegir-Guarderia.Show()
        InformacionGuarderia.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMenuGestGuarderiesEnrere.Click, btnMenuGestGuarderiesEnrere.Click
        Me.Close()
    End Sub

    Private Sub MenúGestióGuarderies_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub
End Class