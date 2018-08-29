using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Demo8_MySql_DataSet2
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

            try
            {
                //creetion d'une table
                DataTable empDS;
                empDS = new DataTable("EMP");

                //objet Dataset
                DataSet ds = new DataSet();

                //rattacher la table empDS au dataset
                ds.Tables.Add(empDS);

                //ajouter des colonnes a la table
                DataColumn cempID = new DataColumn("empID", typeof(int));
                DataColumn cnom = new DataColumn("nom", typeof(string));
                DataColumn cprenom = new DataColumn("prenom", typeof(string));
                DataColumn cage = new DataColumn("age", typeof(int));

                empDS.Columns.Add(cempID);
                empDS.Columns.Add(cnom);
                empDS.Columns.Add(cprenom);
                empDS.Columns.Add(cage);

                //ajouter des enregistrement dans la table 
                //1ere ligne
                DataRow dr1 = empDS.NewRow();
                dr1["empID"] = 100;
                dr1["nom"] = "Kinslet";
                dr1["prenom"] = "Wate";
                dr1["age"] = 23;

                empDS.Rows.Add(dr1);

                //2ere ligne
                DataRow dr2 = empDS.NewRow();
                dr2["empID"] = 101;
                dr2["nom"] = "FlouFlou";
                dr2["prenom"] = "Alain";
                dr2["age"] = 35;

                empDS.Rows.Add(dr2);

                //effecteur une operation select sur empDS
                string where = "nom like 'Flou%'";
                DataRow[] lignes = empDS.Select(where);

                if (lignes != null)
                {
                    for (int i = 0; i < lignes.Length; i++)
                    {
                        int index, age;
                        string nom, prenom;
                        index = (int)lignes[i]["empID"];
                        age = (int)lignes[i]["age"];
                        nom = (string)lignes[i]["nom"];
                        prenom = (string)lignes[i]["prenom"];
                        Console.WriteLine("Code: {0}, nom:{1}, prenom{2}, age:{3}", index, nom, prenom, age);

                    }
                }

                //ajoute de cle unique
                empDS.Constraints.Add("un_nom", empDS.Columns["nom"], false);

                //Verification que la cle est bien en fonction
                //3ere ligne
                DataRow dr3 = empDS.NewRow();
                dr1["empId"] = 102;
                dr1["nom"] = "FlouClair";
                dr1["prenom"] = "Abdel";
                dr1["age"] = 45;

                //empDS.Rows.Add(dr3);

                //ajoute de cle primaire
                empDS.Constraints.Add("ok_empDS", empDS.Columns["empID"], true);

                //indiquer que c'est une colonne auto_incrementee
                cempID.AutoIncrement = true;
                cempID.AutoIncrementSeed = 103;

                //ajoute de nouvelle ligne
                DataRow dr4 = empDS.NewRow();
                //dr4["empID"] = 103;
                dr4["nom"] = "ClaireFlou";
                dr4["prenom"] = "Tango";
                dr4["age"] = 125;

                empDS.Rows.Add(dr4);

                //Liste le contenu de la table
                //string where = "nom like 'Flou%'"
                DataRow[] lignes2 = empDS.Select();

                //afficher le resultat de la requte
                if (lignes2 != null)
                {
                    for (int i = 0; i < lignes2.Length; i++)
                    {
                        int index, age;
                        string nom, prenom;
                        index = (int)lignes2[i]["empID"];
                        age = (int)lignes2[i]["age"];
                        nom = (string)lignes2[i]["nom"];
                        prenom = (string)lignes2[i]["prenom"];
                        Console.WriteLine("Code: {0}, nom:{1}, prenom{2}, age:{3}", index, nom, prenom, age);

                    }
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
