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

    }
}
