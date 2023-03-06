Public Class MenúGestióGuarderies
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pcbMenuGestGuarderiesUsuari.Click
        'Usuaris.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMenuGestGuarderiesAfegGuarderia.Click
        'Afegir-Guarderia.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMenuGestGuarderiesAtras.Click
        Menú_Principal.Show()
        Me.Hide()
    End Sub
End Class