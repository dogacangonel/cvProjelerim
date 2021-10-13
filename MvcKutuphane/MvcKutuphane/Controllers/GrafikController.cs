using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models;

namespace MvcKutuphane.Controllers
{
    public class GrafikController : Controller
    {
        // GET: Grafik
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizeKitapResult()
        {
            return Json(liste(),JsonRequestBehavior.AllowGet);
        }

        public List<Class1> liste()
        {
            List<Class1> cd = new List<Class1>();
                cd.Add(new Class1() {
                    yayinEvi = "Güneş",
                    sayi = 1

                });
            cd.Add(new Class1()
            {
                yayinEvi = "Yapı Kredi",
                sayi = 10
            });
            cd.Add(new Class1()
            {
                yayinEvi = "İmge Kitapevi",
                sayi = 14
            });

            return cd;

        }

    }
}