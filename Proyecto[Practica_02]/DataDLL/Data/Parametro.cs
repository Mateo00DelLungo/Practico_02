using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Data
{
    public class Parametro
    {
        public string Nombre {get;set;}
        public object Valor {get;set;}
        public Parametro(string nom, object val)
        {
            Nombre = nom;
            Valor = val;
        }
        public static SqlCommand LoadToCMD(List<Parametro> parametros, SqlCommand cmd)
        {
            foreach (Parametro p in parametros) 
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            return cmd;
        }
    }
}
