using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ffn_site.Models.Dal.Interface;

namespace ffn_site.Models.Dal
{
    public class CategorieEvaluationDal : IDalCategorieEvaluation
    {

        private ffn_siteEntities bdd;

        public CategorieEvaluationDal()
        {
            bdd = new ffn_siteEntities();
        }
        public int Add(string libelle)
        {
            throw new NotImplementedException();
        }

        public int Add(CategorieEvaluation catComp)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(string libelle)
        {
            throw new NotImplementedException();
        }

        public List<CategorieEvaluation> GetAll()
        {
            return bdd.CategorieEvaluation.ToList();
        }

        public CategorieEvaluation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CategorieEvaluation GetByLbl(string libelle)
        {
            throw new NotImplementedException();
        }
    }
}