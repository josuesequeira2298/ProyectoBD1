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
    }
}
