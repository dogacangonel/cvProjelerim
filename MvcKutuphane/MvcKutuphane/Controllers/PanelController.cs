using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    [Authorize] //Controller Bazında Authorize
    public class PanelController : Controller
    {

        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: Panel
        [HttpGet]
        // [Authorize] Action Bazlı Authorize
        public ActionResult Index()
        {
            var kullanici = (string)Session["Mail"];
            //var uyeGetir = db.TBLUYELER.FirstOrDefault(x => x.MAIL == kullanici);
            var duyuru = db.TBLDUYURULAR.ToList();
            //Profil Kartı Verilerini Getirme Viebag ile taşıma işlemi...
            var d1 = db.TBLUYELER.Where(f => f.MAIL == kullanici).Select(s => s.AD).FirstOrDefault();
            var d2 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.SOYAD).FirstOrDefault();
            var d3 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.OKUL).FirstOrDefault();
            var d4 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.FOTOGRAF).FirstOrDefault();
            var d5 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.KULLANICIADI).FirstOrDefault();
            var d6 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.MAIL).FirstOrDefault();
            var d7 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.TELEFON).FirstOrDefault();
            //  var d8 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.TBLHAREKET.Count()).FirstOrDefault();
            var uyeId = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.ID).FirstOrDefault();
            var d8 = db.TBLHAREKET.Where(w => w.UYE == uyeId).Count();
            var d9 = db.TBLMESAJLAR.Where(w => w.ALICI == kullanici).Count();
            var d10 = db.TBLDUYURULAR.Count();
            

            ViewBag.d1 = d1;
            ViewBag.d2 = d2;
            ViewBag.d3 = d3;
            ViewBag.d4 = d4;
            ViewBag.d5 = d5;
            ViewBag.d6 = d6;
            ViewBag.d7 = d7;
            ViewBag.d8 = d8;
            ViewBag.d9 = d9;
            ViewBag.d10 = d10;
            return View(duyuru);
        }

        [HttpPost]
        public ActionResult Index(TBLUYELER p)
        {
            var kullanici = (string)Session["Mail"];

            var uye = db.TBLUYELER.FirstOrDefault(x => x.MAIL == kullanici);
            uye.AD = p.AD;
            uye.SOYAD = p.SOYAD;
            uye.KULLANICIADI = p.KULLANICIADI;
            uye.SIFRE = p.SIFRE;
            uye.FOTOGRAF = p.FOTOGRAF;
            uye.OKUL = p.OKUL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Kitap()
        {
            var kullanici = (string)Session["Mail"].ToString();
            var d1 = db.TBLUYELER.Where(f => f.MAIL == kullanici).Select(s => s.AD).FirstOrDefault();
            var d2 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.SOYAD).FirstOrDefault();
            var d4 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.FOTOGRAF).FirstOrDefault();

            ViewBag.d1 = d1;
            ViewBag.d2 = d2;
            ViewBag.d4 = d4;

            var degerler = db.TBLHAREKET.Where(z => z.TBLUYELER.MAIL == kullanici).ToList();
            return View(degerler);
        }

        public ActionResult Duyuru()
        {
            var kullanici = (string)Session["Mail"];
            var degerler = db.TBLDUYURULAR.ToList();
            return View(degerler);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap", "Login");
        }

        public PartialViewResult PartialProfil()
        {

            return PartialView();

        }

        public PartialViewResult PartialAyarlar()
        {
            var kullanici = (string)Session["MAIL"];
            var uyeGetir = db.TBLUYELER.Where(w=>w.MAIL==kullanici).Select(s=>s.ID).FirstOrDefault();
            var uyeBul = db.TBLUYELER.Find(uyeGetir);
            return PartialView("PartialAyarlar",uyeBul);
        }
    }
}