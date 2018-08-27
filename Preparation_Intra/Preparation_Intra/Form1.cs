using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intra_Preparation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttoncalculer_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            double taille;
            int masse = 0;
            int age = 0;

            
            if (!(double.TryParse(textBoxTaille.Text.Trim(), out taille)) || !(int.TryParse(textBoxMasse.Text.Trim(), out masse)) || !(int.TryParse(textBoxAge.Text.Trim(), out age)) || nom.Trim().Equals(""))
            {
                MessageBox.Show("Error de saisi ou les champ vide, essayer encor s.v.p");
            }

            string strSexe = "";
            int sexe = 0;
            bool isChecked = radioButtonFemme.Checked;
            if (isChecked)
                strSexe = radioButtonFemme.Text;
            else
                strSexe = radioButtonHomme.Text;

            if (strSexe.Equals("Homme"))
                sexe = 1;

            //Invoke the methode
            double img = Util.CalculerIndice(taille, masse, age, sexe);
            textBoxIndice.Text = img.ToString();

            string interpretation = Util.TrouverInterpretation(img, sexe);
            textBoxInterpretation.Text = interpretation;


            

        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = "";
            textBoxTaille.Text = "";
            textBoxMasse.Text = "";
            textBoxAge.Text = "";
            textBoxIndice.Text = "";
            textBoxInterpretation.Text = "";
            radioButtonHomme.Checked = true;

        }
    }
}
