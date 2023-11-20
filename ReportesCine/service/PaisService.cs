using Newtonsoft.Json;
using ReportesCine.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine.service
{
    public class PaisService
    {
        private DataHttp http { get; set; }
        public PaisService()
        {
            http = new DataHttp("Pais");
        }
        public PaisService(int id)
        {
            http = new DataHttp($"Pais/{id}");
        }

        public async Task<List<Paises>> Get()
        {
            List<Paises> list = new List<Paises>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<Paises>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
            return list;
        }
    }
}
