namespace Demo8_ADO_Projet
{
    partial class Locataire
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hamidBDDataSet = new Demo8_ADO_Projet.HamidBDDataSet();
            this.locatairesTableAdapter = new Demo8_ADO_Projet.HamidBDDataSetTableAdapters.LocatairesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.locataireIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locataireCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomprenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutmariageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatairesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.textBoxNumContract = new System.Windows.Forms.TextBox();
            this.textBoxNomPrenom = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamidBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatairesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Locataires";
            this.bindingSource1.DataSource = this.hamidBDDataSet;
            // 
            // hamidBDDataSet
            // 
            this.hamidBDDataSet.DataSetName = "HamidBDDataSet";
            this.hamidBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatairesTableAdapter
            // 
            this.locatairesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locataireIDDataGridViewTextBoxColumn,
            this.locataireCodeDataGridViewTextBoxColumn,
            this.nomprenomDataGridViewTextBoxColumn,
            this.statutmariageDataGridViewTextBoxColumn,
            this.numerocontactDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.locatairesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // locataireIDDataGridViewTextBoxColumn
            // 
            this.locataireIDDataGridViewTextBoxColumn.DataPropertyName = "locataireID";
            this.locataireIDDataGridViewTextBoxColumn.HeaderText = "locataireID";
            this.locataireIDDataGridViewTextBoxColumn.Name = "locataireIDDataGridViewTextBoxColumn";
            this.locataireIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locataireCodeDataGridViewTextBoxColumn
            // 
            this.locataireCodeDataGridViewTextBoxColumn.DataPropertyName = "locataireCode";
            this.locataireCodeDataGridViewTextBoxColumn.HeaderText = "locataireCode";
            this.locataireCodeDataGridViewTextBoxColumn.Name = "locataireCodeDataGridViewTextBoxColumn";
            // 
            // nomprenomDataGridViewTextBoxColumn
            // 
            this.nomprenomDataGridViewTextBoxColumn.DataPropertyName = "Nomprenom";
            this.nomprenomDataGridViewTextBoxColumn.HeaderText = "Nomprenom";
            this.nomprenomDataGridViewTextBoxColumn.Name = "nomprenomDataGridViewTextBoxColumn";
            // 
            // statutmariageDataGridViewTextBoxColumn
            // 
            this.statutmariageDataGridViewTextBoxColumn.DataPropertyName = "Statutmariage";
            this.statutmariageDataGridViewTextBoxColumn.HeaderText = "Statutmariage";
            this.statutmariageDataGridViewTextBoxColumn.Name = "statutmariageDataGridViewTextBoxColumn";
            // 
            // numerocontactDataGridViewTextBoxColumn
            // 
            this.numerocontactDataGridViewTextBoxColumn.DataPropertyName = "numerocontact";
            this.numerocontactDataGridViewTextBoxColumn.HeaderText = "numerocontact";
            this.numerocontactDataGridViewTextBoxColumn.Name = "numerocontactDataGridViewTextBoxColumn";
            // 
            // locatairesBindingSource
            // 
            this.locatairesBindingSource.DataMember = "Locataires";
            this.locatairesBindingSource.DataSource = this.hamidBDDataSet;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(113, 364);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 9;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(255, 364);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(95, 23);
            this.buttonEffacer.TabIndex = 10;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(418, 364);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(79, 23);
            this.buttonEnregistrer.TabIndex = 11;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxStatut);
            this.panel1.Controls.Add(this.textBoxNumContract);
            this.panel1.Controls.Add(this.textBoxNomPrenom);
            this.panel1.Controls.Add(this.textBoxCode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 160);
            this.panel1.TabIndex = 12;
            // 
            // comboBoxStatut
            // 
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Items.AddRange(new object[] {
            "",
            "Marié",
            "Célibataire"});
            this.comboBoxStatut.Location = new System.Drawing.Point(90, 107);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatut.TabIndex = 16;
            this.comboBoxStatut.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatut_SelectedIndexChanged);
            // 
            // textBoxNumContract
            // 
            this.textBoxNumContract.Location = new System.Drawing.Point(430, 33);
            this.textBoxNumContract.Name = "textBoxNumContract";
            this.textBoxNumContract.Size = new System.Drawing.Size(128, 20);
            this.textBoxNumContract.TabIndex = 15;
            // 
            // textBoxNomPrenom
            // 
            this.textBoxNomPrenom.Location = new System.Drawing.Point(90, 74);
            this.textBoxNomPrenom.Name = "textBoxNomPrenom";
            this.textBoxNomPrenom.Size = new System.Drawing.Size(207, 20);
            this.textBoxNomPrenom.TabIndex = 14;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(90, 33);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(207, 20);
            this.textBoxCode.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Num contract";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Statut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Code";
            // 
            // Locataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Locataire";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Locataire_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamidBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatairesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private HamidBDDataSet hamidBDDataSet;
        private HamidBDDataSetTableAdapters.LocatairesTableAdapter locatairesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locataireIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locataireCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomprenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutmariageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource locatairesBindingSource;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxStatut;
        private System.Windows.Forms.TextBox textBoxNumContract;
        private System.Windows.Forms.TextBox textBoxNomPrenom;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

