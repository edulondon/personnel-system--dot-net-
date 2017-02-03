<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user.Master" AutoEventWireup="true" CodeBehind="viewQuery.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.viewQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table class="table table-striped table-hover"><thead>
       <tr><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200">S/No</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200">Nature of Query</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200">Issued By</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200">Date Issued</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200">Answer</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200">Date Answered</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200">Disciplinary Action</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown; font-weight:200">Effective Start Date</td><td></td></tr></thead>
    <tbody><asp:Label ID="queryString" runat="server"></asp:Label></tbody>
        </table>
</asp:Content>
