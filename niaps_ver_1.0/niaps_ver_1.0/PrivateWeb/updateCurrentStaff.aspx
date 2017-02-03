<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateCurrentStaff.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateCurrentStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="updateCurrentStaff" runat="server">
        <table class="table"><thead>
             <tr>
                <td colspan="3"><h4> Staff Record</h4></td><td colspan="2">
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
            </tr></thead><tbody>
            <tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td></td><td>&nbsp;</td><td class="auto-style2">
                &nbsp;</td>
            </tr>
            <tr>
                <td>Staff Id</td><td>
                    <asp:TextBox ID="stid" runat="server" Enabled="False" Width="102px"></asp:TextBox></td><td></td><td>Designation</td><td class="auto-style2">
                    <asp:TextBox ID="designation" runat="server" Width="110px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Last Name</td><td>
                    <asp:TextBox ID="lname" runat="server" Width="144px" Enabled="False"></asp:TextBox></td><td></td><td>Department</td><td class="auto-style2">
                    <asp:TextBox ID="dept" runat="server" Width="104px"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>First Name</td><td>
                    <asp:TextBox ID="fname" runat="server"  Width="145px" Enabled="False"></asp:TextBox></td><td></td><td>Degree Type</td><td class="auto-style2">
                    <asp:TextBox ID="degree" runat="server" Width="121px"></asp:TextBox>
                 </td>
            </tr><tr>
                <td>Date Joined</td><td>
                    <asp:TextBox ID="doj" runat="server" Enabled="False"></asp:TextBox></td><td></td><td>Discipline</td><td class="auto-style2">
                    <asp:TextBox ID="disc" runat="server" Width="120px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style1">Date Confirmed</td><td class="auto-style1">
                    <asp:TextBox ID="doc" runat="server" Enabled="False"></asp:TextBox></td><td class="auto-style1"></td><td>&nbsp;</td><td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td><td style="text-align:right">
                    <asp:Button ID="update" runat="server" Text="update" OnClick="update_Click"/>
                    </td><td></td><td class="auto-style1">&nbsp;</td><td class="auto-style2">
                    &nbsp;</td>
            </tr>
            </tbody></table>
        </form>
</asp:Content>
