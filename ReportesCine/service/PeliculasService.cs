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
    internal class PeliculasService
    {
        private DataHttp http { get; set; }
        public PeliculasService()
        {
            http = new DataHttp("Peliculas");
        }
        public PeliculasService(int id)
        {
            http = new DataHttp($"Peliculas/{id}");
        }

        public async Task<List<Peliculas>> Get()
        {
            List<Peliculas> list = new List<Peliculas>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<Peliculas>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }
    }
}
