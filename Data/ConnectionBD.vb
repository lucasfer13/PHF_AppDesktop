Imports System.Collections.ObjectModel
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ConnectionBD
    Private connexio As MySqlConnection
    Public Sub connect()
        connexio = New MySqlConnection
        connexio.ConnectionString = Constantes.CONNECTION_STRING
        Try
            connexio.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub close()
        If connexio.State = 1 Then
            connexio.Dispose()
        End If
    End Sub

    Public Function query(sel As String) As DataTable
        connect()
        Dim a As New MySqlDataAdapter(sel, connexio)
        Dim dt As New DataTable
        a.Fill(dt)
        close()
        Return dt
    End Function
End Class