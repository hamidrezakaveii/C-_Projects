namespace Demo_BasicProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SelectionImage = new System.Windows.Forms.Button();
            this.quitterImage = new System.Windows.Forms.Button();
            this.pictureImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionImage
            // 
            this.SelectionImage.Location = new System.Drawing.Point(325, 237);
            this.SelectionImage.Name = "SelectionImage";
            this.SelectionImage.Size = new System.Drawing.Size(75, 23);
            this.SelectionImage.TabIndex = 0;
            this.SelectionImage.Text = "Selection";
            this.SelectionImage.UseVisualStyleBackColor = true;
            this.SelectionImage.Click += new System.EventHandler(this.SelectionImage_Click);
            // 
            // quitterImage
            // 
            this.quitterImage.Location = new System.Drawing.Point(216, 237);
            this.quitterImage.Name = "quitterImage";
            this.quitterImage.Size = new System.Drawing.Size(75, 23);
            this.quitterImage.TabIndex = 1;
            this.quitterImage.Text = "Quitter";
            this.quitterImage.UseVisualStyleBackColor = true;
            this.quitterImage.Click += new System.EventHandler(this.quitterImage_Click);
            // 
            // pictureImage
            // 
            this.pictureImage.Location = new System.Drawing.Point(12, 12);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Size = new System.Drawing.Size(420, 200);
            this.pictureImage.TabIndex = 2;
            this.pictureImage.TabStop = false;
            this.pictureImage.Click += new System.EventHandler(this.pictureImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Windows Bitmaps|*.BMP|JPEG Files|*.JPG|TIFF Files|*.TIFF|PNG Files|*.PNG";
            this.openFileDialog.Title = "Sélectionner une image";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.pictureImage);
            this.Controls.Add(this.quitterImage);
            this.Controls.Add(this.SelectionImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Affichage Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectionImage;
        private System.Windows.Forms.Button quitterImage;
        private System.Windows.Forms.PictureBox pictureImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

