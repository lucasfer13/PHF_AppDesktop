Public Class MenuPrincipal
    Public Shared user As DataTable
    Private Sub btnMenuPrinGestioGuarderies_Click(sender As Object, e As EventArgs) Handles btnMenuPrinGestioGuarderies.Click
        MenuGestioGuarderies.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuPrinGestioServeis_Click(sender As Object, e As EventArgs) Handles btnMenuPrinGestioServeis.Click
        FormSeveis.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuPrincipalSortir_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipalSortir.Click
        Me.Close()
    End Sub

    Private Sub btnMenuPrinGestioAnimals_Click(sender As Object, e As EventArgs) Handles btnMenuPrinGestioAnimals.Click
        GestioTipusAnimals.Show()
        Me.Hide()
    End Sub
    Private Sub pcbMenuPrincipalUsuari_Click(sender As Object, e As EventArgs) Handles pcbMenuPrincipalUsuari.Click
        DadesUsuari.Show()
        Me.Hide()
    End Sub
    Private Sub btnMenuPrincipalGestioUsuaris_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipalGestioUsuaris.Click
        Dim form As New GestioUsuaris
        form.Show()
        Me.Hide()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.ShowDialog()
    End Sub

    Public Sub permisos()
        If (Not user.Rows.Item(0).Item(11) = 1) Then
            setSupervisor()
        Else
            setAdministrador()
        End If
    End Sub
    Private Sub setAdministrador()
        btnMenuPrincipalGestioUsuaris.Enabled = True
        btnMenuPrinGestioAnimals.Enabled = True
        btnMenuPrinGestioServeis.Enabled = True
    End Sub
    Private Sub setSupervisor()
        btnMenuPrincipalGestioUsuaris.Enabled = False
        btnMenuPrinGestioAnimals.Enabled = False
        btnMenuPrinGestioServeis.Enabled = False
    End Sub
End Class