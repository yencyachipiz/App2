using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarCenterWeb.Models;
using CarCenterWeb.Controllers;
using System.Web.Mvc;

namespace CarCenterWeb.Filters
{
    public class VerificarSesion : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //obtener de la sesecion los datos de la persona logueada
            var oPersona = (PERSONAS)HttpContext.Current.Session["User"];
            //si la sesecion no exixte o no se a iniciado sesecion ...
            if (oPersona == null)
            {
                //si la peticion biene de un controlador diferente a accesoControlle, regresamos
                //al usuario a la pantalla de login
                if (filterContext.Controller is AccesoController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Acceso/Index");

                }
            }
            else
            {
                if (filterContext.Controller is AccesoController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/Index");
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }

}