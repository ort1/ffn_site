using ffn_site.Models;
using ffn_site.Models.Dal;
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

        // POST: Profil
        [HttpPost]
        public ActionResult Connexion(string login, string password)
        {
            IDal profilDal = new ProfilDal();
            Profil profilFound = profilDal.getProfil(login, password);
            ViewData["profilAdmin"] = (profilFound != null && (bool)profilFound.estAdmin);
            return View();
        }

    }
}