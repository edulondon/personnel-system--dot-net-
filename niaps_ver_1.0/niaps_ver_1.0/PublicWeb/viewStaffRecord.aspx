<%@ Page Title="" Language="C#" MasterPageFile="~/PublicWeb/user.Master" AutoEventWireup="true" CodeBehind="viewStaffRecord.aspx.cs" Inherits="niaps_ver_1._0.PublicWeb.viewStaffRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
   <table class="table table-striped table-hover"><thead>
                <tr>
                    <td colspan="4" style="font-family:Arial; font-size:xx-large; font-style:italic; color:blue"> <asp:Image ID="Image2" runat="server" ImageUrl="~/images/Heading_personal_details.jpg" Height="19px" Width="577px" BorderStyle="None"/></td>

                </tr></thead><tbody>
    <asp:ListView ID="ListView1" runat="server" ItemType="niaps_ver_1._0.staffRecord" SelectMethod="GetStaffDetail">
        <ItemTemplate>
            
                 <tr>
                    <td></td><td>
                        
                        <asp:Image ID="Image1" runat="server" ImageUrl="<%#:Item.passport%> " Width="150px" Height="150px"/></td><td></td><td></td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Staff Id</td><td><%#: Item.staffId %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Mobile</td><td><%#: Item.mobile %></td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown"> last Name</td><td><%#: Item.lName %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">E-mail</td><td><%#: Item.email %></td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown"> First Name</td><td><%#: Item.fName %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Form of Identification</td><td><%#: Item.formOfIdentification %></td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown"> Middle Name</td><td><%#: Item.middleName %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Number</td><td><%#: Item.idNumber %></td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Gender </td><td><%#: Item.gender %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Status</td><td><%#: Item.status %></td>

                </tr>
                 
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Date of Birth</td><td><%#: DateTime.Parse(Item.dateOfBirth.ToString()).ToShortDateString() %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">LGA</td><td><%#: Item.Lga %></td>

                </tr>
                <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Age</td><td><%#: Item.age %>&nbsp;years</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">State</td><td><%#: Item.state %></td>

                </tr>
             <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Marrital Status</td><td><%#: Item.marritalStatus %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">User Name</td><td> </ItemTemplate>

    </asp:ListView> 
                        <asp:Label ID="usname" runat="server"></asp:Label></td>

                </tr>
               
                
        
        <tr>
                    <td colspan="4" style="align-content:center; font-family:Arial; font-size:xx-large; font-style:italic; color:blue">
                        <img src="../images/Heading_next_of_kin.jpg" /></td>

                </tr>
        <asp:ListView ID="nextOfKin" runat="server" ItemType="niaps_ver_1._0.staffNextOfKin" SelectMethod="getNextOfKin">
            <ItemTemplate>

                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Name</td><td><%#: Item.lname %> <%#:Item.fName%></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Gender</td><td><%#: Item.gender %></td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">GSM</td><td><%#: Item.contactMobile %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Relationship</td><td><%#: Item.relationship %></td>

                </tr>
                 <tr>
                    <td colspan="2" style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Address</td><td><%#: Item.address %></td>

                </tr>
            </ItemTemplate>

        </asp:ListView>
         <tr>
                    <td colspan="4" style="align-content:center; font-family:Arial; font-size:xx-large; font-style:italic; color:blue">
                        <img src="../images/Heading_education_qualification.jpg" /></td>

                </tr>
         <tr >
                    <td colspan="4" style="align-content:center">
                        <asp:Label ID="eq" runat="server"></asp:Label></td>

                </tr>
                <tr>
                    <td colspan="4" style="align-content:center; font-family:Arial; font-size:xx-large; font-style:italic; color:blue">
                        <img src="../images/Heading_current_employment_record.jpg" /></td>

                </tr>
        <asp:ListView ID="currentEP" runat="server" ItemType="niaps_ver_1._0.currentStaffRecord" SelectMethod="getCurrentEmployment">
            <ItemTemplate>

                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Designation</td><td><%#: Item.designation %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Department</td><td><%#: Item.department %></td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Date Joined</td><td><%#: DateTime.Parse(Item.date_Joined.ToString()).ToShortDateString() %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Qualification on Entry</td><td><%#: Item.qualification %></td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Degree</td><td><%#: Item.degree %></td><td></td><td>&nbsp;&nbsp;<br />&nbsp;&nbsp;</td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Probation Period</td><td><%#: Item.probationPeriod %> &nbsp;months</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Date of Confirmation</td><td><%#: DateTime.Parse(Item.dateOfConfirmation.ToString()).ToShortDateString() %></td>

                </tr>
            </ItemTemplate>

        </asp:ListView>
        <tr>
                    <td colspan="4" style="align-content:center; font-family:Arial; font-size:xx-large; font-style:italic; color:blue">
                        <img src="../images/Heading_employment_record.jpg" /></td>

                </tr>
         <tr >
                    <td colspan="4" style="align-content:center">
                        <asp:Label ID="per" runat="server"></asp:Label></td>

                </tr>
               
        
    <tr>
                    <td>&nbsp;</td><td>&nbsp;</td>
                       

                </tr>
           </tbody> </table>
</asp:Content>
