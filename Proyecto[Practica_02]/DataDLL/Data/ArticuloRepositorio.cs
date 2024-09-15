using DataDLL.Domain;
using DataDLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Data
{
    public class ArticuloRepositorio : IArticuloRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> Get()
        {
            throw new NotImplementedException();
        }

        public object Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Articulo oArticulo)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@id", oArticulo.Id),
                new Parametro("@nombre", oArticulo.Nombre),
                new Parametro("@precio", oArticulo.PrecioUnitario)
            };
            var helper = DataHelper.GetInstance();
            int rows = helper.ExecuteSPNonQuery("SP_SAVE_ARTICULOS", parametros);
            return rows == 1;
        }
        public bool Update(Articulo oArticulo)
        {
            throw new NotImplementedException();
        }
    }
}
