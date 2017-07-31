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
    public partial class Promociones : Form
    {
        public Promociones()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Promociones Cartelera = new CapaNegocio.Promociones();

            try
            {
                Cartelera.insertarPromociones(Int32.Parse(txtidpromo.Text), txtnombre.Text, Int32.Parse(txtidpelicula.Text), txtrestriciones.Text, txtfechaini.Text, txtfechafin.Text);

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
            CapaNegocio.Promociones Promociones = new CapaNegocio.Promociones();
            DataTable dtPromociones = new DataTable();

            dtPromociones = Promociones.buscarPromocion(Int32.Parse(txtidpromo.Text));
            dtgpromociones.DataSource = dtPromociones;
        }

        private void btnborar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Promociones Promociones = new CapaNegocio.Promociones();
            try
            {
                Promociones.eliminarPromociones(Int32.Parse(txtidpromo.Text));

                MessageBox.Show("Promocion Eliminada");
                Limpiar();
            }
            catch
            {
                MessageBox.Show("Error Desconocido");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CapaNegocio.Promociones Promociones = new CapaNegocio.Promociones();
            if (Promociones.actualizarPromociones(Int32.Parse(txtidpromo.Text), txtnombre.Text, Int32.Parse(txtidpelicula.Text), txtrestriciones.Text, txtfechaini.Text, txtfechafin.Text))
            {
                MessageBox.Show("Promocion modificada correctamente");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error Desconocido");
            }
        }

        private void Limpiar()
        {
            txtidpromo.Text = " ";
            txtnombre.Text = " ";
            txtidpelicula.Text = " ";
            txtrestriciones.Text = " ";
            txtfechaini.Text = " ";
            txtfechafin.Text = " ";
        }

        private void btnconsultartodo_Click(object sender, EventArgs e)
        {
            CapaNegocio.Promociones Promociones = new CapaNegocio.Promociones();
            DataTable dtPromociones = new DataTable();

            dtPromociones = Promociones.BuscarPromociones();
            dtgpromociones.DataSource = dtPromociones;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
