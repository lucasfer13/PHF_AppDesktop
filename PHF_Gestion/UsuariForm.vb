Imports System.ComponentModel
Imports Data

Public Class UsuariForm
    Private guarderies As DataTable
    Private usuari As DataRow

    Public Sub New(usuari As DataRow)
        InitializeComponent()
        Me.usuari = usuari
    End Sub
    Private Sub UsuariForm_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        GestioUsuaris.Show()
    End Sub

    Private Sub btnUsuariGuardar_Click(sender As Object, e As EventArgs) Handles btnUsuariGuardar.Click
        If Me.ValidateChildren Then
            Dim sql As New ConnectionBD
            sql.addUser(txtUsuariDI.Text, txtUsuariNom.Text, txtUsuariCognom1.Text, txtUsuariCognom2.Text, txtUsuariNomUsuari.Text, txtUsuariContrasenya.Text, txtUsuariTelefon.Text, txtUsuariCorreu.Text)
            relation()
            Me.Close()
        End If
    End Sub
    Private Sub relation()
        Dim user As New Usuari
        Dim row As DataRow = user.getUser(txtUsuariNomUsuari.Text)
        Dim sql As New ConnectionBD
        sql.relacionarUsuarisGuarderies(row, guarderies)
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
        btnUsuariEliminar.Enabled = True
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
        btnUsuariEliminar.Enabled = False
    End Sub

    Private Sub gpbUsuariTipusUsuaris_Validating(sender As Object, e As CancelEventArgs) Handles gpbUsuariTipusUsuaris.Validating
        If Not robUsuariAdminstrador.Checked And Not robUsuariSupervisor.Checked Then
            e.Cancel = True
            erpFormulariUsuariErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If Not e.Cancel Then
            erpFormulariUsuariErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub txtUsuariNom_Validating(sender As TextBox, e As CancelEventArgs) Handles txtUsuariDI.Validating, txtUsuariNom.Validating, txtUsuariCognom1.Validating, txtUsuariContrasenya.Validating, txtUsuariNomUsuari.Validating, txtUsuariCorreu.Validating, txtUsuariTelefon.Validating
        If String.IsNullOrEmpty(sender.Text) Then
            e.Cancel = True
            erpFormulariUsuariErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If Not e.Cancel Then
            erpFormulariUsuariErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub robUsuariAdminstrador_CheckedChanged(sender As Object, e As EventArgs) Handles robUsuariAdminstrador.CheckedChanged, robUsuariSupervisor.CheckedChanged
        If robUsuariAdminstrador.Checked Then
            setAdmin()
        Else
            setSupervisor()
        End If
    End Sub

    Private Sub setSupervisor()
        dgvUsuariGuarderies.Enabled = True
        btnUsuariAfegirGuarderia.Enabled = True
        btnUsuariElminarGuarderia.Enabled = True
    End Sub

    Private Sub setAdmin()
        dgvUsuariGuarderies.Enabled = False
        btnUsuariAfegirGuarderia.Enabled = False
        btnUsuariElminarGuarderia.Enabled = False
    End Sub

    Private Sub btnUsuariAfegirGuarderia_Click(sender As Object, e As EventArgs) Handles btnUsuariAfegirGuarderia.Click
        Dim llistat As New LlistaGuarderies
        llistat.ShowDialog()
        If llistat.row IsNot Nothing Then
            If guarderies.Select("idGuarderia = " & llistat.row(0)).Count = 0 Then
                guarderies.ImportRow(llistat.row)
                bdgFormUserVista.ResetBindings(False)
                If usuari IsNot Nothing Then
                    Dim sql As New ConnectionBD
                    sql.relacionarUsuarisGuarderies(usuari(0), llistat.row(0))
                End If
            End If
        End If
    End Sub

    Private Sub setValues()
        Dim sql As New ConnectionBD
        guarderies = sql.guarderiesGestionadesUsuari(usuari(0))
        bdgFormUserVista.DataSource = guarderies
        dgvUsuariGuarderies.DataSource = bdgFormUserVista
        txtUsuariDI.Text = usuari(1)
        txtUsuariNom.Text = usuari(2)
        txtUsuariCognom1.Text = usuari(3)
        txtUsuariCognom2.Text = usuari(4)
        txtUsuariNomUsuari.Text = usuari(5)
        txtUsuariTelefon.Text = usuari(7)
        txtUsuariCorreu.Text = usuari(8)
        If usuari(11) = 1 Then
            robUsuariAdminstrador.Checked = True
        ElseIf usuari(11) = 2 Then
            robUsuariSupervisor.Checked = True
        Else
            setAdmin()
        End If
    End Sub

    Private Sub UsuariForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As New ConnectionBD
        If usuari IsNot Nothing Then
            setValues()
            setRead()
        Else
            setAdd()
            guarderies = sql.getGuarderies
            guarderies.Rows.Clear()
            bdgFormUserVista.DataSource = guarderies
            dgvUsuariGuarderies.DataSource = bdgFormUserVista
        End If
    End Sub

    Private Sub btnUsuariEnrere_Click(sender As Object, e As EventArgs) Handles btnUsuariEnrere.Click
        Me.Close()
    End Sub

    Private Sub btnUsuariEliminar_Click(sender As Object, e As EventArgs) Handles btnUsuariEliminar.Click
        If usuari(0) <> MenuPrincipal.user.Rows(0).Item(0) Then
            Dim sql As New ConnectionBD
            sql.deleteUser(usuari(0))
            Me.Close()
        End If
    End Sub
End Class