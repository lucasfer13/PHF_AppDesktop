Imports Data

Public Class LlistatMunicipi
    Private idPais As Integer
    Private idPC As Integer = Nothing
    Private FILTER = "CP LIKE '*{0}*' OR Nom LIKE '*{0}*'"

    Public Sub New(idPais As Integer)
        InitializeComponent()
        Me.idPais = idPais
    End Sub
    Private Sub LlistatMunicipi_Load(sender As Object, e As EventArgs)
        Dim sql As New ConnectionBD
        bdgLlistatMunicipiVista.DataSource = sql.getMunicipis(idPais)
        dgvLlistatMunicipisLlista.DataSource = bdgLlistatMunicipiVista
    End Sub

    Private Sub btnLlistaMunicipisEnrere_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Function getIdPC() As Integer
        Return idPC
    End Function

    Private Sub dgvLlistatMunicipisLlista_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            idPC = CType(bdgLlistatMunicipiVista.Current, DataRowView).Row.Item(0)
            Me.Close()
        End If
    End Sub

    Private Sub txtLlistatMunicipisBuscar_KeyDown(sender As TextBox, e As KeyEventArgs)
        If e.KeyCode = Keys.KeyCode.Enter Then
            bdgLlistatMunicipiVista.Filter = String.Format(FILTER, sender.Text)
            If bdgLlistatMunicipiVista.Count = 0 Then
                MsgBox(My.Resources.NoResultat, , My.Resources.Advertencia)
                bdgLlistatMunicipiVista.RemoveFilter()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        bdgLlistatMunicipiVista.RemoveFilter()
    End Sub
End Class