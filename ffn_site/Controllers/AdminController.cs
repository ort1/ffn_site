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
        // Catégories
        private CategorieCompetitionDal catCompDal = new CategorieCompetitionDal();
        private CategorieTourDal catTourDal = new CategorieTourDal();
        private CategorieEpreuveDal catEpreuveDal = new CategorieEpreuveDal();
        private CategorieBalletDal catBalletDal = new CategorieBalletDal();
        
        // Profiles
        private ProfilDal profilDal = new ProfilDal();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        #region Management des catégories
        // GET
        public ActionResult Competition()
        {
            ViewBag.catsComp = catCompDal.GetAll();
            ViewBag.catsTour = catTourDal.GetAll();
            ViewBag.catsEpreuve = catEpreuveDal.GetAll();
            ViewBag.catsBallet = catBalletDal.GetAll();
            return View();
        }

        public ActionResult DeleteCatCompetition(int id = -1)
        {
            if (id != -1)
                catCompDal.Delete(id);
            else
                ModelState.AddModelError("Catégorie de compétitions", "Catégorie introuvable.");
            return RedirectToAction("Competition", "Admin");
        }

        public ActionResult DeleteCatTour(int id = -1)
        {
            if (id != -1)
                catTourDal.Delete(id);
            else
                ModelState.AddModelError("Catégorie de tours", "Catégorie introuvable.");
            return RedirectToAction("Competition", "Admin");
        }

        public ActionResult DeleteCatEpreuve(int id = -1)
        {
            if (id != -1)
                catEpreuveDal.Delete(id);
            else
                ModelState.AddModelError("Catégorie d'épreuves", "Catégorie introuvable.");
            return RedirectToAction("Competition", "Admin");
        }

        public ActionResult DeleteCatBallet(int id = -1)
        {
            if (id != -1)
                catBalletDal.Delete(id);
            else
                ModelState.AddModelError("Catégorie de ballets", "Catégorie introuvable.");
            return RedirectToAction("Competition", "Admin");
        }

        // POST
        [HttpPost]
        public ActionResult UpdateCatCompetition(CategorieCompetition catComp)
        {
            if (catComp != null)
                catCompDal.Update(catComp);
            else
                ModelState.AddModelError("Catégorie de compétitions", "Catégorie introuvable.");
            return Redirect("Competition");
        }

        [HttpPost]
        public ActionResult AddCatCompetition(CategorieCompetition catComp)
        {
            if (catComp != null)
                catCompDal.Add(catComp);
            else
                ModelState.AddModelError("Catégorie de compétitions", "Catégorie introuvable.");
            return Redirect("Competition");
        }

        [HttpPost]
        public ActionResult UpdateCatTour(CategorieTour catTour)
        {
            if (catTour != null)
                catTourDal.Update(catTour);
            else
                ModelState.AddModelError("Catégorie de tours", "Catégorie introuvable.");
            return Redirect("Competition");
        }

        [HttpPost]
        public ActionResult AddCatTour(CategorieTour catTour)
        {
            if (catTour != null)
                catTourDal.Add(catTour);
            else
                ModelState.AddModelError("Catégorie de tours", "Catégorie introuvable.");
            return Redirect("Competition");
        }

        [HttpPost]
        public ActionResult UpdateCatEpreuve(CategorieEpreuve catEpreuve)
        {
            if (catEpreuve != null)
                catEpreuveDal.Update(catEpreuve);
            else
                ModelState.AddModelError("Catégorie d'épreuves", "Catégorie introuvable.");
            return Redirect("Competition");
        }

        [HttpPost]
        public ActionResult AddCatEpreuve(CategorieEpreuve catEpreuve)
        {
            if (catEpreuve != null)
                catEpreuveDal.Add(catEpreuve);
            else
                ModelState.AddModelError("Catégorie d'épreuves", "Catégorie introuvable.");
            return Redirect("Competition");
        }

        [HttpPost]
        public ActionResult UpdateCatBallet(CategorieBallet catBallet)
        {
            if (catBallet != null)
                catBalletDal.Update(catBallet);
            else
                ModelState.AddModelError("Catégorie de ballets", "Catégorie introuvable.");
            return Redirect("Competition");
        }

        [HttpPost]
        public ActionResult AddCatBallet(CategorieBallet catBallet)
        {
            if (catBallet != null)
                catBalletDal.Add(catBallet);
            else
                ModelState.AddModelError("Catégorie de ballets", "Catégorie introuvable.");
            return Redirect("Competition");
        }
        #endregion

        #region Management des profiles
        // GET
        public ActionResult ProfilManager()
        {
            ViewBag.admins = profilDal.getProfiles().Where(p => p.estAdmin != null && (bool)p.estAdmin).ToList();
            ViewBag.juges = profilDal.getProfiles().Where(p => p.estAdmin != null && !(bool)p.estAdmin).ToList();
            ViewBag.enCours = profilDal.getProfiles().Where(p => p.estAdmin == null).ToList();
            return View();
        }

        public ActionResult ProfilEdit()
        {
            return View();
        }

        public ActionResult ProfilEdit(int id = -1)
        {
            if (id != -1)
            {
                ViewBag.profilEdit = profilDal.getProfil(id);
            }
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult ProfilEdit(Profil profil = null)
        {
            return Redirect("ProfilManager");
        }
        #endregion

    }
}