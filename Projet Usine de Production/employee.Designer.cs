
namespace Projet_Usine_de_Production
{
    partial class employee
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
            this.Vider_btn = new System.Windows.Forms.Button();
            this.Supprimer_btn = new System.Windows.Forms.Button();
            this.Modifier_btn = new System.Windows.Forms.Button();
            this.Ajouter_btn = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Quitter_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Vider_btn
            // 
            this.Vider_btn.Location = new System.Drawing.Point(585, 218);
            this.Vider_btn.Name = "Vider_btn";
            this.Vider_btn.Size = new System.Drawing.Size(75, 23);
            this.Vider_btn.TabIndex = 21;
            this.Vider_btn.Text = "Vider";
            this.Vider_btn.UseVisualStyleBackColor = true;
            this.Vider_btn.Click += new System.EventHandler(this.Vider_btn_Click);
            // 
            // Supprimer_btn
            // 
            this.Supprimer_btn.Location = new System.Drawing.Point(479, 218);
            this.Supprimer_btn.Name = "Supprimer_btn";
            this.Supprimer_btn.Size = new System.Drawing.Size(75, 23);
            this.Supprimer_btn.TabIndex = 20;
            this.Supprimer_btn.Text = "Supprimer";
            this.Supprimer_btn.UseVisualStyleBackColor = true;
            this.Supprimer_btn.Click += new System.EventHandler(this.Supprimer_btn_Click);
            // 
            // Modifier_btn
            // 
            this.Modifier_btn.Location = new System.Drawing.Point(585, 150);
            this.Modifier_btn.Name = "Modifier_btn";
            this.Modifier_btn.Size = new System.Drawing.Size(75, 23);
            this.Modifier_btn.TabIndex = 19;
            this.Modifier_btn.Text = "Modifier";
            this.Modifier_btn.UseVisualStyleBackColor = true;
            this.Modifier_btn.Click += new System.EventHandler(this.Modifier_btn_Click);
            // 
            // Ajouter_btn
            // 
            this.Ajouter_btn.Location = new System.Drawing.Point(479, 150);
            this.Ajouter_btn.Name = "Ajouter_btn";
            this.Ajouter_btn.Size = new System.Drawing.Size(75, 23);
            this.Ajouter_btn.TabIndex = 18;
            this.Ajouter_btn.Text = "Ajouter";
            this.Ajouter_btn.UseVisualStyleBackColor = true;
            this.Ajouter_btn.Click += new System.EventHandler(this.Ajouter_btn_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(159, 346);
            this.maskedTextBox1.Mask = "00 00 00 00 00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(159, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(208, 36);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 54);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "DateTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Adresse";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tel";
            // 
            // Quitter_btn
            // 
            this.Quitter_btn.Location = new System.Drawing.Point(479, 269);
            this.Quitter_btn.Name = "Quitter_btn";
            this.Quitter_btn.Size = new System.Drawing.Size(181, 23);
            this.Quitter_btn.TabIndex = 28;
            this.Quitter_btn.Text = "Quitter";
            this.Quitter_btn.UseVisualStyleBackColor = true;
            this.Quitter_btn.Click += new System.EventHandler(this.Quitter_btn_Click);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 396);
            this.Controls.Add(this.Quitter_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vider_btn);
            this.Controls.Add(this.Supprimer_btn);
            this.Controls.Add(this.Modifier_btn);
            this.Controls.Add(this.Ajouter_btn);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "employee";
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vider_btn;
        private System.Windows.Forms.Button Supprimer_btn;
        private System.Windows.Forms.Button Modifier_btn;
        private System.Windows.Forms.Button Ajouter_btn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Quitter_btn;
    }
}