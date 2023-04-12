Imports System.ComponentModel
Imports Data

Public Class GestioUsuaris
    Private FILTER As String = "nomusuari LIKE '*{0}*' OR documentidentitat LIKE '*{0}*' OR correu LIKE '*{0}*'"
    Private Sub btnGestioUsuarisEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioUsuarisEnrere.Click
        Me.Close()
    End Sub

    Private Sub GestioUsuaris_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub btnGestioUsuarisAfegir_Click(sender As Object, e As EventArgs) Handles btnGestioUsuarisAfegir.Click
        Dim form As New UsuariForm(Nothing)
        form.Show()
        Me.Hide()
    End Sub

    Private Sub GestioUsuaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Public Sub cargar()
        Dim users As New ConnectionBD
        Dim dt As DataTable = users.getUsers
        bdgGestioUsuarisVista.DataSource = dt
        dgvGestioUsuarisLlista.DataSource = bdgGestioUsuarisVista
        dgvGestioUsuarisLlista.Columns(0).Visible = False
    End Sub

    Private Sub txtGestioUsuarisBuscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtGestioUsuarisBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            bdgGestioUsuarisVista.Filter = String.Format(FILTER, sender.Text)
            If bdgGestioUsuarisVista.Count = 0 Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bdgGestioUsuarisVista.RemoveFilter()
            End If
        End If
    End Sub

    Private Sub btnGestioUsuarisResetBuscar_Click(sender As Object, e As EventArgs) Handles btnGestioUsuarisResetBuscar.Click
        bdgGestioUsuarisVista.RemoveFilter()
    End Sub

    Private Sub dgvGestioUsuarisLlista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGestioUsuarisLlista.CellClick
        If e.RowIndex >= 0 Then
            Dim form As New UsuariForm(CType(bdgGestioUsuarisVista.DataSource, DataTable).Select("idUsuari = " & dgvGestioUsuarisLlista.Rows(e.RowIndex).Cells(0).Value)(0))
            form.Show()
            Me.Hide()
        End If
    End Sub
End Class