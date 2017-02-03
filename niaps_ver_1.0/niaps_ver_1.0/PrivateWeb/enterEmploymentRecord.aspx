<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="enterEmploymentRecord.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.enterEmploymentRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="../Content/style.css" rel="stylesheet" />
    <form id="createStaff" runat="server">
         <table class="table"><thead>
           <tr>
                <td colspan="3"><h4>Current Employee Record</h4></td><td colspan="3">
                    <asp:Label ID="ms" runat="server" ForeColor="Red"></asp:Label>
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td><td>
                    &nbsp;</td><td>
                    &nbsp;</td></tr></thead><tbody style="width:100%">
            <tr>
                <td >Staff Id No.:</td><td >
                <asp:Label ID="stid" runat="server"></asp:Label>
                </td><td >
                    Name:</td><td>
                    <asp:Label ID="staffName" runat="server"></asp:Label>
                    </td>
                <td>
                    &nbsp;</td><td >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >Designation</td><td >
                    <asp:DropDownList ID="designation" runat="server" DataSourceID="EntityDataSource2" DataTextField="designation" DataValueField="designation" Width="148px" AppendDataBoundItems="true">
                        <asp:ListItem>-select-</asp:ListItem>
                    </asp:DropDownList>
                    <asp:EntityDataSource ID="EntityDataSource2" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="leaveDays" Select="it.[designation]" EntityTypeFilter="leaveDay">
                    </asp:EntityDataSource>

                                      </td><td>Date of employment</td><td>
                <asp:TextBox ID="dtEmp" runat="server" AutoPostBack="true" CssClass="datepicker" OnTextChanged="dtEmp_TextChanged"></asp:TextBox>

                <asp:Label ID="dopError" runat="server" ForeColor="Red"></asp:Label>

                </td><td>
                    &nbsp;</td><td >
                    Department</td>
                <td >
                    <asp:TextBox ID="dept" runat="server"></asp:TextBox>

                    <asp:Label ID="deptError" runat="server" ForeColor="Red"></asp:Label>

                </td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >&nbsp;</td><td >
                    &nbsp;</td><td >Probation Period</td><td >
                <asp:DropDownList ID="pperiod" runat="server" Width="75px" AutoPostBack="True" OnSelectedIndexChanged="pperiod_SelectedIndexChanged1">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                </asp:DropDownList>

                &nbsp;months<asp:Label ID="perror" runat="server" ForeColor="#FF3300"></asp:Label>

                </td><td>
                    &nbsp;</td><td >
                    Confirmation Date</td>
                <td >
                    <asp:TextBox ID="confirm" runat="server" Enabled="False" Width="106px" ForeColor="Red"></asp:TextBox>
                 </td>
                <td >
                    &nbsp;</td>
            </tr>
            </tbody>
            </table>
        <table class="table"><thead>
           <tr>
                <td colspan="4" ><h4>Previous Employment Record</h4>
                    </td><td  colspan="6">
                    &nbsp;</td></tr></thead><tbody>
            <tr>
                <td >Company</td><td >
                    Date Joined</td><td >Date Left</td><td>
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td >
                    Post Held</td>
                <td>
                    &nbsp;</td>
                <td class="">
                    Duties</td>
                <td >
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;<asp:TextBox ID="cname" runat="server" Width="133px"></asp:TextBox></td><td class="arrangeDate">
                <asp:TextBox ID="dj1" runat="server" CssClass="datepicker" OnTextChanged="dj1_TextChanged" AutoPostBack="True"></asp:TextBox>

                                      <asp:Label ID="dj1Error" runat="server" ForeColor="Red"></asp:Label>

                                      </td><td colspan="2">

                <asp:TextBox ID="dl1" runat="server" CssClass="datepicker" AutoPostBack="True" OnTextChanged="dl1_TextChanged"></asp:TextBox>

                    <asp:Label ID="dateError" runat="server" ForeColor="Red"></asp:Label>

                </td>
                <td>
                    &nbsp;</td>
                <td  colspan="2">
                    <asp:TextBox ID="pheld" runat="server" Width="132px"></asp:TextBox></td>
                <td class="" colspan="2">
                    <asp:TextBox ID="duties" runat="server" Height="51px" TextMode="MultiLine" Width="124px"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:TextBox ID="cname0" runat="server" Width="133px"></asp:TextBox></td><td>
                <asp:TextBox ID="dj2" runat="server" CssClass="datepicker" OnTextChanged="dj2_TextChanged" AutoPostBack="True"></asp:TextBox>

                                      <asp:Label ID="dj2Error" runat="server" ForeColor="Red"></asp:Label>

                                      </td><td class="arrangeDate" colspan="2">
                    <asp:TextBox ID="dl2" runat="server" CssClass="datepicker" AutoPostBack="True" OnTextChanged="dl2_TextChanged"></asp:TextBox>

                    <asp:Label ID="dateError2" runat="server" ForeColor="Red"></asp:Label>

                </td>
                <td>
                    &nbsp;</td>
                <td  colspan="2">
                    <asp:TextBox ID="pheld0" runat="server" Width="132px"></asp:TextBox></td>
                <td class="" colspan="2">
                    <asp:TextBox ID="duties0" runat="server" Height="51px" TextMode="MultiLine" Width="124px"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:TextBox ID="cname1" runat="server" Width="133px"></asp:TextBox></td><td>
                <asp:TextBox ID="dj3" runat="server" CssClass="datepicker"></asp:TextBox>

                                      </td><td class="arrangeDate" colspan="2">
                    <asp:TextBox ID="dl3" runat="server" CssClass="datepicker" AutoPostBack="True" OnTextChanged="dl3_TextChanged"></asp:TextBox>

                    <asp:Label ID="dateError3" runat="server" ForeColor="Red"></asp:Label>

                </td>
                <td>
                    &nbsp;</td>
                <td  colspan="2">
                    <asp:TextBox ID="pheld1" runat="server" Width="132px"></asp:TextBox></td>
                <td  colspan="2">
                    <asp:TextBox ID="duties1" runat="server" Height="51px" TextMode="MultiLine" Width="124px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>&nbsp;</td><td>
                &nbsp;</td><td class="arrangeDate" colspan="2">
                    <asp:Button ID="create" runat="server" Text="save" OnClick="create_Click1" BackColor="#00CC66" BorderColor="#0066FF" Font-Size="Large"/>

                </td>
                <td>
                    &nbsp;</td>
                <td  colspan="2">
                    &nbsp;</td>
                <td  colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td><td>
                &nbsp;</td><td class="arrangeDate" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td  colspan="2">
                    &nbsp;</td>
                <td  colspan="2">
                    &nbsp;</td>
            </tr>
                        </tbody>
            </table>
       
        </form>
</asp:Content>
