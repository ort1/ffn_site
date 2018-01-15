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
            throw new NotImplementedException();
        }

        public int Add(CategorieBallet catComp)
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

        public List<CategorieBallet> GetAll()
        {
            return bdd.CategorieBallet.ToList();
        }

        public CategorieBallet GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CategorieBallet GetByLbl(string libelle)
        {
            throw new NotImplementedException();
        }
    }
}