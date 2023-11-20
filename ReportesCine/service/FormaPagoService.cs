using Newtonsoft.Json;
using ReportesCine.Entidades.Factura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine.service
{
    internal class FormaPagoService
    {
        private DataHttp http { get; set; }
        public FormaPagoService()
        {
            http = new DataHttp("FormasPago");
        }

        public async Task<List<FormasPagos>> Get()
        {
            List<FormasPagos> list = new List<FormasPagos>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<FormasPagos>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
            return list;
        }
    }
}
