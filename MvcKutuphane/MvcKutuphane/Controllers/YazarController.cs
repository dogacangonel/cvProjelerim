using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class YazarController : Controller
    {
        // GET: Yazar
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var list = db.TBLYAZAR.ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarEkle(TBLYAZAR p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var degerler = db.TBLYAZAR.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YazarSil(int id)
        {
            var degerler = db.TBLYAZAR.Find(id);
            db.TBLYAZAR.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YazarDetay(int id)
        {
            
            var deger = db.TBLYAZAR.Find(id);
            return View("YazarDetay",deger);
        }

        public ActionResult YazarGuncelle(TBLYAZAR p)
        {
            if (!ModelState.IsValid)
            {
                var degerID=db.TBLYAZAR.Find(p.ID);
                return View("YazarDetay",degerID);
            }
            var degerler = db.TBLYAZAR.Find(p.ID);
            degerler.AD = p.AD;
            degerler.SOYAD = p.SOYAD;
            degerler.DETAY = p.DETAY;
            db.SaveChanges();
            return RedirectToAction("Index");
        }    
        public ActionResult YazarKitaplar(int id)
        {
            var degerler = db.TBLKITAP.Where(w => w.YAZAR == id).ToList();
            var yazarAdiSoyadi = db.TBLYAZAR.Where(w => w.ID == id).Select(s => s.AD + " " + s.SOYAD).FirstOrDefault();
            ViewBag.dgr = yazarAdiSoyadi;
            return View(degerler);
        }
    }
}