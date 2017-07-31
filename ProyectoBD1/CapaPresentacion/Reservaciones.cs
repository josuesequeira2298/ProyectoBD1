using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Reservaciones : Form
    {
        public Reservaciones()
        {
            InitializeComponent();
        }

        private void btnreservar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reservacion reservacion = new CapaNegocio.Reservacion();

            if (reservacion.reservar(Int32.Parse(txtidreservacion.Text), txtnombrecliente.Text, Int32.Parse(txtcantasientos.Text), txtfechareser.Text, Int32.Parse(txtidcartelera.Text), Int32.Parse(txtidpelicula.Text), Int32.Parse(txtidtiposala.Text), Int32.Parse(txttipoentrada.Text)))
            {
                MessageBox.Show("Reservación Agregada");
                Limpiar();
            }else
            {
                MessageBox.Show("Error Desconocido");
            }
        }

        private void Limpiar()
        {
            txtidreservacion.Text = " ";
            txtidcartelera.Text = " ";
            txtidpelicula.Text = " ";
            txtidtiposala.Text = " ";
            txtnombrecliente.Text = " ";
            txtcantasientos.Text = " ";
            txtfechareser.Text = " ";
         
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reservacion reservacion = new CapaNegocio.Reservacion();

            if (reservacion.modifireser(Int32.Parse(txtidreservacion.Text), txtnombrecliente.Text, Int32.Parse(txtcantasientos.Text), txtfechareser.Text, Int32.Parse(txtidcartelera.Text), Int32.Parse(txtidpelicula.Text), Int32.Parse(txtidtiposala.Text), Int32.Parse(txttipoentrada.Text)))
            {
                MessageBox.Show("Reservación Modificada");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error Desconocido");
            }
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reservacion reservacion = new CapaNegocio.Reservacion();

            if(reservacion.eliminarreser(Int32.Parse(txtidreservacion.Text)))
            {
                MessageBox.Show("Reservación Eliminada");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error Desconocido");
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reservacion reservacion = new CapaNegocio.Reservacion();
            DataTable dtreservacion = new DataTable();

            dtreservacion = reservacion.buscarreservacion(Int32.Parse(txtidreservacion.Text));
            dtgreservaciones.DataSource = dtreservacion;
        }

        private void btnconsultodo_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reservacion reservacion = new CapaNegocio.Reservacion();
            DataTable dtreservaciones = new DataTable();

            dtreservaciones = reservacion.Buscarreservaciones();
            dtgreservaciones.DataSource = dtreservaciones;
        }
    }
}
