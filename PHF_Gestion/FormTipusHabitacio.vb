Imports System.ComponentModel
Imports Data

Public Class FormTipusHabitacio
    Private tipusHabitacio As DataRow
    Private idGuarderia As Integer
    Private contError As Integer

    Public Sub New(tipusHabitacio As DataRow, idGuarderia As Integer)
        InitializeComponent()
        Me.tipusHabitacio = tipusHabitacio
        Me.idGuarderia = idGuarderia
    End Sub
    Private Sub btnFTipusHabitacioEnrere_Click(sender As Object, e As EventArgs) Handles btnFTipusHabitacioEnrere.Click
        Me.Close()
    End Sub

    Private Sub FormTipusHabitacio_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If btnFTipusHabitacioGuardar.Enabled Then
            If MsgBox(My.Resources.MisatjeAdvertenciaModificant, MessageBoxButtons.YesNo, My.Resources.Advertencia) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
    End Sub

    Private Sub setRead()
        txtFTipusHabitacioNom.Enabled = False
        txtFTipusHabitacioDesc.Enabled = False
        txtFTipusHabitacioPreu.Enabled = False

        btnFTipusHabitacioModificar.Enabled = True
        btnFTipusHabitacioEliminar.Enabled = True
        btnFTipusHabitacioGuardar.Enabled = False
    End Sub

    Private Sub setModify()
        txtFTipusHabitacioNom.Enabled = True
        txtFTipusHabitacioDesc.Enabled = True
        txtFTipusHabitacioPreu.Enabled = True

        btnFTipusHabitacioModificar.Enabled = False
        btnFTipusHabitacioEliminar.Enabled = False
        btnFTipusHabitacioGuardar.Enabled = True
    End Sub

    Private Sub FormTipusHabitacio_Load(sender As Object, e As EventArgs) Handles Me.Load
        If tipusHabitacio Is Nothing Then
            setModify()
            btnFTipusHabitacioAfegirAnimal.Enabled = False
            btnFTipusHabitacioEliminarAnimal.Enabled = False
        Else
            setValues()
            setRead()
        End If
    End Sub

    Private Sub setValues()
        txtFTipusHabitacioNom.Text = tipusHabitacio.Item(2)
        Try
            txtFTipusHabitacioDesc.Text = tipusHabitacio.Item(3)
        Catch ex As Exception
            txtFTipusHabitacioDesc.Text = ""
        End Try
        txtFTipusHabitacioPreu.Text = tipusHabitacio.Item(4)
        loadAnimal()
    End Sub

    Private Sub loadAnimal()
        Dim sql As New ConnectionBD
        bdgFromThabitacioAnimalVista.DataSource = sql.queryTanimalThabtiacio(tipusHabitacio.Item(0))
        dgvFTipusHabitacioAnimals.DataSource = bdgFromThabitacioAnimalVista
    End Sub

    Private Sub btnFTipusHabitacioModificar_Click(sender As Object, e As EventArgs) Handles btnFTipusHabitacioModificar.Click
        setModify()
    End Sub

    Private Sub btnFTipusHabitacioGuardar_Click(sender As Object, e As EventArgs) Handles btnFTipusHabitacioGuardar.Click
        contError = 0
        Me.ValidateChildren()
        If contError = 0 Then
            If tipusHabitacio Is Nothing Then
                insert()
                setRead()
                Me.Close()
            Else
                modificar()
                setRead()
            End If
        End If
    End Sub

    Private Sub insert()
        Dim sql As New ConnectionBD
        sql.insertTipusHabitacio(idGuarderia, txtFTipusHabitacioNom.Text, txtFTipusHabitacioDesc.Text, Double.Parse(txtFTipusHabitacioPreu.Text))
    End Sub

    Private Sub modificar()
        Dim sql As New ConnectionBD
        sql.updateTipusHabitacio(txtFTipusHabitacioNom.Text, txtFTipusHabitacioDesc.Text, Double.Parse(txtFTipusHabitacioPreu.Text), tipusHabitacio.Item(0))
    End Sub

    Private Sub txtFTipusHabitacioNom_Validating(sender As TextBox, e As CancelEventArgs) Handles txtFTipusHabitacioNom.Validating
        Dim validated As Boolean = True
        If String.IsNullOrEmpty(sender.Text) Then
            contError += 1
            erpFromTHabitacioError.SetError(sender, My.Resources.ErrorObligatoryField)
        End If
        If validated Then
            erpFromTHabitacioError.SetError(sender, "")
        End If
    End Sub

    Private Sub txtFTipusHabitacioPreu_Validating(sender As TextBox, e As CancelEventArgs) Handles txtFTipusHabitacioPreu.Validating
        Dim validated As Boolean = True
        If String.IsNullOrEmpty(sender.Text) Then
            contError += 1
            erpFromTHabitacioError.SetError(sender, My.Resources.ErrorObligatoryField)
            validated = False
        ElseIf Not Double.TryParse(sender.Text, 0) OrElse Double.Parse(sender.Text) <= 0 Then
            contError += 1
            erpFromTHabitacioError.SetError(sender, My.Resources.FormatErrorNumber)
            validated = False
        End If
        If validated Then
            erpFromTHabitacioError.SetError(sender, "")
        End If
    End Sub

    Private Sub btnFTipusHabitacioAfegirAnimal_Click(sender As Object, e As EventArgs) Handles btnFTipusHabitacioAfegirAnimal.Click
        Dim form As New LlistatTipusAnimals
        form.ShowDialog()
        If form.getIdTanimal <> Nothing Then
            Dim sql As New ConnectionBD
            sql.insertTanimalThabitacio(tipusHabitacio.Item(0), form.getIdTanimal)
            loadAnimal()
        End If
    End Sub

    Private Sub btnFTipusHabitacioEliminarAnimal_Click(sender As Object, e As EventArgs) Handles btnFTipusHabitacioEliminarAnimal.Click
        Dim sql As New ConnectionBD
        sql.deleteTanimalThabitacio(tipusHabitacio.Item(0), bdgFromThabitacioAnimalVista.Current.Row.Item(0))
        loadAnimal()
    End Sub

    Private Sub btnFTipusHabitacioEliminar_Click(sender As Object, e As EventArgs) Handles btnFTipusHabitacioEliminar.Click
        Dim sql As New ConnectionBD
        sql.deleteTipusHabitacio(tipusHabitacio.Item(0))
        Me.Close()
    End Sub
End Class