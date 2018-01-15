using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffn_site.Models.Dal.Interface
{
    interface IDalCategorieEvaluation
    {
        List<CategorieEvaluation> GetAll();
        CategorieEvaluation GetById(int id);
        CategorieEvaluation GetByLbl(string libelle);
        int Add(string libelle);
        int Add(CategorieEvaluation catComp);
        int Delete(int id);
        int Delete(string libelle);
    }
}
