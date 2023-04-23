Imports System.ComponentModel
Imports Data

Public Class GestioHabitacions
    Private guarderia As DataRow
    Private FILTER = "numHabitacio LIKE '*{0}*'"

    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub

    Private Sub btnGestioHabitacionsEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioHabitacionsEnrere.Click
        Me.Close()
    End Sub

    Private Sub btnGestioHabitacionsAfegir_Click(sender As Object, e As EventArgs) Handles btnGestioHabitacionsAfegir.Click
        Dim add As New FormulariHabitacio(guarderia, Nothing)
        add.ShowDialog()
        cargar()
    End Sub

    Private Sub cargar()
        Dim sql As New ConnectionBD
        bdgGestioHabitacionsVista.DataSource = sql.getHabitacions(guarderia.Item(0))
        dgvGestioHabitacionsLlistat.DataSource = bdgGestioHabitacionsVista
    End Sub

    Private Sub GestioHabitacions_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar()
    End Sub

    Private Sub txtGestioHabitacionsBuscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtGestioHabitacionsBuscar.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            bdgGestioHabitacionsVista.Filter = String.Format(FILTER, sender.Text)
            If bdgGestioHabitacionsVista.Count = 0 Then
                bdgGestioHabitacionsVista.RemoveFilter()
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
            End If
        End If
    End Sub

    Private Sub btnGestioHabitacionsReset_Click(sender As Object, e As EventArgs) Handles btnGestioHabitacionsReset.Click
        bdgGestioHabitacionsVista.RemoveFilter()
    End Sub

    Private Sub dgvGestioHabitacionsLlistat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGestioHabitacionsLlistat.CellClick
        If e.RowIndex >= 0 Then
            Dim dt As DataTable = bdgGestioHabitacionsVista.DataSource
            Dim fHabitacio As New FormulariHabitacio(guarderia, dt.Select("idHabitacio = " & bdgGestioHabitacionsVista.Current.Row.Item(0))(0))
            fHabitacio.ShowDialog()
            cargar()
        End If
    End Sub
End Class