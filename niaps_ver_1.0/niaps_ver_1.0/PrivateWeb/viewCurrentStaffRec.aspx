<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="viewCurrentStaffRec.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.viewCurrentStaffRec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
        <thead><tr><td colspan="8">
            <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td></tr>
        <tr><td>staff Id</td><td>Designation</td><td>Department</td><td>Degree Type</td><td>Discipline</td><td>Date Joined</td><td>Date Confirmed</td><td></td></tr></thead>
    <asp:Label ID="qst" runat="server"></asp:Label>
        </table>
</asp:Content>
