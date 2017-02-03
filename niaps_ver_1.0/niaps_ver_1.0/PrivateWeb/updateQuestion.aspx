<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateQuestion.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 29px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="createStaff" runat="server">
        <table id="pattern-style-a">
             <tr style="width:150px; height:30px; background-color:ActiveCaption">
                <td colspan="3"><h3>Edit Question</h3></td><td colspan="2">
                   
                    <asp:Label ID="msg" runat="server"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td>&nbsp;</td><td class="auto-style1">
                    <asp:TextBox ID="no" runat="server" Width="51px"></asp:TextBox></td><td></td><td>
                    <asp:TextBox ID="qst" runat="server" TextMode="MultiLine" Height="41px" Width="169px"></asp:TextBox></td><td>
                &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td><td class="auto-style1">
                    &nbsp;</td><td></td><td>
                    <asp:Button ID="done" runat="server" Text="done" OnClick="done_Click"/>
                    </td><td>
                     &nbsp;</td>
            </tr>
             </table>
        </form>
</asp:Content>
