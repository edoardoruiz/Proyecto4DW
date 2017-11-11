<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventario.aspx.cs" Inherits="Dw_Proyecto4.Inventario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
     <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inventario</title>
</head>
<body>
     <% Response.Write( pintarMen());%>
    <br/>
    <br/>
        
    <form id="form1" runat="server">
         <div>          

            <h3>Productos</h3>
            <table  class='table table-striped'> 
                <tr>
                    <th>Codigo</th>                    
                    <th>Descripcion</th>
                    <th>Existencia</th>
                    <th>Reservado</th>                   
                </tr>

                <% cargarxml();%>
            </table>
        </div>
    </form>
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
