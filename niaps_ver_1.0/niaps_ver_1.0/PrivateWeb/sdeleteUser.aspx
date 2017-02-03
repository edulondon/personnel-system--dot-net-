<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/superAdmin.Master" AutoEventWireup="true" CodeBehind="sdeleteUser.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.sdeleteUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
     <form id="form1" runat="server">
     <table class="table"><tr><td colspan="4">

        <h5> Please confirm action:</h5> <br />

        <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
               </td></tr>
         <tr><td style="text-align:center">user name:</td><td>
             <asp:TextBox ID="uname" runat="server" Width="173px"></asp:TextBox>
             </td><td></td><td></td></tr>
         <tr><td style="text-align:center">role:</td><td>
             <asp:TextBox ID="rol" runat="server" Width="154px"></asp:TextBox>
             </td><td></td><td></td></tr>
         <tr><td style="text-align:center">delete?</td><td>
             <asp:CheckBox ID="dt" runat="server" />
             </td><td></td><td></td></tr>
         <tr><td style="text-align:center">&nbsp;</td><td>
             <asp:Button ID="deleteUser" runat="server" Text="delete" OnClick="deleteUser_Click" />
             </td><td>&nbsp;</td><td>&nbsp;</td></tr>
     </table>
     </form>
</asp:Content>
