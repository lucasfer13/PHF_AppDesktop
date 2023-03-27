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

    Function generarSHA(pass As String) As String
        Dim algorithm As SHA256 = SHA256.Create
        Dim enc As New UTF8Encoding
        Dim hash As Byte() = (algorithm.ComputeHash(enc.GetBytes(pass)))
        Return System.Convert.ToBase64String(hash)
    End Function

End Class
