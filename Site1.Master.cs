using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace MTN
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["role"] == null)
                {
                    loginbtn.Visible = true;
                    logoutbtn.Visible = false;
                    adminmanagement.Visible = false;
                    profile.Visible = false;
                }
                else if (Session["role"].Equals("user"))
                {
                    loginbtn.Visible = false;
                    logoutbtn.Visible = true;
                    adminmanagement.Visible = false;
                    profile.Visible = true;
                }
                else if (Session["role"].Equals("admin"))
                {
                    loginbtn.Visible = false;
                    logoutbtn.Visible = true;
                    adminmanagement.Visible = true;
                    profile.Visible = false;
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
             
        }
        protected void Profile_click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
        protected void Logoutbtn_click(object sender, EventArgs e)
        {

            Session["role"] = "";
            Session["number"] = "";
            Session["username"] = "";
            Session["adminname"] = "";
            loginbtn.Visible = true;
            logoutbtn.Visible = false;
            adminmanagement.Visible = false;
            profile.Visible = false;
            Response.Redirect("Home.aspx");
        }
        protected void Adminmanagement_click(object sender, EventArgs e)
        {
            Response.Redirect("adminmanagement.aspx");
        }
        protected void Signup_click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void login_click(object sender, EventArgs e)
        {
            
            if(isAdmin())
            {
                
                Response.Redirect("adminmanagement.aspx");
            }
            else if(isUser())
            {
                Response.Redirect("userprofile.aspx");
            }
            else
            {
                Response.Write("<script>alert('Wrong Input');</script>");
            }
        }
        bool isUser()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string sql = "select * from UserData where UserName='" + TextBox1.Text.Trim() + "' AND UserPassword='" + TextBox2.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(sql, con);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Session["username"] = dr.GetValue(0);
                        Session["number"] = dr.GetValue(3);
                        Session["role"] = "user";
                    }
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        bool isAdmin()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string adsql = "select * from db_securityadmin.AdminInfo where AdminName='" + TextBox1.Text.Trim() + "' AND AdminPassword='" + TextBox2.Text.Trim() + "';";
                SqlCommand adcommand = new SqlCommand(adsql, con);

                SqlDataReader addr = adcommand.ExecuteReader();
                if (addr.HasRows)
                {
                    while (addr.Read())
                    {
                        Session["adminname"] = addr.GetValue(0);
                        Session["role"] = "admin";
                    }
                    
                    return true;
                }
                else
                {
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