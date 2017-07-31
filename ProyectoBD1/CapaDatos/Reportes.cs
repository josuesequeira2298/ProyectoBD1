using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Reportes
    {
        public DataTable CargarVentaspelicula()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtventaspelicula;
            dtventaspelicula = conecta.ejecutar("");
            return dtventaspelicula;
        }
        public DataTable CargarVentasfuncion()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtventasfuncion;
            dtventasfuncion = conecta.ejecutar("");
            return dtventasfuncion;
        }
        public DataTable CargarVentaslapso()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtventaslapso;
            dtventaslapso = conecta.ejecutar("");
            return dtventaslapso;
        }
        public DataTable CargarVentasTotales()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtventastotales;
            dtventastotales = conecta.ejecutar("");
            return dtventastotales;
        }
    }
}

