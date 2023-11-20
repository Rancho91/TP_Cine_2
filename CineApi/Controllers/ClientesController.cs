using DataCineDb.Entidades.Maestras;
using DataCineDb.Service;
using Microsoft.AspNetCore.Mvc;

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClientesController : ControllerBase
    {
        ServiceClientes service = new ServiceClientes();
        // GET: api/<ClientesController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Clientes> sala = service.GetClientes();
                if (sala == null || sala.Count == 0)
                {
                    return BadRequest("No se encontraron datos de géneros.");
                }
                return Ok(sala);
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
