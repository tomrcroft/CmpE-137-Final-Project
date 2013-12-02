using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Introduction_WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == TextBox3.Text)
            {
                  SqlConnection myConnection = new SqlConnection("user id=xaigamer;" +
                                       "server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=FinalProject; " +
                                       "connection timeout=30");
                try
                {
                    myConnection.Open();
                }
                finally
                {

                }

                SqlCommand myCommand = new SqlCommand("INSERT INTO Users VALUES ('" + TextBox1.Text + "','"+ TextBox2.Text +"');", myConnection);
                try
                {
                    myCommand.ExecuteNonQuery();
                    //TextBox4.Text = "User registered";
                    Session["Username"] = TextBox1.Text;
                    Response.Redirect("ListPOIs.aspx");
        
                }
                catch(SqlException sqlerror)
                {
                   TextBox4.Text = "Username is already taken";
                }
            }
            else 
            {
                TextBox4.Text = "Your Passwords do not match.";
            }
        }
    }
}