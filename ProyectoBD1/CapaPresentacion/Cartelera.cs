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
    public partial class Cartelera : Form
    {
        public Cartelera()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Cartelera Cartelera = new CapaNegocio.Cartelera();
            
            try
            {
                Cartelera.insertarCartelera(Int32.Parse(txtidcartelera.Text), Int32.Parse(txtidpelicula.Text),Int32.Parse(txtidsala.Text), txtfecha.Text,txthoraini.Text, txthorafin.Text);

                MessageBox.Show("Cartelera agregada correctamente");
                Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Desconocido");
                Limpiar();
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Cartelera Cartelera = new CapaNegocio.Cartelera();
            DataTable dtCartelera = new DataTable();

            dtCartelera = Cartelera.buscar(Int32.Parse(txtidcartelera.Text));
            dtgcartelera.DataSource = dtCartelera;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Cartelera Cartelera = new CapaNegocio.Cartelera();
            if (Cartelera.actualizarCartelera(Int32.Parse(txtidcartelera.Text), Int32.Parse(txtidpelicula.Text), Int32.Parse(txtidsala.Text), txtfecha.Text, txthoraini.Text, txthorafin.Text))
            {
                MessageBox.Show("Cartelera modificada correctamente");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error Desconocido");
            }
        }

        private void Limpiar()
        {
            txtidcartelera.Text = " ";
            txtidpelicula.Text = " ";
            txtidsala.Text = " ";
            txthoraini.Text = " ";
            txthorafin.Text = " ";
            txtfecha.Text = " ";
        }

        private void btnconsultodo_Click(object sender, EventArgs e)
        {
            CapaNegocio.Cartelera peliculas = new CapaNegocio.Cartelera();
            DataTable dtCartelera = new DataTable();

            dtCartelera = peliculas.BuscarCarteleras();
            dtgcartelera.DataSource = dtCartelera;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Cartelera Cartelera = new CapaNegocio.Cartelera();
            try
            {
                Cartelera.eliminarCartelera(Int32.Parse(txtidcartelera.Text));

                MessageBox.Show("Cartelera Eliminada");
                Limpiar();
            }
            catch
            {
                MessageBox.Show("Error Desconocido");
            }
        }
    }
}
