namespace ReportesCine.Presentacion.Peliculas
{
    partial class FormEditarPelicula
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
            this.label5 = new System.Windows.Forms.Label();
            this.nupMinutos = new System.Windows.Forms.NumericUpDown();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.btnEditarPelicula = new System.Windows.Forms.Button();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblCodigoPelicula = new System.Windows.Forms.Label();
            this.txtNombrePelicula = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Duracion:";
            // 
            // nupMinutos
            // 
            this.nupMinutos.Location = new System.Drawing.Point(201, 173);
            this.nupMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupMinutos.Name = "nupMinutos";
            this.nupMinutos.Size = new System.Drawing.Size(76, 20);
            this.nupMinutos.TabIndex = 30;
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(102, 173);
            this.nudHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(73, 20);
            this.nudHora.TabIndex = 29;
            // 
            // btnEditarPelicula
            // 
            this.btnEditarPelicula.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditarPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPelicula.Location = new System.Drawing.Point(122, 232);
            this.btnEditarPelicula.Name = "btnEditarPelicula";
            this.btnEditarPelicula.Size = new System.Drawing.Size(118, 39);
            this.btnEditarPelicula.TabIndex = 28;
            this.btnEditarPelicula.Text = "Editar";
            this.btnEditarPelicula.UseVisualStyleBackColor = false;
            this.btnEditarPelicula.Click += new System.EventHandler(this.btnEditarPelicula_Click);
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(102, 128);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(175, 21);
            this.cboPais.TabIndex = 24;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(102, 84);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(175, 21);
            this.cboClasificacion.TabIndex = 25;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(66, 136);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 23;
            this.lblPais.Text = "Pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Clasificacion";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(102, 53);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(175, 21);
            this.cboGenero.TabIndex = 27;
            // 
            // lblCodigoPelicula
            // 
            this.lblCodigoPelicula.AutoSize = true;
            this.lblCodigoPelicula.Location = new System.Drawing.Point(12, 18);
            this.lblCodigoPelicula.Name = "lblCodigoPelicula";
            this.lblCodigoPelicula.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoPelicula.TabIndex = 20;
            this.lblCodigoPelicula.Text = "Nombre Pelicula";
            // 
            // txtNombrePelicula
            // 
            this.txtNombrePelicula.Location = new System.Drawing.Point(102, 18);
            this.txtNombrePelicula.Name = "txtNombrePelicula";
            this.txtNombrePelicula.Size = new System.Drawing.Size(179, 20);
            this.txtNombrePelicula.TabIndex = 21;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(51, 56);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 22;
            this.lblGenero.Text = "Genero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReportesCine.Properties.Resources.Cine_12_svg;
            this.pictureBox1.Location = new System.Drawing.Point(273, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormEditarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(358, 298);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nupMinutos);
            this.Controls.Add(this.nudHora);
            this.Controls.Add(this.btnEditarPelicula);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.cboClasificacion);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lblCodigoPelicula);
            this.Controls.Add(this.txtNombrePelicula);
            this.Controls.Add(this.lblGenero);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FormEditarPelicula";
            this.Text = "FormEditarPelicula";
            this.Load += new System.EventHandler(this.FormEditarPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupMinutos;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.Button btnEditarPelicula;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblCodigoPelicula;
        private System.Windows.Forms.TextBox txtNombrePelicula;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}