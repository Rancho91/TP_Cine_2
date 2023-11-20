using Newtonsoft.Json;
using ReportesCine.Entidades.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine.service
{
    public class IdiomaService
    {
        private DataHttp http { get; set; }
        public IdiomaService()
        {
            http = new DataHttp("Idiomas");
        }
        public IdiomaService(int id)
        {
            http = new DataHttp($"Idiomas/{id}");
        }

        public async Task<List<Idiomas>> Get()
        {
            List<Idiomas> list = new List<Idiomas>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<Idiomas>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
            return list;
        }
    }
}
