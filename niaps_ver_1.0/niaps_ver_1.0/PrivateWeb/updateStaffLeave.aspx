<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateStaffLeave.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateStaffLeave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="createStaff" runat="server">
    <table class="table">
        <tr>
            <td colspan="8"><h5>Update Leave</h5>
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
        </tr>
        <tr>
            <td>
            &nbsp;&nbsp;&nbsp;&nbsp;
                </td><td colspan="7">Staff Name:&nbsp;
                <asp:Label ID="sname" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp; Staff Id&nbsp;
                <asp:Label ID="sid" runat="server"></asp:Label>
                <asp:Label ID="sidL" runat="server" ForeColor="Red"></asp:Label>
                </td>
        </tr>
        <tr>
            <td>
                staff Pending Leave 
                <asp:TextBox ID="pLeave" runat="server" Width="48px"></asp:TextBox> days</td><td colspan="3">Leave Days Granted&nbsp;&nbsp;&nbsp;</td>
            <td colspan="3">
                <asp:TextBox ID="daysGranted" runat="server" Width="46px" AutoPostBack="True"></asp:TextBox> <asp:Label ID="dg" runat="server" ForeColor="Red"></asp:Label>
                days</td>
            <td>
                &nbsp;</td>
        </tr>
          <tr>
            <td>&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Start Date</td><td colspan="2">
                <asp:TextBox ID="dati" runat="server" Width="117px"></asp:TextBox>
                  <asp:Label ID="sDati" runat="server" ForeColor="Red"></asp:Label>
              </td>
              <td colspan="3">
                  End Date&nbsp;&nbsp;</td>
              <td colspan="2">
                <asp:TextBox ID="edate" runat="server" Width="122px"></asp:TextBox></td>
        </tr>
          <tr>
            <td>&nbsp;</td><td class="auto-style2">
                  &nbsp;</td>
              <td colspan="3">
                  &nbsp;&nbsp;&nbsp;&nbsp;</td>
              <td colspan="3">
                  &nbsp;</td>
        </tr>
          <tr>
            <td class="auto-style3"></td><td colspan="7" class="auto-style3">
                <asp:Button ID="btnSubmit" runat="server" Text="update" BackColor="#33CC33" BorderColor="#0066FF" Font-Size="Large" OnClick="btnSubmit_Click" />
              </td>
        </tr>
        <tr>
            <td></td><td colspan="7" class="auto-style3">
                
              </td>
        </tr>
          </table>
        </form>

</asp:Content>
