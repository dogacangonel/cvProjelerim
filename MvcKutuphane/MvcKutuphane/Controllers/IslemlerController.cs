﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class IslemlerController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: Islemler
        public ActionResult Index()
        {
            var degerler = db.TBLHAREKET.Where(h => h.ISLEMDURUM == true).ToList();
            return View(degerler);
        }

    }
}