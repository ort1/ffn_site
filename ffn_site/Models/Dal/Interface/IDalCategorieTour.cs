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
        CategorieTour Get(int id);
        CategorieTour Get(string libelle);
        CategorieTour Get(CategorieTour catTour);
        int Add(string libelle);
        int Add(CategorieTour catTour);
        int Delete(int id);
        int Delete(string libelle);
        int Delete(CategorieTour catTour);
        int Update(CategorieTour catTour);
    }
}
