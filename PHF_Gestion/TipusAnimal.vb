Imports System.ComponentModel
Imports Data

Public Class TipusAnimal
    Private dr As DataRow
    Private con As ConnectionBD
    Private contError As Integer
    Public Sub New(dr As DataRow)
        InitializeComponent()
        Me.dr = dr
        con = New ConnectionBD
        If (dr Is Nothing) Then
            modify()
        Else
            read()
            setValues()
        End If
    End Sub
    Private Sub setValues()
        txtgestAnimalnom.Text = dr.Item(1)
    End Sub
    Private Sub btnAnimalBack_Click(sender As Object, e As EventArgs) Handles btnAnimalBack.Click
        Me.Close()
    End Sub
    Private Sub TipusAnimal_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If btnAnimalAfeg.Enabled And dr IsNot Nothing Then
            If MsgBox(My.Resources.MisatjeAdvertenciaModificant, MessageBoxButtons.YesNo, My.Resources.Advertencia) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
        GestioTipusAnimals.cargar()
        GestioTipusAnimals.Show()
        Me.Dispose()
    End Sub
    Private Sub btnAnimalAfeg_Click(sender As Object, e As EventArgs) Handles btnAnimalAfeg.Click
        contError = 0
        Me.ValidateChildren()
        If contError = 0 Then
            If dr Is Nothing Then
                add()
                Me.Close()
            Else
                modificar()
                read()
            End If
        End If
    End Sub
    Private Sub modificar()
        con.comand(String.Format(Constantes.MODIFY_TANIMALS, txtgestAnimalnom.Text, dr.Item(0)))
    End Sub
    Private Sub add()
        con.comand(String.Format(Constantes.INSERT_TANIMALS, txtgestAnimalnom.Text))
    End Sub
    Private Sub modify()
        txtgestAnimalnom.Enabled = True
        btnAnimalAfeg.Enabled = True
        btnTipusAnimalModify.Enabled = False
        btnAnimalElimin.Enabled = False
    End Sub
    Private Sub read()
        txtgestAnimalnom.Enabled = False
        btnAnimalAfeg.Enabled = False
        btnTipusAnimalModify.Enabled = True
        btnAnimalElimin.Enabled = True
    End Sub
    Private Sub btnTipusAnimalModify_Click(sender As Object, e As EventArgs) Handles btnTipusAnimalModify.Click
        modify()
    End Sub
    Private Sub txtgestAnimalnom_Validating(sender As TextBox, e As CancelEventArgs) Handles txtgestAnimalnom.Validating
        Dim validated As Boolean = True
        If String.IsNullOrEmpty(sender.Text) Then
            erpTipusAnimalErrors.SetError(sender, My.Resources.ErrorObligatoryField)
            validated = False
            contError += 1
        End If
        If validated Then
            erpTipusAnimalErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub btnAnimalElimin_Click(sender As Object, e As EventArgs) Handles btnAnimalElimin.Click
        If MsgBox(My.Resources.AdviseDelete, MsgBoxStyle.YesNo, My.Resources.Advertencia) = MsgBoxResult.Yes Then
            con.comand(String.Format(Constantes.DELETE_TANIMALS, dr.Item(0)))
            Me.Close()
        End If
    End Sub
End Class