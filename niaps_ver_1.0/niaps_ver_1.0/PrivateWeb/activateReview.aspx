<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="activateReview.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.activateReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <link href="../Content/style.css" rel="stylesheet" />
    <form id="form1" runat="server">
    <table class="table"><thead>
        <tr>
            <td colspan="2"><h4>Activate Appraisal</h4></td><td colspan="2"><asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr></thead><tbody>
        <tr>
            <td colspan="2" style="text-align:right">Quarter</td><td>
                <asp:DropDownList ID="qtr" runat="server">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>first</asp:ListItem>
                    <asp:ListItem>second</asp:ListItem>
                    <asp:ListItem>third</asp:ListItem>
                    <asp:ListItem>fourth</asp:ListItem>
                </asp:DropDownList>
            </td><td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:right">Year</td><td>
                <asp:DropDownList ID="yr" runat="server">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>2025</asp:ListItem>
                    <asp:ListItem>2024</asp:ListItem>
                    <asp:ListItem>2023</asp:ListItem>
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                </asp:DropDownList>
            </td><td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:right">Activate? (Yes/No)</td><td>
                <asp:CheckBox ID="act" runat="server" /></td><td>
                &nbsp;</td>
        </tr>
        <tr>
            <td></td><td class="auto-style1"></td><td>
                <asp:Button ID="activate" runat="server" Text="done" OnClick="activate_Click" BackColor="#33CC33" BorderColor="#0066CC" /></td><td></td>
        </tr></tbody>
    </table>
    </form>
</asp:Content>
