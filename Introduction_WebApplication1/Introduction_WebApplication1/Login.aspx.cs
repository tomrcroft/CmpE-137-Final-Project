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
            SqlConnection myConnection = new SqlConnection("user id=DavidHsu-PC;" +
=======
         //  SqlConnection myConnection = new SqlConnection("user id=xaigamer;" +
>>>>>>> a414938246d65333a19d4026b8cbaf3dbf9e36c8
                                       "server=localhost;" +
                                       "Trusted_Connection=yes;" +
        //                            "database=FinalProject; " +
                                       "connection timeout=30");

            //xaigamer

            try
            {
                myConnection.Open();
            }
            finally
            {

            }

            //SqlCommand myCommand = new SqlCommand("Use Login; Select Password from Username where Username='" + TextBox1.Text + "';", myConnection);
            //SqlCommand myCommand = new SqlCommand("Use Lab4; Select UserPassword from UserTable where UserName='" + TextBox1.Text + "';", myConnection);
            SqlCommand myCommand = new SqlCommand("Use FinalProject; Select Password from Users where Username='" + TextBox1.Text + "';", myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader["Password"].ToString() == TextBox2.Text)
                //if (myReader["UserPassword"].ToString() == TextBox2.Text)
                {
                    Session["Username"] = TextBox1.Text;
                    Response.Redirect("ListPOIs.aspx");
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