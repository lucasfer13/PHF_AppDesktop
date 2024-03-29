﻿Public Class GestioGuarderia
    Public guarderia As DataRow
    Public Sub New(guarderia As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnGestioGuarderiaEnrere.Click
        Me.Close()
    End Sub

    Private Sub GestioGuarderia_Click(sender As Object, e As EventArgs) Handles MyBase.Closing
        MenuGestioGuarderies.Show()
    End Sub

    Private Sub btnGestGuarderiaModificar_Click(sender As Object, e As EventArgs) Handles btnGestGuarderiaModificar.Click
        Dim guarderia As New InformacionGuarderia(Me.guarderia)
        guarderia.ShowDialog()
        If guarderia.guarderia Is Nothing Then
            Me.Close()
        Else
            loadName()
        End If
    End Sub

    Private Sub btnGestGuarderiaAfegirHabitacio_Click(sender As Object, e As EventArgs) Handles btnGestGuarderiaAfegirHabitacio.Click
        Dim habitacions As New GestioHabitacions(guarderia)
        habitacions.ShowDialog()
    End Sub

    Private Sub btnGestGuarderiaAfegCameres_Click(sender As Object, e As EventArgs) Handles btnGestGuarderiaAfegCameres.Click
        Dim cameres As New GestioCameres(guarderia)
        cameres.ShowDialog()
    End Sub

    Private Sub btnGestGuarderiaAfegirTipusHabitacio_Click(sender As Object, e As EventArgs) Handles btnGestGuarderiaAfegirTipusHabitacio.Click
        Dim tipusHabitacions As New LlistatTipusHabitacions(guarderia)
        tipusHabitacions.ShowDialog()
    End Sub

    Private Sub btnGestioGuarderiaValoracions_Click(sender As Object, e As EventArgs) Handles btnGestioGuarderiaValoracions.Click
        Dim val As New Valoracions(guarderia)
        val.ShowDialog()
    End Sub

    Private Sub loadName()
        lblGestGuarderiaNomGuarderia.Text = guarderia.Item(2)
    End Sub

    Private Sub GestioGuarderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadName()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reserves As New GestioReservas(guarderia)
        reserves.ShowDialog()
    End Sub
End Class