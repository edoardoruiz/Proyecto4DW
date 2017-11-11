using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dw_Proyecto;

namespace Dw_Proyecto4
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string pintarMen()
        {
            NavBar nb = new NavBar();
            return nb.pintabarra(Session["usuario"], Session["nombre"], Session["tipo"], Session["cliente"]);
        }

    }
}