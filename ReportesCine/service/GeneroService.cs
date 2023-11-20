using Newtonsoft.Json;
using ReportesCine.Entidades;
using ReportesCine.Entidades.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine.service
{
    public class GeneroService
    {

        private DataHttp http { get; set; }
        public GeneroService()
        {
            http = new DataHttp("Genero");
        }
        public GeneroService(int id)
        {
            http = new DataHttp($"Genero/{id}");
        }
        public async Task<List<Generos>> Get()
        {
            List<Generos> list = new List<Generos>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<Generos>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
            return list;
        }
    }
}
