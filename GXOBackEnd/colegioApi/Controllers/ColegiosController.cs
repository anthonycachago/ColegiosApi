using colegioDominio.Entities;
using colegioDominio.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace colegioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColegiosController : ControllerBase
    {
        private readonly IColegioRepository _colegioRepository;

        public ColegiosController(IColegioRepository colegioRepository)
        {
            _colegioRepository = colegioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Colegios>>> GetColegios()
        {
            var colegios = await _colegioRepository.GetAllAsync();
            return Ok(colegios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Colegios>> GetColegio(int id)
        {
            var colegio = await _colegioRepository.GetByIdAsync(id);

            if (colegio == null)
            {
                return NotFound();
            }

            return Ok(colegio);
        }

        [HttpPost]
        public async Task<ActionResult<Colegios>> PostColegio(Colegios colegio)
        {
            await _colegioRepository.AddAsync(colegio);
            return CreatedAtAction(nameof(GetColegio), new { id = colegio.Id }, colegio);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutColegio(int id, Colegios colegio)
        {
            if (id != colegio.Id)
            {
                return BadRequest();
            }

            await _colegioRepository.UpdateAsync(colegio);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColegio(int id)
        {
            await _colegioRepository.DeleteAsync(id);
            return NoContent();
        }
    }

}
