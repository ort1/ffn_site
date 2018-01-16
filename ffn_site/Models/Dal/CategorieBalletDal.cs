using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ffn_site.Models.Dal.Interface;

namespace ffn_site.Models.Dal
{
    public class CategorieBalletDal : IDalCategorieBallet
    {
        private ffn_siteEntities bdd;

        public CategorieBalletDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(string libelle)
        {
            return Add(new CategorieBallet
            {
                lbl = libelle
            });
        }

        public int Add(CategorieBallet catBallet)
        {
            bdd.CategorieBallet.Add(catBallet);
            return bdd.SaveChanges();
        }

        public int Delete(int id)
        {
            CategorieBallet catBallet = Get(id);
            return Delete(catBallet);
        }

        public int Delete(string lbl)
        {
            CategorieBallet catBallet = Get(lbl);
            return Delete(catBallet);
        }

        public int Delete(CategorieBallet catBallet)
        {
            bdd.CategorieBallet.Remove(catBallet);
            return bdd.SaveChanges();
        }

        public List<CategorieBallet> GetAll()
        {
            return bdd.CategorieBallet.ToList();
        }

        public CategorieBallet Get(int id)
        {
            return bdd.CategorieBallet.Where(c => c.id == id).FirstOrDefault();
        }

        public CategorieBallet Get(string lbl)
        {
            return bdd.CategorieBallet.Where(c => c.lbl == lbl).FirstOrDefault();
        }

        public CategorieBallet Get(CategorieBallet catBallet)
        {
            return bdd.CategorieBallet.Where(c => c.lbl.Equals(catBallet.lbl) && c.id == catBallet.id).FirstOrDefault();
        }

        public int Update(CategorieBallet catBallet)
        {
            CategorieBallet existCatBallet = Get(catBallet.id);
            if (existCatBallet == null)
                return -1;
            else
            {
                existCatBallet.lbl = catBallet.lbl;
                return bdd.SaveChanges();
            }
        }
    }
}