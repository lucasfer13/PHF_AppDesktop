Imports System.ComponentModel

Public Class FormGestioServeis
    Private Sub btnGestioServeiCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FormGestioServeis_Closing(sender As Object, e As CancelEventArgs)
        If btnGestioServeiModify.Enabled Then
            If MsgBox(My.Resources.MisatjeAdvertenciaModificant, MessageBoxButtons.YesNo, My.Resources.Advertencia) = MsgBoxResult.No Then
                e.Cancel = True
            Else
                FormSeveis.Show()
            End If
        End If
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

    Private Sub btnGestioServeiModify_Click(sender As Object, e As EventArgs)
        modify()
    End Sub

    Private Sub txtGestioServeiName_Validating(sender As Object, e As CancelEventArgs)
        If String.IsNullOrEmpty(txtGestioServeiName.Text) Then
            e.Cancel = True
            erpGestioServeiErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If Not e.Cancel Then
            erpGestioServeiErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub btnGestioServeiSave_Click(sender As Object, e As EventArgs)
        If ValidateChildren() Then
            read()
        End If
    End Sub
End Class