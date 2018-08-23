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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            //Definition des variable
            bool compNom = false;
            bool compPrenom = false;
            bool compCourriel = false;
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string courriel = textBoxCourriel.Text;
            double montant = 0;
            double cotisation = 0;
            double remboursement = 0;

            //Validation champ nom
            if (nom.Trim().Equals(""))
            {
                MessageBox.Show("Le champ nom est vide!");
            }
            else
            {
                compNom = true;
            }
            
            //Validation champ prenom
            if (prenom.Trim().Equals(""))
            {
                MessageBox.Show("Le champ prenom est vide!");
            }
            else
            {
                compPrenom = true;
            }

            //Validation champ courriel
            if (courriel.Trim().Equals(""))
            {
                MessageBox.Show("Le champ courriel est vide!");
            }
            else
            {
                compCourriel = true;
            }

            //Validation champ montant
            if (!(double.TryParse(textBoxMontant.Text.Trim(), out montant)))
            {
                MessageBox.Show("Error de saisi pour le montant ou le champ est vide, essayer encore s.v.p");
            }

            //Validation champ cotisation
            if (!(double.TryParse(textBoxCotisation.Text.Trim(), out cotisation)))
            {
                MessageBox.Show("Error de saisi pour le cotisation ou le champ est vide, essayer encore s.v.p");
            }


            //Verifier les champs et initialiser Form2 
            if(compNom && compPrenom && compCourriel && montant!=0 && cotisation!=0)
            {
                remboursement = util.Remboursement(montant, cotisation);
                Form2 info = new Form2(nom, prenom, courriel, montant, cotisation, remboursement, this);
                info.Show();
                this.Hide();

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
