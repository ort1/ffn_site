using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ffn_site.Tools;

namespace ffn_site.Models.Dal
{
    public class ProfilDal : IDal
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

    }
}