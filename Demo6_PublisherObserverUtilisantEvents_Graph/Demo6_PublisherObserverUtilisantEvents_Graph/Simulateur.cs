using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo6_PublisherObserverUtilisantEvents_Graph
{
    public partial class Simulateur : Form
    {
        Publisher pub;
        int valeur;
        private static Simulateur simulateur;
        public Simulateur()
        {
            InitializeComponent();
            attacherListeners();
        }

        public static Simulateur getInstance()
        {
            if(simulateur == null)
            {
                simulateur = new Simulateur();
                return simulateur;
            }
            else
            {
                return simulateur;
            }
        }

        public void attacherListeners()
        {
            //creer le publisher
            pub = new Publisher();

            //creer le premier observateur
            Observer1 obs1 = new Observer1();

            //creer le deuxieme observateur
            Observer2 obs2 = new Observer2();

            //creer le troiseme observateur
            Observer3 obs3 = new Observer3();

            //attacher le premier observateur
            pub.ValeurTemperatureChange += new Publisher.MonDelegate(obs1.EcrireSurEcran);

            //attacher le deuxieme observateur
            pub.ValeurTemperatureChange += new Publisher.MonDelegate(obs2.EcrireSurEcran1);

            //attacher le troisime observateur
            pub.ValeurTemperatureChange += new Publisher.MonDelegate(obs3.EcrireSurJauge);

        }

        private void Simulateur_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pub.notifier(++valeur);
        }
    }
}
