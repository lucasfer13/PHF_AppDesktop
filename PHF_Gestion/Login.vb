Imports System.ComponentModel
Imports Data
Imports Data.Usuari

Public Class Login
    Private valid As Boolean = False
    Private Sub btnLoginEntrar_Click(sender As Object, e As EventArgs) Handles btnLoginEntrar.Click
        If Me.ValidateChildren Then
            Dim usuari As New Usuari
            Dim dt As DataTable
            dt = usuari.getUser(txtLoginUsuari.Text, txtLoginPassword.Text)
            If (dt.Rows.Count = 1) Then
                valid = True
                MenuPrincipal.user = dt
                Me.Close()
            Else
                erpLoginError.SetError(txtLoginUsuari, My.Resources.ErrorUser)
            End If
        End If
    End Sub

    Private Sub Login_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If Not valid Then
            MenuPrincipal.Close()
        Else
            MenuPrincipal.Show()
        End If
    End Sub

    Private Sub txtLoginUsuari_Validating(sender As TextBox, e As CancelEventArgs) Handles txtLoginUsuari.Validating
        If String.IsNullOrEmpty(sender.Text) Then
            e.Cancel = True
            erpLoginError.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If Not e.Cancel Then
            erpLoginError.SetError(sender, "")
        End If
    End Sub
End Class
