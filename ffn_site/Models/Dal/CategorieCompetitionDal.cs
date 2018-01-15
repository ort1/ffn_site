using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ffn_site.Models.Dal.Interface;

namespace ffn_site.Models.Dal
{
    public class CategorieCompetitionDal : IDalCategorieCompetition
    {
        private ffn_siteEntities bdd;

        public CategorieCompetitionDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(string libelle)
        {
            throw new NotImplementedException();
        }

        public int Add(CategorieCompetition catComp)
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

        public List<CategorieCompetition> GetAll()
        {
            return bdd.CategorieCompetition.ToList();
        }

        public CategorieCompetition GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CategorieCompetition GetByLbl(string libelle)
        {
            throw new NotImplementedException();
        }
    }
}