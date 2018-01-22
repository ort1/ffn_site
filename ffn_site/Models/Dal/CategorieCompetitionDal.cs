using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ffn_site.Models.Dal
{
    public class CategorieCompetitionDal
    {
        private ffn_siteEntities bdd;

        public CategorieCompetitionDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(string libelle)
        {
            return Add(new CategorieCompetition {
                lbl = libelle
            });
        }

        public int Add(CategorieCompetition catComp)
        {
            bdd.CategorieCompetition.Add(catComp);
            return bdd.SaveChanges();
        }

        public int Delete(int id)
        {
            CategorieCompetition catComp = Get(id);
            return Delete(catComp);
        }

        public int Delete(string lbl)
        {
            CategorieCompetition catComp = Get(lbl);
            return Delete(catComp);
        }

        public int Delete(CategorieCompetition catComp)
        {
            bdd.CategorieCompetition.Remove(catComp);
            return bdd.SaveChanges();
        }

        public List<CategorieCompetition> GetAll()
        {
            return bdd.CategorieCompetition.ToList();
        }

        public CategorieCompetition Get(int id)
        {
            return bdd.CategorieCompetition.Where(c => c.id == id).FirstOrDefault();
        }

        public CategorieCompetition Get(string lbl)
        {
            return bdd.CategorieCompetition.Where(c => c.lbl == lbl).FirstOrDefault();
        }

        public CategorieCompetition Get(CategorieCompetition catComp)
        {
            return bdd.CategorieCompetition.Where(c => c.lbl.Equals(catComp.lbl) && c.id == catComp.id).FirstOrDefault();
        }

        public int Update(CategorieCompetition catComp)
        {
            CategorieCompetition existCatComp = Get(catComp.id);
            if (existCatComp == null)
                return -1;
            else
            {
                existCatComp.lbl = catComp.lbl;
                return bdd.SaveChanges();
            }
        }
    }
}