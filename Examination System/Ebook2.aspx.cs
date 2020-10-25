using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ebook2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void java1_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition","filename=java1.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/java1.pdf"));
        Response.End();

    }
    protected void java2_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=java2.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/java.pdf"));
        Response.End();

    }
    protected void java3_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=java3.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/java3.pdf"));
        Response.End();

    }
    protected void cpp1_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=cpp1.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/cpp1.pdf"));
        Response.End();

    }
    protected void cpp2_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=cpp2.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/cpp2.pdf"));
        Response.End();

    }
    protected void cpp3_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=cpp3.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/cpp3.pdf"));
        Response.End();

    }
    protected void js1_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=js1.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/js1.pdf"));
        Response.End();

    }
    protected void js2_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=js2.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/js2.pdf"));
        Response.End();

    }
    protected void js3_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=js3.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/js3.pdf"));
        Response.End();

    }
    protected void cs1_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=c#1.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/c#1.pdf"));
        Response.End();

    }
    protected void cs2_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=c#2.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/c#2.pdf"));
        Response.End();

    }
    protected void cs3_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=c#3.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/c#3.pdf"));
        Response.End();

    }
    protected void c1_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=c1.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/c1.pdf"));
        Response.End();

    }
    protected void c2_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=c2.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/c2.pdf"));
        Response.End();

    }
    protected void c3_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=c3.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/c3.pdf"));
        Response.End();

    }
    protected void sql1_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=sql1.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/sql1.pdf"));
        Response.End();

    }
    protected void sql2_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=sql2.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/sql2.pdf"));
        Response.End();

    }
    protected void sql3_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/octect-stream";
        Response.AppendHeader("content-disposition", "filename=sql3.pdf");
        Response.TransmitFile(Server.MapPath("~/Files/sql3.pdf"));
        Response.End();

    }
   
}