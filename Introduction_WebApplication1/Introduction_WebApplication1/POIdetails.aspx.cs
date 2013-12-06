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
            //SqlConnection con = new SqlConnection(""); //connection string
            SqlConnection con = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=FinalProject;server=(local)");
            con.Open();
            //System.Windows.Forms.MessageBox.Show(con.State.ToString());

            //description
            SqlCommand cmd = con.CreateCommand();
            int i = Convert.ToInt32(Request.QueryString["ID"]);
            cmd.CommandText = "select Description from POIs where ID =" + i + ";";
            string desc = (string)cmd.ExecuteScalar();

            TableRow descrow = new TableRow();
            descriptionTable.Rows.Add(descrow);

            TableCell desccell = new TableCell();
            desccell.Text = desc;
            descrow.Cells.Add(desccell);

            

            //reviews
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandText = "select Comment, rating from Reviews where PoiIDs =" + i + ";";
            SqlDataReader r = cmd2.ExecuteReader();
            while (r.Read())
            {
                //reviewLabel.Text += r["Comment"].ToString() + System.Environment.NewLine;
                TableRow row = new TableRow();
                reviewTable.Rows.Add(row);

                TableCell cell = new TableCell();
                cell.Text = r["Comment"].ToString();
                row.Cells.Add(cell);

                TableCell bufferCell = new TableCell();
                bufferCell.Text = "Rating: ";
                row.Cells.Add(bufferCell);

                TableCell rateCell = new TableCell();
                rateCell.Text = r["rating"].ToString();
                row.Cells.Add(rateCell);

            }

            con.Close();
            
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Request.QueryString["ID"]);
            String s = reviewTextbox.Text;
            String user = Session["Username"].ToString();
            int rev = Convert.ToInt32(this.ratingList.SelectedValue);
            SqlConnection con = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=FinalProject;server=(local)");
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Reviews values('"+ user +"', "+ i + ", '"+ s +"', " + rev + ");";
            cmd.ExecuteNonQuery();
            //name poid comment rating
            Response.Redirect(Request.RawUrl);

            con.Close();

        }

    }
}