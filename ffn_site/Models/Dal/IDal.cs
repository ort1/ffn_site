using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffn_site.Models.Dal
{
    interface IDal : IDisposable
    {
        Profil getProfil(string login, string password);
    }
}
