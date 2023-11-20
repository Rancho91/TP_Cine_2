using Newtonsoft.Json;
using ReportesCine.Entidades.Maestras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine.service
{
    internal class SalasService
    {
        
            private DataHttp http { get; set; }
            public SalasService()
            {
                http = new DataHttp("Salas");
            }
            public SalasService(int id)
            {
                http = new DataHttp($"Salas/{id}");
            }

            public async Task<List<Salas>> Get()
            {
                List<Salas> list = new List<Salas>();
                try
                {
                    string json = await http.Get();
                    list = JsonConvert.DeserializeObject<List<Salas>>(json);
                }
                catch (Exception ex)
                {
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
            return list;
            }
        }

}
