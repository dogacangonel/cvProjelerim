using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
using PagedList;
using PagedList.Mvc;
using MvcKutuphane.Models.Siniflarim;

namespace MvcKutuphane.Controllers
{
    [AllowAnonymous]
    public class VitrinController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: Vitrin
        [HttpGet]
        public ActionResult Index()
        {
            Class1 dgr = new Class1();
            dgr.deger1 = db.TBLKITAP.ToList();
            dgr.deger2 = db.TBLHAKKIMIZDA.ToList();

            return View(dgr);
        }

        [HttpPost]
        public ActionResult Index(TBLILETISIM p)
        {
            db.TBLILETISIM.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}