<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user.Master" AutoEventWireup="true" CodeBehind="leave.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.leave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
     <%--<div class="container">
<ul class="breadcrumb">
<li><a href="index.aspx">Home</a><span class="divider"></span>/</li>
    <li><a href="leave.aspx">view leave</a></li>
</ul>
         </div>--%>
  <table class="table">
                <tr><td colspan="3"><h5>Your Leave is Scheduled as follows:</h5></td>

                </tr>
                <tr><td>Id</td><td></td><td>
                    <asp:Label ID="staffid" runat="server"></asp:Label></td>

                </tr>
                <tr><td>Name</td><td></td><td>
                    <asp:Label ID="sname" runat="server"></asp:Label></td>

                </tr>
                <tr><td>Granted Leave Days</td><td></td><td>
                    <asp:Label ID="gld" runat="server" ></asp:Label></td>

                </tr>
                <tr><td></td><td></td><td>
                    <asp:Label ID="msg" runat="server" ></asp:Label></td>

                </tr>
                <tr><td>Leave Start Date</td><td></td><td>
                    <asp:Label ID="sdate" runat="server" ></asp:Label></td>

                </tr>
                <tr><td>Resumption Date</td><td></td><td>
                    <asp:Label ID="rdate" runat="server" ></asp:Label></td>

                </tr>
                <tr><td>Pending Leave</td><td></td><td>
                    <asp:Label ID="leavep" runat="server" ></asp:Label></td>

                </tr>
            </table>
</asp:Content>
