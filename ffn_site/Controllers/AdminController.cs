using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ffn_site.Models;
using ffn_site.Models.Dal;

namespace ffn_site.Controllers
{

    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                ViewBag.profil = new ProfilDal().getProfil(HttpContext.User.Identity.Name);
            return View();
        }
    }
}