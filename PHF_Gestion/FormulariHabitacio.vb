Imports System.ComponentModel
Imports Data

Public Class FormulariHabitacio
    Private guarderia As DataRow
    Private habitacio As DataRow
    Private contError As Integer
    Private tipusHabitacions As DataTable

    Public Sub New(guarderia As DataRow, habitacio As DataRow)
        InitializeComponent()
        Me.guarderia = guarderia
        Me.habitacio = habitacio
    End Sub
    Private Sub btnFormulariHabitacioEnrere_Click(sender As Object, e As EventArgs) Handles btnFormulariHabitacioEnrere.Click
        Me.Close()
    End Sub

    Private Sub FormulariHabitacio_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If btnFormulariHabitacioGuardar.Enabled Then
            If MsgBox(My.Resources.MisatjeAdvertenciaModificant, MessageBoxButtons.YesNo, My.Resources.Advertencia) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
    End Sub

    Private Sub FormulariHabitacio_Load(sender As Object, e As EventArgs) Handles Me.Load
        If habitacio Is Nothing Then
            setModify()
        Else
            setRead()
            txtFormulariHabitacioNumeracio.Text = habitacio.Item(3)
        End If
        loadComboBox()
    End Sub

    Private Sub setRead()
        txtFormulariHabitacioNumeracio.Enabled = False
        cmbFormulariHabitacioTipus.Enabled = False

        btnFormulariHabitacioGuardar.Enabled = False
        btnFormulariHabitacioEliminar.Enabled = True
        btnFormulariHabitacioModificar.Enabled = True
    End Sub

    Private Sub setModify()
        txtFormulariHabitacioNumeracio.Enabled = True
        cmbFormulariHabitacioTipus.Enabled = True

        btnFormulariHabitacioGuardar.Enabled = True
        btnFormulariHabitacioEliminar.Enabled = False
        btnFormulariHabitacioModificar.Enabled = False
    End Sub

    Private Sub loadComboBox()
        Dim sql As New ConnectionBD
        tipusHabitacions = sql.queryTipusHabitacio(guarderia.Item(0))
        For Each row As DataRow In tipusHabitacions.Rows
            cmbFormulariHabitacioTipus.Items.Add(row.Item(2))
        Next
        If habitacio IsNot Nothing Then
            Dim i As Integer = tipusHabitacions.Rows.IndexOf(tipusHabitacions.Select("idTipusHabitacio = " & habitacio.Item(1))(0))
            cmbFormulariHabitacioTipus.SelectedIndex = i
        End If
    End Sub

    Private Sub txtFormulariHabitacioNumeracio_Validating(sender As TextBox, e As CancelEventArgs) Handles txtFormulariHabitacioNumeracio.Validating
        Dim validated As Boolean = True
        If String.IsNullOrEmpty(sender.Text) Then
            validated = False
            contError += 1
            erpFormHabitacioErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If validated Then
            erpFormHabitacioErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub cmbFormulariHabitacioTipus_Validating(sender As ComboBox, e As CancelEventArgs) Handles cmbFormulariHabitacioTipus.Validating
        Dim validated As Boolean = True
        If sender.SelectedIndex = -1 Then
            validated = False
            contError += 1
            erpFormHabitacioErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If validated Then
            erpFormHabitacioErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub btnFormulariHabitacioGuardar_Click(sender As Object, e As EventArgs) Handles btnFormulariHabitacioGuardar.Click
        contError = 0
        Me.ValidateChildren()
        If contError = 0 Then
            If habitacio Is Nothing Then
                insert()
                setRead()
                Me.Close()
            Else
                modify()
                setRead()
            End If
        End If
    End Sub

    Private Sub insert()
        Dim sql As New ConnectionBD
        sql.insertHabitacio(tipusHabitacions.Rows(cmbFormulariHabitacioTipus.SelectedIndex).Item(0), guarderia.Item(0), txtFormulariHabitacioNumeracio.Text)
    End Sub

    Private Sub modify()
        Dim sql As New ConnectionBD
        sql.updateHabitacio(tipusHabitacions.Rows(cmbFormulariHabitacioTipus.SelectedIndex).Item(0), txtFormulariHabitacioNumeracio.Text, habitacio.Item(0))
    End Sub

    Private Sub btnFormulariHabitacioModificar_Click(sender As Object, e As EventArgs) Handles btnFormulariHabitacioModificar.Click
        setModify()
    End Sub

    Private Sub btnFormulariHabitacioEliminar_Click(sender As Object, e As EventArgs) Handles btnFormulariHabitacioEliminar.Click
        Dim sql As New ConnectionBD
        sql.deleteHabitacio(habitacio.Item(0))
        Me.Close()
    End Sub
End Class