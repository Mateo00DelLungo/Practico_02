namespace Proyecto_Practica_02_.Models
{
    public class ArticuloDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }

        public static bool Validar(ArticuloDTO oArticulo)
        {
            bool result = false;
            if(oArticulo != null && oArticulo.Nombre != string.Empty && oArticulo.PrecioUnitario >= 0)
            {
                result = true;
            }
            return result;
        }
        public override string ToString()
        {
            return $"[{Id}] - {Nombre} - ${PrecioUnitario}";
        }
    }
}
