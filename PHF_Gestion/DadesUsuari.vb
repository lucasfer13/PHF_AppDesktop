Public Class DadesUsuari
    Private Sub btnDadesUsuariTencarSessio_Click(sender As Object, e As EventArgs) Handles btnDadesUsuariTencarSessio.Click, btnDadesUsuariTencarSessio.Click
        Me.Close()
        Login.ShowDialog()
    End Sub
End Class