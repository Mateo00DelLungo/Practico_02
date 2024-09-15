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

        public bool SaveArticulo(ArticuloDTO dto)
        {
            Articulo articulo = Mapper.Set(dto);
            return repositorio.Save(articulo);
        }

        public bool DeleteArticulo(int id)
        {
            return repositorio.Delete(id);
        }
        public List<ArticuloDTO> GetAllArticulo()
        {
            var lstarticulos = repositorio.GetAll();
            return Mapper.GetList(lstarticulos);
        }

        public ArticuloDTO GetByIdArticulo(int id)
        {
            Articulo articulo = repositorio.GetById(id);
            return Mapper.Get(articulo);
        }

        public bool UpdateArticulo(int id, ArticuloDTO dto)
        {
            var articulo = Mapper.Set(dto);
            articulo.Id = id;
            return repositorio.Save(articulo);
        }
    }
}
