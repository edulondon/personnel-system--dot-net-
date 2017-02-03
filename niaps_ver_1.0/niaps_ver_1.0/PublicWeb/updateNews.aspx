<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user2.Master" AutoEventWireup="true" CodeBehind="updateNews.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.updateNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
  <%--   <div class="container">
<ul class="breadcrumb">
<li><a href="postNews.aspx">post news</a><span class="divider">/</span></li>
    <li><a href="updateNews.aspx">view news</a></li>
</ul>
         </div>--%>
    <table class="table">
        <tr><td>S/No</td><td>Title</td><td>Author</td><td>Date</td><td></td></tr>
    <asp:Label ID="newsLabel" runat="server"></asp:Label>
        </table>
</asp:Content>
