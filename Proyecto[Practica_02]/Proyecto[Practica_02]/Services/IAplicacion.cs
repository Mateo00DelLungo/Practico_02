using Proyecto_Practica_02_.Models;

namespace Proyecto_Practica_02_.Services
{
    public interface IAplicacion
    {
        List<ArticuloDTO> GetAllArticulo();
        ArticuloDTO GetByIdArticulo(int id);
        bool SaveArticulo(ArticuloDTO oArticulo);
        bool DeleteArticulo(int id);
        bool UpdateArticulo(int id, ArticuloDTO oArticulo);
    }
}
