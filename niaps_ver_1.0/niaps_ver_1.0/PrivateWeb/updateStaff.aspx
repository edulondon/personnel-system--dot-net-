<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="updateStaff.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.updateStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <%--<div class="container">--%>
         <link href="../Content/style.css" rel="stylesheet" />
<%--<ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="staffList.aspx">staff list</a><span class="divider">/</span></li>
    <li><a href="updateStaff.aspx">update staff</a><span class="divider"></span></li>
</ul>
         </div>--%>
     <form id="createStaff" runat="server">
        <table class="table"><thead>
             <tr>
                <th colspan="3"> Staff Record</th><td colspan="3">
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td>
            </tr></thead><tbody>
            <tr>
                <td>Staff Id</td><td>
                    <asp:TextBox ID="stid" runat="server" Width="102px"></asp:TextBox></td><td class="auto-style4"></td><td class="auto-style3">Gender</td><td colspan="2">
                    <asp:TextBox ID="gender" runat="server" Width="71px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Last Name</td><td>
                    <asp:TextBox ID="lname" runat="server" Width="144px"></asp:TextBox></td><td class="auto-style4"></td><td class="auto-style3">Marital Status</td><td class="auto-style5">
                    <asp:TextBox ID="mstatus" runat="server" Width="104px"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>First Name</td><td>
                    <asp:TextBox ID="fname" runat="server"  Width="145px"></asp:TextBox></td><td class="auto-style4"></td><td class="auto-style3">Form of ID</td><td colspan="2">
                    <asp:TextBox ID="foid" runat="server" Width="121px"></asp:TextBox>
                 </td>
            </tr><tr>
                <td>Middle Name</td><td>
                    <asp:TextBox ID="mname" runat="server"></asp:TextBox></td><td class="auto-style4"></td><td class="auto-style3">ID Number</td><td colspan="2">
                    <asp:TextBox ID="idNumber" runat="server" Width="120px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style1">&nbsp;</td><td class="auto-style1">
                    &nbsp;</td><td class="auto-style4"></td><td class="auto-style3">&nbsp;</td><td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Date of Birth</td><td>
                    <asp:TextBox ID="dob" runat="server"></asp:TextBox></td><td class="auto-style4"></td><td class="auto-style3">Address </td><td colspan="2">
                    <asp:TextBox ID="address" runat="server" Width="355px"></asp:TextBox>
                 </td>
            </tr><tr>
                <td>Age</td><td>
                    <asp:TextBox ID="age" runat="server" Width="87px"></asp:TextBox>
                 </td><td class="auto-style4"></td><td class="auto-style3">
                    LGA</td><td class="auto-style5">
                    <asp:TextBox ID="lga" runat="server" Width="71px"></asp:TextBox>
                 &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;State</td>
                 <td>
                    <asp:TextBox ID="state" runat="server" Width="128px"></asp:TextBox>
                 </td>
            </tr><tr>
                <td>GSM</td><td>
                    <asp:TextBox ID="gsm" runat="server" Width="142px"></asp:TextBox>
                 </td><td class="auto-style4"></td><td class="auto-style3">E-mail</td><td colspan="2">
                    <asp:TextBox ID="email" runat="server" Width="199px"></asp:TextBox>
                 </td>
            </tr>
            </tbody></table>
         <table class="table"><thead>
            <tr>
                <th colspan="5">Next of Kin</th>
                   
            </tr></thead><tbody>
            <tr>
                <td>Last Name&nbsp;</td><td>
                   <asp:TextBox ID="kinLastName" runat="server" Width="149px"></asp:TextBox>
                </td><td>&nbsp;</td><td>
                    GSM</td><td class="auto-style2">
                    <asp:TextBox ID="kinGsm" runat="server" Width="147px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>First Name</td><td>
                    <asp:TextBox ID="kinFirstName" runat="server" Width="149px"></asp:TextBox>
                </td><td>&nbsp;</td><td>
                    Address</td><td class="auto-style2">
                    <asp:TextBox ID="kinAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td><td>
                    <asp:TextBox ID="kinGender" runat="server" Width="120px"></asp:TextBox>
                </td><td>&nbsp;</td><td>
                    relationship</td><td class="auto-style2">
                    <asp:TextBox ID="relationship" runat="server" Width="146px"></asp:TextBox>
                </td>
            </tr>
             </tbody>
        </table>
         <table class="table"><thead>
            <tr>
                <th colspan="6">Current Employment Record</th>
                   
            </tr></thead><tbody>
                <tr>
                <td>Designation</td><td>
                    <asp:TextBox ID="designation" runat="server" Width="167px"></asp:TextBox>
                    </td><td>
                    Department</td><td>
                    <asp:TextBox ID="dept" runat="server" Width="173px"></asp:TextBox>
                    </td><td>
                          Date Joined</td>
                    <td>
                    <asp:TextBox ID="djoined" runat="server" Width="120px"></asp:TextBox>
                    </td>
            </tr>
                <tr>
                <td>Degree</td><td>
                    <asp:TextBox ID="degree" runat="server" Width="120px"></asp:TextBox>
                     </td><td>
                         Discipline</td><td>
                    <asp:TextBox ID="disc" runat="server" Width="180px"></asp:TextBox>
                     </td><td>
                        Probation Period</td>
                    <td>
                    <asp:TextBox ID="pbp" runat="server" Width="79px" Height="20px"></asp:TextBox>
                     </td>
            </tr>
                <tr>
                <td>Date Confirmed</td><td>
                    <asp:TextBox ID="dc" runat="server" Width="120px"></asp:TextBox>
                     </td><td>
                        &nbsp;</td><td>
                        &nbsp;</td><td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
            </tr>
                <tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td>
                        &nbsp;</td><td>
                    <asp:Button ID="update" runat="server" Text="update" OnClick="update_Click" BackColor="#33CC33" BorderColor="#0066FF" Font-Bold="True" Font-Size="Larger" Width="100px"/>
                    </td><td>
                          &nbsp;</td>
                    <td>&nbsp;</td>
            </tr>
                <tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td>
                        &nbsp;</td><td>
                        &nbsp;</td><td>
                          &nbsp;</td>
                    <td>&nbsp;</td>
            </tr>
                </tbody></table>
        </form>
</asp:Content>
