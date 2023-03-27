Public Class Constantes
    Public Const CONNECTION_STRING = "server=localhost;userid=root;password='';database=phf"
    Public Const QUERY_USER = "SELECT * FROM usuaris 
                                    WHERE nomUsuari = '{0}' AND contrasenya = '{1}'"
End Class