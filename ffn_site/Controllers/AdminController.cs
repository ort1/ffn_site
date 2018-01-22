using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ffn_site.Models;
using ffn_site.Models.Dal;
using System.IO;

namespace ffn_site.Controllers
{

    [Authorize]
    public class AdminController : Controller
    {

        private PersonneDal personneDal = new PersonneDal();

        // Catégories
        private CategorieCompetitionDal catCompDal = new CategorieCompetitionDal();
        private CategorieTourDal catTourDal = new CategorieTourDal();
        private CategorieEpreuveDal catEpreuveDal = new CategorieEpreuveDal();
        private CategorieBalletDal catBalletDal = new CategorieBalletDal();
        private CategorieEvaluationDal catEvalDal = new CategorieEvaluationDal();
        
        // Profiles
        private ProfilDal profilDal = new ProfilDal();

        // Clubs
        private ClubDal clubDal = new ClubDal();

        // Nageurs
        private NageurDal nageurDal = new NageurDal();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CompetitionManager()
        {
            return View();
        }

        #region Management des catégories
        // GET
        public ActionResult CategorieManager()
        {
            ViewBag.catsComp = catCompDal.GetAll();
            ViewBag.catsTour = catTourDal.GetAll();
            ViewBag.catsEpreuve = catEpreuveDal.GetAll();
            ViewBag.catsBallet = catBalletDal.GetAll();
            ViewBag.catsEval = catEvalDal.GetAll();
            return View();
        }

        public ActionResult DeleteCatCompetition(int id = -1)
        {
            if (id != -1)
                catCompDal.Delete(id);
            else
                ModelState.AddModelError("Catégorie de compétitions", "Catégorie introuvable.");
            return RedirectToAction("CategorieManager", "Admin");
        }

        public ActionResult DeleteCatTour(int id = -1)
        {
            if (id != -1)
                catTourDal.Delete(id);
            else
                ModelState.AddModelError("Catégorie de tours", "Catégorie introuvable.");
            return RedirectToAction("CategorieManager", "Admin");
        }

        public ActionResult DeleteCatEpreuve(int id = -1)
        {
            if (id != -1)
                catEpreuveDal.Delete(id);
            else
                ModelState.AddModelError("Catégorie d'épreuves", "Catégorie introuvable.");
            return RedirectToAction("CategorieManager", "Admin");
        }

        public ActionResult DeleteCatBallet(int id = -1)
        {
            if (id != -1)
                catBalletDal.Delete(id);
            else
                ModelState.AddModelError("Catégorie de ballets", "Catégorie introuvable.");
            return RedirectToAction("CategorieManager", "Admin");
        }

        public ActionResult DeleteCatEvaluation(int id = -1)
        {
            if (id != -1)
                catEvalDal.Delete(id);
            else
                ModelState.AddModelError("Catégorie d'évaluation", "Catégorie introuvable.");
            return RedirectToAction("CategorieManager", "Admin");
        }

        // POST
        [HttpPost]
        public ActionResult UpdateCatCompetition(CategorieCompetition catComp)
        {
            if (catComp != null)
                catCompDal.Update(catComp);
            else
                ModelState.AddModelError("Catégorie de compétitions", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }

        [HttpPost]
        public ActionResult AddCatCompetition(CategorieCompetition catComp)
        {
            if (catComp != null)
                catCompDal.Add(catComp);
            else
                ModelState.AddModelError("Catégorie de compétitions", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }

        [HttpPost]
        public ActionResult UpdateCatTour(CategorieTour catTour)
        {
            if (catTour != null)
                catTourDal.Update(catTour);
            else
                ModelState.AddModelError("Catégorie de tours", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }

        [HttpPost]
        public ActionResult AddCatTour(CategorieTour catTour)
        {
            if (catTour != null)
                catTourDal.Add(catTour);
            else
                ModelState.AddModelError("Catégorie de tours", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }

        [HttpPost]
        public ActionResult UpdateCatEpreuve(CategorieEpreuve catEpreuve)
        {
            if (catEpreuve != null)
                catEpreuveDal.Update(catEpreuve);
            else
                ModelState.AddModelError("Catégorie d'épreuves", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }

        [HttpPost]
        public ActionResult AddCatEpreuve(CategorieEpreuve catEpreuve)
        {
            if (catEpreuve != null)
                catEpreuveDal.Add(catEpreuve);
            else
                ModelState.AddModelError("Catégorie d'épreuves", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }

        [HttpPost]
        public ActionResult UpdateCatBallet(CategorieBallet catBallet)
        {
            if (catBallet != null)
                catBalletDal.Update(catBallet);
            else
                ModelState.AddModelError("Catégorie de ballets", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }

        [HttpPost]
        public ActionResult AddCatBallet(CategorieBallet catBallet)
        {
            if (catBallet != null)
                catBalletDal.Add(catBallet);
            else
                ModelState.AddModelError("Catégorie de ballets", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }

        public ActionResult UpdateCatEvaluation(CategorieEvaluation catEval)
        {
            if (catEval != null)
                catEvalDal.Update(catEval);
            else
                ModelState.AddModelError("Catégorie d'évaluation", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }

        [HttpPost]
        public ActionResult AddCatEvaluation(CategorieEvaluation catEval)
        {
            if (catEval != null)
                catEvalDal.Add(catEval);
            else
                ModelState.AddModelError("Catégorie d'évaluation", "Catégorie introuvable.");
            return Redirect("CategorieManager");
        }
        #endregion

        #region Management des profiles
        // GET
        public ActionResult ProfilManager()
        {
            ViewBag.token = profilDal.getProfil(User.Identity.Name).token;
            ViewBag.admins = profilDal.getProfiles().Where(p => p.role != null && p.role.Equals(ProfilDal.ADMIN)).ToList();
            ViewBag.juges = profilDal.getProfiles().Where(p => p.role != null && !p.role.Equals(ProfilDal.ADMIN)).ToList();
            ViewBag.enCours = profilDal.getProfiles().Where(p => p.role == null).ToList();
            return View();
        }

        public ActionResult ProfilDelete(string login = "", string adminToken = "")
        {
            List<string> tokens = profilDal.GetAdminsToken();
            if (!"".Equals(login) && tokens.Contains(adminToken))
                profilDal.Delete(login);
            return RedirectToAction("ProfilManager", "Admin");
        }
        #endregion

        #region management clubs
        // GET
        public ActionResult ClubManager()
        {
            ViewBag.clubs = clubDal.GetAll();
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult ImportCSVClub()
        {
            if (Request.Files["csv"] != null)
            {
                HttpPostedFileBase file = Request.Files["csv"];
                string[] filename = file.FileName.Split('.');
                if ("csv".Equals(filename.Last()))
                {
                    string datetimeNow = DateTime.Now.ToString("ddMMyyyyhhmmss");
                    string fullPath = string.Format("D:\\ORT_Lyon\\4MS2I\\csv\\{0}_{1}.csv", filename[0], datetimeNow);
                    if (file.ContentLength > 0)
                    {
                        string FileName = file.FileName;
                        int FileSize = file.ContentLength;
                        byte[] FileByteArray = new byte[FileSize];
                        file.InputStream.Read(FileByteArray, 0, FileSize);
                        file.SaveAs(fullPath);
                    }
                    StreamReader csvReader = new StreamReader(fullPath);
                    int iLine = 0;
                    while (!csvReader.EndOfStream)
                    {
                        var line = csvReader.ReadLine();
                        iLine++;
                        var values = line.Split(';');
                        if (values.Length > 11)
                        {
                            ModelState.AddModelError("Club", string.Format("Le fichier CSV est mal formé - Ligne n°{0}.", iLine));
                            break;
                        }
                        Personne dirigeant = new Personne
                        {
                            nom = values[6],
                            prenom = values[7],
                            telFixe = values[8],
                            telPortable = values[9],
                            mail = values[10]
                        };
                        Club club = new Club
                        {
                            idFederal = values[0],
                            nomClub = values[1],
                            adresseSiege = values[2],
                            cpSiege = values[3],
                            villeSiege = values[4],
                            siteWeb = values[5]
                        };
                        int dirigeantExiste = personneDal.EntityExist(dirigeant);
                        int clubExiste = clubDal.EntityExist(club);
                        if (dirigeantExiste == -1 && clubExiste == -1)
                        {
                            personneDal.Add(dirigeant);
                            club.id_Dirigeant = dirigeant.id;
                            clubDal.Add(club);
                        }
                        else if (dirigeantExiste == -1 && clubExiste != -1)
                        {
                            personneDal.Add(dirigeant);
                            Club leClub = clubDal.Get(clubExiste);
                            leClub.id_Dirigeant = dirigeant.id;
                            clubDal.Update(leClub);
                        }
                        else if (dirigeantExiste != -1 && clubExiste == -1)
                        {
                            club.id_Dirigeant = dirigeantExiste;
                            clubDal.Add(club);
                        }
                    }
                    csvReader.Close();
                    System.IO.File.Delete(fullPath);
                    TempData["addNotification"] = "Le fichier CSV a été importé avec succès.";
                }
            }
            return RedirectToAction("ClubManager", "Admin");
        }
        #endregion

        #region management nageurs
        // GET
        public ActionResult NageursManager()
        {
            ViewBag.clubs = clubDal.GetAll();
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult ImportCSVNageurs()
        {
            if (Request.Files["csv"] != null)
            {
                HttpPostedFileBase file = Request.Files["csv"];
                string[] filename = file.FileName.Split('.');
                if ("csv".Equals(filename.Last()))
                {
                    string datetimeNow = DateTime.Now.ToString("ddMMyyyyhhmmss");
                    string fullPath = string.Format("D:\\ORT_Lyon\\4MS2I\\csv\\{0}_{1}.csv", filename[0], datetimeNow);
                    if (file.ContentLength > 0)
                    {
                        string FileName = file.FileName;
                        int FileSize = file.ContentLength;
                        byte[] FileByteArray = new byte[FileSize];
                        file.InputStream.Read(FileByteArray, 0, FileSize);
                        file.SaveAs(fullPath);
                    }
                    StreamReader csvReader = new StreamReader(fullPath);
                    int iLine = 0;
                    while (!csvReader.EndOfStream)
                    {
                        var line = csvReader.ReadLine();
                        iLine++;
                        var values = line.Split(';');
                        if (values.Length > 7)
                        {
                            ModelState.AddModelError("Club", string.Format("Le fichier CSV est mal formé - Ligne n°{0}.", iLine));
                            break;
                        }
                        Personne nageur = new Personne
                        {
                            nom = values[1],
                            prenom = values[2],
                            dateNaissance = DateTime.Parse(values[3]),
                            telFixe = values[4],
                            telPortable = values[5],
                            mail = values[6]
                        };

                        int idClubExist = clubDal.EntityExist(new Club { idFederal = values[0] });
                        int idNageurExist = personneDal.NageurExist(nageur);
                        if (idClubExist != -1)
                        {
                            if (idNageurExist == -1)
                            {
                                personneDal.Add(nageur);
                                Nageur nageurInClub = new Nageur
                                {
                                    id_Club = idClubExist,
                                    id_Personne = nageur.id
                                };
                                nageurDal.Add(nageurInClub);
                            }
                            else if (nageurDal.Get(idNageurExist, idClubExist) == null)
                            {
                                nageurDal.Add(new Nageur { id_Club = idClubExist, id_Personne = idNageurExist });
                            }
                        }
                    }
                    csvReader.Close();
                    System.IO.File.Delete(fullPath);
                    TempData["addNotification"] = "Le fichier CSV a été importé avec succès.";
                }
            }
            return RedirectToAction("NageursManager", "Admin");
        }
        #endregion
    }
}