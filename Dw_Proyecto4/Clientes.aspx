<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Dw_Proyecto4.clientes" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <%--<link href="css/blueimp-gallery.min.css" rel="stylesheet" />--%>
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <script src="js/jquery.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Clientes</title>


</head>
<body>

    <input class="btn btn-success" type="submit" id="btn1" name="name" value="Hola" />
    <% Response.Write( pintarMen());%>

    <h2>Clientes</h2>
    <%PintarTabla(); %>>
 


    <script>
        $("#btn1").click(function () {
            //$(this).slideUp();
            alert("Hola");
        });
    </script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.min.js"></script>

</body>
</html>
