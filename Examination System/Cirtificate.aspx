<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cirtificate.aspx.cs" Inherits="Cirtificate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        #d2
        {
            border:solid 1px;
            background-color:Silver;
            width:1000px;
            margin-left:200px;
            margin-top:150px;
            
            
        }
    .d1
    {
        float:left;
        padding:10px;
        }
        #dd
        {
            
            width: 98px;
            height: 79px;
        }
        #d3
        {
            
            width: 851px;
            height: 79px;
        }
        
        #logoimg
        {
            width:40px;
            height:40px;
        }
        
        .img-circle{border-radius:50%}
        *,*:before,*:after{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box
                           }
                           *
    {
        color: #000 !important;
        text-shadow: none !important;
        background: transparent !important;
        box-shadow: none !important;
    }
        .style1
        {
            vertical-align: middle;
            height: auto;
            width: auto\9;
            border-style: none;
            border-color: inherit;
            border-width: 0;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="d2">
    <div>
    
      <div class="d1" id="dd">
      
          <asp:Image ID="Image1" runat="server" Height="83px" 
              ImageUrl="~/images/logo.jpg" class="img-circle img" />
      
      </div>  
      <div class="d1" id="d3">
      
          <asp:Image ID="Image2" runat="server" Height="84px" 
              ImageUrl="~/images/slider/CertificatePS.png" Width="858px" />
      
      </div>


&nbsp;<br />
        <br />
&nbsp;</div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        He has successfully completed the&nbsp;
       <asp:Label ID="Label2" runat="server"></asp:Label> &nbsp; exam from ProgrammingSkills.com
    <br />
    <br />
    <h3>Authorized by:</h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <h3>Programming Skills</h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <img src="images/cert.png" class="style1" 
            style="page-break-inside: avoid; max-width: 100%;" />&nbsp;&nbsp;&nbsp;
    <br />

        <br />
                       <br /><br />                        
                                          
                        
                    </div>  
                    <br />
                <asp:Button ID="Button1" runat="server" Text="Print"
                    OnClientClick="JavaScript:window.print();" 
        onclick="Button1_Click" CausesValidation="False"/>
                <br /><br />              
             
    </form>
</body>
</html>
