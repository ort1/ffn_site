using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ffn_site.Models.Dal.Interface;

namespace ffn_site.Models.Dal
{
    public class CategorieTourDal : IDalCategorieTour
    {

        private ffn_siteEntities bdd;

        public CategorieTourDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(string libelle)
        {
            return Add(new CategorieTour
            {
                lbl = libelle
            });
        }

        public int Add(CategorieTour catTour)
        {
            bdd.CategorieTour.Add(catTour);
            return bdd.SaveChanges();
        }

        public int Delete(int id)
        {
            CategorieTour catTour = Get(id);
            return Delete(catTour);
        }

        public int Delete(string lbl)
        {
            CategorieTour catTour = Get(lbl);
            return Delete(catTour);
        }

        public int Delete(CategorieTour catTour)
        {
            bdd.CategorieTour.Remove(catTour);
            return bdd.SaveChanges();
        }

        public List<CategorieTour> GetAll()
        {
            return bdd.CategorieTour.ToList();
        }

        public CategorieTour Get(int id)
        {
            return bdd.CategorieTour.Where(c => c.id == id).FirstOrDefault();
        }

        public CategorieTour Get(string lbl)
        {
            return bdd.CategorieTour.Where(c => c.lbl == lbl).FirstOrDefault();
        }

        public CategorieTour Get(CategorieTour catTour)
        {
            return bdd.CategorieTour.Where(c => c.lbl.Equals(catTour.lbl) && c.id == catTour.id).FirstOrDefault();
        }

        public int Update(CategorieTour catTour)
        {
            CategorieTour existCatTour = Get(catTour.id);
            if (existCatTour == null)
                return -1;
            else
            {
                existCatTour.lbl = catTour.lbl;
                return bdd.SaveChanges();
            }
        }
    }
}