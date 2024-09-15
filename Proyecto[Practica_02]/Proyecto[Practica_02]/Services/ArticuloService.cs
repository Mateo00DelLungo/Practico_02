using DataDLL.Data;
using DataDLL.Domain;
using DataDLL.Interfaces;
using Proyecto_Practica_02_.Models;

namespace Proyecto_Practica_02_.Services
{
    public class ArticuloService : IAplicacion
    {
        private readonly IArticuloRepository repositorio;
        public ArticuloService()
        {
            repositorio = new ArticuloRepositorio();
        }
        public bool SaveArticulo(ArticuloDTO oArticulodto)
        {
            int id = oArticulodto.Id;
            string nom = oArticulodto.Nombre;
            double prec = oArticulodto.PrecioUnitario;
            Articulo articulo = new Articulo(id, nom, prec);
            return repositorio.Save(articulo);
        }

        public bool DeleteArticulo(int id)
        {
            throw new NotImplementedException();
        }

        public List<ArticuloDTO> GetAllArticulo()
        {
            throw new NotImplementedException();
        }

        public ArticuloDTO GetByIdArticulo(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateArticulo(ArticuloDTO oArticulo)
        {
            throw new NotImplementedException();
        }
    }
}
