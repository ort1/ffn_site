using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ffn_site.Controllers
{
    public class ProfilController : Controller
    {
        // GET: Profil
        public ActionResult Connexion()
        {
            return View();
        }

        public ActionResult Inscription()
        {
            return View();
        }
    }
}