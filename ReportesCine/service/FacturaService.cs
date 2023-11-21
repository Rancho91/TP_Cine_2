using Newtonsoft.Json;
using ReportesCine.Entidades.Factura;
using ReportesCine.Entidades.Maestras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine.service
{
    internal class FacturaService
    {
        private DataHttp http { get; set; }
        public FacturaService()
        {
            http = new DataHttp("Factura");
        }

        public async Task Post(FacturasE factura)
        {
            try
            {
                string jsonFactura = JsonConvert.SerializeObject(factura);

                await http.Post(jsonFactura);

                MessageBox.Show("Factura creada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
