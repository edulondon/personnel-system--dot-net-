<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="niaps_ver_1._0.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 192px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" type="text/css" />
    <div class = "container">
 
<%--<div class = "row-fluid">--%>
<div class="col-sm-4 col-md-6 col-lg-6">
    <form id="login" runat="server">
            <table class="table table-hover borderless"><thead>
             <tr><td class="borderless"><h3>Login</h3></td><td class="borderless"></td><td class="borderless">
                 <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td></tr></thead><tbody>
               <tr><td class="borderless">&nbsp;</td><td style="text-align:right" class="borderless">user name</td><td class="borderless">
                   <asp:TextBox ID="uname" runat="server" Font-Size="Medium" Width="128px"></asp:TextBox>
                   <asp:Label ID="unameError" runat="server" ForeColor="Red"></asp:Label>
                   </td></tr>
               <tr><td class="borderless">&nbsp;</td><td style="text-align:right" class="borderless">password</td><td class="borderless">
                   <asp:TextBox ID="psw" runat="server" TextMode="Password" Font-Size="Medium" Width="134px"></asp:TextBox>
                   <asp:Label ID="pswError" runat="server" ForeColor="Red"></asp:Label>
                   </td></tr>
               <tr><td class="borderless">&nbsp;</td><td style="text-align:right" class="borderless">
                   role</td><td style="text-align:left" class="borderless">
                   <asp:DropDownList ID="role" runat="server" Font-Size="Medium">
                       <asp:ListItem>-select-</asp:ListItem>
                       <asp:ListItem Value="admin">Super Admin</asp:ListItem>
                       <asp:ListItem Value="hr">Human Resource</asp:ListItem>
                       <asp:ListItem Value="inventory">Inventory</asp:ListItem>
                       <asp:ListItem Value="secret'l">Secretarial</asp:ListItem>
                       <asp:ListItem Value="staff">Staff</asp:ListItem>
                   </asp:DropDownList>
                   <asp:Label ID="roleError" runat="server" ForeColor="Red"></asp:Label>
                   </td></tr>
               <tr><td class="borderless"></td><td class="btn btn-lg text-right borderless" style="width: 192px; text-align:right"><asp:Button ID="btnLogin" runat="server" Text="login" OnClick="btnLogin_Click1" BackColor="#009933" Font-Size="Large" Width="68px"/></td><td class="btn-link">
                   <asp:HyperLink ID="fpsw" runat="server" NavigateUrl="~/forgotPsw.aspx">forgot password</asp:HyperLink>
                   </td></tr></tbody>
         </table>
        </form>
    </div>
   <%-- <div class="span4">
    
</div>--%>
    <div class="col-sm-8 col-md-6 col-lg-6">
        <table id="pattern-style-a"><thead><tr><td><h2>News</h2></td></tr></thead>
    <tbody><tr><td style="marquee-loop:infinite;"><asp:Label ID="newsLabel" runat="server"></asp:Label></td></tr></tbody>
              </table>
  
</div>
</div>
</asp:Content>

