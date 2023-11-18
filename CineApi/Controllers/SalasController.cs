using DataCineDb.Entidades.Maestras;
using DataCineDb.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class SalasController : ControllerBase
    {
        ServiceSalas service = new ServiceSalas();
        // GET: api/<SalasController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Salas> sala = service.GetSalas();
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
    

        //// GET api/<SalasController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<SalasController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<SalasController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<SalasController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
