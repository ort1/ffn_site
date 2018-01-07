using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ffn_site.Tools;

namespace ffn_site.Models.Dal
{
    public class JugeDal : Interface.IDalJuge
    {
        private ffn_siteEntities bdd;

        public JugeDal()
        {
            bdd = new ffn_siteEntities();
        }

        public bool AddJuge(bool estArbitre, Personne personne)
        {
            throw new NotImplementedException();
        }

        public bool AddJuge(bool estArbitre, Personne personne, Profil profil)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public Juge GetJuge(Profil profil)
        {
            Juge juge = bdd.Juge
                .Where(p => p.id_Profil.Equals(profil.id))
                .FirstOrDefault();
            return juge;
        }

        public Juge GetJuge(int id)
        {
            Juge juge = bdd.Juge
                .Where(p => p.id.Equals(id))
                .FirstOrDefault();
            return juge;
        }

        public Personne GetPersonneFromJuge(Juge juge)
        {
            Personne personne = bdd.Personne
                .Where(p => p.id.Equals(juge.id_Personne))
                .FirstOrDefault();
            return personne;
        }

        public Personne GetPersonneFromJuge(int id_Personne)
        {
            Personne personne = bdd.Personne
                .Where(p => p.id.Equals(id_Personne))
                .FirstOrDefault();
            return personne;
        }
    }
}