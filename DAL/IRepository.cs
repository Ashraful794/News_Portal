using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T,ID>
    {
        void Add(T s);
        List<T> Get();
        void Delete(ID id);
        void Edit(T s);
    }
}
