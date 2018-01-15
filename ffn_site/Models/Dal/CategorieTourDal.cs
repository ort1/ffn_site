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
            throw new NotImplementedException();
        }

        public int Add(CategorieTour catComp)
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

        public List<CategorieTour> GetAll()
        {
            return bdd.CategorieTour.ToList();
        }

        public CategorieTour GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CategorieTour GetByLbl(string libelle)
        {
            throw new NotImplementedException();
        }
    }
}