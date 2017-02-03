<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="employmentRecDataSheetUpload.aspx.cs" Inherits="niaps_ver_1._0.employmentRecDataSheetUpload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Import" OnClick="Button1_Click"/>
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
        
    
    </div>
    </form>
</asp:Content>
