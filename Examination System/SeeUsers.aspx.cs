using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class SeeUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString2"].ToString());
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        String query = "insert into Registration (Name,Email,Mobile,Password,Role) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
        SqlDataAdapter sda = new SqlDataAdapter(query, con);
        sda.SelectCommand.ExecuteNonQuery();
        con.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        String query = "delete from Registration where Name='"+TextBox1.Text+"'";
        SqlDataAdapter sda = new SqlDataAdapter(query,con);
        sda.SelectCommand.ExecuteNonQuery();
        con.Close();
    }
}