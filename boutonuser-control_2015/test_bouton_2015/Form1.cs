using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_bouton_2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userBouton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton a été cliqué!");
        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            userBouton1.Musure = Convert.ToInt32(textBox1.Text);
        }

        private void userBouton1_Load(object sender, EventArgs e)
        {

        }
    }
}
