using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo8_MySql_Graphic2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);
            MessageBox.Show("Updated");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'northwndDataSet.Categories'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categoriesTableAdapter.Fill(this.northwndDataSet.Categories);
            //Charger l image dans l`espace réservé
            //pictureImage.Image = Image.FromFile(openFileDialog.FileName);
            //pictureBox1.Image = ;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
