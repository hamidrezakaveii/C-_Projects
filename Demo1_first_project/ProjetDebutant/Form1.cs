using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_BasicProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectionImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Charger l image dans l`espace réservé
                pictureImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void quitterImage_Click(object sender, EventArgs e)
        {
            //quitter l application
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureImage_Click(object sender, EventArgs e)
        {

        }
    }
}
