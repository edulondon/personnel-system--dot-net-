<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <form id="form1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
            <div class = "container">
<%--<div class = "row-fluid">--%>
   
   
     <div class="col-sm-4 col-md-6 col-lg-6">
         <span class="h3" style=" align-content:center; color:red">Welcome to Nigerian Insurers Association Personnel System (NIAPS)</span><br />
         <asp:Image ID="NIA_House" runat="server"  ImageUrl="~/images/NIA House.jpg" Height="372px" Width="406px" ImageAlign="Middle"/>
        </div>
     <div class="col-sm-8 col-md-6 col-lg-6">
        <table id="pattern-style-a"><thead><tr><td><h5>News</h5></td></tr></thead>
    <tbody><tr><td><asp:Label ID="news" runat="server"></asp:Label></td></tr></tbody>
              </table>
</div>
    </div>
                <%--</div>--%>
    </asp:Panel>
    </form>
</asp:Content>
