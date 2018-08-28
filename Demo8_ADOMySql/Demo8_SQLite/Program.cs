using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MySql.Data.MySqlClient;


namespace Demo8_SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=G:\ADO\sqlite\sqlitenorthwind.s3db");

            try
            {
                Console.WriteLine("Connection sur SQLite...");
                connection.Open();

                //crrer une requete
                string query = "SELECT categoryID, description from categories";

                //preparer l'execution de la requete
                SQLiteCommand sql = new SQLiteCommand(query, connection);

                //Recuperer le curseur
                SQLiteDataReader reader = sql.ExecuteReader();

                //Parcourir le curseur
                while (reader.Read())
                {
                    //afficher detail
                    string description;
                    int id;
                    id = Convert.ToInt32(reader[0]);
                    description = (string)reader[1];
                    Console.WriteLine("categorie: {0} - Description: {1}", id, description);
                }

  



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
