<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="forgotPsw.aspx.cs" Inherits="niaps_ver_1._0.forgotPsw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
   <%-- <div class="container">
<ul class="breadcrumb">
<li><a href="Default.aspx">back</a></li>
</ul>
         </div>--%>
    <form id="form1" runat="server">
        
    <table class="table"><thead>
        <tr>
            <td style="text-align:center">Enter your NIAPS email address &nbsp;&nbsp;&nbsp;<asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            &nbsp;<br />
                <asp:TextBox ID="TextBox1" runat="server" Text="Note: this module is for staff only, admin should contact system admin for new password" Enabled="False" ForeColor="Red" Width="558px" Font-Size="Small"></asp:TextBox>
            </td>
        </tr></thead><tbody>
        <tr>
            <td style="text-align:center">
                <asp:TextBox ID="uname" runat="server" Width="252px"></asp:TextBox>
                <asp:Label ID="check" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr><tr>
            <td style="text-align:center">
                <asp:Button ID="send" runat="server" Text="submit" OnClick="send_Click" />&nbsp;&nbsp;&nbsp;<<
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Font-Size="Medium" ForeColor="#009933">back</asp:HyperLink>>>
                </td>
        </tr></tbody>
    </table>
    </form>
</asp:Content>
