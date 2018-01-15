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
        private CategorieCompetitionDal catCompDal = new CategorieCompetitionDal();
        private CategorieTourDal catTourDal = new CategorieTourDal();
        private CategorieEpreuveDal catEpreuveDal = new CategorieEpreuveDal();
        private CategorieBalletDal catBalletDal = new CategorieBalletDal();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Competition()
        {
            ViewBag.catsComp = catCompDal.GetAll();
            ViewBag.catsTour = catTourDal.GetAll();
            ViewBag.catsEpreuve = catEpreuveDal.GetAll();
            ViewBag.catsBallet = catBalletDal.GetAll();
            return View();
        }
    }
}