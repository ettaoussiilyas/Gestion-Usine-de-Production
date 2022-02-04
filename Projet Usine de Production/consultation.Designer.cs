
namespace Projet_Usine_de_Production
{
    partial class consultation
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
            this.grid_prod = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_prod
            // 
            this.grid_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_prod.Location = new System.Drawing.Point(45, 86);
            this.grid_prod.Name = "grid_prod";
            this.grid_prod.Size = new System.Drawing.Size(524, 268);
            this.grid_prod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUCTION";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afficher le contenue du table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_prod);
            this.Name = "consultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}