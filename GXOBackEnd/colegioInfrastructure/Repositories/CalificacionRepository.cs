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
    public class CalificacionRepository : ICalificacionRepository
    {
        private readonly ColegioDbContext _context;

        public CalificacionRepository(ColegioDbContext context)
        {
            _context = context;
        }

        public async Task<Calificacion> GetByIdAsync(int id)
        {
            return await _context.Calificaciones.FindAsync(id);
        }

        public async Task<IEnumerable<Calificacion>> GetAllAsync()
        {
            return await _context.Calificaciones.ToListAsync();
        }

        public async Task AddAsync(Calificacion calificacion)
        {
            _context.Calificaciones.Add(calificacion);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Calificacion calificacion)
        {
            _context.Calificaciones.Update(calificacion);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var calificacion = await _context.Calificaciones.FindAsync(id);
            if (calificacion != null)
            {
                _context.Calificaciones.Remove(calificacion);
                await _context.SaveChangesAsync();
            }
        }
    }

  

}
