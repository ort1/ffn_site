using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ffn_site.Models.Dal
{
    public class PersonneDal : IDal<Personne>
    {
        private ffn_siteEntities bdd;

        public PersonneDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(Personne o)
        {
            bdd.Personne.Add(o);
            return bdd.SaveChanges();
        }

        public int Delete(Personne o)
        {
            bdd.Personne.Remove(o);
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

        public Personne Get(int id)
        {
            return bdd.Personne.Where(p => p.id == id).FirstOrDefault();
        }

        public Personne Get(Personne o)
        {
            return bdd.Personne.Where(p => p.id == o.id).FirstOrDefault();
        }

        public List<Personne> GetAll()
        {
            return bdd.Personne.ToList();
        }

        public int Update(Personne o)
        {
            Personne personne = Get(o.id);
            if (personne == null)
                return -1;
            else
            {
                if (o.nom != "") personne.nom = o.nom;
                if (o.prenom != "") personne.prenom = o.prenom;
                if (o.dateNaissance != null) personne.dateNaissance = o.dateNaissance;
                if (o.telFixe != "") personne.telFixe = o.telFixe;
                if (o.telPortable != "") personne.telPortable = o.telPortable;
                if (o.mail != "") personne.mail = o.mail;
                return bdd.SaveChanges();
            }
        }

        public int EntityExist(Personne o)
        {
            Personne personne = bdd.Personne
                .Where(p => p.nom.Equals(o.nom)
                    && p.prenom.Equals(o.prenom)
                    && p.telFixe.Equals(o.telFixe)
                    && p.mail.Equals(o.mail))
                .FirstOrDefault();
            return (personne == null) ? -1 : personne.id;
        }

        public int NageurExist(Personne p)
        {
            Personne personne = bdd.Personne
                .Where(n => n.nom.Equals(p.nom)
                    && n.prenom.Equals(p.prenom)
                    && n.dateNaissance == p.dateNaissance)
                .FirstOrDefault();
            return (personne == null) ? -1 : personne.id;
        }
    }
}