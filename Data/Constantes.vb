Public Class Constantes
    ' Cadena de connexio
    Public Const CONNECTION_STRING = "server=localhost;userid=root;password='';database=phf"

    ' Comandes usuaris
    Public Const QUERY_USER = "SELECT * FROM usuaris 
                                    WHERE nomUsuari = '{0}' AND contrasenya = '{1}'"

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
End Class