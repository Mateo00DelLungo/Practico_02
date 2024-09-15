using DataDLL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Interfaces
{
    public interface IArticuloRepository
    {
        List<Object> Get();
        Object Get(int id);
        bool Save(Articulo oArticulo);
        bool Delete(int id);
        bool Update(Articulo oArticulo);
    }
}
