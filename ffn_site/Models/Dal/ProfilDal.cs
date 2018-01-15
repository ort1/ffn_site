using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ffn_site.Tools;

namespace ffn_site.Models.Dal
{
    public class ProfilDal : Interface.IDalProfil
    {
        private ffn_siteEntities bdd;

        public ProfilDal()
        {
            bdd = new ffn_siteEntities();
        }

        public Profil getProfil(string login, string password)
        {
            string passCrypted = Helpers.SHA512(password);
            Profil profil = bdd.Profil
                .Where(p => p.login.Equals(login))
                .Where(p => p.password.Equals(passCrypted))
                .FirstOrDefault();
            return profil;
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public Profil getProfil(int id)
        {
            Profil profil = bdd.Profil
                .Where(p => p.id.Equals(id))
                .FirstOrDefault();
            return profil;
        }

        public Profil getProfil(string login)
        {
            Profil profil = bdd.Profil
                .Where(p => p.login.Equals(login))
                .FirstOrDefault();
            return profil;
        }

        public int AddProfil(Profil profil)
        {
            profil.password = Helpers.SHA512(profil.password);
            profil.estAdmin = false;
            profil.dateCreation = DateTime.Now;
            bdd.Profil.Add(profil);
            return UpdateProfil();
        }

        public List<Profil> getProfiles()
        {
            return bdd.Profil.ToList();
        }

        public int UpdateProfil()
        {
            int result = bdd.SaveChanges();
            return result;
        }

        public int UpdateProfil(Profil profil)
        {
            throw new NotImplementedException();
        }
    }
}