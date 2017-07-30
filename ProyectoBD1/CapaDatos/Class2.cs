using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class Class2
    {
        static string cadenaConexion = "Data Source=JOSU;Initial Catalog=ProyectoBD;Integrated Security=True";
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
