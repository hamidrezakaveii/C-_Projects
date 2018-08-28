using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo8_ADOOracle_Graphic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'northwndDataSet.Products'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            // TODO: cette ligne de code charge les données dans la table 'northwndDataSet.Suppliers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.suppliersTableAdapter.Fill(this.northwndDataSet.Suppliers);

        }
    }
}
