Imports System.Text
Imports System.Security.Cryptography
Imports System.Data

Public Class Usuari
    Public Function getUser(user As String, pass As String) As DataTable
        Dim sql As New ConnectionBD
        Dim dt As DataTable
        dt = sql.query(String.Format(Constantes.QUERY_USER, user, generarSHA(pass)))
        Return dt
    End Function

    Public Shared Function generarSHA(pass As String) As String
        Dim algorithm As SHA256 = SHA256.Create
        Dim enc As New UTF8Encoding
        Dim hash As Byte() = (algorithm.ComputeHash(enc.GetBytes(pass)))
        Return System.Convert.ToBase64String(hash)
    End Function

    Public Function modifyPassword(pass As String, id As Integer) As Boolean
        Dim sql As New ConnectionBD
        Return sql.comand(String.Format(Constantes.MODIFY_USER_PASSWORD, generarSHA(pass), id))
    End Function

    Public Function getUser(userName As String) As DataRow
        Dim sql As New ConnectionBD
        Return sql.query(String.Format(Constantes.QUERY_SPECIFIC_USER, userName)).Rows(0)
    End Function

End Class
