using colegioDominio.Entities;
using colegioDominio.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace colegioApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MateriaController : ControllerBase
    {
        private readonly IMateriaRepository _materiaRepository;

        public MateriaController(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> GetMateria()
        {
            var materia = await _materiaRepository.GetAllAsync();
            return Ok(materia);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Materia>> GetMateria(int id)
        {
            var materia = await _materiaRepository.GetByIdAsync(id);

            if (materia == null)
            {
                return NotFound();
            }

            return Ok(materia);
        }

        [HttpPost]
        public async Task<ActionResult<Materia>> PostMateria(Materia materia)
        {
            await _materiaRepository.AddAsync(materia);
            return CreatedAtAction(nameof(GetMateria), new { id = materia.Id }, materia);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateria(int id, Materia materia)
        {
            if (id != materia.Id)
            {
                return BadRequest();
            }

            await _materiaRepository.UpdateAsync(materia);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateria(int id)
        {
            await _materiaRepository.DeleteAsync(id);
            return NoContent();
        }
    }

    

}
