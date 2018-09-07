using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppClient.ServiceReference1;

namespace WindowsFormsAppClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");

            DateTime dt = new DateTime();

            string msg = client.MessageAnneChoisir("", "", "", dt, 1980);
        }
    }
}
