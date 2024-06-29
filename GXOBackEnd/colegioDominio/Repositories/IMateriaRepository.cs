using colegioDominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colegioDominio.Repositories
{
    public interface IMateriaRepository
    {
        Task<Materia> GetByIdAsync(int id);
        Task<IEnumerable<Materia>> GetAllAsync();
        Task AddAsync(Materia materia);
        Task UpdateAsync(Materia materia);
        Task DeleteAsync(int id);
    }



}
