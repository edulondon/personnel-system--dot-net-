<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="activestaffList.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.activestaffList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="createStaff" runat="server">
    <table id="pattern-style-a">
       <thead>  <tr style="background-color:ActiveCaption"><td colspan="4"><h4>NIA Staff Records</h4></td></tr>
       
           <tr style="background-color:ActiveCaption"><td style="text-align:right"></td><td colspan="3">
           <%--<asp:DropDownList ID="filter" runat="server" AutoPostBack="True" OnSelectedIndexChanged="filter_SelectedIndexChanged">
                <asp:ListItem>-select option-</asp:ListItem>
                <asp:ListItem>active</asp:ListItem>
                <asp:ListItem>inactive</asp:ListItem>
                <asp:ListItem>all</asp:ListItem>
            </asp:DropDownList>--%>
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
                </td></tr></thead>
        <tr><td colspan="4" style="width:80%; height:60px"></td></tr>
               <tr style="font-size:large; font-weight:100"><td style="width:15%">Staff Id</td><td style="width:15%">Last Name</td><td style="width:15%">First Name</td><td style="width:15%">Gender</td></tr>  
        <tr><td colspan="4" style="width:80%; height:15px"></td></tr>
    <asp:ListView ID="ListView1" runat="server" ItemType="niaps_ver_1._0.staffRecord" SelectMethod="GetStaff">
        <ItemTemplate>
        <asp:Label ID="staffDetail" runat="server"></asp:Label>
              <tbody>   <tr><td style="width:15%"><%#: Item.staffId %></td><td style="width:15%"><%#: Item.lName %></td><td style="width:15%"><%#: Item.fName %></td><td style="width:15%"><%#: Item.gender %></td><td style="width:15%"><a href="staffDetails.aspx?staffId=<%#: Item.staffId %>">detail</a></td><td style="width:15%"></tr>         
            </tbody>
        </ItemTemplate>
    </asp:ListView>
        </table>
        </form>
</asp:Content>
