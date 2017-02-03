<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateQuery.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="../Content/style.css" rel="stylesheet" /> 
  <%--  <div class="container">
<ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="createQuery.aspx">create query</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <div class = "container">
        <div class = "row-fluid">
<div class="span4">
    </div>
            

<div class="span4">
    <form id="login" runat="server">
    <table class="table">
      <thead>  <tr>
            <td colspan="2"><h4>Update Query</h4>
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
        </tr></thead><tbody>
          <tr>
            <td style="text-align: left" class="auto-style2">Staff ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td><td>
                &nbsp; &nbsp;
                <asp:Label ID="otherNames" runat="server" ForeColor="Red" Font-Size="Medium"></asp:Label>
              </td>
        </tr>
          <tr>
            <td style="text-align: left" class="auto-style2">Nature of Query</td><td>
                <asp:Label ID="natuerOfQuery" runat="server"></asp:Label>
              </td>
        </tr>
          <tr>
            <td style="text-align: left" class="auto-style2">Issued By</td><td>
                <asp:Label ID="issuedBy" runat="server"></asp:Label>
              </td>
        </tr>
          <tr>
            <td style="text-align: left" class="auto-style3">Date Issued</td><td class="auto-style1">
                <asp:Label ID="dati" runat="server"></asp:Label>
                </td>
        </tr>
          <tr>
            <td style="text-align: left" class="auto-style3">Reply</td><td class="auto-style1">
                <asp:Label ID="reply" runat="server"></asp:Label>
              </td>
        </tr>
          <tr>
            <td style="text-align: left" class="auto-style3">Disciplinary Action</td><td class="auto-style1">
                <asp:TextBox ID="actionT" runat="server" Width="242px" Height="81px" TextMode="MultiLine"></asp:TextBox>
                <asp:Label ID="aError" runat="server"></asp:Label>
              </td>
        </tr>
         <tr>
            <td style="text-align: left" class="auto-style2">Date:</td><td>
                <asp:TextBox ID="discDate" runat="server" CssClass="datepicker" AutoPostBack="True" OnTextChanged="discDate_TextChanged"></asp:TextBox>
                <asp:Label ID="daError" runat="server"></asp:Label>
             </td>
        </tr>
         <tr>
            <td style="text-align: left" class="auto-style2">&nbsp;</td><td>
                <asp:Button ID="btnSubmit" runat="server" Text="update" BackColor="Lime" BorderColor="#0066FF" Font-Size="Large" Width="60px" OnClick="btnSubmit_Click" />
             </td>
        </tr>
         <tr>
            <td style="text-align: left" class="auto-style2">
                </td><td>
                 &nbsp;</td>
        </tr></tbody>
    </table>
        </form>
    </div>
            

<div class="span4">
    </div>
            </div>
        </div>
     <script>

         $('#dati').datepicker({});
    </script>
</asp:Content>
