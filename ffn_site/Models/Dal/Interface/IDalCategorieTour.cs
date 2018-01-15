using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffn_site.Models.Dal.Interface
{
    interface IDalCategorieTour
    {
        List<CategorieTour> GetAll();
        CategorieTour GetById(int id);
        CategorieTour GetByLbl(string libelle);
        int Add(string libelle);
        int Add(CategorieTour catComp);
        int Delete(int id);
        int Delete(string libelle);
    }
}
