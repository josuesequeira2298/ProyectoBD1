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

        public bool insertarsala(int idsala, int idtiposala, int asientos)
        {
            bool creandosala;

            creandosala = conect.ejecutarInsert("insert into Sala (idSalas,Cantidad_Asientos,FK_Sala_Tipo_Sala) values ("+idsala+","+asientos+","+idtiposala+")");

            if (creandosala)
            {
                return true;
            }
            return false;
        }
        public bool actualizarsala (int idsala, int idtiposala, int asientos)
        {
            bool actualizandosala;

            actualizandosala = conect.ejecutarInsert("update Sala set Cantidad_Asientos = "+asientos+", FK_Sala_Tipo_Sala = "+idtiposala+" where idSalas="+idsala+"");
            if (actualizandosala)
            {
                return true;
            }
            return false;
        }
        
        public bool EliminarSala(int idSala)
        {
            bool EliminarSala;
            EliminarSala = conect.ejecutarInsert("DELETE Sala FROM Sala where idSalas = " + idSala + "");
            if (EliminarSala)
            {
                return true;
            }
            return false;
        }
        public DataTable CargarSala(int idsala)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtSala;
            dtSala = conecta.ejecutar("select * from Sala where idSalas ="  + idsala);
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
