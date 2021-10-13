using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class AyarlarController : Controller
    {
        // GET: Ayarlar
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLADMIN.ToList();
           
            return View(degerler);
        }



        [HttpPost]
        public ActionResult YeniAdmin(TBLADMIN p)
        {
            var degerler = db.TBLADMIN.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id) 
        {
            var dgr = db.TBLADMIN.Find(id);
            db.TBLADMIN.Remove(dgr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult AdminGuncelle(int id)
        {
            var dgr = db.TBLADMIN.Find(id);
            return View("AdminGuncelle",dgr);
        }

        [HttpPost]
        public ActionResult AdminGuncelle(TBLADMIN p)
        {
            var dgr = db.TBLADMIN.Find(p.ID);
            dgr.KULLANICI = p.KULLANICI;
            dgr.SIFRE = p.SIFRE;
            dgr.YETKI = p.YETKI;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}