using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Usine_de_Production
{
    public partial class Articles : Form
    {
        ADO d = new ADO();

        public int number()
        {
            var c = 0;
            d.cmd.CommandText = "select count(*) from article where codea='" + numericUpDown1.Value + "'";
            d.cmd.Connection = d.con;
            c = (int)d.cmd.ExecuteScalar();

            return c;

        }
        public Articles()
        {
            InitializeComponent();
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            d.connecter();
        }
        private void Ajouter_btn_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value==0 || textBox1.Text == "" || numericUpDown2.Value == 0 || numericUpDown3.Value == 0)
            {
                MessageBox.Show("un ou plusieurs champs sont vides");
                return;
            }
            if (number() == 0)
            {

                d.cmd.CommandText = "insert into article values('" + numericUpDown1.Value + "','" + textBox1.Text + "','" + numericUpDown2.Value + "','" + numericUpDown3.Value + "')";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();

            }
        }

        private void Modifier_btn_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value== 0)
            {
                MessageBox.Show("Chercher l'article que vous voulez modifier.");
                return;
            }

            if (number() == 1)
            {

                d.cmd.CommandText = "update article set   Designation='" + textBox1.Text + "', Prix='" + numericUpDown2.Value + "', Stock='" + numericUpDown3.Value + "' where codea='"+numericUpDown1.Value+"'";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();

            }
        }

        private void Supprimer_btn_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Chercher l'article que vous voulez Supprimer.");
                return;
            }

            if (number() == 1)
            {

                d.cmd.CommandText = "delete from article where codea='" + numericUpDown1.Value + "' ";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();

            }
        }

        private void Vider_btn_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            textBox1.Text = "";
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Quitter_btn_Click(object sender, EventArgs e)
        {
            d.deconnecter();
            this.Close();
        }
    }
}
