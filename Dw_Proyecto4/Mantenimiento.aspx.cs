using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dw_Proyecto;
using Dw_Proyecto_3.Clases;
using System.Data;
namespace Dw_Proyecto4
{
    public partial class Mantenimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string pintarMen()
        {
            NavBar nb = new NavBar();
            return nb.pintabarra(Session["usuario"], Session["nombre"], Session["tipo"], Session["cliente"]);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion NuevaCnn = new Conexion();
                NuevaCnn.AgregarParametro("@i_operacion", System.Data.SqlDbType.Char, "I");

                NuevaCnn.AgregarParametro("@i_usuario", System.Data.SqlDbType.VarChar ,txtUsuario.Value  );
                Encriptacion en = new Encriptacion();
                NuevaCnn.AgregarParametro("@i_contraseña", System.Data.SqlDbType.VarChar, en.Encriptar(txtContraseña.Value));
                NuevaCnn.AgregarParametro("@i_nombre", System.Data.SqlDbType.VarChar, txtNombre.Value);
                NuevaCnn.AgregarParametro("@i_tipo", System.Data.SqlDbType.Int , txtTipo.Value  );
                NuevaCnn.AgregarParametro("@i_cliente", System.Data.SqlDbType.Char, txtCliente.Value);


                NuevaCnn.EstablecerSP("sp_login");
                NuevaCnn.EjecutarSP(true);
                //DataSet Tabla = NuevaCnn.getTablasRetorno();
                Response.Redirect("Inicio.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("Error " + ex.ToString());
            }
        }
    }
}