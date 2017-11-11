﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Dw_Proyecto
{
    public class NavBar
    {
        public string pintabarra(object usuario = null, object nombre = null, object Tipo = null, object cliente = null)
        {

            string barra = "";

            barra = barra + " <nav class='navbar navbar-inverse navbar-fixed-top'> ";
            barra = barra + "  <div class='container'> ";
            barra = barra + "    <div class='navbar-header'> ";
            barra = barra + "     <button type='button' class='navbar-toggle collapsed' data-toggle='collapse' data-target='#navbar' aria-expanded='false' aria-controls='navbar'> ";
            barra = barra + "          <span class='sr-only'>Toggle navigation</span> ";
            barra = barra + "         <span class='icon-bar'></span> ";
            barra = barra + "           <span class='icon-bar'></span> ";
            barra = barra + "         <span class='icon-bar'></span> ";
            barra = barra + "      </button> ";
            barra = barra + "  <a class='navbar-brand' href='Inicio.aspx'>Inicio</a> ";
            barra = barra + " </div>";
            barra = barra + " <div id='navbar' class='navbar-collapse collapse'> ";
            barra = barra + "     <ul class='nav navbar-nav'> ";

            //barra = barra + "        <form action='Busqueda.aspx' class='navbar-form navbar-right'> ";
            //barra = barra + "            <input type='text' name='producto' class='form-control' placeholder='Buscar Articulo...'> ";
            //barra = barra + "             <button type='submit' class='btn btn-success'>Buscar</button> ";
            //barra = barra + "         </form> ";


            barra = barra + "        <li class='dropdown'> ";
            barra = barra + "           <a href='#' class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Clientes <span><i class='glyphicon glyphicon-leaf'></i></span><span class='caret'></span></a> ";
            barra = barra + "            <ul class='dropdown-menu'> ";
            if (Tipo.ToString() != null)
            {
                if (Tipo.ToString() == "1")
                {
                    barra = barra + "                 <li><a href='Clientes.aspx'>Clientes</a></li> ";
                }
                else
                {
                    barra = barra + "                 <li><a href='Detalles_Cliente.aspx?Cliente=" + cliente.ToString() + "'>Clientes</a></li> ";
                }
            }
            barra = barra + "              </ul>";
            barra = barra + "         </li>";
            barra = barra + "          <li class='dropdown'> ";
            barra = barra + "              <a href='#' class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>Productos <span><i class='glyphicon glyphicon-list-alt'></i></span><span class='caret'></span></a> ";
            barra = barra + "               <ul class='dropdown-menu'> ";
            barra = barra + "                   <li><a href='Inventario.aspx'>Productos</a></li> ";
            // barra = barra +  "                    <li><a href='#'>Something else here</a></li> ";
            barra = barra + "                   <li role='separator' class='divider'></li> ";
            //barra = barra +  "                   <li class='dropdown-header'>Nav header</li> ";
            //barra = barra +  "                   <li><a href='#'>Separated link</a></li> ";
            //barra = barra +  "                   <li><a href='#'>One more separated link</a></li> ";
            barra = barra + "               </ul> ";
            barra = barra + "           </li> ";
            //barra = barra +  "           <li><a href='#contact'>Mensajes <span><i class='glyphicon glyphicon-envelope'></i></span></a></li> ";

            if (Tipo.ToString() != null)
            {
                if (Tipo.ToString() == "1")
                {

                    barra = barra + "           <li><a href='Mantenimiento.aspx'>Mantenimiento <span><i class='glyphicon glyphicon-shopping-cart'></i></span></a></li> ";

                }
            }

            barra = barra + "       </ul> ";


            barra = barra + "        <ul class='nav navbar-nav navbar-right'> ";
            barra = barra + "            <li><a href='../navbar/'>Acerca de <span><i class='glyphicon glyphicon-info-sign'></i></span></a></li> ";
            barra = barra + "            <li><a href='../navbar-static-top/'><span><i class='glyphicon glyphicon-cog'></i></span></a></li> ";
            if (nombre.ToString() != null)
            {
                barra = barra + "           <li class='active'><a href='login.aspx' id='login'> " + nombre.ToString() + " <span><i class='glyphicon glyphicon-log-in'></i></span><span class='sr-only'>(current)</span></a></li> ";

            }
            else
            {
                barra = barra + "           <li class='active'><a href='login.aspx' id='login'>Login <span><i class='glyphicon glyphicon-log-in'></i></span><span class='sr-only'>(current)</span></a></li> ";
            }
            barra = barra + "       </ul> ";
            barra = barra + "   </div> ";
            barra = barra + "    <div class='navbar-header'> ";
            barra = barra + "    </div> ";
            barra = barra + "    <!--/.nav-collapse --> ";
            barra = barra + "  </div> ";
            barra = barra + " </nav> ";
            return barra;
        }
    }
}