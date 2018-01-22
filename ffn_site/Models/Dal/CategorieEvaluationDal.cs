using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ffn_site.Models.Dal
{
    public class CategorieEvaluationDal : IDal<CategorieEvaluation>
    {

        private ffn_siteEntities bdd;

        public CategorieEvaluationDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(CategorieEvaluation o)
        {
            bdd.CategorieEvaluation.Add(o);
            return bdd.SaveChanges();
        }

        public int Delete(CategorieEvaluation o)
        {
            bdd.CategorieEvaluation.Remove(o);
            return bdd.SaveChanges();
        }

        public int Delete(int id)
        {
            CategorieEvaluation cat = Get(id);
            return Delete(cat);
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public CategorieEvaluation Get(int id)
        {
            return bdd.CategorieEvaluation.Where(c => c.id == id).FirstOrDefault();
        }

        public CategorieEvaluation Get(CategorieEvaluation o)
        {
            return bdd.CategorieEvaluation.Where(c => c.id == o.id).FirstOrDefault();
        }

        public List<CategorieEvaluation> GetAll()
        {
            return bdd.CategorieEvaluation.ToList();
        }

        public int Update(CategorieEvaluation o)
        {
            CategorieEvaluation existCatEval = Get(o.id);
            if (existCatEval == null)
                return -1;
            else
            {
                existCatEval.lbl = existCatEval.lbl;
                return bdd.SaveChanges();
            }
        }
    }
}