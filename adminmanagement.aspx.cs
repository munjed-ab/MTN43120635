using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTN
{
    public partial class adminmanagement : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        protected void bill_click(object sender, EventArgs e)
        {
            try
            {
                if(isFound())
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE UserData SET UserBill=@UserBill WHERE UserNumber='" + num.Text.Trim() + "'");
                    cmd.Parameters.AddWithValue("@UserBill", billing.Text.Trim());
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    clearForm();
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Not Found');</script>");
                }

            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void clearForm()
        {
            num.Text = "";
            billing.Text = "";
            GridView1.DataBind();
        }
        bool isFound()
        {
            try
            {
                
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sql = "select * from UserData where UserNumber='" + num.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                    connection.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    connection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        
    }
}