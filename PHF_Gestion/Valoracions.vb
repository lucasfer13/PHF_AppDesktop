Imports System.ComponentModel
Imports Data

Public Class Valoracions
    Private guarderia As DataRow
    Private FILTER = "Data >= {0} AND Data < {1}"

    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub

    Private Sub btnValoracioEnrere_Click(sender As Object, e As EventArgs) Handles btnValoracioEnrere.Click
        Me.Close()
    End Sub

    Private Sub Valoracions_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar()
    End Sub

    Private Sub cargar()
        Dim sql As New ConnectionBD
        bdgValoracionsVista.DataSource = sql.getValoracions(guarderia.Item(0))
        dgvValoriacioLlistat.DataSource = bdgValoracionsVista
    End Sub

    Private Sub dtpValoracioFiltrarData_CloseUp(sender As DateTimePicker, e As EventArgs) Handles dtpValoracioFiltrarData.CloseUp
        bdgValoracionsVista.Filter = String.Format(FILTER, sender.Value.ToShortDateString, sender.Value.AddDays(1).ToShortDateString)
        If bdgValoracionsVista.Count = 0 Then
            bdgValoracionsVista.RemoveFilter()
            MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
        End If
    End Sub

    Private Sub btnValoracioResetFilter_Click(sender As Object, e As EventArgs) Handles btnValoracioResetFilter.Click
        bdgValoracionsVista.RemoveFilter()
    End Sub
End Class