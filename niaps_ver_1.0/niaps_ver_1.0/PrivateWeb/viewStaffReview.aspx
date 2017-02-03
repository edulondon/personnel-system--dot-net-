<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="viewStaffReview.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.viewStaffReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 63px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="../Content/style.css" rel="stylesheet" />
     <%--<div class="container">
    <ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
        <li><a href="viewStaffReview.aspx">view appraisal</a></li>
</ul>
         </div>--%>
    
    <form id="form1" runat="server">
    <table class="table table-striped table-hover"><tr><td colspan="2" style="text-align:right">
        Quarter:
        <asp:DropDownList ID="qtr" runat="server">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>first</asp:ListItem>
                    <asp:ListItem>second</asp:ListItem>
                    <asp:ListItem>third</asp:ListItem>
                    <asp:ListItem>fourth</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp; Year:
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
&nbsp;&nbsp;&nbsp; Straff Name:<asp:DropDownList ID="staff" runat="server" AutoPostBack="True" DataSourceID="EntityDataSource1" DataTextField="lName" DataValueField="staffId" OnSelectedIndexChanged="staff_SelectedIndexChanged" AppendDataBoundItems="true"><asp:ListItem>--select staff--</asp:ListItem></asp:DropDownList><asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="staffRecords" EntityTypeFilter="staffRecord" Select="it.[lName], it.[staffId]">
        </asp:EntityDataSource></td><td class="auto-style1">Select a staff to view his/her appraisal report</td></tr>
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
