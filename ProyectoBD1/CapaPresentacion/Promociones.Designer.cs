namespace CapaPresentacion
{
    partial class Promociones
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
            this.txtidpromo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtidpelicula = new System.Windows.Forms.TextBox();
            this.txtrestriciones = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfechaini = new System.Windows.Forms.TextBox();
            this.txtfechafin = new System.Windows.Forms.TextBox();
            this.btnborar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.dtgpromociones = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnconsultartodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpromociones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Promoción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Pelicula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Restricciones";
            // 
            // txtidpromo
            // 
            this.txtidpromo.Location = new System.Drawing.Point(112, 17);
            this.txtidpromo.Name = "txtidpromo";
            this.txtidpromo.Size = new System.Drawing.Size(100, 20);
            this.txtidpromo.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(112, 47);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtidpelicula
            // 
            this.txtidpelicula.Location = new System.Drawing.Point(112, 79);
            this.txtidpelicula.Name = "txtidpelicula";
            this.txtidpelicula.Size = new System.Drawing.Size(100, 20);
            this.txtidpelicula.TabIndex = 6;
            // 
            // txtrestriciones
            // 
            this.txtrestriciones.Location = new System.Drawing.Point(112, 113);
            this.txtrestriciones.Name = "txtrestriciones";
            this.txtrestriciones.Size = new System.Drawing.Size(100, 20);
            this.txtrestriciones.TabIndex = 7;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(241, 15);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(352, 15);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 9;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Fin";
            // 
            // txtfechaini
            // 
            this.txtfechaini.Location = new System.Drawing.Point(112, 147);
            this.txtfechaini.Name = "txtfechaini";
            this.txtfechaini.Size = new System.Drawing.Size(100, 20);
            this.txtfechaini.TabIndex = 12;
            // 
            // txtfechafin
            // 
            this.txtfechafin.Location = new System.Drawing.Point(112, 181);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(100, 20);
            this.txtfechafin.TabIndex = 13;
            // 
            // btnborar
            // 
            this.btnborar.Location = new System.Drawing.Point(241, 77);
            this.btnborar.Name = "btnborar";
            this.btnborar.Size = new System.Drawing.Size(75, 23);
            this.btnborar.TabIndex = 14;
            this.btnborar.Text = "Borar";
            this.btnborar.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(352, 77);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 15;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // dtgpromociones
            // 
            this.dtgpromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpromociones.Location = new System.Drawing.Point(12, 228);
            this.dtgpromociones.Name = "dtgpromociones";
            this.dtgpromociones.Size = new System.Drawing.Size(415, 150);
            this.dtgpromociones.TabIndex = 16;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(241, 140);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 17;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnconsultartodo
            // 
            this.btnconsultartodo.Location = new System.Drawing.Point(340, 140);
            this.btnconsultartodo.Name = "btnconsultartodo";
            this.btnconsultartodo.Size = new System.Drawing.Size(87, 23);
            this.btnconsultartodo.TabIndex = 18;
            this.btnconsultartodo.Text = "Consultar Todo";
            this.btnconsultartodo.UseVisualStyleBackColor = true;
            // 
            // Promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 390);
            this.Controls.Add(this.btnconsultartodo);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.dtgpromociones);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnborar);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtfechaini);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtrestriciones);
            this.Controls.Add(this.txtidpelicula);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtidpromo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Promociones";
            this.Text = "Promociones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgpromociones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidpromo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtidpelicula;
        private System.Windows.Forms.TextBox txtrestriciones;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfechaini;
        private System.Windows.Forms.TextBox txtfechafin;
        private System.Windows.Forms.Button btnborar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DataGridView dtgpromociones;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnconsultartodo;
    }
}