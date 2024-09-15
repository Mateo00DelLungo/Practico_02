using DataDLL.Domain;
using Proyecto_Practica_02_.Models;

namespace Proyecto_Practica_02_.Services
{
    public static class Mapper
    {
        public static Articulo Set(ArticuloDTO dto)
        {
            var articulo = new Articulo()
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                PrecioUnitario = dto.PrecioUnitario
            };
            return articulo;
        }
        public static ArticuloDTO Get(Articulo articulo)
        {
            if(articulo == null){ return null;}
            var dto = new ArticuloDTO()
            {
                Id = articulo.Id,
                Nombre = articulo.Nombre,
                PrecioUnitario = articulo.PrecioUnitario
            };
            return dto;
        }
        public static List<ArticuloDTO> GetList(List<Articulo> articulos)
        {
            if(articulos == null || articulos.Count == 0) { return null; }
            List<ArticuloDTO> lstdto = new List<ArticuloDTO>();
            foreach (Articulo articulo in articulos)
            {
                lstdto.Add(Get(articulo));
            }
            return lstdto;
        }

    }
}
