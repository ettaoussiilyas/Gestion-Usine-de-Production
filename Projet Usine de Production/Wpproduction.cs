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
    public partial class Wpproduction : Form
    {
        ADO d = new ADO();
        public void remplissagedatagridview()
        {
            d.cmd.CommandText = "delete from wproduction";
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery();

            d.dt.Rows.Clear();






            d.cmd.CommandText = "insert into wproduction(DP,Mat,NP,codea,Designation,qp) select  '"+dateTimePicker1.Value+"',Employe.Mat,'#',ARTICLE.codea,ARTICLE.Designation,ARTICLE.Stock from employe cross join ARTICLE";
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery(); 

            d.cmd.CommandText = "select * from wproduction";
            d.cmd.Connection = d.con;

            d.dr=d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;


        }
        public Wpproduction()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Wpproduction_Load(object sender, EventArgs e)
        {
            d.connecter();
        }

        private void generer_btn_Click(object sender, EventArgs e)
        {
            remplissagedatagridview();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.deconnecter();
            this.Close();
            validation p = new validation();
            
            p.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.deconnecter();
            this.Close();
        }
    }
}
