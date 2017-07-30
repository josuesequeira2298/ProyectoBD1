﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class Peliculas
    {
        

        public bool insertarpelicula(int idPelicula, string Nombre, string Fecha_Estreno, string Fecha_Salida)
        {
            return new CapaDatos.Peliculas().insertarpelicula(idPelicula, Nombre, Fecha_Estreno, Fecha_Salida);

        }

        //-------------------------------------------------
        public DataTable buscar(int idpelicula)
        {

            
            return new CapaDatos.Peliculas().buscar(idpelicula);
        }

        //-------------------------------------------------
        public DataTable buscarPelicula(int idPelicula)
        {
            DataTable dt = new DataTable();


            dt = buscarPelicula(idPelicula);
            return dt;
        }
        //-------------------------------------------------

        public DataTable buscarPelicula(int idPelicula, string Nombre, string Fecha_Estreno, string Fecha_Salida)
        {
            return new CapaDatos.Peliculas().buscar(idPelicula);
        }

        //-------------------------------------------------
        public bool actualizarpelicula(int idPelicula, string Nombre, string Fecha_Estreno, string Fecha_Salida)
        {
            return new CapaDatos.Peliculas().actualizarpelicula(idPelicula, Nombre, Fecha_Estreno, Fecha_Salida);
        }
        public bool eliminarpelicula(int idPelicula, string Nombre, string Fecha_Estreno, string Fecha_Salida)
        {
            return new CapaDatos.Peliculas().eliminarpelicula(idPelicula, Nombre, Fecha_Estreno, Fecha_Salida);
        }
    }
}
