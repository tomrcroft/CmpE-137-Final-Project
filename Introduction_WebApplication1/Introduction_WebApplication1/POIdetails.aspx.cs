using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Introduction_WebApplication1
{
    public partial class POIdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title.Font.Size = 48;
            //SqlConnection con = new SqlConnection(""); //connection string
            SqlConnection con = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=FinalProject;server=(local)");
            con.Open();
            //System.Windows.Forms.MessageBox.Show(con.State.ToString());

            //description
            SqlCommand cmd = con.CreateCommand();
            int i = Convert.ToInt32(Request.QueryString["ID"]);
            cmd.CommandText = "select Description from POIs where ID =" + i + ";";
            string desc = (string)cmd.ExecuteScalar();
            this.rLabel.Text = desc;

            //reviews
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandText = "select Comment from Reviews where ID =" + i + ";";
            SqlDataReader r = cmd2.ExecuteReader();
            while (r.Read())
            {
                reviewLabel.Text += r.NextResult().ToString() + "\n";
            }

            con.Close();
            
        }

    }
}