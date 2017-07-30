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
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgSalas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Tipo Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asientos";
            // 
            // txtidsala
            // 
            this.txtidsala.Location = new System.Drawing.Point(171, 16);
            this.txtidsala.Margin = new System.Windows.Forms.Padding(4);
            this.txtidsala.Name = "txtidsala";
            this.txtidsala.Size = new System.Drawing.Size(132, 22);
            this.txtidsala.TabIndex = 4;
            this.txtidsala.TextChanged += new System.EventHandler(this.txtidsala_TextChanged);
            // 
            // txtidtiposala
            // 
            this.txtidtiposala.Location = new System.Drawing.Point(171, 54);
            this.txtidtiposala.Margin = new System.Windows.Forms.Padding(4);
            this.txtidtiposala.Name = "txtidtiposala";
            this.txtidtiposala.Size = new System.Drawing.Size(132, 22);
            this.txtidtiposala.TabIndex = 5;
            // 
            // txtasientos
            // 
            this.txtasientos.Location = new System.Drawing.Point(171, 106);
            this.txtasientos.Margin = new System.Windows.Forms.Padding(4);
            this.txtasientos.Name = "txtasientos";
            this.txtasientos.Size = new System.Drawing.Size(132, 22);
            this.txtasientos.TabIndex = 7;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(33, 199);
            this.btnconsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(100, 28);
            this.btnconsultar.TabIndex = 8;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(183, 199);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 28);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(33, 247);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(100, 28);
            this.btnborrar.TabIndex = 10;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(183, 247);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(100, 28);
            this.btnmodificar.TabIndex = 11;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(33, 283);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiar.TabIndex = 12;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Consultar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgSalas
            // 
            this.dtgSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSalas.Location = new System.Drawing.Point(311, 7);
            this.dtgSalas.Name = "dtgSalas";
            this.dtgSalas.RowTemplate.Height = 24;
            this.dtgSalas.Size = new System.Drawing.Size(375, 333);
            this.dtgSalas.TabIndex = 13;
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 342);
            this.Controls.Add(this.dtgSalas);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.txtasientos);
            this.Controls.Add(this.txtidtiposala);
            this.Controls.Add(this.txtidsala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgSalas;
    }
}