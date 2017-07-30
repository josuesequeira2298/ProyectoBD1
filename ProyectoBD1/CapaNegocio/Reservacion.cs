using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class Reservacion
    {
        public bool reservar(int idReservacion, string Nombre_Cliente, int Cantidad_Asientos, string Fehca, string Estado, int cartelea, int Cartelera_Pelicula_idPelicula, int Cartelera_Sala_Tipo_Sala_idTipo_Sala)
        {
            return new CapaDatos.Reservaciones().reservar(idReservacion, Nombre_Cliente, Cantidad_Asientos, Fehca, Estado, cartelea, Cartelera_Pelicula_idPelicula, Cartelera_Sala_Tipo_Sala_idTipo_Sala);
            
        }
        public bool modifireser(int idReservacion, string Nombre_Cliente, int Cantidad_Asientos, string Fehca, string Estado, int cartelea, int Cartelera_Pelicula_idPelicula, int Cartelera_Sala_Tipo_Sala_idTipo_Sala)
        {
            return new CapaDatos.Reservaciones().modifreservacion(idReservacion, Nombre_Cliente, Cantidad_Asientos, Fehca, Estado, cartelea, Cartelera_Pelicula_idPelicula, Cartelera_Sala_Tipo_Sala_idTipo_Sala);
        }
        public bool eliminarreser(int idReservacion, string Nombre_Cliente, int Cantidad_Asientos, string Fehca, string Estado, int cartelea, int Cartelera_Pelicula_idPelicula, int Cartelera_Sala_Tipo_Sala_idTipo_Sala)
        {
            return new CapaDatos.Reservaciones().eliminarreservacion(idReservacion, Nombre_Cliente, Cantidad_Asientos, Fehca, Estado, cartelea, Cartelera_Pelicula_idPelicula, Cartelera_Sala_Tipo_Sala_idTipo_Sala);
        }
        public DataTable buscarreservacion(int idreservacion)
        {
            return new CapaDatos.Reservaciones().Cargarreservacion(idreservacion);
        }

        public DataTable Buscarreservaciones()
        {
            return new CapaDatos.Reservaciones().Cargarreservaciones();
        }
    }
    
}
