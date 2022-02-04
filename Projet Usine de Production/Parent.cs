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
    public partial class Parent : Form
    {
        ADO d = new ADO();

        
       
    public Parent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.connecter();
            
        }

        private void employesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee employ = new employee();
            employ.Show();
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articles articles = new Articles();
            articles.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d.deconnecter();
            this.Close();
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wpproduction p = new Wpproduction();
            p.Show();
        }

        private void validationDeLaSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            validation p = new validation();
            p.Show();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultation p = new consultation();
            p.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Gestion Usine de Production-v0.1 \nDevelopped by : \n -Ouail Berra \n -Ilyas Taousi \n -Saad El Moueden \n -Salaheddine Zirari.","A propos",MessageBoxButtons.OK);
        }

        private void sommaireDeLaideF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aide", "", MessageBoxButtons.OK);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void clear()
        {
            if (d.dt.Rows.Count > 0)
            {
                
                d.dt.Clear();
                dataGridView1.Refresh();

            }
        }

        private void listeDesEmployesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (d.dt.Rows.Count > 0)
            {

                d.dt.Clear();
                dataGridView1.Refresh();

            }

            d.cmd.CommandText = "select * from employe";
            d.cmd.Connection = d.con;

            d.dr=d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;



        }

        private void listeDesArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (d.dt2.Rows.Count > 0)
            {

                d.dt2.Clear();
                dataGridView1.Refresh();

            }

            d.cmd.CommandText = "select * from article";
            d.cmd.Connection = d.con;

            d.dr = d.cmd.ExecuteReader();
            d.dt2.Load(d.dr);
            dataGridView1.DataSource = d.dt2;




        }

        private void productionParPeriodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (d.dt3.Rows.Count > 0)
            {

                d.dt3.Clear();
                dataGridView1.Refresh();

            }

            d.cmd.CommandText = "select * from production where DP between '"+dateTimePicker1.Value+ "' and  '"+dateTimePicker2.Value+"'";
            d.cmd.Connection = d.con;

            d.dr = d.cmd.ExecuteReader();
            d.dt3.Load(d.dr);
            dataGridView1.DataSource = d.dt3;


        }
    }
}
