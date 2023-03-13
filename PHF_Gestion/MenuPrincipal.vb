Public Class MenuPrincipal
    Private Sub btnMenuPrinGestioGuarderies_Click(sender As Object, e As EventArgs) Handles btnMenuPrinGestioGuarderies.Click
        MenúGestióGuarderies.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuPrinGestioServeis_Click(sender As Object, e As EventArgs)
        FormSeveis.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuPrincipalSortir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnMenuPrinGestioAnimals_Click(sender As Object, e As EventArgs)
        GestioTipusAnimals.Show()
        Me.Hide()
    End Sub
    Private Sub pcbMenuPrincipalUsuari_Click(sender As Object, e As EventArgs)
        DadesUsuari.Show()
        Me.Hide()
    End Sub
    Private Sub btnMenuPrincipalGestioUsuaris_Click(sender As Object, e As EventArgs)
        GestioUsuaris.Show()
        Me.Hide()
    End Sub
End Class