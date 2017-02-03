<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="viewUsers.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.uploadedfiles.viewUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="pattern-style-a">
       <thead>  <tr style="background-color:ActiveCaption"><td colspan="3"><h4>Users</h4></td></tr>
       
           <tr><td style="text-align:right"></td><td colspan="2">
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
                </td></tr></thead>
        <tr><td colspan="3" style="width:80%; height:60px"></td></tr>
               <tr style="font-size:large; font-weight:100"><td style="width:15%">User Name</td><td style="width:15%">Role</td><td style="width:15%">Status</td></tr>  
        <tr><td colspan="3" style="width:80%; height:15px"></td></tr>
    <asp:ListView ID="ListView1" runat="server" ItemType="niaps_ver_1._0.adminUser" SelectMethod="GetUser">
        <ItemTemplate>
        <asp:Label ID="staffDetail" runat="server"></asp:Label>
              <tbody>   <tr><td style="width:15%"><%#: Item.userName %></td><td style="width:15%"><%#: Item.role %></td><td style="width:15%"><%#: Item.status %></td><td style="width:15%"><a href="updateUser.aspx?staffId=<%#: Item.userName %>">update</a></td></tr>         
            </tbody>
        </ItemTemplate>
    </asp:ListView>
        </table>
</asp:Content>
