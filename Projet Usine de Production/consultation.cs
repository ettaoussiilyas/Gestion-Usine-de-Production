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
    public partial class consultation : Form
    {
        ADO d =new ADO();
        public consultation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.connecter();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.cmd.CommandText = "select * from production";
            d.cmd.Connection = d.con;

            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            grid_prod.DataSource = d.dt;
        }
    }
}
