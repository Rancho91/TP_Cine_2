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


                reportViewer1.LocalReport.DataSources.Clear();

                ReporteFacturasFormaPagoService reporteDBService = new ReporteFacturasFormaPagoService(new DateTime(2020, 1, 1), new DateTime(2023, 1, 1), 0 );
                List<ReporteFacturasFormaPago> lst = await reporteDBService.GetReporte();
                DataTable dt = ConvertListToDataTable(lst);

                if (lst.Count == 0)
                {
                    MessageBox.Show($"Lista sin informacion");
                }

                reportViewer1.LocalReport.ReportPath = @"C:\Users\ramir\Desktop\Proyectos Facu\TP_Cine-Ramiro\ReportesCine\Reportes\InformeGananciaFoirmaPago.rdlc";
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
                MessageBox.Show($"Error al obtener datos: {ex.Message}");
            }
        }
        private DataTable ConvertListToDataTable(List<ReporteFacturasFormaPago> list)
        {
            DataTable dataTable = new DataTable("ReporteFacturasFormaPagoDataSet");

            dataTable.Columns.Add("FormaPago", typeof(string));
            dataTable.Columns.Add("CantVentas", typeof(int));
            dataTable.Columns.Add("SumaTotal", typeof(decimal));
            dataTable.Columns.Add("TotalDescuento", typeof(decimal));
            dataTable.Columns.Add("TotalFacturado", typeof(decimal));
            dataTable.Columns.Add("CantidadFunciones", typeof(int));
            dataTable.Columns.Add("PromedioGananciaFuncion", typeof(decimal));

            // Agrega las filas al DataTable
            foreach (var item in list)
            {
                DataRow row = dataTable.NewRow();
                row["FormaPago"] = item.FormaPago;
                row["CantVentas"] = item.CantVentas;
                row["SumaTotal"] = item.SumaTotal;
                row["TotalDescuento"] = item.totalDescuento;
                row["TotalFacturado"] = item.totalFacturado;
                row["CantidadFunciones"] = item.cantidadFunciones;
                row["PromedioGananciaFuncion"] = item.PromedioGananciaFuncion;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
    