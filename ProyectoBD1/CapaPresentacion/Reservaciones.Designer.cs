namespace CapaPresentacion
{
    partial class Reservaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidcartelera = new System.Windows.Forms.TextBox();
            this.txtidpelicula = new System.Windows.Forms.TextBox();
            this.txtidtiposala = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtcantasientos = new System.Windows.Forms.TextBox();
            this.txtfechareser = new System.Windows.Forms.TextBox();
            this.btnreservar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidreservacion = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dtgreservaciones = new System.Windows.Forms.DataGridView();
            this.btnconsultodo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttipoentrada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgreservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Asientos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Reservación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Cartelera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID Pelicula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID Tipo de Sala";
            // 
            // txtidcartelera
            // 
            this.txtidcartelera.Location = new System.Drawing.Point(120, 44);
            this.txtidcartelera.Name = "txtidcartelera";
            this.txtidcartelera.Size = new System.Drawing.Size(100, 20);
            this.txtidcartelera.TabIndex = 7;
            // 
            // txtidpelicula
            // 
            this.txtidpelicula.Location = new System.Drawing.Point(120, 70);
            this.txtidpelicula.Name = "txtidpelicula";
            this.txtidpelicula.Size = new System.Drawing.Size(100, 20);
            this.txtidpelicula.TabIndex = 8;
            // 
            // txtidtiposala
            // 
            this.txtidtiposala.Location = new System.Drawing.Point(120, 96);
            this.txtidtiposala.Name = "txtidtiposala";
            this.txtidtiposala.Size = new System.Drawing.Size(100, 20);
            this.txtidtiposala.TabIndex = 9;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(120, 122);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecliente.TabIndex = 10;
            // 
            // txtcantasientos
            // 
            this.txtcantasientos.Location = new System.Drawing.Point(141, 174);
            this.txtcantasientos.Name = "txtcantasientos";
            this.txtcantasientos.Size = new System.Drawing.Size(100, 20);
            this.txtcantasientos.TabIndex = 11;
            // 
            // txtfechareser
            // 
            this.txtfechareser.Location = new System.Drawing.Point(141, 200);
            this.txtfechareser.Name = "txtfechareser";
            this.txtfechareser.Size = new System.Drawing.Size(100, 20);
            this.txtfechareser.TabIndex = 12;
            // 
            // btnreservar
            // 
            this.btnreservar.Location = new System.Drawing.Point(23, 241);
            this.btnreservar.Name = "btnreservar";
            this.btnreservar.Size = new System.Drawing.Size(75, 23);
            this.btnreservar.TabIndex = 14;
            this.btnreservar.Text = "Reservar";
            this.btnreservar.UseVisualStyleBackColor = true;
            this.btnreservar.Click += new System.EventHandler(this.btnreservar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(236, 241);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 15;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(23, 291);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 16;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID Reservación";
            // 
            // txtidreservacion
            // 
            this.txtidreservacion.Location = new System.Drawing.Point(120, 18);
            this.txtidreservacion.Name = "txtidreservacion";
            this.txtidreservacion.Size = new System.Drawing.Size(100, 20);
            this.txtidreservacion.TabIndex = 18;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(236, 291);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 19;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(130, 241);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 20;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dtgreservaciones
            // 
            this.dtgreservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgreservaciones.Location = new System.Drawing.Point(361, 22);
            this.dtgreservaciones.Name = "dtgreservaciones";
            this.dtgreservaciones.Size = new System.Drawing.Size(353, 313);
            this.dtgreservaciones.TabIndex = 21;
            // 
            // btnconsultodo
            // 
            this.btnconsultodo.Location = new System.Drawing.Point(118, 291);
            this.btnconsultodo.Name = "btnconsultodo";
            this.btnconsultodo.Size = new System.Drawing.Size(102, 23);
            this.btnconsultodo.TabIndex = 22;
            this.btnconsultodo.Text = "Consultar Todo";
            this.btnconsultodo.UseVisualStyleBackColor = true;
            this.btnconsultodo.Click += new System.EventHandler(this.btnconsultodo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tipo Entrada";
            // 
            // txttipoentrada
            // 
            this.txttipoentrada.Location = new System.Drawing.Point(120, 148);
            this.txttipoentrada.Name = "txttipoentrada";
            this.txttipoentrada.Size = new System.Drawing.Size(100, 20);
            this.txttipoentrada.TabIndex = 24;
            // 
            // Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 350);
            this.Controls.Add(this.txttipoentrada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnconsultodo);
            this.Controls.Add(this.dtgreservaciones);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtidreservacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnreservar);
            this.Controls.Add(this.txtfechareser);
            this.Controls.Add(this.txtcantasientos);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.txtidtiposala);
            this.Controls.Add(this.txtidpelicula);
            this.Controls.Add(this.txtidcartelera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reservaciones";
            this.Text = "Reservaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgreservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidcartelera;
        private System.Windows.Forms.TextBox txtidpelicula;
        private System.Windows.Forms.TextBox txtidtiposala;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtcantasientos;
        private System.Windows.Forms.TextBox txtfechareser;
        private System.Windows.Forms.Button btnreservar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidreservacion;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dtgreservaciones;
        private System.Windows.Forms.Button btnconsultodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttipoentrada;
    }
}