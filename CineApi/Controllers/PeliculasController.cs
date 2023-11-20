using DataCineDb.Entidades.Auxiliares;
using DataCineDb.Entidades.Maestras;
using DataCineDb.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        ServicePeliculas service = new ServicePeliculas();
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Peliculas> peliculas = service.GetPeliculas();
                if (peliculas == null || peliculas.Count == 0)
                {
                    return BadRequest("No se encontraron datos de géneros.");
                }
                return Ok(peliculas);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return BadRequest("Se ha producido un error");
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("peliculasXFunciones/{id}")]
        public IActionResult GetPeliculasXFunciones(int id)
        {
            try
            {
                List<Funciones> funciones = service.GetFuncionesPorPelicula(id);
                if (funciones == null || funciones.Count == 0)
                {
                    return BadRequest("No se encontraron datos de géneros.");
                }
                return Ok(funciones);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return BadRequest("Se ha producido un error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                List<Peliculas> peliculas = service.GetPeliculas(id);
                if (peliculas == null || peliculas.Count == 0)
                {
                    return BadRequest("No se encontraron datos de géneros.");
                }
                return Ok(peliculas);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return BadRequest("Se ha producido un error");
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] Peliculas pelicula)
        {
            bool creo = service.postPelicula(pelicula);
            if (creo ==false)
            {
                return BadRequest("no se pudo crear la pelicula.");
            }
            
            return Ok("se creo correctamente");
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Peliculas pelicula)
        {
            bool creo = service.modPelicula(pelicula);
            if (creo == false)
            {
                return BadRequest("no se pudo modificar la pelicula.");
            }

            return Ok("se creo correctamente");
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool creo = service.EliminarPelicula(id);
            if (creo == false)
            {
                return BadRequest("no se pudo eliminar la pelicula.");
            }

            return Ok("se elimino correctamente");
        }
    }
}
