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
        public DataTable CargarVentasPeliculas(int idPelicula)
        {
            return new CapaDatos.Reportes().CargarVentaspelicula(idPelicula);
        }
        public DataTable CargarVentasFuncion(int idCartelera)
        {
            return new CapaDatos.Reportes().CargarVentasfuncion(idCartelera);
        }
        public DataTable CargarVentasLapso(string fechaIni, string fechaFin)
        {
            return new CapaDatos.Reportes().CargarVentaslapso(fechaIni,fechaFin);
        }
        public DataTable CargarVentasTotales()
        {
            return new CapaDatos.Reportes().CargarVentasTotales();
        }
        public DataTable CargarVentasPorEntrada(int Entrada)
        {
            return new CapaDatos.Reportes().CargarVentasPorEntrada(Entrada);
        }
    }
}
