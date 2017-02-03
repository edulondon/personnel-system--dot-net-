<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dateText.aspx.cs" Inherits="niaps_ver_1._0.dateText" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="Label1" runat="server"></asp:Label><br />
        Date 1:
        <asp:TextBox ID="dates" runat="server" CssClass="datepicker"></asp:TextBox>
        <asp:Label ID="error" runat="server" ForeColor="Red"></asp:Label>
        &nbsp;Date 2:&nbsp;
        <asp:TextBox ID="dates0" runat="server" CssClass="datepicker"></asp:TextBox>
        <br />
        <asp:Button ID="btnPost" runat="server" Text="Button" OnClick="btnPost_Click" />

    </div>
    </form>
      <script src="../Scripts/jquery-2.1.0.js"></script>    
    <script src="../Scripts/bootstrap.min.js"></script>
   
    
    <script src="../Scripts/bootstrap-datepicker.js"></script>

    <script>

        $('.datepicker').datepicker({});
        </script>
</body>
</html>
