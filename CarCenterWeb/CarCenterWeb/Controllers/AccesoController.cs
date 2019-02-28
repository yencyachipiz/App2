using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarCenterWeb.Models;

namespace CarCenterWeb.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter (int user,string pwd){
            try
            {
                using(carcenterEntities db = new carcenterEntities())
                {
                    var lstPersonas = from p in db.PERSONAS
                                     where p.IDENTIFICACION == user && p.CONTRASENA == pwd
                                     select p;

                    if (lstPersonas.Count() > 0)
                    {
                        PERSONAS opersona = lstPersonas.First();
                        Session["User"] = opersona;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario o Contraseña incorrecto");
                    }
                }
            } catch (Exception ex)
            {
                return Content("error" + ex.Message);
            } 

        }

       
    }
}