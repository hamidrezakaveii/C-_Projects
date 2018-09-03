using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo8_ADO_Projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'hamidBDDataSet.Locataires'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.locatairesTableAdapter.Fill(this.hamidBDDataSet.Locataires);

        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
            textBoxNumContract.Text = "";
            textBoxNomPrenom.Text = "";
            comboBoxStatut.SelectedIndex = 0;
            foreach (Control c in panel1.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
                if(c is ComboBox)
                {
                    c.TabIndex = 0;
                }
            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if(textBoxCode.Text == "")
            {
                MessageBox.Show("Vous devez saisir un code de locataire.", "Gestion de locataire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(textBoxNomPrenom.Text == "")
            {
                MessageBox.Show("Vous devez specifier le nom et prenom du locataire.", "Gestion de locataire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //insert
            using (SqlConnection connection =
                new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\1795545\\Documents\\HamidBD.mdf;Integrated Security=True;Connect Timeout=30")){

                SqlCommand command =
                    new SqlCommand("INSERT INTO Locataires(locataireCode, nomprenom, statutmariage, numerocontact) " +
                                   "VALUES('" + textBoxCode.Text + "', '" +
                                   textBoxNomPrenom.Text + "', '" + comboBoxStatut.Text + "', '" + textBoxNumContract.Text + "');", connection);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Un nouveau locataire a été ajouté.","Gestion de locataires", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonEffacer_Click(sender, e);
                Form1_Load(sender, e);



            }

        }

        private void comboBoxStatut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
