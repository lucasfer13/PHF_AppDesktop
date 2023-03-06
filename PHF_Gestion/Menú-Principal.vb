Public Class Menú_Principal
    Private Sub btnMenuPrinGestioGuarderies_Click(sender As Object, e As EventArgs) Handles btnMenuPrinGestioGuarderies.Click
        MenúGestióGuarderies.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuPrinGestioServeis_Click(sender As Object, e As EventArgs) Handles btnMenuPrinGestioServeis.Click
        FormSeveis.Show()
        Me.Hide()
    End Sub
End Class