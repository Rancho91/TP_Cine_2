namespace ReportesCine.Presentacion.FormPeliculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.cboPais.Size = new System.Drawing.Size(175, 21);
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
            this.cboGenero.Size = new System.Drawing.Size(181, 21);
            this.cboGenero.TabIndex = 11;
            // 
            // grbPeliculas
            // 
            this.grbPeliculas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbPeliculas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.grbPeliculas.Location = new System.Drawing.Point(21, 12);
            this.grbPeliculas.Name = "grbPeliculas";
            this.grbPeliculas.Size = new System.Drawing.Size(1017, 148);
            this.grbPeliculas.TabIndex = 12;
            this.grbPeliculas.TabStop = false;
            this.grbPeliculas.Text = "Agregar Peliculas";
            this.grbPeliculas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Duracion:";
            // 
            // nupMinutos
            // 
            this.nupMinutos.Location = new System.Drawing.Point(714, 26);
            this.nupMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupMinutos.Name = "nupMinutos";
            this.nupMinutos.Size = new System.Drawing.Size(60, 20);
            this.nupMinutos.TabIndex = 17;
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(634, 25);
            this.nudHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(49, 20);
            this.nudHora.TabIndex = 16;
            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarPelicula.Location = new System.Drawing.Point(833, 35);
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Size = new System.Drawing.Size(151, 73);
            this.btnAgregarPelicula.TabIndex = 14;
            this.btnAgregarPelicula.Text = "AGREGAR";
            this.btnAgregarPelicula.UseVisualStyleBackColor = true;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.btnAgregarPelicula_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvPeliculas.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvPeliculas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeliculas.Size = new System.Drawing.Size(1017, 363);
            this.dgvPeliculas.TabIndex = 13;
            this.dgvPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ReportesCine.Properties.Resources.Cine_12_svg;
            this.pictureBox1.Location = new System.Drawing.Point(1053, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
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
            this.ColumnGeneroPelicula.Width = 120;
            // 
            // ColumnNombrePelicula
            // 
            this.ColumnNombrePelicula.HeaderText = "Nombre";
            this.ColumnNombrePelicula.Name = "ColumnNombrePelicula";
            this.ColumnNombrePelicula.ReadOnly = true;
            this.ColumnNombrePelicula.Width = 120;
            // 
            // ColumnCodigoPaisPelicula
            // 
            this.ColumnCodigoPaisPelicula.HeaderText = "Pais";
            this.ColumnCodigoPaisPelicula.Name = "ColumnCodigoPaisPelicula";
            this.ColumnCodigoPaisPelicula.ReadOnly = true;
            this.ColumnCodigoPaisPelicula.Width = 150;
            // 
            // ColumnClasificacion
            // 
            this.ColumnClasificacion.HeaderText = "Clasificacion";
            this.ColumnClasificacion.Name = "ColumnClasificacion";
            this.ColumnClasificacion.ReadOnly = true;
            this.ColumnClasificacion.Width = 130;
            // 
            // ColumnDuracion
            // 
            this.ColumnDuracion.HeaderText = "Duracion";
            this.ColumnDuracion.Name = "ColumnDuracion";
            this.ColumnDuracion.ReadOnly = true;
            this.ColumnDuracion.Width = 130;
            // 
            // ColumnEditarPelicula
            // 
            this.ColumnEditarPelicula.HeaderText = "EDITAR";
            this.ColumnEditarPelicula.Name = "ColumnEditarPelicula";
            this.ColumnEditarPelicula.Width = 160;
            // 
            // ColumnEliminarPelicula
            // 
            this.ColumnEliminarPelicula.HeaderText = "ELIMINAR";
            this.ColumnEliminarPelicula.Name = "ColumnEliminarPelicula";
            this.ColumnEliminarPelicula.Width = 160;
            // 
            // FormPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1235, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.grbPeliculas);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FormPeliculas";
            this.Text = "FormPeliculas";
            this.Load += new System.EventHandler(this.FormPeliculas_Load);
            this.grbPeliculas.ResumeLayout(false);
            this.grbPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
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