using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MyGauge
{
    public partial class MyGauge : UserControl
    {
        private int _mesure = 0;
        private int _valeur_Min = 0;
        private int _valeur_Max = 100;
        private int _nbr_division = 5;



        [Browsable(true), DefaultValue("0"), Description("measure"), DisplayName("measure"), Category("Properties")]
        public int Musure
        {
            get { return _mesure; }
            set
            {
                _mesure = value;
                if(value < Valeur_Min) { _mesure = Valeur_Min; }
                else
                {
                    if(value > Valeur_Max) { _mesure = Valeur_Max; }
                    else { _mesure = value; }
                }

                Invalidate();
            }
        }
        [Browsable(true), DefaultValue("0"), Description("Min Value"), DisplayName("Min Value"), Category("Properties")]
        public int Valeur_Min
        {
            get { return _valeur_Min; }
            set
            {
                _valeur_Min = value;

                Invalidate();
            }
        }


        [Browsable(true), DefaultValue("0"), Description("Max Value"), DisplayName("Max Value"), Category("Properties")]
        public int Valeur_Max
        {
            get { return _valeur_Max; }
            set
            {
                _valeur_Max = value;

                Invalidate();
            }
        }

        [Browsable(true), DefaultValue("5"), Description("Division number"), DisplayName("Division number"), Category("Properties")]
        public int Nombre_Division
        {
            get { return this._nbr_division; }
            set {
                this._nbr_division = value;
                Invalidate();
            }
            
        }


        protected override void OnPaint(PaintEventArgs e)
        {


            //Properties definition

            Graphics graphics = e.Graphics;

            int rec1x = 0;
            int rec1y = 0;
            int rec1w = this.Width;
            int rec1h = this.Height;

            int rec2x = (int)(this.Width * 0.05);
            int rec2y = (int)(this.Height * 0.05);
            int rec2w = (int)(this.Width - 2 * (this.Width * 0.05));
            int rec2h = (int)(this.Height - 2 * (this.Height * 0.05));


            int rec3x = (int)(this.Width * 0.10);
            int rec3y = (int)(this.Height * 0.40);
            int rec3w = (int)(this.Width - 2 * (this.Width * 0.10));
            int rec3h = (int)(this.Height - 2 * (this.Height * 0.40));


            // Create rectangles

            SolidBrush rec1Brush = new SolidBrush(Color.Gray);
            Pen rec1Pen = new Pen(Color.Black, 5);   
            Rectangle rect1 = new Rectangle(rec1x, rec1y, rec1w, rec1h);
            e.Graphics.DrawRectangle(rec1Pen, rect1);

            SolidBrush rec2Brush = new SolidBrush(Color.Beige);
            Pen rec2Pen = new Pen(Color.Black, 3);
            Rectangle rect2 = new Rectangle(rec2x, rec2y, rec2w, rec2h);
            e.Graphics.DrawRectangle(rec2Pen, rect2);

            SolidBrush rec3Brush = new SolidBrush(Color.White);
            Pen rec3Pen = new Pen(Color.Black, 3);
            graphics.FillRectangle(rec3Brush, rec3x, rec3y, rec3w, rec3h);


            //Draw the lines

            int barValue = Valeur_Min;
            int pas = rec3w / Nombre_Division;
            SolidBrush barBrush = new SolidBrush(Color.Gray);
            Pen lignePen = new Pen(Color.Black, 5);
            Font strFont = new Font("Arial", 10);

            for (int i = 0; i<=Nombre_Division ; i++)
            {
                graphics.DrawString(barValue.ToString(), strFont, barBrush, rec3x + (i * pas), (rec3y - 30));
                graphics.DrawLine(lignePen, rec3x + (i * pas), (rec3y - 10), rec3x + (i * pas), (rec3y + rec3h + 10));

                barValue += Valeur_Max / Nombre_Division;

            }

            // Draw the bar

            SolidBrush musureBrush = new SolidBrush(Color.Red);
            for (int i=0; i < ((Musure - Valeur_Min) * rec3w) / (Valeur_Max - Valeur_Min); i++)
            {
            graphics.FillRectangle(musureBrush, rec3x, (rec1h - 30) / 2, i , 30);

                
                Thread.Sleep(50);
            }


        }
        public MyGauge()
        {
            InitializeComponent();
        }
    }
}
