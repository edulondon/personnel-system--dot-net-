<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin2.Master" AutoEventWireup="true" CodeBehind="updateAsset.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateAsset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
  <%--  <div class="container">
<ul class="breadcrumb">
<li><a href="regAsset.aspx">Home</a><span class="divider">/</span></li>
    <li><a href="viewNiaAsset.aspx">view asset</a><span class="divider">/</span></li>
    <li><a href="updateAsset.aspx">update asset</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <form id="createStaff" runat="server">
        <table class="table"><thead>
             <tr>
                <th colspan="3">Update Asset Record
                   
                    
                    </th><th colspan="2"><asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></th>
            </tr></thead>
            <tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td></td><td>&nbsp;</td><td>
                &nbsp;</td>
            </tr>
            <tr>
                <td>Asset Id</td><td>
                    <asp:TextBox ID="aid" runat="server"></asp:TextBox></td><td></td><td>Insurance Coy</td><td>
                    <asp:DropDownList ID="ins" runat="server" DataSourceID="EntityDataSource1" DataTextField="nameOfCompany" DataValueField="insuranceCode">
                    </asp:DropDownList>
                    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="insuranceCompanies" EntityTypeFilter="insuranceCompany">
                    </asp:EntityDataSource>
                </td>
            </tr>
             <tr>
                <td>Name</td><td>
                    <asp:TextBox ID="aname" runat="server"></asp:TextBox></td><td></td><td>Policy Number</td><td>
                    <asp:TextBox ID="pnumber" runat="server" Width="200px"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>Date Purchased</td><td>
                    <asp:TextBox ID="dp" runat="server" Width="145px"></asp:TextBox></td><td></td><td>Sum Insured</td><td>
                    <asp:TextBox ID="sum" runat="server" Width="121px"></asp:TextBox>
                 </td>
            </tr><tr>
                <td>Receiving Dept</td><td>
                    <asp:TextBox ID="rdept" runat="server"></asp:TextBox></td><td></td><td>Cover Date</td><td>
                    <asp:TextBox ID="cdate" runat="server" Width="120px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style1">Cost of Purchase</td><td class="auto-style1">
                    <asp:TextBox ID="cp" runat="server" Width="121px"></asp:TextBox></td><td class="auto-style1"></td><td>Expiry Date</td><td>
                    <asp:TextBox ID="edate" runat="server" Width="119px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Remark</td><td>
                    <asp:TextBox ID="remark" runat="server"></asp:TextBox></td><td></td><td class="auto-style1">Status </td><td class="auto-style1">
                    <asp:CheckBox ID="status" runat="server" Text="de/activate" />
                 </td>
            </tr><tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td></td><td>
                    <asp:Button ID="update" runat="server" Text="update" OnClick="update_Click" BackColor="#33CC33" BorderColor="#0033CC" Font-Size="Large"/>
                    </td><td>
                     &nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td></td><td></td><td></td>
            </tr>
        </table>
        </form>
</asp:Content>
