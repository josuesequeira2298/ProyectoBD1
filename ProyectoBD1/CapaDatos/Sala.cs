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
        public bool eliminarsala(int idsala, int idtiposala, string Descripcion, int asientos)
        {
            bool eliminarsala;

            eliminarsala = conect.ejecutarInsert("Delete");
            if (eliminarsala)
            {
                return true;
            }
            return false;
        }
        public DataTable CargarSala(int idsala)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtSala;
            dtSala = conecta.ejecutar("select * from Sala ="  + idsala);
            return dtSala;
        }

        public DataTable CargarSalas()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtSalas;
            dtSalas = conecta.ejecutar("select * from Sala");
            return dtSalas;
        }
    }
}
