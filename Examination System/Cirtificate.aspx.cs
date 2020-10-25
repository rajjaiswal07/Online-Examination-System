using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Cirtificate : System.Web.UI.Page
{
    string sub;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {

        //string user = User.Identity.Name;
        //string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();

        //Label1.Text = user;
        sub = Session["Subject"].ToString();
        Label2.Text = sub;
        cmd.CommandText = "select * from Registration where email='"+Session["emailid"]+"'";
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(ds);
        Label1.Text = ds.Tables[0].Rows[0]["Name"].ToString();


    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.Visible = false;
    }
}