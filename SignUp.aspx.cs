using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


namespace MTN
{
    
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void checkName(object sender, EventArgs e)
        {
            int ch = fname.Text[0];
            if (ch >= 97 || ch<65)
            {
                Response.Write("<script>alert('First letter should be capitalize');</script>");
            }
        }
        
        protected void checkNumber(object sender, EventArgs e)
        {
            int count = 0;
            
            for(int i=0; i<=number.Text.Length;i++)
            {
                count++;
            }
            if(count>13 || count<12)
            {
                Response.Write("<script>alert('It should contain 13 number and not less then 12');</script>");
            }
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            if(checkUserExist())
            {
                Response.Write("<script>alert('Number Or Email is Already Token');</script>");
            }
            else if(isAdmin())
            {
                Response.Write("<script>alert('Already Exist');</script>");
            }
            else{
                signUpNewUser();
                Response.Redirect("Home.aspx");
            }
        }

        bool checkUserExist()
        {
            try
            {
                connection.Open();

                
                string sql = "select * from UserData where UserNumber='"+ number.Text.Trim()+"' OR UserEmail='"+email.Text.Trim()+"';";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count >=1)
                {
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
                connection.Open();

                
                string sql = "select * from AdminInfo where AdminName='" + username.Text.Trim() + "' OR AdminEmail='" + email.Text.Trim() + "';";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
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
        void signUpNewUser()
        {
            string surename = surname.SelectedItem.Value.ToString();
            string firstname = fname.Text.Trim();
            string lastname = lname.Text.Trim();
            string user_name = username.Text.Trim();
            string user_age = age.Text.ToString();
            string user_number = number.Text.ToString();
            string user_city = city.Text.Trim();
            string user_email = email.Text.Trim();
            string user_password = password.Text.ToString();



            // Connect to the database string sql = "INSERT INTO user-data values ('"+surename+"','"+firstname+"','"+lastname+"','"+user_name+"','"+user_age+"','"+user_number+"','"+user_city+"','"+user_email+"','"+user_password+"')";
            try
            {
                if(connection.State==ConnectionState.Closed)
                {
                    connection.Open();
                }
                

                // Create a SQL command to insert the data into the database
                string sql = "insert into UserData (UserSurname,UserFname,UserLname,UserName,UserAge,UserNumber,UserCity,UserEmail,UserPassword,UserBill) values (@UserSurname,@UserFname,@UserLname,@UserName,@UserAge,@UserNumber,@UserCity,@UserEmail,@UserPassword,@UserBill)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@UserSurname", surename);
                command.Parameters.AddWithValue("@UserFname", firstname);
                command.Parameters.AddWithValue("@UserLname", lastname);
                command.Parameters.AddWithValue("@UserName", user_name);
                command.Parameters.AddWithValue("@UserAge", user_age);
                command.Parameters.AddWithValue("@UserNumber", user_number);
                command.Parameters.AddWithValue("@UserCity", user_city);
                command.Parameters.AddWithValue("@UserEmail", user_email);
                command.Parameters.AddWithValue("@UserPassword", user_password);
                command.Parameters.AddWithValue("@UserBill", 0);

                Session["username"] = user_name;
                Session["number"] = user_number;
                Session["role"] = "user";
                Response.Write("<script>alert('Sign up succesfull');</script>");
                // Execute the command to insert the data
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }


    }
}