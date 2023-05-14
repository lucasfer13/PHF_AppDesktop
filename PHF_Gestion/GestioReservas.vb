Imports System.ComponentModel
Imports Data

Public Class GestioReservas
    Dim guarderia As DataRow
    Private Sub btnGestioReservesEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioReservesEnrere.Click
        Me.Close()
    End Sub

    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub

    Private Sub GestioReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub loadData()
        Dim sql As New ConnectionBD
        dgvGestioReservesReserves.DataSource = sql.getReservesGuarderia(guarderia.Item(0))
    End Sub
End Class