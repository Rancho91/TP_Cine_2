using ReportesCine.Entidades.Factura;
using ReportesCine.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCineDb.Entidades.Reportes;
using Microsoft.Reporting.WinForms;

namespace ReportesCine.Reportes.forms
{
    public partial class GananciaFormaPagoForm : Form
    {
        FormaPagoService FPService;
        public GananciaFormaPagoForm()
        {
            InitializeComponent();
            FPService = new FormaPagoService();

        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GananciaFormaPagoForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

     

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

            

                ReporteFacturasFormaPagoService reporteDBService = new ReporteFacturasFormaPagoService(new DateTime(2020, 1, 1), new DateTime(2023, 1, 1), 0 );

                List<ReporteFacturasFormaPago> lst = await reporteDBService.GetReporte();
                if (lst.Count == 0 || lst == null)
                {
                    MessageBox.Show($"Lista sin informacion");
                }
                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.ReportPath = @"C:\Users\ramir\Desktop\Proyectos Facu\TP_Cine-Ramiro\ReportesCine\Reportes\InformeGananciaFoirmaPago.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("FacturaFormaPagoDataSet", lst));
                List<ReportParameter> paramList = new List<ReportParameter>();

                for (int i = 0; i < lst.Count; i++)
                {


                    paramList.Add(new ReportParameter("CantidadVentas", lst[i].CantVentas.ToString()));
                    paramList.Add(new ReportParameter("SumaTotal", lst[i].SumaTotal.ToString()));
                    paramList.Add(new ReportParameter("TotalDescuento", lst[i].totalDescuento.ToString()));
                    paramList.Add(new ReportParameter("TotalFacturado", lst[i].totalFacturado.ToString()));
                    paramList.Add(new ReportParameter("CantidadFunciones", lst[i].cantidadFunciones.ToString()));
                    paramList.Add(new ReportParameter("Promedio", lst[i].PromedioGananciaFuncion.ToString()));
                    paramList.Add(new ReportParameter("FormaPago", lst[i].FormaPago));


                 }
                    reportViewer1.LocalReport.SetParameters(paramList);

                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, mostrar un mensaje de error o registrarla.
                MessageBox.Show($"Error al obtener datos: {ex.Message}");
            }
        }
    }
}
    