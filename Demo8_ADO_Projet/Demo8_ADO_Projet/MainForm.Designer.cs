namespace Demo8_ADO_Projet
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locataireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bailToolStripMenuItem,
            this.locataireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bailToolStripMenuItem
            // 
            this.bailToolStripMenuItem.Name = "bailToolStripMenuItem";
            this.bailToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.bailToolStripMenuItem.Text = "Bail";
            this.bailToolStripMenuItem.Click += new System.EventHandler(this.bailToolStripMenuItem_Click);
            // 
            // locataireToolStripMenuItem
            // 
            this.locataireToolStripMenuItem.Name = "locataireToolStripMenuItem";
            this.locataireToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.locataireToolStripMenuItem.Text = "Locataire";
            this.locataireToolStripMenuItem.Click += new System.EventHandler(this.locataireToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locataireToolStripMenuItem;
    }
}