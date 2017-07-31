namespace CapaPresentacion
{
    partial class Reportes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoEntrada = new System.Windows.Forms.TextBox();
            this.txtidcartelera = new System.Windows.Forms.TextBox();
            this.txtidpelicula = new System.Windows.Forms.TextBox();
            this.btnventfuncion = new System.Windows.Forms.Button();
            this.btnventaspelicula = new System.Windows.Forms.Button();
            this.btnventastotales = new System.Windows.Forms.Button();
            this.btnventaslapso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfechaini = new System.Windows.Forms.TextBox();
            this.txtfechafin = new System.Windows.Forms.TextBox();
            this.btnextra = new System.Windows.Forms.Button();
            this.dtgReportes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Cartelera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Pelicula";
            // 
            // txtTipoEntrada
            // 
            this.txtTipoEntrada.Location = new System.Drawing.Point(159, 27);
            this.txtTipoEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoEntrada.Name = "txtTipoEntrada";
            this.txtTipoEntrada.Size = new System.Drawing.Size(132, 22);
            this.txtTipoEntrada.TabIndex = 4;
            // 
            // txtidcartelera
            // 
            this.txtidcartelera.Location = new System.Drawing.Point(159, 59);
            this.txtidcartelera.Margin = new System.Windows.Forms.Padding(4);
            this.txtidcartelera.Name = "txtidcartelera";
            this.txtidcartelera.Size = new System.Drawing.Size(132, 22);
            this.txtidcartelera.TabIndex = 5;
            // 
            // txtidpelicula
            // 
            this.txtidpelicula.Location = new System.Drawing.Point(159, 91);
            this.txtidpelicula.Margin = new System.Windows.Forms.Padding(4);
            this.txtidpelicula.Name = "txtidpelicula";
            this.txtidpelicula.Size = new System.Drawing.Size(132, 22);
            this.txtidpelicula.TabIndex = 6;
            // 
            // btnventfuncion
            // 
            this.btnventfuncion.Location = new System.Drawing.Point(207, 143);
            this.btnventfuncion.Margin = new System.Windows.Forms.Padding(4);
            this.btnventfuncion.Name = "btnventfuncion";
            this.btnventfuncion.Size = new System.Drawing.Size(152, 28);
            this.btnventfuncion.TabIndex = 8;
            this.btnventfuncion.Text = "Ventas por Función";
            this.btnventfuncion.UseVisualStyleBackColor = true;
            this.btnventfuncion.Click += new System.EventHandler(this.btnventfuncion_Click);
            // 
            // btnventaspelicula
            // 
            this.btnventaspelicula.Location = new System.Drawing.Point(37, 143);
            this.btnventaspelicula.Margin = new System.Windows.Forms.Padding(4);
            this.btnventaspelicula.Name = "btnventaspelicula";
            this.btnventaspelicula.Size = new System.Drawing.Size(152, 28);
            this.btnventaspelicula.TabIndex = 9;
            this.btnventaspelicula.Text = "Ventas por Pelicula";
            this.btnventaspelicula.UseVisualStyleBackColor = true;
            this.btnventaspelicula.Click += new System.EventHandler(this.btnventaspelicula_Click);
            // 
            // btnventastotales
            // 
            this.btnventastotales.Location = new System.Drawing.Point(551, 143);
            this.btnventastotales.Margin = new System.Windows.Forms.Padding(4);
            this.btnventastotales.Name = "btnventastotales";
            this.btnventastotales.Size = new System.Drawing.Size(152, 28);
            this.btnventastotales.TabIndex = 10;
            this.btnventastotales.Text = "Total Ventas";
            this.btnventastotales.UseVisualStyleBackColor = true;
            this.btnventastotales.Click += new System.EventHandler(this.btnventastotales_Click);
            // 
            // btnventaslapso
            // 
            this.btnventaslapso.Location = new System.Drawing.Point(377, 143);
            this.btnventaslapso.Margin = new System.Windows.Forms.Padding(4);
            this.btnventaslapso.Name = "btnventaslapso";
            this.btnventaslapso.Size = new System.Drawing.Size(152, 28);
            this.btnventaslapso.TabIndex = 11;
            this.btnventaslapso.Text = "Ventas por Lapso";
            this.btnventaslapso.UseVisualStyleBackColor = true;
            this.btnventaslapso.Click += new System.EventHandler(this.btnventaslapso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha 2";
            // 
            // txtfechaini
            // 
            this.txtfechaini.Location = new System.Drawing.Point(399, 27);
            this.txtfechaini.Margin = new System.Windows.Forms.Padding(4);
            this.txtfechaini.Name = "txtfechaini";
            this.txtfechaini.Size = new System.Drawing.Size(132, 22);
            this.txtfechaini.TabIndex = 14;
            // 
            // txtfechafin
            // 
            this.txtfechafin.Location = new System.Drawing.Point(399, 57);
            this.txtfechafin.Margin = new System.Windows.Forms.Padding(4);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(132, 22);
            this.txtfechafin.TabIndex = 15;
            // 
            // btnextra
            // 
            this.btnextra.Location = new System.Drawing.Point(594, 16);
            this.btnextra.Margin = new System.Windows.Forms.Padding(4);
            this.btnextra.Name = "btnextra";
            this.btnextra.Size = new System.Drawing.Size(100, 69);
            this.btnextra.TabIndex = 18;
            this.btnextra.Text = "Ventas por tipo de Entrada";
            this.btnextra.UseVisualStyleBackColor = true;
            this.btnextra.Click += new System.EventHandler(this.btnextra_Click);
            // 
            // dtgReportes
            // 
            this.dtgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReportes.Location = new System.Drawing.Point(37, 199);
            this.dtgReportes.Margin = new System.Windows.Forms.Padding(4);
            this.dtgReportes.Name = "dtgReportes";
            this.dtgReportes.Size = new System.Drawing.Size(666, 244);
            this.dtgReportes.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Entrada";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 459);
            this.Controls.Add(this.dtgReportes);
            this.Controls.Add(this.btnextra);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtfechaini);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnventaslapso);
            this.Controls.Add(this.btnventastotales);
            this.Controls.Add(this.btnventaspelicula);
            this.Controls.Add(this.btnventfuncion);
            this.Controls.Add(this.txtidpelicula);
            this.Controls.Add(this.txtidcartelera);
            this.Controls.Add(this.txtTipoEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoEntrada;
        private System.Windows.Forms.TextBox txtidcartelera;
        private System.Windows.Forms.TextBox txtidpelicula;
        private System.Windows.Forms.Button btnventfuncion;
        private System.Windows.Forms.Button btnventaspelicula;
        private System.Windows.Forms.Button btnventastotales;
        private System.Windows.Forms.Button btnventaslapso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfechaini;
        private System.Windows.Forms.TextBox txtfechafin;
        private System.Windows.Forms.Button btnextra;
        private System.Windows.Forms.DataGridView dtgReportes;
        private System.Windows.Forms.Label label1;
    }
}