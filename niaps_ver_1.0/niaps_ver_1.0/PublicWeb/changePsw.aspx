<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user.Master" AutoEventWireup="true" CodeBehind="changePsw.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.changePsw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
     <%--<div class="container">
<ul class="breadcrumb">
<li><a href="index.aspx">Home</a><span class="divider"></span>/</li>
    <li><a href="changePsw.aspx">change password</a></li>
</ul>
         </div>--%>
    <form runat="server" id="changePsw">
        <table class="table"><thead><tr>
            <td><h5>Change Password</h5></td><td>
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td></tr></thead><tbody>
            <tr><td class="auto-style1" style="text-align: right">Old Password</td><td>
                <asp:TextBox ID="oldPsw" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="opError" runat="server" ForeColor="Red"></asp:Label>
                </td></tr>
           <tr> <td class="auto-style1" style="text-align: right"> New Password</td><td><asp:TextBox ID="psw" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="npError" runat="server" ForeColor="Red"></asp:Label>
                </td></tr>
          <tr>  <td class="auto-style1" style="text-align: right">Comfirm</td><td>
              <asp:TextBox ID="cpsw" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="cError" runat="server" ForeColor="Red"></asp:Label>
                </td></tr>
          <tr>  <td class="auto-style1"></td><td></td></tr>
           <tr> <td class="auto-style1"></td><td>
               <asp:Button ID="btnUser" runat="server" Text="change" BackColor="#33CC33" BorderColor="#0066FF" OnClick="btnUser_Click1"/></td></tr>

        </tbody></table>
    </form>
</asp:Content>
