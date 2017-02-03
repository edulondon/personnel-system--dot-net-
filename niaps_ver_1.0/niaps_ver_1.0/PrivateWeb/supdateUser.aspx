<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/superAdmin.Master" AutoEventWireup="true" CodeBehind="supdateUser.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.supdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 60px;
        }
        .auto-style2 {
            height: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <form id="form1" runat="server">
     <table id="pattern-style-a"><tr><td colspan="4" class="auto-style1">

        <h5> Please confirm action:</h5>
         <br />

        <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
               </td></tr>
         <tr><td style="text-align:center" class="auto-style2">user name:</td><td class="auto-style2">
             <asp:TextBox ID="uname" runat="server" Width="173px" Enabled="false"></asp:TextBox>
             </td><td class="auto-style2"></td><td class="auto-style2"></td></tr>
         <tr><td style="text-align:center">role:</td><td>
             <asp:TextBox ID="rol" runat="server" Width="154px" Enabled="false"></asp:TextBox>
             </td><td></td><td></td></tr>
         <tr><td style="text-align:center">deactivate/activate</td><td>
             <asp:CheckBox ID="dt" runat="server" />
             </td><td></td><td></td></tr>
         <tr><td style="text-align:center">&nbsp;</td><td>
             <asp:Button ID="update" runat="server" Text="de/activate" OnClick="update_Click" BackColor="#33CC33" BorderColor="#0066FF" Font-Bold="True" Font-Size="Large" Width="100px"/>
             </td><td>&nbsp;</td><td>&nbsp;</td></tr>
     </table>
     </form>
</asp:Content>
