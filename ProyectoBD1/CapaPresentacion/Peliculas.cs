using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace CapaPresentacion
{
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Peliculas pelicula = new CapaNegocio.Peliculas();

            if (pelicula.insertarpelicula(Int32.Parse(txtidpelicula.Text), txtnombre.Text, txtfechaestreno.Text, txtfechafin.Text))
            {
                MessageBox.Show("Película agregada correctamente");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Limpiar()
        {
            txtidpelicula.Text = " ";
            txtnombre.Text = " ";
            txtfechaestreno.Text = " ";
            txtfechafin.Text = " ";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Peliculas peliculas = new CapaNegocio.Peliculas();
            DataTable dtPeliculas = new DataTable();

            dtPeliculas = peliculas.buscar(Int32.Parse(txtidpelicula.Text));
             DataSource = dtPeliculas;
        }
    }
}
