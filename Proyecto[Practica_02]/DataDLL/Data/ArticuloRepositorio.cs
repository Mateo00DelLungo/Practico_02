using DataDLL.Domain;
using DataDLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Data
{
    public class ArticuloRepositorio : IArticuloRepository
    {
        private readonly DataHelper helper;
        public ArticuloRepositorio()
        {
            helper = DataHelper.GetInstance();
        }
        private List<Articulo> TableToList(DataTable dt)
        {
            if(dt == null || dt.Rows.Count == 0) { return null; }
            List<Articulo> lst = new List<Articulo>();
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(LoadArticulo(row));
            }
            return lst;
        }
        private Articulo LoadArticulo(DataRow row)
        {
            int id = Convert.ToInt32(row["id"]);
            string nombre = row["nombre"].ToString();
            double precio = Convert.ToDouble(row["precio_unitario"]);
            return new Articulo(id, nombre, precio);
        }
        public bool Delete(int id)
        {
            bool result = false;
            List<Parametro> parametros = new List<Parametro>() { new Parametro("@id",id) };
            result = (1 == helper.ExecuteSPNonQuery("SP_DELETE_ARTICULOS", parametros));
            return result;
        }

        public List<Articulo> GetAll()
        {
            return TableToList(helper.ExecuteSPQuery("SP_GET_ALL_ARTICULOS",null));
        }

        public Articulo GetById(int id)
        {
            List<Parametro> parametros = new List<Parametro>() { new Parametro("@id",id) };
            var dt = helper.ExecuteSPQuery("SP_GET_BYID_ARTICULOS", parametros);
            if (dt == null || dt.Rows.Count == 0) { return null;}
            return LoadArticulo(dt.Rows[0]);
        }

        public bool Save(Articulo oArticulo)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@id", oArticulo.Id),
                new Parametro("@nombre", oArticulo.Nombre),
                new Parametro("@precio", oArticulo.PrecioUnitario)
            };
            int rows = helper.ExecuteSPNonQuery("SP_SAVE_ARTICULOS", parametros);
            return rows == 1;
        }
    }
}
