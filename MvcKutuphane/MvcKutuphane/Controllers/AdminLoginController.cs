using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        // GET: AdminLogin

        [HttpGet]
        public ActionResult Login()
        {
     
            return View();
        }
        [HttpPost]
        public ActionResult Login(TBLADMIN p)
        {
            var bilgilerim = db.TBLADMIN.FirstOrDefault(f => f.KULLANICI == p.KULLANICI && f.SIFRE == p.SIFRE);
            if (bilgilerim != null)
            {
                FormsAuthentication.SetAuthCookie(bilgilerim.KULLANICI, false);
                Session["KULLANICI"] = bilgilerim.KULLANICI.ToString();
                return RedirectToAction("Index", "Kategori");
            }
            else
            {
                return View();
            }
           
        }
    }
}