
namespace Projet_Usine_de_Production
{
    partial class Parent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validationDeLaSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEmployesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionParPeriodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogrammeDeProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sommaireDeLaideF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem,
            this.etatsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employesToolStripMenuItem,
            this.articlesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // employesToolStripMenuItem
            // 
            this.employesToolStripMenuItem.Name = "employesToolStripMenuItem";
            this.employesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.employesToolStripMenuItem.Text = "Employes";
            this.employesToolStripMenuItem.Click += new System.EventHandler(this.employesToolStripMenuItem_Click);
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.articlesToolStripMenuItem.Text = "Articles";
            this.articlesToolStripMenuItem.Click += new System.EventHandler(this.articlesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieToolStripMenuItem,
            this.validationDeLaSaisieToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saisieToolStripMenuItem.Text = "Saisie";
            this.saisieToolStripMenuItem.Click += new System.EventHandler(this.saisieToolStripMenuItem_Click);
            // 
            // validationDeLaSaisieToolStripMenuItem
            // 
            this.validationDeLaSaisieToolStripMenuItem.Name = "validationDeLaSaisieToolStripMenuItem";
            this.validationDeLaSaisieToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.validationDeLaSaisieToolStripMenuItem.Text = "Validation de la saisie";
            this.validationDeLaSaisieToolStripMenuItem.Click += new System.EventHandler(this.validationDeLaSaisieToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // etatsToolStripMenuItem
            // 
            this.etatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesEmployesToolStripMenuItem,
            this.listeDesArticlesToolStripMenuItem,
            this.productionParPeriodeToolStripMenuItem,
            this.histogrammeDeProductionToolStripMenuItem});
            this.etatsToolStripMenuItem.Name = "etatsToolStripMenuItem";
            this.etatsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.etatsToolStripMenuItem.Text = "Etats";
            // 
            // listeDesEmployesToolStripMenuItem
            // 
            this.listeDesEmployesToolStripMenuItem.Name = "listeDesEmployesToolStripMenuItem";
            this.listeDesEmployesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.listeDesEmployesToolStripMenuItem.Text = "Liste des employes";
            this.listeDesEmployesToolStripMenuItem.Click += new System.EventHandler(this.listeDesEmployesToolStripMenuItem_Click);
            // 
            // listeDesArticlesToolStripMenuItem
            // 
            this.listeDesArticlesToolStripMenuItem.Name = "listeDesArticlesToolStripMenuItem";
            this.listeDesArticlesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.listeDesArticlesToolStripMenuItem.Text = "Liste des Articles";
            this.listeDesArticlesToolStripMenuItem.Click += new System.EventHandler(this.listeDesArticlesToolStripMenuItem_Click);
            // 
            // productionParPeriodeToolStripMenuItem
            // 
            this.productionParPeriodeToolStripMenuItem.Name = "productionParPeriodeToolStripMenuItem";
            this.productionParPeriodeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.productionParPeriodeToolStripMenuItem.Text = "Production par periode";
            this.productionParPeriodeToolStripMenuItem.Click += new System.EventHandler(this.productionParPeriodeToolStripMenuItem_Click);
            // 
            // histogrammeDeProductionToolStripMenuItem
            // 
            this.histogrammeDeProductionToolStripMenuItem.Name = "histogrammeDeProductionToolStripMenuItem";
            this.histogrammeDeProductionToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.histogrammeDeProductionToolStripMenuItem.Text = "Histogramme de Production";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem,
            this.sommaireDeLaideF1ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // sommaireDeLaideF1ToolStripMenuItem
            // 
            this.sommaireDeLaideF1ToolStripMenuItem.Name = "sommaireDeLaideF1ToolStripMenuItem";
            this.sommaireDeLaideF1ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sommaireDeLaideF1ToolStripMenuItem.Text = "Sommaire de l\'aide F1";
            this.sommaireDeLaideF1ToolStripMenuItem.Click += new System.EventHandler(this.sommaireDeLaideF1ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 410);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(380, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(26, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Production par periode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date Debut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date Fin";
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parent";
            this.Text = "Gestion Usine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validationDeLaSaisieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesEmployesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionParPeriodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogrammeDeProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sommaireDeLaideF1ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

