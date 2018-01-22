using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffn_site.Models.Dal
{
    interface IDal<T>: IDisposable
    {
        T Get(int id);
        T Get(T o);
        List<T> GetAll();
        int Add(T o);
        int Update(T o);
        int Delete(T o);
        int Delete(int id);
    }
}
