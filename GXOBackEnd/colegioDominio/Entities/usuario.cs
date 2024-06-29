using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colegioDominio.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CorreoElectronico { get; set; }
        public string Rol { get; set; }
        public ICollection<Calificacion>? Calificaciones { get; set; }
    }
}
