Imports System.ComponentModel
Imports Data

Public Class LlistatTipusHabitacions
    Private guarderia As DataRow
    Private FILTER = "nom LIKE '*{0}*'"

    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub
    Private Sub btnTipusHabitacioEnrere_Click(sender As Object, e As EventArgs) Handles btnTipusHabitacioEnrere.Click
        Me.Close()
    End Sub

    Private Sub cargar()
        Dim sql As New ConnectionBD
        bdgLListatTHabitacionsVista.DataSource = sql.queryTipusHabitacio(guarderia.Item(0))
        dgvTipusHabitacionsLlistat.DataSource = bdgLListatTHabitacionsVista
    End Sub

    Private Sub btnTipusHabitacioAfegir_Click(sender As Object, e As EventArgs) Handles btnTipusHabitacioAfegir.Click
        Dim add As New FormTipusHabitacio(Nothing, guarderia.Item(0))
        add.ShowDialog()
        cargar()
    End Sub

    Private Sub LlistatTipusHabitacions_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar()
    End Sub

    Private Sub txtTipusHabitacionsBuscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtTipusHabitacionsBuscar.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            bdgLListatTHabitacionsVista.Filter = String.Format(FILTER, sender.Text)
            If bdgLListatTHabitacionsVista.Count = 0 Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bdgLListatTHabitacionsVista.RemoveFilter()
            End If
        End If
    End Sub

    Private Sub btnTipusHabitacionsReset_Click(sender As Object, e As EventArgs) Handles btnTipusHabitacionsReset.Click
        bdgLListatTHabitacionsVista.RemoveFilter()
    End Sub

    Private Sub dgvTipusHabitacionsLlistat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipusHabitacionsLlistat.CellClick
        If e.RowIndex >= 0 Then
            Dim modify As New FormTipusHabitacio(CType(bdgLListatTHabitacionsVista.DataSource, DataTable).Select("idTipusHabitacio =" & bdgLListatTHabitacionsVista.Current.Row.Item(0))(0), guarderia.Item(0))
            modify.ShowDialog()
            cargar()
        End If
    End Sub
End Class