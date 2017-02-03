<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user.Master" AutoEventWireup="true" CodeBehind="query.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 220px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
      <table class="table">
                <tr><td colspan="3"><h5>Please, review below query and answer to it:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></h5></td>

                </tr>
                <tr><td class="auto-style1">&nbsp;</td><td class="auto-style1">Id</td><td>
                    <asp:Label ID="staffid" runat="server"></asp:Label></td>

                </tr>
                <tr><td class="auto-style1">&nbsp;</td><td class="auto-style1">Nature of Query</td><td>
                    <asp:Label ID="nq" runat="server" ></asp:Label></td>

                </tr>
                <tr><td class="auto-style1">&nbsp;</td><td class="auto-style1">Action taken</td><td>
                    <asp:Label ID="act" runat="server" ></asp:Label></td>

                </tr>
                <tr><td class="auto-style1"></td><td class="auto-style1">Date Issued</td><td>
                    <asp:Label ID="di" runat="server" ></asp:Label></td>

                </tr>
                <tr><td class="auto-style1">&nbsp;</td><td class="auto-style1">Answer</td><td>
                    <asp:TextBox ID="ans" runat="server" Height="107px" TextMode="MultiLine" Width="348px"></asp:TextBox>
                    </td>

                </tr>
                <tr><td class="auto-style1">&nbsp;</td><td class="auto-style1">&nbsp;</td><td>
                    <asp:Button ID="answer" runat="server" Text="answer" BackColor="#33CC33" BorderColor="#0066FF" OnClick="answer_Click" />
                    </td>

                </tr>
                <tr><td class="auto-style1">&nbsp;</td><td class="auto-style1">&nbsp;</td><td>
                    &nbsp;</td>

                </tr>
            </table>
      </form>
</asp:Content>
