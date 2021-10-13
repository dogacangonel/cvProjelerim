using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    [AllowAnonymous] // Proje Bazkı authorize işlemi olduğun login sayfasından muaf etmek için ekliyoruz.
    public class ErrorController : Controller
    {
        // GET: Error ve Hata kodlarına gore sayfa döndürmemi sağlayan yapı. Response özelliği ile sağlıyoruz.
        //Her kod için bir actionResult oluşturduk
        //Bu şekilde bitmiyor mesela  404 hatası için Web.config bunun için system web kısmına gidip ayar yapıyoruz.
        //Devamı Web.config de
        public ActionResult Page400()
        {
           
            Response.StatusCode = 400;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Page403()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}