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
using ReportesCine.Entidades.Reportes;
using Microsoft.Reporting.WinForms;

namespace ReportesCine.Reportes.forms
{
    public partial class GananciaFormaPagoFormReporte : Form
    {
        FormaPagoService FPService;
        public GananciaFormaPagoFormReporte()
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


                reportViewer1.LocalReport.DataSources.Clear();

                ReporteFacturasFormaPagoService reporteDBService = new ReporteFacturasFormaPagoService(DateTime.Parse(dtpFechaInicio.Value.ToString("yyyy-MM-dd")), DateTime.Parse(dtpFechaFinal.Value.ToString("yyyy-MM-dd")), (int)nudDesc.Value);
                List<ReporteFacturasFormaPago> lst = await reporteDBService.GetReporte();

                if (lst.Count == 0)
                {
                    MessageBox.Show($"reporte sin informacion");
                }

                reportViewer1.LocalReport.ReportPath = @"C:\Users\Fabri\Desktop\tpProgra\TP_Cine_2\ReportesCine\Reportes\InformeGananciaFoirmaPago.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetGananciaFormaPago", lst));
                List<ReportParameter> paramList = new List<ReportParameter>();

                for (int i = 0; i < lst.Count; i++)
                {

                    paramList.Add(new ReportParameter("CantVentas", lst[i].CantVentas.ToString()));
                    paramList.Add(new ReportParameter("SumaTotal", lst[i].SumaTotal.ToString()));
                    paramList.Add(new ReportParameter("totalDescuento", lst[i].totalDescuento.ToString()));
                    paramList.Add(new ReportParameter("totalFacturado", lst[i].totalFacturado.ToString()));
                    paramList.Add(new ReportParameter("cantidadFunciones", lst[i].cantidadFunciones.ToString()));
                    paramList.Add(new ReportParameter("PromedioGananciaFuncion", lst[i].PromedioGananciaFuncion.ToString()));
                    paramList.Add(new ReportParameter("FormaPago", lst[i].FormaPago));


                 }
                    reportViewer1.LocalReport.SetParameters(paramList);

                reportViewer1.RefreshReport();
                return;

            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, mostrar un mensaje de error o registrarla.
            }
        }
       
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
    