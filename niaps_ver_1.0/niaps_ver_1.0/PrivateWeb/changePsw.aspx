<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="changePsw.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.changePsw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link href="../Content/style.css" rel="stylesheet" />
    <%--     <div class="container">
          
<ul class="breadcrumb">
<li><a href="index.aspx">Home</a><span class="divider">/</span></li>
    <li><a href="changePsw.aspx">change password</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <form runat="server" id="changePsw">
         <table class="table"><thead><tr>
            <td class="auto-style1"><h4>Change Password</h4></td><td>
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
               <asp:Button ID="btnUser" runat="server" Text="change" OnClick="btnUser_Click1" BackColor="#33CC33" BorderColor="#0066FF"/></td></tr>

        </tbody></table>
    </form>

       
</asp:Content>
