namespace Intra_Preparation
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNom = new System.Windows.Forms.Label();
            this.labelTaille = new System.Windows.Forms.Label();
            this.labelMasse = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxTaille = new System.Windows.Forms.TextBox();
            this.textBoxMasse = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.radioButtonFemme = new System.Windows.Forms.RadioButton();
            this.radioButtonHomme = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelIndice = new System.Windows.Forms.Label();
            this.labelInterpretation = new System.Windows.Forms.Label();
            this.textBoxIndice = new System.Windows.Forms.TextBox();
            this.textBoxInterpretation = new System.Windows.Forms.TextBox();
            this.buttoncalculer = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(23, 19);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(32, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom:";
            // 
            // labelTaille
            // 
            this.labelTaille.AutoSize = true;
            this.labelTaille.Location = new System.Drawing.Point(23, 62);
            this.labelTaille.Name = "labelTaille";
            this.labelTaille.Size = new System.Drawing.Size(64, 13);
            this.labelTaille.TabIndex = 1;
            this.labelTaille.Text = "Taille(en m):";
            // 
            // labelMasse
            // 
            this.labelMasse.AutoSize = true;
            this.labelMasse.Location = new System.Drawing.Point(26, 114);
            this.labelMasse.Name = "labelMasse";
            this.labelMasse.Size = new System.Drawing.Size(78, 13);
            this.labelMasse.TabIndex = 2;
            this.labelMasse.Text = "Masse (en Kg):";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(26, 157);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age";
            this.labelAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Location = new System.Drawing.Point(237, 157);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(34, 13);
            this.labelSexe.TabIndex = 4;
            this.labelSexe.Text = "Sexe:";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(110, 19);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxTaille
            // 
            this.textBoxTaille.Location = new System.Drawing.Point(110, 62);
            this.textBoxTaille.Name = "textBoxTaille";
            this.textBoxTaille.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaille.TabIndex = 6;
            // 
            // textBoxMasse
            // 
            this.textBoxMasse.Location = new System.Drawing.Point(111, 114);
            this.textBoxMasse.Name = "textBoxMasse";
            this.textBoxMasse.Size = new System.Drawing.Size(100, 20);
            this.textBoxMasse.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(111, 157);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 8;
            // 
            // radioButtonFemme
            // 
            this.radioButtonFemme.AutoSize = true;
            this.radioButtonFemme.Checked = true;
            this.radioButtonFemme.Location = new System.Drawing.Point(294, 160);
            this.radioButtonFemme.Name = "radioButtonFemme";
            this.radioButtonFemme.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemme.TabIndex = 9;
            this.radioButtonFemme.TabStop = true;
            this.radioButtonFemme.Text = "Femme";
            this.radioButtonFemme.UseVisualStyleBackColor = true;
            // 
            // radioButtonHomme
            // 
            this.radioButtonHomme.AutoSize = true;
            this.radioButtonHomme.Location = new System.Drawing.Point(359, 160);
            this.radioButtonHomme.Name = "radioButtonHomme";
            this.radioButtonHomme.Size = new System.Drawing.Size(61, 17);
            this.radioButtonHomme.TabIndex = 10;
            this.radioButtonHomme.TabStop = true;
            this.radioButtonHomme.Text = "Homme";
            this.radioButtonHomme.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Controls.Add(this.radioButtonHomme);
            this.groupBox1.Controls.Add(this.labelNom);
            this.groupBox1.Controls.Add(this.radioButtonFemme);
            this.groupBox1.Controls.Add(this.labelTaille);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Controls.Add(this.labelMasse);
            this.groupBox1.Controls.Add(this.textBoxMasse);
            this.groupBox1.Controls.Add(this.labelAge);
            this.groupBox1.Controls.Add(this.textBoxTaille);
            this.groupBox1.Controls.Add(this.labelSexe);
            this.groupBox1.Location = new System.Drawing.Point(41, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 199);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inforamtion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxInterpretation);
            this.groupBox2.Controls.Add(this.textBoxIndice);
            this.groupBox2.Controls.Add(this.labelInterpretation);
            this.groupBox2.Controls.Add(this.labelIndice);
            this.groupBox2.Location = new System.Drawing.Point(41, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 113);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultat";
            // 
            // labelIndice
            // 
            this.labelIndice.AutoSize = true;
            this.labelIndice.Location = new System.Drawing.Point(26, 34);
            this.labelIndice.Name = "labelIndice";
            this.labelIndice.Size = new System.Drawing.Size(124, 13);
            this.labelIndice.TabIndex = 0;
            this.labelIndice.Text = "Indice de Masse Grasse:";
            // 
            // labelInterpretation
            // 
            this.labelInterpretation.AutoSize = true;
            this.labelInterpretation.Location = new System.Drawing.Point(26, 71);
            this.labelInterpretation.Name = "labelInterpretation";
            this.labelInterpretation.Size = new System.Drawing.Size(69, 13);
            this.labelInterpretation.TabIndex = 1;
            this.labelInterpretation.Text = "Interpretation";
            // 
            // textBoxIndice
            // 
            this.textBoxIndice.Enabled = false;
            this.textBoxIndice.Location = new System.Drawing.Point(157, 34);
            this.textBoxIndice.Name = "textBoxIndice";
            this.textBoxIndice.Size = new System.Drawing.Size(163, 20);
            this.textBoxIndice.TabIndex = 2;
            // 
            // textBoxInterpretation
            // 
            this.textBoxInterpretation.Enabled = false;
            this.textBoxInterpretation.Location = new System.Drawing.Point(157, 71);
            this.textBoxInterpretation.Name = "textBoxInterpretation";
            this.textBoxInterpretation.Size = new System.Drawing.Size(163, 20);
            this.textBoxInterpretation.TabIndex = 3;
            // 
            // buttoncalculer
            // 
            this.buttoncalculer.Location = new System.Drawing.Point(420, 385);
            this.buttoncalculer.Name = "buttoncalculer";
            this.buttoncalculer.Size = new System.Drawing.Size(75, 23);
            this.buttoncalculer.TabIndex = 13;
            this.buttoncalculer.Text = "Calculer";
            this.buttoncalculer.UseVisualStyleBackColor = true;
            this.buttoncalculer.Click += new System.EventHandler(this.buttoncalculer_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(304, 385);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 14;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(70, 385);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 15;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 439);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttoncalculer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculer de l\'indice de masse grasse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelTaille;
        private System.Windows.Forms.Label labelMasse;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxTaille;
        private System.Windows.Forms.TextBox textBoxMasse;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.RadioButton radioButtonFemme;
        private System.Windows.Forms.RadioButton radioButtonHomme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxInterpretation;
        private System.Windows.Forms.TextBox textBoxIndice;
        private System.Windows.Forms.Label labelInterpretation;
        private System.Windows.Forms.Label labelIndice;
        private System.Windows.Forms.Button buttoncalculer;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.Button buttonQuitter;
    }
}

