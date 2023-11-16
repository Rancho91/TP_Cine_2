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

namespace ReportesCine.Reportes.forms
{
    public partial class GananciaFormaPagoForm : Form
    {
        FormaPagoService FPService;
        public GananciaFormaPagoForm()
        {
            InitializeComponent();
            FPService = new FormaPagoService();
            llenarComboFunciones();

        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GananciaFormaPagoForm_Load(object sender, EventArgs e)
        {
        }

        private async void llenarComboFunciones()
        {
            List<FormasPagos> lst = await FPService.Get();

            cbFormaPago.DataSource = lst;

            cbFormaPago.DisplayMember = "FormaPago";

            cbFormaPago.ValueMember = "codigo";

            cbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
