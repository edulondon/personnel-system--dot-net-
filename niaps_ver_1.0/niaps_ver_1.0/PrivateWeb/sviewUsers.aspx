<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/superAdmin.Master" AutoEventWireup="true" CodeBehind="sviewUsers.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.sviewUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <table class="table"><thead>
         
         <tr><td>Full Name</td><td>User Name</td><td>Role</td><td >Status</td><td colspan="2"></td><td><asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td></tr></thead>
    <asp:Label ID="newsLabel" runat="server"></asp:Label>
              </table>
</asp:Content>
