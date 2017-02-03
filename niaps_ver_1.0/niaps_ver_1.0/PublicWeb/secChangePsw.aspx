<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user2.Master" AutoEventWireup="true" CodeBehind="secChangePsw.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.secChangePsw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <%--   <div class="container">
ul class="breadcrumb">
<li><a href="postNews.aspx">post news</a><span class="divider">/</span></li>
  <li><a href="secChangePsw.aspx">change password</a><span class="divider"></span></li> 
</ul>
         </div>--%>
    
    <form runat="server" id="changePsw">
        <table class="table"><thead><tr>
            <td class="auto-style1"><h3>Change Password</h3></td><td>
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td></tr></thead><tbody>
            <tr><td class="auto-style1" style="text-align: right">Old Password</td><td>
                <asp:TextBox ID="oldPsw" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="oldError" runat="server" ForeColor="Red"></asp:Label>
                </td></tr>
           <tr> <td class="auto-style1" style="text-align: right"> New Password</td><td><asp:TextBox ID="psw" runat="server" TextMode="Password"></asp:TextBox>
               <asp:Label ID="pswError" runat="server" ForeColor="Red"></asp:Label>
               </td></tr>
          <tr>  <td class="auto-style1" style="text-align: right">Comfirm</td><td>
              <asp:TextBox ID="cpsw" runat="server" TextMode="Password"></asp:TextBox>
              <asp:Label ID="cpswError" runat="server" ForeColor="Red"></asp:Label>
              </td></tr>
          <tr>  <td class="auto-style1"></td><td></td></tr>
           <tr> <td class="auto-style1"></td><td>
               <asp:Button ID="btnUser" runat="server" Text="change" BackColor="#33CC33" BorderColor="#0066FF" Font-Size="Large" OnClick="btnUser_Click"/></td></tr>

        </tbody></table>
    </form>
</asp:Content>
