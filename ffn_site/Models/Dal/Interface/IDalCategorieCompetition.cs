
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffn_site.Models.Dal.Interface
{
    interface IDalCategorieCompetition
    {
        List<CategorieCompetition> GetAll();
        CategorieCompetition Get(int id);
        CategorieCompetition Get(string libelle);
        CategorieCompetition Get(CategorieCompetition catComp);
        int Add(string libelle);
        int Add(CategorieCompetition catComp);
        int Delete(int id);
        int Delete(string libelle);
        int Delete(CategorieCompetition catComp);
        int Update(CategorieCompetition catComp);
    }
}
