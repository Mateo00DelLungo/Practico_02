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
                var value = app.GetAllArticulo();
                if(value == null) 
                {
                    return StatusCode(500, "No existen registros en la base de datos");
                }
                return Ok(value);
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
                return BadRequest("Código no valido");
            try
            {
                var value = app.GetByIdArticulo(id);
                if (value == null) 
                    return NotFound($"No existe ningun articulo con el id: [{id}]");
                return Ok(value.ToString());
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
                return BadRequest("Articulo no valido, chequee los datos, para crear un articulo el id debe ser 0");
            }
            try
            {
                if (app.SaveArticulo(value))
                {
                    return Ok($"Articulo: [{value.Nombre} - ${value.PrecioUnitario}] guardado con exito");
                }
                else return StatusCode(500, "Error al insertar en la base de datos");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error Interno: {ex}");
            }
        }

        // PUT api/<ArticulosController>/5
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ArticuloDTO value)
        {
            if(id <= 0) { return BadRequest("Id no válido"); }
            try
            {
                if(app.UpdateArticulo(id, value))
                {
                    return Ok($"Articulo: [{id}] actualizado con exito");
                }
                else
                {
                    return NotFound($"No existe o no se ha encontrado un articulo con el id: [{id}]");
                }
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
                if (app.DeleteArticulo(id))
                {
                    return Ok($"Se ha borrado el articulo: [{id}] con exito");
                }
                else
                {
                    return StatusCode(500,"Error en la base de datos, no existe el articulo o se borraron varios registros");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500,$"Error Interno: {ex}");
            }
        }
    }
}
