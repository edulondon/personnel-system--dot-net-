<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="viewQuery.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.viewQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <link href="../Content/style.css" rel="stylesheet" />
     <%--<div class="container">
    <ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
        <li><a href="viewQuery.aspx">view query</a></li>
</ul>
         </div>--%>
    <table class="table table-striped table-hover"><thead>
        <tr><td colspan="3"><h5>Query Details</h5></td></tr>
        <tr><td colspan="3" style="width:80%; height:60px"></td></tr>
                <tr><td style="width:15%">Staff Id</td><td style="width:15%">Query</td><td style="width:15%">Issued By</td><td style="width:15%">Date Issued</td><td style="width:15%">Date Replied</td><td style="width:15%">Answer</td><td style="width:15%">Disciplinary Action</td><td style="width:15%"></td></tr>  
        <tr><td colspan="4" style="width:80%; height:15px"></td></tr></thead><tbody>
    <asp:ListView ID="ListView1" runat="server" ItemType="niaps_ver_1._0.query" SelectMethod="GetQuery">
        <ItemTemplate>
            
                 <tr><td style="width:15%"><%#: Item.staffId %></td><td style="width:15%"><%#: Item.natureOfQuery%></td><td style="width:15%"><%#: Item.issuedBy%></td><td style="width:15%"><%#: Item.dateIssued.ToShortDateString()%></td><td style="width:15%"><%#: Item.dateReplied %></td><td style="width:15%"><%#:Item.reply %></td><td style="width:15%"><%#: Item.actionTaken%></td><td><a href="updateQuery.aspx?staffId=<%#:Item.staffId %>&queryId=<%#:Item.Id %>">disciplinary action</a></td></tr>         

        </ItemTemplate>
    </asp:ListView></tbody>
        </table>
</asp:Content>
