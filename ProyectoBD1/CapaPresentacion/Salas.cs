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
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Sala sala = new CapaNegocio.Sala();

            try
            {
                sala.insertarsala(Int32.Parse(txtidsala.Text), Int32.Parse(txtidtiposala.Text), Int32.Parse(txtasientos.Text));


                MessageBox.Show("Sala Agregada correctamente");
                Limpiar();
            }
            catch
            {
                MessageBox.Show("Error Desconocido");
            }
        }

        private void Limpiar()
        {
            txtidsala.Text = "";
            txtidtiposala.Text = "";
            txtasientos.Text = "";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Sala sala = new CapaNegocio.Sala();
            try
            {
                sala.actualizarsala(Int32.Parse(txtidsala.Text), Int32.Parse(txtidtiposala.Text), Int32.Parse(txtasientos.Text));

                MessageBox.Show("Sala Modificada correctamente");
                Limpiar();
            }
            catch
            {
                MessageBox.Show("Error Desconocido");
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            CapaNegocio.Sala salas = new CapaNegocio.Sala();
            DataTable dtSalas = new DataTable();

            dtSalas = salas.BuscarSalas();
            dtgSalas.DataSource = dtSalas;

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Sala salas = new CapaNegocio.Sala();
            DataTable dtSalas = new DataTable();

            dtSalas = salas.buscar(Int32.Parse(txtidsala.Text));
            dtgSalas.DataSource = dtSalas;
        }

        private void txtidsala_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            CapaNegocio.Sala sala = new CapaNegocio.Sala();
            try
            {
                sala.EliminarSala(Int32.Parse(txtidsala.Text));
                
                MessageBox.Show("Sala Eliminada");
                Limpiar();
            }
            catch
            {
                MessageBox.Show("Error Desconocido");
            }
        }

        private void dtgSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
