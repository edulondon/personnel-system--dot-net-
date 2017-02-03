<%@ Page Title="" Language="C#" MasterPageFile="~/PrivateWeb/admin.Master" AutoEventWireup="true" CodeBehind="uploadPassport.aspx.cs" Inherits="niaps_ver_1._0.PrivateWeb.uploadPassport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../Scripts/jquery-2.1.0.min.js"></script>
    <script type="text/javascript">
        var path = null;
        $(document).ready(function () {
            $(".btn").button();
            $("#btnUpload").click(function () {
                $.post("uploadHandler.ashx", { path: path }, function (data) {
                    var d = data.split(':');
                    $("#res").html("File Name : " + d[0] + "<br/> Size: " + d[1] + "<br/> Type: " + d[2])
                });
            });

        });
        function show(e) {
         path =  e.value;
        }
    </script>
     <form id="upload" runat="server" enctype="multipart/form-data" method="post">
    <table style="border-collapse: collapse; border-spacing: 2px; empty-cells: hide; table-layout: auto; background-color: #C0C0C0; background-repeat: no-repeat">
        <tr style="width:150px; height:30px; background-color:ActiveCaption">
                <td></td><td>
                    <h3>Upload Staff Passport Photo</h3>
                    </td>
            </tr>
        <tr>
                <td>&nbsp;</td><td>
                    Select Photo</td>
            </tr>
        <tr>
                <td>Passport</td><td>
                    <asp:FileUpload ID="txtFile" runat="server" />
                    </td>
            </tr><tr>
                <td colspan="2" style="text-align:center">
                    &nbsp;<asp:Button id="btnUpload" runat="server" Text="upload" OnClick="btnUpload_Click" />
                    </td>
            </tr>
    </table>
         <div class="res"> </div>
         </form>
         </asp:Content>
