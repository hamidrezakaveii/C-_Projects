using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCfServiceLibraryAgeMessage
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string MessageAnneChoisir(string machineName, string machinIP, string username, DateTime dateTime, DateTime anne)
        {
            String messagee = "";
            try
            {
                if (1970 >= anne.Year)
                {
                    messagee = "Il est temps d’aller se promener à travers le monde";
                }
                else if (1971 >= anne.Year && anne.Year <= 1980)
                {
                    messagee = "il est temps de commencer à travailler sérieusement";
                }
                else if (1981 >= anne.Year && anne.Year <= 1990)
                {
                    messagee = "Il est grand temps de terminer tes études";
                }
                else if (1991 >= anne.Year && anne.Year <= 2000)
                {
                    messagee = "Fais ce qui te plait, tu as encore le temps!";
                }
                else if (2001 >= anne.Year && anne.Year <= 2010)
                {
                    messagee = "utilisation de ce service non-autorisée !!!";
                }
                else
                {
                    messagee = "Pas de defini !!!";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            finally
            {
                
            }

            InseretDonnes(machineName, machinIP, username, dateTime, anne);
            

            return messagee;
        }

        private void InseretDonnes(string machineName, string machinIP, string username, DateTime dateTime, DateTime anne)
        {
            //insert
            using (SqlConnection connection =
              new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HAMIDREZA\\Documents\\LogServiceDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (SqlCommand command =
                    new SqlCommand("INSERT INTO ActivityLOG(machine_name, machine_ip, user_name, curr_date, birth_date) " +
                                   "VALUES('" + machineName + "', '" + machinIP + "', '" + username + "', '" + dateTime + "', '" + anne + "');", connection))
                {
                    try
                    {

                        command.ExecuteNonQuery();
                        command.CommandTimeout = 1000;
                        connection.Close();
                    }
                    catch (System.Data.SqlClient.SqlException sqlException)
                    {
                        Console.WriteLine(sqlException.Message);
                    }


                }
            }

        }
    }
}
