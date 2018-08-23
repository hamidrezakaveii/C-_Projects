using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Intra_Exam
{
    public partial class Form2 : Form
    {
        Form fr;
        public Form2()
        {

            InitializeComponent();
        }

        public Form2(string nom, string prenom, string courriel, double montant, double cotisation, double remboursement, Form fr)
        {
            InitializeComponent();
            //Initialiser les labels
            this.labelNom.Text = "Mr "+ nom + ",";
            this.labelPrenom.Text = prenom.ToString();
            this.labelCourriel.Text = courriel.ToString();
            this.labelMontant.Text = montant.ToString() + " $";
            this.labelCotisation.Text = cotisation.ToString() + " $";
            this.labelremboursemnt.Text = remboursement.ToString() + " $";
            this.fr = fr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vider tous les champs dans Form1
            foreach (var c in fr.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
            //Retour au Form1
            fr.Show();
            this.Close();
        }
    }
}
