<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="viewAsset.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.viewAsset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <%-- <div class="container">
    <ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="viewAsset.aspx">asset list</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <table class="table table-striped table-hover">
        
       <thead> 
                <tr style="font-size:small; font-weight:100"><td style="width:15%">S/No</td><td>Asset ID</td><td>Asset Name</td><td style="width:15%">Date Purchased</td><td style="width:15%">Receiving Department</td><td>Status</td><td></td></tr>  </thead>
        <tbody><tr><td colspan="4" style="width:80%; height:15px"></td></tr>
            <asp:Label ID="assetLabel" runat="server"></asp:Label>
     </tbody>   </table>
</asp:Content>
