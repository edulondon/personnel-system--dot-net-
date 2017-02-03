<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin2.Master" AutoEventWireup="true" CodeBehind="viewNiaAsset.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.viewNiaAsset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <%-- <div class="container">
<ul class="breadcrumb">
<li><a href="regAsset.aspx">Home</a><span class="divider">/</span></li>
    <li><a href="viewAsset.aspx">view asset</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <table class="table table-striped table-hover">
        
       <thead> 
                <tr><td>S/No</td><td>Asset ID</td><td>Asset Name</td><td>Date Purchased</td><td>Receiving Department</td><td>Cover Date</td><td>Expiry Date</td><td>Status</td><td></td><td></td></tr>  </thead>
        <tbody><tr><td colspan="4"></td></tr>
            <asp:Label ID="assetLabel" runat="server"></asp:Label>
     </tbody>   </table>
</asp:Content>
