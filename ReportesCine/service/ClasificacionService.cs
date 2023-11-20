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
    public class ClasificacionService
    {
        private DataHttp http { get; set; }
        public ClasificacionService()
        {
            http = new DataHttp("clasificacion");
        }
        public ClasificacionService(int id)
        {
            http = new DataHttp($"clasificacion/{id}");
        }
        public async Task<List<Clasificaciones>> Get()
        {
            List<Clasificaciones> list = new List<Clasificaciones>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<Clasificaciones>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
            return list;
        }
    }
}
