﻿using System;
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

            if(pelicula.insertarpelicula(Int32.Parse(txtidpelicula.Text), txtnombre.Text, txtfechaestreno.Text, txtfechafin.Text))
            {
                MessageBox.Show("Birra para todos si sirvió");
                Limpiar();
            }
            MessageBox.Show("Playos más tontos, no sirve");
        }

        private void Limpiar()
        {
            txtidpelicula.Text = " ";
            txtnombre.Text = " ";
            txtfechaestreno.Text = " ";
            txtfechafin.Text = " ";
        }
    }
}
