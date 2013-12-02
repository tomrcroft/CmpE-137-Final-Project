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

        //    SqlConnection myConnection = new SqlConnection("user id=xaigamer;" +
                                   "server=localhost;" +
                                   "Trusted_Connection=yes;" +
        //                           "database=FinalProject; " +
                                   "connection timeout=30");
            try
            {
                myConnection.Open();
            }
            finally
            {

            }
            SqlCommand myCommand = new SqlCommand("SELECT * FROM Users WHERE Username ='"+Label1.Text+"';", myConnection);
            try
            {
                SqlDataReader userprofile = myCommand.ExecuteReader();
                userprofile.Read();
                    //indented for visbility
                    Name.Text = userprofile["Name"].ToString();
                    Gender.Text = userprofile["Gender"].ToString();
                    Birthdate.Text = userprofile["Birthdate"].ToString();
                    Email.Text = userprofile["Email"].ToString();
                myConnection.Close();

            }
            catch (SqlException sqlerror)
            {
                TextBox1.Text = "An Error Occurred When Loading. Please Try Again.";
            }
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
                SqlCommand myCommand = new SqlCommand("UPDATE Users SET Name='" + Name.Text +
                    "', Email='" + Email.Text + "', Gender='" + Gender.Text + "', Birthdate='" + Birthdate.Text +
                    "' WHERE Username ='" + Session["Username"].ToString() + "';", myConnection);
                try
                {
                    myCommand.ExecuteNonQuery();
                    TextBox1.Text = "Profile Updated!";
                    myConnection.Close();

                }
                catch (SqlException sqlerror)
                {
                    TextBox1.Text = "An Error Occurred When Updating. Please Try Again.";
                }
            
     
        }

        

    }
}