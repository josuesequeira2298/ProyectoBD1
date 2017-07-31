using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Promociones
    {
        clsConexion conect = new clsConexion();
        clsConexion consultar = new clsConexion();

        public bool insertarPromociones(int idPromocion, string Nombre, int idPelicula, string Restricciones, string Fechaini, string Fechafin, string Descripcion)
        {
            bool creandoPromociones;

            creandoPromociones = conect.ejecutarInsert("insert into Promociones(idPromocion,Nombre,FK_idPelicula,Restricciones,FechaInicio,FechaFin,Descripcion) values ("+idPromocion+",'"+Nombre+"',"+idPelicula+",'"+Restricciones+"','"+Fechaini+"','"+Fechafin+","+Descripcion+"')");

            if (creandoPromociones)
            {
                return true;
            }
            return false;
        }


        public DataTable CargarPromocion(int idPromociones)
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtPromociones;
            dtPromociones = conecta.ejecutar("select * from Promociones where idPromocion = " + idPromociones);
            return dtPromociones;
        }

        public DataTable CargarPromociones()
        {
            CapaDatos.clsConexion conecta = new CapaDatos.clsConexion();
            DataTable dtPromociones;
            dtPromociones = conecta.ejecutar("select * from Promociones");
            return dtPromociones;
        }

        public bool actualizarPromociones(int idPromocion, string Nombre, int idPelicula, string Restricciones, string Fechaini, string Fechafin, string Descripcion)
        {
            bool actualizandoPromociones;

            actualizandoPromociones = conect.ejecutarInsert("update Promociones set idPromocion ="+idPromocion+" , Nombre = '"+Nombre+"', IdPelicula ="+idPelicula+ ",Restricciones='"+Restricciones+"' , FechaInicio = '"+Fechaini+"', FechaFin = '"+Fechafin+"', Descripcion = "+Descripcion+" where idPromocion ="+idPromocion+" ");
            if (actualizandoPromociones)
            {
                return true;
            }
            return false;
        }

        public bool eliminarPromociones(int idPromociones)
        {
            bool eliminarPromociones;
            eliminarPromociones = conect.ejecutarInsert("DELETE Promociones FROM Promociones where idPromocion = " + idPromociones + "");
            if (eliminarPromociones)
            {
                return true;
            }
            return false;
        }
    }
}
