namespace Demo6_PublisherObserverUtilisantEvents_Graph
{
    partial class Simulateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output1 = new System.Windows.Forms.Label();
            this.output2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.jauge = new AquaControls.AquaGauge();
            this.SuspendLayout();
            // 
            // output1
            // 
            this.output1.AutoSize = true;
            this.output1.Location = new System.Drawing.Point(55, 31);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(37, 13);
            this.output1.TabIndex = 0;
            this.output1.Text = "Valeur";
            this.output1.Click += new System.EventHandler(this.label1_Click);
            // 
            // output2
            // 
            this.output2.AutoSize = true;
            this.output2.Location = new System.Drawing.Point(58, 84);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(37, 13);
            this.output2.TabIndex = 1;
            this.output2.Text = "Valeur";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Incrementer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jauge
            // 
            this.jauge.BackColor = System.Drawing.Color.Transparent;
            this.jauge.DialColor = System.Drawing.Color.Lavender;
            this.jauge.DialText = null;
            this.jauge.Glossiness = 11.36364F;
            this.jauge.Location = new System.Drawing.Point(58, 149);
            this.jauge.MaxValue = 100F;
            this.jauge.MinValue = 0F;
            this.jauge.Name = "jauge";
            this.jauge.RecommendedValue = 0F;
            this.jauge.Size = new System.Drawing.Size(150, 150);
            this.jauge.TabIndex = 3;
            this.jauge.ThresholdPercent = 0F;
            this.jauge.Value = 0F;
            // 
            // Simulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 323);
            this.Controls.Add(this.jauge);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Name = "Simulateur";
            this.Text = "Simulateur";
            this.Load += new System.EventHandler(this.Simulateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output1;
        private System.Windows.Forms.Label output2;
        private System.Windows.Forms.Button button1;
        internal AquaControls.AquaGauge jauge;

        //property pour afficher le changement vu par observer1
        public string TextObs1
        {
            get
            {
                return this.output1.Text;
            }
            set
            {
                this.output1.Text = value;
            }
        }

        //property pour afficher le changement vu par observere2
        public string TextObs2
        {
            get
            {
                return this.output2.Text;
            }
            set
            {
                this.output2.Text = value;
            }
        }
    }
}