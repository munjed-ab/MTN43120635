using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace MTN
{
    public partial class userprofile : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                string current = Session["username"].ToString();

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sql = "select * from UserData where UserName='" + current + "';";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox1.Text = dt.Rows[0][1].ToString();
                    TextBox2.Text = dt.Rows[0][2].ToString();
                    TextBox3.Text = dt.Rows[0][7].ToString();
                    TextBox4.Text = dt.Rows[0][3].ToString();
                    TextBox5.Text = dt.Rows[0][5].ToString();
                    TextBox6.Text = dt.Rows[0][4].ToString();
                    TextBox9.Text = dt.Rows[0][8].ToString();
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }
        protected void findBill(object sender, EventArgs e)
        {
            try
            {
                string session = Session["username"].ToString();

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sql = "select * from UserData where UserName='" + session + "';";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count>=1)
                {
                    if (dt.Rows[0][3].ToString()== TextBox7.Text.Trim())
                    {
                        TextBox8.Text = dt.Rows[0][9].ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('No Such Number');</script>");
                    }
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }
    }
}