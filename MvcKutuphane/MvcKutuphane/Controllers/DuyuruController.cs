using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class DuyuruController : Controller
    {
        // GET: Duyuru
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLDUYURULAR.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult DuyuruEkle()
        {
            //List<SelectListItem> list = (from item in db.TBLDUYURULAR.ToList()
            //                             select new SelectListItem
            //                             {

            //                                 Text = item.KATEGORI,
            //                                 Value = item.ID.ToString()
            //                             }).ToList();
            //ViewBag.dgr = list;
            return View();
        }

        [HttpPost]
        public ActionResult DuyuruEkle(TBLDUYURULAR p)
        {
            //var ktgList = db.TBLDUYURULAR.Where(w => w.ID == p.ID).FirstOrDefault();
            //p.ID = ktgList.ID;
            db.TBLDUYURULAR.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DuyuruDetaylar(int id)
        {
            var dgr = db.TBLDUYURULAR.Find(id);
           
            return View("Detaylar",dgr);

        }

        public ActionResult DuyuruSil(int id)
        {
            var degerlerSil = db.TBLDUYURULAR.Find(id);
            db.TBLDUYURULAR.Remove(degerlerSil);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DuyuruGuncelle(TBLDUYURULAR p)
        {
            var degerler = db.TBLDUYURULAR.Find(p.ID);
            degerler.KATEGORI = p.KATEGORI;
            degerler.ICERIK = p.ICERIK;
            degerler.TARIH = p.TARIH;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}