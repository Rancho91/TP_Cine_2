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
    internal class PeliculasEService
    {
        private DataHttp http { get; set; }
        public PeliculasEService()
        {
            http = new DataHttp("Peliculas");
        }

        public PeliculasEService(int id)
        {
            http = new DataHttp($"Peliculas/{id}");
        }


        public async Task<List<PeliculasE>> Get()
        {
            List<PeliculasE> list = new List<PeliculasE>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<PeliculasE>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
            return list;
        }

        public async Task<List<PeliculasE>> GetId()
        {
            List<PeliculasE> list = new List<PeliculasE>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<PeliculasE>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
            return list;
        }

        public async Task Post(PeliculasE pelicula)
        {
            try
            {
                string jsonSala = JsonConvert.SerializeObject(pelicula);

                await http.Post(jsonSala);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
        }
        public async Task Delete()
        {
            try
            {
                await http.Delete();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
        }
        public async Task put(PeliculasE funcion)
        {
            try
            {
                string jsonSala = JsonConvert.SerializeObject(funcion);
                await http.Put(jsonSala);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


    }
}
