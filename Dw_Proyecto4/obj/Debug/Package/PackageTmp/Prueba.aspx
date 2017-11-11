<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="Dw_Proyecto4.Prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <script src="js/jquery.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Prueba</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </div>
    </form>
     <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.min.js"></script>
</body>
</html>
