Imports System.ComponentModel

Public Class LlistatTipusHabitacions
    Private guarderia As DataRow

    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub
    Private Sub btnTipusHabitacioEnrere_Click(sender As Object, e As EventArgs) Handles btnTipusHabitacioEnrere.Click
        Me.Close()
    End Sub

    Private Sub btnTipusHabitacioAfegir_Click(sender As Object, e As EventArgs) Handles btnTipusHabitacioAfegir.Click
        Dim add As New FormTipusHabitacio(Nothing, guarderia.Item(0))
        add.ShowDialog()
    End Sub
End Class