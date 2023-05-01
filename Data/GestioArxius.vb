Imports System.Data
Imports System.IO

Public Class GestioArxius
    Private Const RESOURCES = "Resources"
    Private Const PICTURES = "Resources/Pictures"
    Private Const TXT = "Resources/TXT"
    Private Const XML = "XMLS"
    Public Shared Sub addDefaultDirectoris()
        If Not Directory.Exists(RESOURCES) Then
            Directory.CreateDirectory(RESOURCES)
        End If
        If Not Directory.Exists(PICTURES) Then
            Directory.CreateDirectory(PICTURES)
        End If
        If Not Directory.Exists(TXT) Then
            Directory.CreateDirectory(TXT)
        End If
        If Not Directory.Exists(XML) Then
            Directory.CreateDirectory(XML)
        End If
    End Sub

    Public Shared Function copyFile(origen As String, destino As String, id As Integer) As String
        Dim nameFile As String = id & Path.GetExtension(origen)
        File.Copy(origen, destino & "/" & nameFile)
        Return nameFile
    End Function

    Public Shared Sub directoryExists(dir As String)
        If Not Directory.Exists(dir) Then
            Directory.CreateDirectory(dir)
        End If
    End Sub

    Public Shared Sub generateTXT(dt As DataTable, idGuarderia As Integer)
        Dim text As String
        text = idGuarderia & "#" & Now.ToString("yyyy-MM-dd hh:mm:ss") & "#" & dt.Rows.Count & vbCrLf
        For Each row As DataRow In dt.Rows
            text += row.Item(0) & "#" & row.Item(1) & vbCrLf
        Next
        File.WriteAllText(TXT & "/" & idGuarderia & ".txt", text)
    End Sub
End Class
