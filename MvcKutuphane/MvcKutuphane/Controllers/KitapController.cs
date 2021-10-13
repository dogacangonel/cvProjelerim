using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    
    public class KitapController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: Kitap 

        [Authorize(Roles ="A")] // Role Authentication olma yöntemi ile yetki verme
        public ActionResult Index(string p)
        {
            var kitap = from k in db.TBLKITAP select k;
            if (!string.IsNullOrEmpty(p))
            {
                kitap = kitap.Where(x => x.AD.Contains(p));
            }
            return View(kitap.ToList());
        }

        [HttpGet]
        public ActionResult KitapEkle()
        {
            List<SelectListItem> deger1 = (from ktg in db.TBLKATEGORI.ToList()
                                           select new SelectListItem
                                           {
                                               Text = ktg.AD,
                                               Value = ktg.ID.ToString()

                                           }).ToList();
            ViewBag.dgr1 = deger1;

            List<SelectListItem> deger2 = (from yzr in db.TBLYAZAR.ToList()
                                           select new SelectListItem
                                           {
                                               Text = yzr.AD +" "+ yzr.SOYAD,
                                               Value = yzr.ID.ToString()
                                           }).ToList();
           
            ViewBag.dgr2 = deger2;
            return View();
        }

        [HttpPost]
        public ActionResult KitapEkle (TBLKITAP p)
        {
            var ktg = db.TBLKATEGORI.Where(k => k.ID == p.TBLKATEGORI.ID).FirstOrDefault(); // DropDownListen gelen veriyi kaydetmek için.
            var yzr = db.TBLYAZAR.Where(y => y.ID == p.TBLYAZAR.ID).FirstOrDefault();
            p.TBLKATEGORI = ktg;
            p.TBLYAZAR = yzr;
            db.TBLKITAP.Add(p);

            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult KitapDetay(int id)
        {
            List<SelectListItem> deger1 = (from dktg in db.TBLKATEGORI
                                           select new SelectListItem
                                           {
                                               Text = dktg.AD,
                                               Value = dktg.ID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;

            List<SelectListItem> deger2 = (from dyzr in db.TBLYAZAR
                                           select new SelectListItem
                                           {
                                               Value = dyzr.ID.ToString(),
                                               Text=dyzr.AD+ " " + dyzr.SOYAD
                                           }).ToList();
            ViewBag.dgr2 = deger2;

            var ktg = db.TBLKITAP.Find(id);
            return View("KitapDetay", ktg);
        }

        public ActionResult KitapSil(int id)
        {
            var ktp = db.TBLKITAP.Find(id);
            db.TBLKITAP.Remove(ktp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       public ActionResult KitapGuncelle(TBLKITAP p)
        {
            var ktp = db.TBLKITAP.Find(p.ID);
            var ktg = db.TBLKATEGORI.Where(k => k.ID == p.TBLKATEGORI.ID).FirstOrDefault();
            var yzr = db.TBLYAZAR.Where(y => y.ID == p.TBLYAZAR.ID).FirstOrDefault();
            ktp.AD = p.AD;
            ktp.TBLYAZAR = yzr;
            ktp.TBLKATEGORI = ktg;
            ktp.BASIMYIL = p.BASIMYIL;
            ktp.YAYINEVI = p.YAYINEVI;
            ktp.SAYFA = p.SAYFA;
            ktp.DURUM = p.DURUM;// Bakalım bu durumu false yapacak mı ??
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}