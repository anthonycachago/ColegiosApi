﻿using colegioDominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colegioDominio.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetByIdAsync(int id);
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task AddAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
        Task DeleteAsync(int id);
    }

    

}
