using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo6_DetectionAffichageEvenementsSystemes
{
    public partial class Simulateur : Form
    {
        //On utilise la variable modeEcoute declarée comme bool afin de savoir dans quel mode est notre simulateur.
        private bool modeEcoute;
        public Simulateur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DemarreEcoute();
        }

        private void DemarreEcoute()
        {
            Microsoft.Win32.SystemEvents.DisplaySettingsChanged += new EventHandler(GererEcouteEcran);
            Microsoft.Win32.SystemEvents.TimeChanged += new EventHandler(GererEcouteHorloge);
            this.modeEcoute = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.ArreteEcoute();
        }


        private void ArreteEcoute()
        {
            Microsoft.Win32.SystemEvents.DisplaySettingsChanged -= new EventHandler(GererEcouteEcran);
            Microsoft.Win32.SystemEvents.TimeChanged -= new EventHandler(GererEcouteHorloge);
            this.modeEcoute = false;
        }

        private void GererEcouteEcran(object sender, EventArgs e)
        {
            textBox1.Text += string.Format("Changement de resolution d'écran. {0}", Environment.NewLine);
        }

        private void GererEcouteHorloge(object sender, EventArgs e)
        {
            textBox1.Text += string.Format("Horloge a changé. {0}", Environment.NewLine);
        }

    }
}
