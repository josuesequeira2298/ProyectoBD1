using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Reportes
    {
        public DataTable CargarVentasPeliculas()
        {
            return new CapaDatos.Reportes().CargarVentaspelicula();
        }
        public DataTable CargarVentasFuncion()
        {
            return new CapaDatos.Reportes().CargarVentasfuncion();
        }
        public DataTable CargarVentasLapso()
        {
            return new CapaDatos.Reportes().CargarVentaslapso();
        }
        public DataTable CargarVentasTotales()
        {
            return new CapaDatos.Reportes().CargarVentasTotales();
        }
    }
}
