
namespace Projet_Usine_de_Production
{
    partial class validation
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
            this.grid_wprod = new System.Windows.Forms.DataGridView();
            this.grid_prod = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transfer_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_wprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_wprod
            // 
            this.grid_wprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_wprod.Location = new System.Drawing.Point(12, 39);
            this.grid_wprod.Name = "grid_wprod";
            this.grid_wprod.Size = new System.Drawing.Size(748, 252);
            this.grid_wprod.TabIndex = 0;
            // 
            // grid_prod
            // 
            this.grid_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_prod.Location = new System.Drawing.Point(110, 362);
            this.grid_prod.Name = "grid_prod";
            this.grid_prod.Size = new System.Drawing.Size(566, 242);
            this.grid_prod.TabIndex = 1;
            this.grid_prod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "WPRODUCTION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCTION";
            // 
            // transfer_btn
            // 
            this.transfer_btn.Location = new System.Drawing.Point(866, 270);
            this.transfer_btn.Name = "transfer_btn";
            this.transfer_btn.Size = new System.Drawing.Size(189, 95);
            this.transfer_btn.TabIndex = 4;
            this.transfer_btn.Text = "Transferer Les donnes";
            this.transfer_btn.UseVisualStyleBackColor = true;
            this.transfer_btn.Click += new System.EventHandler(this.transfer_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.Location = new System.Drawing.Point(1014, 581);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(75, 23);
            this.quit_btn.TabIndex = 5;
            this.quit_btn.Text = "Quitter";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Retour a la generation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.transfer_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_prod);
            this.Controls.Add(this.grid_wprod);
            this.Name = "validation";
            this.Text = "validation";
            this.Load += new System.EventHandler(this.validation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_wprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_wprod;
        private System.Windows.Forms.DataGridView grid_prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button transfer_btn;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Button button1;
    }
}