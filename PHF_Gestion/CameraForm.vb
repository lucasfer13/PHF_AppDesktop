Imports System.ComponentModel
Imports Data

Public Class CameraForm
    Private camera As DataRow
    Private idGuarderia
    Private contError As Integer
    Private Sub btnGestioCameraEnrere_Click(sender As Object, e As EventArgs) Handles btnGestioCameraEnrere.Click
        Me.Close()
    End Sub

    Public Sub New(camera As DataRow, idGuarderia As Integer)
        InitializeComponent()
        Me.camera = camera
        Me.idGuarderia = idGuarderia
    End Sub

    Private Sub CameraForm_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If btnGestioCameraGuardar.Enabled Then
            If MsgBox(My.Resources.MisatjeAdvertenciaModificant, MessageBoxButtons.YesNo, My.Resources.Advertencia) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
    End Sub

    Private Sub setRead()
        txtGestioCameraURL.Enabled = False
        txtGestioCameraUsuari.Enabled = False
        txtGestioCameraContrasenya.Enabled = False
        txtGestioCameraDescripció.Enabled = False

        btnGestioCameraGuardar.Enabled = False
        btnGestioCameraModificar.Enabled = True
        btnGestioCameraEliminar.Enabled = True
    End Sub

    Private Sub setModify()
        txtGestioCameraURL.Enabled = True
        txtGestioCameraUsuari.Enabled = True
        txtGestioCameraContrasenya.Enabled = True
        txtGestioCameraDescripció.Enabled = True

        btnGestioCameraGuardar.Enabled = True
        btnGestioCameraModificar.Enabled = False
        btnGestioCameraEliminar.Enabled = False
    End Sub

    Private Sub setValues()
        txtGestioCameraURL.Text = camera.Item(2)
        txtGestioCameraUsuari.Text = camera.Item(3)
        txtGestioCameraContrasenya.Text = camera.Item(4)
        Try
            txtGestioCameraDescripció.Text = camera.Item(5)
        Catch ex As Exception
            txtGestioCameraContrasenya.Text = ""
        End Try
    End Sub

    Private Sub CameraForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If camera Is Nothing Then
            setModify()
        Else
            setValues()
            setRead()
        End If
    End Sub

    Private Sub btnGestioCameraGuardar_Click(sender As Object, e As EventArgs) Handles btnGestioCameraGuardar.Click
        contError = 0
        Me.ValidateChildren()
        If contError = 0 Then
            If camera Is Nothing Then
                insert()
                setRead()
                Me.Close()
            Else
                guardar()
                setRead()
            End If
        End If
    End Sub

    Private Sub insert()
        Dim sql As New ConnectionBD
        sql.insertCamera(idGuarderia, txtGestioCameraURL.Text, txtGestioCameraUsuari.Text, txtGestioCameraContrasenya.Text, txtGestioCameraDescripció.Text)
    End Sub

    Private Sub guardar()
        Dim sql As New ConnectionBD
        sql.modifyCamera(txtGestioCameraURL.Text, txtGestioCameraUsuari.Text, txtGestioCameraContrasenya.Text, txtGestioCameraDescripció.Text, camera.Item(0))
    End Sub

    Private Sub txtGestioCamera_Validating(sender As TextBox, e As CancelEventArgs) Handles txtGestioCameraContrasenya.Validating, txtGestioCameraURL.Validating, txtGestioCameraUsuari.Validating
        Dim validated As Boolean = True
        If String.IsNullOrEmpty(sender.Text) Then
            contError += 1
            erpFormCameraErrors.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If validated Then
            erpFormCameraErrors.SetError(sender, "")
        End If
    End Sub

    Private Sub btnGestioCameraEliminar_Click(sender As Object, e As EventArgs) Handles btnGestioCameraEliminar.Click
        Dim sql As New ConnectionBD
        sql.deleteCamera(camera.Item(0))
        Me.Close()
    End Sub

    Private Sub btnGestioCameraModificar_Click(sender As Object, e As EventArgs) Handles btnGestioCameraModificar.Click
        setModify()
    End Sub
End Class