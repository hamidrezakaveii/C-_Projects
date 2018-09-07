namespace WindowsFormsAppClient
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
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxResultat = new System.Windows.Forms.RichTextBox();
            this.textBoxDateNaissance = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.Location = new System.Drawing.Point(378, 19);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnvoyer.TabIndex = 0;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = true;
            this.buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date de Naissance:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTextBoxResultat
            // 
            this.richTextBoxResultat.Location = new System.Drawing.Point(134, 216);
            this.richTextBoxResultat.Name = "richTextBoxResultat";
            this.richTextBoxResultat.Size = new System.Drawing.Size(227, 34);
            this.richTextBoxResultat.TabIndex = 8;
            this.richTextBoxResultat.Text = "";
            this.richTextBoxResultat.TextChanged += new System.EventHandler(this.richTextBoxResultat_TextChanged);
            // 
            // textBoxDateNaissance
            // 
            this.textBoxDateNaissance.Location = new System.Drawing.Point(134, 21);
            this.textBoxDateNaissance.Name = "textBoxDateNaissance";
            this.textBoxDateNaissance.Size = new System.Drawing.Size(227, 20);
            this.textBoxDateNaissance.TabIndex = 5;
            this.textBoxDateNaissance.TextChanged += new System.EventHandler(this.textBoxAnne_TextChanged);
            this.textBoxDateNaissance.Enter += new System.EventHandler(this.textBoxAnne_Enter);
            this.textBoxDateNaissance.Leave += new System.EventHandler(this.textBoxDateNaissance_Leave);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(134, 42);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 301);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.richTextBoxResultat);
            this.Controls.Add(this.textBoxDateNaissance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEnvoyer);
            this.Name = "Form1";
            this.Text = "Affiche Activity";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnvoyer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxResultat;
        private System.Windows.Forms.TextBox textBoxDateNaissance;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

