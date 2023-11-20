using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ReportesCine.Entidades.Maestras;
namespace ReportesCine.service
{
    public class FuncionService
    {
        private DataHttp http { get; set; }
        public FuncionService()
        {
            http = new DataHttp("Funciones");
        }
        public FuncionService(int id)
        {
            http = new DataHttp($"Funciones/{id}");
        }

        public async Task< List<Funciones>> Get()
        {
            List<Funciones> list = new List<Funciones>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<Funciones>>(json);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
            return list;
        }
        public async Task<Funciones> GetId()
        {
            Funciones list = new Funciones();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<Funciones>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
            return list;
        }
        public async Task Post(Salas sala)
        {
            try
            {
                string jsonSala = JsonConvert.SerializeObject(sala);

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
        public async Task put(Funciones funcion)
        {
            try
            {
                string jsonSala = JsonConvert.SerializeObject(funcion);
                await http.Put(jsonSala);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }
        }
    }
}
