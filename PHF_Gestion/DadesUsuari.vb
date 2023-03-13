Public Class DadesUsuari
    Private Sub btnDadesUsuariTencarSessio_Click(sender As Object, e As EventArgs) Handles btnDadesUsuariTencarSessio.Click, btnDadesUsuariTencarSessio.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnDadesUsuariEnrere_Click(sender As Object, e As EventArgs) Handles btnDadesUsuariEnrere.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub
End Class