using colegioDominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colegioDominio.Repositories
{
    public interface IColegioRepository
    {
        Task<Colegios> GetByIdAsync(int id);
        Task<IEnumerable<Colegios>> GetAllAsync();
        Task AddAsync(Colegios colegio);
        Task UpdateAsync(Colegios colegio);
        Task DeleteAsync(int id);
    }



}
