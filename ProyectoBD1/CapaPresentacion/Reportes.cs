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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnventaspelicula_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reportes Reportes = new CapaNegocio.Reportes();
            DataTable dtReportes = new DataTable();

            dtReportes = Reportes.CargarVentasPeliculas(Int32.Parse(txtidpelicula.Text));
            dtgReportes.DataSource = dtReportes;
        }

        private void btnventfuncion_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reportes Reportes = new CapaNegocio.Reportes();
            DataTable dtReportes = new DataTable();

            dtReportes = Reportes.CargarVentasFuncion(Int32.Parse(txtidcartelera.Text));
            dtgReportes.DataSource = dtReportes;
        }

        private void btnventaslapso_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reportes Reportes = new CapaNegocio.Reportes();
            DataTable dtReportes = new DataTable();

            dtReportes = Reportes.CargarVentasLapso(txtfechaini.Text,txtfechafin.Text);
            dtgReportes.DataSource = dtReportes;
        }

        private void btnventastotales_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reportes Reportes = new CapaNegocio.Reportes();
            DataTable dtReportes = new DataTable();

            dtReportes = Reportes.CargarVentasTotales();
            dtgReportes.DataSource = dtReportes;


        }

        private void btnextra_Click(object sender, EventArgs e)
        {

            CapaNegocio.Reportes Reportes = new CapaNegocio.Reportes();
            DataTable dtReportes = new DataTable();

            dtReportes = Reportes.CargarVentasPorEntrada(Int32.Parse(txtTipoEntrada.Text));
            dtgReportes.DataSource = dtReportes;


        }
    }
}
