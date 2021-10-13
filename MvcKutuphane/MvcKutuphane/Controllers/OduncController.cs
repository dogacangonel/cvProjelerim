using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class OduncController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: Odunc
        public ActionResult Index()
        {
            var degerler = db.TBLHAREKET.Where(h => h.ISLEMDURUM == false).ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult OduncVer()
        {
            List<SelectListItem> deger1 = (from item in db.TBLUYELER.ToList()
                                           select new SelectListItem
                                           {
                                               Text = item.AD + " " + item.SOYAD,
                                               Value = item.ID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;

            List<SelectListItem> deger2 = (from item2 in db.TBLKITAP.Where(w=>w.DURUM==true).ToList()
                                           select new SelectListItem
                                           {

                                               Text = item2.AD,
                                               Value = item2.ID.ToString()

                                           }).ToList();
            ViewBag.dgr2 = deger2;

            List<SelectListItem> deger3 = (from item3 in db.TBLPERSONEL.ToList()
                                           select new SelectListItem
                                           {

                                               Text = item3.AD + " " + item3.SOYAD,
                                               Value = item3.ID.ToString()

                                           }).ToList();
            ViewBag.dgr3 = deger3;
            return View();
        }

        [HttpPost]
        public ActionResult OduncVer(TBLHAREKET p)
        {
            var dgr1 = db.TBLUYELER.Where(w => w.ID == p.TBLUYELER.ID).FirstOrDefault(); // Bu 3 ifade dropdownlist gelen ilk veya varsayılan değeri getirmek için
            var dgr2 = db.TBLKITAP.Where(w => w.ID == p.TBLKITAP.ID).FirstOrDefault();   // yok bu ilişkili alanlara boş değer atıyor.
            var dgr3 = db.TBLPERSONEL.Where(w => w.ID == p.TBLPERSONEL.ID).FirstOrDefault();
            p.TBLUYELER = dgr1;
            p.TBLKITAP = dgr2;
            p.TBLPERSONEL = dgr3;
            var degerler = db.TBLHAREKET.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult OduncDetay(TBLHAREKET p)
        {
            var detayId = db.TBLHAREKET.Find(p.ID);
            DateTime dt = DateTime.Parse(detayId.IADETARIHI.ToString());
            DateTime dt2 = Convert.ToDateTime(DateTime.Now.ToShortDateString().ToString());
            TimeSpan ts = dt2 - dt;
            ViewBag.dgr = ts.TotalDays;

            return View("OduncDetay", detayId);
        }

        public ActionResult OduncGuncelle(TBLHAREKET p)
        {
            var hrk = db.TBLHAREKET.Find(p.ID);
            hrk.UYEGETIRTARIHI = p.UYEGETIRTARIHI;
            hrk.ISLEMDURUM = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}