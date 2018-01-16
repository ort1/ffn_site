using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffn_site.Models.Dal.Interface
{
    interface IDalCategorieEpreuve
    {
        List<CategorieEpreuve> GetAll();
        CategorieEpreuve Get(int id);
        CategorieEpreuve Get(string libelle);
        CategorieEpreuve Get(CategorieEpreuve catEpreuve);
        int Add(string libelle);
        int Add(CategorieEpreuve catEpreuve);
        int Delete(int id);
        int Delete(string libelle);
        int Delete(CategorieEpreuve catEpreuve);
        int Update(CategorieEpreuve catEpreuve);
    }
}
