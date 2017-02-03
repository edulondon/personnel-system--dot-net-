<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="createLeave.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.createLeave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 191px;
        }
        .auto-style3 {
            height: 31px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <%-- <div class="container">
<ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="createLeave.aspx">create leave</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <form id="createStaff" runat="server">
    <table class="table">
        <tr>
            <td colspan="8"><h5>Leave</h5>
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="SelectStaff" runat="server" OnSelectedIndexChanged="SelectStaff_SelectedIndexChanged" AutoPostBack="True" Width="175px" AppendDataBoundItems="true" Height="23px">
                    <asp:ListItem>-- select staff--</asp:ListItem>
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="nameL" runat="server" ForeColor="Red"></asp:Label>
                </td><td colspan="7">Staff Name:&nbsp;
                <asp:TextBox ID="sname" runat="server" Enabled="False" ForeColor="Red"></asp:TextBox>&nbsp;&nbsp;&nbsp; Staff Id&nbsp;
                <asp:TextBox ID="sid" runat="server" Enabled="False" ForeColor="Red"></asp:TextBox>
                <asp:Label ID="sidL" runat="server" ForeColor="Red"></asp:Label>
                </td>
        </tr>
        <tr>
            <td>
                staff Pending Leave 
                <asp:TextBox ID="pLeave" runat="server" Width="48px" Enabled="False" ForeColor="Red"></asp:TextBox> days</td><td colspan="3">Current Leave Days</td>
            <td colspan="3">
                <asp:TextBox ID="cleave" runat="server" Width="72px" Enabled="False" ForeColor="Red"></asp:TextBox></td>
            <td>
                &nbsp;</td>
        </tr>
          <tr>
            <td>&nbsp;Leave Days Granted&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="daysGranted" runat="server" Width="46px" AutoPostBack="True" OnTextChanged="daysGranted_TextChanged"></asp:TextBox> &nbsp;&nbsp;<asp:Label ID="dg" runat="server" ForeColor="Red"></asp:Label>
&nbsp;days</td><td colspan="2">
                  Start Date</td>
              <td colspan="3">
                <asp:TextBox ID="dati" runat="server" Width="117px" CssClass="datepicker" AutoPostBack="True" OnTextChanged="dati_TextChanged"></asp:TextBox>
                  <asp:Label ID="sDati" runat="server" ForeColor="Red"></asp:Label>
              </td>
              <td colspan="2">
                  &nbsp;</td>
        </tr>
          <tr>
            <td>End Date&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="edate" runat="server" Width="122px" Enabled="False" ForeColor="Red"></asp:TextBox></td><td colspan="2">
                  Total Leave Days</td>
              <td colspan="3">
                <asp:Label ID="tldays" runat="server" ForeColor="Red"></asp:Label>
              &nbsp; days</td>
              <td colspan="2">
                  &nbsp;</td>
        </tr>
          <tr>
            <td>&nbsp;Leave Days Left&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="daysLeft" runat="server" Width="46px" ForeColor="Red" Enabled="false"></asp:TextBox> &nbsp; days</td><td class="auto-style2">
                  &nbsp;</td>
              <td colspan="3">
                  &nbsp;&nbsp;&nbsp;&nbsp;</td>
              <td colspan="3">
                  &nbsp;</td>
        </tr>
          <tr>
            <td class="auto-style3"></td><td colspan="7" class="auto-style3">
                <asp:Button ID="btnSubmit" runat="server" Text="assign" OnClick="btnSubmit_Click" BackColor="#33CC33" BorderColor="#0066FF" Font-Size="Large" />
              </td>
        </tr>
        <tr>
            <td></td><td colspan="7" class="auto-style3">
                
              </td>
        </tr>
          </table>
        </form>
     <script>

         $('.datepicker').datepicker({});
    </script>
</asp:Content>
