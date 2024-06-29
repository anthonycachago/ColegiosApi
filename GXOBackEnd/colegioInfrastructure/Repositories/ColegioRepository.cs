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
    public class ColegioRepository : IColegioRepository
    {
        private readonly ColegioDbContext _context;

        public ColegioRepository(ColegioDbContext context)
        {
            _context = context;
        }

        public async Task<Colegios> GetByIdAsync(int id)
        {
            return await _context.Colegios.FindAsync(id);
        }

        public async Task<IEnumerable<Colegios>> GetAllAsync()
        {
            return await _context.Colegios.ToListAsync();
        }

        public async Task AddAsync(Colegios colegio)
        {
            _context.Colegios.Add(colegio);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Colegios colegio)
        {
            _context.Colegios.Update(colegio);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var colegio = await _context.Colegios.FindAsync(id);
            if (colegio != null)
            {
                _context.Colegios.Remove(colegio);
                await _context.SaveChangesAsync();
            }
        }
    }

    

}
