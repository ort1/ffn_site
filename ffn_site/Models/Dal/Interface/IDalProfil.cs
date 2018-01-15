using System;
using System.Collections.Generic;

namespace ffn_site.Models.Dal.Interface
{
    interface IDalProfil : IDisposable
    {
        Profil getProfil(string login, string password);
        Profil getProfil(int id);
        Profil getProfil(string login);
        List<Profil> getProfiles();
        int AddProfil(Profil profil);
        int UpdateProfil();
        int UpdateProfil(Profil profil);
    }
}
