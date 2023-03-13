Public Class MenuPrincipal
    Private Sub btnMenuPrinGestioGuarderies_Click(sender As Object, e As EventArgs) Handles btnMenuPrinGestioGuarderies.Click
        MenúGestióGuarderies.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuPrinGestioServeis_Click(sender As Object, e As EventArgs) Handles btnMenuPrinGestioServeis.Click
        FormSeveis.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuPrincipalSortir_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipalSortir.Click
        Me.Close()
    End Sub

    Private Sub btnMenuPrinGestioAnimals_Click(sender As Object, e As EventArgs) Handles btnMenuPrinGestioAnimals.Click
        GestioTipusAnimals.Show()
        Me.Hide()
    End Sub
    Private Sub pcbMenuPrincipalUsuari_Click(sender As Object, e As EventArgs) Handles pcbMenuPrincipalUsuari.Click
        DadesUsuari.Show()
        Me.Hide()
    End Sub
    Private Sub btnMenuPrincipalGestioUsuaris_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipalGestioUsuaris.Click
        GestioUsuaris.Show()
        Me.Hide()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class