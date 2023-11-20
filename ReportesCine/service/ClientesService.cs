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
    internal class ClientesService
    {
        private DataHttp http { get; set; }
        public ClientesService()
        {
            http = new DataHttp("Clientes");
        }

        public async Task<List<Clientes>> Get()
        {
            List<Clientes> list = new List<Clientes>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<Clientes>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }
    }
}
