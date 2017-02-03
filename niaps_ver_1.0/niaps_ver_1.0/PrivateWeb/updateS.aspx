<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateS.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="createStaff" runat="server">
  
        <table class="table"><tr><td>
        <asp:DropDownList ID="filter" runat="server" Font-Size="Medium" AutoPostBack="True" DataSourceID="EntityDataSource1" AppendDataBoundItems="True" DataTextField="lName" DataValueField="staffId" OnSelectedIndexChanged="filter_SelectedIndexChanged" Width="181px">
            <asp:ListItem>-select-</asp:ListItem>
            </asp:DropDownList>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="staffRecords" EntityTypeFilter="staffRecord">
            </asp:EntityDataSource>
            </td><td>Select a staff to update he/her qulification</td><td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td><td style="text-align:right">
            &nbsp;</td><td style="text-align:match-parent">&nbsp;&nbsp&nbsp;&nbsp
                </td></tr>
           <tr><td colspan="7">
               &nbsp;</td></tr>
        
        
        </table><hr / style="resize:horizontal; border-bottom-color:blueviolet">
         
    <asp:Label ID="qdetail" runat="server"></asp:Label>
              

        </form>
</asp:Content>
