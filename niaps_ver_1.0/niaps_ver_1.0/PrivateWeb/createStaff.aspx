<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="createStaff.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.createStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 41px;
        }
        .auto-style2 {
            width: 113px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="../Content/style.css" rel="stylesheet" />
     <%--<div class="container">
<ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="createStaff.aspx">create staff</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <form id="createStaff" runat="server">
        <table class="table" style="border-top: none;">
             <tr>
                <th colspan="3">Personal Details
                   
                    
                    </th><td colspan="2"><asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
                 <th>&nbsp;</th>
                 <th>&nbsp;</th>
                 <th>&nbsp;</th>
                 <th>&nbsp;</th>
            </tr>
            <tr>
                <td>Staff Id</td><td class="auto-style1">
                    <asp:TextBox ID="sid" runat="server" Width="92px" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="sidError" runat="server" ForeColor="Red"></asp:Label>
                </td><td class="auto-style2">First Name</td><td>
                    <asp:TextBox ID="fname" runat="server" Width="130px" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="fnameError" runat="server" ForeColor="Red"></asp:Label>
                </td><td class="auto-style11">
                    Middle Name</td>
                <td>
                    <asp:TextBox ID="mname" runat="server" Width="104px" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="mError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    Last Name</td>
                <td>
                    <asp:TextBox ID="lname" runat="server" Width="132px" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="lError" runat="server" ForeColor="Red"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Gender</td><td class="auto-style1">
                <asp:DropDownList ID="gender" runat="server" Width="99px" Font-Size="Smaller">
                     <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem Value="male">male</asp:ListItem>
                    <asp:ListItem Value="female">female</asp:ListItem>
                </asp:DropDownList>
                 <asp:Label ID="genderError" runat="server" ForeColor="Red"></asp:Label>
                 </td><td class="auto-style2">Email</td><td>
                    <asp:TextBox ID="email" runat="server" Width="136px" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="eError" runat="server" ForeColor="Red"></asp:Label>
                    <%--<asp:RequiredFieldValidator ID="emailRequired" runat="server" ErrorMessage="email address required" ControlToValidate="email" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="emailReg" runat="server" ErrorMessage="invalid email, e.g me@domain.com" ForeColor="Red" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>--%>
                    <asp:Label ID="emailLabel" runat="server" ForeColor="Red"></asp:Label>
                </td><td>
                    mobile</td>
                <td>
                    <asp:TextBox ID="mobile" runat="server" Width="98px" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="mobileError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    Marital Status</td>
                <td>
                <asp:DropDownList ID="ms" runat="server" Width="160px" Font-Size="Smaller">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem Value="single">single</asp:ListItem>
                    <asp:ListItem Value="married">married</asp:ListItem>
                    <asp:ListItem Value="divorced">divorced</asp:ListItem>
                    <asp:ListItem Value="widow">widow</asp:ListItem>
                    <asp:ListItem Value="widower">widower</asp:ListItem>
                </asp:DropDownList>
                    <asp:Label ID="msError" runat="server" ForeColor="Red"></asp:Label>
                 </td>
                <td>
                    &nbsp;</td>
            </tr>
             <tr>
                <td>Date of Birth</td><td class="auto-style1">
                 <asp:TextBox ID="dob" runat="server" CssClass="datepicker" AutoPostBack="True" OnTextChanged="dob_TextChanged"></asp:TextBox>
                 <asp:Label ID="dobError" runat="server" ForeColor="Red"></asp:Label>
                 </td><td class="auto-style2">Form of Id</td><td>
                <asp:DropDownList ID="foid" runat="server" Width="141px" Font-Size="Smaller">
                    <asp:ListItem Value="National Id Card">National Id Card</asp:ListItem>
                    <asp:ListItem Value="Driver's License">Drivers License</asp:ListItem>
                    <asp:ListItem Value="International Passport">International Passport</asp:ListItem>
                </asp:DropDownList>
                 </td><td>
                     Id Number</td>
                 <td>
                    <asp:TextBox ID="pid" runat="server" Width="148px" Font-Size="Smaller"></asp:TextBox>
                 </td>
                 <td>
                     Address</td>
                 <td colspan="2">
                    <asp:TextBox ID="addr" runat="server" Width="177px" Font-Size="Smaller"></asp:TextBox>
                     <asp:Label ID="addrError" runat="server" ForeColor="Red"></asp:Label>
                 </td>
            </tr>
             <tr>
                <td>State of origin</td><td class="auto-style1">
                <asp:DropDownList ID="ddState" runat="server" AutoPostBack="True" DataSourceID="EntityDataSource1" DataTextField="state1" DataValueField="stateCode" OnSelectedIndexChanged="state_SelectedIndexChanged" Width="153px" AppendDataBoundItems="true" Height="20px">
                    <asp:ListItem>-select state-</asp:ListItem>
                </asp:DropDownList>
                 <asp:Label ID="sError" runat="server" ForeColor="Red"></asp:Label>
                <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="states" Select="it.[stateCode], it.[state1]">
                </asp:EntityDataSource>
                 </td><td class="auto-style2">LGA</td><td>
                <asp:DropDownList ID="ddLga" runat="server" OnSelectedIndexChanged="lga_SelectedIndexChanged" Width="170px" Font-Size="Smaller">
                    <asp:ListItem>-select-</asp:ListItem>
                </asp:DropDownList>
                 <asp:Label ID="lgaError" runat="server" ForeColor="Red"></asp:Label>
                 </td><td>
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
                 <td>
                     User Name </td>
                 <td>
                    <asp:TextBox ID="userName" runat="server" Width="132px" Font-Size="Smaller"></asp:TextBox>
                    &nbsp;<asp:Label ID="userError" runat="server" ForeColor="Red"></asp:Label>
                 </td>
                 <td>
                     &nbsp;</td>
            </tr>
             <tr>
                <th colspan="3">Next of Kin Details
                    </th><td colspan="2">&nbsp;</td>
                 <th>&nbsp;</th>
                 <th>&nbsp;</th>
                 <th>&nbsp;</th>
                 <th>&nbsp;</th>
            </tr>
            <tr>
                <td>First Name</td><td class="auto-style1">
                    <asp:TextBox ID="kfname" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="kfnError" runat="server" ForeColor="Red"></asp:Label>
                </td><td class="auto-style2">Last Name</td><td>
                    <asp:TextBox ID="klname" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="klnError" runat="server" ForeColor="Red"></asp:Label>
                </td><td>
                    Gender</td>
                <td>
                <asp:DropDownList ID="sex" runat="server" Width="99px" Font-Size="Smaller">
                     <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem Value="male">male</asp:ListItem>
                    <asp:ListItem Value="female">female</asp:ListItem>
                </asp:DropDownList>
                    <asp:Label ID="sexError" runat="server" ForeColor="Red"></asp:Label>
                 </td>
                <td>
                    Relationship</td>
                <td>
                    <asp:TextBox ID="rel" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="relError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Address</td><td colspan="3">
                    <asp:TextBox ID="kaddr" Width="298px" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="kaddrError" runat="server" ForeColor="Red"></asp:Label>
                </td><td>
                    Phone</td>
                <td>
                    <asp:TextBox ID="phone" runat="server" Font-Size="Smaller" Width="128px"></asp:TextBox>
                    <asp:Label ID="gsmError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
               <tr>
               <th colspan="3">Educational Qualification
                    </th><td colspan="2">&nbsp;</td>
                 <th>&nbsp;</th>
                 <th>&nbsp;</th>
                 <th>&nbsp;</th>
                 <th>&nbsp;</th>
            </tr><tbody>
            <tr>
                <td>Basic Qualification</td><td class="auto-style1">
                    <asp:TextBox ID="basicQ" runat="server" Font-Size="Smaller"></asp:TextBox>
                    <asp:Label ID="bqError" runat="server" ForeColor="Red"></asp:Label>
                </td><td class="auto-style2">Degree</td><td>
                <asp:DropDownList ID="degree" runat="server" Width="97px" Font-Size="Smaller">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>NCE</asp:ListItem>
                    <asp:ListItem>SSCE</asp:ListItem>
                    <asp:ListItem>OND</asp:ListItem>
                    <asp:ListItem>HND</asp:ListItem>
                    <asp:ListItem>BSc</asp:ListItem>
                    <asp:ListItem>MSc</asp:ListItem>
                    <asp:ListItem>PHD</asp:ListItem>
                    <asp:ListItem>Certification</asp:ListItem>
                </asp:DropDownList>
                 <asp:Label ID="dgError" runat="server" ForeColor="Red"></asp:Label>
                 </td><td>
                    Date Obtained</td>
                <td class="arrangeDate">
                    <asp:TextBox ID="dop" runat="server" CssClass="datepicker" AutoPostBack="True" OnTextChanged="dop_TextChanged"></asp:TextBox>

                    <asp:Label ID="dateError" runat="server" ForeColor="Red"></asp:Label>

                </td>
                <td>
                    &nbsp;Institution</td>
                <td>
                    <asp:TextBox ID="inst" runat="server"></asp:TextBox>
                    <asp:Label ID="iError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td><td class="auto-style1">
                    &nbsp;</td><td class="auto-style2">&nbsp;</td><td style="text-align:right">
                     Passport Photo</td>
                <td colspan="2">
                    <asp:FileUpload ID="txtFile" runat="server" ForeColor="#009900" Width="242px" Font-Size="Medium" />
                     <asp:Label ID="pp" runat="server" ForeColor="Red"></asp:Label>
                 </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
                 <tr>
                <td>&nbsp;</td><td class="auto-style1">
                     &nbsp;</td><td class="auto-style2">&nbsp;</td><td>
                   
                    <asp:Button ID="create" runat="server" Text=" next " OnClick="create_Click" BackColor="#33CC33" BorderColor="#0066FF" Font-Bold="True" Font-Size="Larger" Width="100px"/>
                   
                    </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
                 <tr>
                <td>&nbsp;</td><td class="auto-style1">
                     &nbsp;</td><td class="auto-style2">&nbsp;</td><td>
                   
                     &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        </form>
    <script>
        
        $('.datepicker').datepicker({});
        </script>
</asp:Content>
