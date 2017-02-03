<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="enterNextOfKinInfo.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.enterNextOfKinInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
     <form id="createStaff" runat="server">
        <table id="pattern-style-a"><thead>
            <tr style="width:150px; height:30px; background-color:ActiveCaption">
                <td colspan="5"><h4>Staff Next of Kin</h4>
                    <asp:Label ID="msg" runat="server" Text=""></asp:Label></td></tr></thead><tbody>
            <tr>
                <td>First Name</td><td>
                    <asp:TextBox ID="fname" runat="server"></asp:TextBox></td><td></td><td>&nbsp;</td><td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Last Name</td><td>
                    <asp:TextBox ID="ln" runat="server"></asp:TextBox></td><td></td><td>&nbsp;</td><td>
                    &nbsp;</td>
            </tr>
             <tr>
                <td>Gender</td><td>
                    <asp:TextBox ID="sex" runat="server"></asp:TextBox></td><td></td><td>&nbsp;</td><td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Phone</td><td>
                    <asp:TextBox ID="phone" runat="server"></asp:TextBox>
                </td><td></td><td>&nbsp;</td><td>
                &nbsp;</td>
            </tr>
            <tr>
                <td>Address</td><td>
                    <asp:TextBox ID="addr" Width="240px" runat="server"></asp:TextBox></td><td>&nbsp;</td><td>&nbsp;</td><td>
                &nbsp;</td>
            </tr>
            <tr>
                <td>Relationship</td><td>
                    <asp:TextBox ID="rel" runat="server"></asp:TextBox>
                </td><td>&nbsp;</td><td>&nbsp;</td><td>
                &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>
                &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td><td>
                    <asp:Button ID="create" runat="server" Text="next" OnClick="create_Click"/>
                    </td><td>&nbsp;</td><td>&nbsp;</td><td>
                &nbsp;</td>
            </tr></tbody>
            </table>
        </form>
</asp:Content>
