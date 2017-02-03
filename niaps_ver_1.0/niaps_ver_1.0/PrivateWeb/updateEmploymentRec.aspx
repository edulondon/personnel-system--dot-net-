<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateEmploymentRec.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateEmploymentRec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 447px;
        }
        .auto-style2 {
            width: 200px;
        }
        .auto-style3 {
            width: 751px;
        }
        .auto-style4 {
            width: 628px;
        }
        .auto-style5 {
            width: 446px;
        }
        .auto-style6 {
            width: 380px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="createStaff" runat="server">
        <table class="table"><thead>
           <tr>
                <td colspan="6"><h5>Employment Record</h5>
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td></tr></thead><tbody>
            <tr>
                <td class="auto-style1">Staff Name</td><td class="auto-style2">
                    <asp:Label ID="sname" runat="server"></asp:Label>
                </td><td class="auto-style3"></td><td class="auto-style4">
                    
                    Degree</td><td class="auto-style6">
                    
                    <asp:TextBox ID="degree" runat="server" Width="159px"></asp:TextBox></td><td class="auto-style1">
                    </td>
            </tr>
            <tr>
                <td class="auto-style1">Company</td><td class="auto-style2">
                    <asp:TextBox ID="coy" runat="server" Width="257px"></asp:TextBox></td><td class="auto-style3">Start Date</td><td class="auto-style4">
                    <asp:TextBox ID="sdate" runat="server" CssClass="datepicker"></asp:TextBox></td><td class="auto-style6">
                    End Date</td><td class="auto-style1">
                    <asp:TextBox ID="edate" runat="server" CssClass="datepicker" Width="150px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td class="auto-style5">Post Held</td><td class="auto-style2">
                    <asp:TextBox ID="ph" runat="server" Width="150px"></asp:TextBox>
                 </td><td class="auto-style3">Duties</td><td class="auto-style4">
                    <asp:TextBox ID="duties" runat="server" Width="150px"></asp:TextBox>
                 </td><td class="auto-style6">&nbsp;</td><td class="auto-style1">
                    </td>
            </tr>
             <tr>
                <td class="auto-style5">&nbsp;</td><td class="auto-style2">
                    &nbsp;</td><td colspan="2">
                     <asp:Button ID="update" runat="server" BackColor="#33CC33" BorderColor="#0066FF" Font-Size="Large" Text="update" OnClick="update_Click"/>
                 </td><td class="auto-style6">&nbsp;</td><td class="auto-style1">
                    &nbsp;</td>
            </tr>
            </tbody>
            </table>
        </form>
</asp:Content>
