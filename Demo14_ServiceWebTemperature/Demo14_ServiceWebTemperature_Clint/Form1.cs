using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo14_ServiceWebTemperature_Clint.ServiceReferenceTemp;

namespace Demo14_ServiceWebTemperature_Clint
{
    
    public partial class Form1 : Form
    {
        WebServiceTempSoapClient proxy;
       
        public Form1(WebServiceTempSoapClient proxy)
        {
            this.proxy = proxy;
            InitializeComponent();
        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            double val;
            double res;
            Double.TryParse(textBoxInsert.Text, out val);

            res = proxy.CalculerTemperarure("Cel", val , out string  msg);
            textBoxResult.Text = res.ToString();
            textBoxMessage.Text = msg;
            
        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            double val;
            double res;
            Double.TryParse(textBoxInsert.Text, out val);

            res = proxy.CalculerTemperarure("Far", val, out string msg);
            textBoxResult.Text = res.ToString();
            textBoxMessage.Text = msg;
        }
    }
}
