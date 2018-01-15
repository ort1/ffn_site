using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffn_site.Models.Dal.Interface
{
    interface IDalCategorieBallet
    {
        List<CategorieBallet> GetAll();
        CategorieBallet GetById(int id);
        CategorieBallet GetByLbl(string libelle);
        int Add(string libelle);
        int Add(CategorieBallet catComp);
        int Delete(int id);
        int Delete(string libelle);
    }
}
