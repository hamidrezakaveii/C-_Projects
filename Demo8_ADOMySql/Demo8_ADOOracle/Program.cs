using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace Demo8_ADOOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs =
                        "Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)" +
                        "(HOST = oracleadudb1.bdeb.qc.ca)(PORT = 1521))) (CONNECT_DATA = (SERVICE_NAME = GDNA10) ));" +
                  "User Id=UG235E29;Password=P342k8;";
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = cs;

            try
            {
                Console.WriteLine("Connection vers Oracle ...");
                connection.Open();

                //creer une requete 
                string query = "SELECT last_name, first_name from employees";

                //Preparer l'execution de la requete 
                OracleCommand sql = new OracleCommand();
                sql.Connection = connection;
                sql.CommandText = query;
                sql.CommandType = System.Data.CommandType.Text;

                //Recuperrer le cur
                OracleDataReader reader = sql.ExecuteReader();

                //Parcourir le curseur
                while (reader.Read())
                {
                    //afficher detail
                    string nom, prenom;
                    nom = (string)reader[0];
                    prenom = (string)reader[1];
                    Console.WriteLine("nom: {0} - prenom: {1}", nom, prenom);
                }


            }catch(Exception e){

                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
