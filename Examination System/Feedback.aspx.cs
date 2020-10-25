using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //String dateofcomment;
        //dateofcomment = DateTime.Now.ToLongDateString().ToString();
        //String query = "insert into commentdetail(visitorname,email,comment,dateofcomment) values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + TextBox3.Text + "','" + dateofcomment + "')";
        
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString2"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into CommentDetail(visitorname,email,comment,dateofcomment)values(@visitorname,@email,@comment,@postedDate)",con);
        cmd.Parameters.AddWithValue("@visitorname", TextBox2.Text);
        cmd.Parameters.AddWithValue("@email", TextBox1.Text);
        cmd.Parameters.AddWithValue("@comment", TextBox3.Text);
        cmd.Parameters.AddWithValue("@postedDate", DateTime.Now);
        con.Close();
        //SqlCommand cmd = new SqlCommand();
        //cmd.CommandText = query;
        //cmd.Connection = con;
        //cmd.ExecuteNonQuery();
        DataList1.DataBind();
        Label2.Text = "Thanks for giving your feedback... ";

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        
    }
}