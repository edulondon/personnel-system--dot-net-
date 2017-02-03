<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="viewLeave.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.viewLeave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <%-- <div class="container">
    <ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
        <li><a href="viewLeave.aspx">view leave</a></li>
</ul>
         </div>--%>
    <table class="table table-striped table-hover"><thead>
        <tr><td>S/No</td><td>Staff Name</td><td>Leave Days Granted</td><td>Start Date</td><td>End Date</td><td>Total Un-Used Leave Days</td></tr>
 </thead>  <tbody> <asp:Label ID="leave" runat="server"></asp:Label>
      </tbody>  </table>
</asp:Content>
