<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="staffDetails.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.staffDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/style.css" rel="stylesheet" />
  <%--   <div class="container">
         
<ul class="breadcrumb">
<li><a href="index.aspx">home</a><span class="divider">/</span></li>
    <li><a href="staffList.aspx">staff list</a><span class="divider">/</span></li>
    <li><a href="staffDetails.aspx">staff detail</a><span class="divider"></span></li>
</ul>
         </div>--%>
    <form id="form1" runat="server">
        
    <div class="container">
    <table class="table table-striped table-hover"><thead>
        <tr style="font-style:italic; font-size:small">
                    <th colspan="4" style="align-content:center"> <a href="staffList.aspx">click to go back</a></th>

                </tr>
                <tr>
                    <th colspan="4" style="align-content:center">
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/images/Heading_personal_details.jpg" Height="19px" Width="557px" BorderStyle="None"/></th>

                </tr></thead><tbody>
    <asp:ListView ID="ListView1" runat="server" ItemType="niaps_ver_1._0.staffRecord" SelectMethod="GetStaffDetail">
        <ItemTemplate>
            
                 <tr>
                    <td></td><td>
                        
                        <asp:Image ID="Image1" runat="server" ImageUrl="<%#:Item.passport%> " Width="120px" Height="120px"/></td><td></td><td></td>

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
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown"> Middle Name</td><td><%#: Item.middleName %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Identification Number</td><td><%#: Item.idNumber %></td>

                </tr>
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Gender </td><td><%#: Item.gender %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Status</td><td><%#: Item.status %></td>

                </tr>
                 
                 <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Date of Birth</td><td><%#: Item.dateOfBirth.ToShortDateString() %></td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">LGA</td><td><%#: Item.Lga %></td>

                </tr>
                <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Age</td><td><%#: Item.age %> years</td><td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">State</td><td><%#: Item.state %></td>

                </tr>
             <tr>
                    <td style="font-family:Arial; font-size:larger; font-style:italic; color:rosybrown">Marrital Status</td><td><%#: Item.marritalStatus %></td><td></td><td></td>

                </tr></tbody>
               
                
        </ItemTemplate>

    </asp:ListView> 
                    </table><asp:Image ID="Image3" runat="server" ImageUrl="~/images/Heading_next_of_kin.jpg" Height="19px" Width="557px"/>
        <table class="table table-striped">
            <tr>
                    <th></th>

                </tr>
        <asp:ListView ID="nextOfKin" runat="server" ItemType="niaps_ver_1._0.staffNextOfKin" SelectMethod="getNextOfKin">
            <ItemTemplate>

             <tbody>    <tr>
                    <td>Name</td><td><%#: Item.lname %> <%#:Item.fName%></td><td>Gender</td><td><%#: Item.gender %></td>

                </tr>
                 <tr>
                    <td>Relationship</td><td><%#: Item.relationship %></td><td>Address</td><td><%#: Item.address %></td>

                </tr>
                 <tr>
                    <td>GSM</td><td><%#: Item.contactMobile %></td><td> </td>

                </tr></tbody>
            </ItemTemplate>

        </asp:ListView>
        
            </table>
   <table class="table table-striped"><tbody>
         <tr>
                    <th colspan="4"><asp:Image ID="Image4" runat="server" ImageUrl="~/images/Heading_education_qualification.jpg" Height="19px" Width="557px"/></th>

                </tr>
         <tr >
                    <td colspan="4" style="align-content:center">
                        <asp:Label ID="eq" runat="server"></asp:Label>
                        <asp:Label ID="eMsg" runat="server" ForeColor="Red"></asp:Label>
                    </td>

                </tr>
       </table>
        <table class="table table-striped">
                <tr>
                    <th colspan="4"><asp:Image ID="Image5" runat="server" ImageUrl="~/images/Heading_current_employment_record.jpg" Height="19px" Width="557px"/></th>

                </tr>
        <asp:ListView ID="currentEP" runat="server" ItemType="niaps_ver_1._0.currentStaffRecord" SelectMethod="getCurrentEmployment">
            <ItemTemplate>

                 <tr>
                    <td>Designation</td><td><%#: Item.designation %></td><td>Department</td><td><%#: Item.department %></td>

                </tr>
                 <tr>
                    <td>Date Joined</td><td><%#: Item.date_Joined.ToString()%></td><td>Probation Period</td><td><%#: Item.probationPeriod %> months</td>

                </tr>
                 <tr>
                   <td>Date of Confirmation</td><td><%#: Item.dateOfConfirmation %></td> <td></td><td></td>

                </tr>
                
            </ItemTemplate>

        </asp:ListView>
            </table><asp:Image ID="Image6" runat="server" ImageUrl="~/images/Heading_employment_record.jpg" Height="19px" Width="557px"/>
        <%--<table>
        <tr>
                    <th colspan="4">Previous Employment Record</th>

                </tr>
         <tr >
                    <td colspan="4" style="align-content:center">--%>
                        <asp:Label ID="per" runat="server"></asp:Label>
                        <asp:Label ID="pMsg" runat="server" ForeColor="Red"></asp:Label>
                   <%-- </td>

                </tr>
                <tr>
                    <th>Next of Kin Details</th>

                </tr></tbody>--%><hr / style="border-bottom-width:medium; border-color:green">
        
        </div>
    
    </form>
</asp:Content>
