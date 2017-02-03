<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin2.Master" AutoEventWireup="true" CodeBehind="niaAssetDetails.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.niaAssetDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <%-- <div class="container">
<ul class="breadcrumb">
<li><a href="regAsset.aspx">Home</a><span class="divider">/</span></li>
    <li><a href="viewNiaAsset.aspx">view asset</a><span class="divider">/</span></li>
    <li><a href="niaAssetDetails.aspx">asset detail</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <div class="container">
    <table class="table"><thead>
                <tr>
                    <td colspan="2" style="align-content:center"><h5>Asset Details</h5></td>

                </tr></thead>
    <asp:ListView ID="ListView1" runat="server" ItemType="niaps_ver_1._0.assetRecord" SelectMethod="GetAssetDetail">
        <ItemTemplate>
            <tbody>
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
                </tbody>
        </ItemTemplate>

    </asp:ListView> <tbody>
    <tr>
                    <td>Insurer</td><td><asp:Label ID="coy" runat="server" Text=""></asp:Label></td>
                       

                </tr><tr>
                    <td></td><td></td>
                       

                </tr>
            <tr>
                    <td>&nbsp;</td><td>&nbsp;</td>
                       

                </tr>
        </tbody>
            </table>
        </div>
    
</asp:Content>
