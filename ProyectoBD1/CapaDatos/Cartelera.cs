﻿using System;
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

        public bool insertarCartelera(int idCartelera, int idPelicula, int idsala, string fecha, string Horaini, string Horafin )
        {
            bool creandocartelera;

            creandocartelera = conect.ejecutarInsert("insert into Cartelera (idCartelera,FK_idPelicula,FK_idSala,Fecha,Hora_Inicio,Hora_Fin) values("+idCartelera+","+idPelicula+","+idsala+",'"+fecha+"','"+Horaini+"','"+Horafin +"')");

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

        public bool actualizarCartelera(int idCartelera, int idPelicula, int idsala, string fecha, string Horaini, string Horafin)
        {
            bool actualizandoCartelera;

            actualizandoCartelera = conect.ejecutarInsert("update Cartelera set FK_idPelicula = "+idPelicula+", FK_idSala = "+idsala+",Fecha='"+fecha+"',Hora_Inicio='"+Horaini+"', Hora_Fin='"+Horafin+"' where idCartelera="+idCartelera+"");
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
