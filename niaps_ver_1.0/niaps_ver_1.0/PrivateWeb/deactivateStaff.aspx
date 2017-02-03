<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="deactivateStaff.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.deactivateStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
<%--       <div class="container">
         
<ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="staffList.aspx">staff list</a><span class="divider">/</span></li>
    <li><a href="deactivateStaff.aspx">de/activate staff</a><span class="divider"></span></li>
</ul>
         </div>--%>
     <form id="deactivateStaff" runat="server">
     <table class="table"><tr><td colspan="4" class="auto-style1">

        <h5> Please confirm action:</h5>
         <br />

        <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
               </td></tr>
         <tr><td style="text-align:center" class="auto-style2">&nbsp;</td><td class="auto-style2" rowspan="2">
             <asp:Label ID="img" runat="server"></asp:Label>
             </td><td class="auto-style2">Staff Id</td><td class="auto-style2">
             <asp:TextBox ID="sid" runat="server" Width="173px" Enabled="false"></asp:TextBox>
             </td></tr>
         <tr><td style="text-align:center">&nbsp;</td><td>Name</td><td>
             <asp:TextBox ID="name" runat="server" Width="264px" Enabled="false"></asp:TextBox>
             </td></tr>
         <%--<tr><td style="text-align:center">&nbsp;</td><td>Department</td><td>
             <asp:TextBox ID="dept" runat="server" Width="264px" Enabled="false"></asp:TextBox>
             </td></tr>--%>
         <tr><td style="text-align:center">&nbsp;</td><td>
             &nbsp;</td><td>deactivate/activate</td><td>
             <asp:CheckBox ID="dt" runat="server" />
             </td></tr>
         <tr><td style="text-align:center">&nbsp;</td><td>
             &nbsp;</td><td>
             <asp:Button ID="deactivate" runat="server" Text="de/activate" BackColor="#33CC33" BorderColor="#33CC33" OnClick="deactivate_Click"/>
             </td><td>&nbsp;</td></tr>
         <tr><td style="text-align:center">&nbsp;</td><td>
             &nbsp;</td><td>
                 &nbsp;</td><td>&nbsp;</td></tr>
     </table>
     </form>
</asp:Content>
