using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
         
        string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(strConnString);
        con.Open();
        string str = "select * from Registration";
        SqlCommand cmd = new SqlCommand(str,con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            if (emailid.Text == dr["Email"].ToString() && mobileno.Text == dr["Mobile"].ToString())
            {
                password.Text = dr["Password"].ToString();
            }
            else
            {
                Label1.Text = "Email and Mobile number invalid..!";
                return;
            }
        }
            dr.Close();
            con.Close();
        
        
        
    }
}