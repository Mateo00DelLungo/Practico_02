using Microsoft.AspNetCore.Mvc;
using Proyecto_Practica_02_.Models;
using Proyecto_Practica_02_.Services;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_Practica_02_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly IAplicacion app;
        public ArticulosController()
        {
            app = new ArticuloService();
        }
        // GET: api/<ArticulosController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(app.GetAllArticulo());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error Interno: {ex}");
            }
        }
        // GET api/<ArticulosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {   
            if(id <= 0)
                return BadRequest("Id no valido");
            try
            {
                return Ok(app.GetByIdArticulo(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500,$"Error Interno: {ex}");
            }
        }

        // POST api/<ArticulosController>
        [HttpPost]
        public IActionResult Post([FromBody] ArticuloDTO value)
        {
            if (!ArticuloDTO.Validar(value) || value.Id != 0)
            {
                return BadRequest("Articulo no valido, chequee los datos");
            }
            try
            {
                if (app.SaveArticulo(value))
                {
                    return Ok("Articulo: " + value.ToString() + " guardado con exito");
                }
                else return StatusCode(500, "Error al insertar en la base de datos");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error Interno: {ex}");
            }
        }

        // PUT api/<ArticulosController>/5
        ////////
        ///TO DO
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ArticuloDTO value)
        {
            try
            {
                return Ok(app.UpdateArticulo(value));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error Interno: {ex}");
            }
        }

        // DELETE api/<ArticulosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Id no valido"); 
            try
            {
                return Ok(app.DeleteArticulo(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500,$"Error Interno: {ex}");
            }
        }
    }
}
