using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ProjeTakip.Models.DataContext;
using ProjeTakip.Models.Personel;

namespace ProjeTakip.Controllers
{
    public class GirisBilgileriController : Controller
    {
      

        private ProjeTakipDBContext db = new ProjeTakipDBContext();

        public ProjeTakipDBContext Db { get => db; set => db = value; }

      

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(PersonelBilgileri admin)
        {
            var bilgiler = Db.PersonelBilgileris.FirstOrDefault(x => x.AdSoyad == admin.AdSoyad && x.Sifre == admin.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.AdSoyad,false);
                Session["Kullanici"] = bilgiler.AdSoyad.ToString();
                return RedirectToAction("Index" ,"Home");

            }
            else
            {
                return View();
            }
          
        }

        public ActionResult CikisYap()
        {
            Session["Kullanici"] = null;
            Session.Abandon();
            return RedirectToAction("Index" );
        }
 
    }
}
