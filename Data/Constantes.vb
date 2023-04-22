Public Class Constantes
    ' Cadena de connexio
    Public Const CONNECTION_STRING_LOCAL = "server=localhost;userid=root;password='';database=phf"
    Public Const CONNECTION_STRING_REMOTO_INS = "server=192.168.1.150,server=webapps.insjoanbrudieu.cat;port=25230;username=pethotel;pwd='ElLuAlBe???!19876';database=pethotelDB"
    Public Const CONNECTION_STRING_REMOTO = "server=webapps.insjoanbrudieu.cat;port=25230;userid=pethotel;password=ElLuAlBe???!19876;database=pethotelDB"

    ' Varis
    Public Const DATE_MYSQL = "yyyy-MM-dd"

    ' Comandes usuaris
    Public Const QUERY_USER = "SELECT * FROM usuaris 
    WHERE nomUsuari = '{0}' AND contrasenya = '{1}' AND actiu = 1"
    Public Const QUERY_USERS = "SELECT * FROM usuaris WHERE actiu = 1"
    Public Const QUERY_SPECIFIC_USER = "SELECT * FROM usuaris WHERE nomUsuari = '{0}'"
    Public Const MODIFY_USER = "UPDATE usuaris 
    SET DocumentIdentitat = '{0}', nom = '{1}', cognom1  = '{2}', cognom2 = '{3}', NomUsuari = '{4}', Telefon = '{5}', Correu = '{6}'
    WHERE idUsuari = {7}"
    Public Const INSERT_USER = "INSERT INTO usuaris (DocumentIdentitat, nom, cognom1, cognom2, NomUsuari, Contrasenya, Telefon, Correu, actiu)
    VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', 'True')"
    Public Const DELETE_USER = "UPDATE usuaris SET actiu = 'False' WHERE idUsuari = {0}"
    Public Const MODIFY_USER_PASSWORD = "UPDATE usuaris
    SET Contrasenya = '{0}'
    WHERE idUsuari = {1}"

    ' Comandes serveis
    Public Const QUERY_SERVEIS = "SELECT * FROM serveis"
    Public Const INSERT_SERVEI = "INSERT INTO serveis (nom, descripcio) VALUES ('{0}', '{1}')"
    Public Const DELETE_SERVEI = "DELETE FROM serveis WHERE idServei = {0}"
    Public Const MODIFY_SERVEI = "UPDATE serveis SET nom = '{0}', descripcio = '{1}' WHERE idServei = {2}"

    ' Comandes tipus animals
    Public Const QUERY_TANIMALS = "SELECT * FROM tipusanimal"
    Public Const INSERT_TANIMALS = "INSERT INTO tipusanimal (nom) VALUES ('{0}')"
    Public Const DELETE_TANIMALS = "DELETE FROM tipusanimal WHERE idTipusAnimal = {0}"
    Public Const MODIFY_TANIMALS = "UPDATE tipusanimal SET nom = '{0}' WHERE idTipusAnimal = {1}"

    ' Comandes guarderies
    Public Const QUERY_GUARDERIES = "SELECT g.idGuarderia, g.cif, g.nom, g.descripcio, g.correu, g.telefon, g.idCP, g.carrer, g.porta, c.nom as Municipi, cp.cp as CP, p.nom as Pais, g.avRating FROM guarderia g 
    JOIN codipostal cp ON cp.idCP = g.idCP
    JOIN ciutat c ON cp.idCiutat = c.idCiutat
    JOIN pais p ON p.idPais = c.idPais
    WHERE g.actiu = 1"
    Public Const INSERT_SUPERVISOR_GUARDERIA = "INSERT INTO usuariguarderia (idGuarderia, idUsuari) VALUES ({0}, {1})"
    Public Const QUERY_GUARDERIES_SUPERVISOR = "SELECT g.idGuarderia, g.cif, g.nom, g.descripcio, g.correu, g.telefon, g.idCP, g.carrer, g.porta, c.nom as Municipi, cp.cp as CP, p.nom as Pais, g.avRating FROM guarderia g
    JOIN usuariguarderia gs ON gs.idGuarderia = g.idGuarderia
    JOIN usuaris u ON u.idUsuari = gs.idUsuari
    JOIN codipostal cp ON cp.idCP = g.idCP
    JOIN ciutat c ON cp.idCiutat = c.idCiutat
    JOIN pais p ON p.idPais = c.idPais
    WHERE u.idUsuari = {0} AND actiu=1"
    Public Const INSERT_GUARDERIA = "INSERT INTO guarderia (cif, nom, descripcio, correu, telefon, idCP, carrer, Porta, actiu, avgRating)
    VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', 1, 0)"
    Public Const MODIFY_GUARDERIA = "UPDATE guarderia SET cif = '{0}', nom = '{1}',descripcio = '{2}', correu = '{3}', telefon = '{4}', idCP = {5}, carrer = '{6}', porta = '{7}'
    WHERE idGuarderia = {8}"
    Public Const DELETE_GUARDERIA = "UPDATE guarderia SET actiu = 0 WHERE idGuarderia = {0}"

    ' Comandes Guarderies-Serveis
    Public Const QUERY_GUARDERIES_SERVEIS = "SELECT s.idServei, s.nom, s.descripcio FROM serveis s
    JOIN serveisguarderia gs ON gs.idServei = s.idServei
    JOIN guarderia g ON g.idGuarderia = gs.idGuarderia
    WHERE g.idGuarderia = {0}"
    Public Const DELETE_GUARDERIES_SERVEIS = "DELETE FROM serveisguarderia WHERE idGuarderia={0} AND idServei={1}"
    Public Const INSERT_GUARDERIES_SERVEIS = "INSERT INTO serveisguarderia (idGuarderia, idServei) VALUES ({0}, {1})"

    ' Comandes vacances
    Public Const QUERY_GUARDERIES_VACANCES = "SELECT v.idVacances, v.dataInici, v.dataFi FROM vacances v
    JOIN guarderia g ON g.idGuarderia = v.idGuarderia
    WHERE g.idGuarderia = {0}"
    Public Const DELETE_VACANCES = "DELETE FROM vacances WHERE idVacances = {0}"
    Public Const INSERT_VACANCES = "INSERT INTO vacances (idGuarderia, dataInici, dataFi)
    VALUES ({0}, '{1}', '{2}')"

    ' Querys direccions
    Public Const QUERY_DIRECCIO = "SELECT cp.cp, c.Nom, p.Nom FROM codipostal cp
    JOIN ciutat c ON cp.idCiutat = c.idCiutat
    JOIN pais p ON p.idPais = c.idPais
    WHERE cp.idCP = {0} AND p.idPais = {1}"
    Public Const QUERY_PAIS = "SELECT * FROM pais"
    Public Const QUERY_CP_CIUTAT = "SELECT cp.idCP, c.Nom, cp.cp FROM codipostal cp
    JOIN ciutat c ON c.idCiutat = cp.idCiutat
    JOIN pais p ON p.idPais = c.idPais
    WHERE p.idPais = {0}"
    Public Const QUERY_DIRECCIO_BY_CP = "SELECT cp.idCP, p.idPais, cp.cp, c.Nom, p.Nom FROM codipostal cp
    JOIN ciutat c ON cp.idCiutat = c.idCiutat
    JOIN pais p ON p.idPais = c.idPais
    WHERE cp.idCP = {0}"

    ' QUERYS CAMERES
    Public Const QUERY_CAMERES = "SELECT * FROM cameres WHERE idGuarderia = {0}"
    Public Const INSERT_CAMERA = "INSERT INTO cameres (idGuarderia, url, usuari, contrasenya, descripcio) 
    VALUES ({0},'{1}','{2}','{3}','{4}')"
    Public Const MODIFY_CAMERA = "UPDATE cameres SET url = '{0}', usuari = '{1}', contrasenya = '{2}', descripcio = '{3}' WHERE idCamara = {4}"
    Public Const DELETE_CAMERE = "DELETE FROM cameres WHERE idCamara = {0}"
End Class