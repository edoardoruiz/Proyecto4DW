<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalles_Cliente.aspx.cs" Inherits="Dw_Proyecto4.Detalles_Cliente" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <%--<link href="css/blueimp-gallery.min.css" rel="stylesheet" />--%>
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <script src="js/jquery.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Detalle Cliente</title>


</head>
<body>
    <% Response.Write( pintarMen());%>
    <br/>
    <br/>
     <br/>
    <%--<input class="btn btn-success" type="submit" id="btn1" name="name" value="Hola" />--%>

  
    <%PintarTabla(); %>
 


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
