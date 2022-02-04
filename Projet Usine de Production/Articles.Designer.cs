
namespace Projet_Usine_de_Production
{
    partial class Articles
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
            this.Quitter_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Vider_btn = new System.Windows.Forms.Button();
            this.Supprimer_btn = new System.Windows.Forms.Button();
            this.Modifier_btn = new System.Windows.Forms.Button();
            this.Ajouter_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // Quitter_btn
            // 
            this.Quitter_btn.Location = new System.Drawing.Point(469, 216);
            this.Quitter_btn.Name = "Quitter_btn";
            this.Quitter_btn.Size = new System.Drawing.Size(181, 23);
            this.Quitter_btn.TabIndex = 45;
            this.Quitter_btn.Text = "Quitter";
            this.Quitter_btn.UseVisualStyleBackColor = true;
            this.Quitter_btn.Click += new System.EventHandler(this.Quitter_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Prix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Designation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "codea";
            // 
            // Vider_btn
            // 
            this.Vider_btn.Location = new System.Drawing.Point(575, 165);
            this.Vider_btn.Name = "Vider_btn";
            this.Vider_btn.Size = new System.Drawing.Size(75, 23);
            this.Vider_btn.TabIndex = 38;
            this.Vider_btn.Text = "Vider";
            this.Vider_btn.UseVisualStyleBackColor = true;
            this.Vider_btn.Click += new System.EventHandler(this.Vider_btn_Click);
            // 
            // Supprimer_btn
            // 
            this.Supprimer_btn.Location = new System.Drawing.Point(469, 165);
            this.Supprimer_btn.Name = "Supprimer_btn";
            this.Supprimer_btn.Size = new System.Drawing.Size(75, 23);
            this.Supprimer_btn.TabIndex = 37;
            this.Supprimer_btn.Text = "Supprimer";
            this.Supprimer_btn.UseVisualStyleBackColor = true;
            this.Supprimer_btn.Click += new System.EventHandler(this.Supprimer_btn_Click);
            // 
            // Modifier_btn
            // 
            this.Modifier_btn.Location = new System.Drawing.Point(575, 97);
            this.Modifier_btn.Name = "Modifier_btn";
            this.Modifier_btn.Size = new System.Drawing.Size(75, 23);
            this.Modifier_btn.TabIndex = 36;
            this.Modifier_btn.Text = "Modifier";
            this.Modifier_btn.UseVisualStyleBackColor = true;
            this.Modifier_btn.Click += new System.EventHandler(this.Modifier_btn_Click);
            // 
            // Ajouter_btn
            // 
            this.Ajouter_btn.Location = new System.Drawing.Point(469, 97);
            this.Ajouter_btn.Name = "Ajouter_btn";
            this.Ajouter_btn.Size = new System.Drawing.Size(75, 23);
            this.Ajouter_btn.TabIndex = 35;
            this.Ajouter_btn.Text = "Ajouter";
            this.Ajouter_btn.UseVisualStyleBackColor = true;
            this.Ajouter_btn.Click += new System.EventHandler(this.Ajouter_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 30;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 69);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(209, 185);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 46;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(209, 247);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 47;
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 324);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.Quitter_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vider_btn);
            this.Controls.Add(this.Supprimer_btn);
            this.Controls.Add(this.Modifier_btn);
            this.Controls.Add(this.Ajouter_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Articles";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.Articles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Quitter_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Vider_btn;
        private System.Windows.Forms.Button Supprimer_btn;
        private System.Windows.Forms.Button Modifier_btn;
        private System.Windows.Forms.Button Ajouter_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}