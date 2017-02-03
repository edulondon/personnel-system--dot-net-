<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user2.Master" AutoEventWireup="true" CodeBehind="updateQuestion.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.updateQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
     <form id="updateQuestion" runat="server">
        <table id="hor-minimalist-a">
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
