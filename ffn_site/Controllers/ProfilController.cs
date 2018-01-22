using ffn_site.Models;
using ffn_site.Models.Dal;
using ffn_site.Tools;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ffn_site.Controllers
{
    public class ProfilController : Controller
    {
        private ProfilDal dalProfil = new ProfilDal();
        private JugeDal dalJuge = new JugeDal();
        private PersonneDal dalPersonne = new PersonneDal();

        // GET: Profil
        public ActionResult Connexion(string returnUrl = "")
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

        public ActionResult ProfilEdit(string login = "", string adminToken = null)
        {
            Profil currentProfil = dalProfil.getProfil(HttpContext.User.Identity.Name);
            Profil selectedProfil = dalProfil.getProfil(login);
            if (selectedProfil != null)
            {
                List<string> adminsToken = dalProfil.GetAdminsToken();
                if (!currentProfil.login.Equals(selectedProfil.login) && !adminsToken.Contains(adminToken))
                {
                    ModelState.AddModelError("Profil", "Vous n'avez pas accès à cette page.");
                    return Redirect("/");
                }
                else
                {
                    if (adminsToken.Contains(adminToken))
                    {
                        var listItem = new List<SelectListItem>
                        {
                            new SelectListItem { Text = "Juge", Value = ProfilDal.JUGE },
                            new SelectListItem { Text = "Administrateur", Value = ProfilDal.ADMIN },
                            new SelectListItem { Text = "Arbitre", Value = ProfilDal.ARBITRE }
                        };
                        ViewBag.listRole = listItem;
                    }
                    Juge juge = dalJuge.GetJugeFromProfil(selectedProfil);
                    if (juge != null)
                        ViewBag.personne = dalJuge.GetPersonneFromJuge(juge);
                    ViewBag.profil = selectedProfil;
                }
            }
            else
            {
                ViewBag.profil = currentProfil;
            }
            return View();
        }

        // POST: Profil
        [HttpPost]
        public ActionResult Connexion(Profil profil = null)
        {
            ActionResult returnView = null;

            var query = HttpUtility.ParseQueryString(this.Request.UrlReferrer.Query);
            string returnUrl = HttpUtility.UrlDecode((query["ReturnUrl"] == null || "".Equals(query["ReturnUrl"])) ? "" : query["ReturnUrl"]);

            Profil profilFound = null;
            profilFound = dalProfil.getProfil(profil.login, profil.password);
            if (profilFound != null)
            {
                if (profilFound.role == null)
                {
                    ModelState.AddModelError("Profil", "Aucun profile ne vous a été assigné pour le moment.");
                    returnView = View();
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(profilFound.login.ToString(), false);
                    profilFound.dateConnexion = DateTime.Now;
                    dalProfil.UpdateProfil();
                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        returnView = Redirect(returnUrl);
                    else if (profilFound.role.Equals(ProfilDal.ADMIN))
                        returnView = RedirectToAction("Index", "Admin");
                    else
                        returnView = RedirectToAction("Index", "Juge");
                }
            }
            else
            {
                returnView = View();
                ModelState.AddModelError("Profil", "Identifiant et/ou mot de passe incorrect(s).");
            }
            return returnView;
        }

        [HttpPost]
        public ActionResult Inscription (Profil profil = null, string mailValid = "", string passwordValid = "")
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                profil = dalProfil.getProfil(HttpContext.User.Identity.Name);
                return Connexion(profil);
            }
            if (profil != null)
            {
                bool validMail = mailValid.Equals(profil.mail);
                bool validPassword = passwordValid.Equals(profil.password);
                if (validMail && validPassword)
                {
                    profil.commentaire = HttpUtility.HtmlDecode(profil.commentaire);
                    Profil profilExist = dalProfil.getProfil(profil.login);
                    if (profilExist != null)
                        ModelState.AddModelError("Profil", "Identifiant déjà pris.");
                    else
                    {
                        profil.token = Helpers.SHA512(Helpers.RandomString(10));
                        dalProfil.AddProfil(profil);
                        TempData["addNotification"] = new string[] {
                            "Votre êtes bien inscrit au site de natation synchronisée de la FFN.",
                            "L'administrateur va traiter votre inscription."
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

        [HttpPost]
        public ActionResult ProfilEdit(Profil profil, Personne personne, int idProfil = -1, int idPersonne = -1, string mailPersonne = "", string mailValid = "", string passwordValid = "")
        {
            if (profil != null && idProfil != -1)
            {
                Profil profilToUpdate = dalProfil.getProfil(idProfil);
                bool validMail = mailValid.Equals(profil.mail);
                bool validPassword = passwordValid.Equals(profil.password);
                if (profil.login != null || !"".Equals(profil.login)) profilToUpdate.login = profil.login;
                if (validPassword && (profil.password != null || !"".Equals(profil.password))) profilToUpdate.password = profil.password;
                if (validMail && (profil.mail != null || !"".Equals(profil.mail))) profilToUpdate.mail = profil.mail;
                if (profil.commentaire != null || !"".Equals(profil.commentaire)) profilToUpdate.commentaire = profil.commentaire;
                if (profil.role != null || !"".Equals(profil.role)) profilToUpdate.role = profil.role;
                if (personne != null && !ProfilDal.ADMIN.Equals(profil.role))
                {
                    personne.mail = mailPersonne;
                    if (idPersonne != -1)
                    {
                        Personne personneToUpdate = dalPersonne.Get(idPersonne);
                        if (personne.nom != null || !"".Equals(personne.nom)) personneToUpdate.nom = personne.nom;
                        if (personne.prenom != null || !"".Equals(personne.prenom)) personneToUpdate.prenom = personne.prenom;
                        if (personne.dateNaissance != null || !"".Equals(personne.dateNaissance)) personneToUpdate.dateNaissance = personne.dateNaissance;
                        if (personne.telFixe != null || !"".Equals(personne.telFixe)) personneToUpdate.telFixe = personne.telFixe;
                        if (personne.telPortable != null || !"".Equals(personne.telPortable)) personneToUpdate.telPortable = personne.telPortable;
                        if (personne.mail != null || !"".Equals(personne.mail)) personneToUpdate.mail = personne.mail;
                    }
                    else
                    {
                        Personne personneToAdd = new Personne
                        {
                            nom = personne.nom,
                            prenom = personne.prenom,
                            dateNaissance = personne.dateNaissance,
                            telFixe = personne.telFixe,
                            telPortable = personne.telPortable,
                            mail = mailPersonne
                        };
                        dalPersonne.Add(personneToAdd);

                        Juge juge = new Juge
                        {
                            id_Personne = personneToAdd.id,
                            id_Profil = profilToUpdate.id
                        };
                        dalJuge.Add(juge);
                    }
                }
                dalProfil.UpdateProfil();
            }
            return Redirect("/");
        }

    }
}