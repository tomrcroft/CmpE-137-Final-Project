using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Introduction_WebApplication1
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["Username"].ToString();

        }

        protected void Update_Click(object sender, EventArgs e)
        {
             //   SqlConnection myConnection = new SqlConnection("user id=xaigamer;" +
                                     "server=localhost;" +
                                     "Trusted_Connection=yes;" +
             //                        "database=FinalProject; " +
                                     "connection timeout=30");
                try
                {
                    myConnection.Open();
                }
                finally
                {

                }

                //SqlCommand myCommand = new SqlCommand("UPDATE Users SET Name=' WHERE Username ='"+Session["Username"].ToString()+"';", myConnection);
                try
                {
                    myCommand.ExecuteNonQuery();
                    //TextBox4.Text = "User registered";
                    TextBox1.Text = "Profile Updated!";
 

                }
                catch (SqlException sqlerror)
                {
                    TextBox4.Text = "Username is already taken";
                }
            
            else
            {
                TextBox4.Text = "Your Passwords do not match.";
            }
        }

        

    }
}