using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class Reservaciones
    {
        clsConexion conect = new clsConexion();

        public bool reservar(int idReservacion, string Nombre_Cliente, int Cantidad_Asientos, string Fehca, int cartelea, int Cartelera_Pelicula_idPelicula, int Cartelera_Sala_Tipo_Sala_idTipo_Sala)
        {
            bool creandoreservacion;

            creandoreservacion = conect.ejecutarInsert("Insert Into");

            if (creandoreservacion)
            {
                return true;
            }
            return false;
        }
        public bool modifreservacion(int idReservacion, string Nombre_Cliente, int Cantidad_Asientos, string Fehca, int cartelea, int Cartelera_Pelicula_idPelicula, int Cartelera_Sala_Tipo_Sala_idTipo_Sala)
        {
            bool modifireser;

            modifireser = conect.ejecutarInsert("update");
            if (modifireser)
            {
                return true;
            }
            return false;
        }
        public bool eliminarreservacion(int idReservacion)
        {
            bool eliminarreservacion;

            eliminarreservacion = conect.ejecutarInsert("DELETE Reservacion FROM Reservacion where idReservacion = " + idReservacion + "");
            if (eliminarreservacion)
            {
                return true;
            }
            return false;
        }
        public DataTable Cargarreservacion(int idreservacion)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtreservacion;
            dtreservacion = conecta.ejecutar("select * from Reservacion where idReservacion = " + idreservacion);
            return dtreservacion;
        }

        public DataTable Cargarreservaciones()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtreservaciones;
            dtreservaciones = conecta.ejecutar("select * from Reservacion");
            return dtreservaciones;
        }
    }
}
