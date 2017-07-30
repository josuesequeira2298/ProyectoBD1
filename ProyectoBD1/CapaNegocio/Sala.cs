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
        public bool insertarsala(int idsala, int idtiposala, string Descripcion, int asientos)
        {
            return new CapaDatos.Sala().insertarsala(idsala, idtiposala, Descripcion, asientos);
        }

        public bool actualizarsala(int idsala, int idtiposala, string Descripcion, int asientos)
        {
            return new CapaDatos.Sala().actualizarsala(idsala, idtiposala, Descripcion, asientos);
        }
        public bool eliminarsala(int idsala, int idtiposala, string Descripcion, int asientos)
        {
            return new CapaDatos.Sala().eliminarsala(idsala, idtiposala, Descripcion, asientos);
        }
    }
}
