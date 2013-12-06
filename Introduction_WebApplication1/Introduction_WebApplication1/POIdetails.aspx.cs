﻿using System;
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
            cmd2.CommandText = "select Comment from Reviews where PoiIDs =" + i + ";";
            SqlDataReader r = cmd2.ExecuteReader();
            while (r.Read())
            {
                //reviewLabel.Text += r["Comment"].ToString() + System.Environment.NewLine;
                TableRow row = new TableRow();
                reviewTable.Rows.Add(row);

                TableCell cell = new TableCell();
                cell.Text = r["Comment"].ToString();
                row.Cells.Add(cell);

            }

            con.Close();
            
        }

    }
}