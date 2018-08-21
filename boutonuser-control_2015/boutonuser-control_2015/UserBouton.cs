using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace boutonuser_control_2015
{
    public partial class UserBouton : UserControl
    {
        private int _mesure = 0;
        private int _valeur_Min = 0;
        private int _valeur_Max = 100;
        


        [Browsable(true), DefaultValue("0"), Description("represente la mesure ou la valeur a afficher"), DisplayName("Musure"), Category("Propriétés")]
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
        [Browsable(true), DefaultValue("0"), Description("represente la valeur min de la mesure"),
    DisplayName("Valeur Min"), Category("Propriétés")]
        public int Valeur_Min
        {
            get { return _valeur_Min; }
            set
            {
                _valeur_Min = value;

                Invalidate();
            }
        }


        [Browsable(true), DefaultValue("0"), Description("represente la valeur max de la mesure"),
    DisplayName("Valeur Max"), Category("Propriétés")]
        public int Valeur_Max
        {
            get { return _valeur_Max; }
            set
            {
                _valeur_Max = value;

                Invalidate();
            }
        }

        public Color backgroundColor = Color.Red;
        //etape 2
        private string _labelBouton = "Click click";
        [Browsable(true), DefaultValue("Click click")]
        public string LabelBouton
        {
            get { return _labelBouton; }
            set { _labelBouton = value; Invalidate(); }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            //ref: http://www.windowsdevcenter.com/pub/a/dotnet/2002/03/18/customcontrols.html?page=2
            Graphics graphics = e.Graphics;

            //int penWidth = 4;
            //Pen pen = new Pen(Color.Black, 4);

            //int fontHeight = 10;
            //Font font = new Font("Arial", fontHeight);


            //SolidBrush brush = new SolidBrush(backgroundColor);
            //graphics.FillEllipse(brush, 0, 0, Width, Height);
            //SolidBrush textBrush = new SolidBrush(Color.Black);

            //graphics.DrawEllipse(pen, (int)penWidth / 2,
            //(int)penWidth / 2, Width - penWidth, Height - penWidth);

            //graphics.DrawString(LabelBouton, font, textBrush, Width / 2 - fontHeight,
            //Height / 2 - fontHeight);



            //SolidBrush brushValeur = new SolidBrush(Color.Red);

            //graphics.FillRectangle(brushValeur, 0,
            //((int) Height - 10) / 2, Musure, penWidth);

            // Create pen

            //int fontHeight = 10;
            //Font font = new Font("Arial", fontHeight);

            //Les properietés
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
            //graphics.FillRectangle(rec1Brush, rec1x, rec1y, rec1w, rec1h);
            Rectangle rect1 = new Rectangle(rec1x, rec1y, rec1w, rec1h);
            e.Graphics.DrawRectangle(rec1Pen, rect1);

            SolidBrush rec2Brush = new SolidBrush(Color.Beige);
            Pen rec2Pen = new Pen(Color.Black, 3);
            //graphics.FillRectangle(rec2Brush, rec2x, rec2y, rec2w, rec2h);
            Rectangle rect2 = new Rectangle(rec2x, rec2y, rec2w, rec2h);
            e.Graphics.DrawRectangle(rec2Pen, rect2);

            SolidBrush rec3Brush = new SolidBrush(Color.White);
            Pen rec3Pen = new Pen(Color.Black, 3);
            graphics.FillRectangle(rec3Brush, rec3x, rec3y, rec3w, rec3h);
            //Rectangle rect3 = new Rectangle(rec2x, rec2y, rec2w, rec2h);
            //e.Graphics.DrawRectangle(rec2Pen, rect2);

            //Draw lines
            int pas = ((int)(this.Width * 0.05)) / 5;  //nbDiv
            Pen blackPen2 = new Pen(Color.Black, 5);
            for(int i = 0; i<5; i++)
            {
                //graphics.DrawLine(blackPen2, rec2x, rec2y, rec2x, (int)(this.Height - 2 * (this.Height * 0.25)));

            }

            // Draw le bar
            SolidBrush musureBrush = new SolidBrush(Color.Red);
            for (int i=0; i<Musure; i++)
            {
                graphics.FillRectangle(musureBrush, rec3x, (rec1h - 30) / 2, i, 30);
                //graphics.FillRectangle()
                
                Thread.Sleep(100);
            }


        }
        public UserBouton()
        {
            InitializeComponent();
        }
    }
}
