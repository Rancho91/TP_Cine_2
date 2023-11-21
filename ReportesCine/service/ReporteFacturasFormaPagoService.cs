using ReportesCine.Entidades.Reportes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine.service
{
    public class ReporteFacturasFormaPagoService
    {
        private DataHttp http { get; set; }

        public ReporteFacturasFormaPagoService(DateTime fechaInicio, DateTime fechaFinal, int descuento)
        {
            // Construye manualmente la cadena de fecha con el formato "año-mes-día"
            string fechaInicioStr = $"{fechaInicio.Year}-{fechaInicio.Month:D2}-{fechaInicio.Day:D2}";
            string fechaFinalStr = $"{fechaFinal.Year}-{fechaFinal.Month:D2}-{fechaFinal.Day:D2}";

            // Construye la URL con las fechas formateadas y el descuento
            http = new DataHttp($"Reporte/facturaFormaPago/{fechaInicioStr}/{fechaFinalStr}/{descuento}");
        }

        public async Task<List<ReporteFacturasFormaPago>> GetReporte()
        {
            List<ReporteFacturasFormaPago> list = new List<ReporteFacturasFormaPago>();
            try
            {
                string json = await http.Get();
                list = JsonConvert.DeserializeObject<List<ReporteFacturasFormaPago>>(json);
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack Trace: {ex.Message}");
            }

            return list;
        }
    }
}
