Public Class FormSeveis
    Private Sub btnServeisModify_Click(sender As Object, e As EventArgs) Handles btnServeisModify.Click
        Dim gs As New FormGestioServeis
        gs.ShowDialog()
    End Sub

    Private Sub btnServeisAdd_Click(sender As Object, e As EventArgs) Handles btnServeisAdd.Click
        Dim gs As New FormGestioServeis
        gs.ShowDialog()
    End Sub
End Class