﻿using System;
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
        //metedo que  llama al formulario  de insercion
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        //metodo que va a guardar en la BD
        [HttpPost]
        public ActionResult Add(DominiosDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (carcenterEntities db=new carcenterEntities())
            {
                DOMINIOS oDominio = new DOMINIOS();
                oDominio.TIPO_DOMINIO = model.TipoDominio;
                oDominio.ID_DOMINIO = model.VlrDominio;
                oDominio.VLR_DOMINIO = model.VlrDominio;

                db.DOMINIOS.Add(oDominio);
                db.SaveChanges();

            }
            return Redirect(Url.Content("~Dominios/"));
            
        }

        public ActionResult Edit(string tipoDominio, string idDominio)
        {
            DominiosDTO model = new DominiosDTO();
            using (carcenterEntities db= new carcenterEntities())
            {
                DOMINIOS oDominio = db DOMINIOS.Find(tipoDominio, idDominio);
                model.TipoDominio = oDominio.TIPO_DOMINIO;
                model.IdDominio = oDominio.ID_DOMINIO;
                model.VlrDominio = oDominio.VLR_DOMINIO;
            }
            return View(model);
        }
        public ActionResult Edit(DominiosDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //editar registrar en la BD

            using(carcenterEntities db= new carcenterEntities())
            {
                DOMINIOS oDominio = db.DOMINIOS.Find(model.TipoDominio, model.IdDominio);
                oDominio.TIPO_DOMINIO = model.TipoDominio;
                oDominio.ID_DOMINIO = model.TipoDominio;
                oDominio.VLR_DOMINIO = model.VlrDominio;

                db.Entry(oDominio).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Redirect(Url.Content("~Dominio"));

        }
    }
}