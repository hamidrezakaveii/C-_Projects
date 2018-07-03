namespace App_1
{
    partial class Form_delegate
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
            this.btn_recherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_recherche = new System.Windows.Forms.ComboBox();
            this.tb_resultat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(386, 28);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(75, 23);
            this.btn_recherche.TabIndex = 0;
            this.btn_recherche.Text = "Executer";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher";
            // 
            // cb_recherche
            // 
            this.cb_recherche.FormattingEnabled = true;
            this.cb_recherche.Location = new System.Drawing.Point(105, 29);
            this.cb_recherche.Name = "cb_recherche";
            this.cb_recherche.Size = new System.Drawing.Size(265, 21);
            this.cb_recherche.TabIndex = 2;
            // 
            // tb_resultat
            // 
            this.tb_resultat.Location = new System.Drawing.Point(105, 96);
            this.tb_resultat.MinimumSize = new System.Drawing.Size(200, 150);
            this.tb_resultat.Name = "tb_resultat";
            this.tb_resultat.Size = new System.Drawing.Size(265, 150);
            this.tb_resultat.TabIndex = 3;
            this.tb_resultat.TextChanged += new System.EventHandler(this.tb_resultat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultat";
            // 
            // Form_delegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_resultat);
            this.Controls.Add(this.cb_recherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_recherche);
            this.Name = "Form_delegate";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_recherche;
        private System.Windows.Forms.TextBox tb_resultat;
        private System.Windows.Forms.Label label2;
    }
}

