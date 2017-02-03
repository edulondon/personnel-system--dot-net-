<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="furtherQualification.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.furtherQualification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
     <%--<div class="container">
<ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="furtherQualification.aspx">additional qualification</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <form id="createStaff" runat="server">
        <%--<table><tr><td><a href="index.aspx">Home</a>->additional qualification</td></tr></table>--%>
        <table class="table"><thead>
           <tr>
                <td colspan="5"><h5>Additional Qualification</h5>
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
                <td>&nbsp;</td></tr></thead><tbody>
            <tr>
                <td class="auto-style5">Surname</td><td class="auto-style6" colspan="4">
                    <asp:DropDownList ID="sname" runat="server" Width="122px" AutoPostBack="True" DataSourceID="EntityDataSource1" DataTextField="lName" DataValueField="staffId" OnSelectedIndexChanged="sname_SelectedIndexChanged" AppendDataBoundItems="true">
                        <asp:ListItem>--select staff--</asp:ListItem>
                    </asp:DropDownList><asp:Label ID="snameError" runat="server" ForeColor="Red"></asp:Label>
                    <asp:Label ID="otherNames" runat="server" Font-Size="Medium"></asp:Label>
                    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="staffRecords" Select="it.[lName], it.[staffId]">
                    </asp:EntityDataSource>
                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td><td style="text-align:right">
                Basic Qualification</td><td colspan="3">
                    <asp:Label ID="bq" runat="server" Font-Size="Medium"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Degree</td><td class="auto-style6">
                <asp:DropDownList ID="degree" runat="server" Width="253px">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>NCE</asp:ListItem>
                    <asp:ListItem>SSCE</asp:ListItem>
                    <asp:ListItem>OND</asp:ListItem>
                    <asp:ListItem>HND</asp:ListItem>
                    <asp:ListItem>BSc</asp:ListItem>
                    <asp:ListItem>BEd</asp:ListItem>
                    <asp:ListItem>BA</asp:ListItem>
                    <asp:ListItem>MSc</asp:ListItem>
                    <asp:ListItem>MBA</asp:ListItem>
                    <asp:ListItem>PHD</asp:ListItem>
                    <asp:ListItem>Certification</asp:ListItem>
                </asp:DropDownList>
                    <asp:Label ID="degreeError" runat="server" ForeColor="Red"></asp:Label>
                    </td><td class="auto-style7">Discipline</td><td class="auto-style3" colspan="2">
                    <asp:TextBox ID="basicQ" runat="server" Width="238px"></asp:TextBox>
                    <asp:Label ID="bqError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Date Obtained</td><td>
                    <asp:TextBox ID="dateO" runat="server" Width="155px" CssClass="datepicker" OnTextChanged="dateO_TextChanged" AutoPostBack="True"></asp:TextBox>

                <asp:Label ID="dateError" runat="server" ForeColor="Red"></asp:Label>

                </td><td class="auto-style7">Institution</td><td class="auto-style3" colspan="2">
                    <asp:TextBox ID="inst" runat="server" Width="238px"></asp:TextBox>
                    <asp:Label ID="instError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style1">
                    eg. UNILAG, UI, CCNA or ICAN</td>
            </tr>
             <tr>
                <td class="auto-style5">&nbsp;</td><td class="auto-style6">
                 &nbsp;</td><td class="auto-style7"></td><td class="auto-style3">
                    <asp:Button ID="create" runat="server" Text="save" OnClick="create_Click" BackColor="#33CC33" BorderColor="#0066FF" Font-Size="Large" Width="72px"/>
                    </td><td class="auto-style1">
                    &nbsp;</td>
                 <td class="auto-style1">
                     &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td><td class="auto-style6">
                    &nbsp;</td><td colspan="2">&nbsp;</td><td class="auto-style1">
                &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td><td class="auto-style6">
                    &nbsp;</td><td class="auto-style7">&nbsp;</td><td class="auto-style3">&nbsp;</td><td class="auto-style1">
                &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td><td class="auto-style6">
                    &nbsp;</td><td class="auto-style7">&nbsp;</td><td class="auto-style3">&nbsp;</td><td>
                &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr></tbody>
            </table>
        </form>
</asp:Content>
