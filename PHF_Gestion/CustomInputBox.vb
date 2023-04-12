Public Class CustomInputBox
    Public contrasenya As String
    Public titol As String

    Public Sub New(titol As String)
        InitializeComponent()
        Me.titol = titol
    End Sub

    Private Sub CustomInputBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCanviContrasenyaTitol.Text = titol
    End Sub

    Private Sub btnCanviContrasenyaAcceptar_Click(sender As Object, e As EventArgs) Handles btnCanviContrasenyaAcceptar.Click
        contrasenya = txtCanviContrasenyaPass.Text
        Me.Close()
    End Sub

    Private Sub btnCanviContrasenyaCancelar_Click(sender As Object, e As EventArgs) Handles btnCanviContrasenyaCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCanviContrasenyaPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCanviContrasenyaPass.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            contrasenya = txtCanviContrasenyaPass.Text
            Me.Close()
        End If
    End Sub
End Class