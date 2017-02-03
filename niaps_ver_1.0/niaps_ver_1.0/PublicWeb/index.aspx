<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
   
    <table class="table"><tr><td>
    <asp:Label ID="welcome" runat="server"></asp:Label><br />
        </td></tr></table>
    <div class = "container">
        <%--<div class = "row-fluid">--%>
<div class="col-sm-3 col-md-3 col-lg-4">
    <asp:Image ID="niaLogo" runat="server"  ImageUrl="~/images/NiaLogo.jpg" Height="321px" Width="358px"/>
    </div>
        <div class="col-sm-3 col-md-3 col-lg-4">
            <asp:Label ID="queryLabel" runat="server" ForeColor="Red"></asp:Label>
            <br /><h1>Welcome to Nigerian Insurers Association</h1>
    </div>
      <div class="col-sm-6 col-md-6 col-lg-4">
          <table id="pattern-style-a"><thead><tr><td><h4>News</h4></td></tr></thead>
    <tbody><tr><td><asp:Label ID="news" runat="server"></asp:Label></td></tr></tbody>
              </table>
    </div>
            </div>
           <%-- </div>--%>
        
</asp:Content>
