using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Domain
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public Articulo(int id, string nombre, double precioUnitario)
        {
            Id = id;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
        }
    }
}
