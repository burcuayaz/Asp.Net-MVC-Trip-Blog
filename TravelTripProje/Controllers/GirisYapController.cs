using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Contex c = new Contex();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanci == ad.Kullanci && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanci, false);
                Session["Kullanici"] = bilgiler.Kullanci.ToString();
                return RedirectToAction("Index", "admin");
            }
            else
            {
                return View();
            }
        }
            public ActionResult LogOut()
            {
                FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap", "Login");
            }

        }
    
}