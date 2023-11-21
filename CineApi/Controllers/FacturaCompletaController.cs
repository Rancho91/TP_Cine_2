using DataCineDb.Entidades.Factura;
using DataCineDb.Service;
using Microsoft.AspNetCore.Mvc;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FacturaCompletaController : Controller
    {
        ServiceFacturaCompleta service = new ServiceFacturaCompleta();
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Facturas> factura = service.GetFacturaCompleta();
                if (factura == null || factura.Count == 0)
                {
                    return BadRequest("No se encontraron datos de factura.");
                }
                return Ok(factura);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return BadRequest("Se ha producido un error");
            }
        }
    }
}
