namespace ReportesCine.Reportes.forms
{
    partial class GananciaFormaPagoFormReporte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSetGananciaFormaPagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGananciaFormaPago = new ReportesCine.Reportes.Data.DataSetGananciaFormaPago();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataSetGananciaFormaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudDesc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGananciaFormaPagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGananciaFormaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGananciaFormaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetGananciaFormaPagoBindingSource1
            // 
            this.dataSetGananciaFormaPagoBindingSource1.DataSource = this.dataSetGananciaFormaPago;
            this.dataSetGananciaFormaPagoBindingSource1.Position = 0;
            // 
            // dataSetGananciaFormaPago
            // 
            this.dataSetGananciaFormaPago.DataSetName = "DataSetGananciaFormaPago";
            this.dataSetGananciaFormaPago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descuento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(372, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(216, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desde";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(267, 28);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaInicio.TabIndex = 4;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(420, 28);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaFinal.TabIndex = 5;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSetGananciaFormaPago";
            reportDataSource2.Value = this.dataSetGananciaFormaPagoBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesCine.Reportes.InformeGananciaFoirmaPago.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 59);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(850, 313);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(540, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 34);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataSetGananciaFormaPagoBindingSource
            // 
            this.dataSetGananciaFormaPagoBindingSource.DataSource = this.dataSetGananciaFormaPago;
            this.dataSetGananciaFormaPagoBindingSource.Position = 0;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.dataSetGananciaFormaPago;
            // 
            // nudDesc
            // 
            this.nudDesc.Location = new System.Drawing.Point(102, 28);
            this.nudDesc.Name = "nudDesc";
            this.nudDesc.Size = new System.Drawing.Size(62, 20);
            this.nudDesc.TabIndex = 8;
            // 
            // GananciaFormaPagoFormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(871, 377);
            this.Controls.Add(this.nudDesc);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(887, 416);
            this.MinimumSize = new System.Drawing.Size(887, 416);
            this.Name = "GananciaFormaPagoFormReporte";
            this.Text = "GananciaFormaPagoForm";
            this.Load += new System.EventHandler(this.GananciaFormaPagoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGananciaFormaPagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGananciaFormaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGananciaFormaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource dataSetGananciaFormaPagoBindingSource;
        private Data.DataSetGananciaFormaPago dataSetGananciaFormaPago;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private System.Windows.Forms.BindingSource dataSetGananciaFormaPagoBindingSource1;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.NumericUpDown nudDesc;
    }
}