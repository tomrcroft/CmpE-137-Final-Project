
﻿using System;
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
            /*
        //  SqlConnection myConnection = new SqlConnection("user id=xaigamer;" +
            SqlConnection myConnection = new SqlConnection("user id=DavidHsu-PC;" +
                                       "server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=FinalProject; " +
                                       "connection timeout=30");
             //*/
            SqlConnection myConnection = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=FinalProject;server=(local)");

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