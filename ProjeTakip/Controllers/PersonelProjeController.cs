using ProjeTakip.Models.DataContext;
using ProjeTakip.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeTakip.Controllers
{
    public class PersonelProjeController : Controller
    {
        // GET: PersonelProjeleri
        private ProjeTakipDBContext db = new ProjeTakipDBContext();

        public ActionResult Index()
        {
            var projelistele = db.PersonelProjeleris.ToList();
            return View(projelistele);
        }
        public ActionResult Create()
        {
            ViewBag.PersonelBilgileriId = new SelectList(db.PersonelBilgileris, "PersonelBilgileriId", "AdSoyad");
            return View();
        }
        [HttpPost]
        public ActionResult Create(PersonelProjeleri projeObj, int[] PersonelBilgileriId)
        {

            foreach (var x in PersonelBilgileriId)
            {
                projeObj.PersonelBilgileris.Add(db.PersonelBilgileris.Find(x));
            }
            projeObj.OlusturmaTarihi = DateTime.Now;
            db.PersonelProjeleris.Add(projeObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var projeObj = db.PersonelProjeleris.Find(id);
            return View(projeObj);
        }
        [HttpPost]

        public ActionResult Edit(PersonelProjeleri projeObj)
        {
            var projeDbObj = db.PersonelProjeleris.Find(projeObj.PersonelProjeId);
            projeDbObj.ProjeAciklama = projeObj.ProjeAciklama;
            projeDbObj.ProjeBaslik = projeObj.ProjeBaslik;
            projeDbObj.TamamlanmaOrani = projeObj.TamamlanmaOrani;
            projeDbObj.OncelikDurumu = projeObj.OncelikDurumu;
            projeDbObj.TamamlanmaTarihi = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Tamamla(int id)
        {
            var projeObj = db.PersonelProjeleris.Find(id);
            projeObj.TamamlanmaDurumu = true;
            projeObj.TamamlanmaOrani = 100;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}