Public Class Valoracions
    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tblValoracionsView.Paint

    End Sub

    Private Sub Valoracions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnValoraciobck_Click(sender As Object, e As EventArgs) Handles btnValoraciobck.Click
        Menú_Principal.Show()
        Me.Hide()
    End Sub
End Class