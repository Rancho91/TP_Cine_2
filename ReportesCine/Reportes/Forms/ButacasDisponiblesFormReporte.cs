using ReportesCine.Entidades.Maestras;
using ReportesCine.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportesCine;
using ReportesCine.Entidades.Reportes;
using Microsoft.Reporting.WinForms;

namespace CineApi.ReportesCine
{
    public partial class Form1 : Form
    {
        private FuncionService funcionService;

        private ReporteButacasDisponiblesService reporteDBService;

        public Form1()
        {
            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            funcionService = new FuncionService();
            llenarComboFunciones();
            this.reportViewer2.RefreshReport();
        }




        private async void llenarComboFunciones()
        {
            List<Funciones> lst = await funcionService.Get();

            cboFuncionReporte.DataSource = lst;

            cboFuncionReporte.DisplayMember = "codigo"; 

            cboFuncionReporte.ValueMember = "codigo";

            cboFuncionReporte.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int funcion = 0;

                if (cboFuncionReporte.SelectedItem != null)
                {
                    funcion = Convert.ToInt32(cboFuncionReporte.SelectedValue);
                }
                string estado = comboBox1.Text;
               
                reportViewer2.LocalReport.DataSources.Clear();
                reporteDBService = new ReporteButacasDisponiblesService(funcion,estado);
                
                List<ReporteButacasDisponibles> lst = await reporteDBService.GetReporte();
               if(lst.Count == 0 || lst == null)
                {
                    MessageBox.Show($"Lista sin informacion");

                }

                reportViewer2.LocalReport.ReportPath = @"C:\Users\Fabri\Desktop\tpProgra\TP_Cine_2\ReportesCine\Reportes\ButacasDisponiblesXFuncion.rdlc";
                reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lst));
                List<ReportParameter> paramList = new List<ReportParameter>();

                for (int i = 0; i < lst.Count; i++)
                {

                    paramList.Add(new ReportParameter("Codigo", lst[i].Codigo.ToString()));
                    paramList.Add(new ReportParameter("Fila", lst[i].Fila));
                    paramList.Add(new ReportParameter("Numero", lst[i].Numero.ToString()));
                    paramList.Add(new ReportParameter("Estado", lst[i].Estado));

                }
                reportViewer2.LocalReport.SetParameters(paramList);

                reportViewer2.RefreshReport();

            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, mostrar un mensaje de error o registrarla.
                MessageBox.Show($"Error al obtener datos: {ex.Message}");
            }
        }
    }
}
