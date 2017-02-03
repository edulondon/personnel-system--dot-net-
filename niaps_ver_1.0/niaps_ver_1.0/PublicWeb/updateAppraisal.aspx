<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user.Master" AutoEventWireup="true" CodeBehind="updateAppraisal.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.updateAppraisal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
 <%--    <div class="container">
<ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider"></span>/</li>
    <li><a href="updateAppraisal.aspx">update appraisal</a><span class="divider"></span></li>
</ul>
         </div>--%>
     <form id="reviewForm" runat="server">
        <table class="table">
            <tbody>
            <tr>
                <td colspan="3"><h4>Employee Performance Review</h4></td><td class="auto-style6">
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                
            </tr>
            <tr>
                <td class="auto-style5">Name</td><td class="auto-style4">
                    <asp:TextBox ID="sname" runat="server" Enabled="False" Width="178px"></asp:TextBox></td><td class="auto-style3"></td><td class="auto-style6"></td><td class="input-large">Id</td><td>
                        <asp:TextBox ID="stId" runat="server" Enabled="False"></asp:TextBox></td>
            </tr>
             <tr>
                <td class="auto-style5">Designation</td><td class="auto-style4">
                    <asp:TextBox ID="des" runat="server" Enabled="False" Width="181px"></asp:TextBox></td><td class="auto-style3"></td><td class="auto-style6"></td><td class="input-large">Date Joined NIA</td><td>
                        <asp:TextBox ID="jdate" runat="server" Enabled="False"></asp:TextBox></td>
            </tr>
            
                <tr>
                <td colspan="6"> <h4>Performance Questions</h4><br />
                    </td>
            </tr>
                 <tr>
                <td class="auto-style5">
                    Qualification on Entry</td><td class="auto-style4">
                    <asp:TextBox ID="qoe" runat="server" Enabled="False" Height="39px" TextMode="MultiLine" Width="230px"></asp:TextBox>
                     </td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">
                     &nbsp;</td><td>
                         &nbsp;</td>
            </tr>
                 <tr>
                <td class="auto-style5">
                    1.&nbsp; Additional Qualification after Entry</td><td class="auto-style4">
                         <asp:TextBox ID="TextBox1" runat="server" Width="233px" Height="55px" TextMode="MultiLine"></asp:TextBox>
                     </td><td class="auto-style3"></td><td class="auto-style6"></td><td class="input-large">
                     2.&nbsp; Professional Qualification</td><td>
                         <asp:TextBox ID="TextBox2" runat="server" Width="222px"></asp:TextBox>
                     </td>
            </tr>
                 <tr>
                <td class="auto-style5">
                    3.&nbsp; Training course(s) attended since joining the Association</td><td class="auto-style4">
                         <asp:TextBox ID="TextBox3" runat="server" Width="227px" Height="65px" TextMode="MultiLine"></asp:TextBox>
                     </td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">
                     4. How long have you been involved in your current Directorate/Department?</td><td>
                         <asp:TextBox ID="TextBox4" runat="server" Width="225px" Height="54px" TextMode="MultiLine"></asp:TextBox>
                     </td>
            </tr>
                 <tr>
                <td class="auto-style5">
                    5. Detail schedule of duties</td><td class="auto-style4">
                         <asp:TextBox ID="TextBox5" runat="server" Width="228px" Height="53px" TextMode="MultiLine"></asp:TextBox>
                     </td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">
                     6. Do you enjoy working in your current Directorate/Department? If No give reason(s)</td><td>
                         <asp:TextBox ID="TextBox6" runat="server" Width="226px" Height="50px" TextMode="MultiLine"></asp:TextBox>
                     </td>
            </tr>
                 <tr>
                <td class="auto-style5">
                    7. What suggestion(s) would you give to help the Management improve your performance in your current Directorate/Department?
                     </td><td class="auto-style4">
                         <asp:TextBox ID="TextBox7" runat="server" Width="228px" Height="50px" TextMode="MultiLine"></asp:TextBox>
                     </td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">
                     8. Refer to your objectives for this period. How well do you think you have performed against these objectives</td><td>
                         <asp:TextBox ID="TextBox8" runat="server" Width="218px" Height="54px" TextMode="MultiLine"></asp:TextBox>
                     </td>
            </tr>
                 <tr>
                <td class="auto-style5">
                    9. What problems have you encountered in achieving these objectives? Are there any actions the organization should take to minimize these problems in the future?</td><td class="auto-style4">
                         <asp:TextBox ID="TextBox9" runat="server" Width="228px"></asp:TextBox>
                     </td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">
                     10. What do you consider to be your main strengths?</td><td>
                         <asp:TextBox ID="TextBox10" runat="server" Width="216px"></asp:TextBox>
                     </td>
            </tr>
                 <tr>
                <td class="auto-style5">
                    11. What do you consider to be your weakness?</td><td class="auto-style4">
                         <asp:TextBox ID="TextBox11" runat="server" Width="170px"></asp:TextBox>
                     </td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">
                     12. What training and/or development do you feel you need?</td><td>
                         <asp:TextBox ID="TextBox12" runat="server" Width="226px" Height="53px" TextMode="MultiLine"></asp:TextBox>
                     </td>
            </tr>
                 <tr>
                <td class="auto-style5">
                    13. State your major achievements within the period under review</td><td class="auto-style4">
                         <asp:TextBox ID="TextBox13" runat="server" Width="231px" Height="56px" TextMode="MultiLine"></asp:TextBox>
                     </td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">
                     14. What overall performance rating best describes your performance over the period under review?</td><td>
                         <asp:TextBox ID="TextBox14" runat="server" Width="225px" Height="58px" TextMode="MultiLine"></asp:TextBox>
                     </td>
            </tr>
                 <tr>
                <td class="auto-style5">
                    15. What do you consider to be your most important tasks in the next year?</td><td class="auto-style4">
                         <asp:TextBox ID="TextBox15" runat="server" Width="170px"></asp:TextBox>
                     </td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">
                     16. Please insert any other comments below</td><td>
                         <asp:TextBox ID="TextBox16" runat="server" Width="225px" Height="59px" TextMode="MultiLine"></asp:TextBox>
                     </td>
            </tr>
                 <tr>
                <td class="auto-style5">&nbsp;</td><td style="text-align:right" class="auto-style4">
   
        <asp:Button ID="btnReview" runat="server" Text="submit" BackColor="#33CC33" BorderColor="#33CC33" OnClick="btnReview_Click"/>
                     </td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">&nbsp;</td><td>
                        &nbsp;</td>
            </tr>
                 <tr>
                <td class="auto-style5">&nbsp;</td><td style="text-align:right" class="auto-style4">
   
                     &nbsp;</td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">&nbsp;</td><td>
                        &nbsp;</td>
            </tr>
                 <tr>
                <td class="auto-style5">&nbsp;</td><td style="text-align:right" class="auto-style4">
   
                     &nbsp;</td><td class="auto-style3">&nbsp;</td><td class="auto-style6">&nbsp;</td><td class="input-large">&nbsp;</td><td>
                        &nbsp;</td>
            </tr>
                </tbody>
        </table>
   
        </form>

</asp:Content>
