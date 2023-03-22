Imports System.ComponentModel

Public Class FormGestioServeis
    Private Sub btnGestioServeiCancel_Click(sender As Object, e As EventArgs) Handles btnGestioServeiCancel.Click
        Me.Close()
    End Sub

    Private Sub FormGestioServeis_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If btnGestioServeiSave.Enabled Then
            If MsgBox(My.Resources.MisatjeAdvertenciaModificant, MessageBoxButtons.YesNo, My.Resources.Advertencia) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
        FormSeveis.Show()
    End Sub

    Private Sub modify()
        txtGestioServeiDescripcio.Enabled = True
        txtGestioServeiName.Enabled = True
        btnGestioServeiSave.Enabled = True
        btnGestioServeiModify.Enabled = False
        btnGestioServeiEliminar.Enabled = False
    End Sub

    Private Sub read()
        txtGestioServeiDescripcio.Enabled = False
        txtGestioServeiName.Enabled = False
        btnGestioServeiSave.Enabled = False
        btnGestioServeiModify.Enabled = True
        btnGestioServeiEliminar.Enabled = True
    End Sub

    Private Sub btnGestioServeiModify_Click(sender As Object, e As EventArgs) Handles btnGestioServeiModify.Click
        modify()
    End Sub

    Private Sub txtGestioServeiName_Validating(sender As Object, e As CancelEventArgs) Handles txtGestioServeiName.Validating
        If String.IsNullOrEmpty(txtGestioServeiName.Text) Then
            e.Cancel = True
            erpGestioServeiErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If Not e.Cancel Then
            erpGestioServeiErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub btnGestioServeiSave_Click(sender As Object, e As EventArgs) Handles btnGestioServeiSave.Click
        If ValidateChildren() Then
            read()
        End If
    End Sub
End Class