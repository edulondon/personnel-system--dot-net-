<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user2.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <div class = "container">
         <%--<div class="container">
<ul class="breadcrumb">
<li><a href="postNews.aspx">post news</a><span class="divider"></span>/</li>
    <li><a href="updateNews.aspx">view news</a><span class="divider"></span>/</li>
    <li><a href="#">update news</a></li>
</ul>
         </div>--%>
<div class = "row-fluid">
<div class="span4">
    </div>
    <div class="span4">
      <form id="form1" runat="server">
    <table class="table">
        <thead><tr style="width:180px;">
            <td colspan="2"><h4>Update News</h4>
                <asp:Label ID="msg" runat="server" ForeColor="#FF3300"></asp:Label></td>
        </tr></thead>
        <tr>
            <td class="auto-style1">Author</td><td>
            <asp:TextBox ID="author" runat="server"></asp:TextBox>
            <asp:Label ID="aError" runat="server" ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Title</td><td>
            <asp:TextBox ID="postBy" runat="server"></asp:TextBox>
            <asp:Label ID="tError" runat="server" ForeColor="Red"></asp:Label>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">News</td><td>
                <asp:TextBox ID="news" runat="server" Rows="5" Columns="4" TextMode="MultiLine" Width="355px" Height="137px"></asp:TextBox>
                <asp:Label ID="nError" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"></td><td>
                <asp:Button ID="btnPost" runat="server" Text="update" BackColor="#33CC33" BorderColor="#0099FF" Font-Size="Large" Width="98px" OnClick="btnPost_Click" /></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td><td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td><td>
                &nbsp;</td>
        </tr>
    </table>

    </form>
    
        </div>
    <div class="span4">
  <%-- <table id="Table1"><thead><tr><td><h4>News</h4></td></tr></thead>
    <tbody><tr><td><asp:Label ID="newsLabel" runat="server" BorderStyle="None" BorderColor="#009933" Font-Names="arial" Font-Size="Small" ForeColor="#660066"></asp:Label></td></tr></tbody>
              </table>--%>
</div>
</div>
</div>
</asp:Content>
