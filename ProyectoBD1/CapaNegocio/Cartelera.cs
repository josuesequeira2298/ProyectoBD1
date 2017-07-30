using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cartelera
    {
        public bool insertarCartelera(int idCartelera, int idPelicula, int idsala, string fecha, string Horaini, string Horafin)
        {
            return new CapaDatos.Cartelera().insertarCartelera(idCartelera, idPelicula, idsala, fecha, Horaini, Horafin);

        }


        public DataTable buscar(int idCartelera)
        {
            return new CapaDatos.Cartelera().CargarCartelera(idCartelera);
        }

        public DataTable BuscarCarteleras()
        {
            return new CapaDatos.Cartelera().CargarCarteleras();
        }


        public bool actualizarCartelera(int idCartelera, int idPelicula, int idsala, string fecha, string Horaini, string Horafin)
        {
            return new CapaDatos.Cartelera().actualizarCartelera(idCartelera, idPelicula, idsala, fecha, Horaini, Horafin);
        }
        public bool eliminarCartelera(int idCartelera)
        {
            return new CapaDatos.Cartelera().eliminarCartelera(idCartelera);
        }
    }
}
