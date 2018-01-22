using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ffn_site.Models.Dal
{
    public class NageurDal : IDal<Nageur>
    {

        private ffn_siteEntities bdd;

        public NageurDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(Nageur o)
        {
            bdd.Nageur.Add(o);
            return bdd.SaveChanges();
        }

        public int Delete(Nageur o)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Nageur Get(int id)
        {
            throw new NotImplementedException();
        }

        public Nageur Get(Nageur o)
        {
            throw new NotImplementedException();
        }

        public Nageur Get(int idPersonne, int idClub)
        {
            return bdd.Nageur
                .Where(n => n.id_Club == idClub && n.id_Personne == idPersonne)
                .FirstOrDefault();
        }

        public List<Nageur> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Nageur o)
        {
            throw new NotImplementedException();
        }
    }
}