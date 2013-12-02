using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Introduction_WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
        //  SqlConnection myConnection = new SqlConnection("user id=xaigamer;" +
            SqlConnection myConnection = new SqlConnection("user id=DavidHsu-PC;" +
=======
<<<<<<< HEAD
            //SqlConnection myConnection = new SqlConnection("user id=xaigamer;" +
                        SqlConnection myConnection = new SqlConnection("user id=TOMLAPTOP-HP\\SQLEXPRESS;" +

=======
<<<<<<< HEAD
            SqlConnection myConnection = new SqlConnection("user id=DavidHsu-PC;" +
        //  SqlConnection myConnection = new SqlConnection("user id=xaigamer;" +
=======
          //  SqlConnection myConnection = new SqlConnection("user id=DavidHsu-PC;" +
              SqlConnection myConnection = new SqlConnection("user id=xaigamer;" +
>>>>>>> 2c6848a2ca494314deb7e7eb87b4332b5687957a
>>>>>>> ed5169a4faf2ac471f82a67b19b66258caa1db69
>>>>>>> 17e22ed0658484a211f10f4a22a89b5576f57268
                                       "server=localhost;" +
                                       "Trusted_Connection=yes;" +
            //                           "database=FinalProject; " +
                                                   "database=CMPE137project; " +

                                       "connection timeout=30");

            try
            {
                myConnection.Open();
            }
            finally
            {

            }
            SqlCommand myCommand = new SqlCommand("Use FinalProject; Select Password from Users where Username='" + TextBox1.Text + "';", myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader["Password"].ToString() == TextBox2.Text)
                {
                    Session["Username"] = TextBox1.Text;
                    Response.Redirect("ListPOIs.aspx");
                    //Session["Username"] = TextBox1.Text;
                }
                else
                {
                    TextBox3.Text = "Invalid Username or Password.";
                    TextBox3.Visible = true;
                }
            }
            TextBox3.Text = "Invalid Username or Password.";
            TextBox3.Visible = true;

        }

    }
}