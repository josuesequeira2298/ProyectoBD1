﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Peliculas
    {
        clsConexion conect = new clsConexion();
        clsConexion consultar = new clsConexion();

        public bool insertarpelicula(int idPelicula, string Nombre, string Fecha_Estreno, string Fecha_Salida)
        {
            bool creandopelicula;

            creandopelicula = conect.ejecutarInsert("insert into Pelicula(idPelicula,Nombre, Fecha_Estreno,Fecha_Salida) values (" + idPelicula + " , '" + Nombre + "', '" + Fecha_Estreno + "','" + Fecha_Salida + "')");

            if (creandopelicula)
            {
                return true;
            }
            return false;
        }

        public DataTable buscar(int idpelicula)
        {
            SqlCommand _comando = clsConexion.CrearComandoProc();
            _comando.CommandText = "Select * from Pelicula";
            return clsConexion

            //DataTable dtPeliculas = new DataTable();
            
            //dtPeliculas = conect.ejecutar("select Nombre,Fecha_Estreno,Fecha_Salida from Pelicula where idPelicula = " + idpelicula);
            //return dtPeliculas;
        }

        //public DataTable Pelicula(int idPelicula)
        //{
        //    DataTable dt = new DataTable();
        //    string consulta = "select * from Pelicula where idPelicula = " + idPelicula;

        //    dt = clsConexion.consultar(consulta);
        //    return dt;
        //}

        public bool actualizarpelicula(int idPelicula, string Nombre, string Fecha_Estreno, string Fecha_Salida)
        {
            bool actualizandopeli;

            actualizandopeli = conect.ejecutarInsert("UPDATE Pelicula SET Nombre = '" + Nombre + "', Fecha_Estreno ='" + Fecha_Estreno + "', Fecha_Salida ='" + Fecha_Salida + "' where idPelicula = " + idPelicula + "");
            if (actualizandopeli)
            {
                return true;
            }
            return false;
        }

        public bool eliminarpelicula(int idPelicula, string Nombre, string Fecha_Estreno, string Fecha_Salida)
        {
            bool eliminarpeli;
            eliminarpeli = conect.ejecutarInsert("DELETE Pelicula FROM Pelicula where idPelicula = " + idPelicula + "");
            if (eliminarpeli)
            {
                return true;
            }
            return false;
        }
    }
}
