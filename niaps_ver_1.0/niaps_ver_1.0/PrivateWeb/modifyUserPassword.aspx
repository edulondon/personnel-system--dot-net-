<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="modifyUserPassword.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.modifyUserPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" id="changePsw">
        <table class="table"><thead><tr>
            <td class="auto-style1"><h3>Change Password</h3></td><td>
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td></tr></thead><tbody>
            <tr><td class="auto-style1" style="text-align: right">&nbsp;</td><td>
                &nbsp;</td></tr>
           <tr> <td class="auto-style1" style="text-align: right"> New Password</td><td><asp:TextBox ID="psw" runat="server" TextMode="Password"></asp:TextBox></td></tr>
          <tr>  <td class="auto-style1" style="text-align: right">Comfirm</td><td>
              <asp:TextBox ID="cpsw" runat="server" TextMode="Password"></asp:TextBox></td></tr>
          <tr>  <td class="auto-style1"></td><td></td></tr>
           <tr> <td class="auto-style1"></td><td>
               <asp:Button ID="modify" runat="server" Text="modify" OnClick="modify_Click"/></td></tr>

        </tbody></table>
    </form>
</asp:Content>
