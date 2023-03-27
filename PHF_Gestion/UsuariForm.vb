Imports System.ComponentModel

Public Class UsuariForm
    Private Sub UsuariForm_Closing(sender As Object, e As CancelEventArgs)
        GestioUsuaris.Show()
    End Sub

    Private Sub btnUsuariGuardar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub setRead()
        txtUsuariNom.Enabled = False
        txtUsuariCognom1.Enabled = False
        txtUsuariCognom2.Enabled = False
        txtUsuariDI.Enabled = False
        txtUsuariNomUsuari.Enabled = False
        txtUsuariContrasenya.Enabled = False
        txtUsuariCorreu.Enabled = False
        txtUsuariTelefon.Enabled = False
        btnUsuariGuardar.Enabled = False
    End Sub

    Private Sub setAdd()
        txtUsuariNom.Enabled = True
        txtUsuariCognom1.Enabled = True
        txtUsuariCognom2.Enabled = True
        txtUsuariDI.Enabled = True
        txtUsuariNomUsuari.Enabled = True
        txtUsuariContrasenya.Enabled = True
        txtUsuariCorreu.Enabled = True
        txtUsuariTelefon.Enabled = True
    End Sub

    Private Sub gpbUsuariTipusUsuaris_Validating(sender As Object, e As CancelEventArgs)
        If Not robUsuariAdminstrador.Checked And Not robUsuariAdminstrador.Checked Then
            e.Cancel = True
            erpFormulariUsuariErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If Not e.Cancel Then
            erpFormulariUsuariErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub txtUsuariNom_Validating(sender As TextBox, e As CancelEventArgs) Handles txtUsuariNom.Validating, txtUsuariCognom1.Validating, txtUsuariContrasenya.Validating, txtUsuariNomUsuari.Validating, txtUsuariCorreu.Validating, txtUsuariTelefon.Validating
        If String.IsNullOrEmpty(sender.Text) Then
            e.Cancel = True
            erpFormulariUsuariErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If Not e.Cancel Then
            erpFormulariUsuariErrors.SetError(sender, "")
        End If
    End Sub
End Class