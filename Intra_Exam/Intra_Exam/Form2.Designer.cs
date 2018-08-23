namespace Intra_Exam
{
    partial class Form2
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelCourriel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelCotisation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelremboursemnt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(30, 23);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(24, 13);
            this.labelNom.TabIndex = 0;
            //this.labelNom.Text = "test";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(113, 23);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(30, 13);
            this.labelPrenom.TabIndex = 1;
            //this.labelPrenom.Text = "test2";
            // 
            // labelCourriel
            // 
            this.labelCourriel.AutoSize = true;
            this.labelCourriel.Location = new System.Drawing.Point(33, 59);
            this.labelCourriel.Name = "labelCourriel";
            this.labelCourriel.Size = new System.Drawing.Size(0, 13);
            this.labelCourriel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Merci d\'avoir rempli votre déclaration fiscale.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(29, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Voici les montants qui vous concerent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Montant déclare:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cotisation déclaree:";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(137, 183);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(0, 13);
            this.labelMontant.TabIndex = 7;
            // 
            // labelCotisation
            // 
            this.labelCotisation.AutoSize = true;
            this.labelCotisation.Location = new System.Drawing.Point(143, 218);
            this.labelCotisation.Name = "labelCotisation";
            this.labelCotisation.Size = new System.Drawing.Size(0, 13);
            this.labelCotisation.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(36, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "remboursement auquel vous avez droit: ";
            // 
            // labelremboursemnt
            // 
            this.labelremboursemnt.AutoSize = true;
            this.labelremboursemnt.Location = new System.Drawing.Point(338, 252);
            this.labelremboursemnt.Name = "labelremboursemnt";
            this.labelremboursemnt.Size = new System.Drawing.Size(0, 13);
            this.labelremboursemnt.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelremboursemnt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCotisation);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCourriel);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelCourriel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelCotisation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelremboursemnt;
        private System.Windows.Forms.Button button1;
    }
}