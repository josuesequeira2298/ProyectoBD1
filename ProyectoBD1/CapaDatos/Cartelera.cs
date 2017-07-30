using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class Cartelera
    {
        clsConexion conect = new clsConexion();
        clsConexion consultar = new clsConexion();

        public bool insertarCartelera(int idCartelera, int idPelicula, int idsala, int fecha, int Horaini, int Horafin )
        {
            bool creandocartelera;

            creandocartelera = conect.ejecutarInsert("insert into Cartelera");

            if (creandocartelera)
            {
                return true;
            }
            return false;
        }


        public DataTable CargarCartelera(int idCartelera)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtCartelera;
            dtCartelera = conecta.ejecutar("select * from Cartelera where idCartelera = " + idCartelera);
            return dtCartelera;
        }

        public DataTable CargarCarteleras()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtCartelera;
            dtCartelera = conecta.ejecutar("select * from Cartelera");
            return dtCartelera;
        }

        public bool actualizarCartelera(int idCartelera, int idPelicula, int idsala, int fecha, int Horaini, int Horafin)
        {
            bool actualizandoCartelera;

            actualizandoCartelera = conect.ejecutarInsert("UPDATE Pelicula SET ");
            if (actualizandoCartelera)
            {
                return true;
            }
            return false;
        }

        public bool eliminarCartelera(int idCartelera)
        {
            bool eliminarCartelera;
            eliminarCartelera = conect.ejecutarInsert("DELETE Cartelera FROM Cartelera where idCartelera = " + idCartelera + "");
            if (eliminarCartelera)
            {
                return true;
            }
            return false;
        }
    }
}
