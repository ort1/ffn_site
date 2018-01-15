
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
        CategorieCompetition GetById(int id);
        CategorieCompetition GetByLbl(string libelle);
        int Add(string libelle);
        int Add(CategorieCompetition catComp);
        int Delete(int id);
        int Delete(string libelle);
    }
}
