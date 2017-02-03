<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="assetDetail.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.assetDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
   <%-- <div class="container">
    <ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="viewAsset.aspx">asset list</a><span class="divider">/</span></li>
        <li><a href="assetDetail.aspx">asset detail</a></li>
</ul>
         </div>--%>
    <table class="table table-striped table-hover"><thead> 
                <tr><td colspan="2" style="font-style:italic; font-size:small">
            <a href="viewAsset.aspx">click to go back</a>
         </td>
        </tr>
        <tr><td colspan="2">
            <asp:Label ID="msg" runat="server"></asp:Label></td>

        </tr>
        </thead><tbody>

    <asp:ListView ID="ListView1" runat="server" ItemType="niaps_ver_1._0.assetRecord" SelectMethod="GetAssetDetail">
        <ItemTemplate>
                 <tr>
                    <td>Asset Id</td><td><%#: Item.assetId %></td>

                </tr>
                 <tr>
                    <td>Asset Name</td><td><%#: Item.name %></td>

                </tr>
                 <tr>
                    <td>Date Purchased</td><td><%#: Item.datePurchased.ToShortDateString() %></td>

                </tr>
                 <tr>
                    <td>Cost</td><td><%#: Item.cost.ToString("N2", System.Globalization.CultureInfo.InvariantCulture) %></td>

                </tr>
                 <tr>
                    <td>Receiving Dept</td><td><%#: Item.receivingDept %></td>

                </tr>
                 <tr>
                    <td>Policy Number</td><td><%#: Item.policyNumber %></td>

                </tr>
                 <tr>
                    <td>Sum Insured</td><td><%#: Item.sumInsured.ToString("N2", System.Globalization.CultureInfo.InvariantCulture) %></td>

                </tr>
                <tr>
                    <td>Cover Date</td><td><%#: Item.coverDate.ToShortDateString() %></td>

                </tr>
                <tr>
                    <td>Expiry Date</td><td><%#: Item.expirydate.ToShortDateString() %></td>

                </tr>
                <tr>
                    <td>Status</td><td><%#: Item.status %></td>

                </tr>
                
        </ItemTemplate>

    </asp:ListView> 
    <tr>
                    <td>Insurer</td><td><asp:Label ID="coy" runat="server" Text=""></asp:Label></td>
                       

                </tr>
         <tr>
                    <td></td><td></td>

                </tr>
           </tbody> </table>
    
</asp:Content>
