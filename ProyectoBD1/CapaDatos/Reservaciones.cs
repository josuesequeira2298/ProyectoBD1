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

        public bool reservar(int idReservacion, string Nombre_Cliente, int Cantidad_Asientos, string Fehca, string Estado, int cartelea, int Cartelera_Pelicula_idPelicula, int Cartelera_Sala_Tipo_Sala_idTipo_Sala)
        {
            bool creandoreservacion;

            creandoreservacion = conect.ejecutarInsert("Insert Into");

            if (creandoreservacion)
            {
                return true;
            }
            return false;
        }
        public bool modifreservacion(int idReservacion, string Nombre_Cliente, int Cantidad_Asientos, string Fehca, string Estado, int cartelea, int Cartelera_Pelicula_idPelicula, int Cartelera_Sala_Tipo_Sala_idTipo_Sala)
        {
            bool modifireser;

            modifireser = conect.ejecutarInsert("update");
            if (modifireser)
            {
                return true;
            }
            return false;
        }
        public bool eliminarreservacion(int idReservacion, string Nombre_Cliente, int Cantidad_Asientos, string Fehca, string Estado, int cartelea, int Cartelera_Pelicula_idPelicula, int Cartelera_Sala_Tipo_Sala_idTipo_Sala)
        {
            bool eliminarreservacion;

            eliminarreservacion = conect.ejecutarInsert("delete");
            if (eliminarreservacion)
            {
                return true;
            }
            return false;
        }
    }
}
