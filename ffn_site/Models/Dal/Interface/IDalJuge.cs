using System;

namespace ffn_site.Models.Dal.Interface
{
    interface IDalJuge : IDisposable
    {
        Juge GetJuge(Profil profil);
        Juge GetJuge(int id);
        bool AddJuge(bool estArbitre, Personne personne);
        bool AddJuge(bool estArbitre, Personne personne, Profil profil);
        Personne GetPersonneFromJuge(Juge juge);
        Personne GetPersonneFromJuge(int id_Personne);
    }
}
