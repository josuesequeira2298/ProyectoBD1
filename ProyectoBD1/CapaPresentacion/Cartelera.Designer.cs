namespace CapaPresentacion
{
    partial class Cartelera
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidcartelera = new System.Windows.Forms.TextBox();
            this.txtidpelicula = new System.Windows.Forms.TextBox();
            this.txtidsala = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txthoraini = new System.Windows.Forms.TextBox();
            this.txthorafin = new System.Windows.Forms.TextBox();
            this.dtgcartelera = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnconsultodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcartelera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cartelera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora Fin";
            // 
            // txtidcartelera
            // 
            this.txtidcartelera.Location = new System.Drawing.Point(95, 13);
            this.txtidcartelera.Name = "txtidcartelera";
            this.txtidcartelera.Size = new System.Drawing.Size(100, 20);
            this.txtidcartelera.TabIndex = 6;
            // 
            // txtidpelicula
            // 
            this.txtidpelicula.Location = new System.Drawing.Point(95, 39);
            this.txtidpelicula.Name = "txtidpelicula";
            this.txtidpelicula.Size = new System.Drawing.Size(100, 20);
            this.txtidpelicula.TabIndex = 7;
            // 
            // txtidsala
            // 
            this.txtidsala.Location = new System.Drawing.Point(95, 65);
            this.txtidsala.Name = "txtidsala";
            this.txtidsala.Size = new System.Drawing.Size(100, 20);
            this.txtidsala.TabIndex = 8;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(95, 91);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 9;
            // 
            // txthoraini
            // 
            this.txthoraini.Location = new System.Drawing.Point(95, 117);
            this.txthoraini.Name = "txthoraini";
            this.txthoraini.Size = new System.Drawing.Size(100, 20);
            this.txthoraini.TabIndex = 10;
            // 
            // txthorafin
            // 
            this.txthorafin.Location = new System.Drawing.Point(95, 143);
            this.txthorafin.Name = "txthorafin";
            this.txthorafin.Size = new System.Drawing.Size(100, 20);
            this.txthorafin.TabIndex = 11;
            // 
            // dtgcartelera
            // 
            this.dtgcartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcartelera.Location = new System.Drawing.Point(16, 188);
            this.dtgcartelera.Name = "dtgcartelera";
            this.dtgcartelera.Size = new System.Drawing.Size(398, 150);
            this.dtgcartelera.TabIndex = 12;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(229, 10);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(339, 10);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 14;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(229, 62);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(339, 62);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 16;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(229, 114);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 17;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnconsultodo
            // 
            this.btnconsultodo.Location = new System.Drawing.Point(326, 114);
            this.btnconsultodo.Name = "btnconsultodo";
            this.btnconsultodo.Size = new System.Drawing.Size(88, 23);
            this.btnconsultodo.TabIndex = 18;
            this.btnconsultodo.Text = "Consultar Todo";
            this.btnconsultodo.UseVisualStyleBackColor = true;
            this.btnconsultodo.Click += new System.EventHandler(this.btnconsultodo_Click);
            // 
            // Cartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 364);
            this.Controls.Add(this.btnconsultodo);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dtgcartelera);
            this.Controls.Add(this.txthorafin);
            this.Controls.Add(this.txthoraini);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtidsala);
            this.Controls.Add(this.txtidpelicula);
            this.Controls.Add(this.txtidcartelera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cartelera";
            this.Text = "Cartelera";
            ((System.ComponentModel.ISupportInitialize)(this.dtgcartelera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidcartelera;
        private System.Windows.Forms.TextBox txtidpelicula;
        private System.Windows.Forms.TextBox txtidsala;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txthoraini;
        private System.Windows.Forms.TextBox txthorafin;
        private System.Windows.Forms.DataGridView dtgcartelera;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnconsultodo;
    }
}