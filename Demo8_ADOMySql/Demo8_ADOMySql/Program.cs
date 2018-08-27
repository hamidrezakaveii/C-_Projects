using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Demo8_ADOMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            //connection vers la BD northwinmysql
            //chaine de connection
            string cs = "server=localhost;user=root;" +
                "database=northwindmysql;port=3306;";
            //objet connexion
            MySqlConnection connection = new MySqlConnection(cs);

            try
            {
                
                Console.WriteLine("Connection sur MySql...");
                connection.Open();

                //creer une requete
                string query = "SELECT ContactName, CompanyName from customers";

                //Preparer L'execution de la requte
                MySqlCommand sql = new MySqlCommand(query, connection);

                //Recuperer le cursur
                MySqlDataReader reader = sql.ExecuteReader();

                //Parcourir le curseur
                while (reader.Read())
                {
                    //afficher detail
                    string nom, company;
                    nom = (string)reader[0];
                    company = (string)reader[1];
                    Console.WriteLine("nom: {0} - compagnie: {1}", nom, company);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
