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
        CategorieEpreuve GetById(int id);
        CategorieEpreuve GetByLbl(string libelle);
        int Add(string libelle);
        int Add(CategorieEpreuve catComp);
        int Delete(int id);
        int Delete(string libelle);
    }
}
