using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarCenterWeb.Models.DTOs;
using CarCenterWeb.Models;



namespace CarCenterWeb.Controllers
{
    public class DominiosController : Controller
    {
        // GET: Dominios
        public ActionResult Index()
        {
            List<DominiosDTO> LstDominios = null;
            using (carcenterEntities db = new carcenterEntities())
            {
                LstDominios = (from d in db.DOMINIOS
                               orderby d.ID_DOMINIO ascending
                               select new DominiosDTO
                               {
                                   IdDominio = d.ID_DOMINIO,
                                   TipoDominio = d.TIPO_DOMINIO,
                                   VlrDominio = d.VLR_DOMINIO,
                               }).ToList();

                return View(LstDominios);
            }
        }
    }
}