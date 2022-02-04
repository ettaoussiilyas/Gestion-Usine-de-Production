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
    public partial class employee : Form
    {
        ADO d = new ADO();

        public int number()
        {
            var c = 0;
            d.cmd.CommandText = "select count(*) from employe where mat='" + numericUpDown1.Value + "'";
            d.cmd.Connection = d.con;
            c = (int)d.cmd.ExecuteScalar();

            return c;

        }
        public employee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_btn_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || textBox1.Text == "" || textBox2.Text == "" ||  richTextBox1.Text=="" || maskedTextBox1.Text=="")
            {
                MessageBox.Show("un ou plusieurs champs sont vides");
                return;
            }
            if(number()>0)
            {
                MessageBox.Show("existe deja");
                return;
            }

            if(number()==0)

            {
                d.cmd.CommandText = "insert into Employe values('" + numericUpDown1.Value + "','" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "','" + richTextBox1.Text + "','" + maskedTextBox1.Text + "')";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();

            }


        }

        private void Supprimer_btn_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Chercher l'employe que vous voulez Supprimer.");
                return;
            }

            if (number() == 1)
            {

                d.cmd.CommandText = "delete from employe where mat='" + numericUpDown1.Value + "' ";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();

            }
        }

         private void employee_Load(object sender, EventArgs e)
        {
            d.connecter();

        }

        private void Modifier_btn_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Chercher l'employe que vous voulez modifier.");
                return;
            }

            if (number() == 1)
            {

                d.cmd.CommandText = "update employe set   Nom='" + textBox1.Text + "', Prenom='" + textBox2.Text + "', dn='" +dateTimePicker1.Value + "', adress='" + richTextBox1.Text + "', tel='" + maskedTextBox1.Text + "' where mat='" + numericUpDown1.Value + "'";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();

            }
        }

        private void Vider_btn_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
            maskedTextBox1.Text = "";

            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void Quitter_btn_Click(object sender, EventArgs e)
        {
            d.deconnecter();
            this.Close();
        }
    }
}
