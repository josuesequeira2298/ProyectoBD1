﻿namespace CapaPresentacion
{
    partial class Peliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtfechaestreno = new System.Windows.Forms.TextBox();
            this.txtfechafin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidpelicula = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnborar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.dtgpeliculas = new System.Windows.Forms.DataGridView();
            this.btnConsultarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(129, 49);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // txtfechaestreno
            // 
            this.txtfechaestreno.Location = new System.Drawing.Point(129, 87);
            this.txtfechaestreno.Name = "txtfechaestreno";
            this.txtfechaestreno.Size = new System.Drawing.Size(100, 20);
            this.txtfechaestreno.TabIndex = 1;
            // 
            // txtfechafin
            // 
            this.txtfechafin.Location = new System.Drawing.Point(129, 125);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(100, 20);
            this.txtfechafin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Estreno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Finalización";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(301, 13);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 6;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Pelicula";
            // 
            // txtidpelicula
            // 
            this.txtidpelicula.Location = new System.Drawing.Point(129, 13);
            this.txtidpelicula.Name = "txtidpelicula";
            this.txtidpelicula.Size = new System.Drawing.Size(100, 20);
            this.txtidpelicula.TabIndex = 8;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(418, 13);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborar
            // 
            this.btnborar.Location = new System.Drawing.Point(301, 56);
            this.btnborar.Name = "btnborar";
            this.btnborar.Size = new System.Drawing.Size(75, 23);
            this.btnborar.TabIndex = 10;
            this.btnborar.Text = "Borrar";
            this.btnborar.UseVisualStyleBackColor = true;
            this.btnborar.Click += new System.EventHandler(this.btnborar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(418, 56);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 11;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Rollo Pelicula.png");
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(418, 96);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 12;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // dtgpeliculas
            // 
            this.dtgpeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpeliculas.Location = new System.Drawing.Point(16, 160);
            this.dtgpeliculas.Name = "dtgpeliculas";
            this.dtgpeliculas.Size = new System.Drawing.Size(477, 282);
            this.dtgpeliculas.TabIndex = 13;
            // 
            // btnConsultarTodo
            // 
            this.btnConsultarTodo.Location = new System.Drawing.Point(282, 94);
            this.btnConsultarTodo.Name = "btnConsultarTodo";
            this.btnConsultarTodo.Size = new System.Drawing.Size(94, 25);
            this.btnConsultarTodo.TabIndex = 14;
            this.btnConsultarTodo.Text = "Consultar Todo";
            this.btnConsultarTodo.UseVisualStyleBackColor = true;
            this.btnConsultarTodo.Click += new System.EventHandler(this.btnConsultarTodo_Click);
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.btnConsultarTodo);
            this.Controls.Add(this.dtgpeliculas);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnborar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtidpelicula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtfechaestreno);
            this.Controls.Add(this.txtnombre);
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgpeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtfechaestreno;
        private System.Windows.Forms.TextBox txtfechafin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidpelicula;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnborar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.DataGridView dtgpeliculas;
        private System.Windows.Forms.Button btnConsultarTodo;
    }
}