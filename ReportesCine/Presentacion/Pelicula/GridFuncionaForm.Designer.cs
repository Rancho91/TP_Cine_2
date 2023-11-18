﻿namespace ReportesCine.Presentacion.Pelicula
{
    partial class GridFuncionaForm
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
            this.NuevoGB = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.nupMinutos = new System.Windows.Forms.NumericUpDown();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.FechaDTP = new System.Windows.Forms.DateTimePicker();
            this.ChBSubtitulada = new System.Windows.Forms.CheckBox();
            this.ChB3D = new System.Windows.Forms.CheckBox();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.cbSalas = new System.Windows.Forms.ComboBox();
            this.cbPeliculas = new System.Windows.Forms.ComboBox();
            this.sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            this.dataSetGananciaFormaPago1 = new ReportesCine.Reportes.Data.DataSetGananciaFormaPago();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl3D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSubtitulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NuevoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGananciaFormaPago1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoGB
            // 
            this.NuevoGB.Controls.Add(this.btnCrear);
            this.NuevoGB.Controls.Add(this.label2);
            this.NuevoGB.Controls.Add(this.label6);
            this.NuevoGB.Controls.Add(this.label5);
            this.NuevoGB.Controls.Add(this.label4);
            this.NuevoGB.Controls.Add(this.label3);
            this.NuevoGB.Controls.Add(this.lblPelicula);
            this.NuevoGB.Controls.Add(this.label1);
            this.NuevoGB.Controls.Add(this.nupPrecio);
            this.NuevoGB.Controls.Add(this.nupMinutos);
            this.NuevoGB.Controls.Add(this.nudHora);
            this.NuevoGB.Controls.Add(this.FechaDTP);
            this.NuevoGB.Controls.Add(this.ChBSubtitulada);
            this.NuevoGB.Controls.Add(this.ChB3D);
            this.NuevoGB.Controls.Add(this.cbIdioma);
            this.NuevoGB.Controls.Add(this.cbSalas);
            this.NuevoGB.Controls.Add(this.cbPeliculas);
            this.NuevoGB.Location = new System.Drawing.Point(12, 13);
            this.NuevoGB.Name = "NuevoGB";
            this.NuevoGB.Size = new System.Drawing.Size(1025, 103);
            this.NuevoGB.TabIndex = 0;
            this.NuevoGB.TabStop = false;
            this.NuevoGB.Text = "Nueva Funcion";
            this.NuevoGB.Enter += new System.EventHandler(this.NuevoGB_Enter);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(745, 13);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 64);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Horario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sala:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(31, 24);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(47, 13);
            this.lblPelicula.TabIndex = 10;
            this.lblPelicula.Text = "Pelicula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Idioma:";
            // 
            // nupPrecio
            // 
            this.nupPrecio.DecimalPlaces = 2;
            this.nupPrecio.Location = new System.Drawing.Point(373, 61);
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(76, 20);
            this.nupPrecio.TabIndex = 8;
            // 
            // nupMinutos
            // 
            this.nupMinutos.Location = new System.Drawing.Point(578, 57);
            this.nupMinutos.Name = "nupMinutos";
            this.nupMinutos.Size = new System.Drawing.Size(37, 20);
            this.nupMinutos.TabIndex = 7;
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(523, 57);
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(33, 20);
            this.nudHora.TabIndex = 6;
            // 
            // FechaDTP
            // 
            this.FechaDTP.CustomFormat = "YYYY-MM-DD";
            this.FechaDTP.Location = new System.Drawing.Point(95, 62);
            this.FechaDTP.Name = "FechaDTP";
            this.FechaDTP.Size = new System.Drawing.Size(217, 20);
            this.FechaDTP.TabIndex = 5;
            // 
            // ChBSubtitulada
            // 
            this.ChBSubtitulada.AutoSize = true;
            this.ChBSubtitulada.Location = new System.Drawing.Point(638, 18);
            this.ChBSubtitulada.Name = "ChBSubtitulada";
            this.ChBSubtitulada.Size = new System.Drawing.Size(84, 17);
            this.ChBSubtitulada.TabIndex = 4;
            this.ChBSubtitulada.Text = "Subtitulados";
            this.ChBSubtitulada.UseVisualStyleBackColor = true;
            // 
            // ChB3D
            // 
            this.ChB3D.AutoSize = true;
            this.ChB3D.Location = new System.Drawing.Point(638, 57);
            this.ChB3D.Name = "ChB3D";
            this.ChB3D.Size = new System.Drawing.Size(40, 17);
            this.ChB3D.TabIndex = 3;
            this.ChB3D.Text = "3D";
            this.ChB3D.UseVisualStyleBackColor = true;
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(476, 16);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cbIdioma.TabIndex = 2;
            // 
            // cbSalas
            // 
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.Location = new System.Drawing.Point(289, 19);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.Size = new System.Drawing.Size(121, 21);
            this.cbSalas.TabIndex = 1;
            // 
            // cbPeliculas
            // 
            this.cbPeliculas.FormattingEnabled = true;
            this.cbPeliculas.Location = new System.Drawing.Point(95, 19);
            this.cbPeliculas.Name = "cbPeliculas";
            this.cbPeliculas.Size = new System.Drawing.Size(121, 21);
            this.cbPeliculas.TabIndex = 0;
            this.cbPeliculas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataSetGananciaFormaPago1
            // 
            this.dataSetGananciaFormaPago1.DataSetName = "DataSetGananciaFormaPago";
            this.dataSetGananciaFormaPago1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.ClPelicula,
            this.ClSala,
            this.ClHorario,
            this.clIdioma,
            this.ClFecha,
            this.Cl3D,
            this.ClSubtitulos,
            this.ClPrecio,
            this.btnEliminar,
            this.btnEditar});
            this.dgvFunciones.Location = new System.Drawing.Point(12, 122);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.Size = new System.Drawing.Size(1028, 210);
            this.dgvFunciones.TabIndex = 1;
            this.dgvFunciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciones_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // ClPelicula
            // 
            this.ClPelicula.HeaderText = "Pelicula";
            this.ClPelicula.Name = "ClPelicula";
            // 
            // ClSala
            // 
            this.ClSala.HeaderText = "Sala";
            this.ClSala.Name = "ClSala";
            // 
            // ClHorario
            // 
            this.ClHorario.HeaderText = "Horario";
            this.ClHorario.Name = "ClHorario";
            // 
            // clIdioma
            // 
            this.clIdioma.HeaderText = "Idioma";
            this.clIdioma.Name = "clIdioma";
            // 
            // ClFecha
            // 
            this.ClFecha.HeaderText = "Fecha";
            this.ClFecha.Name = "ClFecha";
            // 
            // Cl3D
            // 
            this.Cl3D.HeaderText = "3D";
            this.Cl3D.Name = "Cl3D";
            // 
            // ClSubtitulos
            // 
            this.ClSubtitulos.HeaderText = "Subtitulos";
            this.ClSubtitulos.Name = "ClSubtitulos";
            // 
            // ClPrecio
            // 
            this.ClPrecio.HeaderText = "Precio";
            this.ClPrecio.Name = "ClPrecio";
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            // 
            // GridPeliculaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 450);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.NuevoGB);
            this.Name = "GridPeliculaForm";
            this.Text = "GridPeliculaForm";
            this.Load += new System.EventHandler(this.GridPeliculaForm_Load);
            this.NuevoGB.ResumeLayout(false);
            this.NuevoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGananciaFormaPago1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NuevoGB;
        private System.Windows.Forms.DateTimePicker FechaDTP;
        private System.Windows.Forms.CheckBox ChBSubtitulada;
        private System.Windows.Forms.CheckBox ChB3D;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.ComboBox cbSalas;
        private System.Windows.Forms.ComboBox cbPeliculas;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.NumericUpDown nupPrecio;
        private System.Windows.Forms.NumericUpDown nupMinutos;
        private System.Windows.Forms.NumericUpDown nudHora;
        private Reportes.Data.DataSetGananciaFormaPago dataSetGananciaFormaPago1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl3D;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSubtitulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPrecio;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
    }
}