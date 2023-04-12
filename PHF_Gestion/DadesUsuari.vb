Imports System.ComponentModel
Imports Data

Public Class DadesUsuari
    Private Sub btnDadesUsuariTencarSessio_Click(sender As Object, e As EventArgs) Handles btnDadesUsuariTencarSessio.Click, btnDadesUsuariTencarSessio.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnDadesUsuariEnrere_Click(sender As Object, e As EventArgs) Handles btnDadesUsuariEnrere.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub DadesUsuari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setData()
    End Sub

    Private Sub setData()
        txtDadesUsuariNom.Text = MenuPrincipal.user.Rows.Item(0).Item(2)
        txtDadesUsuariCognom1.Text = MenuPrincipal.user.Rows.Item(0).Item(3)
        txtDadesUsuariCognom1.Text = MenuPrincipal.user.Rows.Item(0).Item(4)
        txtDadesUsuariDI.Text = MenuPrincipal.user.Rows.Item(0).Item(1)
        txtDadesUsuariNomUsuari.Text = MenuPrincipal.user.Rows.Item(0).Item(5)
        txtDadesUsuariCorreu.Text = MenuPrincipal.user.Rows.Item(0).Item(7)
        txtDadesUsuariTelefon.Text = MenuPrincipal.user.Rows.Item(0).Item(8)
    End Sub

    Private Sub setModify()
        btnDadesUsuariGuardar.Enabled = True
        btnDadesUsuariModificar.Enabled = False
        btnDadesUsuariTencarSessio.Enabled = False
        btnDadesUsuariSeleccionarImatge.Enabled = True
        txtDadesUsuariNom.Enabled = True
        txtDadesUsuariCognom1.Enabled = True
        txtDadesUsuariCognom2.Enabled = True
        txtDadesUsuariNomUsuari.Enabled = True
        btnDadesUsuariChangePass.Enabled = True
        txtDadesUsuariCorreu.Enabled = True
        txtDadesUsuariTelefon.Enabled = True
    End Sub

    Private Sub setRead()
        btnDadesUsuariGuardar.Enabled = False
        btnDadesUsuariModificar.Enabled = True
        btnDadesUsuariTencarSessio.Enabled = True
        btnDadesUsuariSeleccionarImatge.Enabled = False
        txtDadesUsuariNom.Enabled = False
        txtDadesUsuariCognom1.Enabled = False
        txtDadesUsuariCognom2.Enabled = False
        txtDadesUsuariNomUsuari.Enabled = False
        btnDadesUsuariChangePass.Enabled = False
        txtDadesUsuariCorreu.Enabled = False
        txtDadesUsuariTelefon.Enabled = False
    End Sub

    Private Sub btnDadesUsuariModificar_Click(sender As Object, e As EventArgs) Handles btnDadesUsuariModificar.Click
        setModify()
    End Sub

    Private Sub btnDadesUsuariGuardar_Click(sender As Object, e As EventArgs) Handles btnDadesUsuariGuardar.Click
        Dim sql As New ConnectionBD
        If Me.ValidateChildren Then
            sql.modifyUser(txtDadesUsuariDI.Text, txtDadesUsuariNom.Text, txtDadesUsuariCognom1.Text, txtDadesUsuariCognom2.Text, txtDadesUsuariNomUsuari.Text, txtDadesUsuariTelefon.Text, txtDadesUsuariCorreu.Text, MenuPrincipal.user.Rows(0).Item(0))
            setRead()
        End If
    End Sub

    Private Sub btnDadesUsuariChangePass_Click(sender As Object, e As EventArgs) Handles btnDadesUsuariChangePass.Click
        Dim passForm As New CustomInputBox(My.Resources.MisatjeIntroduirContrasenya)
        passForm.ShowDialog()
        If passForm.contrasenya IsNot Nothing Then
            If Usuari.generarSHA(passForm.contrasenya) = MenuPrincipal.user.Rows(0).Item(6) Then
                Dim passFormNew As New CustomInputBox(My.Resources.MisatjeIntroduirNovaContrasenya)
                passFormNew.ShowDialog()
                If passFormNew.contrasenya IsNot Nothing Then
                    Dim userConf As New Usuari
                    userConf.modifyPassword(passFormNew.contrasenya, MenuPrincipal.user.Rows(0).Item(0))
                End If
            Else
                MsgBox(My.Resources.ErrorContrasenya,, My.Resources.Advertencia)
            End If
        End If
    End Sub

    Private Sub lblDadesUsuari_Validating(sender As TextBox, e As CancelEventArgs) Handles txtDadesUsuariDI.Validating, txtDadesUsuariNom.Validating, txtDadesUsuariNomUsuari.Validating, txtDadesUsuariCorreu.Validating
        If String.IsNullOrEmpty(sender.Text) Then
            erpDadesUsuariErrors.SetError(sender, My.Resources.ErrorObligatoryField)
            e.Cancel = True
        End If
        If Not e.Cancel Then
            erpDadesUsuariErrors.SetError(sender, "")
        End If
    End Sub
End Class