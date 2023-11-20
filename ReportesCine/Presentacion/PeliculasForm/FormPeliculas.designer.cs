﻿namespace ReportesCine.Presentacion.FormPeliculas
{
    partial class FormPeliculas
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
            this.lblCodigoPelicula = new System.Windows.Forms.Label();
            this.txtNombrePelicula = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.grbPeliculas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupMinutos = new System.Windows.Forms.NumericUpDown();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarPelicula = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.ColumnCodigoPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGeneroPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombrePelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigoPaisPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditarPelicula = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnEliminarPelicula = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grbPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoPelicula
            // 
            this.lblCodigoPelicula.AutoSize = true;
            this.lblCodigoPelicula.Location = new System.Drawing.Point(8, 28);
            this.lblCodigoPelicula.Name = "lblCodigoPelicula";
            this.lblCodigoPelicula.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoPelicula.TabIndex = 0;
            this.lblCodigoPelicula.Text = "Nombre Pelicula";
            // 
            // txtNombrePelicula
            // 
            this.txtNombrePelicula.Location = new System.Drawing.Point(98, 25);
            this.txtNombrePelicula.Name = "txtNombrePelicula";
            this.txtNombrePelicula.Size = new System.Drawing.Size(179, 20);
            this.txtNombrePelicula.TabIndex = 1;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(8, 70);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Genero";
            this.lblGenero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(318, 28);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 7;
            this.lblPais.Text = "Pais";
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(355, 24);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(121, 21);
            this.cboPais.TabIndex = 8;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(355, 62);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(175, 21);
            this.cboClasificacion.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Clasificacion";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(92, 62);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 11;
            // 
            // grbPeliculas
            // 
            this.grbPeliculas.Controls.Add(this.label1);
            this.grbPeliculas.Controls.Add(this.label5);
            this.grbPeliculas.Controls.Add(this.nupMinutos);
            this.grbPeliculas.Controls.Add(this.nudHora);
            this.grbPeliculas.Controls.Add(this.btnAgregarPelicula);
            this.grbPeliculas.Controls.Add(this.cboPais);
            this.grbPeliculas.Controls.Add(this.cboClasificacion);
            this.grbPeliculas.Controls.Add(this.lblPais);
            this.grbPeliculas.Controls.Add(this.label2);
            this.grbPeliculas.Controls.Add(this.cboGenero);
            this.grbPeliculas.Controls.Add(this.lblCodigoPelicula);
            this.grbPeliculas.Controls.Add(this.txtNombrePelicula);
            this.grbPeliculas.Controls.Add(this.lblGenero);
            this.grbPeliculas.Location = new System.Drawing.Point(12, 12);
            this.grbPeliculas.Name = "grbPeliculas";
            this.grbPeliculas.Size = new System.Drawing.Size(938, 131);
            this.grbPeliculas.TabIndex = 12;
            this.grbPeliculas.TabStop = false;
            this.grbPeliculas.Text = "Agregar Peliculas";
            this.grbPeliculas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Duracion:";
            // 
            // nupMinutos
            // 
            this.nupMinutos.Location = new System.Drawing.Point(600, 26);
            this.nupMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupMinutos.Name = "nupMinutos";
            this.nupMinutos.Size = new System.Drawing.Size(37, 20);
            this.nupMinutos.TabIndex = 17;
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(545, 25);
            this.nudHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(33, 20);
            this.nudHora.TabIndex = 16;
            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.Location = new System.Drawing.Point(690, 28);
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Size = new System.Drawing.Size(118, 58);
            this.btnAgregarPelicula.TabIndex = 14;
            this.btnAgregarPelicula.Text = "AGREGAR";
            this.btnAgregarPelicula.UseVisualStyleBackColor = true;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.btnAgregarPelicula_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoPelicula,
            this.ColumnGeneroPelicula,
            this.ColumnNombrePelicula,
            this.ColumnCodigoPaisPelicula,
            this.ColumnClasificacion,
            this.ColumnDuracion,
            this.ColumnEditarPelicula,
            this.ColumnEliminarPelicula});
            this.dgvPeliculas.Location = new System.Drawing.Point(21, 166);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(929, 150);
            this.dgvPeliculas.TabIndex = 13;
            this.dgvPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellContentClick);
            // 
            // ColumnCodigoPelicula
            // 
            this.ColumnCodigoPelicula.HeaderText = "Codigo Pelicula";
            this.ColumnCodigoPelicula.Name = "ColumnCodigoPelicula";
            this.ColumnCodigoPelicula.ReadOnly = true;
            this.ColumnCodigoPelicula.Visible = false;
            this.ColumnCodigoPelicula.Width = 110;
            // 
            // ColumnGeneroPelicula
            // 
            this.ColumnGeneroPelicula.HeaderText = "Genero";
            this.ColumnGeneroPelicula.Name = "ColumnGeneroPelicula";
            this.ColumnGeneroPelicula.ReadOnly = true;
            // 
            // ColumnNombrePelicula
            // 
            this.ColumnNombrePelicula.HeaderText = "Nombre";
            this.ColumnNombrePelicula.Name = "ColumnNombrePelicula";
            this.ColumnNombrePelicula.ReadOnly = true;
            // 
            // ColumnCodigoPaisPelicula
            // 
            this.ColumnCodigoPaisPelicula.HeaderText = "Pais";
            this.ColumnCodigoPaisPelicula.Name = "ColumnCodigoPaisPelicula";
            this.ColumnCodigoPaisPelicula.ReadOnly = true;
            // 
            // ColumnClasificacion
            // 
            this.ColumnClasificacion.HeaderText = "Clasificacion";
            this.ColumnClasificacion.Name = "ColumnClasificacion";
            this.ColumnClasificacion.ReadOnly = true;
            // 
            // ColumnDuracion
            // 
            this.ColumnDuracion.HeaderText = "Duracion";
            this.ColumnDuracion.Name = "ColumnDuracion";
            this.ColumnDuracion.ReadOnly = true;
            // 
            // ColumnEditarPelicula
            // 
            this.ColumnEditarPelicula.HeaderText = "EDITAR";
            this.ColumnEditarPelicula.Name = "ColumnEditarPelicula";
            // 
            // ColumnEliminarPelicula
            // 
            this.ColumnEliminarPelicula.HeaderText = "ELIMINAR";
            this.ColumnEliminarPelicula.Name = "ColumnEliminarPelicula";
            // 
            // FormPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.grbPeliculas);
            this.Name = "FormPeliculas";
            this.Text = "FormPeliculas";
            this.Load += new System.EventHandler(this.FormPeliculas_Load);
            this.grbPeliculas.ResumeLayout(false);
            this.grbPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoPelicula;
        private System.Windows.Forms.TextBox txtNombrePelicula;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.GroupBox grbPeliculas;
        private System.Windows.Forms.Button btnAgregarPelicula;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupMinutos;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGeneroPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombrePelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoPaisPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuracion;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditarPelicula;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEliminarPelicula;
    }
}