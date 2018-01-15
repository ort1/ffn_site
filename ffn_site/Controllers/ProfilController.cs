using ffn_site.Models;
using ffn_site.Models.Dal;
using ffn_site.Models.Dal.Interface;
using System;
using System.Web;
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
        public ActionResult Connexion(string returnUrl = "", Profil profil = null)
        {
            if (ModelState.IsValid)
            {
                Profil profilFound = null;
                profilFound = dalProfil.getProfil(profil.login, profil.password);
                if (profilFound != null)
                {
                    ActionResult view = null;
                    FormsAuthentication.SetAuthCookie(profilFound.login.ToString(), false);
                    profilFound.dateConnexion = DateTime.Now;
                    dalProfil.UpdateProfil();
                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        view = Redirect(returnUrl);
                    if ((bool)profilFound.estAdmin)
                        view = RedirectToAction("Index", "Admin");
                    else
                    {
                        Juge juge = new JugeDal().GetJuge(profilFound);
                        view = RedirectToAction("Index", "Juge", new { juge = juge });
                    }
                    return view;
                }
                ModelState.AddModelError("Profil", "Identifiant et/ou mot de passe incorrect(s).");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Inscription (Profil profil = null, string mailValid = "", string passwordValid = "")
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                profil = dalProfil.getProfil(HttpContext.User.Identity.Name);
                return Connexion("", profil);
            }
            if (profil != null)
            {

                bool validMail = mailValid.Equals(profil.mail);
                bool validPassword = passwordValid.Equals(profil.password);
                if (validMail && validPassword)
                {
                    Profil profilExist = dalProfil.getProfil(profil.login);
                    if (profilExist != null)
                        ModelState.AddModelError("Profil", "Identifiant déjà pris.");
                    else
                    {
                        dalProfil.AddProfil(profil);
                        TempData["addNotification"] = new string[] {
                            "Votre êtes bien inscrit au site de natation synchronisée de la FFN.",
                            "L'administrateur vas traiter votre inscription."
                        };
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    if (!validMail)
                        ModelState.AddModelError("Profil", "Les emails ne correspondent pas.");
                    if (!validPassword)
                        ModelState.AddModelError("Profil", "Les mots de passe ne correspondent pas.");
                }
            }
            return View();
        }

    }
}