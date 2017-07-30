using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class Sala
    {
        public bool insertarsala(int idsala, int idtiposala, int asientos)
        {
            return new CapaDatos.Sala().insertarsala(idsala, idtiposala, asientos);
        }
        public DataTable buscar(int idsala)
        {
            return new CapaDatos.Sala().CargarSala(idsala);
        }

        public DataTable BuscarSalas()
        {
            return new CapaDatos.Sala().CargarSalas();
        }

        public bool actualizarsala(int idsala, int idtiposala, int asientos)
        {
            return new CapaDatos.Sala().actualizarsala(idsala, idtiposala, asientos);
        }
        
        public bool EliminarSala(int idSala)
        {
            return new CapaDatos.Sala().EliminarSala(idSala);
        }
    }
}
