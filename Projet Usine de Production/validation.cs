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
    public partial class validation : Form
    {
        ADO d = new ADO();
        public DataTable dt2 = new DataTable();
        public validation()
        {
            InitializeComponent();
        }

        public void transfer()
        {

            

            d.cmd.CommandText = "insert into production(num, dp , mat , codea,  qtitep) select  wproduction.num,wproduction.dp,wproduction.mat,wproduction.codea,wproduction.qp from wproduction ";
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery();

            d.cmd.CommandText = "select * from production";
            d.cmd.Connection = d.con;

            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            grid_prod.DataSource = d.dt;

            d.cmd.CommandText = "delete from wproduction";
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery();


            d.dt2.Rows.Clear();

            transfer_btn.Enabled = false;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            d.deconnecter();
            this.Close();

        }

        private void transfer_btn_Click(object sender, EventArgs e)
        {

            transfer();

        }

        private void validation_Load(object sender, EventArgs e)
        {

            d.connecter();

            
            d.cmd.CommandText = "select * from wproduction";
            d.cmd.Connection = d.con;

            d.dr = d.cmd.ExecuteReader();
            d.dt2.Load(d.dr);
            grid_wprod.DataSource = d.dt2;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.deconnecter();
            this.Close();
            Wpproduction p = new Wpproduction();
            p.Show();
        }
    }
}
