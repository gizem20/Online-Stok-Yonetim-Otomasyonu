using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_OnlineStok.Models.Siniflar;

namespace MVC_OnlineStok.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        Context c= new Context();
        public ActionResult Index()
        {
            var degerler=c.Personels.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult PersonelEkle() 
        {

            List<SelectListItem> deger1 = (from x in c.Departmans.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmanAd,
                                               Value = x.DepartmanID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult PersonelEkle(Personel p) 
        {
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult PersonelGetir(int id)
        {


            List<SelectListItem> deger1 = (from x in c.Departmans.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmanAd,
                                               Value = x.DepartmanID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;


            var prs = c.Personels.Find(id);
            return View("PersonelGetir" , prs); ;

        }
        public ActionResult PersonelGetir(Personel p) 
        {
            var prsn = c.Personels.Find(p.PersonelID);
            prsn.PersonelAd = p.PersonelAd;
            prsn.PersonelSoyad = p.PersonelSoyad;
            prsn.DepartmanID = p.DepartmanID;
            c.SaveChanges();
            return RedirectToAction("Index");   
            
        }
    }
}