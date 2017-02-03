<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateEmpRec.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateEmpRec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="createStaff" runat="server">
  
        <table class="table"><tr><td>
        <asp:DropDownList ID="emprec" runat="server" Font-Size="Medium" AutoPostBack="True" DataSourceID="EntityDataSource1" AppendDataBoundItems="True" DataTextField="lName" DataValueField="staffId" Width="181px" OnSelectedIndexChanged="emprec_SelectedIndexChanged">
            <asp:ListItem>-select-</asp:ListItem>
            </asp:DropDownList>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="staffRecords" EntityTypeFilter="staffRecord" Select="it.[staffId], it.[lName]">
            </asp:EntityDataSource>
            </td><td>Select a staff to update he/her employment record</td><td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td><td style="text-align:right">
            &nbsp;</td><td style="text-align:match-parent">&nbsp;&nbsp&nbsp;&nbsp
                </td></tr>
           <tr><td colspan="7">
               &nbsp;</td></tr>
        
        
        </table><hr / style="resize:horizontal; border-bottom-color:blueviolet">
         
    <asp:Label ID="qdetail" runat="server"></asp:Label>
              

        </form>
</asp:Content>
