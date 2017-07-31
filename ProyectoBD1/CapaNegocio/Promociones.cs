using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Promociones
    {
        public bool insertarPromociones(int idPromocion, string Nombre, int idPelicula, string Restricciones, string Fechaini, string Fechafin)
        {
            return new CapaDatos.Promociones().insertarPromociones(idPromocion,Nombre,idPelicula, Restricciones, Fechaini, Fechafin);

        }


        public DataTable buscarPromocion(int idCartelera)
        {
            return new CapaDatos.Promociones().CargarPromocion(idCartelera);
        }

        public DataTable BuscarPromociones()
        {
            return new CapaDatos.Promociones().CargarPromociones();
        }


        public bool actualizarPromociones(int idPromocion, string Nombre, int idPelicula, string Restricciones, string Fechaini, string Fechafin)
        {
            return new CapaDatos.Promociones().actualizarPromociones(idPromocion, Nombre, idPelicula, Restricciones, Fechaini, Fechafin);
        }
        public bool eliminarPromociones(int idPromociones)
        {
            return new CapaDatos.Promociones().eliminarPromociones(idPromociones);
        }
    }
}
