using ffn_site.Models;
using ffn_site.Models.Dal;
using ffn_site.Models.Dal.Interface;
using System.Web.Mvc;
using System.Web.Security;

namespace ffn_site.Controllers
{
    public class ProfilController : Controller
    {
        private IDalProfil dalProfil = new ProfilDal();

        // GET: Profil
        public ActionResult Connexion()
        {
            ViewBag.profiles = dalProfil.getProfiles();
            Profil profil = null;
            if (HttpContext.User.Identity.IsAuthenticated)
                profil = dalProfil.getProfil(HttpContext.User.Identity.Name);
            return View(profil);
        }

        public ActionResult Inscription()
        {
            return View();
        }

        public ActionResult Deconnexion()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }

        // POST: Profil
        [HttpPost]
        public ActionResult Connexion(string returnUrl, Profil profil = null)
        {
            if (ModelState.IsValid)
            {
                Profil profilFound = null;
                profilFound = dalProfil.getProfil(profil.login, profil.password);
                if (profilFound != null)
                {
                    FormsAuthentication.SetAuthCookie(profilFound.id.ToString(), false);
                    ViewBag.login = profilFound.login;
                    ViewBag.role = ((bool)profilFound.estAdmin) ? "admin" : "juge";
                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                    if ((bool)profilFound.estAdmin)
                        return RedirectToAction("Index", "Admin");
                    else
                    {
                        Juge juge = new JugeDal().GetJuge(profilFound);
                        return RedirectToAction("Index", "Admin", new { juge = juge });
                    }
                }
                ModelState.AddModelError("Profil", "Identifiant et/ou mot de passe incorrect(s).");
            }
            return View();
        }

    }
}