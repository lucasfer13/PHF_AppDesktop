Public Class FormSeveis
    Private Sub btnServeisModify_Click(sender As Object, e As EventArgs)
        Dim gs As New FormGestioServeis
        gs.ShowDialog()
    End Sub

    Private Sub btnServeisAdd_Click(sender As Object, e As EventArgs)
        Dim gs As New FormGestioServeis
        gs.ShowDialog()
    End Sub
End Class