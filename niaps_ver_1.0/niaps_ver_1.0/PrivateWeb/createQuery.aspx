<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="createQuery.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.createQuery" %>
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
            <td colspan="2"><h4>Issue Query</h4>
                <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
        </tr></thead><tbody>
          <tr>
            <td style="text-align: left" class="auto-style2">Staff Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td><td>
                <asp:DropDownList ID="sid" runat="server" AutoPostBack="True" DataSourceID="EntityDataSource1" DataTextField="lName" DataValueField="staffId" Width="219px" OnSelectedIndexChanged="sid_SelectedIndexChanged" AppendDataBoundItems="true" Height="28px">
                    <asp:ListItem>--select staff--</asp:ListItem>
                </asp:DropDownList>
                &nbsp; &nbsp;
                <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="staffRecords" Select="it.[staffId], it.[lName]">
                </asp:EntityDataSource>
                <asp:Label ID="otherNames" runat="server" ForeColor="Red" Font-Size="Medium"></asp:Label>
              </td>
        </tr>
          <tr>
            <td style="text-align: left" class="auto-style2">Nature of Query</td><td>
                <asp:TextBox ID="natuerOfQuery" runat="server" Height="75px" TextMode="MultiLine" Width="335px"></asp:TextBox>
                <asp:Label ID="nqError" runat="server" ForeColor="Red"></asp:Label>
              </td>
        </tr>
          <tr>
            <td style="text-align: left" class="auto-style2">Issued By</td><td>
                <asp:TextBox ID="issuedBy" runat="server" Width="169px"></asp:TextBox>
                <asp:Label ID="iError" runat="server" ForeColor="Red"></asp:Label>
              </td>
        </tr>
          <tr>
            <td style="text-align: left" class="auto-style3">Date Issued</td><td class="auto-style1">
                <asp:TextBox ID="dati" runat="server" CssClass="datepicker" AutoPostBack="true" OnTextChanged="dati_TextChanged"></asp:TextBox>
                <asp:Label ID="datiError" runat="server" ForeColor="Red"></asp:Label>
              </td>
        </tr>
         <tr>
            <td style="text-align: left" class="auto-style2">Status</td><td>
                <asp:DropDownList ID="status" runat="server" Font-Size="Small">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>pending</asp:ListItem>
                    <asp:ListItem>replied</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="statusError" runat="server" ForeColor="Red"></asp:Label>
             </td>
        </tr>
         <tr>
            <td style="text-align: left" class="auto-style2">&nbsp;</td><td>
                <asp:Button ID="btnSubmit" runat="server" Text="post" OnClick="btnSubmit_Click" BackColor="Lime" BorderColor="#0066FF" Font-Size="Large" Width="60px" />
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
