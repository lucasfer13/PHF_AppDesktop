Imports Data

Public Class LlistatPaisos
    Private idPais As Integer
    Private nomPais As String
    Private Const FILTER = "nom = {0}"
    Private Sub LlistatPaisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Public Sub New()
        InitializeComponent()
        idPais = Nothing
    End Sub

    Public Sub cargar()
        Dim sql As New ConnectionBD
        bgsLlistatPaisosVista.DataSource = sql.getPaisos()
        dgvLlistaGuarderiesLlista.DataSource = bgsLlistatPaisosVista
    End Sub

    Public Function getId() As Integer
        Return idPais
    End Function

    Private Sub dgvLlistaGuarderiesLlista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLlistaGuarderiesLlista.CellClick
        If e.RowIndex >= 0 Then
            idPais = bgsLlistatPaisosVista.Current.Row.Item(0)
            nomPais = bgsLlistatPaisosVista.Current.Row.Item(1)
            Me.Close()
        End If
    End Sub

    Public Function getNomPais() As String
        Return nomPais
    End Function

    Private Sub btnLlistaGuarderiesReset_Click(sender As Object, e As EventArgs) Handles btnLlistaGuarderiesReset.Click
        bgsLlistatPaisosVista.RemoveFilter()
    End Sub

    Private Sub txtLlistaGuarderiesBuscar_KeyDown(sender As TextBox, e As KeyEventArgs) Handles txtLlistaGuarderiesBuscar.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            bgsLlistatPaisosVista.Filter = String.Format(FILTER, sender.Text)
            If bgsLlistatPaisosVista.Count = 0 Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bgsLlistatPaisosVista.RemoveFilter()
            End If
        End If
    End Sub
End Class