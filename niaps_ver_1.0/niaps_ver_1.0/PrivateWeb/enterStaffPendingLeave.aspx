<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="enterStaffPendingLeave.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.enterStaffPendingLeave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <form id="createStaff" runat="server">
    <table class="table"><thead>
        <tr>
            <td colspan="2"><h4>Staff Pending Leave</h4><asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
        </tr></thead><tbody>
         <tr>
            <td>Staff Name</td><td> <asp:DropDownList ID="sname" runat="server" DataSourceID="EntityDataSource1" DataTextField="lName" DataValueField="staffId" Width="128px" OnSelectedIndexChanged="SelectStaff_SelectedIndexChanged" AppendDataBoundItems="true">
                <asp:ListItem>-- select staff--</asp:ListItem>
                </asp:DropDownList>
             <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="staffRecords" EntityTypeFilter="staffRecord" Select="it.[staffId], it.[lName]">
             
             </asp:EntityDataSource>
             <asp:Label ID="otherNames" runat="server"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>Pending Leave</td><td>
                <asp:TextBox ID="pleave" runat="server" MaxLength="2" TextMode="Number" Width="67px"></asp:TextBox>
                &nbsp;days<asp:Label ID="plError" runat="server" ForeColor="Red"></asp:Label>
             </td>
        </tr>
         <tr>
            <td></td><td>
                <asp:Button ID="btnPLeave" runat="server" Text="post" OnClick="btnPLeave_Click" BackColor="#33CC33" BorderColor="#0033CC" Font-Size="Large" Height="25px" Width="65px" /></td>
        </tr>
        </tbody>
    </table>
        </form>
</asp:Content>
