using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ffn_site.Models.Dal.Interface;

namespace ffn_site.Models.Dal
{
    public class CategorieEpreuveDal : IDalCategorieEpreuve
    {

        private ffn_siteEntities bdd;

        public CategorieEpreuveDal()
        {
            bdd = new ffn_siteEntities();
        }
        public int Add(string libelle)
        {
            throw new NotImplementedException();
        }

        public int Add(CategorieEpreuve catComp)
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

        public List<CategorieEpreuve> GetAll()
        {
            return bdd.CategorieEpreuve.ToList();
        }

        public CategorieEpreuve GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CategorieEpreuve GetByLbl(string libelle)
        {
            throw new NotImplementedException();
        }
    }
}