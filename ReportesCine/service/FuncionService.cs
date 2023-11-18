﻿using System;
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
    }
}
