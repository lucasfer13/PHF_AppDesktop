Imports System.ComponentModel

Public Class TipusAnimal
    Private Sub btnAnimalBack_Click(sender As Object, e As EventArgs) Handles btnAnimalBack.Click
        Me.Close()
    End Sub

    Private Sub TipusAnimal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If btnAnimalAfeg.Enabled Then
            If MsgBox(My.Resources.MisatjeAdvertenciaModificant, MessageBoxButtons.YesNo, My.Resources.Advertencia) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
        GestioTipusAnimals.Show()
    End Sub

    Private Sub btnAnimalAfeg_Click(sender As Object, e As EventArgs) Handles btnAnimalAfeg.Click
        If ValidateChildren() Then
            read()
        End If
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
        If String.IsNullOrEmpty(sender.Text) Then
            erpTipusAnimalErrors.SetError(sender, My.Resources.ErrorObligatoryField)
            e.Cancel = True
        End If
        If Not e.Cancel Then
            erpTipusAnimalErrors.SetError(sender, "")
        End If
    End Sub
End Class