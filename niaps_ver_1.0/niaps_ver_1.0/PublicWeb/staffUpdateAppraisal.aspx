<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user.Master" AutoEventWireup="true" CodeBehind="staffUpdateAppraisal.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.staffUpdateAppraisal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <table class="table"><tr><td colspan="2" style="text-align:right" class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Year:
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
        &nbsp;&nbsp;&nbsp;</td><td class="auto-style1">Quarter:
        <asp:DropDownList ID="qtr" runat="server" OnSelectedIndexChanged="qtr_SelectedIndexChanged">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>first</asp:ListItem>
                    <asp:ListItem>second</asp:ListItem>
                    <asp:ListItem>third</asp:ListItem>
                    <asp:ListItem>fourth</asp:ListItem>
                </asp:DropDownList>
        </td></tr>
        <tr><td colspan="3">&nbsp;</td>
           </tr>
        <tr><td class="auto-style2" style="text-align:right"><asp:Label ID="displayDetail" runat="server" ForeColor="Red"></asp:Label></td><td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="displayDetails2" runat="server" ForeColor="Red"></asp:Label></td>
           </tr> 
        
    </table>
    <table class="table"><tr><td> &nbsp;</td><td></td><td></td></tr>
        <asp:Label ID="review" runat="server"></asp:Label> 
        <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp;</td><td></td></tr>
        <tr><td></td><td>&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr>
</table>
    </form>
</asp:Content>
