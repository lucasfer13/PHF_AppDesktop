Public Class Constantes
    ' Cadena de connexio
    Public Const CONNECTION_STRING = "server=localhost;userid=root;password='';database=phf"

    ' Comandes usuaris
    Public Const QUERY_USER = "SELECT * FROM usuaris 
    WHERE nomUsuari = '{0}' AND contrasenya = '{1}'"
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
    Public Const QUERY_GUARDERIES = "SELECT * FROM guarderia"
    Public Const INSERT_SUPERVISOR_GUARDERIA = "INSERT INTO guarderiasupervisor (idGuarderia, idUsuari) VALUES ({0}, {1})"
    Public Const QUERY_GUARDERIES_SUPERVISOR = "SELECT g.idGuarderia, g.cif, g.nom, g.correu FROM guarderia g
    JOIN guarderiasupervisor gs ON gs.idGuarderia = g.idGuarderia
    JOIN usuaris u ON u.idUsuari = gs.idUsuari
    WHERE u.idUsuari = {0}"
End Class