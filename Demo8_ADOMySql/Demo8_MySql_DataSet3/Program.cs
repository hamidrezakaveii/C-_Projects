using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Demo8_MySql_DataSet3
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

                //objet Dataset
                DataSet ds = new DataSet();

                //ajout de la deuxieme table Dept
                DataTable deptDS = new DataTable();

                //ajouter la table au DataSet
                ds.Tables.Add(deptDS);

                //ajouter des colonnes a la table
                DataColumn cdeptID = new DataColumn("deptID", typeof(int));
                DataColumn cdeptNom = new DataColumn("deptNom", typeof(string));
                deptDS.Columns.Add(cdeptID);
                deptDS.Columns.Add(cdeptNom);

                //ajouter une contrainte de cle primaire
                deptDS.Constraints.Add("dept_PK", cdeptID, true);
                cdeptID.AutoIncrement = true;
                cdeptID.AutoIncrementSeed = 10; //code demarre de 10 

                //ajoute d'un enregistrement
                DataRow deptRow = deptDS.NewRow();
                deptRow["deptNom"] = "Commercial";
                deptDS.Rows.Add(deptRow);
                //2iem enregistremen
                DataRow deptRow2 = deptDS.NewRow();
                deptRow2["deptNom"] = "Technique";
                deptDS.Rows.Add(deptRow2);

                //afficher le contenu de la table deptDS
                DataRow[] ligneDept = deptDS.Select();

                //afficher le resultat de la requete
                Console.WriteLine("===================================");
                Console.WriteLine("Liste des departements dans le systeme");
                Console.WriteLine("===================================");
                if (ligneDept != null)
                {
                    for (int i = 0; i < ligneDept.Length; i++)
                    {
                        int index;
                        string titre;
                        index = (int)ligneDept[i]["deptID"];
                        titre = (string)ligneDept[i]["deptNom"];
                        Console.WriteLine("Code: {0}, nom:{1}", index, titre);

                    }
                }

                //ajout d'une table employe
                DataTable empDS = new DataTable("EMP");

                //ajouter la table au DataSet
                ds.Tables.Add(empDS);

                //ajouter des colonnes a la table
                DataColumn cempID = new DataColumn("empID", typeof(int));
                DataColumn cnom = new DataColumn("nom", typeof(string));
                DataColumn cprenom = new DataColumn("prenom", typeof(string));
                DataColumn cage = new DataColumn("age", typeof(int));
                DataColumn cdeptempID = new DataColumn("deptID", typeof(int)); //le code dept auquel appatient emp
                empDS.Columns.Add(cempID);
                empDS.Columns.Add(cnom);
                empDS.Columns.Add(cprenom);
                empDS.Columns.Add(cage);
                empDS.Columns.Add(cdeptempID);

                //ajote de cle unique
                empDS.Constraints.Add("un_nom", empDS.Columns["nom"], false);
                //ajoute de cle primaire
                empDS.Constraints.Add("pk_empDs", empDS.Columns["empID"], true);

                //indiquer que c'est une colonne auto_incrementee
                cempID.AutoIncrement = true;
                cempID.AutoIncrementSeed = 100;

                //ajoute de dataRelation entre la table empDS et DeptDS
                DataRelation empDept = new DataRelation("emp_dept_rel", deptDS.Columns["deptID"], empDS.Columns["deptID"], true);
                ds.Relations.Add(empDept);

                //ajouter des enregistrement dans la table
                //1ere ligne
                DataRow dr1 = empDS.NewRow();
                //dr1["empID"] = 100;
                dr1["nom"] = "Kinslet";
                dr1["prenom"] = "wate";
                dr1["age"] = 23;
                dr1["deptID"] = deptRow2["deptID"]; //le mettre dans Technique

                empDS.Rows.Add(dr1);

                //2eme ligne
                DataRow dr2 = empDS.NewRow();
                //dr2["empID"] = 101;
                dr2["nom"] = "FlouFlou";
                dr2["prenom"] = "Alain";
                dr2["age"] = 35;
                dr2["deptID"] = deptRow["deptID"]; //le mettre dans Commercial

                empDS.Rows.Add(dr2);

                //afficher en mode Maitre-Detail
                //lister les employe de chaque dept
                for (int i = 0; i < deptDS.Rows.Count; i++)
                {
                    Console.WriteLine("----Departement code:{0}, nom:{1}-----", deptDS.Rows[i]["deptID"], deptDS.Rows[i]["deptNom"]);
                    //relation utilise pour cette structure maire-detal
                    DataRow[] empRow = deptDS.Rows[i].GetChildRows("emp_dept_rel");
                    //lister les enfants maintenent
                    foreach (DataRow drow in empRow)
                    {
                        int index, age, codeDept;
                        string nom, prenom;
                        index = (int)drow["empID"];
                        age = (int)drow["age"];
                        nom = (string)drow["nom"];
                        prenom = (string)drow["prenom"];
                        codeDept = (int)drow["deptID"];
                        Console.WriteLine("Code: {0}, nom:{1}, prenom{2}, age:{3}, dept:{4}", index, nom, prenom, age, codeDept);

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
