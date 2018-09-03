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
    public partial class Bail : Form
    {
        MainForm mf;
        public Bail(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void bailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hamidBDDataSet);

        }

        private void Bail_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'hamidBDDataSet.paiement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.paiementTableAdapter.Fill(this.hamidBDDataSet.paiement);
            // TODO: cette ligne de code charge les données dans la table 'hamidBDDataSet.bail'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bailTableAdapter.Fill(this.hamidBDDataSet.bail);

        }

        private void Bail_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.Show();
        }
    }
}
