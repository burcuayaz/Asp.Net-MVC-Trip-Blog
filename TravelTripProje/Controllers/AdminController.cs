using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Contex c = new Contex();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        //Sayfa yüklendiğinde boş döndür..
        [HttpGet]
        public ActionResult YeniBlog()
        {
           
            return View();
        }

        //sayfada değişiklik yapılırsa onu döndür..
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            return View();
        }
    }
}