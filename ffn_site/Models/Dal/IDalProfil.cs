using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffn_site.Models.Dal
{
    interface IDalProfil : IDisposable
    {
        Profil getProfil(string login, string password);
        Profil getProfil(int id);
        Profil getProfil(string login);
        bool AddProfil(string login, string password, string email);
    }
}
