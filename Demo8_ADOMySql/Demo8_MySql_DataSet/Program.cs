using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Demo8_MySql_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //connection vers la BD northwindmysql
            //chain de connexion
            string cs = "server= localhost; user=root; database=northwindmysql; port=3306;";

            //objet connection
            MySqlConnection connection = new MySqlConnection(cs);

            //objet DataSet
            DataSet ds = new DataSet();
            try
            {
                Console.WriteLine("Manipulation sur MySQL...");

                //Creer une requete avec adapter
                string query = "SELECT CategoryName, Description, Picture from categories";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);

                //Preparer l'execution de la requete 
                MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(da);

                //creer une table categories dans le DataSet
                da.Fill(ds, "CategoriesDS");

                //Manipuler le dataset
                //Code pour ajouter un enregistrement dans la table
                //CategorieDS dans le dataset "ds" --
                Console.WriteLine("Manipulation de la table du dataset...");

                DataRow myRow = ds.Tables["CategoriesDS"].NewRow();
                //myRow["CategoryID"] = "11";
                myRow["CategoryName"] = "Machinima";
                myRow["Description"] = "Etude cinma 3D";
                myRow["Picture"] = "Machine.jpg";

                //ajouter l'enregistrement a la table dans le dataset
                ds.Tables["CategoriesDS"].Rows.Add(myRow);

                //verifier que le code au niveu de DataSet marche bien
                Console.WriteLine("Verification Du dataset...");
                foreach (DataColumn column in ds.Tables["CategoriesDS"].Columns)
                    Console.WriteLine("{0}", column.Caption);
                foreach(DataTable maTable in ds.Tables)
                {
                    foreach(DataRow enreg in maTable.Rows)
                    {
                        foreach (DataColumn myColumn in maTable.Columns)
                            Console.WriteLine(enreg[myColumn]);
                    }
                }
                //Mettre a jour la source
                Console.WriteLine("Mise a jour de la source a partir du dataset....");
                da.Update(ds, "CategoriesDS");


            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }



        }
    }
}
