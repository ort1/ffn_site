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
        CategorieBallet Get(int id);
        CategorieBallet Get(string libelle);
        CategorieBallet Get(CategorieBallet catBallet);
        int Add(string libelle);
        int Add(CategorieBallet catBallet);
        int Delete(int id);
        int Delete(string libelle);
        int Delete(CategorieBallet catBallet);
        int Update(CategorieBallet catBallet);
    }
}
