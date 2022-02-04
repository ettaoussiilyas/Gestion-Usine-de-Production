using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Projet_Usine_de_Production
{
    class ADO
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataTable dt2 = new DataTable();
        public DataTable dt3 = new DataTable();





        public void connecter()
        {
            con.ConnectionString = "Data Source=BESSIE;Initial Catalog=USINE;Integrated Security=true";

            if(con.State == ConnectionState.Closed||con.State == ConnectionState.Broken)
            {
                con.Open();

            }
           
        }

        public void deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
