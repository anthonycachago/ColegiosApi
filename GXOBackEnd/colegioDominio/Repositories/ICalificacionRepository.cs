using colegioDominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colegioDominio.Repositories
{
    public interface ICalificacionRepository
    {
        Task<Calificacion> GetByIdAsync(int id);
        Task<IEnumerable<Calificacion>> GetAllAsync();
        Task AddAsync(Calificacion calificacion);
        Task UpdateAsync(Calificacion calificacion);
        Task DeleteAsync(int id);
    }

    // Similar interfaces for Materia, Calificacion, and Usuario

}
