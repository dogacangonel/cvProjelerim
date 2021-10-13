using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLPERSONEL.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult PersonelEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonelEkle(TBLPERSONEL p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var degerler = db.TBLPERSONEL.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelSil(int id)
        {
            var personelSil = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(personelSil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelDetay(int id)
        {
            var personelDetay = db.TBLPERSONEL.Find(id);
            return View("PersonelDetay", personelDetay);
        }

        public ActionResult PersonelGuncelle(TBLPERSONEL p)
        {
            var degerler = db.TBLPERSONEL.Find(p.ID);
            degerler.AD = p.AD;
            degerler.SOYAD = p.SOYAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}