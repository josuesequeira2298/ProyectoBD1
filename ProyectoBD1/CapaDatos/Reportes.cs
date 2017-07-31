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
        public DataTable CargarVentaspelicula(int idPelicula)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtventaspelicula;
            dtventaspelicula = conecta.ejecutar("select sum(t2.Precio) as Total_Por_Pelicula from Reservacion t1 left outer join Tipo_Sala t2 on t1.FK_idTipoSala = t2.idTipo_Sala where t1.FK_idPelicula = "+idPelicula+"");
            return dtventaspelicula;
        }
        public DataTable CargarVentasfuncion(int idCartelera)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtventasfuncion;
            dtventasfuncion = conecta.ejecutar("select sum(t2.Precio) as Total_Por_Funcion from Reservacion t1 left outer join Tipo_Sala t2 on t1.FK_idTipoSala = t2.idTipo_Sala where t1.FK_idCartelera = "+idCartelera+"");
            return dtventasfuncion;
        }
        public DataTable CargarVentaslapso(string fechaIni,string fechaFin)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtventaslapso;
            dtventaslapso = conecta.ejecutar("select sum(t2.Precio) as Total_Por_Fechas from Reservacion t1 left outer join Tipo_Sala t2 on t1.FK_idTipoSala = t2.idTipo_Sala where t1.Fecha = '"+fechaIni+"' or Fecha = '"+fechaFin+"'");
            return dtventaslapso;
        }
        public DataTable CargarVentasTotales()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtventastotales;
            dtventastotales = conecta.ejecutar("select sum(t2.Precio) as Ventas_Totales from Reservacion t1 left outer join Tipo_Sala t2 on t1.FK_idTipoSala = t2.idTipo_Sala where t1.idReservacion != 0");
            return dtventastotales;
        }
        public DataTable CargarVentasPorEntrada(int Entrada)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtventastotales;
            dtventastotales = conecta.ejecutar("select sum(t2.Precio) as Ventas_Por_Tipo_Entrada from Reservacion t1 left outer join Tipo_Sala t2 on t1.FK_idTipoSala = t2.idTipo_Sala where t1.FK_idTipo_Entrada = "+Entrada+"");
            return dtventastotales;
        }
    }
}

