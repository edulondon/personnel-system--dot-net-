<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="message.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.message" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="pattern-style-a"><thead>
        <tr>
            <td colspan="2">Transaction Status</td>

        </tr></thead><tbody>
        <tr>
            <td class="auto-style1"> </td><td></td>

        </tr>
        <tr>
            <td class="auto-style1" colspan="2" style="text-align:center"> <asp:Label ID="msg" runat="server" Text="Label" ForeColor="Red"></asp:Label></td>

        </tr>
         <tr>
            <td class="auto-style1" colspan="2" style="text-align:center"> <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PrivateWeb/index.aspx" ForeColor="#66FF66">back to home</asp:HyperLink></td>

        </tr></tbody>

    </table>
   
   
</asp:Content>
