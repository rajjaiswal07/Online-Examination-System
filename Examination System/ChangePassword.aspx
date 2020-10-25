<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
Change Password
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
body {
background-color: #f4f4f4;
color: #5a5656;
font-family: 'Open Sans', Arial, Helvetica, sans-serif;
font-size: 16px;
line-height: 1.5em;
}
#a1
{
    font-size:x-large;
}
a { text-decoration: none; }
h1 { font-size: 1em; }
h1, p {
margin-bottom: 10px;
}
strong {
font-weight: bold;
}
.uppercase { text-transform: uppercase; }

/* ---------- CHANGE PASSWORD ---------- */
#login {
margin: 50px auto;
width: 300px;
}
form fieldset input[type="text"], input[type="password"] {
        border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: #e5e5e5;
            border-radius: 3px;
            -moz-border-radius: 3px;
            -webkit-border-radius: 3px;
            color: #5a5656;
            font-family: 'Open Sans', Arial, Helvetica, sans-serif;
            font-size: 14px;
            outline: none;
            padding: 0px 10px;
            -webkit-appearance:none;
}

form fieldset input[type="submit"] {
background-color: #008dde;
border: none;
border-radius: 3px;
-moz-border-radius: 3px;
-webkit-border-radius: 3px;
color: #f4f4f4;
cursor: pointer;
font-family: 'Open Sans', Arial, Helvetica, sans-serif;
height: 50px;
text-transform: uppercase;
width: 280px;
-webkit-appearance:none;
}
form fieldset a {
color: #5a5656;
font-size: 10px;
}

h1
{
    color:Black;
}
</style>

</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">

    <div id="login">
<h1><strong>Welcome.</strong> Change Your Password.</h1>
   
<fieldset>  
OLD PASSWORD:<br /><br />
<asp:TextBox ID="oldpass" runat="server"  Height="50px"></asp:TextBox>
    
    <br /><br /> 
NEW PASSWORD:<br /><br />
<asp:TextBox ID="newpass" runat="server" Height="50px"></asp:TextBox>
    
   <br /><br /> 
CONFIRM Password:<br /><br />
<asp:TextBox ID="conpass" runat="server" Height="50px"></asp:TextBox>
    

<p><a href="SignIn.aspx">SignIn</a>
    <p>
    <asp:Label ID="Label1" runat="server" ForeColor="#FF3300"></asp:Label>
    </p>


     <asp:Button ID="show" runat="server" Text="Change Password" 
        onclick="show_Click"  />
    <br /><br />
    
  <p>New User? click Here for</p> <h1><a href="Registration.aspx" id="a1"> SignUP </a></h1>
    
</fieldset><br />
    <br />
    <br />
&nbsp;
</div>


</asp:Content>




