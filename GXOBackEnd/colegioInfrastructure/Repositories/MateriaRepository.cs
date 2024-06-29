using colegioDominio.Entities;
using colegioDominio.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colegioInfrastructure.Repositories
{
    public class MateriaRepository : IMateriaRepository
    {
        private readonly ColegioDbContext _context;

        public MateriaRepository(ColegioDbContext context)
        {
            _context = context;
        }

        public async Task<Materia> GetByIdAsync(int id)
        {
            return await _context.Materias.FindAsync(id);
        }

        public async Task<IEnumerable<Materia>> GetAllAsync()
        {
            return await _context.Materias.ToListAsync();
        }

        public async Task AddAsync(Materia materia)
        {
            _context.Materias.Add(materia);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Materia materia)
        {
            _context.Materias.Update(materia);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var materia = await _context.Materias.FindAsync(id);
            if (materia != null)
            {
                _context.Materias.Remove(materia);
                await _context.SaveChangesAsync();
            }
        }
    }

    

}
