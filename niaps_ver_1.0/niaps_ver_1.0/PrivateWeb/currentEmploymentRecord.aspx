<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="currentEmploymentRecord.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.currentEmploymentRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="createStaff" runat="server">
        <table class="table">
           <tr style="width:150px; height:30px; background-color:ActiveCaption">
                <td colspan="3"><h5>Employee Record</h5></td><td colspan="3">
                    <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label></td><td>
                    &nbsp;</td><td>
                    &nbsp;</td></tr>
            <tr>
                <td>Staff Id</td><td>
                    <asp:TextBox ID="sid" runat="server" ReadOnly="True"></asp:TextBox></td><td>Staff Name</td><td>
                    <asp:TextBox ID="sname" runat="server"></asp:TextBox></td><td>
                    &nbsp;</td><td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Designation</td><td>
                    <asp:DropDownList ID="designation" runat="server" DataSourceID="EntityDataSource2" DataTextField="designation" DataValueField="designation" AutoPostBack="True" Width="158px">
                    </asp:DropDownList>
                    <asp:EntityDataSource ID="EntityDataSource2" runat="server" ConnectionString="name=niapsEntities1" DefaultContainerName="niapsEntities1" EnableFlattening="False" EntitySetName="leaveDays" Select="it.[designation]" EntityTypeFilter="leaveDay">
                    </asp:EntityDataSource>

                                      </td><td>Date of employment</td><td>
                <asp:DropDownList ID="doeday" runat="server" Width="50px">
                     <asp:ListItem>day</asp:ListItem>
                    <asp:ListItem Value="1">1</asp:ListItem>
                    <asp:ListItem Value="2">2</asp:ListItem>
                    <asp:ListItem Value="3">3</asp:ListItem>
                    <asp:ListItem Value="4">4</asp:ListItem>
                    <asp:ListItem Value="5">5</asp:ListItem>
                    <asp:ListItem Value="6">6</asp:ListItem>
                    <asp:ListItem Value="7">7</asp:ListItem>
                    <asp:ListItem Value="8">8</asp:ListItem>
                    <asp:ListItem Value="9">9</asp:ListItem>
                    <asp:ListItem Value="10">10</asp:ListItem>
                    <asp:ListItem Value="11">11</asp:ListItem>
                    <asp:ListItem Value="12">12</asp:ListItem>
                    <asp:ListItem Value="13">13</asp:ListItem>
                    <asp:ListItem Value="14">14</asp:ListItem>
                    <asp:ListItem Value="15">15</asp:ListItem>
                    <asp:ListItem Value="16">16</asp:ListItem>
                    <asp:ListItem Value="17">17</asp:ListItem>
                    <asp:ListItem Value="18">18</asp:ListItem>
                    <asp:ListItem Value="19">19</asp:ListItem>
                    <asp:ListItem Value="20">20</asp:ListItem>
                    <asp:ListItem Value="21">21</asp:ListItem>
                    <asp:ListItem Value="22">22</asp:ListItem>
                    <asp:ListItem Value="23">23</asp:ListItem>
                    <asp:ListItem Value="24">24</asp:ListItem>
                    <asp:ListItem Value="25">25</asp:ListItem>
                    <asp:ListItem Value="26">26</asp:ListItem>
                    <asp:ListItem Value="27">27</asp:ListItem>
                    <asp:ListItem Value="28">28</asp:ListItem>
                    <asp:ListItem Value="29">29</asp:ListItem>
                    <asp:ListItem Value="30">30</asp:ListItem>
                    <asp:ListItem Value="31">31</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="doemonth" runat="server" Width="65px">
                     <asp:ListItem>month</asp:ListItem>
                    <asp:ListItem Value="January">January</asp:ListItem>
                    <asp:ListItem Value="February">February</asp:ListItem>
                    <asp:ListItem Value="March">March</asp:ListItem>
                    <asp:ListItem Value="April">April</asp:ListItem>
                    <asp:ListItem Value="May">May</asp:ListItem>
                    <asp:ListItem Value="June">June</asp:ListItem>
                    <asp:ListItem Value="July">July</asp:ListItem>
                    <asp:ListItem Value="August">August</asp:ListItem>
                    <asp:ListItem Value="September">September</asp:ListItem>
                    <asp:ListItem Value="October">October</asp:ListItem>
                    <asp:ListItem Value="November">November</asp:ListItem>
                    <asp:ListItem Value="December">December</asp:ListItem>
                </asp:DropDownList>
                    <asp:DropDownList ID="doeyear" runat="server" Width="50px">
                     <asp:ListItem>year</asp:ListItem>
                    <asp:ListItem Value="2020">2020</asp:ListItem>
                    <asp:ListItem Value="2019">2019</asp:ListItem>
                    <asp:ListItem Value="2018">2018</asp:ListItem>
                    <asp:ListItem Value="2017">2017</asp:ListItem>
                    <asp:ListItem Value="2016">2016</asp:ListItem>
                    <asp:ListItem Value="2015">2015</asp:ListItem>
                    <asp:ListItem Value="2014">2014</asp:ListItem>
                    <asp:ListItem Value="2013">2013</asp:ListItem>
                    <asp:ListItem Value="2012">2012</asp:ListItem>
                    <asp:ListItem Value="2011">2011</asp:ListItem>
                    <asp:ListItem Value="2010">2010</asp:ListItem>
                    <asp:ListItem Value="2009">2009</asp:ListItem>
                    <asp:ListItem Value="2008">2008</asp:ListItem>
                    <asp:ListItem Value="2007">2007</asp:ListItem>
                    <asp:ListItem Value="2006">2006</asp:ListItem>
                    <asp:ListItem Value="2005">2005</asp:ListItem>
                    <asp:ListItem Value="2004">2004</asp:ListItem>
                    <asp:ListItem Value="2003">2003</asp:ListItem>
                    <asp:ListItem Value="2002">2002</asp:ListItem>
                    <asp:ListItem Value="2001">2001</asp:ListItem>
                    <asp:ListItem Value="2000">2000</asp:ListItem>
                    <asp:ListItem Value="1999">1999</asp:ListItem>
                    <asp:ListItem Value="1998">1998</asp:ListItem>
                    <asp:ListItem Value="1997">1997</asp:ListItem>
                    <asp:ListItem Value="1996">1996</asp:ListItem>
                    <asp:ListItem Value="1995">1995</asp:ListItem>
                    <asp:ListItem Value="1994">1994</asp:ListItem>
                    <asp:ListItem Value="1993">1993</asp:ListItem>
                    <asp:ListItem Value="1992">1992</asp:ListItem>
                    <asp:ListItem Value="1991">1991</asp:ListItem>
                    <asp:ListItem Value="1990">1990</asp:ListItem>
                     <asp:ListItem Value="1989">1989</asp:ListItem>
                    <asp:ListItem Value="1998">1988</asp:ListItem>
                    <asp:ListItem Value="1987">1987</asp:ListItem>
                    <asp:ListItem Value="1986">1986</asp:ListItem>
                    <asp:ListItem Value="1985">1985</asp:ListItem>
                    <asp:ListItem Value="1984">1984</asp:ListItem>
                    <asp:ListItem Value="1983">1983</asp:ListItem>
                    <asp:ListItem Value="1982">1982</asp:ListItem>
                    <asp:ListItem Value="1981">1981</asp:ListItem>
                    <asp:ListItem Value="1980">1980</asp:ListItem>
                     <asp:ListItem Value="1979">1979</asp:ListItem>
                    <asp:ListItem Value="1978">1978</asp:ListItem>
                    <asp:ListItem Value="1977">1977</asp:ListItem>
                    <asp:ListItem Value="1976">1976</asp:ListItem>
                    <asp:ListItem Value="1975">1975</asp:ListItem>
                    <asp:ListItem Value="1974">1974</asp:ListItem>
                    <asp:ListItem Value="1993">1973</asp:ListItem>
                    <asp:ListItem Value="1972">1972</asp:ListItem>
                    <asp:ListItem Value="1971">1971</asp:ListItem>
                    <asp:ListItem Value="1970">1970</asp:ListItem>
                     <asp:ListItem Value="1969">1969</asp:ListItem>
                    <asp:ListItem Value="1968">1968</asp:ListItem>
                    <asp:ListItem Value="1967">1967</asp:ListItem>
                    <asp:ListItem Value="1966">1966</asp:ListItem>
                    <asp:ListItem Value="1965">1965</asp:ListItem>
                    <asp:ListItem Value="1964">1964</asp:ListItem>
                    <asp:ListItem Value="1963">1963</asp:ListItem>
                    <asp:ListItem Value="1962">1962</asp:ListItem>
                    <asp:ListItem Value="1961">1961</asp:ListItem>
                    <asp:ListItem Value="1960">1960</asp:ListItem>
                     <asp:ListItem Value="1959">1959</asp:ListItem>
                    <asp:ListItem Value="1958">1958</asp:ListItem>
                    <asp:ListItem Value="1957">1957</asp:ListItem>
                    <asp:ListItem Value="1956">1956</asp:ListItem>
                    <asp:ListItem Value="1955">1955</asp:ListItem>
                    <asp:ListItem Value="1954">1954</asp:ListItem>
                    <asp:ListItem Value="1953">1953</asp:ListItem>
                    <asp:ListItem Value="1952">1952</asp:ListItem>
                    <asp:ListItem Value="1951">1951</asp:ListItem>
                    <asp:ListItem Value="1950">1950</asp:ListItem>
                </asp:DropDownList>

                </td><td>
                    &nbsp;</td><td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
             <tr>
                <td>Qualification</td><td>
                    <asp:TextBox ID="qualification" runat="server"></asp:TextBox>

                                      </td><td>Degree</td><td>
                <asp:DropDownList ID="degree" runat="server" Width="142px">
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
                 </td><td>
                     &nbsp;</td><td class="auto-style1">
                     &nbsp;</td>
                 <td class="auto-style1">
                     &nbsp;</td>
                 <td class="auto-style1">
                     &nbsp;</td>
            </tr>
            <tr>
                <td>Other Qualifications</td><td>
                    Year Obtained</td><td>Department</td><td>
                    <asp:TextBox ID="dept" runat="server"></asp:TextBox>

                </td><td>
                    &nbsp;</td><td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="other" runat="server"></asp:TextBox>

                </td><td>
                    <asp:TextBox ID="year1" runat="server"></asp:TextBox>

                </td><td>Probation Period</td><td>
                <asp:DropDownList ID="pperiod" runat="server" Width="138px" OnSelectedIndexChanged="pperiod_SelectedIndexChanged">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                </asp:DropDownList>
                 </td><td>
                    &nbsp;</td><td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="other2" runat="server"></asp:TextBox>

                </td><td>
                    <asp:TextBox ID="year2" runat="server"></asp:TextBox>

                </td><td>Confirmation Date would be:</td><td>
                <asp:Label ID="confirm" runat="server"></asp:Label>
                 </td><td>
                    &nbsp;</td><td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td class="auto-style1">
                &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td><td>
                    &nbsp;</td><td>
                    <asp:Button ID="create" runat="server" Text="save and continue" OnClick="create_Click"/>
                    </td><td>&nbsp;</td><td>&nbsp;</td><td class="auto-style1">
                &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            </table>
        </form>
</asp:Content>
