using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo6c_Manipulation_Gauge_control
{
    class Dassboardview : UserControl
    {
        public Dassboardview()
        {
            InitializeComponent();
        }

        //center 
        private int centerX = 0;
        private int centerY = 0;
        private int dX = 0;
        private int dY = 0;

        //Attributs

        private int sy = 0;
        private int sx = 100;
        private float val1 = 0;
        private int nombreDivision = 5;

        private Color c = Color.Aqua;
        private Color ctexte = Color.Black;
        private int taille = 16;

        [Category("Configuration"), Browsable(true), Description("Maxvalue")]
        public int MaxValue
        {
            get
            {
                return this.sx;
            }
            set
            {
                this.sx = value;
                this.Refresh();
            }
        }

        [Category("Configuration"), Browsable(true), Description("Minvalue")]
        public int MinValue
        {
            get
            {
                return this.sy;
            }
            set
            {
                if (value < 0)
                    this.sy = 0;
                else
                    this.sy = 0;

                this.Refresh();
            }
        }
    }
}
