using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();  
        public ActionResult Index()
        {
            //İstatikler Bolumu widget kartları

            //Toplam Üye Sayısı
            var deger1 = db.TBLUYELER.Count();
            ViewBag.dgr1 = deger1;

            //Kitap sayısı
            var deger2 = db.TBLKITAP.Count();
            ViewBag.dgr2 = deger2;

            //Emanet sayısı
            var deger3 = db.TBLKITAP.Where(x => x.DURUM == false).Count();
            ViewBag.dgr3 = deger3;

            //Kasa Tutarını Çekme
            var deger4 = db.TBLCEZALAR.Sum(x=>x.PARA);
            ViewBag.dgr4 = deger4;
            return View();


        }


        //Hava Durumu Index

        public ActionResult Hava()
        {
            return View();
        }

        public ActionResult HavaKart()
        {
            return View();
        }

        public ActionResult Galeri()
        {
            return View();
        }


        //Fotoğraf Upload Etme
        [HttpPost]
        public ActionResult Dosya(HttpPostedFileBase dosya)
        {
            if (dosya.ContentLength > 0)
            {
                string dosyaYolu = Path.Combine(Server.MapPath("~/web2/resimler"), Path.GetFileName(dosya.FileName));
                dosya.SaveAs(dosyaYolu);
                
            }
            return RedirectToAction("Galeri");
        }

        // Linq Kartlar Sayfası Widget Kart İşlemleri
        public ActionResult LinqKart()
        {
            //Widget Kitap Sayısı
            var kitapSayisi = db.TBLKITAP.Count();
            ViewBag.ktpSayisi = kitapSayisi;

            //Widget Kullanıcı sayısı
            var kullaniciSayisi = db.TBLUYELER.Count();
            ViewBag.kllSayisi = kullaniciSayisi;

            //Kasa Tutarı
            var kasaToplam = db.TBLCEZALAR.Sum(p => p.PARA);
            ViewBag.ktoplam = kasaToplam;

            //Oduncte Bulunan Kitap Sayısı
            var oduncToplam = db.TBLHAREKET.Where(o=>o.ISLEMDURUM==false).Count();
            ViewBag.oToplam = oduncToplam;

            //Kategori Sayısı
            var kategoriSayisi = db.TBLKATEGORI.Count();
            ViewBag.ktgSayisi = kategoriSayisi;

            //En fazla kitabı olan yazar
            var enFazlaktp = db.ENFAZLAKITAPYAZAR().FirstOrDefault();
            ViewBag.enFazlaktp = enFazlaktp;

            //En fazla kitabı olan yayın evi
            var enFazlaYayinEv = (db.TBLKITAP.GroupBy(y => y.YAYINEVI).OrderByDescending(z=>z.Count()).Select(k=>k.Key).FirstOrDefault()).ToString();
            ViewBag.enFazlaYayin = enFazlaYayinEv;

            //En Aktif Üye
            var enAktifUye = db.TBLHAREKET.GroupBy(u=>u.UYE).OrderByDescending(z=>z.Count()).SelectMany(x=>db.TBLUYELER.Where(t=>t.ID==x.Key),(t,x)=>new
            {
                adSoyad = x.AD + " " + x.SOYAD            
            }).Select(a=>a.adSoyad).FirstOrDefault();

            ViewBag.enAktif = enAktifUye.ToString();

            //En Başarılı Personel
            var enBasarili = db.TBLHAREKET.GroupBy(g => g.PERSONEL).OrderByDescending(o=>o.Count()).SelectMany(x => db.TBLPERSONEL.Where(y => y.ID == x.Key), (x, y) => new
            {
                adSoyad = y.AD +" "+ y.SOYAD
            }).Select(s=>s.adSoyad).FirstOrDefault();

            ViewBag.enBasarili = enBasarili;

            //En Çok Okunan Kitap
            var EnCokKitap = db.TBLHAREKET.GroupBy(g => g.KITAP).OrderByDescending(o=>o.Count()).SelectMany(x => db.TBLKITAP.Where(y => y.ID == x.Key), (x, y) => new
            {
                ad = y.AD
            }).Select(s=>s.ad).FirstOrDefault();
            ViewBag.enOkunanKitap = EnCokKitap;

            //Toplam Mesaj Sayısı
            var toplamMesaj = db.TBLILETISIM.Count();
            ViewBag.toplamMesaj = toplamMesaj;
            

            //Bugün Verilen Emanetler
            var emanetVer = db.TBLHAREKET.Where(x => x.ALISTARIHI == DateTime.Today).Count();
            ViewBag.emanetVer = emanetVer;

            return View();
        }
    }
}