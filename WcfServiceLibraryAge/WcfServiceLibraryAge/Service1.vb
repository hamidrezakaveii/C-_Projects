' REMARQUE : vous pouvez utiliser la commande Renommer du menu contextuel pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
Imports System.ServiceModel.Channels
Imports WcfServiceLibraryAge

Public Class Service1
    Implements IService1



    Public Function MessageAnneChoisir(dateDeNaissance As Integer) As String Implements IService1.MessageAnneChoisir
        String Message = "";
            Try
            {

                If (1970 < dateDeNaissance) Then
                                {
                    messagee = "Il est temps d’aller se promener à travers le monde";

                }
                ElseIf (1971 <= dateDeNaissance && dateDeNaissance >= 1980) Then
                                {
                    messagee = "il est temps de commencer à travailler sérieusement";
                }
                ElseIf (1981 <= dateDeNaissance && dateDeNaissance >= 1990) Then
                                {
                    messagee = "Il est grand temps de terminer tes études";
                }
                ElseIf (1991 <= dateDeNaissance && dateDeNaissance >= 2000) Then
                                {
                    messagee = "Fais ce qui te plait, tu as encore le temps!";
                }
                ElseIf (2001 <= dateDeNaissance && dateDeNaissance >= 2010) Then
                                {
                    messagee = "utilisation de ce service non-autorisée !!!";
                }

            }catch(Exception ex)
            {
                //WebServiceDataBase wsgr = New WebServiceDataBase();

            }
            Finally
            {
                
            }

        Return Messagee;
    End Function
End Class
