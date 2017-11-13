namespace CapaPresentacion
{
    partial class Salas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidsala = new System.Windows.Forms.TextBox();
            this.txtidtiposala = new System.Windows.Forms.TextBox();
            this.txtasientos = new System.Windows.Forms.TextBox();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgSalas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Tipo Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asientos";
            // 
            // txtidsala
            // 
            this.txtidsala.Location = new System.Drawing.Point(128, 13);
            this.txtidsala.Name = "txtidsala";
            this.txtidsala.Size = new System.Drawing.Size(100, 20);
            this.txtidsala.TabIndex = 4;
            this.txtidsala.TextChanged += new System.EventHandler(this.txtidsala_TextChanged);
            // 
            // txtidtiposala
            // 
            this.txtidtiposala.Location = new System.Drawing.Point(128, 39);
            this.txtidtiposala.Name = "txtidtiposala";
            this.txtidtiposala.Size = new System.Drawing.Size(100, 20);
            this.txtidtiposala.TabIndex = 5;
            // 
            // txtasientos
            // 
            this.txtasientos.Location = new System.Drawing.Point(128, 65);
            this.txtasientos.Name = "txtasientos";
            this.txtasientos.Size = new System.Drawing.Size(100, 20);
            this.txtasientos.TabIndex = 7;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(277, 10);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 8;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(384, 10);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(384, 42);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 11;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(276, 80);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 12;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Consultar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgSalas
            // 
            this.dtgSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSalas.Location = new System.Drawing.Point(16, 136);
            this.dtgSalas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgSalas.Name = "dtgSalas";
            this.dtgSalas.RowTemplate.Height = 24;
            this.dtgSalas.Size = new System.Drawing.Size(443, 271);
            this.dtgSalas.TabIndex = 13;
            this.dtgSalas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSalas_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(277, 41);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 24);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 428);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgSalas);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.txtasientos);
            this.Controls.Add(this.txtidtiposala);
            this.Controls.Add(this.txtidsala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Salas";
            this.Text = "Salas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidsala;
        private System.Windows.Forms.TextBox txtidtiposala;
        private System.Windows.Forms.TextBox txtasientos;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgSalas;
        private System.Windows.Forms.Button btnEliminar;
    }
}