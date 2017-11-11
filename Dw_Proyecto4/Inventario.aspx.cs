using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Dw_Proyecto;

namespace Dw_Proyecto4
{
    public partial class Inventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string pintarMen()
        {
            NavBar nb = new NavBar();
            return nb.pintabarra(Session["usuario"], Session["nombre"], Session["tipo"], Session["cliente"]);
        }
        protected void cargarxml()
        {
            XmlDocument xDoc = new XmlDocument();
            //La ruta del documento XML permite rutas relativas 
            //respecto del ejecutable!
            xDoc.Load("http://52.225.225.180:8080/WS_Bodega/webresources/paquete.stock");
            XmlNodeList stocks = xDoc.GetElementsByTagName("stocks");
            XmlNodeList lista =
                ((XmlElement)stocks[0]).GetElementsByTagName("stock");
            foreach (XmlElement nodo in lista)
            {
                int i = 0;
                XmlNodeList comprometidas =
                nodo.GetElementsByTagName("comprometidas");
                XmlNodeList disponible =
                nodo.GetElementsByTagName("disponible");
                XmlNodeList nombre =
                nodo.GetElementsByTagName("nombre");
                XmlNodeList productId =
                nodo.GetElementsByTagName("productId");
                Response.Write("<tr>");

                Response.Write("<td>");
                Response.Write(productId[i].InnerText);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(nombre[i].InnerText);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(disponible[i].InnerText);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(comprometidas[i].InnerText);
                Response.Write("</td>");

                Response.Write("</tr>");

            }
        }
    }
}