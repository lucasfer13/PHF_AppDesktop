Imports System.Collections.ObjectModel
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ConnectionBD
    Private connexio As MySqlConnection
    Public Function connect() As Boolean
        connexio = New MySqlConnection
        connexio.ConnectionString = Constantes.CONNECTION_STRING_REMOTO_INS
        Try
            connexio.ConnectionString = Constantes.CONNECTION_STRING_REMOTO
            connexio.Open()
        Catch ex As Exception
            Try
                connexio.ConnectionString = Constantes.CONNECTION_STRING_REMOTO
                connexio.Open()
            Catch e As Exception
                connexio.ConnectionString = Constantes.CONNECTION_STRING_LOCAL
                connexio.Open()
            End Try
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
        Try
            If command.ExecuteNonQuery > 0 Then
                c = True
            End If
        Catch ex As Exception
        End Try
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

    Public Function modifyUser(di As String, nom As String, cognom1 As String, cognom2 As String, nomUsuari As String, telefon As String, correu As String, idUsuari As Integer) As Boolean
        Return comand(String.Format(Constantes.MODIFY_USER, di, nom, cognom1, cognom2, nomUsuari, telefon, correu, idUsuari))
    End Function

    Public Function deleteUser(id As Integer) As Boolean
        Return comand(String.Format(Constantes.DELETE_USER, id))
    End Function

    Public Function addUser(di As String, nom As String, cognom1 As String, cognom2 As String, nomusuari As String, pass As String, tel As String, correu As String)
        Return comand(String.Format(Constantes.INSERT_USER, di, nom, cognom1, cognom1, nomusuari, Usuari.generarSHA(pass), tel, correu))
    End Function

    Public Function getUsers() As DataTable
        Return query(Constantes.QUERY_USERS)
    End Function

    Public Function getGuarderies() As DataTable
        Return query(Constantes.QUERY_GUARDERIES)
    End Function

    Public Sub relacionarUsuarisGuarderies(user As DataRow, guarderies As DataTable)
        For Each row As DataRow In guarderies.Rows
            comand(String.Format(Constantes.INSERT_SUPERVISOR_GUARDERIA, row.Item(0), user(0)))
        Next
    End Sub

    Public Sub relacionarUsuarisGuarderies(idUser As Integer, idGuarderia As Integer)
        comand(String.Format(Constantes.INSERT_SUPERVISOR_GUARDERIA, idGuarderia, idUser))
    End Sub

    Public Function guarderiesGestionadesUsuari(id As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_GUARDERIES_SUPERVISOR, id))
    End Function

    Public Function insertGuarderia(cif As String, nom As String, desc As String, correu As String, telefon As String, idPC As Integer, carrer As String, porta As String) As Boolean
        Return comand(String.Format(Constantes.INSERT_GUARDERIA, cif, nom, desc, correu, telefon, idPC, carrer, porta))
    End Function

    Public Function modifyGuarderia(cif As String, nom As String, desc As String, correu As String, telefon As String, idPC As Integer, carrer As String, porta As String, idGuarderia As Integer) As Boolean
        Return comand(String.Format(Constantes.MODIFY_GUARDERIA, cif, nom, desc, correu, telefon, idPC, carrer, porta, idGuarderia))
    End Function

    Public Function deleteGuarderia(idGuarderia As Integer) As Boolean
        Return comand(String.Format(Constantes.DELETE_GUARDERIA, idGuarderia))
    End Function

    Public Function getGuarderiaServeis(idGuarderia As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_GUARDERIES_SERVEIS, idGuarderia))
    End Function

    Public Function addGuarderiaServei(idGuarderia As Integer, idServei As Integer)
        Return comand(String.Format(Constantes.INSERT_GUARDERIES_SERVEIS, idGuarderia, idServei))
    End Function

    Public Function deleteGuarderiaServei(idGuarderia As Integer, idServei As Integer)
        Return comand(String.Format(Constantes.DELETE_GUARDERIES_SERVEIS, idGuarderia, idServei))
    End Function

    Public Function getGuarderiaVacances(idGuarderia As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_GUARDERIES_VACANCES, idGuarderia))
    End Function

    Public Function createVacances(idGuarderia As Integer, dataInici As Date, dataFi As Date) As Boolean
        Return comand(String.Format(Constantes.INSERT_VACANCES, idGuarderia, dataInici.ToString(Constantes.DATE_MYSQL), dataFi.ToString(Constantes.DATE_MYSQL)))
    End Function

    Public Function deleteVacances(idVacances As Integer) As Boolean
        Return comand(String.Format(Constantes.DELETE_VACANCES, idVacances))
    End Function

    Public Function getPaisos() As DataTable
        Return query(Constantes.QUERY_PAIS)
    End Function

    Public Function getMunicipis(idPais As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_CP_CIUTAT, idPais))
    End Function

    Public Function getDireccio(idCP As Integer, idPais As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_DIRECCIO, idCP, idPais))
    End Function

    Public Function getDireccioByCP(idCP As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_DIRECCIO_BY_CP, idCP))
    End Function

    Public Function getCameres(idGuarderia As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_CAMERES, idGuarderia))
    End Function

    Public Function insertCamera(idGuarderia As Integer, url As String, usuari As String, contrasenya As String, desc As String) As Boolean
        Return comand(String.Format(Constantes.INSERT_CAMERA, idGuarderia, url, usuari, contrasenya, desc))
    End Function

    Public Function modifyCamera(url As String, usuari As String, contrasenya As String, desc As String, idCamera As Integer) As Boolean
        Return comand(String.Format(Constantes.MODIFY_CAMERA, url, usuari, contrasenya, desc, idCamera))
    End Function

    Public Function deleteCamera(idCamera As Integer) As Boolean
        Return comand(String.Format(Constantes.DELETE_CAMERE, idCamera))
    End Function

    Public Function queryTipusHabitacio(idGuarderia As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_TIPUS_HABITACIO, idGuarderia))
    End Function

    Public Function insertTipusHabitacio(idGuarderia As Integer, nom As String, descripcio As String, preu As Double) As Boolean
        Return comand(String.Format(Constantes.INSERT_TIPUS_HABITACIO, idGuarderia, nom, descripcio, preu))
    End Function

    Public Function updateTipusHabitacio(nom As String, descripcio As String, preu As Boolean, idTipusHabitacio As Integer) As Boolean
        Return comand(String.Format(Constantes.MODIFY_TIPUS_HABITACIO, nom, descripcio, preu, idTipusHabitacio))
    End Function

    Public Function deleteTipusHabitacio(idTipusHabitacio As Integer) As Boolean
        Return comand(String.Format(Constantes.DELETE_TIPUS_HABITACIO, idTipusHabitacio))
    End Function

    Public Function queryTanimalThabtiacio(idTipusHabitacio As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_TIPUSH_TANIMAL, idTipusHabitacio))
    End Function

    Public Function insertTanimalThabitacio(idTipusHabitacio As Integer, idTipusAnimal As Integer) As Boolean
        Return comand(String.Format(Constantes.INSERT_TIPUSH_TANIMAL, idTipusHabitacio, idTipusAnimal))
    End Function

    Public Function deleteTanimalThabitacio(idTipusHabitacio As Integer, idTipusAnimal As Integer) As Boolean
        Return comand(String.Format(Constantes.DELETE_TIPUSH_TANIMAL, idTipusHabitacio, idTipusAnimal))
    End Function

    Public Function delteUserGuarderia(idUsuari As Integer, idGuarderia As Integer) As Boolean
        Return comand(String.Format(Constantes.DELETE_SUPERVISOR_GUARDERIA, idUsuari, idGuarderia))
    End Function

    Public Function getValoracions(idGuarderia As Integer) As DataTable
        Return query(String.Format(Constantes.QUERY_VALORACIONS, idGuarderia))
    End Function
End Class