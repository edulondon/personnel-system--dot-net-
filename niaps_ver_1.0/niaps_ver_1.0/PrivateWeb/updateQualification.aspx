<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateQualification.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateQualification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .auto-style1 {
            height: 39px;
        }
        .auto-style2 {
            height: 39px;
            width: 296px;
        }
        .auto-style3 {
            width: 296px
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="createStaff" runat="server">
        <table class="table"><thead>
           <tr>
                <td colspan="6"><h5>Educational Qualification</h5>
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td></tr></thead><tbody>
            <tr>
                <td class="auto-style1">Staff Name</td><td class="auto-style2">
                    <asp:Label ID="sname" runat="server"></asp:Label>
                </td><td class="auto-style1"></td><td class="auto-style1">
                    
                    Degree</td><td class="auto-style1">
                    
                    <asp:TextBox ID="degree" runat="server" Width="159px"></asp:TextBox></td><td class="auto-style1">
                    </td>
            </tr>
            <tr>
                <td class="auto-style1">Qualification</td><td class="auto-style2">
                    <asp:TextBox ID="bq" runat="server" Width="237px"></asp:TextBox></td><td class="auto-style1">&nbsp;</td><td class="auto-style1">
                    Date Obtained</td><td class="auto-style1">
                    <asp:TextBox ID="dobt" runat="server"></asp:TextBox></td><td class="auto-style1">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style5">Institution</td><td class="auto-style3">
                    <asp:TextBox ID="inst" runat="server" Width="307px"></asp:TextBox>
                 </td><td class="auto-style7">&nbsp;</td><td class="auto-style7">&nbsp;</td><td class="auto-style9">&nbsp;</td><td class="auto-style1">
                    </td>
            </tr>
             <tr>
                <td class="auto-style5">&nbsp;</td><td class="auto-style3">
                    &nbsp;</td><td class="auto-style7" colspan="2">
                     <asp:Button ID="update" runat="server" BackColor="#33CC33" BorderColor="#0066FF" Font-Size="Large" Text="update" OnClick="update_Click"/>
                 </td><td class="auto-style9">&nbsp;</td><td class="auto-style1">
                    &nbsp;</td>
            </tr>
            </tbody>
            </table>
        </form>
</asp:Content>
