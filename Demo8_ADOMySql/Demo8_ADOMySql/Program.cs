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
            MySqlConnection connection = null;
            MySqlDataReader reader = null;

            try
            {
                
                Console.WriteLine("Connection sur MySql...");
                connection = new MySqlConnection(cs);
                connection.Open();

                ////creer une requete
                //string query = "SELECT ContactName, CompanyName from customers";

                ////Preparer L'execution de la requte
                //MySqlCommand sql = new MySqlCommand(query, connection);

                ////Recuperer le cursur
                // reader = sql.ExecuteReader();

                ////Parcourir le curseur
                //while (reader.Read())
                //{
                //    //afficher detail
                //    string nom, company;
                //    nom = (string)reader[0];
                //    company = (string)reader[1];
                //    Console.WriteLine("nom: {0} - compagnie: {1}", nom, company);
                //}

                //insert 
                //string queryinsert = "INSERT INTO categories(CategoryName, Description, Picture) values ('sport', 'Tous les articles de sport', 'sport.gif')";
                //MySqlCommand sql2 = new MySqlCommand(queryinsert, connection);
                //sql2.ExecuteNonQuery();

                //update
                //string queryupdate = "UPDATE categories set Description ='Tous les articles de sport 2019' WHERE CategoryName='sport'";
                //MySqlCommand sql3 = new MySqlCommand(queryupdate, connection);
                //sql3.ExecuteNonQuery();

                //delete
                //string querydelete = "DELETE FROM categories WHERE CategoryName='sport'";
                //MySqlCommand sql4 = new MySqlCommand(querydelete, connection);
                //sql4.ExecuteNonQuery();

                //Opérations d’agrégation
                //string querymax = "SELECT max(UnitPrice) from products";
                //MySqlCommand sql5 = new MySqlCommand(querymax, connection);
                //double max = (double)sql5.ExecuteScalar();
                //Console.WriteLine(max);

                //Opérations d’agrégation
                //string querymin = "SELECT min(UnitPrice) from products";
                //MySqlCommand sql6 = new MySqlCommand(querymin, connection);
                //double min = (double)sql6.ExecuteScalar();
                //Console.WriteLine(min);

                //
                //creer une requete
                string reqSelect = "select ProductName, UnitPrice from products where ProductName like @nomproduit  AND UnitPrice > @prix";

                //Demander a l'utilisateur la valeur
                Console.Write("Saisir le nom du produit: ");
                string nomprd = Console.ReadLine();
                Console.Write("Saisir le prix min produit: ");
                double userprix = Double.Parse(Console.ReadLine());

                //Definir le parametre utilisé dans l'objet Command
                MySqlParameter parametre = new MySqlParameter();
                parametre.ParameterName = "@nomproduit";
                parametre.Value = "%" + nomprd + "%";

                MySqlParameter parametre2 = new MySqlParameter();
                parametre2.ParameterName = "@prix";
                parametre2.Value = userprix;

                //Definir l'objet command
                MySqlCommand sql = new MySqlCommand(reqSelect, connection);

                //Ajouter le parametre l'objet Command
                sql.Parameters.Add(parametre);
                sql.Parameters.Add(parametre2);

                //Executer la commande
                reader = sql.ExecuteReader();

                //Afficher les enregistrements
                while (reader.Read())
                {
                    string nom = (string)reader[0];
                    double prix = Convert.ToDouble(reader[1]);
                    Console.WriteLine("nom produit:{0} - prix: {1:f}", nom, prix);
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
