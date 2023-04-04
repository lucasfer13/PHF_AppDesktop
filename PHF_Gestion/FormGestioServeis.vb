Imports System.ComponentModel
Imports Data

Public Class FormGestioServeis
    Private dr As DataRow
    Private serveis As ConnectionBD
    Public Sub New(dr As DataRow)
        InitializeComponent()
        Me.dr = dr
        serveis = New ConnectionBD
        If dr IsNot Nothing Then
            read()
            setProperties()
        Else
            setModify()
        End If
    End Sub
    Public Sub setProperties()
        txtGestioServeiName.Text = dr.Item(1)
        txtGestioServeiDescripcio.Text = dr.Item(2)
    End Sub
    Private Sub btnGestioServeiCancel_Click(sender As Object, e As EventArgs) Handles btnGestioServeiCancel.Click
        Me.Close()
    End Sub

    Private Sub FormGestioServeis_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If btnGestioServeiSave.Enabled And dr IsNot Nothing Then
            If MsgBox(My.Resources.MisatjeAdvertenciaModificant, MessageBoxButtons.YesNo, My.Resources.Advertencia) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
        FormSeveis.loadData()
        FormSeveis.Show()
    End Sub

    Private Sub setModify()
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
        setModify()
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
            If dr Is Nothing Then
                add()
                Me.Close()
            Else
                modify()
            End If
            read()
        End If
    End Sub

    Private Sub add()
        serveis.addServei(txtGestioServeiName.Text, txtGestioServeiDescripcio.Text)
    End Sub

    Private Sub modify()
        serveis.modifyServei(txtGestioServeiName.Text, txtGestioServeiDescripcio.Text, dr.Item(0))
    End Sub

    Private Sub btnGestioServeiEliminar_Click(sender As Object, e As EventArgs) Handles btnGestioServeiEliminar.Click
        serveis.deleteServei(dr.Item(0))
    End Sub
End Class