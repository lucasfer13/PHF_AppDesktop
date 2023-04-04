Imports System.Collections.ObjectModel
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ConnectionBD
    Private connexio As MySqlConnection
    Public Function connect() As Boolean
        connexio = New MySqlConnection
        connexio.ConnectionString = Constantes.CONNECTION_STRING
        Try
            connexio.Open()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Sub close()
        If connexio.State = 1 Then
            Try
                connexio.Dispose()
            Catch ex As Exception
            End Try
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

    Public Function comand(query As String) As Boolean
        connect()
        Dim c As Boolean = False
        Dim command As New MySqlCommand(query, connexio)
        If command.ExecuteNonQuery > 0 Then
            c = True
        End If
        close()
        Return c
    End Function

    Public Function getServeis() As DataTable
        Return query(Constantes.QUERY_SERVEIS)
    End Function

    Public Function modifyServei(nom As String, desc As String, id As Integer) As Boolean
        Return comand(String.Format(Constantes.MODIFY_SERVEI, nom, desc, id))
    End Function

    Public Function deleteServei(id As Integer) As Boolean
        Return comand(String.Format(Constantes.DELETE_SERVEI, id))
    End Function

    Public Function addServei(nom As String, desc As String) As Boolean
        Return comand(String.Format(Constantes.INSERT_SERVEI, nom, desc))
    End Function

    Public Function addTAnimal(nom As String) As Boolean
        Return comand(String.Format(Constantes.INSERT_TANIMALS, nom))
    End Function

    Public Function modifyTAnimal(nom As String, id As Integer) As Boolean
        Return comand(String.Format(Constantes.MODIFY_TANIMALS, nom, id))
    End Function

    Public Function deleteTAnimal(id As Integer) As Boolean
        Return comand(String.Format(Constantes.DELETE_TANIMALS, id))
    End Function

    Public Function getTAnimal() As DataTable
        Return query(Constantes.QUERY_TANIMALS)
    End Function
End Class