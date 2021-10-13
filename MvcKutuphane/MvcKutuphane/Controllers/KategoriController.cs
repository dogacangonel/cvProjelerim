using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index(string p)
        {
            var kategori = from k in db.TBLKATEGORI select k;
            if (!string.IsNullOrEmpty(p))
            {
                kategori = kategori.Where(x => x.AD.Contains(p) && x.DURUM==true);
            }
            return View(kategori.ToList());
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(TBLKATEGORI p)
        {
            db.TBLKATEGORI.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var deger = db.TBLKATEGORI.Find(id);
            deger.DURUM = false;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult KategoriDetay(int id)
        {
            var ktg = db.TBLKATEGORI.Find(id);
            return View("KategoriDetay", ktg);

        }

        public ActionResult KategoriGuncelle(TBLKATEGORI p)
        {
            var degerler = db.TBLKATEGORI.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}