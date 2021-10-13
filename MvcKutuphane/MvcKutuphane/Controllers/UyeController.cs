using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace MvcKutuphane.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index(string p1, int sayfa = 1)
        {
            var degerler = from i in db.TBLUYELER select i;
            if (!string.IsNullOrEmpty(p1))
            {
                degerler = degerler.Where(x => x.AD.Contains(p1));
            }
            return View(degerler.ToList().ToPagedList(sayfa,3));
        }

        [HttpGet]
        public ActionResult UyeEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UyeEkle(TBLUYELER p)
        {
            if (!ModelState.IsValid)
            {
                return View("UyeEkle");
            }
            db.TBLUYELER.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UyeSil(int id)
        {
            var uyeSil = db.TBLUYELER.Find(id);
            db.TBLUYELER.Remove(uyeSil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UyeDetay(int id)
        {
            var uyeId = db.TBLUYELER.Find(id);
            return View("UyeDetay", uyeId);
        }

        public ActionResult UyeGuncelle(TBLUYELER p)
        {
            var degerler = db.TBLUYELER.Find(p.ID);
            degerler.AD = p.AD;
            degerler.SOYAD = p.SOYAD;
            degerler.MAIL = p.MAIL;
            degerler.KULLANICIADI = p.KULLANICIADI;
            degerler.SIFRE = p.SIFRE;
            degerler.FOTOGRAF = p.FOTOGRAF;
            degerler.TELEFON = p.TELEFON;
            degerler.OKUL = p.OKUL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UyeGecmis(int id)
        {
            var gecmis = db.TBLHAREKET.Where(w => w.UYE == id).ToList();
            var uyeAdiSoyadi = db.TBLUYELER.Where(w => w.ID == id).Select(s => s.AD + " " + s.SOYAD).FirstOrDefault();
            ViewBag.dgr = uyeAdiSoyadi;
            return View(gecmis);
        }
    }
}