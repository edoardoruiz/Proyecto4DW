using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Dw_Proyecto_3.Clases;
using System.Xml;
using Dw_Proyecto;
using System.Net;
using System.IO;

namespace Dw_Proyecto4
{
    public partial class Detalles_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        public string pintarMen()
        {
            NavBar nb = new NavBar();
            return nb.pintabarra(Session["usuario"], Session["nombre"], Session["tipo"], Session["cliente"]);
        }

        public void PintarTabla()
        {
            string Cliente = "";
            Cliente = Request.QueryString["Cliente"];
            if (Cliente == null)
            {
                Response.Write("<Br/>");
                Response.Write("<Br/>");
                Response.Write(" <div class='alert alert-danger' role='alert'>");
                Response.Write(" <h3><span class='glyphicon glyphicon-exclamation-sign' aria-hidden='true'></span>");
                Response.Write(" Debe Seleccionar un cliente </h3>");
                Response.Write("</div>");
                /*
                 <div class="alert alert-danger" role="alert">
  <span class='glyphicon glyphicon-exclamation-sign' aria-hidden='true'></span>
  <span class=sr-only'>Error:</span>
  Debe Seleccionar un cliente
</div>
                 */
            }
            else
            {

                Conexion NuevaCnn = new Conexion();
                NuevaCnn.AgregarParametro("Operacion", System.Data.SqlDbType.Char, "F");
                NuevaCnn.AgregarParametro("i_cliente", System.Data.SqlDbType.Int, Cliente);
                NuevaCnn.EstablecerSP("sp_clientes");
                NuevaCnn.EjecutarSP(true);
                DataSet Tabla = NuevaCnn.getTablasRetorno();

                if (Tabla.Tables.Count > 0)
                {
                    if (Tabla.Tables[0].Rows.Count > 0)
                    {
                        Response.Write("<div class='table-responsive'>");
                        Response.Write("<table class='table table-striped'>");
                        Response.Write("<thead>");
                        Response.Write("<tr>");
                        for (int i = 0; i < Tabla.Tables[0].Columns.Count; i++)
                        {
                            Response.Write("<th> " + Tabla.Tables[0].Columns[i].ColumnName + " </th>");
                        }


                        Response.Write("</tr>");
                        Response.Write(" </thead>");
                        Response.Write(" <tbody>");

                        for (int i = 0; i < Tabla.Tables[0].Rows.Count; i++)
                        {
                            Response.Write("<tr>");
                            for (int j = 0; j < Tabla.Tables[0].Columns.Count; j++)
                            {
                                Response.Write("<td>");
                                if (j == 99)
                                {
                                    Response.Write("<a class='btn btn-sm btn-primary' runat='server' href='ProductoDetalle.aspx?Producto=" + Tabla.Tables[0].Rows[i][j].ToString() + "'>");
                                    Response.Write(Tabla.Tables[0].Rows[i][j].ToString());
                                    Response.Write("</a>");

                                }
                                else
                                {
                                    Response.Write(Tabla.Tables[0].Rows[i][j].ToString());
                                }

                                Response.Write("</td>");
                            }
                            Response.Write("</tr>");
                        }
                    }
                }
                Response.Write("</tbody>");
                Response.Write("</table>");
            }
        }

    }
}