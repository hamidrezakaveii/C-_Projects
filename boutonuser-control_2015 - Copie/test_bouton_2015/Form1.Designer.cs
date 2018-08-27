namespace test_bouton_2015
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
            this.Afficher = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userBouton1 = new boutonuser_control_2015.UserBouton();
            this.SuspendLayout();
            // 
            // Afficher
            // 
            this.Afficher.Location = new System.Drawing.Point(306, 278);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(75, 23);
            this.Afficher.TabIndex = 1;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // userBouton1
            // 
            this.userBouton1.Location = new System.Drawing.Point(93, 52);
            this.userBouton1.Musure = 0;
            this.userBouton1.Name = "userBouton1";
            this.userBouton1.Size = new System.Drawing.Size(381, 206);
            this.userBouton1.TabIndex = 3;
            this.userBouton1.Valeur_Max = 100;
            this.userBouton1.Valeur_Min = 0;
            this.userBouton1.Load += new System.EventHandler(this.userBouton1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 344);
            this.Controls.Add(this.userBouton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Afficher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Afficher;
        private System.Windows.Forms.TextBox textBox1;
        private boutonuser_control_2015.UserBouton userBouton1;
    }
}

