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

            dtReportes = Reportes.CargarVentasPeliculas();
            txtventastotales.Text = "1";
        }

        private void btnventfuncion_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reportes Reportes = new CapaNegocio.Reportes();
            DataTable dtReportes = new DataTable();

            dtReportes = Reportes.CargarVentasFuncion();
            txtventastotales.Text = "2";
        }

        private void btnventaslapso_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reportes Reportes = new CapaNegocio.Reportes();
            DataTable dtReportes = new DataTable();

            dtReportes = Reportes.CargarVentasLapso();
            txtventastotales.Text = "3";
        }

        private void btnventastotales_Click(object sender, EventArgs e)
        {
            CapaNegocio.Reportes Reportes = new CapaNegocio.Reportes();
            DataTable dtReportes = new DataTable();

            dtReportes = Reportes.CargarVentasTotales();
            txtventastotales.Text = "4";

           
        }
    }
}
