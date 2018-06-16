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
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.textCel = new System.Windows.Forms.TextBox();
        this.textFar = new System.Windows.Forms.TextBox();
        this.cversf = new System.Windows.Forms.Button();
        this.fversc = new System.Windows.Forms.Button();
        this.quite = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(40, 34);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(92, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Temperature:(oC):";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(43, 84);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(88, 13);
        this.label2.TabIndex = 1;
        this.label2.Text = "Temperature(oF):";
        // 
        // textCel
        // 
        this.textCel.Location = new System.Drawing.Point(139, 34);
        this.textCel.Name = "textCel";
        this.textCel.Size = new System.Drawing.Size(170, 20);
        this.textCel.TabIndex = 2;
        // 
        // textFar
        // 
        this.textFar.Location = new System.Drawing.Point(139, 76);
        this.textFar.Name = "textFar";
        this.textFar.Size = new System.Drawing.Size(170, 20);
        this.textFar.TabIndex = 3;
        // 
        // cversf
        // 
        this.cversf.Location = new System.Drawing.Point(139, 196);
        this.cversf.Name = "cversf";
        this.cversf.Size = new System.Drawing.Size(75, 23);
        this.cversf.TabIndex = 4;
        this.cversf.Text = "oC vers oF";
        this.cversf.UseVisualStyleBackColor = true;
        this.cversf.Click += new System.EventHandler(this.cversf_Click);
        // 
        // fversc
        // 
        this.fversc.Location = new System.Drawing.Point(247, 196);
        this.fversc.Name = "fversc";
        this.fversc.Size = new System.Drawing.Size(75, 23);
        this.fversc.TabIndex = 5;
        this.fversc.Text = "oF vers oC";
        this.fversc.UseVisualStyleBackColor = true;
        this.fversc.Click += new System.EventHandler(this.fversc_Click);
        // 
        // quite
        // 
        this.quite.Location = new System.Drawing.Point(348, 196);
        this.quite.Name = "quite";
        this.quite.Size = new System.Drawing.Size(75, 23);
        this.quite.TabIndex = 6;
        this.quite.Text = "Quitter";
        this.quite.UseVisualStyleBackColor = true;
        this.quite.Click += new System.EventHandler(this.quite_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(463, 262);
        this.Controls.Add(this.quite);
        this.Controls.Add(this.fversc);
        this.Controls.Add(this.cversf);
        this.Controls.Add(this.textFar);
        this.Controls.Add(this.textCel);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textCel;
    private System.Windows.Forms.TextBox textFar;
    private System.Windows.Forms.Button cversf;
    private System.Windows.Forms.Button fversc;
    private System.Windows.Forms.Button quite;
}
}

