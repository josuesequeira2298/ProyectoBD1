﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace CapaDatos
{
    public class Peliculas
    {
        clsConexion conect = new clsConexion();

        public bool insertarpelicula (int idPelicula, string Nombre, string Fecha_Estreno, string Fecha_Salida)
        {
            bool creandopelicula;

            creandopelicula = conect.ejecutarInsert("insert into Pelicula(idPelicula,Nombre, Fecha_Estreno,Fecha_Salida) values ("+ idPelicula +" , '"+ Nombre + "', '"+ Fecha_Estreno +"','"+ Fecha_Salida +"')");

            if (creandopelicula)
            {
                return true;
            }
            return false;   
        }
    }
}
