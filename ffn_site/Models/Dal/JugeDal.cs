using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ffn_site.Tools;

namespace ffn_site.Models.Dal
{
    public class JugeDal : IDal<Juge>
    {
        private ffn_siteEntities bdd;

        public JugeDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(Juge o)
        {
            bdd.Juge.Add(o);
            return bdd.SaveChanges();
        }

        public int Delete(Juge o)
        {
            bdd.Juge.Remove(o);
            return bdd.SaveChanges();
        }

        public int Delete(int id)
        {
            return Delete(Get(id));
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public Juge Get(int id)
        {
            return bdd.Juge.Where(j => j.id == id).FirstOrDefault();
        }

        public Juge Get(Juge o)
        {
            return Get(o.id);
        }

        public List<Juge> GetAll()
        {
            throw new NotImplementedException();
        }

        public Personne GetPersonneFromJuge(Juge juge)
        {
            Personne personne = bdd.Personne
                .Where(p => p.id == juge.id_Personne)
                .FirstOrDefault();
            return personne;
        }

        public Personne GetPersonneFromJuge(int id_Personne)
        {
            Personne personne = bdd.Personne
                .Where(p => p.id == id_Personne)
                .FirstOrDefault();
            return personne;
        }

        public Juge GetJugeFromProfil(Profil profil)
        {
            return bdd.Juge.Where(j => j.id_Profil == profil.id).FirstOrDefault();
        }

        public int Update(Juge o)
        {
            Juge juge = Get(o.id);
            if (juge == null)
                return -1;
            else
            {
                if (o.id_Personne != null) juge.id_Personne = o.id_Personne;
                if (o.id_Profil != null) juge.id_Profil = o.id_Profil;
                return bdd.SaveChanges();
            }
        }
    }
}