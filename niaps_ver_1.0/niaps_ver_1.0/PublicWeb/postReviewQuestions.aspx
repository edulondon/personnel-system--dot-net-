<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user2.Master" AutoEventWireup="true" CodeBehind="postReviewQuestions.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.postReviewQuestions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
     <form id="form1" runat="server">
    <table id="hor-minimalist-a">
        <tr style="width:180px; height:30px; background-color:ActiveCaption">
            <td class="auto-style1" colspan="2"><h3>Post Questions</h3>
                <asp:Label ID="msg" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td><td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Question No.</td><td>
            <asp:TextBox ID="qstno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Question</td><td>
            <asp:TextBox ID="qst" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td><td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td><td>
                <asp:Button ID="btnPost" runat="server" Text="Post" OnClick="btnPost_Click" /></td>
        </tr>
    </table>

    </form>
</asp:Content>
