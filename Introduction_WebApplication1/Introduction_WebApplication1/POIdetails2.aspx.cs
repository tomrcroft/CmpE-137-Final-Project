using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Introduction_WebApplication1
{
    public partial class POIdetails2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx", true);
            }
            if (Request.QueryString["ID"] == null)
            {
                Response.Redirect("ListPOIs.aspx");
            }
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

            //Query to get POI data from database
            string PoiQuery = "Use FinalProject; Select Name, Description from POIs where ID="+Request.QueryString["ID"];

            //Open connection for database
            command.CommandText = PoiQuery;
            command.Connection = conn;
            conn.Open();

            SqlDataReader myReader = command.ExecuteReader();
            if (myReader.Read())
            {
                POINameLabel.Text = myReader["Name"].ToString();
                POIDescriptionLabel.Text = myReader["Description"].ToString();
            }
            myReader.Close();

            //Set up table header
            TableHeaderRow tHeaderRow = new TableHeaderRow();
            TableHeaderCell tHeadCell = new TableHeaderCell();
            tHeadCell.Text = "User";
            tHeaderRow.Cells.Add(tHeadCell);

            tHeadCell = new TableHeaderCell();
            tHeadCell.Text = "Comment";
            tHeaderRow.Cells.Add(tHeadCell);

            tHeadCell = new TableHeaderCell();
            tHeadCell.Text = "Rating";
            tHeaderRow.Cells.Add(tHeadCell);

            ReviewsTable.Rows.Add(tHeaderRow);

            //Get Reviews from database
            string ReviewsQuery = "Use FinalProject; Select UserID, comment, rating FROM Reviews where PoiIDs=" + Request.QueryString["ID"];
            command.CommandText = ReviewsQuery;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                TableRow tRow = new TableRow();
                ReviewsTable.Rows.Add(tRow);

                TableCell tCell = new TableCell();
                tCell.Text = myReader["UserID"].ToString();
                tRow.Cells.Add(tCell);

                tCell = new TableCell();
                tCell.Text = myReader["comment"].ToString();
                tRow.Cells.Add(tCell);

                tCell = new TableCell();
                tCell.Text = myReader["rating"].ToString();
                tRow.Cells.Add(tCell);
            }
            myReader.Close();
            conn.Close();  
        }

        protected void submitReview_Click(object sender, EventArgs e)
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

            //Query to get POI data from database
            string insertReviewQuery = "Use FinalProject; INSERT INTO Reviews(UserID,PoiIDs,comment,rating) VALUES('"
                + Session["Username"].ToString() + "',"
                + Request.QueryString["ID"] + ",'"
                + commentTextBox.Text + "',"
                + ratingDropDown.SelectedValue + ");";

            //Open connection for database
            command.CommandText = insertReviewQuery;
            command.Connection = conn;
            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();

            Response.Redirect(Request.RawUrl);
        }
    }
}