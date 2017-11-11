<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mantenimiento.aspx.cs" Inherits="Dw_Proyecto4.Mantenimiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <script src="js/jquery.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Mantenimiento</title>
</head>
<body>
    <% Response.Write( pintarMen());%>
    <br/>
    <br/>
     <br/>
    <form id="form1" runat="server">
        <div class="panel-body">


            <div class="form-group">
                <!-- Street 1 -->
                <label for="street1_id" class="control-label">Usuario</label>
                <input type="text" class="form-control" id="txtUsuario" required="" placeholder="Usuario" runat="server">
            </div>
            <div class="form-group">
                <!-- Street 1 -->
                <label for="street1_id" class="control-label">Nombre</label>
                <input type="text" class="form-control" id="txtNombre" required="" placeholder="Nombre del Articulo" runat="server">
            </div>
            <div class="form-group">
                <!-- Street 1 -->
                <label for="street1_id" class="control-label">Contraseña</label>
                <input type="password" class="form-control" id="txtContraseña" required="" placeholder="Contraseña" runat="server">
            </div>

            <div class="form-group">
                <!-- Street 1 -->
                <label for="street1_id" class="control-label">Confirmar Contraseña</label>
                <input type="password" class="form-control" id="txtContraseña1" required="" placeholder="Confirmar" runat="server">
            </div>


            <div class="form-group">
                <!-- City-->
                <label for="city_id" class="control-label">Id Cliente</label>
                <input type="number" class="form-control" id="txtCliente" required="" placeholder="Id de Cliente" runat="server">
            </div>

            <div class="form-group">
                <!-- State Button -->
                <label for="state_id" class="control-label">Tipo</label>
                <select class="form-control" id="txtTipo" required="" runat="server">
                    <option value="1">Administrador</option>
                    <option value="2">Cliente</option>
                </select>
            </div>
            <div class="form-group">
                <!-- Submit Button -->
                <!-- <input class="btn btn-primary" type="submit"  id="btnGuardar" name="name" value="Guardar" />
                     -->
                <%--<asp:Button ID="btnGuardar" runat="server" class="btn btn-primary" OnClick="btnGuardar_Click" Text="Guardar" />--%>
                <%-- <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />--%>
                <asp:Button ID="btnGuardar" class="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </form>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.min.js"></script>
</body>
</html>
