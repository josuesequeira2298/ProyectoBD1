using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class Sala
    {
        clsConexion conect = new clsConexion();

        public bool insertarsala(int idsala, int idtiposala, string Descripcion, int asientos)
        {
            bool creandosala;

            creandosala = conect.ejecutarInsert("Insert Into");

            if (creandosala)
            {
                return true;
            }
            return false;
        }
        public bool actualizarsala (int idsala, int idtiposala, string Descripcion, int asientos)
        {
            bool actualizandosala;

            actualizandosala = conect.ejecutarInsert("update into");
            if (actualizandosala)
            {
                return true;
            }
            return false;
        }
    }
}
