﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Visible = false;
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            richTextBoxResultat.Text = "";
            
            //Get the user infos
            string machineName = Environment.MachineName;
            string machineIP = Dns.GetHostAddresses(machineName)[0].ToString();
            //string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            string username = Environment.UserName;

            //Access to service
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");

            //Get the user date
            DateTime dtNaissance = DateTime.Parse(textBoxDateNaissance.Text);

            //Get current date
            DateTime dtCurrent = DateTime.Now;

            //Invoke the sevice method
            string msg = client.MessageAnneChoisir(machineName, machineIP, username, dtCurrent, dtNaissance);

            //Set the message to rich text box
            richTextBoxResultat.Text += msg ;

            Console.WriteLine(dtCurrent);
            Console.WriteLine(dtNaissance);


        }





        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void textBoxAnne_TextChanged(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void textBoxAnne_Enter(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
         
            textBoxDateNaissance.Text = monthCalendar1.SelectionStart.ToShortDateString();
            
            monthCalendar1.Visible = false;
            //var monthCalendar = sender as MonthCalendar;
        }

        private void textBoxDateNaissance_Leave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void richTextBoxResultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void textBoxDateNaissance_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }
    }
}
