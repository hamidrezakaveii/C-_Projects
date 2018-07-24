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

        private void cversf_Click(object sender, EventArgs e)
        {
            
            textFar.Text = Utility.cversf(textCel.Text.Trim());
        }

        private void fversc_Click(object sender, EventArgs e)
        {
            
            textCel.Text = Utility.fversc(textFar.Text.Trim());

        }

        private void quite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
