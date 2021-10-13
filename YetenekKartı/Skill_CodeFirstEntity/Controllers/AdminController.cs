using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skill_CodeFirstEntity.Models.Classes;

namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        CONTEXT c = new CONTEXT();
        public ActionResult Index()
        {
            var degerler = c.YETENEKLERS.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniYetenek()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(YETENEKLER y)
        {
            c.YETENEKLERS.Add(y);
            c.SaveChanges();
            return View();
        }

        public ActionResult YetenekSil(int id)
        {
            var degerler = c.YETENEKLERS.Find(id);
            c.YETENEKLERS.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var degerler = c.YETENEKLERS.Find(id);
            return View("YetenekGetir", degerler);
            
        }

        [HttpPost]
        public ActionResult YetenekGetir(YETENEKLER y)
        {
            var degerler = c.YETENEKLERS.Find(y.ID);
            degerler.ACIKLAMA = y.ACIKLAMA;
            degerler.DEGER = y.DEGER;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}