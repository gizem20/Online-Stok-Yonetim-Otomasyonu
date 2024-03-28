using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_OnlineStok.Models.Siniflar;
namespace MVC_OnlineStok.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler = c.Departmans.Where(x=> x.Durum==true).ToList();
            return View(degerler);
        }
 
        [HttpGet]
        public ActionResult DepartmanEkle() 
        { 
            return View();
        }


        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            d.Durum= true;
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanSil(int id) 
        {
            var dep = c.Departmans.Find(id);
            dep.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DepartmanGetir(int id)
        {
            var dpt = c.Departmans.Find(id);
            return View("DepartmanGetir",dpt);
        }
        public ActionResult DepartmanGuncelle(Departman p)
        {
            var dept = c.Departmans.Find(p.DepartmanID);
            dept.DepartmanAd = p.DepartmanAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanDetay(int id)
        {
            var degerler = c.Personels.Where(x => x.DepartmanID == id).ToList();
            var dpt=c.Departmans.Where(x=>x.DepartmanID== id).Select(y=>y.DepartmanAd).FirstOrDefault();
            ViewBag.d = dpt;
            return View(degerler);
        }
        public ActionResult DepartmaPersonelKullanim(int id)
        {
            var degerler=c.KullanimHareketis.Where(x=> x.Personelid== id).ToList();
            var per=c.Personels.Where(x=> x.PersonelID== id).Select(y=> y.PersonelAd + "" + y.PersonelSoyad).FirstOrDefault();
            ViewBag.dpers = per;
            return View(degerler);
        }
    }
} 
