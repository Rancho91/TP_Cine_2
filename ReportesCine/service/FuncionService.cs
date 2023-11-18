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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }
            return list;
        }
        public async Task Post(Salas sala)
        {
            try
            {
                string jsonSala = JsonConvert.SerializeObject(sala);

                await http.Post(jsonSala);

                MessageBox.Show("Funcion creada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public async Task Delete()
        {
            try
            {
                await http.Delete();

                MessageBox.Show("Funcion Eliminada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public async Task put(Funciones funcion)
        {
            try
            {
                string jsonSala = JsonConvert.SerializeObject(funcion);
                await http.Put(jsonSala);

                MessageBox.Show("Funcion modificada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
