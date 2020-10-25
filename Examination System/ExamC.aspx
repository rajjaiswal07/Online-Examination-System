<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ExamC.aspx.cs" Inherits="ExamC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">C Exam
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">

<div class="container">
<br />
<h2>Please take a look on below points before starting exam: </h2>
<br /><hr /><br />

<ul>
<li>Make sure that you have read all the <a href="Rules.aspx">Rules</a>. </li>
<li>Before Giving Exam you should Practice for the particular subjects.</li>
<li>The certificate of exam is free but out of 20 you should get atleast 15 marks</li>
<li>There is no negative marking</li>
<li>All questions are Compulsary</li>
</ul>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Start Exam" 
        onclick="Button1_Click" />

    <br />

</div>

</asp:Content>
