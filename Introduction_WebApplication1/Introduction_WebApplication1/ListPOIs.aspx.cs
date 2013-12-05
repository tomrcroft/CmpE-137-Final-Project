using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Introduction_WebApplication1
{
    public partial class ListPOIs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                //Setup database connection
                SqlCommand command = new SqlCommand();
                SqlConnection conn = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=FinalProject;server=(local)");
                /*
                SqlConnection conn = new SqlConnection("user id=DavidHsu-PC;" +
                                       "server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=FinalProject; " +
                                       "connection timeout=30");
                //*/

                //Query to get data from database User table
                string PoiQuery = "Use FinalProject; Select ID, Name, Description from POIs";

                //Open connection for database
                command.CommandText = PoiQuery;
                command.Connection = conn;
                conn.Open();

                //Set up table header
                TableHeaderRow tHeaderRow = new TableHeaderRow();
                TableHeaderCell tHeadCell = new TableHeaderCell();
                tHeadCell.Text="Name";
                tHeaderRow.Cells.Add(tHeadCell);

                tHeadCell = new TableHeaderCell();
                tHeadCell.Text = "Description";
                tHeaderRow.Cells.Add(tHeadCell);

                /*
                tHeadCell = new TableHeaderCell();
                tHeadCell.Text = "Rating";
                tHeaderRow.Cells.Add(tHeadCell);
                //*/

                Table1.Rows.Add(tHeaderRow);

                //Get data from database
                SqlDataReader myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    TableRow tRow = new TableRow();
                    Table1.Rows.Add(tRow);

                    TableCell tCell = new TableCell();
                    tCell.Text = "<a href='POIdetails.aspx?ID="+ myReader["ID"].ToString() + "'>" + 
                        myReader["Name"].ToString()+"</a>";
                    tRow.Cells.Add(tCell);

                    tCell = new TableCell();
                    tCell.Text = myReader["Description"].ToString();
                    tRow.Cells.Add(tCell);

                    /*
                    SqlCommand getRating = new SqlCommand();
                    getRating.CommandText = "Use FinalProject;Select avg(Reviews.rating) from Reviews Where POIIDs =" + myReader["ID"];
                    getRating.Connection = conn;
                    //*/
                    /*
                    command.CommandText = "Use FinalProject;Select avg(Reviews.rating) from Reviews Where POIIDs =" + myReader["ID"];
                    tCell = new TableCell();
                    tCell.Text = command.ExecuteScalar().ToString();
                    tRow.Cells.Add(tCell);
                    //*/
                }
                myReader.Close();
                conn.Close();             
            }
            else
            {
                Response.Redirect("Login.aspx");     
            }

        }
    }
}