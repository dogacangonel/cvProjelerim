using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
using System.Web.Security;

namespace MvcKutuphane.Controllers
{
    public class MesajController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: Mesaj
        public ActionResult Index()
        {
            var kullanici = (string)Session["Mail"].ToString();
            var d1 = db.TBLUYELER.Where(f => f.MAIL == kullanici).Select(s => s.AD).FirstOrDefault();
            var d2 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.SOYAD).FirstOrDefault();
            var d4 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.FOTOGRAF).FirstOrDefault();

            ViewBag.d1 = d1;
            ViewBag.d2 = d2;
            ViewBag.d4 = d4;
         
            var degerler = db.TBLMESAJLAR.Where(x => x.ALICI == kullanici).ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniMesaj()
        {
            //Layouta Kullanıcı bilgileri taşıma kısmı
            var kullanici = (string)Session["Mail"].ToString();
            var d1 = db.TBLUYELER.Where(f => f.MAIL == kullanici).Select(s => s.AD).FirstOrDefault();
            var d2 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.SOYAD).FirstOrDefault();
            var d4 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.FOTOGRAF).FirstOrDefault();

            ViewBag.d1 = d1;
            ViewBag.d2 = d2;
            ViewBag.d4 = d4;
            return View();
        }

        [HttpPost]
        public ActionResult YeniMesaj(TBLMESAJLAR p)
        {
            // Session ile mesajları listeleme 

            var kullanici = (string)Session["Mail"].ToString();
            p.GONDEREN = kullanici;
            p.TARIH = DateTime.Today;
            db.TBLMESAJLAR.Add(p);
            db.SaveChanges();
            return RedirectToAction("GidenMesaj");

        }

        public ActionResult GidenMesaj(TBLMESAJLAR p)
        {

            var kullanici = (string)Session["Mail"].ToString();
            var d1 = db.TBLUYELER.Where(f => f.MAIL == kullanici).Select(s => s.AD).FirstOrDefault();
            var d2 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.SOYAD).FirstOrDefault();
            var d4 = db.TBLUYELER.Where(w => w.MAIL == kullanici).Select(s => s.FOTOGRAF).FirstOrDefault();

            ViewBag.d1 = d1;
            ViewBag.d2 = d2;
            ViewBag.d4 = d4;

            var gidenMesaj = db.TBLMESAJLAR.Where(z => z.GONDEREN == kullanici).ToList();
            return View(gidenMesaj); 
        }
        
        public PartialViewResult PartialSideBar()
        {
            var kullanici = (string)Session["Mail"].ToString();
            var  glnSayisi= db.TBLMESAJLAR.Where(w => w.ALICI == kullanici).Count();
            ViewBag.gln = glnSayisi;

            var gdnSayisi = db.TBLMESAJLAR.Where(w => w.GONDEREN == kullanici).Count();
            ViewBag.gdn = glnSayisi;
            return PartialView();
        }

    }
}