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
    internal class PeliculasXFuncionService
    {
        private DataHttp http { get; set; }

        public PeliculasXFuncionService(int id)
        {
            http = new DataHttp($"Peliculas/peliculasXFunciones/{id}");
        }

        public async Task<List<Funciones>> GetIdPeliculasXFunciones()
        {
            List<Funciones> list = new List<Funciones>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<Funciones>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stack Trace: {ex.Message}");

            }
            return list;
        }
    }
}
