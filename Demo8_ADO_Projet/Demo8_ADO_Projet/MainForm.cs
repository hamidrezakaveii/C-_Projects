using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo8_ADO_Projet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bail bail = new Bail(this);
            this.Visible = false;
            bail.Show();
            
        }

        private void locataireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Locataire locataire = new Locataire(this);
            this.Visible = false;
            locataire.Show();
        }
    }
}
