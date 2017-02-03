<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin2.Master" AutoEventWireup="true" CodeBehind="regAsset.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.regAsset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
    <form id="regAsset" runat="server">
        <table class="table" style="border-top: none;">
             <tr>
                <td colspan="2" style="border-top: none;"><h4>Register Asset</h4></td><td colspan="3"><asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>  
            </tr>

            <tr>
                <td style="border-top: none;">Asset Id</td><td>
                    <asp:TextBox ID="aid" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="assetError" runat="server" ForeColor="Red"></asp:Label>
                </td><td></td><td>Insurer</td><td>
                <asp:DropDownList ID="insurance" runat="server" AutoPostBack="True" DataSourceID="EntityDataSource1" DataTextField="nameOfCompany" DataValueField="insuranceCode" Font-Size="Smaller">
                </asp:DropDownList>
                <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="insuranceCompanies" Select="it.[insuranceCode], it.[nameOfCompany]">
                </asp:EntityDataSource>
                </td>
            </tr>
             <tr>
                <td>Name</td><td>
                    <asp:TextBox ID="aname" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="aError" runat="server" ForeColor="Red"></asp:Label>
                 </td><td></td><td>Insurance Policy Number</td><td>
                    <asp:TextBox ID="pnumber" runat="server" Width="200px" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="ipError" runat="server" ForeColor="Red"></asp:Label>
                 </td>
            </tr>
            <tr>
                <td>Date Purchased</td><td>
                <asp:TextBox ID="dateP" runat="server" Width="106px" CssClass="datepicker" OnTextChanged="dateP_TextChanged"></asp:TextBox>
                <asp:Label ID="dError" runat="server" ForeColor="Red"></asp:Label>
                </td><td></td><td>Sum Insured</td><td>
                    <asp:TextBox ID="sum" runat="server" Font-Size="Smaller" MaxLength="10" AutoPostBack="True" OnTextChanged="sum_TextChanged"></asp:TextBox>
                    <asp:Label ID="siError" runat="server" ForeColor="Red"></asp:Label>
                 </td>
            </tr>
            <tr>
                <td>Vendor</td><td>
                    <asp:TextBox ID="ven" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="vendorError" runat="server" ForeColor="Red"></asp:Label>
                </td><td>&nbsp;</td><td>Remark</td><td>
                    <asp:TextBox ID="remark" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="remarkError" runat="server" ForeColor="Red"></asp:Label>
                 </td>
            </tr><tr>
                <td>Receiving Dept</td><td>
                    <asp:TextBox ID="rdept" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="rdError" runat="server" ForeColor="Red"></asp:Label>
                    </td><td></td><td>Cover Date</td><td>
                <asp:TextBox ID="cdate" runat="server" Width="106px" CssClass="datepicker" AutoPostBack="True" OnTextChanged="cdate_TextChanged"></asp:TextBox>
                    <asp:Label ID="dateError" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
             <tr>
                <td class="auto-style1">Cost of Purchase</td><td class="auto-style1">
                    <asp:TextBox ID="cp" runat="server" Font-Size="Smaller" MaxLength="10" TextMode="Number" AutoPostBack="True" OnTextChanged="cp_TextChanged"></asp:TextBox>
                    <asp:Label ID="copError" runat="server" ForeColor="Red"></asp:Label>
                 </td><td class="auto-style1"></td><td>Expiry Date</td><td>
                <asp:TextBox ID="edate" runat="server" Width="106px" CssClass="datepicker" AutoPostBack="True" OnTextChanged="edate_TextChanged"></asp:TextBox>
                 <asp:Label ID="dateError2" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td></td><td class="auto-style1">Status </td><td class="auto-style1">
                    <asp:DropDownList ID="status" runat="server">
                        <asp:ListItem>-select-</asp:ListItem>
                        <asp:ListItem>active</asp:ListItem>
                        <asp:ListItem>inactive</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="statusError" runat="server" ForeColor="Red"></asp:Label>
                 </td>
            </tr><tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td></td><td>
                    <asp:Button ID="register" runat="server" Text="register" OnClick="register_Click" BackColor="#33CC33" BorderColor="#0066FF" Font-Size="Large"/>
                    </td><td>
                        &nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td></td><td></td><td></td>
            </tr>
        </table>
        </form>
    <script>
        $('.datepicker').datepicker({});
     </script>
</asp:Content>
