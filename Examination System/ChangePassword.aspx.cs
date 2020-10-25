using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
  
    protected void show_Click(object sender, EventArgs e)
    {
        string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(strConnString);
        SqlDataAdapter sda = new SqlDataAdapter("select Password from Registration where Password='" + oldpass.Text + "'", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        if (dt.Rows.Count.ToString() == "1")
        {
            if (newpass.Text == conpass.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Registration set Password='" + conpass.Text + "' where Password='" + oldpass.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Text = "Sucessfully Updated";
            }
            else
            {
                Label1.Text = "New Password and Confirm Password must be same..!";
            }
        }
        else
        {
            Label1.Text = "Please check your old password..!";
        }

    }
}