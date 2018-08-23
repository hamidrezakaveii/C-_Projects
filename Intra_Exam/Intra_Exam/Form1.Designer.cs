namespace Intra_Exam
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
            this.labelPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelCotisation = new System.Windows.Forms.Label();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxCourriel = new System.Windows.Forms.TextBox();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.textBoxCotisation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(38, 54);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(32, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom:";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(38, 95);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(46, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prenom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Courriel:";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(38, 172);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(75, 13);
            this.labelMontant.TabIndex = 3;
            this.labelMontant.Text = "Montant paye:";
            // 
            // labelCotisation
            // 
            this.labelCotisation.AutoSize = true;
            this.labelCotisation.Location = new System.Drawing.Point(38, 208);
            this.labelCotisation.Name = "labelCotisation";
            this.labelCotisation.Size = new System.Drawing.Size(56, 13);
            this.labelCotisation.TabIndex = 4;
            this.labelCotisation.Text = "Cotisation:";
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.Location = new System.Drawing.Point(41, 250);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnvoyer.TabIndex = 5;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = true;
            this.buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(134, 54);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(148, 20);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(134, 88);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(148, 20);
            this.textBoxPrenom.TabIndex = 7;
            // 
            // textBoxCourriel
            // 
            this.textBoxCourriel.Location = new System.Drawing.Point(134, 130);
            this.textBoxCourriel.Name = "textBoxCourriel";
            this.textBoxCourriel.Size = new System.Drawing.Size(148, 20);
            this.textBoxCourriel.TabIndex = 8;
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(134, 165);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(148, 20);
            this.textBoxMontant.TabIndex = 9;
            // 
            // textBoxCotisation
            // 
            this.textBoxCotisation.Location = new System.Drawing.Point(134, 201);
            this.textBoxCotisation.Name = "textBoxCotisation";
            this.textBoxCotisation.Size = new System.Drawing.Size(148, 20);
            this.textBoxCotisation.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Saisir votre demande de remboursement";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCotisation);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.textBoxCourriel);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonEnvoyer);
            this.Controls.Add(this.labelCotisation);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demande remboursement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelCotisation;
        private System.Windows.Forms.Button buttonEnvoyer;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxCourriel;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.TextBox textBoxCotisation;
        private System.Windows.Forms.Label label2;
    }
}

