<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateUser.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="createStaff" runat="server">
        <table id="pattern-style-a">
             <tr style="width:150px; height:30px; background-color:ActiveCaption">
                <td colspan="3"><h4>Deactivate User</h4></td><td colspan="2">
                   
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td>&nbsp;</td><td class="auto-style1" style="text-align:right">
                    deactivate/activate user</td><td>
                    <asp:CheckBox ID="dt" runat="server" />
                </td><td>
                    &nbsp;</td><td>
                &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td><td class="auto-style1">
                    &nbsp;</td><td>
                    <asp:Button ID="done" runat="server" Text="done" OnClick="done_Click"/>
                    </td><td>
                    &nbsp;</td><td>
                     &nbsp;</td>
            </tr>
             </table>
        </form>
</asp:Content>
