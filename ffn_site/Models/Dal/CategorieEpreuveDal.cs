using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ffn_site.Models.Dal
{
    public class CategorieEpreuveDal
    {

        private ffn_siteEntities bdd;

        public CategorieEpreuveDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(string libelle)
        {
            return Add(new CategorieEpreuve
            {
                lbl = libelle
            });
        }

        public int Add(CategorieEpreuve catEpreuve)
        {
            bdd.CategorieEpreuve.Add(catEpreuve);
            return bdd.SaveChanges();
        }

        public int Delete(int id)
        {
            CategorieEpreuve catEpreuve = Get(id);
            return Delete(catEpreuve);
        }

        public int Delete(string lbl)
        {
            CategorieEpreuve catEpreuve = Get(lbl);
            return Delete(catEpreuve);
        }

        public int Delete(CategorieEpreuve catEpreuve)
        {
            bdd.CategorieEpreuve.Remove(catEpreuve);
            return bdd.SaveChanges();
        }

        public List<CategorieEpreuve> GetAll()
        {
            return bdd.CategorieEpreuve.ToList();
        }

        public CategorieEpreuve Get(int id)
        {
            return bdd.CategorieEpreuve.Where(c => c.id == id).FirstOrDefault();
        }

        public CategorieEpreuve Get(string lbl)
        {
            return bdd.CategorieEpreuve.Where(c => c.lbl == lbl).FirstOrDefault();
        }

        public CategorieEpreuve Get(CategorieEpreuve catEpreuve)
        {
            return bdd.CategorieEpreuve.Where(c => c.lbl.Equals(catEpreuve.lbl) && c.id == catEpreuve.id).FirstOrDefault();
        }

        public int Update(CategorieEpreuve catEpreuve)
        {
            CategorieEpreuve existCatEpreuve = Get(catEpreuve.id);
            if (existCatEpreuve == null)
                return -1;
            else
            {
                existCatEpreuve.lbl = catEpreuve.lbl;
                return bdd.SaveChanges();
            }
        }
    }
}