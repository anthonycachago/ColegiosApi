using colegioDominio.Entities;
using colegioDominio.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace colegioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalificacionController : ControllerBase
    {
        private readonly ICalificacionRepository _calificacionRepository;

        public CalificacionController(ICalificacionRepository calificacionRepository)
        {
            _calificacionRepository = calificacionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Calificacion>>> GetCalificacion()
        {
            var calificacion = await _calificacionRepository.GetAllAsync();
            return Ok(calificacion);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Calificacion>> GetCalificacion(int id)
        {
            var calificacion = await _calificacionRepository.GetByIdAsync(id);

            if (calificacion == null)
            {
                return NotFound();
            }

            return Ok(calificacion);
        }

        [HttpPost]
        public async Task<ActionResult<Calificacion>> PostCalificacion(Calificacion calificacion)
        {
            await _calificacionRepository.AddAsync(calificacion);
            return CreatedAtAction(nameof(GetCalificacion), new { id = calificacion.Id }, calificacion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalificacion(int id, Calificacion calificacion)
        {
            if (id != calificacion.Id)
            {
                return BadRequest();
            }

            await _calificacionRepository.UpdateAsync(calificacion);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalificacion(int id)
        {
            await _calificacionRepository.DeleteAsync(id);
            return NoContent();
        }
    }


}
