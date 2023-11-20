namespace ReportesCine.Presentacion.Pelicula
{
    partial class EditarFuncionForms
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
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Location = new System.Drawing.Point(87, 167);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 64);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Horario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sala:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(17, 17);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(47, 13);
            this.lblPelicula.TabIndex = 27;
            this.lblPelicula.Text = "Pelicula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Idioma:";
            // 
            // nupPrecio
            // 
            this.nupPrecio.DecimalPlaces = 2;
            this.nupPrecio.Location = new System.Drawing.Point(289, 52);
            this.nupPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(88, 20);
            this.nupPrecio.TabIndex = 25;
            // 
            // nupMinutos
            // 
            this.nupMinutos.Location = new System.Drawing.Point(125, 130);
            this.nupMinutos.Name = "nupMinutos";
            this.nupMinutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nupMinutos.Size = new System.Drawing.Size(37, 20);
            this.nupMinutos.TabIndex = 24;
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(70, 130);
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(33, 20);
            this.nudHora.TabIndex = 23;
            // 
            // FechaDTP
            // 
            this.FechaDTP.CustomFormat = "";
            this.FechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDTP.Location = new System.Drawing.Point(289, 13);
            this.FechaDTP.Name = "FechaDTP";
            this.FechaDTP.Size = new System.Drawing.Size(88, 20);
            this.FechaDTP.TabIndex = 22;
            // 
            // ChBSubtitulada
            // 
            this.ChBSubtitulada.AutoSize = true;
            this.ChBSubtitulada.Location = new System.Drawing.Point(246, 94);
            this.ChBSubtitulada.Name = "ChBSubtitulada";
            this.ChBSubtitulada.Size = new System.Drawing.Size(84, 17);
            this.ChBSubtitulada.TabIndex = 21;
            this.ChBSubtitulada.Text = "Subtitulados";
            this.ChBSubtitulada.UseVisualStyleBackColor = true;
            // 
            // ChB3D
            // 
            this.ChB3D.AutoSize = true;
            this.ChB3D.Location = new System.Drawing.Point(246, 133);
            this.ChB3D.Name = "ChB3D";
            this.ChB3D.Size = new System.Drawing.Size(40, 17);
            this.ChB3D.TabIndex = 20;
            this.ChB3D.Text = "3D";
            this.ChB3D.UseVisualStyleBackColor = true;
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(70, 92);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cbIdioma.TabIndex = 19;
            // 
            // cbSalas
            // 
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.Location = new System.Drawing.Point(70, 52);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.Size = new System.Drawing.Size(121, 21);
            this.cbSalas.TabIndex = 18;
            // 
            // cbPeliculas
            // 
            this.cbPeliculas.FormattingEnabled = true;
            this.cbPeliculas.Location = new System.Drawing.Point(70, 14);
            this.cbPeliculas.Name = "cbPeliculas";
            this.cbPeliculas.Size = new System.Drawing.Size(121, 21);
            this.cbPeliculas.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = ":";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Location = new System.Drawing.Point(220, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 64);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // EditarFuncionForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 259);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupPrecio);
            this.Controls.Add(this.nupMinutos);
            this.Controls.Add(this.nudHora);
            this.Controls.Add(this.FechaDTP);
            this.Controls.Add(this.ChBSubtitulada);
            this.Controls.Add(this.ChB3D);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.cbSalas);
            this.Controls.Add(this.cbPeliculas);
            this.Name = "EditarFuncionForms";
            this.Text = "EditarFuncionForms";
            this.Load += new System.EventHandler(this.EditarFuncionForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupPrecio;
        private System.Windows.Forms.NumericUpDown nupMinutos;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.DateTimePicker FechaDTP;
        private System.Windows.Forms.CheckBox ChBSubtitulada;
        private System.Windows.Forms.CheckBox ChB3D;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.ComboBox cbSalas;
        private System.Windows.Forms.ComboBox cbPeliculas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}