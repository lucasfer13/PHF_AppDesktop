Imports System.ComponentModel
Imports Data

Public Class GestioCameres
    Private guarderia As DataRow
    Private FILTER = "url LIKE '*{0}*' OR usuari LIKE '*{0}*' OR descripcio LIKE '*{0}*'"
    Private Sub btnCameresEnrere_Click(sender As Object, e As EventArgs) Handles btnCameresEnrere.Click
        Me.Close()
    End Sub

    Private Sub btnCameresAfegir_Click(sender As Object, e As EventArgs) Handles btnCameresAfegir.Click
        Dim form As New CameraForm(Nothing, guarderia.Item(0))
        form.ShowDialog()
        cargar()
    End Sub

    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub

    Private Sub cargar()
        Dim sql As New ConnectionBD
        bdgGestioCameresVista.DataSource = sql.getCameres(guarderia.Item(0))
        dgvCameresLlistat.DataSource = bdgGestioCameresVista
    End Sub

    Private Sub GestioCameres_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar()
    End Sub

    Private Sub btnCameresResetBusqueda_Click(sender As Object, e As EventArgs) Handles btnCameresResetBusqueda.Click
        bdgGestioCameresVista.RemoveFilter()
    End Sub

    Private Sub txtCameresBuscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtCameresBuscar.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            bdgGestioCameresVista.Filter = String.Format(FILTER, sender.Text)
            If bdgGestioCameresVista.Count = 0 Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bdgGestioCameresVista.RemoveFilter()
            End If
        End If
    End Sub

    Private Sub dgvCameresLlistat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCameresLlistat.CellClick
        If e.RowIndex >= 0 Then
            Dim form As New CameraForm(CType(bdgGestioCameresVista.DataSource, DataTable).Select("idCamara = " & bdgGestioCameresVista.Current.Row.Item(0))(0), guarderia.Item(0))
            form.ShowDialog()
            cargar()
        End If
    End Sub
End Class