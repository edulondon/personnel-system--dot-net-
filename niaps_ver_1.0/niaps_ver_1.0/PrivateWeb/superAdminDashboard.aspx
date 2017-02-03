<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/superAdmin.Master" AutoEventWireup="true" CodeBehind="superAdminDashboard.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.superAdminDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
   <div class="col-sm-4 col-md-6 col-lg-8">
    <form id="setupUser" runat="server">
    <table class="table "><thead>
            <tr>
                
            <td colspan="2" style="width:150px"><h4>Setup Users</h4><br />
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
            </thead><tbody>
            <tr><td>Full Name</td><td>
                <asp:TextBox ID="fname" runat="server" Width="189px"></asp:TextBox>
                &nbsp;<asp:Label ID="fnameMsg" runat="server" ForeColor="Red"></asp:Label>
                </td></tr>
            <tr><td>Username</td><td>
                <asp:TextBox ID="usname" runat="server"></asp:TextBox>
                <asp:Label ID="unameMsg" runat="server" ForeColor="Red"></asp:Label>
                </td></tr>
           <tr> <td> Password</td><td><asp:TextBox ID="psword" runat="server" TextMode="Password"></asp:TextBox>
               <asp:Label ID="pswMsg" runat="server" ForeColor="Red"></asp:Label>
               </td></tr>
          <tr>  <td>Role</td><td>
              <asp:DropDownList ID="roles" runat="server">
                 
                  <asp:ListItem>-select-</asp:ListItem>
                  <asp:ListItem Value="admin">Super Admin</asp:ListItem>
                  <asp:ListItem Value="hr">Human Resource</asp:ListItem>
                  <asp:ListItem Value="inventory">Inventory</asp:ListItem>
                  <asp:ListItem Value="secret'l">Secretarial</asp:ListItem>
                 
              </asp:DropDownList>
              </td></tr>
          <tr>  <td></td><td></td></tr>
           <tr> <td></td><td>
               <asp:Button ID="btnUser" runat="server" Text="create" OnClick="btnUser_Click" /></td></tr>
            </tbody>
        </table>
        </form>
       </div>
    <div class="col-sm-8 col-md-6 col-lg-4">

  </div>
    
</asp:Content>
