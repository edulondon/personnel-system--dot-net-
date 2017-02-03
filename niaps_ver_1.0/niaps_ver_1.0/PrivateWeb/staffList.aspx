<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="staffList.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.staffList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <%-- <div class="container">
<ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="staffList.aspx">staff details</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <form id="createStaff" runat="server">
  
        <table class="table"><tr><td>
        <asp:DropDownList ID="filter" runat="server" Font-Size="Medium">
                <asp:ListItem>All</asp:ListItem>
                <asp:ListItem>Active</asp:ListItem>
                <asp:ListItem>Inactive</asp:ListItem>
                
            </asp:DropDownList>
            </td><td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td><td style="text-align:right">
            <asp:TextBox ID="param" runat="server" Font-Size="Medium" Width="211px" ToolTip="enter a name to search" placeholder="enter a name to search"></asp:TextBox></td><td style="text-align:match-parent">&nbsp;&nbsp&nbsp;&nbsp
                <asp:Button ID="search" runat="server" Text="search" Font-Italic="True" Font-Size="Smaller" ForeColor="#333300" ToolTip="enter a name to search" OnClick="search_Click" Height="24px" Width="65px" BackColor="#33CC33" BorderColor="#0066FF" Font-Bold="True"/> 
        </td></tr>
           <tr><td colspan="7">
               <asp:Button ID="view" runat="server" Text="view" BackColor="#33CC33" BorderColor="#0066FF" Font-Bold="True" Font-Italic="True" Font-Size="Smaller" Width="100px" OnClick="view_Click" /> </td></tr>
        
        
        </table><hr / style="resize:horizontal; border-bottom-color:blueviolet">
         
    <asp:Label ID="staffDetail" runat="server"></asp:Label>
              

        </form>
</asp:Content>
